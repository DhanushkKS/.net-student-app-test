using Microsoft.EntityFrameworkCore;
using StudentAPI.Domain;

namespace StudentAPI.Infrascture;

public class StudentDbContext :DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options){}
    public DbSet<Student> Students { get; set; }
}