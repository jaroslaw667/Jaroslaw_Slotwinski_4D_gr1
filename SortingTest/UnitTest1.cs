    namespace Aplikacja_do_testowania
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] liczby = { 9, 4, 7, 2, 8, 1, 5, 3, 6 };
            int[] oczekiwane = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var sort = new Sortowanie();

            int[] wynik = sort.ShellSort(liczby);

            Assert.Equal(oczekiwane, wynik);
        }

        [Fact]
        public void Test2()
        {
            int[] liczby = { 1, 2, 3, 4, 5 };
            int[] oczekiwane = { 1, 2, 3, 4, 5 };

            var sort = new Sortowanie();

            int[] wynik = sort.ShellSort(liczby);

            Assert.Equal(oczekiwane, wynik);
        }

        [Fact]
        public void Test3()
        {
            int[] liczby = { -3, 5, -1, 0, -7, 2 };
            int[] oczekiwane = { -7, -3, -1, 0, 2, 5 };

            var sort = new Sortowanie();
            int[] wynik = sort.ShellSort(liczby);

            Assert.Equal(oczekiwane, wynik);
        }
    }
}