using Conversations.Abstractions.Auth;
using Microsoft.Extensions.Logging;

namespace Copilot;

public class CopilotClient
{
    private readonly ILogger<CopilotClient> _logger;
    
    public CopilotClient(ILogger<CopilotClient> logger)
    {
        _logger = logger;
    }
    
    public CopilotUserData GetUserData()
    {
        var userData = new CopilotUserData
        {
            UserId = "internal-user",
            UserName = "Copilot Internal User",
            IsAuthenticated = true
        };
        
        _logger.LogInformation("[CopilotClient] Copilot Internal User response: {UserData}", userData);
        
        return userData;
    }
}
