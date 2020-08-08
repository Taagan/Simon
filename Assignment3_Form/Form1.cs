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
        Thread threadScan, threadArla, threadAxFood,threadICA,threadCOOP,threadCityGross,threadStorage;
        Semaphore semaphoreObject = new Semaphore(1,1);
        List<Item> storage = new List<Item>();
        List<Item> icaStorage = new List<Item>();
        List<Item> cityGrossStorage = new List<Item>();
        List<Item> coopStorage = new List<Item>();

        Random ran = new Random();
        Item item = new Item("test", 1, 1);
        bool scan, arla, axFood,ica, coop, cityGross,storageCheck = true;
        double icaCurrentItems, icaCurrentWeights, icaCurrentVolumes, coopCurrentItems, coopCurrentWeights, coopCurrentVolumes, cityGrossCurrentItems, cityGrossCurrentWeights, cityGrossCurrentVolumes;
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
           
            InitializeComponent();
            
            item.AddArlaProducts();
            item.AddScanProducts();
            item.AddAxFoodProducts();
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
        public void ScanProduce()
        {
            while (scan)
            {
                Thread.Sleep(100);
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.scanItems.Count);
                    temp = ran.Next(0, item.scanItems.Count);
                    storage.Add(item.scanItems[temp]);
                }
            }
            MethodInvoker inv = delegate
            {
                lblStatusScan.Text = "Waiting";
            };
            Invoke(inv);
        }

        public void ArlaProduce()
        {
            while (arla)
            {
                Thread.Sleep(100);
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.arlaItems.Count);
                    temp = ran.Next(0, item.arlaItems.Count);
                    storage.Add(item.arlaItems[temp]);
                }
            }
            MethodInvoker inv = delegate
            {
                lblStatusArla.Text = "Waiting";
            };
            Invoke(inv);
        }


        public void AxFoodProduce()
        {
            while (axFood)
            {
                Thread.Sleep(100);
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.axFoodItems.Count);
                    temp = ran.Next(0, item.axFoodItems.Count);
                    storage.Add(item.axFoodItems[temp]);
                }
            }
            MethodInvoker inv = delegate
            {
                lblStatusAxfood.Text = "Waiting";
            };
            Invoke(inv);
        }



        public void IcaTakeFromStorage()
        {
            
            while (ica)
            {
                semaphoreObject.WaitOne();
                Thread.Sleep(200);
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
                        
                    }
                    else
                    {
                        MethodInvoker inv3 = delegate
                        {
                            lblIcaStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        ica = false;
                        //threadICA.Interrupt();
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
                semaphoreObject.Release();
                
            }
            Thread.Sleep(5000);
        }

        public void CoopTakeFromStorage()
        {

            while (coop)
            {
                semaphoreObject.WaitOne();
                Thread.Sleep(200);
                coopCurrentWeights = 0;
                coopCurrentVolumes = 0;
                foreach (Item item in coopStorage)
                {
                    coopCurrentItems = coopStorage.Count;
                    coopCurrentWeights += item.weight;
                    coopCurrentVolumes += item.volume;
                }

                if (storage.Count > 0 && (double.Parse(lblCoopItem.Text) <= coopCurrentItems || double.Parse(lblCoopWeight.Text) <= coopCurrentWeights + storage[storage.Count - 1].weight || double.Parse(lblCoopVolume.Text) <= coopCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    MethodInvoker inv = delegate
                    {
                        lblCoopStatus.Text = "Limit Reached";
                        coopStorage.Clear();
                        lstCoop.Items.Clear();
                    };
                    Invoke(inv);

                    if (chkCoopCont.Checked)
                    {
                        
                    }
                    else
                    {
                        MethodInvoker inv2 = delegate
                        {
                            lblCoopStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        coop = false;
                    }


                }

                else
                {
                    if (storage.Count > 0)
                    {
                        coopStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                        foreach (Item item in coopStorage)
                        {
                            MethodInvoker inv = delegate
                            {
                                lstCoop.Items.Add(item.name);
                                lblCoopStatus.Text = "Loading";
                            };
                            Invoke(inv);
                        }
                    }
                    else
                    {
                        MethodInvoker inv = delegate
                        {
                            lblCoopStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        Thread.Sleep(100);
                    }
                }
                semaphoreObject.Release();
               
            }
            Thread.Sleep(5000);
        }


        public void CityGrossTakeFromStorage()
        {

            while (cityGross)
            {
                semaphoreObject.WaitOne();
                Thread.Sleep(200);
                cityGrossCurrentWeights = 0;
                cityGrossCurrentVolumes = 0;
                foreach (Item item in cityGrossStorage)
                {
                    cityGrossCurrentItems = cityGrossStorage.Count;
                    cityGrossCurrentWeights += item.weight;
                    cityGrossCurrentVolumes += item.volume;
                }

                if (storage.Count > 0 && (double.Parse(lblCityItem.Text) <= cityGrossCurrentItems || double.Parse(lblCityWeight.Text) <= cityGrossCurrentWeights + storage[storage.Count - 1].weight || double.Parse(lblCityVolume.Text) <= cityGrossCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    MethodInvoker inv = delegate
                    {
                        lblCityStatus.Text = "Limit Reached";
                        cityGrossStorage.Clear();
                        lstCity.Items.Clear();
                    };
                    Invoke(inv);

                    if (chkCityCont.Checked)
                    {
                        
                    }
                    else
                    {
                        MethodInvoker inv3 = delegate
                        {
                            lblCityStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        cityGross = false;
                        //threadICA.Interrupt();
                    }


                }

                else
                {
                    if (storage.Count > 0)
                    {
                        cityGrossStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                        foreach (Item item in cityGrossStorage)
                        {
                            MethodInvoker inv = delegate
                            {
                                lstCity.Items.Add(item.name);
                                lblCityStatus.Text = "Loading";
                            };
                            Invoke(inv);
                        }
                    }
                    else
                    {
                        MethodInvoker inv = delegate
                        {
                            lblCityStatus.Text = "Waiting";

                        };
                        Invoke(inv);
                        Thread.Sleep(100);
                    }
                }
                semaphoreObject.Release();
                
            }
            Thread.Sleep(5000);
        }




        /// <summary>
        /// Start scan producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            threadScan = new Thread(ScanProduce);
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
            threadArla = new Thread(ArlaProduce);
            threadArla.Start();
            arla = true;
            btnStopArla.Enabled = true;
            btnStartArla.Enabled = false;
            lblStatusArla.Text = "Producing";
        }

        /// <summary>
        /// Start axfood producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartAxfood_Click(object sender, EventArgs e)
        {
            threadAxFood = new Thread(AxFoodProduce);
            threadAxFood.Start();
            axFood = true;
            btnStopAxfood.Enabled = true;
            btnStartAxfood.Enabled = false;
            lblStatusAxfood.Text = "Producing";
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
            lblIcaItem.Text = "13";
            lblIcaWeight.Text = "12,00";
            lblIcaVolume.Text = "30,50";

            lblCoopItem.Text = "10";
            lblCoopWeight.Text = "27,00";
            lblCoopVolume.Text = "13,50";

            lblCityItem.Text = "30";
            lblCityWeight.Text = "50,10";
            lblCityVolume.Text = "43,51";
        }

        /// <summary>
        /// Stop arla producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopArla_Click(object sender, EventArgs e)
        {
            arla = false;
            btnStopArla.Enabled = false;
            btnStartArla.Enabled = true;
        }

        /// <summary>
        /// Stop axfood producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopAxfood_Click(object sender, EventArgs e)
        {
            axFood = false;
            btnStopAxfood.Enabled = false;
            btnStartAxfood.Enabled = true;
        }

        /// <summary>
        /// Start Ica consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
            threadICA = new Thread(IcaTakeFromStorage);
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
            threadCOOP = new Thread(CoopTakeFromStorage);
            threadCOOP.Start();
            coop = true;
        }

        /// <summary>
        /// Stop coop thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCoop_Click(object sender, EventArgs e)
        {
            coop = false;
        }

        /// <summary>
        /// Start City Gross consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCity_Click(object sender, EventArgs e)
        {
            threadCityGross = new Thread(CityGrossTakeFromStorage);
            threadCityGross.Start();
            cityGross = true;
        }

        /// <summary>
        /// Stop city gross thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCity_Click(object sender, EventArgs e)
        {
            cityGross = false;
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
