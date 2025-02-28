using System;

namespace AlitaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("ALITA'S STORE");
                Console.WriteLine("WELCOME TO OUR STORE MENU");
                Console.WriteLine("1. BURGER MENU");
                Console.WriteLine("2. PIZZA MENU");
                Console.WriteLine("3. KOTA MENU");
                Console.WriteLine("4. WRAP MENU");
                Console.WriteLine("5. DRINKS");
                Console.WriteLine("6. EXIT");
                Console.WriteLine("Enter your choice:");
                int mainChoice = int.Parse(Console.ReadLine());
                if (mainChoice >= 1 && mainChoice <= 6)


                    switch (mainChoice)
                    {
                        case 1:
                            BurgerMenu();
                            break;

                        case 2:
                            Console.WriteLine("PIZZA MENU");
                            Console.WriteLine("1. Creamy Chicken");
                            Console.WriteLine("2. BBQ Chicken");
                            Console.WriteLine("3. Bacon and BBQ");
                            Console.WriteLine("4. Something Meaty");
                            Console.WriteLine("5. Creamy Veg");
                            Console.WriteLine("choose your option:");
                            // Add PizzaMenu method if needed
                            break;

                        case 3:
                            Console.WriteLine("KOTA MENU");
                            Console.WriteLine("1. Mac and Cheese");
                            Console.WriteLine("2. Curry");
                            Console.WriteLine("3. Full Stack");
                            Console.WriteLine("4. Bacon");
                            Console.WriteLine("5. Bacon and Russian");
                            Console.WriteLine("choose your option:");
                            // Add KotaMenu method if needed
                            break;

                        case 4:
                            Console.WriteLine("WRAP MENU");
                            Console.WriteLine("1. Buffalo Chicken");
                            Console.WriteLine("2. Taco Lettuce");
                            Console.WriteLine("3. Roasted Veg");
                            Console.WriteLine("4. Chicken Caesar");
                            Console.WriteLine("5. Crunchy Chicken");
                            Console.WriteLine("choose your option:");
                            // Add WrapMenu method if needed
                            break;

                        case 5:
                            Console.WriteLine("DRINKS");
                            Console.WriteLine("1. Water");
                            Console.WriteLine("2. Coke");
                            Console.WriteLine("3. Shakes");
                            Console.WriteLine("4. 100% Juice");
                            Console.WriteLine("5. Smoothies");
                            // Add DrinksMenu method if needed
                            break;

                        case 6:
                            Console.WriteLine("Thank you for visiting our store");
                            break; // Exit the program

                        default:
                            Console.WriteLine("Invalid input, please select a correct option.");
                            break;
                    }
            }
        }

        private static void BurgerMenu()
        {
            Console.WriteLine("BURGER MENU");
            Console.WriteLine("1. Hamburger - R30");
            Console.WriteLine("2. Cheese Burger - R35");
            Console.WriteLine("3. Chicken Burger - R40");
            Console.WriteLine("4. Bacon Burger - R45");
            Console.WriteLine("5. Veggie Burger - R25");
            Console.WriteLine("6. Exit");

            if (!int.TryParse(Console.ReadLine(), out int burgerChoice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            int price = 0;

            switch (burgerChoice)
            {
                case 1:
                    price = 30;
                    Console.WriteLine("You have chosen Hamburger.");
                    break;

                case 2:
                    price = 35;
                    Console.WriteLine("You have chosen Cheese Burger.");
                    break;

                case 3:
                    price = 40;
                    Console.WriteLine("You have chosen Chicken Burger.");
                    break;

                case 4:
                    price = 45;
                    Console.WriteLine("You have chosen Bacon Burger.");
                    break;

                case 5:
                    price = 25;
                    Console.WriteLine("You have chosen Veggie Burger.");
                    break;

                case 6:
                    Console.WriteLine("Returning to main menu.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Enter Quantity:");
            if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
            {
                Console.WriteLine("Total price:R" + price * quantity);
            }
            else
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number.");
            }
        }
    }
}

            