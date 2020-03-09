using System;
using System.Collections.Generic;
using System.Linq;

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
            Student Audrey = new Student ("Audrey", "Borgra", "KevtheDev");
            Student Jansen = new Student ("Jansen", "Van der Spuy", "KevtheDev");
            Student Namita = new Student ("Namita", "Manohor", "KevtheDev");

            // ---------Student enrolment---------
            C37.CohortStudents.Add (Mac);
            C37.CohortStudents.Add (Audrey);
            C37.CohortStudents.Add (Jansen);
            C37.CohortStudents.Add (Namita);
            C38.CohortStudents.Add (Kurt);
            C39.CohortStudents.Add (Garrett);
            C36.CohortStudents.Add (Kevin);

            // ----------INSTRUCTORS----------
            Instructor Adam = new Instructor ("Adam", "Sheaffer", "adamsheaf", "Angular");
            Instructor Steve = new Instructor ("Steve", "Brownlee", "Chortlehort", "Dad Jokes");
            Instructor Leah = new Instructor ("Leah", "Hoefling", "leah", "Taking Care of Splant");
            Instructor Brenda = new Instructor ("Brenda", "Long", "bjlong", "UX/UI");

            // ----------Instructor Placement -----------
            C37.CohortInstructors.Add (Adam);
            C38.CohortInstructors.Add (Leah);
            C39.CohortInstructors.Add (Steve);
            C36.CohortInstructors.Add (Brenda);

            // ----------Student Assigment----------
            Adam.AssignStudentExercise (CityPlanner, Mac);
            Adam.AssignStudentExercise (EyesOnThesky, Mac);
            Adam.AssignStudentExercise (CityPlanner, Garrett);
            Adam.AssignStudentExercise (EyesOnThesky, Garrett);
            Adam.AssignStudentExercise (ReactNutshell, Kurt);
            Adam.AssignStudentExercise (EyesOnThesky, Kurt);
            Adam.AssignStudentExercise (Glassdale, Kevin);
            Adam.AssignStudentExercise (FlexboxFroggy, Kevin);

            Leah.AssignStudentExercise (FlexboxFroggy, Mac);
            Leah.AssignStudentExercise (Glassdale, Mac);
            Leah.AssignStudentExercise (FlexboxFroggy, Garrett);
            Leah.AssignStudentExercise (Glassdale, Garrett);
            Leah.AssignStudentExercise (CityPlanner, Kurt);
            Leah.AssignStudentExercise (FlexboxFroggy, Kurt);
            Leah.AssignStudentExercise (ReactNutshell, Kevin);
            Leah.AssignStudentExercise (EyesOnThesky, Kevin);

            Steve.AssignStudentExercise (ReactNutshell, Mac);
            Steve.AssignStudentExercise (FlexboxFroggy, Mac);
            Steve.AssignStudentExercise (ReactNutshell, Garrett);
            Steve.AssignStudentExercise (FlexboxFroggy, Garrett);
            Steve.AssignStudentExercise (ReactNutshell, Kurt);
            Steve.AssignStudentExercise (EyesOnThesky, Kurt);
            Steve.AssignStudentExercise (Glassdale, Kevin);
            Steve.AssignStudentExercise (FlexboxFroggy, Kevin);

            Brenda.AssignStudentExercise (FlexboxFroggy, Mac);
            Brenda.AssignStudentExercise (Glassdale, Mac);
            Brenda.AssignStudentExercise (FlexboxFroggy, Garrett);
            Brenda.AssignStudentExercise (Glassdale, Garrett);
            Brenda.AssignStudentExercise (CityPlanner, Kurt);
            Brenda.AssignStudentExercise (FlexboxFroggy, Kurt);
            Brenda.AssignStudentExercise (ReactNutshell, Kevin);
            Brenda.AssignStudentExercise (EyesOnThesky, Kevin);

            List<Student> students = new List<Student> ();
            students.Add (Mac);
            students.Add (Kevin);
            students.Add (Garrett);
            students.Add (Kurt);
            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (EyesOnThesky);
            exercises.Add (ReactNutshell);
            exercises.Add (FlexboxFroggy);
            exercises.Add (Glassdale);
            exercises.Add (CityPlanner);
            List<Cohort> cohorts = new List<Cohort> ();
            cohorts.Add (C37);
            cohorts.Add (C36);
            cohorts.Add (C38);
            cohorts.Add (C39);
            List<Instructor> instructors = new List<Instructor> ()
            {
                Leah,
                Steve,
                Adam,
                Brenda
            };

            var JavascriptExercises = exercises.Where (exercise =>
            {
                return exercise.Language == "JavaScript";
            });
            Console.WriteLine ("JavaScript Exercises");
            foreach (Exercise ex in JavascriptExercises)
            {

                Console.WriteLine (ex.Name);

            }

            var Cohort37 = cohorts.Where (cohort =>
            {
                return cohort == C37;

            }).ToList ();

            foreach (Cohort cohort in Cohort37)
            {
                Console.WriteLine (cohort.CohortName);
                Console.WriteLine ("--------------");
                Console.WriteLine ("****Students****");

                foreach (Student student in cohort.CohortStudents)
                {
                    Console.WriteLine ($"{student.FirstName} {student.LastName}");
                }

                Console.WriteLine ("                ");
                Console.WriteLine ("****Instructors****");
                foreach (Instructor instruc in cohort.CohortInstructors)
                {
                    Console.WriteLine ($"{instruc.FirstName} {instruc.LastName}");
                }
            }

            // foreach (Cohort cohort in cohorts)
            // {
            //     Console.WriteLine ($"********* {cohort.CohortName} *********");
            //     Console.WriteLine ("                ");
            //     foreach (Student student in cohort.CohortStudents)
            //     {
            //         Console.WriteLine ($"{student.FirstName} {student.LastName}");
            //         Console.WriteLine ("--------------");

            //         foreach (Exercise exercise in student.StudentsExercises)
            //         {
            //             Console.WriteLine (exercise.Name);
            //         }

            //     }
            // }

        }

    }
}

// Create 4, or more, exercises.
// Create 3, or more, cohorts.
// Create 4, or more, students and assign them to one of the cohorts.
// Create 3, or more, instructors and assign them to one of the cohorts.
// Have each instructor assign 2 exercises to each of the students.