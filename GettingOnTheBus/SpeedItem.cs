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

        public SpeedItem(float speedChanger)
        {
            SpeedCoeff = speedChanger;
        }
    }
}
