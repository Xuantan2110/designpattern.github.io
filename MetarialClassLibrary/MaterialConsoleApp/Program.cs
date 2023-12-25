using MetarialClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MaterialConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choicematerial;
            while (true)
            {
                Console.WriteLine("----------Choose materials----------");
                Console.WriteLine(".             1. Metal             .");
                Console.WriteLine(".             2. Wood              .");
                Console.WriteLine(".             3. Wall              .");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Your choose: ");
                try
                {
                    choicematerial = int.Parse(Console.ReadLine());
                    if (choicematerial == 1)
                    {
                        choosemetal();
                        break;
                    }
                    else if (choicematerial == 2)
                    {
                        choosewood();
                        break;
                    }
                    else if (choicematerial == 3)
                    {
                        choosewall();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input, please choose material again!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid integer.");
                }
            }
        }



        public static void choosemetal()
        {
            Material mymetal = new Metal();
            int choicepaint;
            int previousChoicepaint = 0;
            do
            {
                displaymenu();
                choicepaint = GetChoicepaint(previousChoicepaint);
                if (choicepaint != 0)
                {
                    if (choicepaint >= previousChoicepaint)
                    {
                        switch (choicepaint)
                        {
                            case 1:
                                mymetal = new Glossy(mymetal);
                                break;
                            case 2:
                                mymetal = new Antifouling(mymetal);
                                break;
                            case 3:
                                mymetal = new WaterProof(mymetal);
                                break;
                            default:
                                Console.WriteLine("Wrong input, please enter again.");
                                break;
                        }
                        previousChoicepaint = choicepaint;
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE TO CHOOSE IN ORDER:1->2->3");
                    }
                }
            } while (choicepaint != 0);
            Console.WriteLine("The material and paint layers you choose are: " + mymetal.GetDiscription());
            Console.WriteLine("The amount of paint is: " + mymetal.CalculatorVolume() + " liter");
            Console.ReadLine();



        }
        public static void choosewood()
        {
            Material mywood = new Wood();
            int choicepaint;
            int previousChoicepaint = 0;
            do
            {
                displaymenu();
                choicepaint = GetChoicepaint(previousChoicepaint);
                if (choicepaint != 0)
                {
                    if (choicepaint >= previousChoicepaint)
                    {
                        switch (choicepaint)
                        {
                            case 1:
                                mywood = new Glossy(mywood);
                                break;
                            case 2:
                                mywood = new Antifouling(mywood);
                                break;
                            case 3:
                                mywood = new WaterProof(mywood);
                                break;
                            default:
                                Console.WriteLine("Wrong input, please enter again.");
                                break;
                        }

                        // Cập nhật giá trị previousChoicepaint chỉ khi lựa chọn khác 0
                        previousChoicepaint = choicepaint;
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE TO CHOOSE IN ORDER:1->2->3");
                    }
                }

            } while (choicepaint != 0);
            Console.WriteLine("The material and paint layers you choose are: " + mywood.GetDiscription());
            Console.WriteLine("The amount of paint is: " + mywood.CalculatorVolume() + " liter");
            Console.ReadLine();
        }



        public static void choosewall()
        {
            Material mywall = new Wall();
            int choicepaint;
            int previousChoicepaint = 0;
            do
            {
                displaymenu();
                choicepaint = GetChoicepaint(previousChoicepaint);
                if (choicepaint != 0)
                {
                    if (choicepaint >= previousChoicepaint)
                    {
                        switch (choicepaint)
                        {
                            case 1:
                                mywall = new Glossy(mywall);
                                break;
                            case 2:
                                mywall = new Antifouling(mywall);
                                break;
                            case 3:
                                mywall = new WaterProof(mywall);
                                break;
                            default:
                                Console.WriteLine("Wrong input, please enter again.");
                                break;
                        }
                        // Cập nhật giá trị previousChoicepaint chỉ khi lựa chọn khác 0
                        previousChoicepaint = choicepaint;
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE TO CHOOSE IN ORDER:1->2->3");
                    }
                }
            } while (choicepaint != 0);
            Console.WriteLine("The material and paint layers you choose are: " + mywall.GetDiscription());
            Console.WriteLine("The amount of paint is: " + mywall.CalculatorVolume() + " liter");
            Console.ReadLine();
        }


        static int GetChoicepaint(int previousChoicepaint)
        {
            int choice = 0;
            bool isValid;

            do
            {
                Console.Write("Paint type you choose: ");
                string userInput = Console.ReadLine();
                try
                {
                    isValid = int.TryParse(userInput, out choice);

                    if (!isValid || (choice != 0 && (choice < 0 || choice > 3 || choice < previousChoicepaint)))
                    {
                        Console.WriteLine("Wrong input, please enter again.");
                    }
                    else if (choice != 0 && (!isValid || (choice < 0 || choice > 3) || (choice < previousChoicepaint)))
                    {
                        Console.WriteLine("Paint type you choose: ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid integer.");
                    isValid = false;
                }
            } while (!isValid || (choice != 0 && (choice < 0 || choice > 3 || choice < previousChoicepaint)));

            return choice;
        }



        public static void displaymenu()
        {
            Console.WriteLine("----------Choose paints----------");
            Console.WriteLine("YOU HAVE TO CHOOSE IN ORDER:1->2->3");
            Console.WriteLine(".         1.Glossy paint            .");
            Console.WriteLine(".         2.Antifouling paint       .");
            Console.WriteLine(".         3.Water proof paint       .");
            Console.WriteLine(".         0.Done and display        .");
        }
    }
}
