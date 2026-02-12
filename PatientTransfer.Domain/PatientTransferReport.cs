namespace PatientTransfer.Domain
{
    public class PatientTransferReport
    {
        public int TransferId { get; set; }
        public string PatientName { get; set; }
        public int age { get; set; }
        public string FromFacility { get; set; }
        public string ToFacility { get; set; }
        public DateTime TransferDate { get; set; }
    }
}
