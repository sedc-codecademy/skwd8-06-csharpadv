List <user> users = UserService.populateUsers();
int counter = 0;
int score = 0;
bool IsLoggedIn = false;
List<user> usrsTested = new List<user>();

TRY{

        // Prompt user to enter username -> string username = Readline()
        // check if the username exist
		//(a method in UserService that will query the List provided for the given username)
        // user userToCheck = CheckUsername()
		// method accepts username & users
		// (LINQ -> query users where user.Usename = username)
		// returns user object
	// Use if else logic to determine whether it exists or not (null or user object returned))
        // prompt user to enter password -> string password = Readline()
        // check whether password == userToCheck.Password (returned user object from CheckUsername())
        	// (if true -> continue to check user Role {if user.Role == Role.Teacher or Role.Student}
			// else counter++)
        // if counter == 3 -> return (terminate) application
	// check if the user has taken the Quiz already (query with LINQ the usrsTested List for the current user)
	
//IF EVERYTHING PASSED SET THE bool IsLoggedIn VARIABLE TO TRUE (this means someone is logged in right now)
	
        //case when User is Student
        	// Class Question (properties: string question, int correct answer)
		// Instantiate objects of Question Class for every question of the Data
		// create a list with the questions
        	// start for loop that goes to the length of the Question List (or use foreach)
        		// Writeline 1st Question -> 
        		// Readline 1st answer -> validate answer 
				// check if it is integer 
				// check if it is 1 to 4.
					// If not show appropriate message and terminate, 
					// if yes add 1 to score and show the score in the console -> WriteLine(score)
		// End of Loop ->
			// usrsTested.Add(current user) 
			// Log out current user (set bool variable to false)

        //case when User is Teacher
        	// Print in console (a service method that accepts List of users to print or simple printing in the main program of every element of the List:
			//green color -> users from usrsTested 
			//red color the list of users that are not equal to usrsTested 
				(LINQ -> query List users for users that are NOT in usrsTested)
        	//Enter pressed logs the teacher out (set bool variable to false)
}
CATCH {
	// catch all the exceptions with multiple catch blocks (format exception, global exception etc.)
	// print appropriate message and 
	// then terminate the execution
}