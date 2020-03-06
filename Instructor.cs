using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public string Specialty { get; set; }

        public Instructor (string firstName, string lastName, string slackHandle, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Specialty = specialty;
        }

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