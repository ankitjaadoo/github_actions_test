using Pulumi;
using S3 = Pulumi.Aws.S3;
using Aws = Pulumi.Aws;

class MyStack : Stack
{
    public MyStack()
    {
        // Create an AWS resource (S3 Bucket)
        string resource_prefix = "PulumiGitHubAction";

        var s3Bucket = new S3.Bucket($"{resource_prefix}_S3Bucket", new S3.BucketArgs
        {
            BucketName = "adappt_co_uk",
            Versioning = new Aws.S3.Inputs.BucketVersioningArgs
            {
                Enabled = true,
            },
        });

    }

    [Output]
    public Output<string> BucketName { get; set; }
}