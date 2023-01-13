namespace Blog.Application.Utilities
{
    public interface IResult
    {
        string Message { get; }
        bool IsSucceeded { get; }
    }

}
