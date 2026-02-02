# Netlify Deployment Checklist

Use this checklist to ensure a smooth deployment to Netlify.

## 📋 Pre-Deployment Checklist

### Repository Setup
- [ ] Code is in a Git repository (GitHub, GitLab, or Bitbucket)
- [ ] `.gitignore` excludes `node_modules/`, `dist/`, and build artifacts
- [ ] Repository is up to date with latest changes
- [ ] All dependencies are listed in `package.json`
- [ ] Project builds successfully locally

### Build Configuration
- [ ] Build command is defined (e.g., `npm run build`)
- [ ] Build command succeeds locally
- [ ] Output directory is known (e.g., `dist/`, `build/`, `out/`)
- [ ] Build produces static files (HTML, CSS, JS)
- [ ] All assets are referenced with relative paths

### Environment Variables
- [ ] List all required environment variables
- [ ] Know which variables are build-time vs runtime
- [ ] Use proper prefixes for framework (e.g., `REACT_APP_`, `VITE_`)
- [ ] Sensitive values are not committed to Git
- [ ] Have values ready for production environment

### Framework-Specific
- [ ] Know your framework's build command
- [ ] Know your framework's output directory
- [ ] SPA routing configured (if applicable)
- [ ] Framework-specific plugins identified (if needed)

## 🚀 Initial Deployment

