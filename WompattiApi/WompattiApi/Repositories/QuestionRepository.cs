using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly WompattidbContext _context;

        public QuestionRepository(WompattidbContext context)
        {
            _context = context;
        }

        public Question CreateQuestion(Question question)
        {
            _context.Add(question);
            _context.SaveChanges();
            return question;
        }

        public Question ReadQuestion(long id)
        {
            return _context.Question
                .Where(q => q.Id == id)
                .FirstOrDefault(q => q.Id == id);
        }

        public List<Question> ReadQuestions()
        {
            return _context.Question
                .ToList();
        }

        public List<Question> ReadQuestions(string searchQuestion)
        {
            return _context.Question
                .Where(q => q.Title.Contains(searchQuestion))
                .ToList();
        }

        public List<Question> ReadQuestionsFromSubject (long id)
        {
            return _context.Question
                .Where(q => q.Subject.Id == id)
                .ToList();
        }

        public Question UpdateQuestion(Question question)
        {
            _context.Update(question);
            _context.SaveChanges();
            return question;
        }
    }
}
