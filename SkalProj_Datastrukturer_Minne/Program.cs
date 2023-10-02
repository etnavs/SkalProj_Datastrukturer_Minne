using System;
using System.Collections;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        // Frågor:
        // 1. Stacken är snabb och lagrar enligt principen last in first out.
        // Innehållet rensas ut automatiskt efter användandet.
        // I heapen är all data tillgänglig. Den behöver rensas med hjälp av
        // garbage collectorn. Objekt som skapas med hjälp av "new" Hamnar i heapen.
        // 
        // 2.Value types är typer från System.ValueType, exempelvis bool, char, int.
        // De lagras där de deklareras. Reference types lagras alltid på heapen. 
        // De lagrar en referens till datan.
        //
        // 3. I ReturnValue2, när man skriver att y = x, betyder det att
        // x och y kommer att dela referensen till heapen. Sätter man
        // y till 4 kommer x också att bli 4.




        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
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
             * Make sure to look at the stack after pushing and and poping 
             * to see how it behaves
            */

            Stack myStack = new Stack();
            Console.WriteLine("Write something to reverse it");
            Console.WriteLine("0 to exit");


            String message = Console.ReadLine();
            for (int i = 0; i < message.Length; i++)
            {
                string letter = message.Substring(i, 1);
                myStack.Push(letter);
            }

            foreach (string letter in myStack)
            {
                Console.Write(letter);
                //Jag använde från början Console.Write(myStack.Pop());här,
                //men det fungerade inte. Jag vet inte varför.
            }
        }



        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            // Min ide är att använda en stack, och mata in tecknen i strängen om det
            // är en parentes. Öppnande paranteser kan matas in hur många som helst,
            // men när det kommer en stängande parentes jämförs den med parentesen innan.
            // Om parentesen innan är en öppnande av samma typ tas de två parenteserna
            // bort och inmatningen fortsätter. Är den öppnande parentesen av en annan typ
            // är strängen inte välformad. När hela strängen är genomgången ska stacken
            // vara tom, annars är är stacken inte välformad.


            Stack compStack = new Stack();
            Console.WriteLine("Write a string with parenthesis to check it.");
            
            String compare = Console.ReadLine();
            for (int i = 0; i < compare.Length; i++)
            {
                string letter = compare.Substring(i, 1);
                if (letter == "{" || letter == "(" || letter == "[")
                {
                    compStack.Push(letter);
                }

                if (letter == "}" && compStack.Count > 0 && compStack.Peek().ToString() == "{")
                {
                    compStack.Pop();
                }

                if (letter == ")" && compStack.Count > 0 && compStack.Peek().ToString() == "(")
                {
                    compStack.Pop();
                }

                if (letter == "]" && compStack.Count > 0 && compStack.Peek().ToString() == "[")
                {
                    compStack.Pop();
                }


            }

            if (compStack.Count == 0)
            {
                Console.WriteLine("Parenthesis: Correct.");
            }

            else
            {
                Console.WriteLine("Parenthesis: NOT correct.");
            }


        }
    }


}

