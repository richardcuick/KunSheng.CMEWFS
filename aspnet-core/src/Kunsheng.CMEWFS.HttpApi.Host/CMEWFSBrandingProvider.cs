using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kunsheng.CMEWFS;

[Dependency(ReplaceServices = true)]
public class CMEWFSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CMEWFS";
}
