using System;

namespace StudentExercises
{
    public class Exercise
    {
        public string Name { get; set; }
        private string _language { get; set; }

        public Exercise (string language)
        {
            _language = language;
        }
    }
}