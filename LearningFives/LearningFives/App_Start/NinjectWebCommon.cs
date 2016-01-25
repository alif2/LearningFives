using System;
using System.Web;
using DataAccessors;
using Engines;
using Interfaces.DataAccessors;
using Interfaces.Engines;
using Interfaces.Managers;
using LearningFives;
using LearningFives.Models;
using Managers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace LearningFives
{
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ISignUpManager>().To<SignUpManager>();
            kernel.Bind<ISignUpEngine>().To<SignUpEngine>();
            kernel.Bind<ISignUpDataAccessor>().To<SignUpDataAccessor>();

            kernel.Bind<IAdminManager>().To<AdminManager>();
            kernel.Bind<IAdminEngine>().To<AdminEngine>();
            kernel.Bind<IAdminDataAccessor>().To<AdminDataAccessor>();

            kernel.Bind<ApplicationDbContext>().ToSelf();
            kernel.Bind<IAuthenticationManager>().ToMethod(c => HttpContext.Current.GetOwinContext().Authentication).InRequestScope();
            kernel.Bind<IUserStore<ApplicationUser>>().To<UserStore<ApplicationUser>>().WithConstructorArgument("context", kernel.Get<ApplicationDbContext>());
            kernel.Bind<UserManager<ApplicationUser>>().ToSelf();
        }        
    }
}