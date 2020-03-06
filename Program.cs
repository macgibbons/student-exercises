using System;

namespace StudentExercises
{
    class Program
    {
        static void Main (string[] args)
        {
            // ----------EXERCISES ----------
            Exercise CityPlanner = new Exercise ("C #")
            {
                Name = "City Planner"
            };
            Exercise EyesOnThesky = new Exercise ("JavaScript")
            {
                Name = "Eyes on the Sky"
            };
            Exercise FlexboxFroggy = new Exercise ("CSS")
            {
                Name = "Flexbox Froggy"
            };
            Exercise Glassdale = new Exercise ("JavaScript")
            {
                Name = "Glassdale PD"
            };
            Exercise ReactNutshell = new Exercise ("React")
            {
                Name = "React Nutshell"
            };

            // ----------COHORTS----------
            Cohort C36 = new Cohort
            {
                CohortName = "Day Cohort 36"
            };
            Cohort C37 = new Cohort
            {
                CohortName = "Day Cohort 37"
            };
            Cohort C38 = new Cohort
            {
                CohortName = "Day Cohort 38"
            };
            Cohort C39 = new Cohort
            {
                CohortName = "Day Cohort 39"
            };

            // ----------STUDENTS----------
            Student Mac = new Student ("Mac", "Gibbons", "macgibbons");

            Student Kurt = new Student ("Kurt", "Krafft", "Kurtster");

            Student Garrett = new Student ("Garret", "Freshwater", "Gfresh69");

            Student Kevin = new Student ("Kevin", "Penny", "KevtheDev");

            C37.CohortStudents.Add (Mac);
            C38.CohortStudents.Add (Kurt);
            C39.CohortStudents.Add (Garrett);
            C36.CohortStudents.Add (Kevin);

            Instructor Adam = new Instructor ("Adam", "Sheaffer", "adamsheaf", "Angular");
            Instructor Steve = new Instructor ("Steve", "Brownlee", "Chortlehort", "Dad Jokes");
            Instructor Leah = new Instructor ("Leah", "Hoefling", "leah", "Taking Care of Splant");
            Instructor Brenda = new Instructor ("Brenda", "Long", "bjlong", "UX/UI");

            C37.CohortInstructors.Add (Adam);
            C38.CohortInstructors.Add (Leah);
            C39.CohortInstructors.Add (Steve);
            C36.CohortInstructors.Add (Brenda);
        }
    }
}

// Create 4, or more, exercises.
// Create 3, or more, cohorts.
// Create 4, or more, students and assign them to one of the cohorts.
// Create 3, or more, instructors and assign them to one of the cohorts.
// Have each instructor assign 2 exercises to each of the students.