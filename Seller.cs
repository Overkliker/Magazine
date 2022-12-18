using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public class Seller
    {
        ModelOfWorker seller = new ModelOfWorker();
        //Товары на складе
        List<Product> allProducts = new List<Product>();
        List<SellerProduct> selledProducts = new List<SellerProduct>();
        public Seller(ModelOfWorker seller, List<Product> allProducts)
        {
            this.seller = seller;
            this.allProducts = allProducts;
        }

        internal enum Post
        {
            S = ConsoleKey.S,
            Plus = ConsoleKey.OemPlus,
            Minus = ConsoleKey.OemMinus,
            Enter = ConsoleKey.Enter,
            UpArrow = ConsoleKey.UpArrow,
            DownArrow = ConsoleKey.DownArrow,

        }
        public void Interface()
        {
            int pose = 2;
            int max = allProducts.Count() + 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(pose);
                Console.SetCursorPosition(0, pose);
                Console.WriteLine("->");

                InterfaceForUsers.PrintInterface(seller);
                PrintOrder();

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == (ConsoleKey)Post.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += max - 2;
                    }
                    else
                    {
                        pose--;
                    }

                }
                else if (key.Key == (ConsoleKey)Post.DownArrow)
                {
                    if (pose >= max)
                    {
                        pose -= max - 2;
                    }
                    else
                    {
                        pose++;
                    }

                }
                else if (key.Key == (ConsoleKey)Post.Plus)
                {
                    PlusProd(pose);
                }
                else if (key.Key == (ConsoleKey)Post.Minus)
                {
                    MInusProd(pose);
                }
                else if (key.Key == (ConsoleKey)Post.S)
                {
                    Save();
                }
            }
        
        }
        public void PlusProd(int id)
        {

        }
        public void MInusProd(int id)
        {

        }
        public void Save()
        {

        }
        public void PrintOrder()
        {
            foreach (Product i in selledProducts)
            {
                Console.WriteLine($"Название: {i.name},  Количество: {i.count}  Цена за шт.: {i.price}");
            }
        }

    }
}
