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

    //
    /// <summary>
    /// Bu controllerda EducatorInfo için yapılmıştır.
    /// Bu controllerda sadece EducatorInfo için dataları List halinde getirme işlemi yapılacaktır
    /// Dİğer Crud işlemleri Admin tarafından yapılacaktır
    /// 
    /// 
    /// </summary>

    [ApiController]
    [Route("api/[controller]")]
    public class EducatorInfoController : ControllerBase
    {

        EducatorInfoManager educatorInfoManager = new EducatorInfoManager(new EfCoreEducatorRepository());

        [HttpGet]
        public async Task<IActionResult> GetEducatorInfos()
        {
            var educatorInfos = await educatorInfoManager.GetAll();
            return Ok(educatorInfos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEducatorInfo(int id)
        {
            var educatorInfos = await educatorInfoManager.GetById(id);
            if (educatorInfos == null)
            {
                return NotFound();
            }
            return Ok(educatorInfos);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEducatorInfo(EducatorInfo entity)
        {
            await educatorInfoManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetEducatorInfo), new { id = entity.EducatorId }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var educatorInfos = await educatorInfoManager.GetById(id);
            if (educatorInfos == null)
            {
                return NotFound();
            }
            await educatorInfoManager.DeleteAsync(educatorInfos);
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
