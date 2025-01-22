SeaMailer

SeaMailer is a simple, lightweight email-sending library for .NET applications. It wraps email-sending functionality behind an easy-to-use interface, enabling developers to quickly integrate email notifications into any .NET application that supports dependency injection (such as ASP.NET Core, Worker Services, and more).
Table of Contents
Features
Installation
Getting Started
1. Configure Settings
2. Register Services
3. Inject and Use
Example Usage
appsettings.json Example
Advanced Configuration
Contributing
License


Features
Dependency Injection-friendly: Easily register SeaMailer in your DI container.
Configuration-based: Provide API credentials via appsettings.json, environment variables, or user secrets.
Async/Await Support: All email-sending operations are asynchronous.
Extensible: Written with extensibility in mind—easy to customize or extend for more complex scenarios.


Installation
SeaMailer is distributed via NuGet. You can install it using the .NET CLI:

dotnet add package SeaMailer
Or via the NuGet Package Manager console in Visual Studio:

Install-Package SeaMailer


Getting Started
1. Configure Settings
In your .NET application (for example, an ASP.NET Core or Worker Service project), you will typically store the PublicKey and SecretKey in your configuration (e.g., appsettings.json, environment variables, or user secrets).
