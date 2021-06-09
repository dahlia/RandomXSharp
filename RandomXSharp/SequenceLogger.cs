using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace RandomXSharp
{
    internal static class SequenceLogger
    {
        internal static readonly string LogDirPath;

        internal static string LogFilePath => Path.Combine(
            LogDirPath,
            $"{Process.GetCurrentProcess().Id}_{Thread.CurrentThread.ManagedThreadId}.log"
        );

        static SequenceLogger() {
            LogDirPath
                = Path.DirectorySeparatorChar == '/'
                ? "/tmp/RandomXSharp"
                : @"C:\temp\RandomXSharp";
            Directory.CreateDirectory(LogDirPath);
        }

        internal static void Log(
            string message,
            [CallerFilePathAttribute] string path = "",
            [CallerLineNumber] int line = 0
        )
        {
            using StreamWriter sw = File.AppendText(LogFilePath);
            sw.WriteLine($"{path}:{line}:{message}");
        }
    }
}
