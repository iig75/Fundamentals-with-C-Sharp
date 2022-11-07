using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "end")
                    break;

                if (!boxes.Any(x => x.BoXSerialNumber == command[0]))
                {
                    Item item = new Item(command[1], decimal.Parse(command[3]));
                    Box box = new Box(command[0], item, int.Parse(command[2]), (decimal.Parse(command[3]) * decimal.Parse(command[2])));

                    boxes.Add(box);
                }
            }

            foreach (var val in boxes.OrderByDescending(x => x.BoxPricePerBox))
            {
                Console.WriteLine($"{val.BoXSerialNumber}");
                Console.WriteLine($"-- {val.Item.ItemName} - ${ val.Item.ItemPrice:f2}: { val.BoxItemQuontity}");
                Console.WriteLine($"-- ${val.BoxPricePerBox:f2}");
            }
        }
    }



    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }



    class Box
    {
        public Box(string boXSerialNumber, Item item, int boxItemQuontity, decimal boxPricePerBox)
        {
            BoXSerialNumber = boXSerialNumber;
            Item = item;
            BoxItemQuontity = boxItemQuontity;
            BoxPricePerBox = boxPricePerBox;
        }

        public string BoXSerialNumber { get; set; }

        public Item Item { get; set; }

        public int BoxItemQuontity { get; set; }

        public decimal BoxPricePerBox { get; set; }
    }

}
