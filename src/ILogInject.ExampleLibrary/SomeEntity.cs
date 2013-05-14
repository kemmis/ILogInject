// File: SomeEntity.cs
// Project Name: ILogInject.ExampleLibrary
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using System;
using Common.Logging;

namespace ILogInject.ExampleLibrary
{
    public class SomeEntity: ISomeEntity
    {
        private readonly ILog _logger;

        public SomeEntity(ILog logger)
        {
            _logger = logger;
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
