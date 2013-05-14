using System;
using System.IO;
using ILogInject.ExampleLibrary;
using Microsoft.Practices.Unity;

namespace ILogInject.Unity.Log4Net
{
    public class Bootstrapper
    {
        private static readonly object Sync = new object();
        private static volatile IUnityContainer _container;

        /// <summary>  Gets the container. </summary>
        ///
        /// <value> The container. </value>
        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    lock (Sync)
                    {
                        if (_container == null)
                        {
                            //Configure container
                            IUnityContainer container = new UnityContainer();
                            container.RegisterInstance(container);
                            container.AddNewExtension<BuildTracking>();
                            container.AddNewExtension<CommonLoggingLogCreationExtension>();
                            container.RegisterType<IConfiguration, Configuration>(new ContainerControlledLifetimeManager()); //Sigelton

                            //Manual registrations (could have used an auto registration library for Unity)
                            container.RegisterType<ISomeEntity, SomeEntity>();

                            StartUp(container);
                            _container = container;
                        }
                    }
                }
                return _container;
            }
        }

        private static void StartUp(IUnityContainer container)
        {
            IConfiguration configuration = container.Resolve<IConfiguration>();
            if (!Directory.Exists(configuration.LogDirectoryPath))
            {
                Directory.CreateDirectory(configuration.LogDirectoryPath);
            }
            log4net.GlobalContext.Properties["LogFile"] = Path.Combine(configuration.LogDirectoryPath, configuration.LogFileName);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)); 
        }
    }
}
