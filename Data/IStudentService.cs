﻿using System.Collections.Generic;

namespace blazor_22c.Data
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool Remove(int id);
    }
}
