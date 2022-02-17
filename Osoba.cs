using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDvaaa
{
    internal class Radnik
    {
        public string Ime { get; set; } = string.Empty;

        /* Isto kao gore samo duuugacko :/
         * private string _ime;
        internal string Ime
        {
            get
            {
                return _ime;
            }
            set
            {
                _ime = value;
            }
        }*/

        public string Prezime { get; set; } = string.Empty;

        public decimal TrecaPlata { get; set; } = 31;

        private decimal _plata = 30;

        internal decimal GetPlatu()
        {
            return _plata;
        }

        internal void SetPlatu(decimal novaPlata)
        {
            if (novaPlata > _plata)
                _plata = novaPlata;
        }

        //Isto kao i gore samo cool
        private decimal _plata2 = 30;

        internal decimal Plata2
        {
            get
            {
                return _plata2;
            }
            set
            {
                if (value > _plata2)
                    _plata2 = value;
            }
        }
    }
}