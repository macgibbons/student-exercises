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
        }
    }
}

// Create 4, or more, exercises.
// Create 3, or more, cohorts.
// Create 4, or more, students and assign them to one of the cohorts.
// Create 3, or more, instructors and assign them to one of the cohorts.
// Have each instructor assign 2 exercises to each of the students.