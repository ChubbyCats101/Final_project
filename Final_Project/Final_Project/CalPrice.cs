using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class CalPrice
    {
        public int CalculateTotalPrice(string spaceship, string planet)
        {
            // คำนวณราคา

            // ราคาเริ่มต้น
            int price = 1000000;

            // เพิ่มราคาตามยานอวกาศ
            switch (spaceship)
            {
                case "Skywalker OG":
                    price += 500000;
                    break;
                case "Ghost Train Haze":
                    price += 2000000;
                    break;
                case "Blue Dream":
                    price += 7000000;
                    break;
                case "Candy Kush Express":
                    price += 9000000;
                    break;
            }

            // เพิ่มราคาตามดาวเคราะห์
            switch (planet)
            {
                case "Matar Bay":
                    price += 500000;
                    break;
                case "Alathfar XI":
                    price += 800000;
                    break;
                case "Charon Prime":
                    price += 650000;
                    break;
                case "Asperoth Prime":
                    price += 980000;
                    break;
                case "Bore Rock":
                    price += 1100000;
                    break;
                case "Pathfinder V":
                    price += 1000000;
                    break;
                case "Klen Dahth II":
                    price += 2000000;
                    break;
                case "Widow's Harbor":
                    price += 2300000;
                    break;
                case "New Haven":
                    price += 3000000;
                    break;
                case "Pilen V":
                    price += 5500000;
                    break;
            }

            // ส่งคืนราคา
            return price;
        }
    }
}
