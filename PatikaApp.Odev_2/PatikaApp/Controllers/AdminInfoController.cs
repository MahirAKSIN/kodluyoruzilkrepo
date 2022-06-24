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
    /// Bu controllerda AdminInfo için yapılmıştır.
    /// Admini yapacağı butun işlemlerin tutulduğu yerdir
    /// AdminInfo CRUD işlemleri ve diğer tabloların ilişkisinin düzenlendiği controllerdır
    /// HttpGEt,HttpPost ve projenin ana damarları olan APInin ayağa kalktığı yerdir
    /// </summary>


    [ApiController]
    [Route("api/[controller]")]
    public class AdminInfoController : ControllerBase
    {
        AdminInfoManager adminInfoManager = new AdminInfoManager(new EfCoreAdminInfoRepository());

        [HttpGet]
        public async Task<IActionResult> GetAdminInfos()
        {
            var adminInfo = await adminInfoManager.GetAllWithDetails();
            return Ok(adminInfo);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdminInfo(int id)
        {
            var adminInfo = await adminInfoManager.GetById(id);
            if (adminInfo == null)
            {
                return NotFound();
            }
            return Ok(adminInfo);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdminInfo(AdminInfo entity)
        {
            await adminInfoManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetAdminInfo), new { id = entity.AdminId }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var information = await adminInfoManager.GetById(id);
            if (information == null)
            {
                return NotFound();
            }
            await adminInfoManager.DeleteAsync(information);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AdminInfo entity)
        {
            if (id != entity.AdminId)
            {
                return BadRequest();
            }
            await adminInfoManager.UpdateAsync(entity);
            return NoContent();
        }

    }
}
