using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetById
{
    public class GetByIdWriterQueryHandler : IRequestHandler<GetByIdWriterQueryRequest, IDataResult<WriterDTO>>
    {
        private readonly IWriterService _writerService;

        public GetByIdWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<WriterDTO>> Handle(GetByIdWriterQueryRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writerDto = await _writerService.GetByIdAsync(request.Id);
            return new SuccessDataResult<WriterDTO>(Messages.GetWriter,writerDto);
        }
    }
}
