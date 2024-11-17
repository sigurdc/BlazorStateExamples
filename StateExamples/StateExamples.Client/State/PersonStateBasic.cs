using StateExamples.Client.Models;

namespace StateExamples.Client.State;

public class PersonStateBasic
{
    public Person CurrentPerson { get; set; } = new()
    {
        Name = "Sigurd",
    };
    
    
}