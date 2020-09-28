using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService (IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public Question CreateQuestion(Question question)
        {
            return _questionRepository.CreateQuestion(question);
        }

        public Question ReadQuestion(long id)
        {
            return _questionRepository.ReadQuestion(id);
        }

        public List<Question> ReadQuestions()
        {
            return _questionRepository.ReadQuestions();
        }

        public List<Question> ReadQuestions(string searchQuestion)
        {
            return _questionRepository.ReadQuestions(searchQuestion);
        }

        public List<Question> ReadQuestionsFromSubject (long id)
        {
            return _questionRepository.ReadQuestionsFromSubject(id);
        }

        public Question UpdateQuestion(Question question, long id)
        {
            if (question != null)
            {
                if (question.Id.Equals(id))
                {
                    return _questionRepository.UpdateQuestion(question);
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
