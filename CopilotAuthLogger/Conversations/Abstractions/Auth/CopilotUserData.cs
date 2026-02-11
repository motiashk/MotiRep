namespace Conversations.Abstractions.Auth;

public class CopilotUserData
{
    public string? UserId { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public bool IsAuthenticated { get; set; }
    
    public override string ToString()
    {
        return $"Conversations.Abstractions.Auth.CopilotUserData";
    }
}
