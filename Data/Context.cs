using Microsoft.EntityFrameworkCore;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options): base(options)
    {
        
    }
    public DbSet<TblStudent> tblStudents { get; set; }
    public DbSet<TblLog> tblLogs { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=MYDb;user id=SA;password=A&VeryComplex123Password;MultipleActiveResultSets=true;TrustServerCertificate=true");
    // }
}