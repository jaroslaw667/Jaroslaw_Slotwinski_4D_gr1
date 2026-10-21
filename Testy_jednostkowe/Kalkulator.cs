using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_jednostkowe
{
    public class Kalkulator
    {
        public decimal ObliczCeneNetto(decimal cenaBrutto, decimal stawkaVat)
        {
            return cenaBrutto / (1 + stawkaVat / 100);
        }

        public decimal ObliczCeneBrutto(decimal cenaNetto, decimal stawkaVat)
        {
            return cenaNetto * (1 + stawkaVat / 100);
        }
            
        public decimal ZastosujRabat(decimal cena, decimal procentRabatu)
        {
            return cena - (cena * procentRabatu / 100);
        }

        public bool CzyDrogiProdukt(decimal cena)
        {
            return cena > 1000;
        }
    }

}
