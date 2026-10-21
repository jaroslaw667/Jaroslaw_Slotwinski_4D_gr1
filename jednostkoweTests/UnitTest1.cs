namespace Testy_jednostkowe
{
    public class UnitTest1
    {
        // Sprawdza, czy cena brutto dla 100 z³ netto i 23% VAT wynosi 123 z³.
        [Fact]
        public void CenaBrutto()
        {
            var kalkulator = new Kalkulator();

            decimal wynik = kalkulator.ObliczCeneBrutto(100m, 23m);

            Assert.Equal(123m, wynik);
        }

        // Sprawdza, czy rabat 10% od kwoty 200 z³ daje wynik 180 z³.
        [Fact]
        public void Rabat()
        {
            var kalkulator = new Kalkulator();

            decimal wynik = kalkulator.ZastosujRabat(200m, 10m);

            Assert.Equal(180m, wynik);
        }

        // Sprawdza, czy produkt kosztuj¹cy 1500 z³ jest uznawany za drogi.
        [Fact]
        public void CzyDrogiProdukt()
        {
            var kalkulator = new Kalkulator();

            bool wynik = kalkulator.CzyDrogiProdukt(1500m);

            Assert.True(wynik);
        }
    }
}