using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestniCMS2.Models
{

    [Table("TestTablica")]
    public class Bookletdruck
    {

        public string PDFPath { get; set; }

        public string Buchungsnummer { get; set; }
        [Key]
        public int BookletID { get; set; }

        public int LaufID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy HH:mm}")]
        public DateTime Reisebeginn { get; set; }

        public string MessageTo { get; set; }

        public string PassengerList { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy HH:mm}")]
        public DateTime CreatedOn { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy HH:mm}")]
        public DateTime SentOn { get; set; }

    }
}