# Netlify Functions Examples

This directory contains serverless functions that run on Netlify's infrastructure.

## 📖 Overview

Netlify Functions allow you to run server-side code without managing servers. They're perfect for:
- API endpoints
- Form processing
- Authentication
- Database queries
- Third-party API integrations

## 🚀 Usage

Functions are automatically deployed when you deploy your site. They're accessible at:

```
https://your-site.netlify.app/.netlify/functions/function-name
```

## 📁 File Structure

```
netlify/
  functions/
    hello.js          # Example function
    api.js            # Your custom functions
    [name].js         # Each file = one function endpoint
```

## 💡 Examples

### Basic Function (hello.js)

**Request:**
```bash
curl https://your-site.netlify.app/.netlify/functions/hello?name=World
```

**Response:**
```json
{
  "message": "Hello, World!",
  "timestamp": "2024-01-01T00:00:00.000Z",
  "method": "GET"
}
```

### POST Request

```bash
curl -X POST \
  https://your-site.netlify.app/.netlify/functions/hello \
  -H 'Content-Type: application/json' \
  -d '{"name":"John","email":"john@example.com"}'
```

## 🔧 Development

### Local Testing

```bash
# Install Netlify CLI
npm install -g netlify-cli

# Run functions locally
netlify dev

# Test function
curl http://localhost:8888/.netlify/functions/hello
```

### Environment Variables

Access environment variables in your functions:

```javascript
exports.handler = async (event, context) => {
  const apiKey = process.env.API_KEY;
  // Use apiKey...
};
```

Set environment variables in Netlify UI:
- Site Settings → Build & Deploy → Environment

## 📚 Function Structure

```javascript
exports.handler = async (event, context) => {
  // event object contains:
  // - httpMethod: GET, POST, etc.
  // - headers: request headers
  // - queryStringParameters: URL query params
  // - body: request body (for POST/PUT)
  // - path: request path
  
  // context object contains:
  // - clientContext: identity/user info
  // - functionName: name of the function
  
  return {
    statusCode: 200,
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify({ message: 'Success' }),
  };
};
```

## 🎯 Common Use Cases

### 1. API Proxy

```javascript
exports.handler = async (event) => {
  const response = await fetch('https://api.example.com/data', {
    headers: {
      'Authorization': `Bearer ${process.env.API_KEY}`
    }
  });
  const data = await response.json();
  
  return {
    statusCode: 200,
    body: JSON.stringify(data),
  };
};
```

### 2. Form Submission

```javascript
exports.handler = async (event) => {
  if (event.httpMethod !== 'POST') {
    return { statusCode: 405, body: 'Method Not Allowed' };
  }
  
  const data = JSON.parse(event.body);
  
  // Process form data
  // Send email, save to database, etc.
  
  return {
    statusCode: 200,
    body: JSON.stringify({ success: true }),
  };
};
```

### 3. Database Query

```javascript
const { MongoClient } = require('mongodb');

exports.handler = async (event) => {
  const client = await MongoClient.connect(process.env.MONGODB_URI);
  const db = client.db('mydb');
  const data = await db.collection('items').find().toArray();
  await client.close();
  
  return {
    statusCode: 200,
    body: JSON.stringify(data),
  };
};
```

## 🔒 Security

1. **Never expose secrets in client code**
   - Use environment variables
   - Access them only in functions

2. **Validate input**
   ```javascript
   if (!event.body) {
     return { statusCode: 400, body: 'Missing body' };
   }
   ```

3. **Enable CORS selectively**
   ```javascript
   headers: {
     'Access-Control-Allow-Origin': 'https://yourdomain.com',
   }
   ```

4. **Rate limiting**
   - Use Netlify's built-in rate limiting
   - Or implement your own logic

## 📊 Limits

- **Execution time**: 10 seconds (can be increased to 26s on Pro plans)
- **Memory**: 1024 MB
- **Payload size**: 6 MB
- **Invocations**: 125,000/month on free tier

## 📖 Documentation

- [Netlify Functions Docs](https://docs.netlify.com/functions/overview/)
- [Function Examples](https://functions.netlify.com/examples/)
- [Netlify CLI](https://cli.netlify.com/)

## 🆘 Troubleshooting

**Function not working?**
1. Check function logs in Netlify dashboard
2. Test locally with `netlify dev`
3. Verify function name matches filename
4. Check for syntax errors

**Environment variables not available?**
1. Set them in Netlify UI
2. Redeploy after adding variables
3. Don't use `REACT_APP_` prefix for functions

**Timeout errors?**
1. Optimize function performance
2. Use async/await properly
3. Consider background functions for long tasks
