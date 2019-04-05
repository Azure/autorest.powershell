
namespace Microsoft.Rest.ClientRuntime
{
    using System;
    using System.Threading.Tasks;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class Response : EventData
    {
        public Response() : base()
        {
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class Response<T> : Response
    {
        private Func<Task<T>> _resultDelegate;
        private Task<T> _resultValue;

        public Response(T value) : base() => _resultValue = Task.FromResult(value);
        public Response(Func<T> value) : base() => _resultDelegate = () => Task.FromResult(value());
        public Response(Func<Task<T>> value) : base() => _resultDelegate = value;
        public Task<T> Result => _resultValue ?? (_resultValue = this._resultDelegate());
    }
}