using Castle.Windsor;
using System.ServiceModel;

namespace WebService.Interface.Service.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var c = BuildContainer())
            {
            }
        }

        private static IWindsorContainer BuildContainer()
        {
         //  var applicationServiceBase = AppConfig.GetAppSetting<string>("ApplicationServiceBase");

            var container = new WindsorContainer();

          //  container.AddFacility<WcfFacility>();

            var binding = new NetTcpBinding(SecurityMode.None)
            {
                PortSharingEnabled = true,
                MaxBufferPoolSize = 2147483647,
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            return container;
        }
    }
}
