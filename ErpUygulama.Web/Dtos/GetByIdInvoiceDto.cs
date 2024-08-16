namespace ErpUygulama.Web.Dtos
{
    public class GetByIdInvoiceDto
    {
        public int Id { get; set; }
        public string Vkn { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public DateTime DocumentDate { get; set; }

        public string CurrencyCode { get; set; } = string.Empty;
        public int Company { get; set; }
        public string DocumentType { get; set; } = string.Empty;
        public string ApprovingSection { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
    }
}
