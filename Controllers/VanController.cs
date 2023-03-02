using DapperASPNetCore.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperASPNetCore.Controllers;


	[Route("api/Van")]
	[ApiController]

    public class VanController : ControllerBase
	{
        private readonly IVanRepository _VanRepository;

		public VanController(IVanRepository VanRepository)
		{
			_VanRepository = VanRepository;
		}

	[HttpGet]
		public async Task<IActionResult> GetVan()
		{
			try
			{
				var _varpayback = await _VanRepository.GetVan();

				return Ok(_varpayback);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}



    }
