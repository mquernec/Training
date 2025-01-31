// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Task t1 = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write($" {i} ");
        Task.Delay(100).Wait();
    }
});

t1.Wait();

Task t2 = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("X");
        Task.Delay(100).Wait();
    }
});

t2.Wait();
Console.WriteLine("");
Task t3 = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Z");
        Task.Delay(100).Wait();
    }
});



Task t4 = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Y");
        Task.Delay(100).Wait();
    }
});

Task.WaitAll(t3, t4);

await Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("A");
        Task.Delay(100).Wait();
    }
});


for (int i = 0; i < 10; i++)
{
    var num = await MaMethodeAsync();
    Console.Write($" {num} "); 
}



async Task<int> MaMethodeAsync()
{
    await Task.Delay(100);
    return 1;
}

 var tokenSource2 = new CancellationTokenSource();
        CancellationToken ct = tokenSource2.Token;

        var task = Task.Run(() =>
        {
            // Were we already canceled?
            ct.ThrowIfCancellationRequested();

            bool moreToDo = true;
            while (moreToDo)
            {
                // Poll on this property if you have to do
                // other cleanup before throwing.
                if (ct.IsCancellationRequested)
                {
                    // Clean up here, then...
                    ct.ThrowIfCancellationRequested();
                }
            }
        }, tokenSource2.Token); // Pass same token to Task.Run.

        tokenSource2.Cancel();

        // Just continue on this thread, or await with try-catch:
        try
        {
            await task;
        }
        catch (OperationCanceledException e)
        {
            Console.WriteLine($"{nameof(OperationCanceledException)} thrown with message: {e.Message}");
        }
        finally
        {
            tokenSource2.Dispose();
        }
