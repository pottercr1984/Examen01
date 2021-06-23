﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess
    {
        private readonly IConfiguration config;

        public DataAccess(IConfiguration _Config)
        {
            config = _Config;
        }


        public SqlConnection DbConnection => new SqlConnection(
            new SqlConnectionStringBuilder(config.GetConnectionString("Conn")).ConnectionString
            
        );

        public async Task<IEnumerable<T>> QueryAsync<T>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        public async Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task<IEnumerable<T>> QueryAsync<T, B>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B, C, D, E, F>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F, G>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
                using(var exec = DbConnection)
                {
                    await exec. OpenAsync();

                    var result = exec.QueryAsync<T, B, C, D, E, F, G>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<T> QueryFirstAsync<T>(string sp, object Param= null, int? Timeout=null)
        {
            try 
	        {	        
		        using(var exec = DbConnection)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryFirstOrDefaultAsync<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
	        }
	        catch (Exception)
	        {

		        throw;
	        }
        }


        public async Task<T> QueryFirstAsync<T>(string sp, object Param= null, int? Timeout=null)
        {
            try 
	        {	        
		        using(var exec = DbConnection)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryFirstOrDefaultAsync<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }
	        }
	        catch (Exception)
	        {

		        throw;
	        }
        }

        public async Task<>ExecuteAsync<T>(string sp, object Param= null, int? Timeout=null)
        {
            try 
	        {	        
		        using(var exec = DbConnection)
                {
                    await exec.OpenAsync();

                    var result = await exec.ExecuteReaderAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return  result.ReadAsync;
                }
	        }
	        catch (Exception)
	        {

		        throw;
	        }
        }
    }
}
