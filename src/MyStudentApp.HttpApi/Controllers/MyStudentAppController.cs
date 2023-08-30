using MyStudentApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyStudentApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyStudentAppController : AbpControllerBase
{
    protected MyStudentAppController()
    {
        LocalizationResource = typeof(MyStudentAppResource);
    }
}
