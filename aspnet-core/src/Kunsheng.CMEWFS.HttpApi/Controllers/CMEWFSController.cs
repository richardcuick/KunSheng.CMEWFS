using Kunsheng.CMEWFS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kunsheng.CMEWFS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CMEWFSController : AbpControllerBase
{
    protected CMEWFSController()
    {
        LocalizationResource = typeof(CMEWFSResource);
    }
}
