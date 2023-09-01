using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    internal interface IEventBus
    {
        void Register(ISubscribable subscribable);

        void Unregister(ISubscribable subscribable);
        
        void Dispatch(IEvent currentEvent);
        
        List<ISubscribable> GetSubscribers();
        
    }
}
