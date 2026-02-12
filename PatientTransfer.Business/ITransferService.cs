using PatientTransfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientTransfer.Business
{
    public interface ITransferService
    {
        Task<IEnumerable<PatientTransferReport>> GetReportAsync(DateTime startDate, DateTime endDate);
    }
}
