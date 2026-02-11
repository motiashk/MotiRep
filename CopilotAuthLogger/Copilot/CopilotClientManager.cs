namespace Copilot;

public class CopilotClientManager
{
    public void FetchModelList()
    {
        var timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        Console.WriteLine($"[CopilotClientManager Information] CopilotClientManager: model list fetched as of {timestamp}.");
    }
}
