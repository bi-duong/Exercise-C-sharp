using System.Data;
using Npgsql;
using DTO;
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

        public bool InsertStudent(Student student)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into student (StudentID,SName,ClassID)" +
                                  "values (@StudentID,@SName,@ClassID)";
            NpgsqlParameter parameter1 = new NpgsqlParameter("@StudentID", student.ID);
            NpgsqlParameter parameter2 = new NpgsqlParameter("@SName", student.Name);
            NpgsqlParameter parameter3 = new NpgsqlParameter("@ClassID", student.ClassID);

            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }

        public bool UpdateStudent(Student student)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.Connection = connection;
            //command.CommandText = "update [STUDENT] set [Name] = '@Name', [ClassID] = '@ClassID' where [StudentID] = '@StudentID'";

            //SqlParameter parameter1 = new SqlParameter("@StudentID", student.ID);
            //SqlParameter parameter2 = new SqlParameter("@Name", student.Name);
            //SqlParameter parameter3 = new SqlParameter("@ClassID", student.ClassID);

            //command.Parameters.Add(parameter1);
            //command.Parameters.Add(parameter2);
            //command.Parameters.Add(parameter3);

            NpgsqlCommand command =
                new NpgsqlCommand(
                    $"update student set SName='{student.Name}', ClassID='{student.ClassID}' where StudentID='{student.ID}'", connection);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }

        public bool DeleteStudent(string studentID)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.Connection = connection;
            //command.CommandText = "delete from [STUDENT] where [StudentID] = '@StudentID'";

            //SqlParameter parameter1 = new SqlParameter("@StudentID", studentID);


            //command.Parameters.Add(parameter1);

            NpgsqlCommand command = new NpgsqlCommand($"Delete from student where StudentID='{studentID}'", connection);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }
    }
}