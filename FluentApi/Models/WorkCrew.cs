using System;
using System.Collections.Generic;


namespace GroundzKeeper.Data
{
    public class WorkCrew
    {
        //-------------------------------------------------------------------------------------------------------
        // This class is used to group employees into a single work unit.
        //-------------------------------------------------------------------------------------------------------
        public WorkCrew() { }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeProfile> Employees { get; set; }
    }
}
