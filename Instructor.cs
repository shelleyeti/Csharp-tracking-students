using System;
using System.Collections.Generic;

namespace tracking_student_exercises
{
    public class Instructor
    {
        private List<Cohort> _cohortList;
        public string FirstName;
        public string LastName;
        public string SlackHandle;
        public List<Cohort> CohortList
        {
            get
            {
                return _cohortList;
            }
            set
            {
                _cohortList = value;
            }
        }
        public string Specailty;


        public void ExerciseAssignment(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }

        public Instructor(string first, string last)
        {
            FirstName = first;
            LastName = last;
            _cohortList = new List<Cohort>();
        }
    }
}