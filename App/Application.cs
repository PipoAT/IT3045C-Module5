namespace App;

public class App
{
    public static async Task ExecuteAsync()
    {
        // Do not change any code in this method
        await RunInlineAwaitAsync();
        await RunWhenAllAsync();
        await RunWhenAnyAsync();
    }

    public static async Task RunInlineAwaitAsync()
    {
        //TODO: Call 3 different DataUtility async methods
        //      using in-line awaits
        Console.WriteLine("**********************************************************");
        Console.WriteLine("RunInlineAwaitAsync");
        Console.WriteLine("**********************************************************");
        // add code below


        await Task.Delay(0);  // delete after adding your code
    }

    public static async Task RunWhenAllAsync()
    {
        //TODO: Call 3 different DataUtility async methods
        //      in parallel using the Task.WhenAll method
        Console.WriteLine("**********************************************************");
        Console.WriteLine("RunWhenAllAsync");
        Console.WriteLine("**********************************************************");
        // add code below


        await Task.Delay(0);  // delete after adding your code
    }

    public static async Task RunWhenAnyAsync()
    {
        //TODO: Create an in-line cancel task like demonstrated in recording
        //TODO: Call 1 DataUtility async method and the cancel task
        //      using the Task.WhenAny method
        Console.WriteLine("**********************************************************");
        Console.WriteLine("RunWhenAnyAsync");
        Console.WriteLine("**********************************************************");
        // add code below


        await Task.Delay(0);  // delete after adding your code
    }
}
