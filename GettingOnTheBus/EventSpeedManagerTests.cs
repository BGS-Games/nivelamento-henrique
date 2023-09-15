using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class EventSpeedManagerTests
    {
        [Test]         
        public void Should_create_only_one_instance_of_manager()
        {
            EventSpeedManager.Instance.Speed = 7;

            Assert.That(EventSpeedManager.Instance.Speed, Is.EqualTo(7));               
        }
    }
}
