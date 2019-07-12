using System;

namespace tracking_student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            var exercise1 = new Exercise("Writing to the Console", "C#");
            var exercise2 = new Exercise("Learning JavaScript", "JavaScript");
            var exercise3 = new Exercise("Reacting to React", "React");
            var exercise4 = new Exercise("CSS, It's your Friend", "CSS");

            // Create 3, or more, cohorts.
            var cohort32 = new Cohort(true, 32);
            var cohort33 = new Cohort(true, 33);
            var cohort34 = new Cohort(false, 34);

            // Create 4, or more, students and assign them to one of the cohorts.
            var student1 = new Student("Shelley", "Arnold");
            var student2 = new Student("Emily", "Loggins");
            var student3 = new Student("Heather", "Cleland");
            var student4 = new Student("Eliot", "Clarke");

            cohort32.StudnetList.Add(student1);
            cohort32.StudnetList.Add(student2);
            cohort32.StudnetList.Add(student3);
            cohort32.StudnetList.Add(student4);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            var instructor1 = new Instructor("Adam", "Hat");
            var instructor2 = new Instructor("Jisie", "David");
            var instructor3 = new Instructor("Kristen", "Norris");

            cohort32.InstructorList.Add(instructor1);
            cohort32.InstructorList.Add(instructor2);
            cohort32.InstructorList.Add(instructor3);

            // Have each instructor assign 2 exercises to each of the students.
            instructor1.ExerciseAssignment(student1, exercise1);
            instructor1.ExerciseAssignment(student2, exercise1);

            instructor2.ExerciseAssignment(student3, exercise2);
            instructor2.ExerciseAssignment(student4, exercise2);

            instructor3.ExerciseAssignment(student1, exercise3);
            instructor3.ExerciseAssignment(student2, exercise3);

        }
    }
}
