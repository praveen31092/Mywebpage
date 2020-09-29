using System;

namespace MyPersonalWebsite.Models
{
    public class Qualification
    {
        public Personal Id { get; }
        public int QualiId { get; }
        public string QualificationName { get; }
        public string University { get; }
        public string Department { get; }
        public string Place { get; }
        public DateTime Start { get; }
        public DateTime End { get; }
    }
}
