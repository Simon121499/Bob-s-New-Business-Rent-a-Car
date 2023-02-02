# Bobs-New-Business-Rent-a-Car
 A solution that accepts two parameters which are startingDate (DateTimeOffset) and numberOfDays (int) and calculates total price for given arguments

To build the project cd to "Bob-s-New-Business-Rent-a-Car\Rent a Car" and run "dotnet build"

To run the test case cd to "Bob-s-New-Business-Rent-a-Car\CarRentalPriceTests" and run "dotnet test"

The CarRental class "Bob-s-New-Business-Rent-a-Car\Rent a Car\CarRental.cs" is a simple class that implements a business logic of a car rental service. The class contains a dictionary called Prices, which is a 2-dimensional array that stores the prices for each month and number of days of car rental. The class has a public static method called CalculatePrice, which takes two arguments: startDate and numberOfDays, and calculates the total expected price for the car rental service.

A dictionary is used for the values of the rental pricing because it has faster lookup 

The CalculatePrice method starts by getting the specified month from the startDate argument using the Month property of the DateTimeOffset type. Then, it initializes the priceIndex with 0, which is the index of the first column of the Prices dictionary.

The method then uses a series of if statements to determine the priceIndex based on the number of days of the car rental. If the number of days is between 1 and 3, the priceIndex is set to 0. If the number of days is between 4 and 8, the priceIndex is set to 1, and so on.

Finally, the method returns the value of the cell in the Prices dictionary located at the specified row (month) and column (priceIndex) and multiplies it by the number of days to get the total price for the car rental service.
