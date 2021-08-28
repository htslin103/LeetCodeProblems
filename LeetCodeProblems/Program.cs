using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LeetCodeProblems.Classes;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Destination City 

            //We need the city that doesn't have any outgoing paths from it
     
            //                                      //
            //*** THE TEMPLATE FOR THE FINISHED APP //
            //                                      //
            //Console.WriteLine("Choose which feature you would like to test!" + Environment.NewLine + 
            //                  "A. Goal Parser" + Environment.NewLine +
            //                  "B. " + Environment.NewLine +
            //                  "C." + Environment.NewLine +
            //                  "D.");

            //switch (Console.ReadLine())
            //{
            //    case "A":
            //        RunGoalParser();
            //        break;

            //    case "B":
            //        MethodHere();
            //        break;

            //    case "C":
            //        MethodHere();
            //        break;

            //    case "D":
            //        MethodHere();
            //        break;
            //}

        }

        public static void RunGoalParser()
        {
            //Goal Parser example
            Console.WriteLine("Type a sentence and our parser will give you the result:");
            Console.WriteLine("\tG = G");
            Console.WriteLine("\t() = o");
            Console.WriteLine("\t(al) = al");
            Console.WriteLine("Enter text below: ");
            string inputString = Console.ReadLine();
            string changedString = GoalParser.Interpret(inputString);
            Console.WriteLine(Environment.NewLine + $"Your parsed string: {changedString}");
        }


         public static string DestCity(IList<IList<string>> paths)
         {
             List<string> list = new List<string>();

             foreach (var path in paths)
             {
                 list.Add(path[1]);
             }

             foreach (var path in paths)
             {
                 if (list.Contains(path[0]))
                 {
                     list.Remove(path[0]);
                 }

             }

             return list.Last();
        }

    }
}