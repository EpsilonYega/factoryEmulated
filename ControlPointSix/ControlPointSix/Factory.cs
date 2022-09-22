using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPointSix
{
    internal class Factory
    {
        int wood = 1000;
        int plastic = 500;

        List<IForSale> products = new List<IForSale>();

        public void CreatePencil(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Pencil pencil = new Pencil();
                products.Add(pencil);
                wood -= 10;
                plastic -= 5;
            }
        }
        public void CreatePen(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Pen pen = new Pen();
                products.Add(pen);
                plastic -= 5;
            }
        }

        public void ShowResouces()
        {
            Console.Write($"Осталось дерева: " + wood + "\t" + "|" + "\t");
            Console.Write($"Осталось пластика: " + plastic);
        }
        public void ShowCost()
        {
            var price = 0;
            foreach (var el in products)
            {
                price += el.Sale();
            }
            Console.Write("\t" + "Итого: " + price + "\t" + "|" + "\t");
        }
    }
}