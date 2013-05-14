// File: Configuration.cs
// Project Name: NMultiTool.Console
// Project Home: https://github.com/trondr
// License: New BSD License (BSD) http://www.opensource.org/licenses/BSD-3-Clause
// Credits: See the Credit folder in this project
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