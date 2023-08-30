using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public sealed class Item : ISpeedChanger
    {
        public float SpeedChanger { get; } 

        public Item(float speedChanger) 
        {
            SpeedChanger = speedChanger; 
        }
    }
}
