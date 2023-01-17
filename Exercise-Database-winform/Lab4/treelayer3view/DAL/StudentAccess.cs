using DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentAccess : DatabaseAccess
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            NpgsqlCommand command = new NpgsqlCommand("select * from student", connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);

                students.Add(new Student(studentID, name, classID));

            }
            connection.Close();
            return students;
        }
    }
}
