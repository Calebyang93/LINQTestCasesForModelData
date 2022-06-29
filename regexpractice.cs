//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WebAPIClient
//{
    
//    class regexpractice
//    {
//        string s = "You win some. You lose some.";
//        char[] separators = new char[] { ' ', '.' };
//        string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
//        string[] expressions = { "16 + 21", "31 * 3", "28 / 3",
//                       "42 - 18", "12 * 7",
//                       "2, 4, 6, 8" };
//        string pattern = @"(\d+)\s+([-+*/])\s+(\d+)";
//        foreach (string expression in expressions)
//	    {
//            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(expression, pattern))
//	        {
//                int value1 = Int32.Parse(m.Groups[1].value);
//                int value2 = Int32.Parse(m.Groups[2].value);
//                switch (m.Groups[2].value);
//	        {
//                case "+":
//                    Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
//                    break;
//                case "-":
//                    Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
//                    break;
//                case "*":
//                    Console.WriteLine("{0} = {1}", m.Value, value1* value2);
//                    break;
//                case "/":
//                    Console.WriteLine("{0} = {1}", m.Value, value 1/ value2);
//                    break;
//	}
//}
	   