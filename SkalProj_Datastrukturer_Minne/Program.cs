using System;
using System.Collections;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            bool isAlive = true;
            List<string> theList = new List<string>();
            Console.WriteLine("Add or remove something to the list");
            Console.WriteLine("+ in front adds to the list,");
            Console.WriteLine("- removes from the list");
            Console.WriteLine("0 to exit");

            while (isAlive)
            {
                //for (int i = 0; i < theList.Count; i++)
                //{
                //    Console.WriteLine(theList[i]);                    
                //}

                Console.WriteLine("Listan innehåller " + theList.Count + " objekt");
                Console.WriteLine("Arrayen innehåller " + theList.Capacity + " platser");

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;

                    case '-':
                        theList.Remove(value);
                        break;

                    case '0':
                        isAlive = false;
                        break;

                    default:
                        Console.WriteLine("Use + or -");
                        break;


                }

            }
            /*
             * 2. Listans array ökar när listan blir större än arrayen.
             * 3. Arrayen dubbleras i storlek.
             * 4. När arrayen ökar i storlek kopieras den till en annan plats i minnet. 
             *    Den dubbleras för att undvika att detta görs för många gånger.
             * 5. Nej.
             * 6. Om man vet att man inte kommer att behöva ändra storleken fungerar en array.
             *    I en array når man också innehållet snabbare än i en lista, och den använder
             *    mindre minne.
             */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing 
             * to see how it behaves
            */

            bool isAlive = true;
            Queue myQueue = new Queue();
            Console.WriteLine("Add a person to the queue");
            Console.WriteLine("- to remove a person from the queue");
            Console.WriteLine("0 to exit");
                      
            while (isAlive)
            {
                Console.WriteLine("\nthe queue contains " + myQueue.Count + " objects");

                string obj = Console.ReadLine();

                switch (obj)
                {
                    case "0":
                        isAlive = false;
                        break;

                    case "-":
                        if (myQueue.Count > 0)
                        {
                            myQueue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty");
                        }
                        break;

                    default:
                        myQueue.Enqueue(obj);
                        break;                        
                }

                Console.WriteLine("\t\tThe queue:");
                foreach (Object item in myQueue)
                {
                    Console.WriteLine("\t\t" + item);
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

