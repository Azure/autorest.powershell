
namespace Microsoft.Rest.ClientRuntime
{

    using System;
    using System.Threading.Tasks;
    public class Response : EventData
    {
        public Response() : base()
        {
        }
    }

    public class Response<T> : Response
    {
        private Func<Task<T>> _resultDelegate;
        private Task<T> _resultValue;

        public Response(T value) : base() => _resultValue = Task.FromResult(value);
        public Response(Func<T> value) : base() => _resultDelegate = () => Task.FromResult(value());
        public Response(Func<Task<T>> value) : base() => _resultDelegate = value;
        public Task<T> Result => _resultValue ?? (_resultValue = this._resultDelegate());
    }

    /*
        public class Response<T1, T2> : Response<T1>
        {
            private Func<Task<T2>> _result2Delegate;
            private Task<T2> _result2Value;

            public Response(T1 value, T2 value2) : base(value) => _result2Value = Task.FromResult(value2);
            public Response(Func<T1> value, Func<T2> value2) : base(value) => _result2Delegate = () => Task.FromResult(value2());
            public Response(Func<Task<T1>> value, Func<Task<T2>> value2) : base(value) => _result2Delegate = () => value2();
            public Task<T2> Result2 => _result2Value ?? (_result2Value = this._result2Delegate());
        }
     */
}