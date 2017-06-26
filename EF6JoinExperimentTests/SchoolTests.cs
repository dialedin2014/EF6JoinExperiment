using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF6JoinExperiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6JoinExperiment.Tests
{
    [TestClass()]
    public class SchoolTests
    {
        [TestMethod()]
        public void GetStudentSeatLabelTest()
        {
            var result = School.GetStudentSeatLabel();
            Assert.AreEqual("1", result);
        }

        [TestMethod()]
        public void GetStudentTutorsTest()
        {
            var result = School.GetStudentTutors();
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void GetStudentsWithNationallyCertifiedTutorTest()
        {
            var result = School.GetStudentsWithNationallyCertifiedTutor();
            Assert.AreEqual("Jane", result[0]);
        }

        [TestMethod()]
        public void GetClassroomSeatsTest()
        {
            var result = School.GetClassroomSeats();
            Assert.AreEqual(1, result.Count());
        }
    }
}