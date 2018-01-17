using System;
using System.Runtime.CompilerServices;

namespace CustomAwaitable
{
    public class CustomAwaiter : INotifyCompletion
    {
        public bool IsCompleted { get; }
        private Action _continuation;

        public CustomAwaiter(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }

        public void OnCompleted(Action continuation)
        {
            _continuation = continuation;
            Console.CancelKeyPress += Continue;
        }

        public void Continue(object sender, ConsoleCancelEventArgs e)
        {
            _continuation();
            Console.CancelKeyPress -= Continue;
        }

        public string GetResult()
            => "This is my result!";
    }
}