### Netlify Account Setup
- [ ] Sign up at [netlify.com](https://netlify.com)
- [ ] Verify email address
- [ ] Connect Git provider (GitHub/GitLab/Bitbucket)
- [ ] Authorize Netlify to access repositories

### Site Creation
- [ ] Click "Add new site" → "Import an existing project"
- [ ] Select Git provider
- [ ] Choose repository
- [ ] Configure build settings:
  - [ ] Build command entered
  - [ ] Publish directory entered
  - [ ] Node version specified (if needed)
- [ ] Add environment variables (if any)
- [ ] Click "Deploy site"

### First Deployment
- [ ] Wait for initial build to complete
- [ ] Check build logs for errors
- [ ] Visit preview URL (e.g., `random-name.netlify.app`)
- [ ] Test all pages and routes
- [ ] Verify assets load correctly
- [ ] Check console for errors
- [ ] Test on mobile viewport

## ⚙️ Configuration

### netlify.toml Creation
- [ ] Create `netlify.toml` in repository root
- [ ] Add build configuration
- [ ] Add redirect rules (for SPA)
- [ ] Add security headers
- [ ] Add cache headers for assets
- [ ] Commit and push to repository

### Redirect Configuration
- [ ] SPA fallback configured (if needed)
- [ ] API proxy configured (if needed)
- [ ] Custom redirects added (if needed)
- [ ] Redirect rules tested

### Security Headers
- [ ] X-Frame-Options set
- [ ] X-Content-Type-Options set
- [ ] X-XSS-Protection set
- [ ] Referrer-Policy configured
- [ ] CSP headers added (if needed)

## 🌐 Domain & SSL

### Custom Domain Setup
- [ ] Domain name purchased
- [ ] Add domain in Netlify UI
- [ ] Configure DNS records:
  - [ ] A record or CNAME added
  - [ ] DNS propagation verified (24-48 hours)
- [ ] SSL certificate provisioned
- [ ] HTTPS enabled
- [ ] Force HTTPS enabled
- [ ] Test domain works

### DNS Configuration
Choose one method:
- [ ] **Option A**: Netlify DNS (recommended)
  - [ ] Update nameservers at registrar
  - [ ] Verify nameserver update
- [ ] **Option B**: External DNS
  - [ ] Add A record: `@` → `75.2.60.5`
  - [ ] Add CNAME: `www` → `your-site.netlify.app`

## 🔄 Continuous Deployment

### Git Integration
- [ ] Repository connected to Netlify
- [ ] Production branch set (usually `main` or `master`)
- [ ] Deploy previews enabled for PRs
- [ ] Branch deploys configured
- [ ] Build hooks created (if needed)

### Deployment Triggers
- [ ] Push to production branch triggers deploy
- [ ] PR creation triggers preview deploy
- [ ] Build notifications configured (optional)

### Testing
- [ ] Push change to test auto-deploy
- [ ] Create PR to test preview deploy
- [ ] Verify deploy preview URL works
- [ ] Verify production deploy works

## 🔧 Advanced Configuration

### Netlify Functions
If using serverless functions:
- [ ] Create `netlify/functions/` directory
- [ ] Add function files
- [ ] Test functions locally with `netlify dev`
- [ ] Test functions in production
- [ ] Configure environment variables for functions

### Form Handling
If using Netlify Forms:
- [ ] Add `netlify` or `data-netlify="true"` to form
- [ ] Add hidden `form-name` field
- [ ] Configure form notifications
- [ ] Test form submission
- [ ] Set up spam filtering

### Identity & Authentication
If using Netlify Identity:
- [ ] Enable Identity in Site Settings
- [ ] Configure registration preferences
- [ ] Set up email templates
- [ ] Add Identity widget to site
- [ ] Test registration/login flow

### Analytics
- [ ] Enable Netlify Analytics (if desired)
- [ ] Add custom tracking (if needed)
- [ ] Configure third-party analytics
- [ ] Verify tracking works

## 🧪 Testing & Validation

### Functional Testing
- [ ] All pages load correctly
- [ ] All links work
- [ ] Forms submit successfully
- [ ] Images and assets load
- [ ] Videos play correctly
- [ ] Downloads work

### Cross-Browser Testing
- [ ] Test in Chrome
- [ ] Test in Firefox
- [ ] Test in Safari
- [ ] Test in Edge
- [ ] Test on mobile browsers

### Performance Testing
- [ ] Run Lighthouse audit
- [ ] Check Core Web Vitals
- [ ] Verify asset caching
- [ ] Check bundle sizes
- [ ] Test load times

### Security Testing
- [ ] Verify HTTPS works
- [ ] Check security headers
- [ ] Test CSP (if configured)
- [ ] Verify no sensitive data exposed
- [ ] Check for mixed content warnings

## 📊 Monitoring & Maintenance

### Post-Deployment
- [ ] Monitor first few deploys
- [ ] Check error logs
- [ ] Monitor build times
- [ ] Review bandwidth usage
- [ ] Set up uptime monitoring (optional)

### Ongoing Maintenance
- [ ] Regular dependency updates
- [ ] Monitor build success rate
- [ ] Review and update environment variables
- [ ] Optimize build times
- [ ] Update Node version as needed
- [ ] Review and update security headers

### Documentation
- [ ] Document build process
- [ ] Document environment variables
- [ ] Document deployment process
- [ ] Update README with deployment info
- [ ] Document rollback procedure

## 🚨 Troubleshooting Checklist

### Build Failures
- [ ] Check build logs in Netlify UI
- [ ] Verify Node version matches local
- [ ] Clear build cache and redeploy
- [ ] Check for missing environment variables
- [ ] Verify dependencies install correctly

### Runtime Issues
- [ ] Check browser console for errors
- [ ] Verify asset paths are correct
- [ ] Check redirect rules
- [ ] Verify environment variables are set
- [ ] Test in incognito/private mode

### Performance Issues
- [ ] Check bundle sizes
- [ ] Verify asset caching headers
- [ ] Optimize images
- [ ] Enable lazy loading
- [ ] Use CDN for assets

## ✅ Deployment Complete Checklist

Final verification:
- [ ] Site is accessible via custom domain
- [ ] All pages load without errors
- [ ] Forms work correctly
- [ ] Analytics tracking works
- [ ] Security headers verified
- [ ] Performance is acceptable
- [ ] Mobile experience is good
- [ ] SEO basics in place
- [ ] Documentation updated
- [ ] Team notified of deployment

## 📝 Notes

Use this space to track deployment-specific information:
- Site URL: _______________
- Netlify Site ID: _______________
- Deploy frequency: _______________
- Last deployment: _______________
- Known issues: _______________

---

**Congratulations!** 🎉 Your site is deployed to Netlify!
