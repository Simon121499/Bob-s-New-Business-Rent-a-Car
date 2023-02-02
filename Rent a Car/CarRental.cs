namespace CarRentalPrice
{
    public class CarRental
    {

        //Created a Dictionary with "Key" indicating the periods and "Value" corresponding to the periods
        //As specified in the business pricing

        private static readonly Dictionary<int, int[]> Prices = new Dictionary<int, int[]>
    {
        { 1, new int[] { 50, 49, 48, 45 } },
        { 2, new int[] { 50, 49, 48, 45 } },
        { 3, new int[] { 50, 49, 48, 45 } },
        { 4, new int[] { 51, 50, 49, 48 } },
        { 5, new int[] { 52, 51, 50, 50 } },
        { 6, new int[] { 54, 54, 54, 54 } },
    };

        //Created a method to calculate the total price expected for each month, number of days of car rental
        public static int CalculatePrice(DateTimeOffset startDate, int numberOfDays)
        {
            // Get the specified month from the DateTimeOffset
            int month = startDate.Month;

            //Initialize the price index corresponding to the month and number of days of car rental
            int priceIndex = 0;


            //If number of days of rental is between 1 and 3 days, we will use the column 0 of the dictionary
            if (numberOfDays >= 1 && numberOfDays <= 3)
            {
                priceIndex = 0;
            }

            //If number of days of rental is between 4 and 8 days, we will use the column 1 of the dictionary
            else if (numberOfDays >= 4 && numberOfDays <= 8)
            {
                priceIndex = 1;
            }

            //If number of days of rental is between 9 and 15 days, we will use the column 2 of the dictionary
            else if (numberOfDays >= 9 && numberOfDays <= 15)
            {
                priceIndex = 2;
            }

            //If number of days of rental is greater than or equals to 16 days, we will use the column 3 of the dictionary
            else if (numberOfDays >= 16)
            {
                priceIndex = 3;
            }


            //return the value of column "priceIndex" and row "month" of the dictionary and multiply by the number of days
            return Prices[month][priceIndex] * numberOfDays;
        }
    }

}