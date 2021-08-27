using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string changedString = Interpret("GGGGG()(al)()(al)()(al)");
            Console.WriteLine(changedString);
        }

        public static string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}
