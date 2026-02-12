using PatientTransfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientTransfer.Data
{
    public interface ITransferRepository
    {
        Task<IEnumerable<PatientTransferReport>> GetTransferReportAsync(DateTime startDate, DateTime endDate);
    }
}
