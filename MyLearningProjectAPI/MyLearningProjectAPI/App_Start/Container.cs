using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLearningProjectAPI.App_Start
{
    public static class Container
    {
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<SMSService>().As<IMobileServive>();
            //builder.RegisterType<EmailService>().As<IMailService>();
            //var container = builder.Build();

            //container.Resolve<IMobileServive>().Execute();
            //container.Resolve<IMailService>().Execute();
            Console.ReadLine();
        }
    }
}