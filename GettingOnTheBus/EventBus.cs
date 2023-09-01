using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class EventBus : IEventBus
    {
        private readonly List<ISubscribable> subscribablesList;

        public EventBus()
        {
            subscribablesList = new();
        }

        public void Dispatch(IEvent currentEvent)
        {
            foreach (ISubscribable s in subscribablesList)
            {
                s.Handle(currentEvent);
            }
        }

        public List<ISubscribable> GetSubscribers()
        {
            return subscribablesList;
        }

        public void Register(ISubscribable subscribable)
        {
            subscribablesList.Add(subscribable);
        }

        public void Unregister(ISubscribable subscribable)
        {
            subscribablesList.Remove(subscribable);
        }
    }
}
