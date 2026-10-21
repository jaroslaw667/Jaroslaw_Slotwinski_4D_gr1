namespace Testy_jednostkowe
{
    public class UnitTest1
    {
        [Fact]
        public void CenaBrutto()
        {
            var kalkulator = new Kalkulator();

            decimal wynik = kalkulator.ObliczCeneBrutto(100m, 23m);

            Assert.Equal(123m, wynik);
        }

        [Fact]
        public void Rabat()
        {
            var kalkulator = new Kalkulator();

            decimal wynik = kalkulator.ZastosujRabat(200m, 10m);

            Assert.Equal(180m, wynik);
        }
    }



}