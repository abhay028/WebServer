using WebServer;

Console.WriteLine("Web server started!");

// Listen incomming requests.
var handleRequest = new HandleRequest();
var readRequestThread = new Thread(handleRequest.ReadAndEnqueueRequest);
readRequestThread.Start();

// Monitor request queue
var monitorRequestQueueThread = new Thread(handleRequest.MonitorRequestQueue);
monitorRequestQueueThread.Start();


