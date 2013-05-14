// File: IConfiguration.cs
// Project Name: ILogInject.Unity.Log4NetExample
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.
namespace ILogInject.Unity.Log4Net
{
    public interface IConfiguration
    {
        string LogDirectoryPath { get; set; }
        string LogFileName { get; set; }
    }
}