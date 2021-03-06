﻿// File: CommonLoggingTraceListener.cs
// Project Name: ILogInject.Unity
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using Common.Logging;

namespace ILogInject.Unity
{
   public class CommonLoggingTraceListener : System.Diagnostics.TraceListener
   {
      private readonly ILog _log;

      public CommonLoggingTraceListener()
      {
         _log = LogManager.GetLogger("System.Diagnostics.Redirection");
      }

      public CommonLoggingTraceListener(ILog log)
      {
         _log = log;
      }

      public override void Write(string message)
      {
         if (_log != null)
         {
            if(_log.IsDebugEnabled) _log.Debug(message);
         }
      }

      public override void WriteLine(string message)
      {
         if (_log != null)
         {
            if (_log.IsDebugEnabled) _log.Debug(message);
         }
      }
   }
}