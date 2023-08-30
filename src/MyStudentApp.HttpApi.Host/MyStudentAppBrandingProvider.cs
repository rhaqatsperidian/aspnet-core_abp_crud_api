using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyStudentApp;

[Dependency(ReplaceServices = true)]
public class MyStudentAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyStudentApp";
}
