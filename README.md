# ILogInject

ILogInject enables an IOC container to inject a CommonLogging.ILog class logger into a registered class.

## Credits

ILogInject.Unity is derived from http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container

## Supported IOC Containers

* Microsoft Unity (ILogInject.Unity)

## Supported .NET runtimes

* .NET 3.5
* .NET 3.5 Client
* .NET 4.0
* .NET 4.0 Client
* .NET 4.0.3
* .NET 4.0.3 Client
* .NET 4.5

## Installation

ILogInject.Unity is installed into your project by Nuget Package Manager

## Example C# project utilizing ILogInject.Unity

See https://github.com/trondr/ILogInject/tree/master/src/ILogInject.Unity.Log4NetExample

## Example of ILog usage

```csharp
using System;
using Common.Logging;

namespace ILogInject.ExampleLibrary
{
	public interface ISomeEntity
    {
        void SomeMethod(string sometext);
    }

    public class SomeEntity: ISomeEntity
    {
        private readonly ILog _logger;

        public SomeEntity(ILog logger)
        {
            //A logger with name "ILogInject.ExampleLibrary.SomeEntity" is injected into the class when the IOC container
			//resolves ISomeEntity -> SomeEntity, a mapping that have on application startup been registered into the 
			//IOC container
			
			_logger = logger; 
			
			//The logger is now available for all methods of the class by using the _logger field	
        }

        public void SomeMethod(string sometext)
        {
            if(_logger.IsTraceEnabled) _logger.Trace("Starting SomeMethod...");
            if(sometext == null) throw new ArgumentNullException("sometext");
            bool somecondition = sometext.Length > 10;
            if (somecondition)
            {
                if (_logger.IsInfoEnabled) _logger.Info("Some condition was true");
            }
            else
            {
                if (_logger.IsInfoEnabled) _logger.Info("Some condition was false");
            }
            if (_logger.IsTraceEnabled) _logger.Trace("Finished SomeMethod!");
        }
    }
}
	
```
