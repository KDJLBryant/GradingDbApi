using GradingDB.Data;
using GradingDB.Models;
using GradingDbApi.Controllers;
using GradingDbApi.Data.Interface;

namespace GradingDbApi.Data.Repository
{
    public class SchoolRepository : IRepository
    {
        private readonly GradingContext _dbContext;

        public SchoolRepository()
        {
            _dbContext = new GradingContext();
        }

        public void CreateGroup(Group group)
        {
            using (var db = _dbContext)
            {
                db.groups.Add(group);
                db.SaveChanges();
            }
        }

        public void CreateMark(Mark mark)
        {
            using (var db = _dbContext)
            {
                db.marks.Add(mark);
                db.SaveChanges();
            }
        }

        public void CreateStudent(Student student)
        {
            using (var db = _dbContext)
            {
                db.students.Add(student);
                db.SaveChanges();
            }
        }

        public void CreateSubject(Subject subject)
        {
            using (var db = _dbContext)
            {
                db.subjects.Add(subject);
                db.SaveChanges();
            }
        }

        public void CreateTeacher(Teacher teacher)
        {
            using (var db = _dbContext)
            {
                db.teachers.Add(teacher);
                db.SaveChanges();
            }
        }

        public Group GetGroup(int id)
        {
            using (var db = _dbContext)
            {
                return db.groups.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Group> GetGroups()
        {
            using (var db = _dbContext)
            {
                return db.groups.ToList();
            }
        }

        public Mark GetMark(int id)
        {
            using (var db = _dbContext)
            {
                return db.marks.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Mark> GetMarks()
        {
            using (var db = _dbContext)
            {
                return db.marks.ToList();
            }
        }

        public Student GetStudent(int id)
        {
            using (var db = _dbContext)
            {
                return db.students.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Student> GetStudents()
        {
            using (var db = _dbContext)
            {
                return db.students.ToList();
            }
        }

        public Subject GetSubject(int id)
        {
            using (var db = _dbContext)
            {
                return db.subjects.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Subject> GetSubjects()
        {
            using (var db = _dbContext)
            {
                return db.subjects.ToList();
            }
        }

        public Teacher GetTeacher(int id)
        {
            using (var db = _dbContext)
            {
                return db.teachers.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Teacher> GetTeachers()
        {
            using (var db = _dbContext)
            {
                return db.teachers.ToList();
            }
        }
    }
}
