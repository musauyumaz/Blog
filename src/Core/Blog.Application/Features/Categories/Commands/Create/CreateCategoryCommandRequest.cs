using MediatR;

namespace Blog.Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
