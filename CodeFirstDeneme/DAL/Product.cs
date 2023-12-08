using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDeneme.DAL
{
    public class Product
    {
        // Her biri Product tablosunda bir sütuna  karşılık gelecek Product'ın özelliklerini yazıyoruz.
        // Not : Tipleri Nasıl yazarsak veritabanına öyle gider
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }


    }
}
