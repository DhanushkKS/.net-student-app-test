using Microsoft.EntityFrameworkCore;
using StudentAPI.Domain;

namespace StudentAPI.Infrastructure;

public class StudentDbContext :DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options){}

    public DbSet<Student> Type { get; set; }
}