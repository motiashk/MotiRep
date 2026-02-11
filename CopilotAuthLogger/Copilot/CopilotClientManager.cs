using Microsoft.Extensions.Logging;

namespace Copilot;

public class CopilotClientManager
{
    private readonly ILogger<CopilotClientManager> _logger;
    
    public CopilotClientManager(ILogger<CopilotClientManager> logger)
    {
        _logger = logger;
    }
    
    public void FetchModelList()
    {
        var timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        _logger.LogInformation("CopilotClientManager: model list fetched as of {Timestamp}.", timestamp);
    }
}
