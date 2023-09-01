using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class SpeedItem : ISpeedChanger, IEvent
    {
        public float SpeedCoeff { get; }

        public string EventType => "SpeedItem";

        public SpeedItem(float speedChanger)
        {
            SpeedCoeff = speedChanger;
        }

        public SpeedItem GetData()
        {
            return this;
        }
    }
}
