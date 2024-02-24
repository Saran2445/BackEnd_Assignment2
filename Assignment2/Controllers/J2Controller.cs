using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>Receives 2 integer inputs {m}/{n}. And Returns the string There are {count} ways to get the sum 10 where count is the output integer</summary>
        ///<param name="m">The first input integer representing the sides of the first dice</param>
        ///<param name="n">The second input integer representing the sides of the second dice</param>
        ///<returns>Returns the string There are {count} ways to get the sum 10 where count is the output integer</returns>
        ///<example>
        ///GET api/J2/DiceGame/6/8 ->There are 5 ways to get the sum 10
        /// </example>
        /// <example>
        ///GET api/J2/DiceGame/3/3 ->There are 0 ways to get the sum 10
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public String DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i+j==10)
                    {
                        count++;
                    }
                }
            }
            return "There are"+ " " +count+" " +"ways to get the sum 10";
        }
    }
}
