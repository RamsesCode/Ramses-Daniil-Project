using System;

// These are changes only for Ramses Branch



//Class to go here 


public class Appointment

// Constructor to begin here
{

    
    private List<int>[] reservedMinutes = new List<int>[8]; // Array for the list of periods that are available 

private bool isMinuteFree(int period, int minute)
    {
        
        return true; 
    }

private void reserveBlock(int period, int startMinute, int duration)
    {
        //This will be to reserve a space, we are keeping in the private portion of the constructor 
        Console.WriteLine($"Block reserved from minute {startMinute} for {duration} minutes in period {period}");
    }

    }



//Functions will take place here 






//Function for reserving a block 




//Function for finding free blocks 




//to make appointment 




    
    


    