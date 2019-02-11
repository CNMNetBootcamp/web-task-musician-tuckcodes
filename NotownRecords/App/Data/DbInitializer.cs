//using App.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace App.Data
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(StudioContext context)
//        {
//            context.Database.EnsureCreated();

//            // Look for any musicians.
//            if (context.Musicians.Any())
//            {
//                return;   // DB has been seeded
//            }

//            var musicians = new Musician[]
//            {
//            new Musician{FirstName="Carson",LastName="Alexander",SSN=123121234,Address=null},
//            new Musician{FirstName="Meredith",LastName="Alonso",SSN=123121234,Address=null},
//            new Musician{FirstName="Arturo",LastName="Anand",SSN=123121234,Address=null},
//            new Musician{FirstName="Gytis",LastName="Barzdukas",SSN=123121234,Address=null},
//            new Musician{FirstName="Yan",LastName="Li",SSN=123121234,Address=null},
//            new Musician{FirstName="Peggy",LastName="Justice",SSN=123121234,Address=null},
//            new Musician{FirstName="Laura",LastName="Norman",SSN=123121234,Address=null},
//            new Musician{FirstName="Nino",LastName="Olivetto",SSN=123121234,Address=null}
//            };
//            foreach (Musician s in musicians)
//            {
//                context.Students.Add(s);
//            }
//            context.SaveChanges();

//            var courses = new Course[]
//            {
//            new Course{CourseID=1050,Title="Chemistry",Credits=3},
//            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
//            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
//            new Course{CourseID=1045,Title="Calculus",Credits=4},
//            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
//            new Course{CourseID=2021,Title="Composition",Credits=3},
//            new Course{CourseID=2042,Title="Literature",Credits=4}
//            };
//            foreach (Course c in courses)
//            {
//                context.Courses.Add(c);
//            }
//            context.SaveChanges();

//            var enrollments = new Enrollment[]
//            {
//            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
//            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
//            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
//            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
//            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
//            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
//            new Enrollment{StudentID=3,CourseID=1050},
//            new Enrollment{StudentID=4,CourseID=1050},
//            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
//            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
//            new Enrollment{StudentID=6,CourseID=1045},
//            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
//            };
//            foreach (Enrollment e in enrollments)
//            {
//                context.Enrollments.Add(e);
//            }
//            context.SaveChanges();
//        }
//    }
//}
