using System.Collections.Generic;

namespace tracking_student_exercises
{
    public class Cohort
    {
        private List<Student> _studentList;
        private List<Instructor> _instructorList;
        public bool IsDayTime;
        public int CohortNum;
        public string CohortName;
        public List<Student> StudentList
        {
            get
            {
                return _studentList;
            }
            set
            {
                _studentList = value;
            }
        }
        public List<Instructor> InstructorList
        {
            get
            {
                return _instructorList;
            }
            set
            {
                _instructorList = value;
            }
        }

        public Cohort(bool isDayTime, int cohortNum)
        {
            IsDayTime = isDayTime;
            CohortNum = cohortNum;
            _studentList = new List<Student>();
            _instructorList = new List<Instructor>();
            if (IsDayTime)
            {
                CohortName = $"Day Cohort {CohortNum}";
            }
            else
            {
                CohortName = $"Night Cohort {CohortNum}";
            }
        }

    }
}