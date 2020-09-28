using System.Collections.Generic;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public interface ISubjectRepository
    {
        Subject CreateSubject(Subject subject);
        Subject ReadSubject(long id);
        List<Subject> ReadSubjects();
        List<Subject> ReadSubjects(string searchSubject);
        Subject UpdateSubject(Subject subject);
    }
}