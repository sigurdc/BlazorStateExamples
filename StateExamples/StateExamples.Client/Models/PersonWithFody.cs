using PropertyChanged;

namespace StateExamples.Client.Models;

[AddINotifyPropertyChangedInterface]
public class PersonWithFody
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
}