﻿using DotNet7WithSqlExample.Gateway;
using DotNet7WithSqlExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet7WithSqlExample.Manager
{
    public class StudentManager
    {
        StudentGateway _studentGateway = new StudentGateway();

        public bool Add(Student student)
        {
            return _studentGateway.Add(student);
        }

        public List<Student> GetAll()
        {
            return _studentGateway.GetAll();
        }

        public bool Update(Student student)
        {
            return _studentGateway.Update(student);
        }

        public bool Delete(int id)
        {
            return _studentGateway.Delete(id);

        }
    }
}
