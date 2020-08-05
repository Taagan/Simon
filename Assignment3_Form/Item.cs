using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Assignment3_Form
{
    class Item
    {
        string name;
        public int weight, volume;
        float productionTime;
        public Item(string name, int weight, int volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }




        public void produce()
        {

        }
    }
}
