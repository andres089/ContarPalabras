using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Business.Entities;
using Microsoft.Extensions.Configuration;

namespace CodeTest.Business.Services
{
    public class Service
    {
        private readonly IConfiguration _config;

        public Service(IConfiguration config)
        {                    
            _config = config;
        }

        public bool UserValidate(UserRequest user)
        {
            string userName = new string(_config.GetValue<string>("User:userName"));
            string userPasword = new string(_config.GetValue<string>("User:userPasword"));

            if (user.Name == userName && user.Pasword == userPasword)
            {
                return true;
            }else
            {
                return false;
            }           
        }

       

        public ContarPalabrasResponse ContarPalabras(ContarPalabrasRequest request)
        {

            ContarPalabrasResponse response = new ContarPalabrasResponse();
           
            if (request == null)
            {                
                response.Message = "El texto a validar es requerido.";
                return response;
            }

            string[] textoRecorer = request.textoValidar.Replace(".", "").Replace(",", "").ToUpper().Split(" ");

            List<PalabrasRepetidas> palabras = new List<PalabrasRepetidas>();

            foreach (var grouping in textoRecorer.GroupBy(t => t).Where(t => t.Count() > 0))
            {
                if(grouping.Key.Trim().Length > 0)
                {
                    PalabrasRepetidas palabra = new PalabrasRepetidas();
                    palabra.Palabra = grouping.Key;
                    palabra.cantidad = grouping.Count();
                    palabras.Add(palabra);
                }                
            }

            response.palabras = palabras;

            return response;
                      

        }
             
    }
}
