using System.Collections.Generic;

namespace tracking_student_exercises
{
    public class Instructor : People
    {
        private List<Cohort> _cohortList;
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