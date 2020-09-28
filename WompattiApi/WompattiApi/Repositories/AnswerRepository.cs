using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly WompattidbContext _context;

        public AnswerRepository(WompattidbContext context)
        {
            _context = context;
        }
        public Answer CreateAnswer(Answer answer)
        {
            _context.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        public Answer DeleteAnswer(Answer answer)
        {
            _context.Remove(answer);
            _context.SaveChanges();
            return answer;
        }

        public Answer ReadAnswer(long id)
        {
            return _context.Answer
                .Where(a => a.Id == id)
                .FirstOrDefault(a => a.Id == id);
        }

        public List<Answer> ReadAnswersFromQuestion (long id)
        {
            return _context.Answer
                .Where(a => a.Question.Id == id)
                .ToList();
        }

        public List<Answer> ReadAnswersFromUser (long id)
        {
            return _context.Answer
                .Where(a => a.User.Id == id)
                .ToList();
        }

        public List<Answer> ReadAnswers()
        {
            return _context.Answer
                .ToList();
        }

        public Answer UpdateAnswer(Answer answer)
        {
            _context.Update(answer);
            _context.SaveChanges();
            return answer;
        }
    }
}
