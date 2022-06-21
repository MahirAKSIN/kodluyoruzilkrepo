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
    public class EducatorInfoController : ControllerBase
    {

        EducatorInfoManager educatorInfoManager = new EducatorInfoManager(new EfCoreEducatorRepository());

        [HttpGet]
        public async Task<IActionResult> GetPersonInformations()
        {
            var personelinformations = await educatorInfoManager.GetAll();
            return Ok(personelinformations);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonInformation(int id)
        {
            var personelinformation = await educatorInfoManager.GetById(id);
            if (personelinformation == null)
            {
                return NotFound();
            }
            return Ok(personelinformation);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePersonInformation(EducatorInfo entity)
        {
            await educatorInfoManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetPersonInformation), new { id = entity.EducatorId }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var personelinformation = await educatorInfoManager.GetById(id);
            if (personelinformation == null)
            {
                return NotFound();
            }
            await educatorInfoManager.DeleteAsync(personelinformation);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, EducatorInfo entity)
        {
            if (id != entity.EducatorId)
            {
                return BadRequest();
            }
            await educatorInfoManager.UpdateAsync(entity);
            return NoContent();
        }
    }
}
