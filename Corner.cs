using System;

namespace LabWork10
{
    internal class Corner
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else if (value > 180) { Gradus = 180; }
                else { gradus = value; };
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }

        public Corner(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            double totalGradus = Gradus + (Min / 60.0) + (Sec / 3600.0);

            return totalGradus * (Math.PI / 180);
        }

    }
}
