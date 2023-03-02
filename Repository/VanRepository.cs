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


public class VanRepository : IVanRepository
{
    private readonly DapperContext _context;

		public VanRepository(DapperContext context)
		{
			_context = context;
		}

    public async Task<List<Van>> GetVan()
    {
            var query = "spbeneficio_generado_por_la_inversion";
        	using (var connection = _context.CreateConnection())
			{
                      var _Van = await connection.QueryAsync<Van>(query,param:null,null ,null,commandType: CommandType.StoredProcedure );
                      return _Van.ToList();

            }
        throw new NotImplementedException();
    }
}