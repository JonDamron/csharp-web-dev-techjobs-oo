using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this ()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Name == "")
            {
                Name = "Data not available";
            }

            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }

            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }

            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            string expectedTestString = $"\n ID: {Id}\n Name: {Name}\n Employer: {EmployerName}\n Location: {EmployerLocation}\n Position Type: {JobType}\n Core Competency: {JobCoreCompetency}\n";

            return expectedTestString;
        }
    }
}
