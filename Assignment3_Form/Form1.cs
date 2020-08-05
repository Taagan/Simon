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
        double icaCurrentItems, icaCurrentWeights, icaCurrentVolumes;
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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

                }
                else
                {
                    storage.Add(new Item("bread", 1, 1));
                }
            }
            MethodInvoker inv = delegate
            {
                lblStatusScan.Text = "Waiting";
            };
            Invoke(inv);
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

                if (storage.Count > 0 && (double.Parse(lblIcaItem.Text) <= icaCurrentItems || double.Parse(lblIcaWeight.Text) <= icaCurrentWeights + storage[storage.Count - 1].weight || double.Parse(lblIcaVolume.Text) <= icaCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    MethodInvoker inv = delegate
                    {
                        lblIcaStatus.Text = "Limit Reached";
                        icaStorage.Clear();
                        lstIca.Items.Clear();
                    };
                    Invoke(inv);

                    if (chkIcaCont.Checked)
                    {
                            Thread.Sleep(5000);
                    }
                    else
                    {
                        MethodInvoker inv3 = delegate
                        {
                            lblIcaStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        ica = false;
                        threadICA.Interrupt();
                    }
                }
                else
                {
                    if (storage.Count > 0)
                    {
                        icaStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                        foreach (Item item in icaStorage)
                        {
                            MethodInvoker inv = delegate
                            {
                                lstIca.Items.Add(item.name);
                                lblIcaStatus.Text = "Loading";
                            };
                            Invoke(inv);
                        }
                    }
                    else
                    {
                        MethodInvoker inv = delegate
                        {
                            lblIcaStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        Thread.Sleep(100);
                    }
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
            lblStatusScan.Text = "Producing";
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
            scan = false;
            btnStopScan.Enabled = false;
            btnStartScan.Enabled = true;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            threadStorage = new Thread(StorageCheck);
            threadStorage.Start();
            lblIcaItem.Text = "15";
            lblIcaWeight.Text = "27,00";
            lblIcaVolume.Text = "12,50";
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
