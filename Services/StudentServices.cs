

namespace Branches_Practice.Services
{
    public class StudentServices : IStudentServices
    {
        
        List<string> _studentList = ["Brandon Langehennig", "Student 2", "Jacob"];
        
        
        
        public List<string> StudentGetAll()
        {
            return _studentList;
        }

        public int StudentCount()
        {
            return ;
        }

    }
}