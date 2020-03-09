using System;

namespace StudentExercises
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }

        public Exercise (string language)
        {
            Language = language;
        }
    }
}