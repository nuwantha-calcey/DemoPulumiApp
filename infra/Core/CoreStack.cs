using DemoPulumiApp.ResourceGroups;
using Pulumi;

namespace DemoPulumiApp;

public class CoreStack : Stack
{
    public CoreStack()
    {
        var s3ResourceGroup = new S3ResourceGroup();
    }
}
