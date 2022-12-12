using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        static void Main(string[] args)
        {
        }
    }
}
