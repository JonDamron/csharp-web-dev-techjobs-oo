using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.AreEqual(testJob1, testJob2);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName, "ACME");
            Assert.AreEqual(testJob.EmployerLocation, "Desert");
            Assert.AreEqual(testJob.JobType, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency, "Persistance");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJobEquals1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Job testJobEquals2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.IsFalse(testJobEquals1.Equals(testJobEquals2));
        }
    }
}
