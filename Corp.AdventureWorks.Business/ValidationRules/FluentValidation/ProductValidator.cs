using Corp.AdventureWorks.Entities.Concrete;
using FluentValidation;

namespace Corp.AdventureWorks.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductCategoryId).NotEmpty().WithMessage("Category Id can not be empty");
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ListPrice).GreaterThan(0);
            RuleFor(p => p.ListPrice).GreaterThan(20).When(p=>p.ProductCategoryId == 3);
            RuleFor(p => p.ProductNumber).Length(4, 10);
        }
    }
}