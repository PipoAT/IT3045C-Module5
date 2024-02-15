namespace App;

public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Pronoun { get; set; }
    public string? FavoritePet {get;set;}
    public float Gpa { get; set; }

    public override string ToString()
    {
        return @$"FirstName={FirstName}|LastName={LastName}|Pronoun={Pronoun}|FavoritePet={FavoritePet}|Gpa={Gpa}";
    }
}
