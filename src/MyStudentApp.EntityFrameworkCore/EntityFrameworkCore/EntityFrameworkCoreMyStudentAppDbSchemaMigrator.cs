using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyStudentApp.Data;
using Volo.Abp.DependencyInjection;

namespace MyStudentApp.EntityFrameworkCore;

public class EntityFrameworkCoreMyStudentAppDbSchemaMigrator
    : IMyStudentAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMyStudentAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MyStudentAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MyStudentAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
