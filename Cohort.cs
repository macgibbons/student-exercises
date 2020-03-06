using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public List<Student> CohortStudents { get; set; } = new List<Student> ();
        public List<Instructor> CohortInstructors { get; set; } = new List<Instructor> ();
    }
}