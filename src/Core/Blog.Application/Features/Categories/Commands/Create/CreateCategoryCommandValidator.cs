using FluentValidation;

namespace Blog.Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c=>c.Name).NotEmpty().NotNull().WithMessage("Kategori Adını Boş Geçemezsiniz!")
                              .MinimumLength(3).MaximumLength(50).WithMessage("Kategori Adı 3 ile 50 karakter arasında olmalıdır.");
            RuleFor(c=>c.Description).NotEmpty().NotNull().WithMessage("Açıklamayı Boş Geçemezsiniz!")
                              .MinimumLength(3).MaximumLength(1000).WithMessage("Açıklama alanı 3 ile 200 karakter arasında olmalıdır."); ;
        }
    }
}
