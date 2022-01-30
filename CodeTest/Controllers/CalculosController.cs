using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeTest.Business.Services;
using CodeTest.Business.Entities;
using Microsoft.AspNetCore.Authorization;

namespace CodeTest.Controllers
{
    [Authorize]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        private readonly TokenFactory _tokenFactory;
        private readonly Service _service;

        public CalculosController(TokenFactory tokenFactory, Service service)
        {
            _tokenFactory = tokenFactory;
            _service = service;
        }

        [HttpPost("ContarPalabras")]
        public IActionResult ContarPalabras(ContarPalabrasRequest request)
        {
            ContarPalabrasResponse response= new ContarPalabrasResponse();
            response =  _service.ContarPalabras(request);

            if (response == null)
            {
                response.Message = "El texto esta vacio.";
                return Ok(response);
            }

            return Ok(response);

        }        

    }
}
