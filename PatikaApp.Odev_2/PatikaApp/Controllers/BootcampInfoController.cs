using Microsoft.AspNetCore.Mvc;
using PatikaApp.BusinessLayer.Concrete;
using PatikaApp.DataLayer.Concrete.Ef;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatikaApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BootcampInfoController : ControllerBase
    {
        BootcampInfoManager bootcampInfoManager = new BootcampInfoManager(new EfCoreBootcampRepository());

        public async Task<IActionResult> GetInformations()
        {

            var bootcampInfo = await bootcampInfoManager.GetAll();
            return Ok(bootcampInfo);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInformation(int id)
        {
            var detail = await bootcampInfoManager.GetById(id);
            if (detail == null)
            {
                return NotFound();
            }
            return Ok(detail);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInformation(BootcampInfo entity)
        {
            await bootcampInfoManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetInformation), new { id = entity.BootcampId }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var information = await bootcampInfoManager.GetById(id);
            if (information == null)
            {
                return NotFound();
            }
            await bootcampInfoManager.DeleteAsync(information);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BootcampInfo entity)
        {
            if (id != entity.BootcampId)
            {
                return BadRequest();
            }
            await bootcampInfoManager.UpdateAsync(entity);
            return NoContent();
        }
    }
}
