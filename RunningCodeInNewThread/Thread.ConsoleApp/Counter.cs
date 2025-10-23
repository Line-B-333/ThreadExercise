using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // Husk denne import for Thread.Sleep

namespace ThreadsExercise.ConsoleApp;

public abstract class Counter
{

    //Method that counts from 1 to 10 using a while loop
    public static void CountToTen()
    {
        int index = 1;
        while (index <= 10)
        {
            Console.WriteLine(index);
            Thread.Sleep(2000);
            index++;
        }
    }
    
    //Object: 
    public static void CountToTenNamed(object threadName)
    {
        string name = (string)threadName; // Cast fra object til string
        int index2 = 1;
        while (index2 <= 10)
        {
            Console.WriteLine($"Thread {threadName}" + index2);
            Thread.Sleep(2000);
            index2++;
        }
    }


    /* Assigment 3 part 1
    public static void CountToTenNamed(string threadName) 
    {
        int index2 = 1;
        while (index2 <= 10)
        {
            Console.WriteLine($"Thread {threadName}" + index2);
            Thread.Sleep(2000);
            index2++;
        }
    }*/
}
