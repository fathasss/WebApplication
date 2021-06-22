using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Estate
    {
        public int ilanID { get; set; }
        public int ilanNumber { get; set; }
        public string Photo { get; set; }
        public string City { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public string Mahalle { get; set;}
        [Required(ErrorMessage = "Error 404")]
        public string Sokak { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public int numberAd { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public int metreSquare { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public int banyoNumber { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public int odaNumber { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public int binaAge { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public string kullanimStatus { get; set; }
        public string sahipName { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public string mobilyaStatus { get; set; }
        [Required(ErrorMessage = "Error 404")]
        public string homeInfo { get; set; }
    }
}