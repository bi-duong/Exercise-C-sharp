using DTO;
using DAL;
namespace BLL
{
    public class StudentAccessBLL
    {
        public StudentAccess StudentAccess = new StudentAccess();

        public List<Student> GetStudents()
        {
            return StudentAccess.GetStudents();
        }

        public bool InsertStudent(Student student)
        {
            if (StudentAccess.InsertStudent(student))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            if (StudentAccess.UpdateStudent(student))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteStudent(string studentID)
        {
            if (StudentAccess.DeleteStudent(studentID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}