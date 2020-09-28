using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        public ActionResult<Subject> CreateSubject(Subject subject)
        {
            return new JsonResult(_subjectService.CreateSubject(subject));
        }

        [HttpGet]
        public ActionResult<List<Subject>> ReadSubjects()
        {
            return new JsonResult(_subjectService.ReadSubjects());
        }

        [HttpGet("{id}")]
        public ActionResult<Subject> ReadSubject(long id)
        {
            return new JsonResult(_subjectService.ReadSubject(id));
        }

        [HttpGet("search/{title}")]
        public ActionResult<List<Subject>> ReadSubjects(string title)
        {
            return new JsonResult(_subjectService.ReadSubjects(title));
        }

        [HttpPut("{id}")]
        public ActionResult<Subject> UpdateSubject(Subject subject, long id)
        {
            return new JsonResult(_subjectService.UpdateSubject(subject, id));
        }
        
    }
}