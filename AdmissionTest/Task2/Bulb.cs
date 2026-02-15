using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public bool Situation { get; set; }

        public event Action<bool> BulbSituationON;
        public event Action<bool> BulbSituationOFF;
        public void On()
        {
            Situation = true;
            if (BulbSituationON != null)
            {
                BulbSituationON(Situation);
            }
        }
        public void Off()
        {
            Situation = false;
            if (BulbSituationOFF != null)
            {
                BulbSituationOFF(Situation);
            }
        }


    }
}
