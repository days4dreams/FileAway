using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// declared the System.IO in order to use 'File' 

namespace FileAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\MyToDoList.txt";
            // a single backslash in a special character. Using two to indicate a single \ for file path
            string title = "To Do List\n";
            File.WriteAllText(file, title);
            // creates a text file in the location of string file and puts the string contents in it

            string oneToDo = "Buy Milk";
            string twoToDo = "Wash Car";
            string threeToDo = "Call Mum";
            // a selection of tasks

            System.Collections.Generic.List<string> yesAnswers = new System.Collections.Generic.List<string>() { "yes", "true", "aye", "yep", "1" };  //everything is lowercase
            string order = string.Empty;
            bool additions = false;

            string myList = String.Format("1.{0} \n2.{1} \n3.{2} \n...", oneToDo, twoToDo, threeToDo);
            File.WriteAllText(file, myList);

            string content = File.ReadAllText(file);
            Console.WriteLine(content);
            // looks for the file in location string file and prints all of the text to the console

            /* START IF TEXT */
            while (additions == false)
            {
                Console.WriteLine("Would you like to add anything further?");

                order = Console.ReadLine();
                additions = yesAnswers.Contains(order.ToLower());  //now use ToLower so that I convert the value to be all lower case. I don't have to worry about uppercase now. 

                if (additions == false)
                {
                    Console.WriteLine("No problem.\n");
                    continue;       //go through loop again from the start and ignore rest of logic in this iteration.
                }

                Console.WriteLine("What task would you like to add to your to do list?");
                string fourToDo = string.Empty;

                fourToDo = Console.ReadLine();
               else
                            {
                                Console.WriteLine("Sorry, I didn't understand that! Please try again.");

                            }

             }//this loop continues until you get a valid yes/no

            /*END OF TEXT */

            FileInfo ToDoListInfo = new FileInfo("C:\\MyToDoList.txt");
            // we can call the class FileInfo because it existing the .Net framework library (its not a complex object)
            // we create a new object and tell it to point to the path of MyToDoList.txt

            long fileLength = ToDoListInfo.Length;
            DateTime fileCreated = ToDoListInfo.CreationTime;
            bool fileIsReadOnly = ToDoListInfo.IsReadOnly;
            // capture information for the attriibutes of our To Do List

            Console.WriteLine("Your To Do List is " + fileLength + " characters in length");
            Console.WriteLine("Your To Do List was created at " + fileCreated);
            Console.WriteLine("The File is read-only is " + fileIsReadOnly);

            Console.ReadKey();

        }
    }
}
