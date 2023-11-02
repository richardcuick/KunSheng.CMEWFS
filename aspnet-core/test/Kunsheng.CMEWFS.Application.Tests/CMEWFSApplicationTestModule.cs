using Volo.Abp.Modularity;

namespace Kunsheng.CMEWFS;

[DependsOn(
    typeof(CMEWFSApplicationModule),
    typeof(CMEWFSDomainTestModule)
    )]
public class CMEWFSApplicationTestModule : AbpModule
{

}
