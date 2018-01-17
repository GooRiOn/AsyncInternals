namespace CustomAwaitable
{
    public class CustomAwaitable
    {
        private readonly bool _isCompleted;

        public CustomAwaitable(bool isCompleted)
        {
            _isCompleted = isCompleted;
        }

        public CustomAwaiter GetAwaiter()
            => new CustomAwaiter(_isCompleted);
    }
}
