using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment
{
    public class Drugs
    {
        //Declaring Variables
        [Key]
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string DrugCompany { get; set;}
        public DateTime MfgDate { get; set; }
        public int Price { get; set; }              //Prices are per 10 Tablets

        public IList<DrugPatient> DrugPatient { get; set; }

    }
}
