using System.Threading.Tasks;

namespace Kunsheng.CMEWFS.Data;

public interface ICMEWFSDbSchemaMigrator
{
    Task MigrateAsync();
}
