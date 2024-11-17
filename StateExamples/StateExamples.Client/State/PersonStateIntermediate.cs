using StateExamples.Client.Models;

namespace StateExamples.Client.State;

public class PersonStateIntermediate
{
    public Person CurrentPerson { get; set; } = new()
    {
        Name = "Sigurd",
    };

    public void UpdateCurrentPersonName(string name)
    {
        CurrentPerson.Name = name;
        NotifyOnChange();
    }

    private void NotifyOnChange() => OnChange?.Invoke();
    
    public event Action? OnChange;
    
}