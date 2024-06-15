using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    public class Dependent : User
    {
        public string Kinship { get; set; }
        public int MemberID { get; set; }

        public Dependent() { }
    }
}