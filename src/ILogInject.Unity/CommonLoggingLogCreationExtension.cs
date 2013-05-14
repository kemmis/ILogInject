// File: CommonLoggingLogCreationExtension.cs
// Project Name: ILogInject.UnityCommonLogging
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: http://blog.baltrinic.com/software-development/dotnet/log4net-integration-with-unity-ioc-container
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.ObjectBuilder;

namespace ILogInject.Unity
{
   public class CommonLoggingLogCreationExtension: UnityContainerExtension
   {
      protected override void Initialize()
      {
         Context.Strategies.AddNew<CommonLoggingLogCreationStrategy>(UnityBuildStage.PreCreation);
      }
   }
}