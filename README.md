# Appointment Scheduler

## Author: Daniil Nasadiuk

### Responsibilities:
- I implemented the appointment scheduling system, which includes managing available time blocks and reserving them for appointments. 
- My role was to add the core functionality for checking free time, reserving time blocks, and making appointments across different periods.
- I also added test cases to verify that the functions work as expected.

### Functions I Added:

1. **`isMinuteFree(int period, int minute)`**: 
   - Checks if a specific minute in a given period is free.

2. **`reserveBlock(int period, int startMinute, int duration)`**:
   - Reserves a block of time in a specific period for a given duration.

3. **`findFreeBlock(int period, int duration)`**:
   - Finds a free block of time for the requested duration within a period.

4. **`makeAppointment(int startPeriod, int endPeriod, int duration)`**:
   - Attempts to make an appointment across multiple periods if a free block is available.

### Test Cases I Added:

1. **Test Case 1: Finding a Free Block**
   - Tests if a free 15-minute block can be found in period 2.

2. **Test Case 2: Making an Appointment**
   - Tests if a 20-minute appointment can be successfully booked across periods 2 to 4.

3. **Test Case 3: Booking a Smaller Appointment**
   - Tests if a 5-minute appointment can be booked in periods 3 and 4.

4. **Test Case 4: Trying to Book an Appointment that is Too Long**
   - Tests if a 50-minute appointment can be booked across periods 1 to 3.

### Conclusion:
I developed the scheduling functionality for managing time blocks and handling appointments, ensuring that users can book available time slots effectively. The test cases were added to verify the functionality and ensure that the system behaves as expected.

