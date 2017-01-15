using System.Data.Entity;

namespace DataAccess
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
    }
}