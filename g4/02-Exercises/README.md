# Quizz App ✍
A school is requesting a quizz app to be developed so that the students can log in, answer questions and get an automatic grade. The students can only solve the quizz once and the teachers can see the results of all the quizzes. 

## Features 🔹
* Log in
  * A student or a teacher can log in
  * Usernames and passwords should be predefined ( created before hand in the system )
* Student logs in
  * A quiz pops up with 5 multiple choice questions ( 4 choices )
  * After the student picks a choice on the 5 answers a grade apears from 1 to 5
  * After that the user is loged out and another user can log in
  * If the same student tries to log in, it should say that they already did the test and log them out
* Teacher logs in
  * All students that did the quiz and have a grade show up in green
  * all the students that did not do the quiz show up in red
  * When hitin enter it logs out the teacher and another user can log in
* Validations
  * All the choices must be numbers from 1 to 4
  * Username must exist in the database
  * Username and Password must match
  * If the username and password do not match 3 times, then close the application

## Data 🔹 

Star after the answer denotes a correct answer

1) Q: Who wrote Mozard's Third Symphony?
    * a: Ludwig van Beethoven
    * b: Wolfgang Amadeus Mozart
    * c: Carl Friedrich Abel *
    * d: Johann Sebastian Bach
2) Q: What animals are the Canary Islands named for?
    * a: Dogs *
    * b: Canaries
    * c: Giraffes
    * d: Lions
3) Q: In which month did the October revolution happen?
    * a: January
    * b: October
    * c: November *
    * d: September
4) Q: What was King George VI's first name?
    * a: George
    * b: James
    * c: Henry
    * d: Albert *
5) Q: Which country makes Panama hats?
    * a: Panama
    * b: Guatemala
    * c: Equador *
    * d: Brazil