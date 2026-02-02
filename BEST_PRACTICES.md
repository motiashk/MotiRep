# Netlify Best Practices & Tips

A collection of best practices, tips, and recommendations for deploying to Netlify.

## 🏗️ Build Optimization

### 1. Use Build Caching

Install the cache plugin to speed up builds:

```bash
npm install -D netlify-plugin-cache
```

Add to `netlify.toml`:
```toml
[[plugins]]
  package = "netlify-plugin-cache"
  
  [plugins.inputs]
    paths = [
      "node_modules",
      ".cache",
      "public"
    ]
```

### 2. Optimize Dependencies

```bash
# Use npm ci for faster, more reliable installs
npm ci

# In netlify.toml
[build]
  command = "npm ci && npm run build"
```

### 3. Minimize Build Output

Only deploy what's necessary:
```bash
# .gitignore
node_modules/
*.log
.DS_Store

# Don't include source files in output
src/
tests/
```

### 4. Set Explicit Node Version

```toml
[build.environment]
  NODE_VERSION = "18"
  NPM_VERSION = "9.6.0"
```

### 5. Use Build Time Limits Wisely

Monitor build times and optimize:
- Remove unused dependencies
- Use code splitting
- Optimize image processing
- Parallelize build tasks

## 🚀 Performance Optimization

### 1. Set Optimal Cache Headers

```toml
# Long-term cache for immutable assets
[[headers]]
  for = "/*.js"
  [headers.values]
    Cache-Control = "public, max-age=31536000, immutable"

[[headers]]
  for = "/*.css"
  [headers.values]
    Cache-Control = "public, max-age=31536000, immutable"

# No cache for HTML
[[headers]]
  for = "/*.html"
  [headers.values]
    Cache-Control = "public, max-age=0, must-revalidate"
```

### 2. Enable Asset Optimization

In Netlify UI:
- Site Settings → Build & Deploy → Post processing
- ✅ Bundle CSS
- ✅ Minify CSS
- ✅ Minify JS
- ✅ Compress images

### 3. Use Code Splitting

Frameworks like React, Vue, and Next.js support automatic code splitting:

```javascript
// React lazy loading
const Component = React.lazy(() => import('./Component'));

// Dynamic imports
const module = await import('./module.js');
```

### 4. Optimize Images

```toml
# Use Netlify Large Media for Git LFS
[[plugins]]
  package = "netlify-plugin-git-lfs"

# Or use Image CDN
[[plugins]]
  package = "@netlify/plugin-image-optim"
```

### 5. Implement Preloading

```html
<!-- Preload critical assets -->
<link rel="preload" href="/critical.css" as="style">
<link rel="preload" href="/critical.js" as="script">
```

## 🔒 Security Best Practices

### 1. Set Security Headers

```toml
[[headers]]
  for = "/*"
  [headers.values]
    # Prevent clickjacking
    X-Frame-Options = "DENY"
    
    # Prevent MIME sniffing
    X-Content-Type-Options = "nosniff"
    
    # XSS Protection
    X-XSS-Protection = "1; mode=block"
    
    # Referrer Policy
    Referrer-Policy = "strict-origin-when-cross-origin"
    
    # Permissions Policy
    Permissions-Policy = "geolocation=(), microphone=(), camera=()"
    
    # Content Security Policy
    Content-Security-Policy = "default-src 'self'; script-src 'self' 'unsafe-inline'; style-src 'self' 'unsafe-inline';"
```

### 2. Enable HTTPS Only

In Netlify UI:
- Site Settings → Domain Management → HTTPS
- ✅ Force HTTPS
- ✅ Enable HSTS

```toml
[[headers]]
  for = "/*"
  [headers.values]
    Strict-Transport-Security = "max-age=31536000; includeSubDomains; preload"
```

### 3. Protect Sensitive Routes

```toml
# Password protect admin routes
[[redirects]]
  from = "/admin/*"
  to = "/admin/:splat"
  status = 200
  force = true
  conditions = {Role = ["admin"]}

# Protect API endpoints
[[redirects]]
  from = "/api/private/*"
  to = "/.netlify/functions/auth-check"
  status = 200
```

### 4. Use Environment Variables for Secrets

❌ **Don't:**
```javascript
const API_KEY = "sk_live_123456789";
```

✅ **Do:**
```javascript
const API_KEY = process.env.API_KEY;
```

Set in Netlify UI, not in code.

### 5. Implement Rate Limiting

```javascript
// In Netlify Function
const rateLimit = require('express-rate-limit');

exports.handler = async (event, context) => {
  // Implement rate limiting logic
  // Or use third-party service like Cloudflare
};
```

## 🌐 Deployment Strategies

### 1. Branch Deploys

```toml
# Deploy all branches
[context.branch-deploy]
  command = "npm run build"

# Or specific branches only
[context.staging]
  command = "npm run build:staging"
```

### 2. Deploy Previews

Enable in Netlify UI:
- Site Settings → Build & Deploy → Deploy contexts
- ✅ Deploy Previews: Automatically build deploy previews for all pull requests

### 3. Atomic Deploys

Netlify deploys atomically - new version is live only when complete:
- No partial updates
- Instant rollback available
- Zero downtime

