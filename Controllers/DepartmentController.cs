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
        [HttpGet("getAllDepartmentById")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            // here will be the department get by id method
            var model = await _repo.GetDataById(id);
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(model));
        }
        [HttpPost("InsertDepartment")]
        public async Task<IActionResult> CreateDeoartment(DepartmentDto departmentDto)
        {
            // here will be the insert method
            var department = _mapper.Map<Department>(departmentDto);
            await _repo.UpdateData(department);
            return Ok(departmentDto);
        }
    }
}