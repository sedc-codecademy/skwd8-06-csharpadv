1. The app asks for input
2. Readline(userInput)
- Enter day -> WriteLine
  - Readline(day) {(1)try catch logic -> (2)TryParse(userInput)}
- Enter month
  - Readline(month) {(1)try catch logic -> (2)TryParse(userInput)}
- Enter Year
  - Readline(year) {(1)try catch logic -> (2)TryParse(userInput)}

// Im sure that the inputs are numbers!!!
Datetime myDate = new Datetime(day.month.year);

3. //It should show the user a message whether the date they entered is working or not
 - Datetime (myDate) -> DayOfWeek will tell me which day it is
 check IF myDate and day of week != Saturday or Sunday{
	check IF (myDate is not a PRAZNIK)
	  - List<Datetime> praznici query it with LINQ for myDate
WriteLine (raboten e ili ne e)
}

4. Ask user whether he wants to enter another date -> 
	call previous code to run again () or use global while()