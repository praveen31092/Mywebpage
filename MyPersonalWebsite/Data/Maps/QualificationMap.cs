using FluentNHibernate.Mapping;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.Data.Maps
{
    public class QualificationMap : ClassMap<Qualification>
    {
        public QualificationMap()
        {
            Table("qualification");
            References(x => x.Id, "persId");
            Map(x => x.QualiId, "QualId");
            Map(x => x.QualificationName, "nameOfTheQualification");
            Map(x => x.Start, "yearOfSatrt");
            Map(x => x.End, "YearOfPass");
            Map(x => x.University, "UniversityName");
            Map(x => x.Place, "placeOFTheUniversity");
            Map(x => x.Department, "Department");
        }
    }
}
