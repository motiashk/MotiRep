# Framework-Specific Netlify Configurations

This directory contains example `netlify.toml` configurations for popular frameworks.

## 🎯 Available Examples

- [React (Create React App)](#react-create-react-app)
- [React (Vite)](#react-vite)
- [Vue.js](#vuejs)
- [Next.js](#nextjs)
- [Angular](#angular)
- [Svelte/SvelteKit](#sveltesveltekit)
- [Nuxt.js](#nuxtjs)
- [Hugo](#hugo)
- [Gatsby](#gatsby)

## React (Create React App)

```toml
[build]
  command = "npm run build"
  publish = "build"

[build.environment]
  NODE_VERSION = "18"
  REACT_APP_API_URL = "https://api.example.com"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

## React (Vite)

```toml
[build]
  command = "npm run build"
  publish = "dist"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200

[dev]
  command = "npm run dev"
  targetPort = 5173
```

## Vue.js

```toml
[build]
  command = "npm run build"
  publish = "dist"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

## Next.js

### Option 1: Static Export

```toml
[build]
  command = "npm run build && npm run export"
  publish = "out"

[build.environment]
  NODE_VERSION = "18"
```

### Option 2: With Next.js Runtime (Recommended)

```toml
[build]
  command = "npm run build"
  publish = ".next"

[build.environment]
  NODE_VERSION = "18"

[[plugins]]
  package = "@netlify/plugin-nextjs"
```

Install plugin:
```bash
npm install -D @netlify/plugin-nextjs
```

## Angular

```toml
[build]
  command = "npm run build -- --configuration production"
  publish = "dist/your-app-name"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

## Svelte/SvelteKit

### Svelte

```toml
[build]
  command = "npm run build"
  publish = "build"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

### SvelteKit

```toml
[build]
  command = "npm run build"
  publish = "build"

[build.environment]
  NODE_VERSION = "18"

[[plugins]]
  package = "@sveltejs/adapter-netlify"
```

Install adapter:
```bash
npm install -D @sveltejs/adapter-netlify
```

Update `svelte.config.js`:
```javascript
import adapter from '@sveltejs/adapter-netlify';

export default {
  kit: {
    adapter: adapter()
  }
};
```

## Nuxt.js

### Nuxt 3

```toml
[build]
  command = "npm run build"
  publish = ".output/public"

[build.environment]
  NODE_VERSION = "18"
```

### Nuxt 2

```toml
[build]
  command = "npm run generate"
  publish = "dist"

[build.environment]
  NODE_VERSION = "18"
```

## Hugo

```toml
[build]
  command = "hugo --gc --minify"
  publish = "public"

[build.environment]
  HUGO_VERSION = "0.120.0"
  HUGO_ENV = "production"

[context.deploy-preview]
  command = "hugo --gc --minify --buildFuture -b $DEPLOY_PRIME_URL"

[context.branch-deploy]
  command = "hugo --gc --minify -b $DEPLOY_PRIME_URL"
```

## Gatsby

```toml
[build]
  command = "npm run build"
  publish = "public"

[build.environment]
  NODE_VERSION = "18"
  GATSBY_EXPERIMENTAL_PAGE_BUILD_ON_DATA_CHANGES = "true"

[[plugins]]
  package = "netlify-plugin-gatsby-cache"
```

Install cache plugin:
```bash
npm install -D netlify-plugin-gatsby-cache
```

## Jekyll

```toml
[build]
  command = "jekyll build"
  publish = "_site"

[build.environment]
  RUBY_VERSION = "3.1.0"
  JEKYLL_ENV = "production"
```

## Astro

```toml
[build]
  command = "npm run build"
  publish = "dist"

[build.environment]
  NODE_VERSION = "18"
```

## Remix

```toml
[build]
  command = "npm run build"
  publish = "public"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/.netlify/functions/server"
  status = 200
```

## Eleventy (11ty)

```toml
[build]
  command = "npm run build"
  publish = "_site"

[build.environment]
  NODE_VERSION = "18"
```

## Docusaurus

```toml
[build]
  command = "npm run build"
  publish = "build"

[build.environment]
  NODE_VERSION = "18"

[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200
```

## VitePress

```toml
[build]
  command = "npm run docs:build"
  publish = ".vitepress/dist"

[build.environment]
  NODE_VERSION = "18"
```

## Additional Tips

### Build Optimization

Add caching plugin for faster builds:
```toml
[[plugins]]
  package = "netlify-plugin-cache"

[[plugins.inputs]]
  paths = [
    "node_modules",
    ".cache"
  ]
```

### Environment-Specific Commands

```toml
[context.production]
  command = "npm run build:prod"
  
[context.deploy-preview]
  command = "npm run build:preview"
  
[context.branch-deploy]
  command = "npm run build:dev"
```

### Custom Headers for SPAs

```toml
[[headers]]
  for = "/*.js"
  [headers.values]
    Cache-Control = "public, max-age=31536000, immutable"

[[headers]]
  for = "/index.html"
  [headers.values]
    Cache-Control = "no-cache"
```

## More Information

- [Netlify Build Configuration](https://docs.netlify.com/configure-builds/file-based-configuration/)
- [Framework Detection](https://docs.netlify.com/configure-builds/get-started/#framework-detection)
- [Build Plugins](https://docs.netlify.com/configure-builds/build-plugins/)
