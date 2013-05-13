// File: IConfiguration.cs
// Project Name: NMultiTool.Console
// Project Home: https://github.com/trondr
// License: New BSD License (BSD) http://www.opensource.org/licenses/BSD-3-Clause
// Credits: See the Credit folder in this project
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

namespace ILogInject.UnityCommonLogging.Log4Net
{
    public interface IConfiguration
    {
        string LogDirectoryPath { get; set; }
        string LogFileName { get; set; }
    }
}