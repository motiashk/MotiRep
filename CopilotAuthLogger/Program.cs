using Copilot;

// Create instances and execute the logging sequence
var copilotClient = new CopilotClient();
var copilotModels = new CopilotModels();
var copilotAuthStatus = new CopilotAuthStatus();
var copilotClientManager = new CopilotClientManager();

// Execute the operations to produce the log output
copilotClient.GetUserData();
copilotModels.CheckEnvironmentVariables();
copilotAuthStatus.LogAuthStatus(AuthStatus.OK, BadgeStatus.Active);
copilotClientManager.FetchModelList();
