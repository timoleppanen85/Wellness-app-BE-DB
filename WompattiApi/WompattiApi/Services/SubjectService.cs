using System.Collections.Generic;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public Subject CreateSubject(Subject subject)
        {
            return _subjectRepository.CreateSubject(subject);
        }

        public Subject ReadSubject(long id)
        {
            return _subjectRepository.ReadSubject(id);
        }

        public List<Subject> ReadSubjects()
        {
            return _subjectRepository.ReadSubjects();
        }

        public List<Subject> ReadSubjects(string title)
        {
            return _subjectRepository.ReadSubjects(title);
        }

        public Subject UpdateSubject(Subject subject, long id)
        {
            if (subject != null)
            {
                if (subject.Id.Equals(id))
                {
                    return _subjectRepository.UpdateSubject(subject);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}