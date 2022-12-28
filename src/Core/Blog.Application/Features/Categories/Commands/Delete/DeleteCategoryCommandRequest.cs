using MediatR;

namespace Blog.Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
    {
        public int Id { get; set; }
    }
}
