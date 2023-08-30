using System.Threading.Tasks;

namespace MyStudentApp.Data;

public interface IMyStudentAppDbSchemaMigrator
{
    Task MigrateAsync();
}
