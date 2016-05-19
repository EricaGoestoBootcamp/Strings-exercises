using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_is_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console app that asks the user for a name. 
            //Loop over each character in the name and print each one as a line to the console.

            string testName = "Jefferson Jones";

            for (int i = 0; i < testName.Length; i++)
            {
                Console.WriteLine(testName[i]);
            }

            //Find the first e

            Console.WriteLine(testName.IndexOf('e'));

            //Call out each e by location
            //start by changing to lowercase

            string lowerTestName = testName.ToLower();
            string search = "e";
            int position = lowerTestName.IndexOf(search);
            while (position != -1)
            {
                Console.WriteLine("e found at {0}", position);
                position = lowerTestName.IndexOf(search, position + 1);
            }

            //Count the e's
            //int count = source.Split('/').Length - 1;
            int count = lowerTestName.Split('e').Length - 1;
            Console.WriteLine("the number of e's is {0}", count);


            /* Remove all html tags from the string 
            “<p>This is remaining <a href=”#”>text</a>. I’d like to keep it.</p>”

            It should print out 
            “This is remaining text. I’d like to keep it.” */

            string myString = "<p>This is remaining <a href=”#”>text</a>. I’d like to keep it.</p>";

            //create a string that goes to the first occurrence of openBrace
            //and removes removeIt characters

            int stringLength = myString.Length;
            int openBrace;
            int closeBrace;
            int removeIt;

            //idea: do-while loop that marches through the string and removes the braces 
            do
            {
                openBrace = myString.IndexOf("<");
                closeBrace = myString.IndexOf(">");
                removeIt = closeBrace + 1 - openBrace;
                myString = myString.Remove(openBrace, removeIt);
            } while (myString.Contains("<"));
            Console.WriteLine(myString);
        }
    }
}
