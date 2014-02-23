using System.Collections.Generic;
using TestCaliburnMicro.LibPcl;

namespace TestCaliburnMicro.Services
{
    public class SectionsService
    {
        public IEnumerable<Section> GetSections()
        {
            return new List<Section>
            {
                new Section {Name="Firm Info"},
                new Section {Name="For-Cause Outbreak"},
                new Section {Name="General Info"},
                new Section {Name="Building Info"},
                new Section {Name="Seed Info"},
            };
        }
    }
}
