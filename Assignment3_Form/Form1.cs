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
    public partial class Form1 : Form
    {
        Thread threadScan, threadArla, threadaxFood,threadICA,threadCOOP,threadCityGross,threadStorage;
        List<Item> storage = new List<Item>();
        List<Item> icaStorage = new List<Item>();
        Random ran = new Random();
        bool scan, arla, axFood,ica, coop, cityGross,storageCheck = true;
        int icaCurrentItems, icaCurrentWeights, icaCurrentVolumes;
        public Form1()
        {
            InitializeComponent();
        }

        public void GetRandomItem()
        {
            
        }
        public void StorageCheck()
        {
            while (storageCheck)
            {
                MethodInvoker inv = delegate
                {
                    progressItems.Value = storage.Count;

                };
                Invoke(inv);
            }
        }
        public void Produce()
        {
            while (scan)
            {
                Thread.Sleep(100);
                if (storage.Count >= 50)
                {
                    MessageBox.Show("FULL");
                    scan = false;
                }
                else
                {
                    storage.Add(new Item("bread", 1, 3));
                }
            }

        }
        public void TakeFromStorage()
        {
            while (ica)
            {
                Thread.Sleep(50);
                icaCurrentWeights = 0;
                icaCurrentVolumes = 0;
                foreach (Item item in icaStorage)
                {
                    icaCurrentItems = icaStorage.Count;
                    icaCurrentWeights += item.weight;
                    icaCurrentVolumes += item.volume;
                }
                if (int.Parse(lblIcaItem.Text) == icaCurrentItems|| int.Parse(lblIcaWeight.Text) == icaCurrentWeights || int.Parse(lblIcaVolume.Text) <= icaCurrentVolumes)
                {
                    MessageBox.Show(icaCurrentItems.ToString() + icaCurrentWeights.ToString() + icaCurrentVolumes.ToString());
                }
                else
                {
                    icaStorage.Add(storage[storage.Count - 1]);
                    storage.Remove(storage[storage.Count - 1]);
                }
            }
        }

        /// <summary>
        /// Start scan producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            threadScan = new Thread(Produce);
            threadScan.Start();
            scan = true;
            btnStopScan.Enabled = true;
            btnStartScan.Enabled = false;
        }

        /// <summary>
        /// Start arla producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartArla_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start axfood producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartAxfood_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Stop scan producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopScan_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            threadStorage = new Thread(StorageCheck);
            threadStorage.Start();
            lblIcaItem.Text = "15";
            lblIcaWeight.Text = "27.00";
            lblIcaVolume.Text = "12.50";
        }

        /// <summary>
        /// Stop arla producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopArla_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Stop axfood producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopAxfood_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start Ica consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
            threadICA = new Thread(TakeFromStorage);
            threadICA.Start();
            ica = true;

        }

        /// <summary>
        /// Stop Ica thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {
            ica = false;
        }

        /// <summary>
        /// Start Coop consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCoop_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Stop coop thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCoop_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start City Gross consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCity_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Stop city gross thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCity_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }


    }
}
