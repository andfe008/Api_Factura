//using DomainModel.Model;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Threading.Tasks;


//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EntryController : ControllerBase
//    {
//        private readonly InvoiceProvider _businessProvider;

//        public EntryController(InvoiceProvider businessProvider)
//        {
//            _businessProvider = businessProvider;
//        }

//        [HttpGet]
//        [ProducesResponseType(typeof(IEnumerable<StudentVm>), (int)HttpStatusCode.OK)]
//        public async Task<IActionResult> Get()
//        {
//            return Ok(await _businessProvider.GetDataStudent());
//        }

//        [HttpGet("{id}")]
//        [ProducesResponseType(typeof(StudentVm), (int)HttpStatusCode.OK)]
//        [ProducesResponseType((int)HttpStatusCode.NotFound)]
//        public async Task<IActionResult> Get(long id)
//        {
//            if (!await _businessProvider.existsdatastudent(id))
//            {
//                return NotFound($"Recors with Id {id} does not exist");
//            }

//            return Ok(await _businessProvider.GetDataStudent(id));
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] StudentVm value)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest();
//            }

//            if (value.Fk_Houses == null && value.Id == 0)
//            {
//                return BadRequest();
//            }

//            var result = await _businessProvider.AddDataStudent(value);

//            return Created("/api/Entry", result);
//        }

//        [HttpPut("{id}")]
//        [ProducesResponseType((int)HttpStatusCode.OK)]
//        [ProducesResponseType((int)HttpStatusCode.NotFound)]
//        public async Task<IActionResult> Put(long id, [FromBody] StudentVm value)
//        {
//            if (id == 0)
//            {
//                return BadRequest();
//            }

//            if (!await _businessProvider.existsdatastudent(id))
//            {
//                return NotFound($"DataEventRecord with Id {id} does not exist");
//            }

//            await _businessProvider.UpdateDataStudent(id, value);
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        [ProducesResponseType((int)HttpStatusCode.OK)]
//        [ProducesResponseType((int)HttpStatusCode.NotFound)]
//        [ProducesResponseType((int)HttpStatusCode.Conflict)]
//        public async Task<IActionResult> Delete(long id)
//        {
//            if (id == 0)
//            {
//                return BadRequest();
//            }

//            if (!await _businessProvider.existsdatastudent(id))
//            {
//                return NotFound($"DataEventRecord with Id {id} does not exist");
//            }

//            await _businessProvider.DeleteDataStudent(id);

//            return Ok();
//        }
//    }
//}
