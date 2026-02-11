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
    public void LogAuthStatus(AuthStatus authStatus, BadgeStatus badgeStatus)
    {
        Console.WriteLine($"[Conversations Information] Copilot auth status: {authStatus}. Copilot badge status: {badgeStatus}");
    }
}
