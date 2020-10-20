using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinYiHelp.SocketHelp;
using System.Net;
using JinYiHelp.StringHelp;
using System.Net.Sockets;
using System.Threading;
using JinYiHelp.CodingHelp;

namespace JYKJDome
{
    public partial class Form_SocketClient : Form
    {
        public Form_SocketClient()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
        }
        SynchronizationContext _syncContext;
        Socket _client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            try
            {
              
                //IPAddress address = IPAddress.Parse(txtIP.Text);
                int port = txtPort.Text.ToInt32();

                _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _client.Connect(txtIP.Text, port);

                _client.SendVarData("hi server");

                


                Task task = new Task(() => AcceptInvoke());

                task.Start();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           string msg= Guid.NewGuid().ToString();
            _client.SendVarData(msg);
        }

        private void Form_SocketClient_Load(object sender, EventArgs e)
        {

        }


        private void AcceptMsg(object obj)
        {
            infolist.Items.Add(obj.ToString());
        }

        private void AcceptInvoke()
        {

            while (true)
            {
                string msg;
                try
                {
                    byte[] bin = _client.ReceiveVarData();
                     msg = CodingHelper.ByteToString(bin);
                }catch(Exception ex)
                {
                    msg = ex.Message;
                    break;
                }

               

                _syncContext.Post(AcceptMsg, msg);

              
            }

        }

        private void btnSendThis_Click(object sender, EventArgs e)
        {
            string msg = txtThis.Text;
            _client.SendVarData(msg);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _client.Shutdown(SocketShutdown.Both);
            _client.Close();
        }
    }
}
