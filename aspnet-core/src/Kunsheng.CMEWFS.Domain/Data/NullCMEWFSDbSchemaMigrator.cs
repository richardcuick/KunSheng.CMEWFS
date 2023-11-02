using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Kunsheng.CMEWFS.Data;

/* This is used if database provider does't define
 * ICMEWFSDbSchemaMigrator implementation.
 */
public class NullCMEWFSDbSchemaMigrator : ICMEWFSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
