namespace App;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Pronoun { get; set; }
    public string? FavoritePet {get;set;}
    public bool IsEmployed { get; set; }

    public override string ToString()
    {
        return @$"FirstName={FirstName}|LastName={LastName}|Pronoun={Pronoun}|FavoritePet={FavoritePet}|IsEmployed={IsEmployed}";
    }
}
