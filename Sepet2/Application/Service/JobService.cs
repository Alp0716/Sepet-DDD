using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class JobService : IJobService
    {
        public void ContinuationJob()
        {
            Console.WriteLine("Continuation jobs tetiklendi!");

        }

        public void DelayedJob()
        {
            Console.WriteLine("Delayed jobs tetiklendi!");

        }

        public void FireAndForgetJob()
        {
            Console.WriteLine("FireAndForget jobs tetiklendi!");

        }

        public void ReccuringJob()
        {
            Console.WriteLine("Recurring jobs tetiklendi!");
        }
    }
}
