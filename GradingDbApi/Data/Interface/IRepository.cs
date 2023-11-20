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
        // Update
        Group UpdateGroup(int id, Group group);
        Mark UpdateMark(int id, Mark mark);
        Student UpdateStudent(int id, Student student);
        Subject UpdateSubject(int id, Subject subject);
        Teacher UpdateTeacher(int id, Teacher teacher);
        // Delete
        bool DeleteGroup(int id);
        bool DeleteMark(int id);
        bool DeleteStudent(int id);
        bool DeleteSubject(int id);
        bool DeleteTeacher(int id);

    }
}
