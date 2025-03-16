Daniil's-Branch

=======
﻿using System;
using System.Collections.Generic;

// These are changes only for Daniil Branch

public class Appointment
{
    // Array for the list of periods that are available
    private List<int>[] reservedMinutes = new List<int>[8];

    // Constructor to initialize the schedule with random free durations
    public Appointment()
    {
        Random rand = new Random();
        for (int i = 0; i < 8; i++)
        {
            reservedMinutes[i] = new List<int>();
            int freeDuration = rand.Next(0, 31); // Randomly choosing free duration between 0 and 30 minutes
            for (int j = 0; j < freeDuration; j++)
            {
                reservedMinutes[i].Add(j);
            }
        }
    }

    // This will begin the portion where we look if any free minutes in a period 
    private bool isMinuteFree(int period, int minute)
    {
        return !reservedMinutes[period - 1].Contains(minute);
    }

    // This will be to reserve a space, we are keeping in the private portion of the constructor 
    private void reserveBlock(int period, int startMinute, int duration)
    {
        for (int i = startMinute; i < startMinute + duration; i++)
        {
            reservedMinutes[period - 1].Add(i);
        }
        Console.WriteLine($"Block reserved from minute {startMinute} for {duration} minutes in period {period}");
    }

    // Function for finding free blocks
    public int findFreeBlock(int period, int duration)
    {
        for (int startMinute = 0; startMinute <= 60 - duration; startMinute++)
        {
            bool blockAvailable = true;
            for (int j = 0; j < duration; j++)
            {
                if (!isMinuteFree(period, startMinute + j))
                {
                    blockAvailable = false;
                    break;
                }
            }
            if (blockAvailable)
            {
                return startMinute;
            }
        }
        return -1; // No available block found
    }

    // Function to make an appointment
    public bool makeAppointment(int startPeriod, int endPeriod, int duration)
    {
        for (int period = startPeriod; period <= endPeriod; period++)
        {
            int startMinute = findFreeBlock(period, duration);
            if (startMinute != -1)
            {
                reserveBlock(period, startMinute, duration);
                return true;
            }
        }
        return false; // No available time slot found in the given period range
    }
}
