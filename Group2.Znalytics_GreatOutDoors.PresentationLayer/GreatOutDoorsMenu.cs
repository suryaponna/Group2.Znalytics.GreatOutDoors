using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class GreatOutDoorsMenu
    {
        static void Main() {
            WriteLine("----------------WelCome TO GreatOutDoors hope you find your things here----------------");
            WriteLine();
            while (true) {
                WriteLine("Enter 1 to sign up");
                WriteLine();
                WriteLine("Enter 2 to sign in");
                int option;
                bool b = int.TryParse(ReadLine(), out option);
                switch(option){
                    case 1:     CustomerSignUp();
                                break;
                    case 2:     CustomerSignIn();
                                break;
                    default:    WriteLine("Enter Valid Option");
                                break;  
                }
            }
        }
        static void CustomerSignUp() {



            SelectProducts();
        }
        static void CustomerSignIn() {



            SelectProducts();
        }
        static void SelectProducts() {
            WriteLine("-----------------These are the Products Hope you find out what you want---------------");

        }

    }
}
