using Conversations.Abstractions.Auth;

namespace Copilot;

public class CopilotClient
{
    public CopilotUserData GetUserData()
    {
        var userData = new CopilotUserData
        {
            UserId = "internal-user",
            UserName = "Copilot Internal User",
            IsAuthenticated = true
        };
        
        Console.WriteLine($"[Conversations Information] [CopilotClient] Copilot Internal User response: {userData}");
        
        return userData;
    }
}
