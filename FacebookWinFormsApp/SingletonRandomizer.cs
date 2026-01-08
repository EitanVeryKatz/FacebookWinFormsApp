using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public sealed class SingletonRandomizer
    {
        private static readonly Random sr_instance = new Random();
        private SingletonRandomizer() { }
        public static Random Instance { get { return sr_instance; } }
    }
}