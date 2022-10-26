
// Angelica Ayala 

 // Date Revised: 10/25/22

 // Challenge #3 Restaurant Picker 

 // Created a restaurant picker where there are 3 food categories that are buttons (Dine In, FastFood and Dessert) and 1 button that will randomly select an option from either category. 

 //Peer reviewed by:
 //Date:
 //Comment:

bool playAgain = true;
bool isValid = true;
bool validNumber;
string response;
string userSelect;



string[] Restaurants = {"Chapalla", "Rey Azteca", "Nenas", "La Palmas", "Tio Pepes", "El Grullense", "Mayitas", "Senor Frogs", "Susys", "Don Luis", "Burger King", "McDonalds", "Taco Bell", "InNOut", "Red Robbin", "Chick Fil A", "McDonalds", "Subway", "Pollo Loco", "Hamburger stand", "Mikasa", "Shirasoni", "Domo", "Toyo", "Ramen 101", "Benihana", "Shogun", "shoMi", "Cocoro", "Hana"};

Random RanRest = new Random();
int Option;

while (playAgain == true)
{
    isValid = true;
    Console.WriteLine("Please select a restaurnt category");
    Console.WriteLine("Select 1 for Mexican Food, Select 2 for Fast Food, Select 3 for Japanese, or select 4 for all categories combined.");

    do
    {
        userSelect = Console.ReadLine();
        validNumber = int.TryParse(userSelect, out Option);
        if (validNumber != true || Option >= 5)
        {
            Console.Write("Please enter a valid whole number.");
        }
    }
    while (validNumber != true || Option >= 5);

    if (Option == 1)
    {
        int ranGen = RanRest.Next(0, 10);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen]);
    }
    else if (Option == 2)
    {
        int ranGen2 = RanRest.Next(10, 20);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen2]);
    }
    else if (Option == 3)
    {
        int ranGen3 = RanRest.Next(20, 30);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen3]);
    }
    else if (Option == 4)
    {
        int ranGen4 = RanRest.Next(0, 30);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen4]);
    }
    while(isValid)
    {
        Console.Write("Do you want to select again? (Y/N) ");
        response = Console.ReadLine().ToUpper();
        if(response == "Y")
            {
                playAgain = true;
                isValid = false;
            }
            else if(response == "N")
            {
                playAgain = false;
                isValid = false;
            }
            else
            {
                playAgain = false;
                isValid = true;
                Console.WriteLine(response + " isn't a valid response. Please Enter an actual valid response please.");
            }

            Console.WriteLine("Thank you for using our services!");
        

    }



}