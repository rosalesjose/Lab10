using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Question
    {
        public static string GetString(string prompt)
        {
            return Console.ReadLine();
        }

        public static int GetInt(string prompt)
        {
            return int.Parse(Console.ReadLine());
        }

        public static bool GetBool(string prompt)
        {
            string Input = Console.ReadLine().ToLower();
            return Input.StartsWith("y") || Input.StartsWith("n");
        }
    }
}
