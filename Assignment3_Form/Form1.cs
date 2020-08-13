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
        Thread threadScan, threadArla, threadAxFood,threadICA,threadCOOP,threadCityGross, threadStorage;
        Semaphore semaphoreProducer = new Semaphore(1,1);
        Semaphore semaphoreConsumer = new Semaphore(1, 1);
        Mutex buffer = new Mutex();
        List<Item> storage = new List<Item>();
        List<Item> icaStorage = new List<Item>();
        List<Item> cityGrossStorage = new List<Item>();
        List<Item> coopStorage = new List<Item>();

        Random ran = new Random();
        Item item = new Item("test", 1, 1);
        bool scan, arla, axFood,ica, coop, cityGross,continueIca,continueCoop,continueCity,storageCheck = true;
        double icaCurrentItems, icaCurrentWeights, icaCurrentVolumes, coopCurrentItems, coopCurrentWeights, coopCurrentVolumes, cityGrossCurrentItems, cityGrossCurrentWeights, cityGrossCurrentVolumes;
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
           
            InitializeComponent();
            
            item.AddArlaProducts();
            item.AddScanProducts();
            item.AddAxFoodProducts();
            lblIcaItem.Text = "13";
            lblIcaWeight.Text = "12,00";
            lblIcaVolume.Text = "30,50";

            lblCoopItem.Text = "10";
            lblCoopWeight.Text = "27,00";
            lblCoopVolume.Text = "13,50";

            lblCityItem.Text = "30";
            lblCityWeight.Text = "50,10";
            lblCityVolume.Text = "43,51";
            progressItems.Value = 0;

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
                Thread.Sleep(1000);
                buffer.WaitOne();
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.scanItems.Count);
                    temp = ran.Next(0, item.scanItems.Count);
                    storage.Add(item.scanItems[temp]);
                }
                buffer.ReleaseMutex();

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
                Thread.Sleep(1000);
                buffer.WaitOne();
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.arlaItems.Count);
                    temp = ran.Next(0, item.arlaItems.Count);
                    storage.Add(item.arlaItems[temp]);
                }
                buffer.ReleaseMutex();
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
                Thread.Sleep(1000);
                buffer.WaitOne();
                if (storage.Count >= 50)
                {

                }
                else
                {
                    int temp = ran.Next(0, item.axFoodItems.Count);
                    temp = ran.Next(0, item.axFoodItems.Count);
                    storage.Add(item.axFoodItems[temp]);
                }
                buffer.ReleaseMutex();
            }
            MethodInvoker inv = delegate
            {
                lblStatusAxfood.Text = "Waiting";
            };
            Invoke(inv);
        }

        public void IcaTakeFromStorage()
        {
            MethodInvoker inv = delegate
            {
                lblIcaStatus.Text = "Waiting";

            };
            Invoke(inv);
            while (ica)
            {
                semaphoreProducer.WaitOne();
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
                    MethodInvoker inv2 = delegate
                    {
                        lblIcaStatus.Text = "Limit Reached";
                    };
                    Invoke(inv2);

                    if (chkIcaCont.Checked)
                    {
                        continueIca = true;
                        semaphoreProducer.Release();
                    }
                    else
                    {
                        ica = false;
                        //threadICA.Interrupt();
                    }
                }            
                else
                {
                    buffer.WaitOne();
                    if (storage.Count > 0)
                    {
                        icaStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                            MethodInvoker inv3 = delegate
                            {
                                lstIca.Items.Clear();
                                foreach (Item item in icaStorage)
                                {
                                    lstIca.Items.Add(item.name);
                                    lblIcaStatus.Text = "Loading";
                                }
                            };
                            Invoke(inv3);

                    }
                    else
                    {
                        MethodInvoker inv4 = delegate
                        {
                            lblIcaStatus.Text = "Waiting";

                        };
                        Invoke(inv4);
                    }
                    buffer.ReleaseMutex();
                    Thread.Sleep(100);
                }
                if (continueIca)
                {
                    Thread.Sleep(2000);
                    MethodInvoker inv5 = delegate
                    {
                        lblIcaStatus.Text = "Waiting";
                        icaStorage.Clear();
                        lstIca.Items.Clear();
                    };
                    Invoke(inv5);
                    Thread.Sleep(3000);
                }
                else
                {
                    semaphoreProducer.Release();
                }
                continueIca = false;
            }
            Thread.Sleep(5000);
            MethodInvoker inv6 = delegate
            {
                lblIcaStatus.Text = "Waiting";
                if (storage.Count > 0 && (double.Parse(lblIcaItem.Text) <= icaCurrentItems ||
                double.Parse(lblIcaWeight.Text) <= icaCurrentWeights + storage[storage.Count - 1].weight ||
                double.Parse(lblIcaVolume.Text) <= icaCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    icaStorage.Clear();
                    lstIca.Items.Clear();
                }
                btnStartIca.Enabled = true;
                btnStopIca.Enabled = false;
            };
            Invoke(inv6);

        }

        public void CoopTakeFromStorage()
        {
            MethodInvoker inv = delegate
            {
                lblCoopStatus.Text = "Waiting";
            };
            Invoke(inv);
            while (coop)
            {
                semaphoreProducer.WaitOne();
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
                    MethodInvoker inv2 = delegate
                    {
                        lblCoopStatus.Text = "Limit Reached";
                    };
                    Invoke(inv2);

                    if (chkCoopCont.Checked)
                    {
                        continueCoop = true;
                        semaphoreProducer.Release();

                    }
                    else
                    {
                        coop = false;
                    }


                }

                else
                {
                    buffer.WaitOne();
                    if (storage.Count > 0)
                    {
                        coopStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                        MethodInvoker inv3 = delegate
                        {
                            lstCoop.Items.Clear();
                            foreach (Item item in coopStorage)
                            {
                                lstCoop.Items.Add(item.name);
                                lblCoopStatus.Text = "Loading";
                            }
                        };
                        Invoke(inv3);
                    }
                    else
                    {
                        MethodInvoker inv4 = delegate
                        {
                            lblCoopStatus.Text = "Waiting";

                        };
                        Invoke(inv4);
                    }
                    buffer.ReleaseMutex();
                    Thread.Sleep(100);
                }
                if (continueCoop)
                {
                    Thread.Sleep(2000);
                    MethodInvoker inv5 = delegate
                    {
                        lblCoopStatus.Text = "Waiting";
                        coopStorage.Clear();
                        lstCoop.Items.Clear();
                    };
                    Invoke(inv5);

                    Thread.Sleep(3000);

                }
                else
                {
                semaphoreProducer.Release();
                }
                continueCoop = false;
            }
            Thread.Sleep(5000);
            MethodInvoker inv6 = delegate
            {
                lblCoopStatus.Text = "Waiting";
                if (storage.Count > 0 && (double.Parse(lblCoopItem.Text) <= coopCurrentItems ||
                double.Parse(lblCoopWeight.Text) <= coopCurrentWeights + storage[storage.Count - 1].weight ||
                double.Parse(lblCoopVolume.Text) <= coopCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    coopStorage.Clear();
                    lstCoop.Items.Clear();
                }
                btnStartCoop.Enabled = true;
                btnStopCoop.Enabled = false;
            };
            Invoke(inv6);

        }


        public void CityGrossTakeFromStorage()
        {
            MethodInvoker inv = delegate
            {
                lblCityStatus.Text = "Waiting";
            };
            Invoke(inv);

            while (cityGross)
            {
                semaphoreProducer.WaitOne();
                Thread.Sleep(200);
                cityGrossCurrentWeights = 0;
                cityGrossCurrentVolumes = 0;
                foreach (Item item in cityGrossStorage)
                {
                    cityGrossCurrentItems = cityGrossStorage.Count;
                    cityGrossCurrentWeights += item.weight;
                    cityGrossCurrentVolumes += item.volume;
                }

                if (storage.Count > 0 && (double.Parse(lblCityItem.Text) <= cityGrossCurrentItems ||
                    double.Parse(lblCityWeight.Text) <= cityGrossCurrentWeights + storage[storage.Count - 1].weight ||
                    double.Parse(lblCityVolume.Text) <= cityGrossCurrentVolumes + storage[storage.Count - 1].volume))
                {
                    MethodInvoker inv2 = delegate
                    {
                        lblCityStatus.Text = "Limit Reached";
                    };
                    Invoke(inv2);

                    if (chkCityCont.Checked)
                    {
                        continueCity = true;
                        semaphoreProducer.Release();

                    }
                    else
                    {
                        cityGross = false;
                    }
                }
                else
                {
                    buffer.WaitOne();
                    if (storage.Count > 0)
                    {
                        cityGrossStorage.Add(storage[storage.Count - 1]);
                        storage.Remove(storage[storage.Count - 1]);
                        MethodInvoker inv3 = delegate
                        {
                            lstCity.Items.Clear();
                            foreach (Item item in cityGrossStorage)
                            {
                                lstCity.Items.Add(item.name);
                                lblCityStatus.Text = "Loading";
                            }
                        };
                        Invoke(inv3);
                    }
                    else
                    {
                        MethodInvoker inv4 = delegate
                        {
                            lblCityStatus.Text = "Waiting";

                        };
                        Invoke(inv4);
                    }
                    buffer.ReleaseMutex();
                    Thread.Sleep(100);

                }
                if (continueCity)
                {
                    Thread.Sleep(5000);
                    MethodInvoker inv5 = delegate
                    {
                        lblCityStatus.Text = "Waiting";
                        cityGrossStorage.Clear();
                        lstCity.Items.Clear();
                    };
                    Invoke(inv5);

                    Thread.Sleep(3000);
                }
                else
                {
                semaphoreProducer.Release();
                }
                continueCity = false;
                
            }
            Thread.Sleep(5000);
            MethodInvoker inv6 = delegate
            {
                lblCityStatus.Text = "Waiting";
                if (storage.Count > 0 && (double.Parse(lblCityItem.Text) <= cityGrossCurrentItems ||
                    double.Parse(lblCityWeight.Text) <= cityGrossCurrentWeights + storage[storage.Count - 1].weight ||
                    double.Parse(lblCityVolume.Text) <= cityGrossCurrentVolumes + storage[storage.Count - 1].volume))
                {
                cityGrossStorage.Clear();
                lstCity.Items.Clear();
                }
                btnStartCity.Enabled = true;
                btnStopCity.Enabled = false;
            };
            Invoke(inv6);
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
            btnStart.Visible = false;
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
            btnStartIca.Enabled = false;
            btnStopIca.Enabled = true;
        }

        /// <summary>
        /// Stop Ica thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {
            ica = false;
            btnStopIca.Enabled = false;
            btnStartIca.Enabled = true;
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
            btnStartCoop.Enabled = false;
            btnStopCoop.Enabled = true;

        }

        /// <summary>
        /// Stop coop thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCoop_Click(object sender, EventArgs e)
        {
            coop = false;
            btnStartCoop.Enabled = true;
            btnStopCoop.Enabled = false;

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
            btnStartCity.Enabled = false;
            btnStopCity.Enabled = true;

        }

        /// <summary>
        /// Stop city gross thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCity_Click(object sender, EventArgs e)
        {
            cityGross = false;
            btnStartCity.Enabled = true;
            btnStopCity.Enabled = false;
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
