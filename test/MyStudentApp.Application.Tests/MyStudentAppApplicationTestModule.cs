using Volo.Abp.Modularity;

namespace MyStudentApp;

[DependsOn(
    typeof(MyStudentAppApplicationModule),
    typeof(MyStudentAppDomainTestModule)
    )]
public class MyStudentAppApplicationTestModule : AbpModule
{

}
