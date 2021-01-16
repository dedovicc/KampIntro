using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        //Classların bir kullanımı özellik tutmak
        //İkinci özelliği manager
        //Property - Özellik 
        //Ürünün Özellikleri
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }


    }
}
