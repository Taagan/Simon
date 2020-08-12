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
        //Semaphore semaphoreProducer = new Semaphore(1,1);
        Semaphore semaphoreConsumer = new Semaphore(1, 1);
        Mutex buffer = new Mutex();
        List<Item> storage = new List<Item>();
        List<Item> icaStorage = new List<Item>();
        List<Item> cityGrossStorage = new List<Item>();
        List<Item> coopStorage = new List<Item>();

        double currentItems, currentWeights, currentVolumes;

        double icaMaxVol = 30.5;
        double icaMaxWeight = 12;
        int icaMaxAmount = 13;

        double coopMaxVol = 13.5;
        double coopMaxWeight = 27;
        int coopMaxAmount = 10;

        double cityGrossMaxVol = 43.51;
        double cityGrossMaxWeight = 50.1;
        int cityGrossMaxAmount = 30;

        Random ran = new Random();
        Item item = new Item("test", 1, 1);
        bool scan, arla, axFood,ica, coop, cityGross,continueIca,continueCoop,continueCity, run, storageCheck = true;
     
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
           
            InitializeComponent();
            
            item.AddArlaProducts();
            item.AddScanProducts();
            item.AddAxFoodProducts();
            lblIcaItem.Text = icaMaxAmount.ToString();
            lblIcaWeight.Text = icaMaxWeight.ToString();
            lblIcaVolume.Text = icaMaxVol.ToString();

            lblCoopItem.Text = coopMaxAmount.ToString();
            lblCoopWeight.Text = coopMaxWeight.ToString();
            lblCoopVolume.Text = coopMaxVol.ToString();

            lblCityItem.Text = cityGrossMaxAmount.ToString();
            lblCityWeight.Text = cityGrossMaxWeight.ToString();
            lblCityVolume.Text = cityGrossMaxVol.ToString();
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
        public void Produce(bool run, string id)
        {
            
            while (run)
            {
                
                Thread.Sleep(1000);
                buffer.WaitOne();
                    if (storage.Count >= 50)
                    {

                    }
                    else
                    {
                        int tempN = ran.Next(0, item.GetItemAmount(id));
                        tempN = ran.Next(0, item.GetItemAmount(id));
                        storage.Add(item.GetLastItem(id, tempN));


                    }

                buffer.ReleaseMutex();
            }
            MethodInvoker inv = delegate
            {

                if (id == "arla")
                {
                    lblStatusArla.Text = "Waiting";
                    run = arla;
                }
                else if (id == "scan")
                {
                    lblStatusScan.Text = "Waiting";
                    run = scan;
                }
                else if (id == "axFood")
                {
                    lblStatusAxfood.Text = "Waiting";
                    run = axFood;
                }
                
            };

            Invoke(inv);
            
        }

        
        public void TakeFromStorage(bool run, string id)
        {
            
            MethodInvoker inv = delegate
            {
                

                if (id == "ica")
                {
                    lblIcaStatus.Text = "Waiting";
                }
                else if (id == "coop")
                {
                    lblCoopStatus.Text = "Waiting";
                }
                else if (id == "cityGross")
                {
                    lblCityStatus.Text = "Waiting";
                }


            };
            Invoke(inv);


            currentItems = 0;
            currentVolumes = 0;
            currentWeights = 0;

            double tempMaxVol = 0;
            double tempMaxWeight = 0;
            double tempMaxNumber = 0;


            if (id == "ica")
            {
                tempMaxVol = icaMaxVol;
                tempMaxNumber = icaMaxAmount;
                tempMaxWeight = icaMaxWeight;
                foreach (Item item in icaStorage)
                {
                    currentItems = icaStorage.Count;
                    currentWeights += item.weight;
                    currentVolumes += item.volume;
                }
            }
            else if (id == "coop")
            {
                tempMaxVol = coopMaxVol;
                tempMaxNumber = coopMaxAmount;
                tempMaxWeight = coopMaxWeight;
                foreach (Item item in coopStorage)
                {
                    currentItems = coopStorage.Count;
                    currentWeights += item.weight;
                    currentVolumes += item.volume;
                }
            }
            else if (id == "cityGross")
            {
                tempMaxVol = cityGrossMaxVol;
                tempMaxNumber = cityGrossMaxAmount;
                tempMaxWeight = cityGrossMaxWeight;
                foreach (Item item in cityGrossStorage)
                {
                    currentItems = cityGrossStorage.Count;
                    currentWeights += item.weight;
                    currentVolumes += item.volume;
                }
            }

            while (run)
            {
                
                semaphoreConsumer.WaitOne();
                Thread.Sleep(200);

                currentItems = 0;
                currentVolumes = 0;
                currentWeights = 0;

                tempMaxVol = 0;
                tempMaxWeight = 0;
                tempMaxNumber = 0;


                if (id == "ica")
                {
                    tempMaxVol = icaMaxVol;
                    tempMaxNumber = icaMaxAmount;
                    tempMaxWeight = icaMaxWeight;
                    foreach (Item item in icaStorage)
                    {
                        currentItems = icaStorage.Count;
                        currentWeights += item.weight;
                        currentVolumes += item.volume;
                    }
                }
                else if (id == "coop")
                {
                    tempMaxVol = coopMaxVol;
                    tempMaxNumber = coopMaxAmount;
                    tempMaxWeight = coopMaxWeight;
                    foreach (Item item in coopStorage)
                    {
                        currentItems = coopStorage.Count;
                        currentWeights += item.weight;
                        currentVolumes += item.volume;
                    }
                }
                else if (id == "cityGross")
                {
                    tempMaxVol = cityGrossMaxVol;
                    tempMaxNumber = cityGrossMaxAmount;
                    tempMaxWeight = cityGrossMaxWeight;
                    foreach (Item item in cityGrossStorage)
                    {
                        currentItems = cityGrossStorage.Count;
                        currentWeights += item.weight;
                        currentVolumes += item.volume;
                    }
                }


                if (storage.Count > 0 && (tempMaxNumber <= currentItems || tempMaxWeight <= currentWeights + storage[storage.Count - 1].weight || tempMaxVol <= currentVolumes + storage[storage.Count - 1].volume))
                {
                    MethodInvoker inv2 = delegate
                    {
                        if (id == "ica")
                        {
                            lblIcaStatus.Text = "Limit Reached";
                        }
                        else if (id == "coop")
                        {
                            lblCoopStatus.Text = "Limit Reached";
                        }
                        else if (id == "cityGross")
                        {
                            lblCityStatus.Text = "Limit Reached";
                        }
                       
                    };
                    Invoke(inv2);



                    if (id == "ica")
                    {
                        if (chkIcaCont.Checked)
                        {
                            continueIca = true;
                            semaphoreConsumer.Release();
                        }
                        else
                        {
                            ica = false;
                        }
                    }
                    else if (id == "coop")
                    {
                        if (chkCoopCont.Checked)
                        {
                            continueCoop = true;
                            semaphoreConsumer.Release();
                        }
                        else
                        {
                            coop = false;
                        }
                    }
                    else if (id == "cityGross")
                    {
                        if (chkCityCont.Checked)
                        {
                            continueCity = true;
                            semaphoreConsumer.Release();
                        }
                        else
                        {
                            cityGross = false;
                        }
                    }
                }
            
                else
                {
                    buffer.WaitOne();
                    if (storage.Count > 0)
                    {



                        if (id == "ica")
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
                        else if (id == "coop")
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
                        else if (id == "cityGross")
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
                    
                    

                    }
                    else
                    {
                        if (id == "ica")
                        {
                            MethodInvoker inv4 = delegate
                            {
                                lblIcaStatus.Text = "Waiting";

                            };
                            Invoke(inv4);
                            buffer.ReleaseMutex();
                            Thread.Sleep(100);
                        }
                        else if (id == "coop")
                        {
                            MethodInvoker inv4 = delegate
                            {
                                lblCoopStatus.Text = "Waiting";

                            };
                            Invoke(inv4);
                            buffer.ReleaseMutex();
                            Thread.Sleep(100);
                        }
                        else if (id == "cityGross")
                        {
                            MethodInvoker inv4 = delegate
                            {
                                lblCityStatus.Text = "Waiting";

                            };
                            Invoke(inv4);
                            buffer.ReleaseMutex();
                            Thread.Sleep(100);
                        }

                       
                    }
                }
                if (continueIca && id == "ica")
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
                else if (id == "ica")
                {
                    semaphoreConsumer.Release();
                }
                continueIca = false;





                if (continueCoop && id == "coop")
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
                else if(id == "coop")
                {
                    semaphoreConsumer.Release();
                }
                continueCoop = false;

                if (continueCity && id == "cityGross")
                {
                    Thread.Sleep(2000);
                    MethodInvoker inv5 = delegate
                    {
                        lblCityStatus.Text = "Waiting";
                        cityGrossStorage.Clear();
                        lstCity.Items.Clear();
                    };
                    Invoke(inv5);

                    Thread.Sleep(3000);
                }
                else if (id == "cityGross")
                {
                    semaphoreConsumer.Release();
                }
                continueCity = false;


                

            }
            Thread.Sleep(2000);
            MethodInvoker inv6 = delegate
            {
                if (id == "ica")
                {
                    lblIcaStatus.Text = "Waiting";
                }
                else if (id == "coop")
                {
                    lblCoopStatus.Text = "Waiting";
                }
                else if (id == "cityGross")
                {
                    lblCityStatus.Text = "Waiting";
                }
               
                if (storage.Count > 0 && (tempMaxNumber <= currentItems ||
                    tempMaxWeight <= currentWeights + storage[storage.Count - 1].weight ||
                    tempMaxVol <= currentVolumes + storage[storage.Count - 1].volume))
                {
                    if (id == "ica")
                    {
                        icaStorage.Clear();
                        lstIca.Items.Clear();

                    }
                    else if (id == "coop")
                    {
                        coopStorage.Clear();
                        lstCoop.Items.Clear();
                    }
                    else if (id == "cityGross")
                    {
                        cityGrossStorage.Clear();
                        lstCity.Items.Clear();
                    }
                    
                }

            };
            Invoke(inv6);

            Thread.Sleep(3000);
        }

        




        /// <summary>
        /// Start scan producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            scan = true;
            threadScan = new Thread(() => Produce(scan, "scan"));
            threadScan.Start();
           
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
            arla = true;
            threadArla = new Thread(() => Produce(arla, "arla"));
            threadArla.Start();
          
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
            axFood = true;
            threadAxFood = new Thread(() => Produce(axFood, "axFood"));
            threadAxFood.Start();
            
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
            ica = true;
            threadICA = new Thread(() => TakeFromStorage(ica, "ica"));
            threadICA.Start();
            
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
            btnStartIca.Enabled = true;
            btnStopIca.Enabled = false;
        }

        /// <summary>
        /// Start Coop consumer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCoop_Click(object sender, EventArgs e)
        {
            coop = true;
            threadCOOP = new Thread(() => TakeFromStorage(coop, "coop"));
            threadCOOP.Start();
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
            cityGross = true;
            threadCityGross = new Thread(() => TakeFromStorage(cityGross, "cityGross"));
            threadCityGross.Start();
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
