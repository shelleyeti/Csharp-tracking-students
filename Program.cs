using System;

namespace tracking_student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            var exercise1 = new Exercise("Writing to the Console", "C#");

            // Create 3, or more, cohorts.
            var cohort32 = new Cohort(true, 32);

            // Create 4, or more, students and assign them to one of the cohorts.
            var student1 = new Student("Shelley", "Arnold");


            cohort32.StudnetList.Add(student1);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            var instructor1 = new Instructor("Adam", "Hat");

            cohort32.InstructorList.Add(instructor1);

            // Have each instructor assign 2 exercises to each of the students.
            instructor1.ExerciseAssignment(student1, exercise1);


        }
    }
}
