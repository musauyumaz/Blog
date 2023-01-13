namespace Blog.Application.Utilities
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message, T data) : base(message, true, data) { }
        public SuccessDataResult(T data) : base(true, data) { }
        public SuccessDataResult(string message) : base(message, true, default) { }
        public SuccessDataResult() : base(true, default) { }
    }
}
