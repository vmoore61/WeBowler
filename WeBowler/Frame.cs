using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBowler
{
    public class Frame
    {
        public int Bowl1 { get; set; }
        public int Bowl2 { get; set; }
        public int GetTotalRawScore()
        {
            return Bowl1 + Bowl2;
        }

        internal bool isSpare()
        {
            return (GetTotalRawScore() == 10 && !isStrike());
        }
        internal bool isStrike()
        {
            return (Bowl1 == 10);
        }
    }
}
