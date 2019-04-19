[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(E_Commerce_ShoebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(E_Commerce_ShoebApi.App_Start.NinjectWebCommon), "Stop")]

namespace E_Commerce_ShoebApi.App_Start
{
    using System;
    using System.Web;
    using E_Commerce_ShoebApi.BAL;
    using E_Commerce_ShoebApi.DAL;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
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
                System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Ninject.WebApi.DependencyResolver.NinjectDependencyResolver(kernel);

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
            kernel.Bind<BAL_ItblProducts>().To<BAL_tblProducts>();
            kernel.Bind<DAL_ItblProducts>().To<DAL_tblProducts>();
            kernel.Bind<BAL_IPostEmailPw>().To<BAL_PostEmailPw>();
            kernel.Bind<DAL_IPostEmailPw>().To<DAL_PostEmailPw>();
            kernel.Bind<BAL_INewProduct>().To<BAL_NewProduct>();
            kernel.Bind<DAL_INewProduct>().To<DAL_NewProduct>();
        }        
    }
}