using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost]
        public ActionResult<Question> CreateQuestion(Question question)
        {
            return new JsonResult(_questionService.CreateQuestion(question));
        }

        [HttpGet]
        public ActionResult<List<Question>> ReadQuestions()
        {
            return new JsonResult(_questionService.ReadQuestions());
        }

        [HttpGet("{id}")]
        public ActionResult<Question> ReadQuestion(long id)
        {
            return new JsonResult(_questionService.ReadQuestion(id));
        }

        [HttpGet("search/{title}")]
        public ActionResult<List<Question>> ReadQuestions(string title)
        {
            return new JsonResult(_questionService.ReadQuestions(title));
        }

        [HttpGet("subject/{id}")]
        public ActionResult<List<Question>> ReadQuestionsFromSubject(long id)
        {
            return new JsonResult(_questionService.ReadQuestionsFromSubject(id));
        }

        [HttpPut("{id}")]
        public ActionResult<Question> UpdateQuestion(Question question, long id)
        {
            return new JsonResult(_questionService.UpdateQuestion(question, id));
        }
    }
}