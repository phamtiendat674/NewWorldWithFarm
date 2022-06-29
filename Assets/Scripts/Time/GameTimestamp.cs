using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameTimestamp
{
    public int year;
    public int day;
    public int hour;
    public int minute;

    public GameTimestamp(int year, int day, int hour, int minute)
    {
        this.year = year;
        this.day = day;
        this.hour = hour;
        this.minute = minute;
    }

    public void UpdateClock()
    {
        minute++;
        
        if (minute >= 60)
        {
            minute = 0;
            hour++;
        }

        if (hour >= 24)
        {
            hour = 0;
            day++;
        }

        if (day >= 365)
        {
            day = 0;
            year++;
        }
    }
}
