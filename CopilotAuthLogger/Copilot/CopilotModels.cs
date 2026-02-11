using Microsoft.Extensions.Logging;

namespace Copilot;

public class CopilotModels
{
    private readonly ILogger<CopilotModels> _logger;
    
    public CopilotModels(ILogger<CopilotModels> logger)
    {
        _logger = logger;
    }
    
    public void CheckEnvironmentVariables()
    {
        var useDefaultProxy = Environment.GetEnvironmentVariable("COPILOT_USE_DEFAULTPROXY");
        var useDefaultProxyValue = !string.IsNullOrEmpty(useDefaultProxy) && 
                                   bool.TryParse(useDefaultProxy, out var result) && result;
        
        _logger.LogInformation("[CopilotModels] Environment variable COPILOT_USE_DEFAULTPROXY found: {Value}", 
            useDefaultProxyValue);
    }
}
