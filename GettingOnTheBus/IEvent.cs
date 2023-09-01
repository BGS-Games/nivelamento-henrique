using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public interface IEvent
    {
        string EventType { get; }

        //TODO: ideal seria transformar isso em algo genérico - para qualquer tipo de evento
        //public T GetData();

        public SpeedItem GetData();
    }
}
