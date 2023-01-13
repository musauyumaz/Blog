namespace Blog.Application.Utilities
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }

}
