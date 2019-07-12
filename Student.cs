using System;
using System.Collections.Generic;

namespace tracking_student_exercises
{
    public class Student
    {
        private List<Exercise> _exerciseList;
        public string FirstName;
        public string LastName;
        public string SlackHandle;
        public List<Exercise> ExerciseList
        {
            get
            {
                return _exerciseList;
            }
            set
            {
                _exerciseList = value;
            }
        }
        public Student(string first, string last)
        {
            FirstName = first;
            LastName = last;
            _exerciseList = new List<Exercise>();
        }

    }
}