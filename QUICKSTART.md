# Quick Start Guide for Netlify Deployment

This is a condensed guide to get you deploying to Netlify in minutes.

## 🚀 5-Minute Deployment

### Option 1: UI Deployment (Easiest)

1. **Go to Netlify**: Visit [app.netlify.com](https://app.netlify.com)
2. **Sign up/Login**: Use GitHub, GitLab, Bitbucket, or email
3. **Add Site**: Click "Add new site" → "Import an existing project"
4. **Connect Repo**: Select your repository
5. **Configure Build**:
   ```
   Build command: npm run build
   Publish directory: dist
   ```
6. **Deploy**: Click "Deploy site"

✅ Done! Your site is live at `random-name.netlify.app`

### Option 2: CLI Deployment (For Developers)

```bash
# 1. Install Netlify CLI
npm install -g netlify-cli

# 2. Login
netlify login

# 3. Initialize (first time only)
netlify init

# 4. Deploy to production
netlify deploy --prod
```

✅ Done! Your site is deployed.

## 🔧 Common Framework Setups

### React (Create React App)
```bash
# Build command
npm run build

# Publish directory
build
```

### React (Vite)
```bash
# Build command
npm run build

# Publish directory
dist
```

### Next.js
```bash
# Install plugin
npm install -D @netlify/plugin-nextjs

# Build command
npm run build

# Publish directory
.next
```

### Vue.js
```bash
# Build command
npm run build

# Publish directory
dist
```

### Angular
```bash
# Build command
npm run build -- --configuration production

# Publish directory
dist/[your-app-name]
```

## 🌐 Environment Variables

### Add via UI
1. Site Settings → Build & Deploy → Environment
2. Click "Edit variables"
3. Add key-value pairs
4. Redeploy

### Framework-Specific Prefixes
- **React**: `REACT_APP_API_KEY`
- **Vite**: `VITE_API_URL`
- **Next.js**: `NEXT_PUBLIC_API_KEY`
- **Nuxt**: `NUXT_PUBLIC_API_URL`

## 📁 Essential Files

### netlify.toml (optional but recommended)
```toml
[build]
  command = "npm run build"
  publish = "dist"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

### .gitignore
```
node_modules/
dist/
.env
.netlify/
```

## 🔄 Continuous Deployment

Once connected to Git:
- ✅ Push to main branch → Auto deploy to production
- ✅ Create PR → Auto deploy preview
- ✅ Push to feature branch → Branch deploy

## 🐛 Common Issues

### Build Fails
```toml
# Add to netlify.toml
[build.environment]
  NODE_VERSION = "18"
```

### 404 on Reload (SPA)
```toml
# Add to netlify.toml
[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

### Environment Variables Not Working
1. Set in Netlify UI (not .env file)
2. Use correct framework prefix
3. Redeploy after adding

## 📞 Need Help?

- 📖 [Full Documentation](DEPLOYMENT.md)
- 🎯 [Framework Examples](examples/FRAMEWORKS.md)
- 💬 [Netlify Forums](https://answers.netlify.com/)
- 📚 [Official Docs](https://docs.netlify.com/)

## ⚡ Pro Tips

1. **Test Locally First**
   ```bash
   netlify dev
   ```

2. **Preview Before Production**
   ```bash
   netlify deploy  # Preview
   netlify deploy --prod  # Production
   ```

3. **Check Build Logs**
   - Go to Deploys in Netlify UI
   - Click on failed deploy
   - Read error messages

4. **Use Build Cache**
   ```toml
   [[plugins]]
     package = "netlify-plugin-cache"
   ```

5. **Set Up Custom Domain**
   - Site Settings → Domain Management
   - Add custom domain
   - Follow DNS instructions

## 🎉 Next Steps

After deployment:
- [ ] Set up custom domain
- [ ] Configure environment variables
- [ ] Enable deploy previews
- [ ] Add form handling (if needed)
- [ ] Set up Netlify Functions (if needed)
- [ ] Configure analytics

---

**Time to deploy?** Choose your method above and get started! 🚀
