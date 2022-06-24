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
    /// Bu controllerda BootcampInfo için yapılmıştır.
    /// Bu controllerda sadece Bootcapm için dataları List halinde getirme işlemi yapılacaktır
    /// Dİğer Crud işlemleri Admin tarafından yapılacaktır
    /// 
    /// 
    /// </summary>

    [ApiController]
    [Route("api/[controller]")]
    public class BootcampInfoController : ControllerBase
    {
        BootcampInfoManager bootcampInfoManager = new BootcampInfoManager(new EfCoreBootcampRepository());

        [HttpGet]
        public async Task<IActionResult> GetBootcampInfos()
        {

            var bootcampInfo = await bootcampInfoManager.GetAll();
            return Ok(bootcampInfo);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBootcampInfo(int id)
        {
            var bootcampInfo = await bootcampInfoManager.GetById(id);
            if (bootcampInfo == null)
            {
                return NotFound();
            }
            return Ok(bootcampInfo);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBootcampInfo(BootcampInfo entity)
        {
            await bootcampInfoManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetBootcampInfo), new { id = entity.BootcampId }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var bootcampInfo = await bootcampInfoManager.GetById(id);
            if (bootcampInfo == null)
            {
                return NotFound();
            }
            await bootcampInfoManager.DeleteAsync(bootcampInfo);
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
