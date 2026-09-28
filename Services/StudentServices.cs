

namespace Branches_Practice.Services
{
    public class StudentServices : IStudentServices
    {
        
        List<string> _studentList = ["Student 1", "Student 2", "Student 3"];
        
        
        
        public List<string> StudentGetAll()
        {
            return _studentList;
        }

    }
}