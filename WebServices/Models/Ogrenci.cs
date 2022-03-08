using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class Ogrenci
    {
        //Properties:
        private int Id { get; set; }
        private string Ad { get; set; }

        public int getId()
        {
            return Id;
        }

        public void setId(int deger)
        {
            Id = deger;
        }

        public string getAd()
        {
            return Ad;
        }

        public void setAd(string deger)
        {
            Ad = deger;
        }

        //Constuctors:
        public Ogrenci(int _Id, string _Ad)
        {
            Id = _Id;
            Ad = _Ad;
        }
    }
}