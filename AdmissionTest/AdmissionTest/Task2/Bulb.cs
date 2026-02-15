using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public bool Situation { get; set; }

        public event Action<bool> BulbSituation;
        public void On()
        {
            Situation = true;
            if (BulbSituation != null)
            {
                BulbSituation(Situation);
            }
        }
        public void Off()
        {
            Situation = false;
            if (BulbSituation != null)
            {
                BulbSituation(Situation);
            }
        }


    }
}
