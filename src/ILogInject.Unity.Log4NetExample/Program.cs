// File: Program.cs
// Project Name: ILogInject.Unity.Log4NetExample
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using System;
using Common.Logging;
using ILogInject.ExampleLibrary;
using Microsoft.Practices.Unity;

namespace ILogInject.Unity.Log4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = Bootstrapper.Container.Resolve<ILog>();
            try
            {
                if(log.IsInfoEnabled) log.Info("Starting ILogInject.UnityCommonLogging.Log4NetExample");
                ISomeEntity someEntity = Bootstrapper.Container.Resolve<ISomeEntity>();
                someEntity.SomeMethod("This is a test string");
            }
            catch (Exception ex)
            {
                if(log.IsErrorEnabled) log.Error(ex.Message);
            }
            finally
            {
                if (log.IsInfoEnabled) log.Info("Stopping ILogInject.UnityCommonLogging.Log4NetExample");
                Console.WriteLine("Press ENTER...");
                Console.ReadLine();
            }
        }
    }
}
