# Netlify Deployment Guide

This guide provides comprehensive instructions for deploying your project to Netlify.

## Table of Contents
- [Quick Start](#quick-start)
- [Prerequisites](#prerequisites)
- [Deployment Methods](#deployment-methods)
- [Configuration](#configuration)
- [Environment Variables](#environment-variables)
- [Common Frameworks](#common-frameworks)
- [Custom Domains](#custom-domains)
- [Troubleshooting](#troubleshooting)
- [Best Practices](#best-practices)

## Quick Start

### Method 1: Deploy via Netlify UI (Recommended for First Time)

1. **Sign up/Login to Netlify**
   - Visit [netlify.com](https://netlify.com)
   - Sign up with GitHub, GitLab, Bitbucket, or email

2. **Connect Your Repository**
   - Click "Add new site" → "Import an existing project"
   - Authorize Netlify to access your Git provider
   - Select your repository

3. **Configure Build Settings**
   - Build command: `npm run build` (or your build command)
   - Publish directory: `dist` (or `build`, `out`, `public`, etc.)
   - Click "Deploy site"

4. **Wait for Deployment**
   - Netlify will build and deploy your site
   - You'll get a random subdomain like `random-name-123.netlify.app`

### Method 2: Deploy via Netlify CLI

```bash
# Install Netlify CLI globally
npm install -g netlify-cli

# Login to Netlify
netlify login

# Initialize Netlify in your project
netlify init

# Deploy manually
netlify deploy

# Deploy to production
netlify deploy --prod
```

### Method 3: Deploy with Drag & Drop

1. Build your project locally
2. Go to [app.netlify.com/drop](https://app.netlify.com/drop)
3. Drag and drop your build folder

## Prerequisites

### Required
- A Git repository (GitHub, GitLab, or Bitbucket)
- A build command that generates static files
- Node.js installed (for npm/yarn projects)

### Optional
- Netlify CLI for local testing
- Custom domain name
- Environment variables for API keys

## Deployment Methods

### Continuous Deployment (Recommended)

Netlify automatically deploys when you push to your repository:

1. **Connect Repository**: Link your Git repo to Netlify
2. **Configure Build**: Set build command and publish directory
3. **Auto Deploy**: Every push triggers a new deployment
4. **Deploy Previews**: Pull requests get preview URLs

### Manual Deployment

Use Netlify CLI for manual deployments:

```bash
# Deploy draft for preview
netlify deploy

# Deploy to production
netlify deploy --prod
```

### Git Gateway Deployment

For CMS integration without direct Git access:

1. Enable Git Gateway in Site Settings → Identity
2. Configure Netlify Identity
3. Use with NetlifyCMS or other headless CMS

## Configuration

### netlify.toml

The `netlify.toml` file in your repository root configures your Netlify deployment:

```toml
[build]
  publish = "dist"
  command = "npm run build"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

### Build Settings Priority

1. `netlify.toml` (highest priority)
2. UI configuration in Netlify dashboard
3. netlify.toml in build directory
4. Default framework detection

## Environment Variables

### Adding Environment Variables

**Via Netlify UI:**
1. Go to Site Settings → Build & Deploy → Environment
2. Click "Edit variables"
3. Add key-value pairs
4. Save and redeploy

**Via netlify.toml:**
```toml
[context.production.environment]
  NODE_VERSION = "18"
  API_URL = "https://api.example.com"
```

**Via .env file (local only):**
```bash
# .env
REACT_APP_API_KEY=your_key_here
VITE_API_URL=https://api.example.com
```

### Environment Variable Scopes

- **Build-time**: Available during build (e.g., `REACT_APP_*`, `VITE_*`)
- **Runtime**: Available in Netlify Functions
- **Context-specific**: Different values for production, deploy-preview, branch-deploy

## Common Frameworks

### React (Create React App)

```toml
[build]
  command = "npm run build"
  publish = "build"
```

### Vue.js

```toml
[build]
  command = "npm run build"
  publish = "dist"
```

### Next.js

```toml
[build]
  command = "npm run build && npm run export"
  publish = "out"
```

Or use the Next.js Runtime plugin:
```toml
[build]
  command = "npm run build"
  publish = ".next"

[[plugins]]
  package = "@netlify/plugin-nextjs"
```

### Vite

```toml
[build]
  command = "npm run build"
  publish = "dist"
```

### Angular

```toml
[build]
  command = "npm run build -- --prod"
  publish = "dist/your-app-name"
```

### Svelte/SvelteKit

```toml
[build]
  command = "npm run build"
  publish = "build"
```

### Static Site Generators

**Hugo:**
```toml
[build]
  command = "hugo"
  publish = "public"

[build.environment]
  HUGO_VERSION = "0.110.0"
```

**Jekyll:**
```toml
[build]
  command = "jekyll build"
  publish = "_site"

[build.environment]
  RUBY_VERSION = "2.7.2"
```

**Gatsby:**
```toml
[build]
  command = "gatsby build"
  publish = "public"
```

## Custom Domains

### Adding a Custom Domain

1. **Purchase a domain** (from any registrar)

2. **Add domain in Netlify:**
   - Site Settings → Domain Management → Add custom domain
   - Enter your domain name

3. **Configure DNS:**

   **Option A: Use Netlify DNS (Recommended)**
   - Point nameservers to Netlify
   - Netlify manages all DNS records
   - Automatic SSL certificates

   **Option B: Use External DNS**
   - Add A record: `@` → `75.2.60.5`
   - Add CNAME: `www` → `your-site.netlify.app`

4. **Enable HTTPS:**
   - Netlify provides free SSL certificates
   - Automatic renewal via Let's Encrypt

### Subdomain Setup

```
CNAME record: subdomain.yourdomain.com → your-site.netlify.app
```

## Troubleshooting

### Build Fails

**Check Node Version:**
```toml
[build.environment]
  NODE_VERSION = "18"
```

**Clear Cache:**
```bash
# In Netlify UI: Deploys → Trigger Deploy → Clear cache and deploy
```

**Check Build Logs:**
- View full build logs in Netlify dashboard
- Look for dependency issues, missing files, or build errors

### Page Not Found (404)

**For SPAs, add redirect:**
```toml
[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

### Environment Variables Not Working

- Ensure variables are set in Netlify UI
- For React: prefix with `REACT_APP_`
- For Vite: prefix with `VITE_`
- Redeploy after adding variables

### Deploy Preview Not Working

- Check branch deploy settings
- Ensure PR builds are enabled
- Verify netlify.toml is in repository root

## Best Practices

### Security

1. **Enable HTTPS Only**
   - Force HTTPS redirects in Site Settings

2. **Set Security Headers**
   ```
   /*
     X-Frame-Options: DENY
     X-Content-Type-Options: nosniff
     X-XSS-Protection: 1; mode=block
   ```

3. **Protect Sensitive Routes**
   ```toml
   [[redirects]]
     from = "/admin/*"
     to = "/admin/:splat"
     status = 200
     force = true
     conditions = {Role = ["admin"]}
   ```

### Performance

1. **Enable Asset Optimization**
   - Site Settings → Build & Deploy → Post processing
   - Enable bundle CSS, minify JS/CSS

2. **Set Cache Headers**
   ```
   /*.js
     Cache-Control: public, max-age=31536000, immutable
   ```

3. **Use Netlify CDN**
   - Automatic global CDN distribution
   - Edge caching for static assets

### Build Optimization

1. **Use Build Plugins**
   ```toml
   [[plugins]]
     package = "netlify-plugin-cache"
   ```

2. **Optimize Dependencies**
   ```bash
   # Use npm ci instead of npm install for faster builds
   ```

3. **Skip Unnecessary Files**
   - Don't commit node_modules
   - Use `.gitignore` properly

### Deployment Strategies

1. **Branch Deploys**: Preview changes on feature branches
2. **Deploy Previews**: Automatic PR preview URLs
3. **Split Testing**: A/B test different versions
4. **Rollback**: Instant rollback to previous deploys

## Additional Resources

- [Netlify Documentation](https://docs.netlify.com/)
- [Netlify Community Forum](https://answers.netlify.com/)
- [Netlify CLI Documentation](https://cli.netlify.com/)
- [Netlify Status](https://www.netlifystatus.com/)

## Support

If you encounter issues:
1. Check [Netlify Status](https://www.netlifystatus.com/)
2. Search [Netlify Forums](https://answers.netlify.com/)
3. Contact Netlify Support (Pro plans and above)
4. Check repository-specific documentation

## Next Steps

After successful deployment:
- [ ] Set up custom domain
- [ ] Configure environment variables
- [ ] Enable deploy previews for PRs
- [ ] Set up form handling (if needed)
- [ ] Configure Netlify Functions (if needed)
- [ ] Enable identity/authentication (if needed)
- [ ] Set up monitoring and analytics
