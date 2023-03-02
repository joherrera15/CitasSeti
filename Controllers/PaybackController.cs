using DapperASPNetCore.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperASPNetCore.Controllers;


	[Route("api/Payback")]
	[ApiController]

    public class PaybackController : ControllerBase
	{
        private readonly IPaybackRepository _payback;

		public PaybackController(IPaybackRepository payback)
		{
			_payback = payback;
		}

	[HttpGet]
		public async Task<IActionResult> GetPayback()
		{
			try
			{
				var _varpayback = await _payback.GetPayback();

				return Ok(_varpayback);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}



    }
