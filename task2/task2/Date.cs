using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Date
{
    int year;

    public Date(int year)
    {
        this.year = year;
    }

    private bool CheckBissextile()
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

    public int NumberOfDays()
    {
        if(CheckBissextile())
        {
            return 366;
        }
        else
        {
            return 365;
        }
    }
}