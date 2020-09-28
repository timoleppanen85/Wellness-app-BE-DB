using System.Collections.Generic;
using WompattiApi.Models;

namespace WompattiApi.Services
{
    public interface ISubjectService
    {
        Subject CreateSubject(Subject subject);
        Subject ReadSubject(long id);
        List<Subject> ReadSubjects();
        List<Subject> ReadSubjects(string title);
        Subject UpdateSubject(Subject subject, long id);
    }
}