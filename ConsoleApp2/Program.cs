using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {

        public interface Callback
        {
            void Execute();
        }

        class CallbackRel : Callback
        {
            public void Execute()
            {
                Console.WriteLine("sth");
            }
        }
        public class Executor
        {
            private Callback cb;
            public void SetCallback(Callback cb)
            {
                this.cb = cb;
            }
            public void ExecuteAction()
            {
                cb.Execute();
            }
        }

        static void Main(string[] args)
        {
            Executor h = new Executor();
            Callback a = new CallbackRel();

            h.SetCallback(a);
            h.ExecuteAction();
        }
    }
}
