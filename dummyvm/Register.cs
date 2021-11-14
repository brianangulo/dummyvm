using System;
namespace dummyvm
{
    public class Register<T>
    {
        private T state;

        public Register(T state)
        {
            this.state = state;
        }

        public Register()
        {

        }

        public T GetState()
        {
            return state;
        }

        public void SetState(T registerState)
        {
            state = registerState;
        }
    }
}
