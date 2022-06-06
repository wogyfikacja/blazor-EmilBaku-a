using System.Collections.Generic;
using System.Linq;

namespace blazor_22c.Data
{
    public class StudentService : IStudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Test",
                    LastName = "Test",
                    Birthdate = new System.DateTime(1990, 1, 1),
                    Studies = "Test",
                    Avatar = "test"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Mariusz",
                    LastName = "Pudzianowski",
                    Birthdate = new System.DateTime(1999, 1, 1),
                    Studies = "Test",
                    Avatar = "test"
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Jan",
                    LastName = "Papaj",
                    Birthdate = new System.DateTime(1992, 1, 1),
                    Studies = "Test",
                    Avatar = "https://i1.sndcdn.com/avatars-000184062541-d79jz9-t500x500.jpg"
                }
            };
        }
        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(e => e.ID == id);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public bool Remove(int id)
        {
            return _students.Remove(_students.FirstOrDefault(e => e.ID == id));
        }
    }
}
