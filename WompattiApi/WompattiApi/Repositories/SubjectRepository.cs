using System.Collections.Generic;
using WompattiApi.Models;
using System.Linq;

namespace WompattiApi.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly WompattidbContext _context;

        public SubjectRepository(WompattidbContext context)
        {
            _context = context;
        }

        public Subject CreateSubject(Subject subject)
        {
            _context.Add(subject);
            _context.SaveChanges();
            return subject;
        }

        public Subject ReadSubject(long id)
        {
            return _context.Subject
                .Where(s => s.Id == id)
                .FirstOrDefault(s => s.Id == id);
        }

        public List<Subject> ReadSubjects()
        {
            return _context.Subject
                .ToList();
        }

        public List<Subject> ReadSubjects(string searchSubject)
        {
            return _context.Subject
                .Where(s => s.Title.Contains(searchSubject))
                .ToList();
        }

        public Subject UpdateSubject(Subject subject)
        {
            _context.Update(subject);
            _context.SaveChanges();
            return subject;
        }
    }
}