using MyStudentApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyStudentApp;

[DependsOn(
    typeof(MyStudentAppEntityFrameworkCoreTestModule)
    )]
public class MyStudentAppDomainTestModule : AbpModule
{

}
