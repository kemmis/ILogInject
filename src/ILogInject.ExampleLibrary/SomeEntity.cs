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
