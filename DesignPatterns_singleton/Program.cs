// See https://aka.ms/new-console-template for more information
using DesignPatterns_singleton;

Logger logger = Logger.getInstance();
logger.Log("hello from logger");
Logger.getInstance().Log("Hello 2");
Logger logger2 = Logger.getInstance();
Console.WriteLine(logger == logger2);