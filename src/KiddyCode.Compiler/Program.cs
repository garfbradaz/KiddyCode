using System;

namespace KiddyCode.Compiler;

public class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("KiddyCode Compiler v0.1");
            Console.WriteLine("Usage: kiddycode <source-file>");
            return 1;
        }

        // Future compiler implementation will go here
        return 0;
    }
}
