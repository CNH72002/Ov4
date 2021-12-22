using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ov4
{
    public class Menu
    {

        private int choosedInput;  // Menu class instance variable

        #region
        public void Start()  // Start Menu method.
        {
            int choice = -1;   // set the initial out value to -1.

            while (choice != 0)     //While loop to ensure that this loop terminates if the user input is zero (0).
            {
                WriteMenuText();  // Displays the first Menu.

                choice = ReadInputChoice();  // Read the input to the Main Menu and assign value to variable choice.

                choosedInput = choice;  // The out variable from the method ReadInputChoice() assigned to variable  
                                        // choosedInput.

                CurrentOperationMenu();  // This method displays the current operation choosed

            }

        }






        private void CurrentOperationMenu()    // All the operations for this Application is selected here
        {
            switch (choosedInput)   // The switch block used the choosedInput as variable for the check.
            {
                case 0:
                    Environment.Exit(0); 
                    break;

                case 1:
                    ExamineListMenu();  
                    break;

                case 2:
                    TestQueueAndDequeue();  
                    break;

                case 3:
                    ExamineStack();  
                    break;

                case 4:
                    CheckParantheses();  
                    break;

                default:
                    Console.WriteLine("Wrong choice try again!");   // default if no right choice was made
                    break;

            }

        }





        private void WriteMenuText()  // This method displays the first main Menu.
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  MAIN MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Exit the program                        :0");
            Console.WriteLine("     Examine List 1 and Examine List 2       :1");
            Console.WriteLine("     Test Enqueue and Dequeue                :2");
            Console.WriteLine("     ExamineStack and Reverse Text           :3");
            Console.WriteLine("     CheckParanthesis                        :4");
            Console.WriteLine("----------------------------------------------");



        }


        private void ExamineListMenu()
        {

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  SUB-MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Examine List 1                         :1");
            Console.WriteLine("     Examine List 2                         :2");
            Console.WriteLine("     To terminate the program               :3");
            Console.WriteLine("--------------------------------------------- ");


            int userResponse = ReadInputChoice2();

            if (userResponse == 1)
            {
                ExamineList1();  //For individuals

            }
            else if (userResponse == 2)
            {
                ExamineList2();   //For groups of friends , family etc
            }
            else if (userResponse == 3)
            {
                Environment.Exit(3);   //Exit the program
            }
            else
            {

            }

            Console.WriteLine("-------------------------------");


        }




        // This method validates the user input to the Menu and ensures it is within(0-2) inclusive
        private int ReadInputChoice2()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Make your choice: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 1) && (choice <= 3))  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }




        public static void ExamineList1()
        {
            List<int> firstlist = new List<int>();

            // Adding elements in firstlist
            int input = Utilities.ReadInteger2();
            int choice = 0;
            bool validNum = false;

            for(int i = 0; i < input; i++)
            {
                Console.Write("Add an interger to the List ");
                string inputData = Console.ReadLine();
                validNum = int.TryParse(inputData, out choice);
                if (validNum)
                {
                    firstlist.Add(choice);

                }
                
            }

            Console.WriteLine();
            // Printing the Capacity of firstlist
            Console.WriteLine("The Capacity of the List is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            Console.WriteLine("Press any key to continue....\n");
            Console.ReadLine();
            Console.WriteLine("NOW ADD extra two intergers to the List\n");

            bool validNum2 = false;
            int choice2 = 0;
            // Adding some more
            // elements in firstlist
            for (int i = 0; i < 2; i++)
            {
                Console.Write("ADD extra interger here ");
                string inputData2 = Console.ReadLine();
                validNum2 = int.TryParse(inputData2, out choice2);
                if (validNum2)
                {
                    firstlist.Add(choice2);

                }

            }

            Console.WriteLine();
            // Printing the Capacity of firstlist
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("The Capacity of the List now is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            Console.WriteLine();

            string str = "2. The list capacity increases when the count is equal to the capacity.\n";
            str += "3. The capacity increases by 4. for everytime list.count = list.Capacity \n";
            str += "4. This is because of the underlying internal array structure of the list. \n";
            str += "5. The capacity does not decrease as an element is removed from the list (unchanged). \n";
            str += "6. Array is advantageous to use when manipulation of its elements is necessary unlike the list. ";

            Console.WriteLine(str);






        }


        //This method first creates a List of integers
        // In this method,  we are setting Capacity
        // explicitly i.e.
        public static void ExamineList2()
        {
            int input = Utilities.ReadInteger3();
            List<int> firstlist = new List<int>(input);

            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("The Count in the list is: " + firstlist.Count);

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadLine();

            Console.WriteLine("Add 4 integers to the List\n");

            bool validNum2 = false;
            int choice2 = 0;
            // Adding some more
            // elements in firstlist
            for (int i = 0; i < 4; i++)
            {
                Console.Write("ADD interger {0} here ", i + 1);
                string inputData2 = Console.ReadLine();
                validNum2 = int.TryParse(inputData2, out choice2);
                if (validNum2)
                {
                    firstlist.Add(choice2);

                }

            }

            Console.WriteLine();

            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            Console.WriteLine("Press any key to continue....\n");
            Console.ReadLine();
            Console.WriteLine("NOW ADD extra two intergers to the List\n");

            bool validNum3 = false;
            int choice3 = 0;
            // Adding some more
            // elements in firstlist
            for (int i = 0; i < 2; i++)
            {
                Console.Write("ADD extra interger here ");
                string inputData3 = Console.ReadLine();
                validNum3 = int.TryParse(inputData3, out choice3);
                if (validNum3)
                {
                    firstlist.Add(choice3);

                }

            }

            // Printing the Capacity of firstlist
            // It will give output 10 as we have
            // already set the Capacity
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            Console.WriteLine("Count increased while Capacity id unchanged !\n" +
                "Capacity can only increase if List.count = List Capacity");


        }



        static Queue myICAqueue;

        //This method only add element to the queue and calls the dequeue method
        public static void TestQueueAndDequeue()
        {
            // Create a queue
            // Using Queue class
            myICAqueue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method


            //Kalle joins the queue
            Console.Write("Add the first element to Enqueue ");
            string input1 = Console.ReadLine();
            myICAqueue.Enqueue(input1);

            Console.WriteLine();

            //Greta joins the queue
            Console.Write("Add the second element to Enqueue ");
            string input2 = Console.ReadLine();
            myICAqueue.Enqueue(input2);

            Console.WriteLine();

            //Kalle leaves the queue
            Console.Write("Add the first element to Dequeue ");
            string input3 = Console.ReadLine();

            TestDequeue(input3);  

            //Stina joins the queue
            Console.Write("Add the fourth element to Enqueue ");
            string input4 = Console.ReadLine();
            myICAqueue.Enqueue(input4);

            //Greta leaves the queue
            Console.Write("Add the first element to Dequeue ");
            string input5 = Console.ReadLine();
            TestDequeue(input5);

            //Olle stands in the queue
            Console.Write("Add the fifth element to Enqueue ");
            string input6 = Console.ReadLine();
            myICAqueue.Enqueue(input6);




            Console.WriteLine("List of all elements in the Queue\n");

            foreach (string p in myICAqueue)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine();

            Console.WriteLine("Total elements present in my_ICAqueue: {0}",
              myICAqueue.Count);


        }




        //This method removes only an element from the top of th queue.
        public static string TestDequeue(string obj)
        {
            Console.WriteLine();

            // obj = Console.ReadLine();
            if (obj != null)
            {
                if (myICAqueue.Contains(obj) == true)
                {
                    Console.WriteLine("The  {0} Element has been removed!\n", obj);
                    myICAqueue.Dequeue();

                    // myICAqueue = new myICAqueue<string>(myICAqueue.Where(x => x != obj));
                    // Queue = new Queue<string>(Queue.Where(x => x != obj));

                }
                else
                {
                    Console.WriteLine("The element entered is not the top list element...!!");
                }
            }



            return obj.ToString();
        }


        public static void ExamineStack1()
        {
            // Create a stack
            // Using Stack class
            Stack myStack = new Stack();

            int input = Utilities.ReadInteger4();
            int choice = 0;
            bool validNum = false;

            for (int i = 0; i < input; i++)
            {
                Console.Write("Push  item {0} (Integers only!) to the Stack ", i+1);
                string inputData = Console.ReadLine();
                validNum = int.TryParse(inputData, out choice);
                if (validNum)
                {
                    myStack.Push(choice);

                }

            }

            Console.WriteLine();
            Console.WriteLine("List of elements in the Stack are :\n");

            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("Total elements present in" +
                        " myStack: {0}", myStack.Count);

            Console.WriteLine("Press any key to pop the top element from the Stack");
            Console.ReadLine();

            myStack.Pop();

            

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my_stack after the pop: {0}", myStack.Count);




            // Accessing the elements
            // of my_stack Stack
            // Using foreach loop
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }
        }



        //This method reverses a text string. 
        public static void ReverseText()
        {
            Stack myStack2 = new Stack();

            int number = Utilities.ReadInteger();
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter character {0} ", i+1);
                string mycharString = Console.ReadLine();

                myStack2.Push(mycharString);

            }


            //List all the characters entered. 

            Console.WriteLine("The reverse character is :");

            foreach (var p in myStack2)
            {
                Console.Write(p);
            }

            Console.WriteLine();


        }





        // This method validates the user input to the Menu and ensures it is within(0-4) inclusive
        private int ReadInputChoice()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Make your choice: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 4))  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }






        //Sun menu for examining the Stack
        private void ExamineStack()
        {

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  SUB-MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Examine Stack method                    :1");
            Console.WriteLine("     Reverse Text                            :2");
            Console.WriteLine("     To terminate the program                :3");
            Console.WriteLine("----------------------------------------------");


            int userResponse = ReadInputChoice2();

            if (userResponse == 1)
            {
                ExamineStack1();  //For Stack examination

            }
            else if (userResponse == 2)
            {
                ReverseText();   //To reverse all the input string or character
            }
            else if (userResponse == 3)
            {
                Environment.Exit(3);   //Exit the program
            }
            else
            {

            }

            Console.WriteLine("-------------------------------");


        }



        #endregion


        public static void CheckParantheses()
        {
            Console.WriteLine("Jag ska gora den senare.!!1");
            Console.ReadLine();

            Stack myStack3 = new Stack();
            Queue myQueue = new Queue();


            Console.Write("Enter your string ");
            string myString = Console.ReadLine();

            bool b = myString.Contains("(");
            bool c = myString.Contains("[");
            bool d = myString.Contains("{");
            bool e = myString.Contains("<");


            if (b)
            {
                myQueue.Enqueue("(");
                myStack3.Push(")");

            }
            if (c)
            {
                myQueue.Enqueue("[");
                myStack3.Push("]");

            }
            if (d)
            {
                myQueue.Enqueue("{");
                myStack3.Push("}");


            }
            if (e)
            {

                myQueue.Enqueue("<");
                myStack3.Push(">");

            }



            foreach (var p in myQueue)
            {

                Console.Write(p);
            }

            Console.WriteLine();

            foreach (var s in myStack3)
            {

                Console.Write(s);
            }

        }











    }
}
