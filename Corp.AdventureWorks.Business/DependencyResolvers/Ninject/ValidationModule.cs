using Corp.AdventureWorks.Business.ValidationRules.FluentValidation;
using Corp.AdventureWorks.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace Corp.AdventureWorks.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}