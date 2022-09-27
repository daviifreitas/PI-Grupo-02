using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Domain.Entities
{
    public class OutlierRegister : EntityBase
    {
        public double Vibration { get; set; }
        public double Temp { get; set; }
        public double Noise { get; set; }
        public Log Log { get; set; }
        public Machine Machine { get; set; }
        public DateTime Time { get; set; }
    }
}
