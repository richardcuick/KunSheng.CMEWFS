using Kunsheng.CMEWFS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kunsheng.CMEWFS;

[DependsOn(
    typeof(CMEWFSEntityFrameworkCoreTestModule)
    )]
public class CMEWFSDomainTestModule : AbpModule
{

}
