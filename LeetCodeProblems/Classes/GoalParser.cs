using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Classes
{
    //LeetCode problem 1678
    public static class GoalParser
    {
        //Takes a user given string and parses it with the given criteria
        public static string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}
