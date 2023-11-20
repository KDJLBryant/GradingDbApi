using GradingDB.Models;
using GradingDbApi.Controllers;
using GradingDbApi.Data.Interface;

namespace GradingDbApi.Data.Repository
{
    public class MockRepository : IRepository
    {

        List<Group> Groups = new List<Group>()
        {
            new Group() { Id = 1, Name = "Mock-Smarties" },
            new Group() { Id = 2, Name = "Mock-Dumbos" }
        };
        List<Student> Students = new List<Student>()
        {
            new Student() { Id = 1, FirstName = "Mock-Kyle", LastName = "Bryant", GroupId = 1 },
            new Student() { Id = 2, FirstName = "Mock-Halla", LastName = "Margret", GroupId = 2 }
        };
        List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher() { Id = 1, FirstName = "Mock-Jim", LastName = "Mgill" },
            new Teacher() { Id = 2, FirstName = "Mock-Chuck", LastName = "Mgill" }
        };
        List<Subject> Subjects = new List<Subject>()
        {
            new Subject() { Id = 1, Title = "Mock-Maths" },
            new Subject() { Id = 2, Title = "Mock-Programming" }
        };
        List<Mark> Marks = new List<Mark>()
        {
            new Mark() { Id = 1, mark = 5, StudentId = 1, SubjectId = 1, DateTime = DateTime.Now },
            new Mark() { Id = 2, mark = 8, StudentId = 2, SubjectId = 2, DateTime = DateTime.Now }
        };

        public MockRepository()
        {

        }

        public void CreateGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public void CreateMark(Mark mark)
        {
            throw new NotImplementedException();
        }

        public void CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void CreateSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void CreateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGroup(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMark(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSubject(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroup(int id)
        {
            return Groups.FirstOrDefault(x => x.Id == id);
        }

        public List<Group> GetGroups()
        {
            return Groups;
        }

        public Mark GetMark(int id)
        {
            return Marks.FirstOrDefault(x => x.Id == id);
        }

        public List<Mark> GetMarks()
        {
            return Marks;
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public Subject GetSubject(int id)
        {
            return Subjects.FirstOrDefault(x => x.Id == id);
        }

        public List<Subject> GetSubjects()
        {
            return Subjects;
        }

        public Teacher GetTeacher(int id)
        {
            return Teachers.FirstOrDefault(x => x.Id == id);
        }

        public List<Teacher> GetTeachers()
        {
            return Teachers;
        }

        public Group UpdateGroup(int id, Group group)
        {
            throw new NotImplementedException();
        }

        public Mark UpdateMark(int id, Mark mark)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public Subject UpdateSubject(int id, Subject subject)
        {
            throw new NotImplementedException();
        }

        public Teacher UpdateTeacher(int id, Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
