using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<summary>Receives 4 integer inputs {burger}/{drink}/{side}/{dessert}. And Returns the string Your total calories is {totalCalories} where totalCalories is the output integer</summary>
        ///<param name="burger">The first input integer representing the choice of burger</param>
        ///<param name="drink">The second input integer representing the choice of drink</param>
        ///<param name="side">The third input integer representing the choice of side</param>
        ///<param name="dessert">The fourth input integer representing the choice of dessert</param>
        ///<returns>Your total calories is totalCalories where {totalCalories} is the output integer</returns>
        ///<example>
        ///GET api/J1/Menu/4/4/4/4 ->Your total calorie count is 0
        /// </example>
        /// <example>
        ///GET api/J1/Menu/1/2/3/4 ->Your total calorie count is 691
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public String Menu(int burger,int drink,int side,int dessert)
        {
            int [] burgerCalories = { 461, 431, 420, 0 };
            int [] drinkCalories = { 130, 160, 118, 0 };
            int [] sideCalories = { 100, 57, 70, 0 };
            int [] dessertCalories = { 167, 266, 75, 0 };
            int totalCalories = 0;
            totalCalories = totalCalories + burgerCalories[burger - 1];
            totalCalories = totalCalories + drinkCalories[drink - 1];
            totalCalories = totalCalories + sideCalories[side - 1];
            totalCalories = totalCalories + dessertCalories[dessert - 1];
            return "Your total calorie count is" + " " +totalCalories;
        }
    }
}
