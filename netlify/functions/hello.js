// Example Netlify Function
// This function demonstrates how to create serverless functions on Netlify
// Deploy path: /.netlify/functions/hello

exports.handler = async (event, context) => {
  // Log request information
  console.log('Request:', {
    path: event.path,
    httpMethod: event.httpMethod,
    headers: event.headers,
    queryStringParameters: event.queryStringParameters,
  });

  // Get query parameters
  const { name = 'World' } = event.queryStringParameters || {};

  // Handle different HTTP methods
  if (event.httpMethod === 'GET') {
    return {
      statusCode: 200,
      headers: {
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*', // Enable CORS
      },
      body: JSON.stringify({
        message: `Hello, ${name}!`,
        timestamp: new Date().toISOString(),
        method: event.httpMethod,
      }),
    };
  }

  if (event.httpMethod === 'POST') {
    let data;
    try {
      data = JSON.parse(event.body);
    } catch (error) {
      return {
        statusCode: 400,
        body: JSON.stringify({ error: 'Invalid JSON' }),
      };
    }

    return {
      statusCode: 200,
      headers: {
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*',
      },
      body: JSON.stringify({
        message: 'Data received',
        data: data,
        timestamp: new Date().toISOString(),
      }),
    };
  }

  // Handle unsupported methods
  return {
    statusCode: 405,
    body: JSON.stringify({ error: 'Method Not Allowed' }),
  };
};
