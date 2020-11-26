using LibraryManager.Application.DTO.DTO;
using LibraryManager.Application.Interfaces;
using LibraryManager.Util.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroApplicationService _livroApplicationService;

        public LivroController(ILivroApplicationService livroApplicationService)
        {
            _livroApplicationService = livroApplicationService;
        }

        [HttpGet]
        public ActionResult<List<LivroDTO>> Get()
        {
            try
            {
                return Ok(_livroApplicationService.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetExceptionMessage() });
            }
        }

        // GET api/<LivroController>/5
        [HttpGet("{id}")]
        public ActionResult<LivroDTO> Get(int id)
        {
            try
            {
                return Ok(_livroApplicationService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetExceptionMessage() });
            }
        }

        // POST api/<LivroController>
        [HttpPost]
        public ActionResult<LivroDTO> Post([FromBody] LivroDTO livro)
        {
            try
            {
                return Ok(_livroApplicationService.Add(livro));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetExceptionMessage() });
            }
        }

        // PUT api/<LivroController>/5
        [HttpPut("{id}")]
        public ActionResult<LivroDTO> Put(int id, [FromBody] LivroDTO livro)
        {
            try
            {
                return Ok(_livroApplicationService.Update(id, livro));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetExceptionMessage() });
            }
        }

        // DELETE api/<LivroController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _livroApplicationService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetExceptionMessage() });
            }
        }
    }
}
