using System;
using System.Collections.Generic;
using System.Linq;

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

            //add exercises to a list
            var exercises = new List<Exercise>() {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };

            // Create 3, or more, cohorts.
            var cohort32 = new Cohort(true, 32);
            var cohort33 = new Cohort(true, 33);
            var cohort34 = new Cohort(false, 34);

            //add cohorts to a list
            var cohorts = new List<Cohort>()
            {
                cohort32,
                cohort33,
                cohort34
            };

            // Create 4, or more, students and assign them to one of the cohorts.
            var student1 = new Student("Shelley", "Arnold");
            var student2 = new Student("Emily", "Loggins");
            var student3 = new Student("Heather", "Cleland");
            var student4 = new Student("Eliot", "Clarke");
            var student5 = new Student("Cavy", "Baby");
            var student6 = new Student("Cerin", "Street");
            var student7 = new Student("Sheba", "Arant");
            var student8 = new Student("Scout", "Dog");

            //add students to a list
            var allStudentList = new List<Student>()
            {
                student1,
                student2,
                student3,
                student4,
                student5,
                student6,
                student7,
                student8
            };


            cohort32.StudentList.Add(student1);
            cohort32.StudentList.Add(student2);
            cohort32.StudentList.Add(student3);
            cohort32.StudentList.Add(student4);


            cohort33.StudentList.Add(student5);
            cohort33.StudentList.Add(student6);
            cohort33.StudentList.Add(student7);
            cohort33.StudentList.Add(student8);


            // Create 3, or more, instructors and assign them to one of the cohorts.
            var instructor1 = new Instructor("Adam", "Hat");
            var instructor2 = new Instructor("Jisie", "David");
            var instructor3 = new Instructor("Kristen", "Norris");

            //add instructors to a list
            var instructorList = new List<Instructor>()
            {
                instructor1,
                instructor2,
                instructor3
            };

            //
            cohort32.InstructorList.Add(instructor1);
            cohort32.InstructorList.Add(instructor2);
            cohort32.InstructorList.Add(instructor3);

            // Have each instructor assign 2 exercises to each of the students.
            instructor1.ExerciseAssignment(student1, exercise1);
            instructor1.ExerciseAssignment(student2, exercise1);

            instructor2.ExerciseAssignment(student3, exercise2);
            instructor2.ExerciseAssignment(student4, exercise2);

            instructor3.ExerciseAssignment(student1, exercise3);

            //LINQ Queries
            //List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<string> jsLessons = from l in exercises
                                            where l.Language == "JavaScript"
                                            select l.Name;
            foreach (var lesson in jsLessons)
            {
                Console.WriteLine($"{lesson} is a lesson about JavaScript");
            }

            //List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<string> studentsInCohort32 = from s in cohort32.StudentList
                                                     where s.FirstName == "Eliot"
                                                     select s.FirstName;
            foreach (var student in studentsInCohort32)
            {
                Console.WriteLine($"{student} is a student in Cohort 32");
            }

            //List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<string> instructorsInCohort32 = from i in cohort32.InstructorList
                                                        where i.LastName == "Hat"
                                                        select i.FirstName;
            foreach (var instructor in instructorsInCohort32)
            {
                Console.WriteLine($"{instructor} is an instructor in Cohort 32");
            }

            //Sort the students by their last name.
            IEnumerable<string> lNameAscending = allStudentList.OrderBy(x => x.LastName).Select(x => x.LastName).ToList();
            foreach (var lname in lNameAscending)
            {
                Console.WriteLine($"Sort students by last name {lname}");
            }

            //Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<string> lazyStudents = allStudentList.Where(x => x.ExerciseList.Count() == 0).Select(x => x.FirstName);
            foreach (var studnetsNoEx in lazyStudents)
            {
                Console.WriteLine($"Student with no exercises {studnetsNoEx}");
            }

            //Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<string> doingTheMost = allStudentList.Where(x => x.ExerciseList.Count() == allStudentList.Max(y => y.ExerciseList.Count())).Select(x => x.FirstName);
            foreach (var most in doingTheMost)
            {
                Console.WriteLine($"The student doing the most is: {most}");
            }

            //How many students in each cohort?
            Console.WriteLine($"Cohort 32 has {cohort32.StudentList.Count()} students");
            Console.WriteLine($"Cohort 33 has {cohort33.StudentList.Count()} students");

        }
    }
}
