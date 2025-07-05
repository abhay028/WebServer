namespace WebServer;

public partial class HandleRequest
{
    // Process request
    public void ProcessRequest(Request request)
    {
        Thread.Sleep(5000);
        Console.WriteLine(request.Value);
    }
}