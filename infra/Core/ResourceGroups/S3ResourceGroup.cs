using Pulumi.Aws.S3;

namespace DemoPulumiApp.ResourceGroups;

public class S3ResourceGroup
{
    public S3ResourceGroup()
    {
        // Create an AWS resource (S3 Bucket)
        var bucket = new BucketV2("my-bucket");
    }
}
