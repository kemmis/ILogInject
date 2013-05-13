using System;
using Common.Logging;
using ILogInject.ExampleLibrary;
using Microsoft.Practices.Unity;

namespace ILogInject.UnityCommonLogging.Log4Net
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
