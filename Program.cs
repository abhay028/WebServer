using WebServer;

Console.WriteLine("Web server started!");

var requestQueue = new Queue<Request>();

// Read Request
var readRequestThread = new Thread(ReadAndEnqueueRequest);
readRequestThread.Start();

// Monitor request queue
var monitorRequestQueueThread = new Thread(MonitorRequestQueue);
monitorRequestQueueThread.Start();


#region methods

// Read request and enqueue in RequestQueue.
void ReadAndEnqueueRequest()
{
    while (true)
    {
        Console.WriteLine("Enter request string: ");
        string request = Console.ReadLine() ?? "Empty";
        requestQueue.Enqueue(new Request() { Value = request });
    }
}

// Monitor Request Queue.
void MonitorRequestQueue()
{
    while (true)
    {
        if (requestQueue.Count != 0)
        {
            var request = requestQueue.Dequeue();
            var handleRequestThread = new Thread(() => HandleRequest(request));
            handleRequestThread.Start();
        }
    }
}

// Handle request
void HandleRequest(Request request)
{
    Thread.Sleep(5000);
    Console.WriteLine(request.Value);
}

#endregion

