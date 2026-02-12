using Microsoft.Data.SqlClient;
using PatientTransfer.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PatientTransfer.Data
{
    public class TransferRepository : ITransferRepository
    {
        private readonly string _connectionString;

        public TransferRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<IEnumerable<PatientTransferReport>> GetTransferReportAsync(DateTime startDate, DateTime endDate)
        {
            var sql = @"select t.TransferId, p.Name as PatientName, p.Age, f1.FacilityName as FromFacility, f2.FacilityName as ToFacility, t.TransferDate from Transfers t inner join Patients p on t.PatientId = p.PatientId inner join Facilities f1 on t.FromFacilityId = f1.FacilityId inner join Facilities f2 on t.ToFacilityId = f2.FacilityId where t.TransferDate between @StartDate and @EndDate order by t.TransferDate desc";
           
            using IDbConnection db = new SqlConnection(_connectionString);

            return await db.QueryAsync<PatientTransferReport>
                (sql, new { StartDate = startDate, EndDate = endDate });
        }
    }
}
