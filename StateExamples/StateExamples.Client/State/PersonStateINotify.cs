using StateExamples.Client.Models;

namespace StateExamples.Client.State;

public class PersonStateINotify() : BaseState<Person>(new Person
{
    Name = "Sigurd"
})
{
    public void UpdateCurrentPersonName(string name)
    {
        State.Name = name;
        OnPropertyChanged();
    }

    // public Person GetCurrentPerson()
    // {
    //     return State;
    // }
    
}