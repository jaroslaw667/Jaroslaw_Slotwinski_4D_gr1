    namespace Aplikacja_do_testowania
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int[] liczby = { 9, 4, 7, 2, 8, 1, 5, 3, 6 };
            int[] oczekiwane = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var sort = new Sortowanie();

            // Act
            int[] wynik = sort.ShellSort(liczby);

            // Assert
            Assert.Equal(oczekiwane, wynik);
        }
    }
}