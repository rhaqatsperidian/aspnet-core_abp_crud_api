using MyStudentApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyStudentApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyStudentAppEntityFrameworkCoreModule),
    typeof(MyStudentAppApplicationContractsModule)
    )]
public class MyStudentAppDbMigratorModule : AbpModule
{
}
