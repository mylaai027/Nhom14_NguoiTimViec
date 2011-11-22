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
using System.Threading;
using Form_Host;


namespace Form_Client
{
    public partial class Form1 : Form
    {
        ITimviec timviec = null;
        ITimviec timviec1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }
        #region WSMethod
        void functionGetAuthorCallBack(Object sender, ServiceReference_WSHttp.GetAuthorsCompletedEventArgs e)
        {
            nhom.Text = e.Result;
            loi.Text = "Da chay xong GetAuthor";
        }
        void functionDeTaiCallBack(Object sender, ServiceReference_WSHttp.DetaiCompletedEventArgs e)
        {
            Detai.Text = e.Result;
            loi.Text = "Da chay xong DeTai";
        }
        #endregion
        #region BasicMethod
        void functionGetAuthor_Basic_CallBack(Object sender, ServiceReference_BasicHttp.GetAuthorsCompletedEventArgs e)
        {
            nhom.Text = e.Result;
            loi.Text = "Da chay xong GetAuthor";
        }
        void functionDeTai_Basic_CallBack(Object sender, ServiceReference_BasicHttp.DetaiCompletedEventArgs e)
        {
            Detai.Text = e.Result;
            loi.Text = "Da chay xong DeTai";
        }
        #endregion
        private void NetTCPBinding_Click(object sender, EventArgs e)
        {
                EndpointAddress address = new EndpointAddress(new Uri("net.tcp://localhost:8000/NetTCPBinding"));
                ChannelFactory<ITimviec> channel = new ChannelFactory<ITimviec>(new NetTcpBinding(), address);
                timviec1 = channel.CreateChannel();
                

        }
        private void WSHttpBinding_Click(object sender, EventArgs e)
        {
            
            EndpointAddress address1 = new EndpointAddress(new Uri("http://localhost:8000/WSHttpBinding"));
            ChannelFactory<ITimviec> channel1 = new ChannelFactory<ITimviec>(new WSHttpBinding(), address1);
            timviec1 = channel1.CreateChannel();
            try
            {
                ServiceReference_WSHttp.TimviecClient proxy = new ServiceReference_WSHttp.TimviecClient();
                proxy.GetAuthorsCompleted += new EventHandler<ServiceReference_WSHttp.GetAuthorsCompletedEventArgs>(functionGetAuthorCallBack);
                proxy.GetAuthorsAsync();
                proxy.DetaiCompleted += new EventHandler<ServiceReference_WSHttp.DetaiCompletedEventArgs>(functionDeTaiCallBack);
                proxy.DetaiAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BasicHttpBinding_Click(object sender, EventArgs e)
        {

            EndpointAddress address2 = new EndpointAddress(new Uri("http://localhost:8000/BasicHttpBinding"));
            ChannelFactory<ITimviec> channel2 = new ChannelFactory<ITimviec>(new BasicHttpBinding(), address2);
            timviec = channel2.CreateChannel();
            try
            {
                ServiceReference_BasicHttp.TimviecClient proxy = new ServiceReference_BasicHttp.TimviecClient();
                proxy.GetAuthorsCompleted += new EventHandler<ServiceReference_BasicHttp.GetAuthorsCompletedEventArgs>(functionGetAuthor_Basic_CallBack);
                proxy.GetAuthorsAsync();
                proxy.DetaiCompleted += new EventHandler<ServiceReference_BasicHttp.DetaiCompletedEventArgs>(functionDeTai_Basic_CallBack);
                proxy.DetaiAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}
