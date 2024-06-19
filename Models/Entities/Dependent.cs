using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    public class Dependent : User
    {
        public string kinship { get; set; }
        public string memberId { get; set; }
    }
}