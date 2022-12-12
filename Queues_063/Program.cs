using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queues_063
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Initializing the values of the variables REAR and FRONT to -1 to indicate that
             the queue is initially empty.*/
            FRONT = -1; 
            REAR = -1;
        }
        public void insert(int element)
        {
            /*this statment checks for the overflow condition.*/
            if((FRONT == 0 && REAR == max - 1) || (FRONT ==REAR + 1))
            {
                Console.WriteLine("\nQueue overflow \n");
                return;
            }
            /*This following statment checks whether the queue is empty. If the queue is empty
             then the value of the REAR adn FRONT variables is set to 0*/
            if (FRONT == -1)
            {
                FRONT = 0; 
                REAR = 0;
            }
            else
            {
                /*If REAR is at the last position of the array, them the value of 
                 REAR is not to 0 that corresponds to the first position of the array*/
                if (REAR == max - 1)
                    REAR= 0;
                else
                    /*If REAL is not at the last position, then its value is incremented by one*/
                    REAR = REAR + 1;
            }
            /*one the position of rear is determinted, the element is added at its proper place*/
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /*Check wheater the queue is empty*/
            if (FRONT == -1)
            {
                Console.WriteLine("\nQueue overflow \n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");
            /*Check if the queue has one element */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR= -1;
            }
            else
            {
                /*if the element to be deleted is at the last position of the array, then the value
                 of FRONT is set to 0 i.e to the first element of the array*/
                if (FRONT == max - 1)
                    FRONT= 0;
                else
                    /*FRONT is incremeneted by one of if it is not the first element of array*/
                    FRONT = FRONT +1;
            }
        }
        public void display()
        {
            int FRONT_Position = FRONT;
            int REAR_Position = REAR;
            /*Check if the queue is empty*/
            if (FRONT == -1)
            {
                Console.WriteLine("\nQueue overflow \n");
                return;
            }
            Console.WriteLine("\nElemenets in the queue are..........................\n");
            if (FRONT_Position <= REAR_Position)
            {
                /*traverses the queue till the last element present in an array*/
                while(FRONT_Position <= REAR_Position)
                {
                    Console.WriteLine(queue_array[FRONT_Position] + "  ");
                    FRONT_Position++;
                }
                Console.WriteLine();
            }
            else
            {
                /*traverses the queue till the last position of the array*/
                while(FRONT_Position <= max -1)
                {
                    Console.WriteLine(queue_array[FRONT_Position] + "  ");
                    FRONT_Position++;
                }
                /*set the FRONT position to the first element of the array*/
                FRONT_Position = 0;
                /*traverses the queue till the element present in the queue*/
                while (FRONT_Position <= REAR_Position)
                {
                    Console.WriteLine(queue_array[FRONT_Position] + "  ");
                    FRONT_Position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your Choice (1-4):  ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Enter a number:  ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                            default:
                            {
                                Console.WriteLine("Invalid Option !!");
                            }
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
