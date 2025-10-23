namespace ThreadsExercise.ConsoleApp;

internal class Program
{
    
    static void Main(string[] args)
    {

        // Opret tre tråde som skal køre CountToTenNamed
        Thread t1 = new Thread(new ParameterizedThreadStart(Counter.CountToTenNamed));
        Thread t2 = new Thread(new ParameterizedThreadStart(Counter.CountToTenNamed));
        Thread t3 = new Thread(new ParameterizedThreadStart(Counter.CountToTenNamed));

        // Start dem med forskellige navne
        t1.Start("First thread");
        t2.Start("Second thread");
        t3.Start("Third thread");


        // Assignment 3 part 1, her sker der en fejl,
        // fordi ParameterizedThreadStart forventer en metode med et parameter typen object
        //Thread thread = new Thread(new ParameterizedThreadStart(Counter.CountToTenNamed));

        /* Assignment 2
        Console.WriteLine("Count 1 to 10");

        // Opret en ny Thread og giv CountToTen som metode
        Thread countThread = new Thread(Counter.CountToTen);

        // Start tråden
        countThread.Start();

        // (valgfrit) Hvis du vil vente på, at tråden bliver færdig, kan du gøre dette:
        // countThread.Join();

        Console.WriteLine("Counting started on a separate thread!");
       */

    }


}
