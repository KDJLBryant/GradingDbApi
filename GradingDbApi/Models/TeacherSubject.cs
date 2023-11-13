using GradingDB.Models;

namespace GradingDbApi.Models
{
    public class TeacherSubject
    {
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }
        public int SubjectId { get; set; }
        public Subject subject { get; set; }
    }
}
