using System;

namespace MyPersonalWebsite.Models
{
    public class Experience
    {
        public Personal Id { get; }
        public int ExpId { get; }
        public string CompanyName { get; }
        public string CompanyAddress { get; }
        public string Country { get; }
        public string City { get; }
        public string CompanyWebsite { get; }
        public DateTime ContractStart { get; }
    }
}
