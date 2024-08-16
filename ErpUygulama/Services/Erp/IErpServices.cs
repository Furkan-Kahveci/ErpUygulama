using ErpUygulama.Dtos;

namespace ErpUygulama.Services.Erp
{
    public interface IErpServices
    {
     Task<List<ResultInvoiceDto>> GetAllInvoiceAsync();

     Task<List<GetByIdInvoiceDto>> GetByIdInvoicesAsync(int id);

        Task CreateInvoiceAsync(CreateInvoiceDto model);

        Task UpdateInvoiceAsync(UpdateInvoiceDto model);
        Task DeleteInvoiceAsync(int id);







    }
}
