using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using smsapi.Data;
using smsapi.DTO;
using smsapi.Model;

namespace smsapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IRepository<Department> _repo;
        private readonly IMapper _mapper;
        public DepartmentController(IRepository<Department> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("getAllDepartments")]

        public async Task<IActionResult> GetDepartments()
        {
            var model = await _repo.GetData();
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(model));
        }
    }
}