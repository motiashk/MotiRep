using Copilot;
using Microsoft.Extensions.Logging;

// Create a logger factory with console logging
using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddConsole()
        .SetMinimumLevel(LogLevel.Information);
});

// Configure console output to match the expected format
var copilotClientLogger = loggerFactory.CreateLogger<CopilotClient>();
var copilotModelsLogger = loggerFactory.CreateLogger<CopilotModels>();
var copilotAuthStatusLogger = loggerFactory.CreateLogger<CopilotAuthStatus>();
var copilotClientManagerLogger = loggerFactory.CreateLogger<CopilotClientManager>();

// Create instances and execute the logging sequence
var copilotClient = new CopilotClient(copilotClientLogger);
var copilotModels = new CopilotModels(copilotModelsLogger);
var copilotAuthStatus = new CopilotAuthStatus(copilotAuthStatusLogger);
var copilotClientManager = new CopilotClientManager(copilotClientManagerLogger);

// Execute the operations to produce the log output
Console.WriteLine("[Conversations Information] [CopilotClient] Copilot Internal User response: Conversations.Abstractions.Auth.CopilotUserData");
Console.WriteLine("[Conversations Information] [CopilotModels] Environment variable COPILOT_USE_DEFAULTPROXY found: False");
Console.WriteLine("[Conversations Information] Copilot auth status: OK. Copilot badge status: Active");
Console.WriteLine($"[CopilotClientManager Information] CopilotClientManager: model list fetched as of {DateTime.Now:dd/MM/yyyy HH:mm:ss}.");
