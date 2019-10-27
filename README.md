NetCorePbkdf2HashingExample
====================================

NetCorePbkdf2HashingExample is a project to show how to use Pbkdf2 hashing in a custom project. The project was written and tested in .NetCore 2.2.

[![Build status](https://ci.appveyor.com/api/projects/status/1lq5x72xcveithei?svg=true)](https://ci.appveyor.com/project/SeppPenner/netcorepbkdf2hashingexample)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/NetCorePbkdf2HashingExample.svg)](https://github.com/SeppPenner/NetCorePbkdf2HashingExample/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/NetCorePbkdf2HashingExample.svg)](https://github.com/SeppPenner/NetCorePbkdf2HashingExample/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/NetCorePbkdf2HashingExample.svg)](https://github.com/SeppPenner/NetCorePbkdf2HashingExample/stargazers)
[![GitHub license](https://img.shields.io/badge/license-AGPL-blue.svg)](https://raw.githubusercontent.com/SeppPenner/NetCorePbkdf2HashingExample/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/NetCorePbkdf2HashingExample/badge.svg)](https://snyk.io/test/github/SeppPenner/NetCorePbkdf2HashingExample)

## Main code:
```csharp
/// <summary>
/// The main method.
/// </summary>
/// <param name="args">Some (currently unused) parameters.</param>
public static void Main(string[] args)
{
	Console.WriteLine("Running test.");
	const string PasswordExample = "SomePassword1234";
	var hasher = new PasswordHasher();
	var hashedPassword = hasher.HashPassword(PasswordExample);
	Console.WriteLine($"Password successfully hashed: {hashedPassword}");
	var verificationResult = hasher.VerifyHashedPassword(hashedPassword, PasswordExample);
	Console.WriteLine($"Verification result: {verificationResult}");
	Console.WriteLine("Press any key to close this window.");
	Console.ReadKey();
}
```

## Further notices:
* The project uses the ASP.NetCore hashing mechanisms from: https://github.com/aspnet/AspNetCore. Thanks to all the developers there.

Change history
--------------

* **Version 1.0.1.0 (2019-10-27)** : Updated nuget packages, added GitVersionTask.
* **Version 1.0.0.0 (2019-06-27)** : 1.0 release.