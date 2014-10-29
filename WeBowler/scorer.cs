using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBowler
{
    static public class Scorer
    {

        public static int CalculateScore(Frame[] frames)
        {
            int totalScore = 0;
            if (frames==null)
            {
                return 0;
            }
            else
            {
                Frame f;
                for (int count=0;count<frames.Length;count++)
                {
                    f = frames[count];
                    if (f != null)
                    {
                        totalScore += f.GetTotalRawScore();
                        if (f.isSpare() && frames[count + 1]!=null)
                        {
                            totalScore += frames[count+1].Bowl1;
                        }
                        else if (f.isStrike() && frames[count + 1] != null)
                        {
                            totalScore += frames[count + 1].GetTotalRawScore();
                        }
                    }
                }
            }
            return totalScore;
        }
    }
}
