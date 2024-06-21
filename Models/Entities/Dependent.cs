using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    public class Dependent : User
    {
        private string? kinship;
        private string? memberId;

        [Required]
        public string Kinship { get => kinship!; set => kinship = value; }
        [Required]
        public string MemberId { get => memberId!; set => memberId = value; }
    }
}