using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Shoes.Models;
using System.Diagnostics;


namespace Shoes.Infrastructure
{
    //This is also a custom validation attribute, but we will
    //apply it at the model level.
    public class ShoeValidAttribute : ValidationAttribute
    {
        //constructor
        public ShoeValidAttribute()
        {
            //override error message
            ErrorMessage = "Shoe not valid - please use real shoes!";
        }
        public override bool IsValid(object value)
        {
            string p = value as string; //a "cast" to a person object
            //first check if we actually have a person obect to validate
            if (p == null)
                return true; //not really a person object, so skip this
            if (p.Equals("lava"))
            {
                Debug.Write("model is not valid");
                return false;
            }
            else
            {
                Debug.Write("model is valid");
                return true;
            }
        }
    }
}