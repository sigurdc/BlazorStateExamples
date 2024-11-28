using StateExamples.Client.Models;

namespace StateExamples.Client.State;

public class PersonStateIntermediate
{
    private Person _currentPerson = new()
    {
        Name = "Sigurd",
    };

    /* For simpler / smaller state objects, this could be enough -- doesn't scale a lot */
    public Person CurrentPerson
    {
        get => _currentPerson;
        set
        {
            _currentPerson = value;
            NotifyOnChange();
        }
    }

    // public Person CurrentPerson { get; private set; }

    /* For more advanced scenarios, this has more control and flexibility */
    public void UpdateCurrentPersonName(string name)
    {
        CurrentPerson.Name = name;
        NotifyOnChange();
    }

    public void UpdatePerson(Person person)
    {
        CurrentPerson = person;
        NotifyOnChange();
    }

    private void NotifyOnChange() => OnChange?.Invoke();

    public event Action? OnChange;
}