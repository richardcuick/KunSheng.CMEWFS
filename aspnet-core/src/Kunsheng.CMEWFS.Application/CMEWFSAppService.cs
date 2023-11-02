using System;
using System.Collections.Generic;
using System.Text;
using Kunsheng.CMEWFS.Localization;
using Volo.Abp.Application.Services;

namespace Kunsheng.CMEWFS;

/* Inherit your application services from this class.
 */
public abstract class CMEWFSAppService : ApplicationService
{
    protected CMEWFSAppService()
    {
        LocalizationResource = typeof(CMEWFSResource);
    }
}
