using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo
{
    public class WorkDoneEventArgs : EventArgs
    {
        public string Result { get; }

        public WorkDoneEventArgs(string result)
        {
            Result = result;
        }
    }

    public class Worker
    {
        public event EventHandler<WorkDoneEventArgs>? WorkCompleted;

        public void DoWork()
        {
            Console.WriteLine("Worker: Do Work!");
            string workResult = "Data processed";
            OnWorkCompleted(workResult);
        }

        protected void OnWorkCompleted(string result)
        {
            Console.WriteLine("Worker: Work completed.");
            WorkDoneEventArgs args = new(result);
            WorkCompleted?.Invoke(this, args);
        }
    }

    public class Supervisor
    {
        public string Name {get;}

        public Supervisor(string name)
        {
            Name = name;
        }

        public void StartMonitoring(Worker worker)
        {
            Console.WriteLine($"Supervisor {Name} subscribing to worker.");
            worker.WorkCompleted += Worker_WorkDone;
            // worker.WorkCompleted(this, new WorkDoneEventArgs("Ordered by boss!"));
        }

        public void StopMonitoring(Worker worker)
        {
            Console.WriteLine($"Supervisor {Name} unsubscribing from worker.");
            worker.WorkCompleted -= Worker_WorkDone;
        }

        private void Worker_WorkDone(object? sender, WorkDoneEventArgs e)
        {
            Console.WriteLine($"Supervisor {Name} received {e.Result}");
        }
    }

    internal class WorkerSupervisorDemo
    {
        public static void Run()
        {
            Worker myWorker = new Worker();

            myWorker.DoWork();

            Supervisor boss = new Supervisor("Boss");
            Supervisor admin = new Supervisor("Admin");

            admin.StartMonitoring(myWorker);
            myWorker.DoWork();

            boss.StartMonitoring(myWorker);
            myWorker.DoWork();

            admin.StopMonitoring(myWorker);
            myWorker.DoWork();
        }
    }
}
