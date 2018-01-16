using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CelToFerTmp.Models
{
    public class CheckTemp
    {
        //we need data "using System.ComponentModel.DataAnnotations;" to use this []
        //[Required(ErrorMessage ="input your name")]
        //[Display(Name="Your name")]
        //[Required]
        static public string Name { get; set; }

        //[Required(ErrorMessage ="input temprature")]
        //[Display(Name ="Your temperature")]
        //[Required]
        static public int Temp { get; set; }

        static public string DescriptionFever { get; set; }
        static public string DescriptionHypo { get; set; }

        static public void CalcTemp()
        {
            if (Temp<=38)
            {
                DescriptionFever = "There is no fever";
            }
            else
            {
                DescriptionFever = "There is fever";
            }

        }
    }
}