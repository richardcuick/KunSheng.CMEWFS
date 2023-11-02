using Kunsheng.CMEWFS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Kunsheng.CMEWFS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CMEWFSEntityFrameworkCoreModule),
    typeof(CMEWFSApplicationContractsModule)
    )]
public class CMEWFSDbMigratorModule : AbpModule
{
}
