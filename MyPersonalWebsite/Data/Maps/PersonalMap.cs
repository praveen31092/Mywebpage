using FluentNHibernate.Mapping;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.Data.Maps
{
    public class PersonalMap : ClassMap<Personal>
    {
        public PersonalMap()
        {
            Table("tblpersonal");
            Id(x => x.Id, "persId");
            Map(x => x.FirstName, "firstName");
            Map(x => x.LastName, "lastName");
            Map(x => x.Age, "age");
            Map(x => x.DateOfBirth, "DateOfBirth");
            Map(x => x.Nationality, "Nationality");
            Map(x => x.Address, "address");
            Map(x => x.Country, "countryOfResience");
            Map(x => x.MobileNumber, "mobileNumber");
            Map(x => x.EmailId, "emailId");
            Map(x => x.LinkedUrl, "linkedInUrl");
            Map(x => x.XingUrl, "xing");
        }
    }
}
