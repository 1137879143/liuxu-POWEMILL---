using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinYiHelp.CodingHelp;
using JinYiHelp.SocketHelp;

namespace JYKJDome
{
    public partial class Form_SocketServer : Form
    {
        public Form_SocketServer()
        {
            InitializeComponent();
            _synckContent = SynchronizationContext.Current;
            CheckForIllegalCrossThreadCalls = false;
        }
        SynchronizationContext _synckContent = null;
        Socket _server;
        List<Socket> list = new List<Socket>();

        private void Form_SocketServer_Load(object sender, EventArgs e)
        {
            
        }

        private void AcceptMsg(object obj)
        {
            lb_ServerInfo.Items.Add(obj.ToString());
        }

        /// <summary>
        /// 接收客户端 连接的
        /// </summary>
        private void AcceptInvoke()
        {
            while (true)
            {
                var client = _server.Accept();
                lock (this)
                {
                    list.Add(client);
                    labClientCount.Text = list.Count.ToString();
                }
               
                

                Task task = new Task(() => Rec(client));
                task.Start();
                Thread.Sleep(200);
            }
            
        }

        private void Rec(Socket s)
        {
            while (true)
            {

                string msg;
                try
                {
                    byte[] bin = s.ReceiveVarData();
                    msg = CodingHelper.ByteToString(bin);

                    s.SendVarData("服务器发送的:" + msg);
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    lock (this)
                    {
                        list.Remove(s);
                        labClientCount.Text = list.Count.ToString();
                    }
                   

                    break;
                }


                Console.WriteLine("服务器:" + msg);
                _synckContent.Post(AcceptMsg, msg);


             
            }
        }


        private void bn_Start_Click(object sender, EventArgs e)
        {
            bn_Start.Enabled = false;
            try
            {
                IPAddress address = IPAddress.Any;
                IPEndPoint ip = new IPEndPoint(address,5200);
                _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                _server.Bind(ip);
                _server.Listen(100);

               

                Task task = new Task(() => AcceptInvoke());
                task.Start();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }

        private void but_newClient_Click(object sender, EventArgs e)
        {
            new Form_SocketClient().Show();
        }

        private void btnSendto_Click(object sender, EventArgs e)
        {

        }

        private void bn_Resume_Click(object sender, EventArgs e)
        {
            string msg = DateTime.Now.ToString();
            foreach (var item in list)
            {
                
                item.SendVarData("服务器随机消息:"+msg);
            }
        }

        private void bn_Stop_Click(object sender, EventArgs e)
        {
            _server.Shutdown(SocketShutdown.Both);
            _server.Close();
        }
    }
}
