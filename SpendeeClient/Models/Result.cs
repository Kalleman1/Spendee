namespace SpendeeApi.Models
{
    public class Result<T>
    {
        public T Value { get; private set; }
        public string Error { get; private set; }
        public bool IsSuccess => Error == null;

        private Result(T value, string error)
        {
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new Result<T>(value, null);
        public static Result<T> Failure(string error) => new Result<T>(default(T), error);
    }
}
