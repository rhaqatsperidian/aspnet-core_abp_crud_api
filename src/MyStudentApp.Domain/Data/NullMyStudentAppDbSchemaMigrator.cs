using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyStudentApp.Data;

/* This is used if database provider does't define
 * IMyStudentAppDbSchemaMigrator implementation.
 */
public class NullMyStudentAppDbSchemaMigrator : IMyStudentAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
