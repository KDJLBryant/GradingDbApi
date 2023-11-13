using GradingDB.Models;

namespace GradingDbApi.Data
{
    public interface IRepository
    {

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
    }
}
