namespace DTO
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ClassID { get; set; }

        public Student(string id, string name, string classId)
        {
            ID = id;
            Name = name;
            ClassID = classId;
        }
    }
}