using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class Singleton<T> where T: Singleton<T>, new()
    {
        private static T instance ;        

        public static T Instance {
            get {
                instance ??= new T();
                return instance;
            }
        }
    }
}
