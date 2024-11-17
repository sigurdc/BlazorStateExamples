namespace StateExamples.Client.Models;

public class Person
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
}