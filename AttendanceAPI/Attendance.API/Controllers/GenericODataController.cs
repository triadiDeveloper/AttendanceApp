using Attendance.Application.Interfaces;
using Attendance.API.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace Attendance.API.Controllers
{
    [Authorize] // Hanya bisa diakses jika sudah login
    [Route("odata/[controller]")]
    public class GenericODataController<T> : ODataController where T : class
    {
        private readonly IGenericService<T> _service;

        public GenericODataController(IGenericService<T> service)
        {
            _service = service;
        }

        // ✅ OData murni, mendukung $filter, $top, $skip, etag, dll
        [EnableQuery(PageSize = 25)]
        [HttpGet]
        public IQueryable<T> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{key}")]
        public async Task<IActionResult> GetById([FromRoute] object key)
        {
            var data = await _service.GetByIdAsync(key);
            return data is null
                ? ResponseHelper.NotFoundResponse()
                : ResponseHelper.SuccessResponse(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T entity)
        {
            var result = await _service.AddAsync(entity);
            return ResponseHelper.CreatedResponse(result);
        }

        [HttpPut("{key}")]
        public async Task<IActionResult> Put([FromRoute] object key, [FromBody] T entity)
        {
            var updated = await _service.UpdateAsync(entity);
            return updated
                ? ResponseHelper.SuccessResponse("Data berhasil diperbarui")
                : ResponseHelper.NotFoundResponse();
        }

        [HttpDelete("{key}")]
        public async Task<IActionResult> Delete([FromRoute] object key)
        {
            var deleted = await _service.DeleteAsync(key);
            return deleted
                ? ResponseHelper.SuccessResponse("Data berhasil dihapus")
                : ResponseHelper.NotFoundResponse();
        }
    }
}