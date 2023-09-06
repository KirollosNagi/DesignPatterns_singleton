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
            ConsoleLogger.GetInstance().LogInfo($"Thread {threadId} - Log Entry {j}");
        }
    });
}

// Wait for all threads to complete.
Task.WaitAll(tasks);

Console.WriteLine("Logging complete.");


ConsoleLogger logger = ConsoleLogger.GetInstance();
logger.LogWarning("hello from logger");
ConsoleLogger.GetInstance().LogError("Hello 2");
ConsoleLogger logger2 = ConsoleLogger.GetInstance();
Console.WriteLine(logger == logger2);