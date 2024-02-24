using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        ///<summary>Receives a integer input. And Returns the an integer input</summary>
        ///<param name="Y">The input integer represents the year</param>
        ///<returns>Returns an integer {D} which is the next year after {Y} with distinct digits</returns>
        ///<example>
        ///GET api/J3/DistinctYear/1987 ->2013
        /// </example>
        /// <example>
        ///GET api/J3/DistinctYear/999 ->1023
        /// </example>
        [HttpGet]
        [Route("api/J3/DistinctYear/{Y}")]
        public int DistinctYear(int Y)
        {
            int D;
            while (Y>=0 && Y <=10000)
            {
                Y++;

                if(YearHasDistinctDigits(Y))
                {
                    D = Y;
                    return D;
                }
            }
            return 0;
        }
        private bool YearHasDistinctDigits(int year)
        {
            string yearInString = year.ToString();




            //Tried Different Logics/loops but kept getting errors unfortuantely. Was not able to figure it out this time.
            //Will definitely try solving this in the reading week
            return true;
        }
    }
}
