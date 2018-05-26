using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndAjax.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }    
    }
}