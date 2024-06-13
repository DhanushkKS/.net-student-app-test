using StudentAPI.Domain.Entities;

namespace StudentAPI.Domain;

public class Student : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public string City { get; set; } = null!;
}