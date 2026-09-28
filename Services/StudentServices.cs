

namespace Branches_Practice.Services
{
    public class StudentServices : IStudentServices
    {
        
        List<string> _studentList = ["Brandon Langehennig", "Isaiah", "Student 3"];
        
        
        
        public List<string> StudentGetAll()
        {
            return _studentList;
        }

    }
}