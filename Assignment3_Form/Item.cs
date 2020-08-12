using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Assignment3_Form
{
    class Item
    {
        public string name;
        public double weight, volume;
        float productionTime;
        public List<Item> arlaItems = new List<Item>();
        public List<Item> scanItems = new List<Item>();
        public List<Item> axFoodItems = new List<Item>();

        public Item(string name, double weight, double volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }




        public void AddArlaProducts()
        {
            arlaItems.Clear();
            StreamReader sr = new StreamReader("ArlaItems.txt");

            while (!sr.EndOfStream)
            {

                string tempName = sr.ReadLine();
                double tempWeight = double.Parse(sr.ReadLine());
                double tempVolym = double.Parse(sr.ReadLine());

                arlaItems.Add(new Item(tempName, tempWeight, tempVolym));
            }
            sr.Close();

        }

        public void AddScanProducts()
        {
            scanItems.Clear();
            StreamReader sr = new StreamReader("ScanItems.txt");

            while (!sr.EndOfStream)
            {

                string tempName = sr.ReadLine();
                double tempWeight = double.Parse(sr.ReadLine());
                double tempVolym = double.Parse(sr.ReadLine());

                scanItems.Add(new Item(tempName, tempWeight, tempVolym));
            }
            sr.Close();

        }




        public void AddAxFoodProducts()
        {
            axFoodItems.Clear();
            StreamReader sr = new StreamReader("AxFoodItems.txt");

            while (!sr.EndOfStream)
            {

                string tempName = sr.ReadLine();
                double tempWeight = double.Parse(sr.ReadLine());
                double tempVolym = double.Parse(sr.ReadLine());

                axFoodItems.Add(new Item(tempName, tempWeight, tempVolym));
            }
            sr.Close();

        }




    }
}
