using ErpUygulama.Data.Context;
using ErpUygulama.Dtos;
using ErpUygulama.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ErpServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ErpUygulamaDbContext _context;

        public ValuesController(ErpUygulamaDbContext context)
        {
            _context = context;
        }


        [HttpGet] 
        public IActionResult Get() { 
        
        var value = _context.Set<Invoice>().ToList();

            return Ok(value);   
        
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteInvoice(int id)

        {

            var value = _context.Set<Invoice>().ToList();
            return Ok(value);
        }

        [HttpGet("{id}")]

        public IActionResult GetInvoice(int id)
        {

            var value = _context.Set<Invoice>().ToList();
            return Ok(value);

        }


        [HttpPut]
        public IActionResult Put()
        {

            var value = _context.Set<Invoice>().ToList();

            return Ok(value);

        }
        [HttpPost]

        public IActionResult Post() 
        
        
        {

            var value = _context.Set<Invoice>().ToList();
            return Ok(value);
        
        
        }
    }


    }
