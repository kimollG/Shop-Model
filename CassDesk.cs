using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ggg
{
    class CassDesk
    {
        double m, sigma;
        Queue<ICustomer> queue;
        public int QueueLength { get { return queue.Count; } }
        public void NewCustomer(ICustomer customer)
        {
            queue.Enqueue(customer);
        }
        public ICustomer Dequeue()
        {
            return queue.Dequeue();
        }


    }
}
