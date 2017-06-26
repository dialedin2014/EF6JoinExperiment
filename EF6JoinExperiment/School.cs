using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6JoinExperiment
{
    public static class School 
    {
        public static string GetStudentSeatLabel()
        {
            var context = new Ef6JoinExperimentEntities();
            context.Database.Log = s => Debug.WriteLine(s);

            var result = context.Students
                .Where(s => s.FirstName == "Joe" && s.LastName == "Smith")
                .Select( s=>s.Seat.SeatLabel).First();

            return result;
        }
        public static List<string> GetStudentTutors()
        {
            var context = new Ef6JoinExperimentEntities();
            context.Database.Log = s => Debug.WriteLine(s);
            var result = context.Students
                .Where(s => s.TutorId != null)
                .Select(s => string.Concat(s.FirstName, " is tutored by ", s.Tutor.FirstName))
                .ToList();

            return result;
        }
        public static List<string> GetStudentsWithNationallyCertifiedTutor()
        {
            var context = new Ef6JoinExperimentEntities();
            context.Database.Log = s => Debug.WriteLine(s);

            var result = context.Students
                .Where(s => s.Tutor.AssociationMemberships
                    .Any(am=>am.TutorAssociation.Name 
                        == "National Tutor Association"))
                .Select(s => s.FirstName)
                .ToList();
            
            return result;
        }

        public static List<string> GetClassroomSeats()
        {
            var context = new Ef6JoinExperimentEntities();
            context.Database.Log = s => Debug.WriteLine(s);

            var result = context.Classrooms
                .FirstOrDefault(c => c.RoomNumber == 100)
                .ClassroomSeats
                .Select(cs => cs.Seat.SeatLabel)
                .ToList();

            result = context.ClassroomSeats
                .Where(cs=>cs.Classroom.RoomNumber == 100)
                .Select(cs => cs.Seat.SeatLabel)
                .ToList();
            return result;
        }
    }
}
