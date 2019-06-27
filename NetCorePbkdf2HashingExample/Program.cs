
namespace NetCorePbkdf2HashingExample
{
    using System;

    using NetCorePbkdf2HashingExample.Hashing;

    /// <summary>
    /// The main class to show how the <see cref="PasswordHasher"/> works.
    /// </summary>
    public class Program
    {
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
    }
}
