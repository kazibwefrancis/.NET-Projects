using System;

namespace Thanos_API.Models
{
    public class Contribution
    {
        public long RecordId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCode { get; set; }
        public string NssfNumber { get; set; }
        public double TransactionAmount { get; set; }
        public string PartnerId { get; set; }
        public string TransactionId { get; set; }
        public string Channel { get; set; }
        public string Status { get; set; }
        public string ProductType { get; set; }
        public string TransactionType { get; set; }
        public string Vendor { get; set; }
        public bool Reconclied { get; set; }
        public string ReconciledBy { get; set; }
        public DateTime? ReconcilationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool Approved { get; set; }
        public string ReconciledReason { get; set; }
    }
}
