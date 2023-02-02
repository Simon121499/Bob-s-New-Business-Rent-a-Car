using CarRentalPrice;

namespace CarRentalPriceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RentalPriceTest()
        {
            // Arrange

            // DateTimeOffset and numberOfDays to test with
            // Jan 1 2023 DateTime
            DateTimeOffset startDate = new DateTimeOffset(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);

            // 5 Days as the number of days
            int numberOfDays = 5;


            //Expected price for 5 days starting from Jan 1 2023
            int expectedPrice = 245;

            // Act

            // Car Rental Total Price for the number of days
            int carRentalActualTotalPrice = CarRental.CalculatePrice(startDate,numberOfDays);

            // Assert

            // Assert that the sorted words returned from our implemented method is the same as expected words
            Assert.AreEqual(expectedPrice, carRentalActualTotalPrice);
        }
    }
}