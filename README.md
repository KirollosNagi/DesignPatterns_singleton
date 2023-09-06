# Design Patterns Singleton

This is a simple project out of a series of projects for learning design patterns in C#.

The singelton design pattern is one of the creational design patterns that are used to provide a global managed instance of an object that could be shared across different classes.

I am implementing a simple singleton logger here to show the importance and significance of this design pattern. 

I have also went ahead afterwards and made the logger thread-safe to work with multithreading applications and remain a singleton.

Furthermore, I went ahead and used lazy initialization instead of actually worrying about initialization using locking.

Moreover, I decided to expand this project to have multiple singleton loggers so I added ConsoleLogger and FileLogger that both implement the ILogger interface.

I added a glimpse of a singleton factory to create, access, and use loggers from external projects while maintaining the singleton concepts.