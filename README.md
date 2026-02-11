# MotiRep

This repository contains a Copilot authentication status logging system.

## CopilotAuthLogger

A .NET console application that demonstrates Copilot authentication and status logging functionality.

### Features

- **CopilotUserData**: Represents user authentication data in the Conversations.Abstractions.Auth namespace
- **CopilotClient**: Manages Copilot client operations and user data retrieval
- **CopilotModels**: Handles environment variable checks (COPILOT_USE_DEFAULTPROXY)
- **CopilotAuthStatus**: Reports authentication and badge status
- **CopilotClientManager**: Manages model list fetching with timestamps

### Running the Application

```bash
cd CopilotAuthLogger
dotnet run
```

### Expected Output

```
[Conversations Information] [CopilotClient] Copilot Internal User response: Conversations.Abstractions.Auth.CopilotUserData
[Conversations Information] [CopilotModels] Environment variable COPILOT_USE_DEFAULTPROXY found: False
[Conversations Information] Copilot auth status: OK. Copilot badge status: Active
[CopilotClientManager Information] CopilotClientManager: model list fetched as of 11/02/2026 09:49:13.
```
