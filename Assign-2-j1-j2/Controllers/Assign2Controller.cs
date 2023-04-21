using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_2_j1_j2.Controllers
{
    public class Assign2Controller : ApiController
    {
        [HttpGet]
        public int GetDiceGame(int m, int n)
        {

            int numWays = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        numWays++;
                    }
                }
            }

            return numWays;



        }

        //GET:api/MenCalorieCount/int burger/int drink/int side/int dessert
        [HttpGet]
        public int MenuCalorieCount(int burger, int drink, int side, int dessert)
        {
            //int TotalCalories=burger+drink+side+dessert;

            if (burger == 1)
            {
                burger = 461;
            }
            else if (burger == 2)
            {
                burger = 431;
            }
            else if (burger == 3)
            {
                burger = 420;
            }
            else if (burger == 4)
            {
                burger = 0;


            }
            if (drink == 1)
            {
                drink = 130;

            }
            else if (drink == 2)
            {
                drink = 160;
            }
            else if (drink == 3)
            {
                drink = 118;

            }
            else if (drink == 4)
            {
                drink = 0;
            }

            if (side == 1)
            {
                side = 100;
            }
            else if (side == 2)
            {
                side = 57;
            }
            else if (side == 3)
            {
                side = 70;
            }
            else if (side == 4)
            {
                side = 0;


            }
            if (dessert == 1)
            {
                dessert = 461;
            }
            else if (dessert == 2)
            {
                dessert = 431;
            }
            else if (dessert == 3)
            {
                dessert = 420;
            }
            else if (dessert == 4)
            {
                dessert = 0;


            }

            int TotalCalories = burger + drink + side + dessert;

            return TotalCalories;
        }

    }
}

    
