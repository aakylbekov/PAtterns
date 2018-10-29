using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        #region 1part
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
        #endregion 
        
        public interface Observerable
        {
            void AddObsever();
            void RemoveObsever();
            void NotifyAllObservers();
        }
        public interface Observer
        {
            void Subscribe(string msg);
        }

        public class Subscriber : Observer
        {
            public void Subscribe(string msg)
            {
                Console.WriteLine(msg);
            }
        }
        private class YouTube: Observerable
        {
            private string ChanelName;
            private List<Observer> subscribers;
            private ArrayList videos = new ArrayList();

            public YouTube()
            {
            }

            public void addVideo(string videoName)
            {
                this.videos.Add(videoName);
                NotifyAllObservers();
            }
            public void setChannelName(string ChanelName)
            {
                this.ChanelName = ChanelName;
            }

            public void AddObsever(Observer observer)
            {
                this.subscribers.Add(observer);
            }
            public void RemoveObsever(Observer observer)
            {
                this.subscribers.Remove(observer);
            }
            public void NotifyAllObservers()
            {
                                
                foreach (var item in subscribers)
                {
                    ;
                    Console.WriteLine("Watch yotube");
                    subscribers.Subcsribe(this.videos.LastIndexOf());
                }
                
            }

            public void AddObsever()
            {
                throw new NotImplementedException();
            }

            public void RemoveObsever()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            //Executor h = new Executor();
            //Callback a = new CallbackRel();

            //h.SetCallback(a);
            //h.ExecuteAction();
            
        }
    }

    internal class Iterator<T>
    {
    }
}
