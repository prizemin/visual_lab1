using System;

class Programm
{
    static void Main()
    {
        int[] queue1 = { 6, 4, 5 };
        int registers1 = 1;
        int[] queue2 = { 11, 2, 3, 3 };
        int registers2 = 2;
        int[] queue3 = { 1, 2, 11 };
        int registers3 = 2;

        Console.WriteLine(HW1.QueueTime(queue1, registers1));
        Console.WriteLine(HW1.QueueTime(queue2, registers2));
        Console.WriteLine(HW1.QueueTime(queue3, registers3));

    }
}
public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int theTime = 0;
        while (customers.Length > 0)
        {
            int busyRegister = 0;

            if (n > customers.Length)
            {
                 busyRegister = customers.Length;
            }
            else
            {
                busyRegister = n;
            }

            for (int x = 0; x < busyRegister; x++)
            {
                customers[x]--;
            }

            customers = Array.FindAll(customers, y => y != 0);

            theTime++;
        }
        return theTime;
    }
}

