using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public struct AsyncTaskMethodBuilder
    {
        public static AsyncTaskMethodBuilder Create()
        {
            return new AsyncTaskMethodBuilder();
        }

        public void SetException(Exception e) { }
        public void SetResult() { }
        public Task Task { get { return null; } }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
              where TAwaiter : INotifyCompletion
              where TStateMachine : IAsyncStateMachine
        {
            Console.WriteLine("I'm hacked!");
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
              where TAwaiter : ICriticalNotifyCompletion
              where TStateMachine : IAsyncStateMachine
        {
            Console.WriteLine("I'm hacked!");
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
            stateMachine.MoveNext();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
