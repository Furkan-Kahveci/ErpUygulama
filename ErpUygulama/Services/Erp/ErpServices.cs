using ErpUygulama.Dtos;
using ErpUygulama.Models;
using ErpUygulama.Repositories;

namespace ErpUygulama.Services.Erp
{
    public class ErpServices : IErpServices
    {
        private readonly IRepositories<Invoice> _repsoitory;

        public ErpServices(IRepositories<Invoice> repsoitory)
        {
            _repsoitory = repsoitory;
        }

        public async Task CreateInvoiceAsync(CreateInvoiceDto model)
        {
            var invoice = new Invoice
            {

                Vkn = model.Vkn,
                DocumentNumber = model.DocumentNumber,
                DocumentDate = model.DocumentDate,
                CurrencyCode = model.CurrencyCode,
                Company = model.Company,
                DocumentType = model.DocumentType,
                ApprovingSection = model.ApprovingSection,
                PaymentDate = model.PaymentDate,

            };
             await _repsoitory.CreateAsync(invoice);
        
        }


        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _repsoitory.GetByIdAsync(id);
            await _repsoitory.DeleteAsync(invoice);
        }

        public async Task<List<ResultInvoiceDto>> GetAllInvoiceAsync()
        {
            var values = await _repsoitory.GetAllAsync1();
            return values.Select(x => new ResultInvoiceDto
            {
                Id = x.Id,
                Vkn = x.Vkn,
                DocumentNumber = x.DocumentNumber,
                DocumentDate = x.DocumentDate,
                CurrencyCode = x.CurrencyCode,
                Company = x.Company,
                DocumentType = x.DocumentType,
                PaymentDate = x.PaymentDate,
                ApprovingSection = x.ApprovingSection,

            }).ToList();
        }

        public async Task<GetByIdInvoiceDto> GetByIdInvoicesAsync(int id)
        {
            var inovice = await _repsoitory.GetByIdAsync(id);
            var oneinvoice = new GetByIdInvoiceDto
            {

                Id=inovice.Id,
                Vkn=inovice.Vkn,
                DocumentNumber = inovice.DocumentNumber,
                DocumentDate = inovice.DocumentDate,
                CurrencyCode = inovice.CurrencyCode,
                Company=inovice.Company,
                DocumentType=inovice.DocumentType,
                PaymentDate = inovice.PaymentDate,
                ApprovingSection=inovice.ApprovingSection,
             };
            return oneinvoice;
           

        }

        public Task<List<GetByIdInvoiceDto>> GetByIdInvoicesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateInvoiceAsync(UpdateInvoiceDto model)
        {
            var invoice = await _repsoitory.GetByIdAsync(model.Id);
            invoice.DocumentNumber = model.DocumentNumber;
            invoice.DocumentDate = model.DocumentDate;
            invoice.CurrencyCode = model.CurrencyCode;
            invoice.Company = model.Company;
            invoice.Vkn = model.Vkn;
            invoice.ApprovingSection = model.ApprovingSection;
            invoice.DocumentDate = model.DocumentDate;
            invoice.DocumentType = model.DocumentType;
        }

        Task<List<GetByIdInvoiceDto>> IErpServices.GetByIdInvoicesAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
