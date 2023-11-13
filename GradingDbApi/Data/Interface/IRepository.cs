using GradingDB.Models;

namespace GradingDbApi.Data.Interface
{
    public interface IRepository
    {
        // Get
        List<Group> GetGroups();
        Group GetGroup(int id);
        List<Mark> GetMarks();
        Mark GetMark(int id);
        List<Student> GetStudents();
        Student GetStudent(int id);
        List<Subject> GetSubjects();
        Subject GetSubject(int id);
        List<Teacher> GetTeachers();
        Teacher GetTeacher(int id);
        // Create
        void CreateGroup(Group group);
        void CreateMark(Mark mark);
        void CreateStudent(Student student);
        void CreateSubject(Subject subject);
        void CreateTeacher(Teacher teacher);
    }
}
