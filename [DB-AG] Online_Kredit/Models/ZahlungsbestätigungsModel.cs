using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _DB_AG__Online_Kredit.Models
{
    public class ZahlungsbestätigungsModel
    {
        [HiddenInput(DisplayValue = false)]
        [Required]
        public int ID_Kunde { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public bool ZahlungsErinnerung { get; set; } = false;

        [HiddenInput(DisplayValue = false)]
        [Required]
        public bool Bezahlt { get; set; } = false;

    }
}