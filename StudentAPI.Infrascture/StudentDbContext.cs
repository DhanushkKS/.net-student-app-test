using Microsoft.EntityFrameworkCore;
using StudentAPI.Domain;

namespace StudentAPI.Infrascture
{   
    

public class StudentDbContext(DbContextOptions<StudentDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
}
}
