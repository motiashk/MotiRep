namespace Copilot;

public class CopilotModels
{
    public void CheckEnvironmentVariables()
    {
        var useDefaultProxy = Environment.GetEnvironmentVariable("COPILOT_USE_DEFAULTPROXY");
        var useDefaultProxyValue = !string.IsNullOrEmpty(useDefaultProxy) && 
                                   bool.TryParse(useDefaultProxy, out var result) && result;
        
        Console.WriteLine($"[Conversations Information] [CopilotModels] Environment variable COPILOT_USE_DEFAULTPROXY found: {useDefaultProxyValue}");
    }
}
