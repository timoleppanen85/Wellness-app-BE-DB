using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public interface IQuestionRepository
    {
        Question CreateQuestion(Question question);
        Question ReadQuestion(long id);
        List<Question> ReadQuestions();
        List<Question> ReadQuestions(string searchQuestion);
        List<Question> ReadQuestionsFromSubject (long id);
        Question UpdateQuestion(Question question);
    }
}
