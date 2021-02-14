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
            Assert.AreNotEqual(testJob1.Id, testJob2.Id);
            Assert.IsTrue(testJob2.Id == (testJob1.Id + 1));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.Value, "Persistance");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJobEquals1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Job testJobEquals2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.IsFalse(testJobEquals1.Equals(testJobEquals2));
        }

        [TestMethod]
        public void TestToString()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            string expectedTestString = $"\n ID: {testJob.Id}\n Name: {testJob.Name}\n Employer: {testJob.EmployerName}\n Location: {testJob.EmployerLocation}\n Position Type: {testJob.JobType}\n Core Competency: {testJob.JobCoreCompetency}\n";
            Assert.AreEqual(testJob.ToString(), expectedTestString);
        }

        [TestMethod]
        public void TestToString2()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location(" "), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            string expectedTestString = $"\n ID: {testJob.Id}\n Name: {testJob.Name}\n Employer: {testJob.EmployerName}\n Location: Data not available \n Position Type: {testJob.JobType}\n Core Competency: {testJob.JobCoreCompetency}\n";
            Assert.AreEqual(testJob.ToString(), expectedTestString);
        }
    }
}
