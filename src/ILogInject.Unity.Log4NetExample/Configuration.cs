// File: Configuration.cs
// Project Name: ILogInject.Unity.Log4NetExample
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ILogInject.Unity.Log4Net
{
    public class Configuration : IConfiguration
    {
        private string _logDirectoryPath;
        private string _logFileName;
        private readonly string _sectionName;

        public Configuration()
        {
            _sectionName = "ILogInject.UnityCommonLogging.Log4NetExample";
        }

        public string LogDirectoryPath
        {
            get
            {
                if (string.IsNullOrEmpty(_logDirectoryPath))
                {
                    NameValueCollection section = (NameValueCollection) ConfigurationManager.GetSection(_sectionName);
                    if (section == null)
                    {
                        throw new ConfigurationErrorsException("Missing section in application configuration file: " +
                                                               _sectionName);
                    }
                    _logDirectoryPath = Environment.ExpandEnvironmentVariables(section["LogDirectoryPath"]);
                }
                return _logDirectoryPath;
            }
            set { _logDirectoryPath = value; }
        }

        public string LogFileName
        {
            get
            {
                if (string.IsNullOrEmpty(_logFileName))
                {
                    NameValueCollection section = (NameValueCollection) ConfigurationManager.GetSection(_sectionName);
                    if (section == null)
                    {
                        throw new ConfigurationErrorsException("Missing section in application configuration file: " +
                                                               _sectionName);
                    }
                    _logFileName = Environment.ExpandEnvironmentVariables(section["LogFileName"]);
                }
                return _logFileName;
            }
            set { _logFileName = value; }
        }
    }
}