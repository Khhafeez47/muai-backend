using DevOpsApp.Models;

namespace DevOpsApp.Interfaces
{
    public interface IStudentService
    {
        Task<bool> PostStudentRecord(Student student);
    }
}
