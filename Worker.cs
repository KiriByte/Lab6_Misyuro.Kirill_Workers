using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Workers
{
    internal class Worker : IPosition
    {
        public string GetPosition() { return GetType().Name; }
    }
}
