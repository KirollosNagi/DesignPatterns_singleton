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
            LoggerFactory.GetFileLogger("log.txt").LogInfo($"Thread {threadId} - Log Entry {j}");
        }
    });
}

// Wait for all threads to complete.
Task.WaitAll(tasks);

Console.WriteLine("Logging complete.");

ILogger logger = LoggerFactory.GetConsoleLogger();
logger.LogWarning("hello from logger");
LoggerFactory.GetConsoleLogger().LogError("Hello 2");
ILogger logger2 = LoggerFactory.GetConsoleLogger();
Console.WriteLine(logger == logger2);