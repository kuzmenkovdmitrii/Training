namespace task3
{
    class Date
    {
        int day;
        int mounth;
        int year;
        public Date(int day,int mounth, int year)
        {
            this.day = day;
            this.mounth = mounth;
            this.year = year;
        }

        public int OrdinalDay() //task2
        {
            int ordinalDay = 0;
            for (int i = 1; i < mounth; i++)
            {
                if (i % 2 != 0)
                {
                    ordinalDay += 31;
                }
                else if (i % 2 == 0 && i != 2)
                {
                    ordinalDay += 30;
                }
                else if (i == 2)
                {
                    if (CheckBissextile())
                    {
                        ordinalDay += 29;
                    }
                    else
                    {
                        ordinalDay += 28;
                    }
                }
            }
            ordinalDay += day;
            return ordinalDay;
        }

        private bool CheckBissextile() //task2
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
