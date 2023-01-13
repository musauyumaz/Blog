namespace Blog.Application.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(string message, bool isSucceeded, T data) : base(message, isSucceeded) => this.Data = data;

        public DataResult(bool isSucceeded, T data) : base(isSucceeded) => this.Data = data;

        public T Data { get; }
    }
}
