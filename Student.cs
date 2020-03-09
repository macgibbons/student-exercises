using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort cohort { get; set; }
        public List<Exercise> StudentsExercises { get; set; } = new List<Exercise> ();

        public Student (string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;

        }

        public void AssignStudentCohort (Cohort cohort, Student student)
        {
            cohort.CohortStudents.Add (student);

        }

    }
}

// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on