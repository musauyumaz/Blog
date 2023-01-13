namespace Blog.Application.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string message, T data) : base(message, false, data) { }
        public ErrorDataResult(T data) : base(false, data) { }
        public ErrorDataResult(string message) : base(message, false, default) { }
        public ErrorDataResult() : base(false, default) { }
    }
}
