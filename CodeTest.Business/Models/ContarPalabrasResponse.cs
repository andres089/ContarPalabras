using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest.Business.Entities
{
    public class ContarPalabrasResponse
    {
        public string Message { get; set; }

        public IEnumerable<PalabrasRepetidas> palabras { get; set; }

    }

    public class PalabrasRepetidas
    {
        public string Palabra { get; set; }

        public int cantidad { get; set; } 

    }   

}

