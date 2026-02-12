using PatientTransfer.Data;
using PatientTransfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientTransfer.Business
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public async Task<IEnumerable<PatientTransferReport>> GetReportAsync(DateTime startDate, DateTime endDate)
        {
            return await _transferRepository.GetTransferReportAsync(startDate, endDate);
        }
    }
}
