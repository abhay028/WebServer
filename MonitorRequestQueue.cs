namespace WebServer;

public partial class HandleRequest
{
    // Monitor Request Queue.
    public void MonitorRequestQueue()
    {
        while (true)
        {
            if (Data.RequestQueue.Count != 0)
            {
                var request = Data.RequestQueue.Dequeue();

                var handleRequest = new HandleRequest();
                var handleRequestThread = new Thread(() => handleRequest.ProcessRequest(request));
                handleRequestThread.Start();
            }
        }
    }
}