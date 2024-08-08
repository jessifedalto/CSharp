public class Person
{
    public required string Name {get; set;}
    public int Age {get;set;}

    public bool IsFromDitactorFamily {get;set;}

    bool canDrive(Person person)
    => person switch 
    {
        {IsFromDitactorFamily: true} => true,
        { Age: > 17} => true,
        { Age: > 12, Name: "Relamopago"} => true,
        _ => false
    };
}

