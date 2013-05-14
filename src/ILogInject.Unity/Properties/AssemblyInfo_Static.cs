// File: AssemblyInfo_Static.cs
// Project Name: ILogInject.Unity
// Project Home: https://github.com/trondr/ILogInject/blob/master/README.md
// License: New BSD License (BSD) https://github.com/trondr/ILogInject/blob/master/License.md
// Credits: See the Credit folder in this project
// Copyright © <github.com/trondr> 2013 
// All rights reserved.

using System.Reflection;
using System.Runtime.CompilerServices;

#if NET20
[assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 2.0")]
#elif NET35
   [assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 3.5")]
#elif NET35CLIENT
   [assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 3.5 Client Profile")]
#elif NET40
[assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 4")]
#elif NET40CLIENT
   [assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 4 Client Profile")]
#elif NET403
[assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 4.0.3")]
#elif NET403CLIENT
   [assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 4.0.3 Client Profile")]
#elif NET40MONO
   [assembly: AssemblyTitle("ILogInject.Unity for Mono 4.0")]
#elif MONO20
   [assembly: AssemblyTitle("ILogInject.Unity for Mono 2.0")]
#elif NET45
	[assembly: AssemblyTitle("ILogInject.Unity for .NET Framework 4.5")]
#else
#error Unknown target framework found in AssemblyInfo.cs
#endif

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
