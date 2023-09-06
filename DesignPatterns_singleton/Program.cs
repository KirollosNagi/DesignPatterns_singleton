// See https://aka.ms/new-console-template for more information
using DesignPatterns_singleton;

// Create multiple threads that use the Logger.
Task[] tasks = new Task[5];
for (int i = 0; i < tasks.Length; i++)
{
    int threadId = i;
    tasks[i] = Task.Run(() =>
    {
        for (int j = 0; j < 3; j++)
        {
            Logger.getInstance().Log($"Thread {threadId} - Log Entry {j}");
        }
    });
}

// Wait for all threads to complete.
Task.WaitAll(tasks);

Console.WriteLine("Logging complete.");


Logger logger = Logger.getInstance();
logger.Log("hello from logger");
Logger.getInstance().Log("Hello 2");
Logger logger2 = Logger.getInstance();
Console.WriteLine(logger == logger2);