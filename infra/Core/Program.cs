using Pulumi;
using System.Threading.Tasks;

namespace DemoPulumiApp
{
    public static class Program
    {
        public static async Task<int> Main()
        {
            return await Deployment.RunAsync<CoreStack>();
        }
    }
}