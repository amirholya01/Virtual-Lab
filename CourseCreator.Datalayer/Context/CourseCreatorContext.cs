using Microsoft.EntityFrameworkCore;

namespace CourseCreator.Datalayer.Context;

public class DBConext : DbContext
{
    public DBConext(DbContextOptions<DBConext>options):base(options)
    {
        
    }
}