### 4. Split Testing

```toml
# A/B test different versions
[build]
  publish = "dist"

[context.split-test]
  publish = "dist-variant"
```

Enable in Netlify UI:
- Site Settings → Split Testing

### 5. Rollback Strategy

In Netlify UI:
1. Go to Deploys
2. Find previous working deploy
3. Click "Publish deploy"
4. Instant rollback

## 📊 Monitoring & Analytics

### 1. Enable Netlify Analytics

- No client-side code needed
- Privacy-friendly
- Server-side metrics

In Netlify UI:
- Site Settings → Analytics → Enable

### 2. Build Notifications

Set up notifications for:
- Deploy succeeded
- Deploy failed
- Build warnings

Options:
- Email
- Slack
- Webhooks
- GitHub checks

### 3. Monitor Build Times

```bash
# View build logs
netlify deploy --build

# Check previous builds
netlify deploys:list
```

### 4. Use Structured Logging

```javascript
// In Netlify Functions
console.log(JSON.stringify({
  level: 'info',
  message: 'Function executed',
  userId: user.id,
  timestamp: new Date().toISOString()
}));
```

### 5. Set Up Uptime Monitoring

Use external services:
- UptimeRobot
- Pingdom
- StatusCake
- Better Uptime

## 🎯 Development Workflow

### 1. Local Development

```bash
# Install Netlify CLI
npm install -g netlify-cli

# Run locally with functions
netlify dev

# Test production build
netlify build
```

### 2. Environment-Specific Config

```toml
[context.production.environment]
  NODE_ENV = "production"
  API_URL = "https://api.example.com"

[context.deploy-preview.environment]
  NODE_ENV = "preview"
  API_URL = "https://preview-api.example.com"

[context.dev.environment]
  NODE_ENV = "development"
  API_URL = "http://localhost:3001"
```

### 3. Use Git Hooks

```bash
# .husky/pre-commit
npm run lint
npm run test
```

### 4. Automate Testing

```toml
[build]
  command = "npm run test && npm run build"
```

Or use GitHub Actions for more control.

### 5. Document Everything

Keep updated:
- README.md - Project overview
- DEPLOYMENT.md - Deployment instructions
- .env.example - Required environment variables
- CHANGELOG.md - Version history

## 💡 Cost Optimization

### 1. Optimize Build Minutes

- Use build caching
- Minimize dependencies
- Skip unnecessary steps
- Use conditional builds

```bash
# Only build on certain conditions
if [ "$CONTEXT" != "deploy-preview" ]; then
  npm run build
fi
```

### 2. Optimize Bandwidth

- Enable compression
- Use proper caching
- Optimize images
- Use lazy loading

### 3. Optimize Function Invocations

- Cache function responses
- Use edge caching
- Minimize function complexity
- Batch operations

### 4. Monitor Usage

Check Netlify UI:
- Site Usage → Build minutes
- Site Usage → Bandwidth
- Site Usage → Function invocations

### 5. Choose Appropriate Plan

- **Starter (Free)**: Hobby projects
- **Pro**: Production sites
- **Business**: Team projects
- **Enterprise**: Large organizations

## 🔧 Advanced Features

### 1. Forms

```html
<form name="contact" method="POST" data-netlify="true">
  <input type="text" name="name" required />
  <input type="email" name="email" required />
  <textarea name="message"></textarea>
  <button type="submit">Send</button>
</form>
```

### 2. Identity

```javascript
// Add Netlify Identity widget
<script src="https://identity.netlify.com/v1/netlify-identity-widget.js"></script>

// Initialize
netlifyIdentity.init();
```

### 3. Large Media

For Git LFS integration:
```bash
netlify lm:install
netlify lm:setup
```

### 4. Background Functions

For long-running tasks:
```javascript
// netlify/functions/background.js
exports.handler = async (event, context) => {
  // Task takes > 10 seconds
  // Runs in background
};
```

### 5. Edge Functions

For lightning-fast responses:
```javascript
// netlify/edge-functions/hello.js
export default () => new Response("Hello from the edge!");
```

## 📚 Additional Resources

### Documentation
- [Netlify Docs](https://docs.netlify.com/)
- [Build Configuration](https://docs.netlify.com/configure-builds/file-based-configuration/)
- [Deploy Contexts](https://docs.netlify.com/site-deploys/overview/#deploy-contexts)

### Community
- [Netlify Forums](https://answers.netlify.com/)
- [Discord Community](https://discord.gg/netlify)
- [GitHub Discussions](https://github.com/netlify/discussions)

### Learning
- [Jamstack](https://jamstack.org/)
- [Netlify Blog](https://www.netlify.com/blog/)
- [YouTube Channel](https://www.youtube.com/netlify)

## 🎓 Key Takeaways

1. ✅ Always use version control
2. ✅ Set explicit Node versions
3. ✅ Use environment variables for secrets
4. ✅ Enable security headers
5. ✅ Implement proper caching
6. ✅ Test locally before deploying
7. ✅ Monitor build and runtime metrics
8. ✅ Document your deployment process
9. ✅ Use deploy previews for PRs
10. ✅ Keep dependencies updated

---

**Happy Deploying!** 🚀
