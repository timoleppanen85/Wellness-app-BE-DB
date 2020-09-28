using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public Answer CreateAnswer(Answer answer)
        {
            return _answerRepository.CreateAnswer(answer);
        }

        public Answer DeleteAnswer(long id)
        {
            Answer answer = ReadAnswer(id);
            return _answerRepository.DeleteAnswer(answer);
        }

        public Answer ReadAnswer(long id)
        {
            return _answerRepository.ReadAnswer(id);
        }

        public List<Answer> ReadAnswersFromQuestion (long id)
        {
            return _answerRepository.ReadAnswersFromQuestion(id);
        }

        public List<Answer> ReadAnswersFromUser (long id)
        {
            return _answerRepository.ReadAnswersFromUser(id);
        }

        public List<Answer> ReadAnswers()
        {
            return _answerRepository.ReadAnswers();
        }

        public Answer UpdateAnswer(Answer answer, long id)
        {
            if (answer != null)
            {
                if (answer.Id.Equals(id))
                {
                    return _answerRepository.UpdateAnswer(answer);
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
