
// Angelica Ayala 

 // Date Revised: 10/25/22

 // Challenge #3 Restaurant Picker 

 // Created a restaurant picker where there are 3 food categories that are buttons (Dine In, FastFood and Dessert) and 1 button that will randomly select an option from either category. 

 //Peer reviewed by:
 //Date:
 //Comment:

using System;

namespace RestaurantPickerRepo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           System.Random F = new System.Random();
           int randomFood = 0;
    


     List<string> FoodList = new List<string>();
     string DiningBtn;
     string DessertBtn;
     string RandomFoodBtn;


    void Start()
    {
        // DiningBtn.text = FoodList[0].Dining;
        // DessertBtn.text = FoodList[0].Dessert;
        // FastFoodBtn.text = FoodList[0].FastFood;
    }

    void DineInFood()
    {
        randomFood = F.Next(0,FoodList.Count);
        DiningBtn.text = FoodList[randomFood].Dining;
        
    }

    void DessertFood()
    {
        randomFood = F.Next(0,FoodList.Count);
        DessertBtn.text = FoodList[randomFood].Dessert;
    }
    
    void FastFood()
    {
        randomFood = F.Next(0,FoodList.Count);
        FastFoodBtn.text = FoodList[randomFood].FastFood;
    }

     void MyRandomOptionsFromList()
     {
         //randomFood = F.Next(0,FoodList.Count);
         System.Random rnd = new System.Random();
         int num = rnd.Next(1,4);

         if (num == 1)
         {
            DineInFood();
         }
         else if (num == 2)
         {
            DessertFood();
         }
         else if (num == 3)
         {
            FastFood();
         }
         else
         {
            Debug.Log($"Error: num variable = {num}");
         }

        
         
       
     }
            Console.WriteLine("Hello World!");
        }
    }
}


