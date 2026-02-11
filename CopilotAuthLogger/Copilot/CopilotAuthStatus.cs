using Microsoft.Extensions.Logging;

namespace Copilot;

public enum AuthStatus
{
    OK,
    Unauthorized,
    Error
}

public enum BadgeStatus
{
    Active,
    Inactive,
    Unknown
}

public class CopilotAuthStatus
{
    private readonly ILogger<CopilotAuthStatus> _logger;
    
    public CopilotAuthStatus(ILogger<CopilotAuthStatus> logger)
    {
        _logger = logger;
    }
    
    public void LogAuthStatus(AuthStatus authStatus, BadgeStatus badgeStatus)
    {
        _logger.LogInformation("Copilot auth status: {AuthStatus}. Copilot badge status: {BadgeStatus}", 
            authStatus, badgeStatus);
    }
}
