using System;
using System.Collections.Generic;
using System.Text;
using MyStudentApp.Localization;
using Volo.Abp.Application.Services;

namespace MyStudentApp;

/* Inherit your application services from this class.
 */
public abstract class MyStudentAppAppService : ApplicationService
{
    protected MyStudentAppAppService()
    {
        LocalizationResource = typeof(MyStudentAppResource);
    }
}
