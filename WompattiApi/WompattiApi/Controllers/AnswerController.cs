using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WompattiApi.Services;
using WompattiApi.Models;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;

        public AnswerController (IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpPost]
        public ActionResult<Answer> CreateAnswer (Answer answer)
        {
            return new JsonResult(_answerService.CreateAnswer(answer));
        }

        [HttpGet]
        public ActionResult<List<Answer>> ReadAnswer ()
        {
            return new JsonResult(_answerService.ReadAnswers());
        }

        [HttpGet("{id}")]
        public ActionResult<Answer> ReadAnswer (long id)
        {
            return new JsonResult(_answerService.ReadAnswer(id));
        }

        [HttpGet("user/{id}")]
        public ActionResult<List<Answer>> ReadAnswersFromUser (long id)
        {
            return new JsonResult(_answerService.ReadAnswersFromUser(id));
        }

        [HttpGet("question/{id}")]
        public ActionResult<List<Answer>> ReadAnswersFromQuestion(long id)
        {
            return new JsonResult(_answerService.ReadAnswersFromQuestion(id));
        }

        [HttpPut("{id}")]
        public ActionResult<Answer> UpdateAnswer(Answer answer, long id)
        {
            return new JsonResult(_answerService.UpdateAnswer(answer, id));
        }

        [HttpDelete("{id}")]
        public ActionResult<Answer> DeleteAnswer(long id)
        {
            return new JsonResult(_answerService.DeleteAnswer(id));
        }
    }
}