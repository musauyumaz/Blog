using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryHandler : IRequestHandler<GetAllWriterQueryRequest, IDataResult<ListWriterRootDTO>>
    {
        private readonly IWriterService _writerService;

        public GetAllWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<ListWriterRootDTO>> Handle(GetAllWriterQueryRequest request, CancellationToken cancellationToken)
        {
            var writers = await _writerService.GetAllAsync(request.Page, request.Size);
            return new SuccessDataResult<ListWriterRootDTO>(Messages.GetAllWriter,writers);
        }
    }
}
