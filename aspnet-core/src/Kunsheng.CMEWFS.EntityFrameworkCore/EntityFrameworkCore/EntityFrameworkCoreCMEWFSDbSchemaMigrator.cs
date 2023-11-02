using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kunsheng.CMEWFS.Data;
using Volo.Abp.DependencyInjection;

namespace Kunsheng.CMEWFS.EntityFrameworkCore;

public class EntityFrameworkCoreCMEWFSDbSchemaMigrator
    : ICMEWFSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCMEWFSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CMEWFSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CMEWFSDbContext>()
            .Database
            .MigrateAsync();
    }
}
