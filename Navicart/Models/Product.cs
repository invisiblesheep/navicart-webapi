using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Navicart.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int shelfId { get; set; }
        public int shelfSector { get; set; }
        public Point point { get; set; }

        public Product(int id, string name, int hyllyId, int hyllyPaikka)
        {
            this.id = id;
            this.name = name;
            shelfId = hyllyId;
            hyllyPaikka = shelfSector;
            point = getPoint(hyllyId, hyllyPaikka);
        }

        private Point getPoint(int hyllyId, int hyllyPaikka)
        {
            //Hae hylly tietokannasta ja hyllyn päätepisteiden mukaan laske piste tuotteelle
            return null;
        }
    }
}