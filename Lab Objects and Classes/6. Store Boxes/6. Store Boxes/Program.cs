using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();

            while(true)
            {
                List<string> input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                if (input[0] == "end")
                    break;

                Item item = new Item(input[1], double.Parse(input[3]));
                items.Add(item);

                Box box = new Box(input[0], input[1], int.Parse(input[2]), int.Parse(input[2])*double.Parse(input[3]));
                boxes.Add(box);
            }

            foreach(var val in boxes.OrderByDescending(x=>x.BoxPrice))
            {
                Console.WriteLine($"{val.BoxSerialNumber}");

                foreach(var i in items.Where(z=>z.ItemName == val.BoxItem))
                   Console.WriteLine($"-- {val.BoxItem} - ${(i.ItemPrice):f2}: {val.BoxItemQuantity}");

                Console.WriteLine($"-- ${(val.BoxPrice):f2}");
            }
        }
    }



    class Item
    {
        public Item(string itemName, double itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public string ItemName { get; set; }

        public double ItemPrice { get; set; }
    }



    class Box
    {
        public Box(string boxSerialNumber, string boxItem, int boxItemQuantity, double boxPrice)
        {
            BoxSerialNumber = boxSerialNumber;
            BoxItem = boxItem;
            BoxItemQuantity = boxItemQuantity;
            BoxPrice = boxPrice;
        }

        public string BoxSerialNumber { get; set; }

        public string BoxItem { get; set; }

        public int BoxItemQuantity { get; set; }

        public double BoxPrice { get; set; }
    }


}
