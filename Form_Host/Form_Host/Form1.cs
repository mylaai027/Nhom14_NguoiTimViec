using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration.Install;
using System.ServiceProcess;



namespace Form_Host
{
    public partial class Form1 : Form
    {
        bool StartServer = false;
        ServiceHost myservice = null;
        ServiceMetadataBehavior behavior;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {


            if (!StartServer)
            {
                Uri baseAddress;


                try
                {

                    // =====================Kiểu Binding NetTCPBinding ====================================
                    if (cb_EndPoints1.Checked == true)
                    {
                        baseAddress = new Uri("net.tcp://" + baseaddress.Text + "/" + tb_NetTCPBinding.Text);
                        // baseAddress = new Uri("net.tcp://localhost:8000/NetTcpBinding");
                        myservice = new ServiceHost(typeof(Timviec), baseAddress);
                        myservice.AddServiceEndpoint(typeof(ITimviec), new NetTcpBinding(), baseAddress);
                        if (mex.Checked == false)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myservice.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myservice.AddServiceEndpoint(typeof(IMetadataExchange), new NetTcpBinding(), "hehe");

                        }
                        tb.Text = "da ket noi kieu TcpBinding";
                    }
                    //=============kieu WsHTTP ==========================================
                    if (cb_Endpoint2.Checked == true)
                    {
                        //EndpointAddress baseAddress1 = new EndpointAddress("http://localhost:8000/WSHttpBinding()");
                        baseAddress = new Uri("http://" + baseaddress.Text + "/" + tb_WSHttpBinding.Text);
                        //baseAddress = new Uri("http://localhost:8000/WSHttpBinding");
                        myservice = new ServiceHost(typeof(Timviec), baseAddress);
                        myservice.AddServiceEndpoint(typeof(ITimviec), new WSHttpBinding(), baseAddress);

                        if (mex.Checked == false)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myservice.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myservice.AddServiceEndpoint(typeof(IMetadataExchange), new NetTcpBinding(), "hihi");

                        }
                        tb.Text = "da ket noi kieu WSHttpBinding";
                    }
                      ///============Kiểu BasicHttpBinding=======================//
                    if (cb_Endpoint3.Checked == true)
                    {

                        baseAddress = new Uri("http://" + baseaddress.Text + "/" + tb_BasicHttpBinding.Text);

                        myservice = new ServiceHost(typeof(Timviec), baseAddress);
                        myservice.AddServiceEndpoint(typeof(ITimviec), new BasicHttpBinding(), baseAddress);

                        if (mex.Checked == false)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myservice.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myservice.AddServiceEndpoint(typeof(IMetadataExchange), new NetTcpBinding(), "haha");

                        }
                        tb.Text = "da ket noi kieu BasicHttpBinding";
                    }



                    myservice.Open();
                    StartServer = true;
                    bt_stop.Enabled = true;
                    bt_start.Enabled = false;
                }
                    catch (Exception hi)
                    {
                        batloi.Text = "Bạn chưa chọn kiểu EndPoint nào";

                    }
                }
            
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            myservice.Close();
            StartServer = false;
            bt_stop.Enabled = false;
            bt_start.Enabled = true;
            tb.Text = "Da Ngat Ket Noi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_stop.Enabled = false;
        }
       

    }
}
