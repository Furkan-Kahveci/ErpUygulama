using ErpUygulama.Web.Dtos;

namespace ErpUygulama.Web.Services.Erp
{
    public interface IErpService
    {
        Task<List<ResultInvoiceDto>> GetAllInvoiceAsync();

        Task<List<GetByIdInvoiceDto>> GetByIdInvoicesAsync(int id);

        Task CreateInvoiceAsync(CreateInvoiceDto model);

        Task UpdateInvoiceAsync(UpdateInvoiceDto model);
        Task DeleteInvoiceAsync(int id);







    }
}
