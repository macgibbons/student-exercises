using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public string specialty { get; set; }

        public void AssignStudentExercise (Exercise exercise, Student student)
        {
            student.StudentsExercises.Add (exercise);
        }
    }
}

// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on