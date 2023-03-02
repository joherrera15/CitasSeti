using Dapper;
using DapperASPNetCore.Context;
using DapperASPNetCore.Contracts;
using DapperASPNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace DapperASPNetCore.Repository;


public class PaybackRepository : IPaybackRepository
{
    private readonly DapperContext _context;

		public PaybackRepository(DapperContext context)
		{
			_context = context;
		}

    public async Task<List<Payback>> GetPayback()
    {
            var query = "SPtiempo_recuperaion_Inversion";
        	using (var connection = _context.CreateConnection())
			{
                      var _Payback = await connection.QueryAsync<Payback>(query,param:null,null ,null,commandType: CommandType.StoredProcedure );
                      return _Payback.ToList();

            }
        throw new NotImplementedException();
    }
}