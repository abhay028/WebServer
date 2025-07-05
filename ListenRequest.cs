namespace WebServer;

public partial class HandleRequest
{
    // Read request and enqueue in RequestQueue.
    public void ReadAndEnqueueRequest()
    {
        while (true)
        {
            Console.WriteLine("Enter request string: ");
            string request = Console.ReadLine() ?? "Empty";
            Data.RequestQueue.Enqueue(new Request() { Value = request });
        }
    }
}