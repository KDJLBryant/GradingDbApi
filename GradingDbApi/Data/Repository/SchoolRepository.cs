using GradingDB.Data;
using GradingDB.Models;
using GradingDbApi.Controllers;
using GradingDbApi.Data.Interface;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;

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

        public bool DeleteGroup(int id)
        {
            Group chosenGroup;

            using (var db = _dbContext)
            {
                chosenGroup = db.groups.FirstOrDefault(x => x.Id == id);
                if (chosenGroup == null)
                {
                    return false;
                }
                else
                {
                    db.groups.Remove(chosenGroup);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteMark(int id)
        {
            Mark chosenMark;

            using (var db = _dbContext)
            {
                chosenMark = db.marks.FirstOrDefault(x => x.Id == id);
                if (chosenMark == null)
                {
                    return false;
                }
                else
                {
                    db.marks.Remove(chosenMark);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteStudent(int id)
        {
            Student chosenStudent;

            using (var db = _dbContext)
            {
                chosenStudent = db.students.FirstOrDefault(x => x.Id == id);
                if (chosenStudent == null)
                {
                    return false;
                }
                else
                {
                    db.students.Remove(chosenStudent);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteSubject(int id)
        {
            Subject chosenSubject;

            using (var db = _dbContext)
            {
                chosenSubject = db.subjects.FirstOrDefault(x => x.Id == id);
                if (chosenSubject == null)
                {
                    return false;
                }
                else
                {
                    db.subjects.Remove(chosenSubject);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteTeacher(int id)
        {
            Teacher chosenTeacher;

            using (var db = _dbContext)
            {
                chosenTeacher = db.teachers.FirstOrDefault(x => x.Id == id);
                if (chosenTeacher == null)
                {
                    return false;
                }
                else
                {
                    db.teachers.Remove(chosenTeacher);
                    db.SaveChanges();
                    return true;
                }
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
                return db.subjects.Include(t => t.Teachers).FirstOrDefault(x => x.Id == id);
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
                return db.teachers.Include(s => s.Subjects).FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Teacher> GetTeachers()
        {
            using (var db = _dbContext)
            {
                return db.teachers.ToList();
            }
        }

        public Group UpdateGroup(int id, Group group)
        {

            Group chosenGroup;

            using (var db = _dbContext)
            {
                chosenGroup = db.groups.FirstOrDefault(x => x.Id == id);

                if(chosenGroup == null)
                {
                    return null;
                }

                chosenGroup.Name = group.Name;
                db.SaveChanges();

                return chosenGroup;
            }
        }

        public Mark UpdateMark(int id, Mark mark)
        {
            Mark chosenMark;

            using (var db = _dbContext)
            {
                chosenMark = db.marks.FirstOrDefault(x => x.Id == id);

                if (chosenMark == null)
                {
                    return null;
                }

                chosenMark.mark = mark.mark;
                db.SaveChanges();

                return chosenMark;
            }
        }

        public Student UpdateStudent(int id, Student student)
        {
            Student chosenStudent;

            using (var db = _dbContext)
            {
                chosenStudent = db.students.FirstOrDefault(x => x.Id == id);

                if (chosenStudent == null)
                {
                    return null;
                }

                chosenStudent.FirstName = student.FirstName;
                chosenStudent.LastName = student.LastName;
                db.SaveChanges();

                return chosenStudent;
            }
        }

        public Subject UpdateSubject(int id, Subject subject)
        {
            Subject chosenSubject;

            using (var db = _dbContext)
            {
                chosenSubject = db.subjects.FirstOrDefault(x => x.Id == id);

                if (chosenSubject == null)
                {
                    return null;
                }

                chosenSubject.Title = subject.Title;

                db.SaveChanges();

                return chosenSubject;
            }
        }

        public Teacher UpdateTeacher(int id, Teacher teacher)
        {
            Teacher chosenTeacher;

            using (var db = _dbContext)
            {
                chosenTeacher = db.teachers.FirstOrDefault(x => x.Id == id);

                if (chosenTeacher == null)
                {
                    return null;
                }

                chosenTeacher.FirstName = teacher.FirstName;
                chosenTeacher.LastName = teacher.LastName;

                db.SaveChanges();

                return chosenTeacher;
            }
        }
    }
}
