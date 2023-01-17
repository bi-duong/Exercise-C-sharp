using DTO;
using DAL;
using DTO;
namespace BLL
{
    public class StudentAccessBLL
    {
        public StudentAccess StudentAccess = new StudentAccess();

        public List<Student> GetStudents()
        {
            return StudentAccess.GetStudents();
        }
    }
}