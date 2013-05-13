# ILogInject

ILogInject enables an IOC container to inject a CommonLogging.ILog class logger into a registered class.

## Credits

The ILog injection Unity extension was initially written for Log4Net by http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container

## Currently Supported Containers

* ILogInject.UnityCommonLogging (Microsoft Unity)

## Supported runtimes

* .NET 3.5

## Installation

ILogInject.UnityCommonLogging will in near future be available from Nuget Package Manager

## Example

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
			//resolves ISomeEntity -> SomeEntity that has been registered into the IOC container
			
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
