using ErpUygulama.Dtos;
using ErpUygulama.Services.Erp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpUygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvociesController : ControllerBase
    {
        private readonly IErpServices _services;

        public InvociesController(IErpServices services)
        {
            _services = services;
        }


        [HttpGet]

        public async Task<IActionResult> GetAllInvoice()
        {

            var value = _services.GetAllInvoiceAsync(); 
            return Ok(value);



        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetByIdInvoice(int id)
        {

            var value = await _services.GetByIdInvoicesAsync(id);
            return Ok(value);


        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice(CreateInvoiceDto model)
        {

            await _services.CreateInvoiceAsync(model);
            return Ok("Belgeniz başarılı bir şekilde kaydedildi");


        }


        [HttpPut]
        public async Task<IActionResult> UpdateInvoice(UpdateInvoiceDto model)
        {

            await _services.UpdateInvoiceAsync(model);
            return Ok("Belgeniz başarılı bir şekilde yenilendi");

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInvoice(int id)
        {

            await _services.DeleteInvoiceAsync(id);
            return Ok ("Belgeniz başarılı bir şekilde silindi");


        }




        }
    }

