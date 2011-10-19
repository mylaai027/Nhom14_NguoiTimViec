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
      
        private void NetTCPBinding_Click(object sender, EventArgs e)
        {
           
            
                EndpointAddress address = new EndpointAddress(new Uri("net.tcp://localhost:8000/NetTCPBinding"));
                ChannelFactory<ITimviec> channel = new ChannelFactory<ITimviec>(new NetTcpBinding(), address);
                timviec = channel.CreateChannel();
                nhom.Text = timviec.GetAuthors();
                Detai.Text = timviec.Detai();
            
           
        }
        private void WSHttpBinding_Click(object sender, EventArgs e)
        {
            
            EndpointAddress address1 = new EndpointAddress(new Uri("http://localhost:8000/WSHttpBinding"));

            ChannelFactory<ITimviec> channel1 = new ChannelFactory<ITimviec>(new WSHttpBinding(), address1);


            timviec1 = channel1.CreateChannel();


            nhom.Text = timviec1.GetAuthors();
            Detai.Text = timviec1.Detai();
        }

        private void BasicHttpBinding_Click(object sender, EventArgs e)
        {

            EndpointAddress address2 = new EndpointAddress(new Uri("http://localhost:8000/BasicHttpBinding"));

            ChannelFactory<ITimviec> channel2 = new ChannelFactory<ITimviec>(new BasicHttpBinding(), address2);


            timviec = channel2.CreateChannel();


            nhom.Text = timviec.GetAuthors();
            Detai.Text = timviec.Detai();
        }
    
    
    }


}
