namespace App;

public class DataUtility
{
    public static List<Person> People { get; set; } = [
        new Person {FirstName="Brian", LastName="Dietrick", Pronoun="He",IsEmployed=true},
        new Person {FirstName="Brandi", LastName="Dietrick", Pronoun="She",IsEmployed=false},
        new Person {FirstName="Erika", LastName="Dietrick", Pronoun="She",IsEmployed=true},
        new Person {FirstName="Maysun", LastName="Dietrick", Pronoun="She",IsEmployed=true},
        new Person {FirstName="Dawson", LastName="Dietrick", Pronoun="He",IsEmployed=false},
        new Person {FirstName="Jason", LastName="Dietrick", Pronoun="He",IsEmployed=false},
        new Person {FirstName="Joe", LastName="Weaks", Pronoun="He",IsEmployed=true},
        new Person {FirstName="Ryan", LastName="MacLennan", Pronoun="He",IsEmployed=true},
    ];

    public static async Task DisplayPeopleWithLastNameDietrickUsingQueryExpressionAsync()
    {
        //TODO: Create a LINQ Query Expression that writes people objects 
        //      with the last name of Dietrick to the console using Person ToString()
        await Task.Delay(2000);
        Console.WriteLine("**********************************************************");
        Console.WriteLine("DisplayPeopleWithLastNameDietrickUsingQueryExpressionAsync");
        Console.WriteLine("**********************************************************");
        // add code below
        //**********************************************************

        var dispLastNameDietrickQuery = from person in People where person.LastName == "Dietrick" select person;

        foreach (var dispLastNameDietrickPerson in dispLastNameDietrickQuery)
        {
            Console.WriteLine(dispLastNameDietrickPerson.ToString());
        }
    }

    public static async Task DisplayPeopleWithLastNameDietrickUsingApiMethodAsync()
    {
        //TODO: Create a LINQ API Method that writes people objects 
        //      with the last name of Dietrick to the console
        //      using Person ToString()
        await Task.Delay(2000);
        Console.WriteLine("**********************************************************");
        Console.WriteLine("DisplayPeopleWithLastNameDietrickUsingApiMethodAsync");
        Console.WriteLine("**********************************************************");
        // add code below
        //**********************************************************
        
        var dispLastNameDietrickAPI = People.Where(person => person.LastName == "Dietrick");

        foreach (var dispLastNameDietrickPerson in dispLastNameDietrickAPI)
        {
            Console.WriteLine(dispLastNameDietrickPerson.ToString());
        }
    }

    public static async Task DisplayPeopleWithLastNameWithShePronounThatIsEmployedAsync()
    {
        //TODO: Using LINQ style of your choice, write people with last name 
        //      of Dietrick, uses She pronoun and is employed to the console
        //      using Person ToString()
        await Task.Delay(2000);
        Console.WriteLine("**********************************************************");
        Console.WriteLine("DisplayPeopleWithLastNameWithShePronounThatIsEmployedAsync");
        Console.WriteLine("**********************************************************");
        // add code below
        //**********************************************************

        var dispDietrickSheEmployedQuery = from person in People where person.LastName == "Dietrick"
                                            && person.Pronoun == "She" && person.IsEmployed select person;

        foreach (var dispDietrickSheEmployedPerson in dispDietrickSheEmployedQuery)
        {
            Console.WriteLine(dispDietrickSheEmployedPerson.ToString());
        }
    }

    public static async Task DisplayStudentsAsync()
    {
        //TODO: Using LINQ style of your choice, create student objects 
        //      from person objects with last name of Dietrick and are unemployed
        //      and write student objects to the console using Student ToString() 
        await Task.Delay(2000);
        Console.WriteLine("**********************************************************");
        Console.WriteLine("DisplayStudentsAsync");
        Console.WriteLine("**********************************************************");        
        // add code below
        //**********************************************************

        var dispUnemployedDietrickStudentsAPI = People.Where(person => person.LastName == "Dietrick" && !person.IsEmployed)
                                                .Select(person => new Student {
                                                    FirstName = person.FirstName,
                                                    LastName = person.LastName,
                                                    Pronoun = person.Pronoun
                                                });

        foreach (var dispUnemployedDietrickStudents in dispUnemployedDietrickStudentsAPI)
        {
            Console.WriteLine(dispUnemployedDietrickStudents.ToString());
        }
    }
}