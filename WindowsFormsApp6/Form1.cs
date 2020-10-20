using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using JinYiHelp.IniHelp;
using pmclass;
using jy = JinYiHelp.StringHelp;
using PM = PowerSolutionDOTNetOLE.clsPowerMILLOLE;
using PMINI = PowerSolutionDOTNetOLE.clsIniFile;
using PMPOINT = PowerSolutionDOTNetOLE.clsPoint3D;
using PMFILE = PowerSolutionDOTNetOLE.clsFileFunctions;

namespace WindowsFormsApp6
{

    public partial class Form1 : Form
    {
        public string pftf = AppDomain.CurrentDomain.BaseDirectory;       //文件运行目录

        Pmmclass pma = new Pmmclass();
        

        public Form1()
        {
            InitializeComponent();



        }



        void DrawImg()

        {
           
            Graphics g = panel1.CreateGraphics();
            g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
            this.AutoScrollMinSize = new Size(800, 600);

            //开头写好以后下面就是你要的逻辑了想画什么就画什么只要不传播少儿不宜的就没事哈哈哈开个玩笑


            this.AutoScrollMinSize = new Size(800, 600); //这句话的意思是当窗口小于宽800高600的时候就会出现滚动条
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }



        private void comboBox1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string[] kaicu = { "偏置区域清除", "偏置区域二粗", "偏置平坦区域", "平行区域清除", "平行区域二粗", "平行平坦区域", "等高", "试料", "面铣削", "打中心点", "钻孔加工", "全自动钻孔", "外形侧光", "模型轮廓", "倒角", "插铣" };

        //初始化
        public void morenqidong()
        {
            string[] qieruqiechu = { @"区域清除\浅滩和陡峭內定", "曲面法向-曲面法向-圆形圆弧",
                "水平圆弧90度-圆形圆弧","水平圆弧-水平圆弧-水平圆弧",
                "无-无-全高度","无-无-掠过","无-圆形圆弧",
                "无-无-在曲面上","斜向-螺旋下刀",
                "斜向-螺旋下刀-刻字用","斜向-水平圆弧-圆形圆弧",
                "斜向-无-圆形圆弧","延伸斜向-延伸-圆形圆弧",
                "延伸-延伸-短连接直",
            };


            comboBox_切入切出.Items.Clear();
            comboBox_切入切出.Items.AddRange(qieruqiechu);
            this.comboBox_切入切出.SelectedIndex = 0;
            // this.comboBox_坐标系.SelectedIndex = 0;
            this.comboBox_点分布.SelectedIndex = 0;
            this.comboBox_计算前宏.SelectedIndex = 0;
            this.comboBox7_计算后宏.SelectedIndex = 0;
            this.comboBox_切削方向.SelectedIndex = 0;
            this.comboBox_加工顺序.SelectedIndex = 0;
            this.comboBox_轮廓方向.SelectedIndex = 0;
            this.comboBox_平坦区域.SelectedIndex = 0;
            this.comboBox_连接.SelectedIndex = 0;
            //  this.comboBox_刀具.SelectedIndex = 0;
            this.comboBox_边界.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //测试按钮


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        string 状态名称;
        //开粗被选中
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                状态名称 = "开粗";
                comboBox_策略.Items.Clear();
                comboBox_策略.Items.AddRange(kaicu);
                comboBox_策略.SelectedIndex = 0;
            }

        }
        //创建文件夹被点击
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox_策略.Text == "" || comboBox_刀具.Text == "")
            {
                MessageBox.Show("未选择策略或者刀具");
                return;
            }

            string pthfname;
            int id = treeView1.Nodes[4].GetNodeCount(false);
            id += 1;
            pthfname = id + "_" + comboBox_刀具.Text + "_";
            //创建新的节点
            TreeNode pthftmp = new TreeNode(pthfname);
            treeView1.Nodes[4].Nodes.Add(pthftmp);

            treeView1.SelectedNode = pthftmp;//选中刚才创建的节点

            //将创建的节点图标选中与非选中 改为一样
            treeView1.SelectedNode.ImageIndex = 1;
            treeView1.SelectedNode.SelectedImageIndex = 1;
            //展开所以节点
            treeView1.ExpandAll();

            //创建新的子节点在上一节点之下
            string name = pthfname + 状态名称 + "-" + comboBox_策略.Text;
            TreeNode tmp = new TreeNode(name);
            //在TreeView组件中加入子节点
            treeView1.SelectedNode.Nodes.Add(tmp);
            treeView1.SelectedNode = tmp;//选择最新创建的节点
            treeView1.Select();//激活控件用以显示

            treeView1.ExpandAll();//展开所有节点



        }
        //中光被选中
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                状态名称 = "中光";
            }

        }
        //精光被选中
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                状态名称 = "精光";
            }
        }


        //获取当前pm激活的坐标系


        //获取所有坐标
        void getzuobiao()
        {
            //获取所有的坐标
            int num = 1;
            string[] zb = new string[100];
            int id = 1;
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmWorkplane, ref num, ref zb, ref id);
            comboBox_坐标系.Items.Clear();
            if (zb != null)
            {
                comboBox_坐标系.Items.AddRange(zb);
            }


            //获取激活的坐标
            string zuobiao = PM.GetActiveEntityName(PM.enumPowerMILLEntityType.pmWorkplane);
            //写进框框内
            comboBox_坐标系.Text = zuobiao;

        }

        /// <summary>
        /// 激活坐标
        /// </summary>
        /// <param name="开关"></param>
        void 坐标_激活(string name)
        {
            PM.Execute("ACTIVATE Workplane " + name);
        }

        //错误与警告的开与关
        void message(bool 开关)
        {
            string KG;
            if (开关)
            {
                KG = " ON";
            }
            else
            {
                KG = " OFF";
            }


            PM.Execute("DIALOGS MESSAGE " + KG);
            PM.Execute("DIALOGS SMILEY " + KG);


        }



        //读取按钮被点击
        private void button_读取_Click(object sender, EventArgs e)
        {
            //读取pm中的刀具
            comboBox_刀具.Items.Clear();
            string[] ttoolname = readtoolname();
            if (ttoolname != null)
            {
                comboBox_刀具.Items.AddRange(ttoolname);
                comboBox_刀具.SelectedIndex = 0;
            }


            //获取坐标
            getzuobiao();


            //先全部清空
            int aa = treeView1.Nodes[4].GetNodeCount(false);
            for (int i = 0; i < aa; i++)
            {
                treeView1.Nodes[4].NextVisibleNode.Remove();
            }
            string[] toolpath = Readtoolpath();
            if (toolpath == null)
            {
                return;
            }
            foreach (var item in toolpath)
            {
                TreeNode bb = new TreeNode(item);
                treeView1.Nodes[4].Nodes.Add(bb);
            }
            //展开所有节点
            treeView1.ExpandAll();


        }
        //打印输出
        void print(string aa)
        {
            System.Diagnostics.Debug.WriteLine(aa);
        }

        //函数 读取PM中的所有刀具路径
        string[] Readtoolpath()
        {
            int aa = 1;
            int id = 1;
            string[] toolpath = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmToolpath, ref aa, ref toolpath, ref id);
            return toolpath;
        }

        //获取残留模型
        string[] ReadStockModel()
        {
            int aa = 0;
            int id = 0;
            string[] StockModel = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmStockModel, ref aa, ref StockModel, ref id);
            return StockModel;
        }


        //获取孔特征集
        string[] ReadFeatureset()
        {
            int aa = 0;
            int id = 0;
            string[] Featureset = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmFeatureSet, ref aa, ref Featureset, ref id);
            return Featureset;
        }

        //获取工作平面
        string[] ReadWorkplane()
        {
            int num = 1;
            string[] Workplane = new string[100];
            int id = 1;
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmWorkplane, ref num, ref Workplane, ref id);
            return Workplane;
        }

        //获取模型
        string[] ReadModel()
        {
            int num = 1;
            string[] Model = new string[100];
            int id = 1;
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmModel, ref num, ref Model, ref id);

            return Model;
        }

        //函数 层 组合和夹持
        string[] readLevel()
        {
            int num = 1;
            int id = 1;
            string[] readLevel = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmLevel, ref num, ref readLevel, ref id);
            return readLevel;
        }

        // 函数 获取边界
        string[] readBoundary()
        {
            int num = 1;
            int id = 1;
            string[] readBoundary = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmBoundary, ref num, ref readBoundary, ref id);
            return readBoundary;
        }
        // 函数 获取参考线
        string[] readreferenceline()
        {
            int num = 1;
            int id = 1;
            string[] referenceline = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmPattern, ref num, ref referenceline, ref id);
            return referenceline;
        }

        //-----------------------------------------------------------------------------------

        //函数 获取所有刀具名称
        string[] readtoolname()
        {
            int num = 1;
            int id = 1;
            string[] toolname = new string[1000];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmTool, ref num, ref toolname, ref id);

            return toolname;
        }

        //函数 获取刀具详细参数
        string[] toolinformation(string toolname)
        {
            string[] testtoolname = PM.GetEntityParameterInfo(PM.enumPowerMILLEntityType.pmTool, toolname);
            return testtoolname;
        }

        //函数 获取某个刀具路径的详细信息
        string[] Toolinformation(string toolpath)
        {
            //获取某个刀具路径的详细信息
            string[] aa = PM.GetEntityParameterInfo(PM.enumPowerMILLEntityType.pmToolpath, toolpath);
            return aa;
        }

        /// <summary>
        ///  取消边界激活
        /// </summary>
        void 边界_取消激活()
        {
            //  PM.Execute("DEACTIVATE Boundary");


        }

        //测试按钮
        private void button9_Click(object sender, EventArgs e)
        {
            // Toolinformation();
            /**
            string[] aa = ReadModel();

            foreach (var item in aa)
            {
                print(item);
            }*/

            pma.show();


        }

        //切换图片
        private void comboBox_策略_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(pftf + @"image\" + comboBox_策略.Text + ".png");
        }

        private void checkBox_残留加工_CheckedChanged(object sender, EventArgs e)
        {

            comboBox_参考类型.Enabled = checkBox_残留加工.Checked;
            comboBox_上一刀路.Enabled = checkBox_残留加工.Checked;
            textBox_检测厚于.Enabled = checkBox_残留加工.Checked;
            textBox_扩展.Enabled = checkBox_残留加工.Checked;
            checkBox_自动优化.Enabled = checkBox_残留加工.Checked;

        }

        /// <summary>
        /// 预览毛坯
        /// </summary>
        /// <param name="XY偏置"></param>
        /// <param name="正Z偏置"></param>
        /// <param name="负Z偏置"></param>
        void 预览毛坯(string XY偏置, string 正Z偏置, string 负Z偏置)
        {
            // PM.Execute("FORM BLOCK");//设置为工作坐标系
            //  PM.Execute("EDIT BLOCK COORDINATE WORKPLANE");//设置为工作坐标系
            PM.Execute("edit block reset");//计算已选面毛坯 textBox_XY偏置
            PM.Execute("draw block");//显示毛坯

            ArrayList size = 获取毛坯大小();
            if (size.Count > 0)
            {
                PM.Execute("EDIT BLOCK XMIN " + "'" + size[6] + "+-" + XY偏置 + "'");//xmin
                PM.Execute("EDIT BLOCK xmax " + "'" + size[7] + "+" + XY偏置 + "'");//xmax
                PM.Execute("EDIT BLOCK ymin " + "'" + size[8] + "+-" + XY偏置 + "'");//ymin
                PM.Execute("EDIT BLOCK ymax " + "'" + size[9] + "+" + XY偏置 + "'");//ymax

                PM.Execute("EDIT BLOCK zmin " + "'" + size[10] + "+-" + 负Z偏置 + "'");//zmin正Z偏置
                PM.Execute("EDIT BLOCK zmax " + "'" + size[11] + "+" + 正Z偏置 + "'");//zmax

            }

        }

        /// <summary>
        /// 获取毛坯大小  从第6个数开始为XMIN, Xmax , Ymin  ,Ymax  , Zmin,Zmax
        /// </summary>
        /// <param name="name"></param>
        ArrayList 获取毛坯大小()
        {
            string blocksize = PM.ExecuteEx("size block");
            ArrayList size = new ArrayList();
            if (blocksize == "")
            {
                MessageBox.Show("当前无毛坯");
                return size;
            }

            string[] aa = blocksize.Split();

            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = aa[i].Replace(" ", "");
                //aa[i] = aa[i].Replace("+", "");
                //  aa[i] = aa[i].Replace("-", "");
            }
            for (int i = 0; i < aa.Length; i++)
            {
                if (aa[i] != "")
                {
                    // Console.WriteLine("第" + i.ToString() + aa[i]);
                    size.Add(aa[i]);
                }
            }
            return size;

            //  Console.WriteLine(size.Count);
        }


        void 创建已选曲面边界(string name)
        {


            PM.Execute("CREATE BOUNDARY  " + name + " SELECTED FORM BOUNDARY");//边界类型

            if (checkBox_顶部.Checked)
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELVERTICAL UP");//顶部勾选
            }
            else
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELVERTICAL down");//顶部不勾选
            }
            if (checkBox浮动.Checked)
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELROLLOVER ON");//浮动开
            }
            else
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELROLLOVER off");//浮动关
            }

            PM.Execute("EDIT BOUNDARY " + name + " TOLERANCE " + textBox_公差.Text);//公差
            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS '0.00'");//余量
            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS AXIAL_RADIAL OFF");//轴向余量关
            PM.Execute("EDIT BOUNDARY " + name + " TOOL NAME " + comboBox_刀具.Text);//更换刀具
            PM.Execute("EDIT BOUNDARY " + name + " CALCULATE");//计算
            PM.Execute("EDIT BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT");//接受

        }

        void 创建浅滩边界(string name, string 上限角, string 下限角, string 公差, string 径向余量, string 轴向余量, bool 使用轴向余量, string 刀具名称)
        {

            PM.Execute("CREATE BOUNDARY " + name + " SHALLOW FORM BOUNDARY");//边界类型

            PM.Execute("EDIT BOUNDARY " + name + " SLOPE " + 上限角);//
            PM.Execute("EDIT BOUNDARY " + name + " SET_LOWER_ANGLE " + 下限角);//

            PM.Execute("EDIT BOUNDARY " + name + " TOLERANCE  " + 公差);//

            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS   " + 径向余量);//

            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS AXIAL   " + 轴向余量);//

            string 局_使用轴向余量;
            if (使用轴向余量)
            {
                局_使用轴向余量 = " ON";
            }
            else
            {
                局_使用轴向余量 = " OFF";
            }

            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS AXIAL_RADIAL   " + 局_使用轴向余量);//

            PM.Execute("EDIT BOUNDARY " + name + " TOOL NAME   " + 刀具名称);//
            PM.Execute("EDIT BOUNDARY " + name + " CALCULATE");//计算

            PM.Execute("EDIT BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT  ");//接受

        }

        void 创建接触点边界(string name, string 模型公差, string 边缘公差)
        {

            PM.Execute("CREATE BOUNDARY " + name + " CONTACTPOINT FORM BOUNDARY");//边界类型
            PM.Execute("EDIT BOUNDARY " + name + " TOLERANCE  " + 模型公差);//模型公差
            PM.Execute("EDIT BOUNDARY " + name + " EDGE_TOLERANCE  " + 边缘公差);//边缘公差
            PM.Execute("EDIT BOUNDARY " + name + " INSERT MODEL  ");//插入已选模型
            PM.Execute("EDIT BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT  ");//接受


        }
        void 创建毛呸边界(string name)
        {


            PM.Execute("CREATE BOUNDARY " + name + " BLOCK FORM BOUNDARY");//边界类型
            PM.Execute("EDIT  BOUNDARY " + name + " CALCULATE");//计算
            PM.Execute("EDIT  BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT");//接受

        }




        //计算边界被点击
        private void button_计算边界_Click_1(object sender, EventArgs e)
        {

            message(false);
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("当前无创建刀具路径,无法确定创建类型,请点击刀路或文件夹创建新的刀具路径");
                return;
            }

            string name = treeView1.SelectedNode.Text + "_" + comboBox_边界.Text;//树中已选定的名字

            while (边界是否存在(name))
            {
                name += "_1";
            }

            if (comboBox_边界.Text == "已选曲面边界")
            {
                创建已选曲面边界(name);

            }
            if (comboBox_边界.Text == "浅滩边界")
            {
                创建浅滩边界(name, "45", "0", "0.0254", "0", "0", true, comboBox_刀具.Text);
            }
            if (comboBox_边界.Text == "毛坯边界")
            {
                创建毛呸边界(name);
            }
            if (comboBox_边界.Text == "接触点边界")
            {
                创建接触点边界(name, "0.0254", "0.0254");
            }

            message(true);

        }





        /// <summary>
        /// 边界名称如果存在返回true,不存在返回false;
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool 边界是否存在(string name)
        {
            string[] aa = readBoundary();
            if (aa == null)
            {
                return false;
            }

            foreach (var item in aa)
            {
                if (item == name)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 计算刀具路径名称是否已经存在,如果存在返回true 不存在返回fales
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool 刀具路径是否存在(string name)
        {
            string[] toolpathname = Readtoolpath();
            if (toolpathname == null)
            {
                return false;
            }


            foreach (var item in toolpathname)
            {
                if (item == name)
                {
                    return true;
                }
            }
            return false;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "按偏置量")
            {
                预览毛坯(textBox_XY偏置.Text, textBox_Z正偏置.Text, textBox_Z负偏置.Text);
            }

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            textBox_公差.Enabled = checkBox15.Checked;


        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = checkBox16.Checked;
        }

        private void comboBox_刀具_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toolname = comboBox_刀具.Text;


            if (treeView1.SelectedNode != null)
            {
                string treename = treeView1.SelectedNode.Text;
                if (treename != "")
                {
                    string oldname = jy.StringHelper.Between(treename, "_", "_");
                    if (oldname != null && toolname != "")
                    {
                        string newname = treename.Replace(oldname, toolname);

                        treeView1.SelectedNode.Text = newname;
                    }

                }



            }
        }
        //计算当前被点击
        private void 计算当前()
        {
            //取被选中的加工类型 加工刀具 
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("你要计算哪个?");
                return;
            }

            string name = treeView1.SelectedNode.Text;
            string nametype = comboBox_策略.Text;

            PM.DialogsOff();
            if (nametype == "偏置区域清除")
            {
                创建偏置区域清除刀路();
            }

            PM.DialogsOn();
        }

        private void 创建偏置区域清除刀路()
        {
            string toolpathname = treeView1.SelectedNode.Text;
            //判断刀具路径名称是否已存在,如存在就激活它 重新计算;
            if (!刀具路径是否存在(toolpathname))
            {
                PM.Execute("IMPORT TEMPLATE ENTITY TOOLPATH TMPLTSELECTORGUI  3D-Area-Clearance/Model-Area-Clearance.003.ptf");
                PM.Execute("RENAME TOOLPATH 1 " + toolpathname);//改名字
            }
            else
            {
                PM.Execute("ACTIVATE TOOLPATH " + toolpathname + " FORM TOOLPATH");
            }


            if (comboBox_坐标系.Text != "")
            {
                PM.Execute("ACTIVATE WORKPLANE " + comboBox_坐标系.Text);//改坐标
            }

            if (comboBox_边界.Text == "无")
            {
                边界_取消激活();//ACTIVATE BOUNDARY " "

                PM.Execute(" ACTIVATE BOUNDARY '' ");//改坐标


            }//改边界

            //重新计算毛坯
            if (comboBox1.Text == "按偏置量")
            {
                预览毛坯(textBox_XY偏置.Text, textBox_Z正偏置.Text, textBox_Z负偏置.Text);
            }




            PM.Execute(" ACTIVATE TOOL " + comboBox_刀具.Text);//改刀具
            编辑轮廓切削方向(comboBox_轮廓方向.SelectedIndex);       //改轮廓方向
            编辑区域切削方向(comboBox_切削方向.SelectedIndex);//改切削方向;

            PM.Execute("EDIT PAR Tolerance " + textBox3.Text);//改公差
            PM.Execute("EDIT PAR Thickness " + textBox1.Text);//改侧面余量;
            PM.Execute("EDIT PAR AxialThickness  " + textBox2.Text);//改底面余量;

            编辑允许毛坯外(checkBox_允许毛坯外.Checked);//改允许毛坯外;
            编辑裁剪(checkBox边界内部.Checked);//改边界内部或者外部;
            编辑不安全段删除(checkBox8.Checked, checkBox12.Checked, textBox6.Text);
            if (!编辑平坦面加工(comboBox_平坦区域.Text))
            {
                编辑平坦面加工("区域");//修改平坦区域方式
            }
            编辑连接(comboBox_连接.Text); //连接
            轮廓光顺(checkBox6.Checked, textBox4.Text);//光顺
            光顺余量(checkBox7.Checked, textBox5.Text);//光顺余量
            增加从外侧进刀(checkBox9.Checked);
            保持保持切削方向(checkBox11.Checked);
            编辑加工方向(comboBox_加工顺序.Text);


            ///还是接着这里写 2020-7-17 17:58:56

            //差一些待会儿写 自动检查 步距 转速 进给  切入切出 不让他弹窗  // BATCH PROCESSING TOOLPATH +NAME 应该是进度条?
            PM.Execute("edit toolpath " + treeView1.SelectedNode.Text + " calculate ");//计算
            PM.Execute("FORM ACCEPT SFAreaClearance");//关闭计算窗口

        }

        /// <summary>
        /// 编辑加工方向 自动 由外向内 由内向外
        /// </summary>
        private void 编辑加工方向(string 加工顺序)
        {
            if (加工顺序 == "自动")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Order' 'automatic'");//自动

            }
            if (加工顺序 == "由外向内")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Order' 'outside_in'");//由外向内

            }
            if (加工顺序 == "由内向外")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Order' 'inside_out'");//由内向外

            }


        }

        /// <summary>
        /// 编辑保持保持切削方向
        /// </summary>
        /// <param name="保持切削方向"></param>
        private void 保持保持切削方向(bool 保持切削方向)
        {
            if (保持切削方向)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Preference' 'maintain_cut_dir'");

            }
            else
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Preference' 'minimise_air_moves'");

            }
        }

        /// <summary>
        /// 增加从外侧进刀
        /// </summary>
        private void 增加从外侧进刀(bool 增加)
        {
            if (增加)
            {
                PM.Execute("EDIT PAR 'AreaClearance.LeadIn.ApproachOutside' '1'");//打开
            }
            else
            {
                PM.Execute("EDIT PAR 'AreaClearance.LeadIn.ApproachOutside' '0'");//关闭
            }
        }


        /// <summary>
        /// 光顺余量--赛车线光顺
        /// </summary>
        private void 光顺余量(bool 光顺余量, string 光顺值)
        {
            if (光顺余量)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.SmoothingAllowance.Active' '1'");//打开光顺余量
                PM.Execute("EDIT PAR 'AreaClearance.Offset.SmoothingAllowance.Value' " + 光顺值);//设置光顺余量值

            }
            else
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.SmoothingAllowance.Active' '0'");//关闭光顺余量

            }
        }

        /// <summary>
        /// 轮廓光顺 
        /// </summary>
        private void 轮廓光顺(bool 轮廓光顺, string 光顺值)
        {
            if (轮廓光顺)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CornerRadius.Active' '1'");//轮廓光顺打开
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CornerRadius.Value' " + 光顺值);//设置光顺半径
            }
            else
            {
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CornerRadius.Active' '0'"); //轮廓光顺关闭
            }


            //  PM.Connect();
        }


        /// <summary>
        /// 编辑连接方式,直 光顺 无
        /// </summary>
        private void 编辑连接(string 连接方式)
        {
            if (连接方式 == "直")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Links' 'straight'");//直

            }
            if (连接方式 == "光顺")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Links' 'smooth'");//光顺

            }
            if (连接方式 == "无")
            {
                PM.Execute("EDIT PAR 'AreaClearance.Offset.Links' 'none'");//无

            }
        }

        /// <summary> 
        /// 编辑平坦面加工 区域 层 关
        /// 三种方式 区域 层 关 输入正确返回true,错误返回false 错误的话 默认为为区域
        /// </summary>
        private bool 编辑平坦面加工(string 平坦区域方式)
        {
            if (平坦区域方式 == "区域")
            {
                PM.Execute("EDIT PAR 'AreaClearance.ZHeights.Flats' 'area'");//区域
                return true;
            }
            if (平坦区域方式 == "层")
            {
                PM.Execute("EDIT PAR 'AreaClearance.ZHeights.Flats' 'off'");//层 
                return true;
            }
            if (平坦区域方式 == "关")
            {
                PM.Execute("EDIT PAR 'AreaClearance.ZHeights.Flats' 'level'");//关
                return true;
            }
            MessageBox.Show("平坦面加工方式选择错误,已修改为区域");
            return false;
        }

        /// <summary>
        /// 轮廓切削方向 0=顺铣 1=逆铣 2=任意
        /// </summary>
        /// <param name="方向"></param>

        private void 编辑轮廓切削方向(int 方向)
        {
            if (方向 == 0)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CutDirection' " + " 'climb'");
            }
            if (方向 == 1)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CutDirection' " + " 'conventional'");
            }
            if (方向 == 2)
            {
                PM.Execute("EDIT PAR 'AreaClearance.Profile.CutDirection' " + " 'any'");
            }


        }


        /// <summary>
        /// 区域切削方向 0=顺铣 1=逆铣 2=任意
        /// </summary>
        private void 编辑区域切削方向(int 方向)
        {
            if (方向 == 0)
            {
                PM.Execute("EDIT PAR 'CutDirection'  " + " 'climb'");
            }
            if (方向 == 1)
            {
                PM.Execute("EDIT PAR 'CutDirection'  " + " 'conventional'");
            }
            if (方向 == 2)
            {
                PM.Execute("EDIT PAR 'CutDirection'  " + " 'any'");
            }

        }

        /// <summary>
        /// 不安全段删除 true为打开,false为关闭,为false时 分界值无效
        /// </summary>
        /// <param name="yesorno"></param>
        private void 编辑不安全段删除(bool 区域过滤, bool 仅闭合区域, string 分界值)
        {
            if (区域过滤)
            {
                PM.Execute("EDIT PAR AreaClearance.Slicer.Filter.Active 1");
            }
            else
            {
                PM.Execute("EDIT PAR AreaClearance.Slicer.Filter.Active 0");

            }
            if (仅闭合区域)
            {
                PM.Execute("EDIT PAR AreaClearance.Slicer.Filter.EnclosedOnly  1");
            }
            else
            {
                PM.Execute("EDIT PAR AreaClearance.Slicer.Filter.EnclosedOnly  0");

            }

            PM.Execute("EDIT PAR AreaClearance.Slicer.Filter.Threshold  " + 分界值.ToString());


        }

        /// <summary>
        /// 编辑允许毛坯外
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 编辑允许毛坯外(bool 允许)
        {
            if (允许)
            {
                PM.Execute("EDIT PAR 'AllowToolOutsideBlock' '1'");
            }
            else
            {
                PM.Execute("EDIT PAR 'AllowToolOutsideBlock' '0'");

            }
        }

        /// <summary>
        /// 为true 保留内部 false保留外部
        /// </summary>
        /// <param name="保留内部"></param>
        private void 编辑裁剪(bool 保留内部)
        {
            if (保留内部)
            {
                PM.Execute("EDIT PAR 'BoundaryLimit.Keep' 'inside'");
            }
            else
            {
                PM.Execute("EDIT PAR 'BoundaryLimit.Keep' 'outside'");

            }
        }


        private void comboBox_边界_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_边界.Text == "无")
            {

                comboBox_已有边界.Enabled = false;
                checkBox边界内部.Enabled = false;
                checkBox15.Enabled = false;
                textBox_公差.Enabled = false;
                checkBox16.Enabled = false;
                checkBox_顶部.Enabled = false;
                checkBox浮动.Enabled = false;
                textBox8.Enabled = false;

                边界_取消激活();
            }
            else if (comboBox_边界.Text == "已有边界")
            {
                comboBox_已有边界.Enabled = true;
                string[] allboundary = readBoundary();
                comboBox_已有边界.Items.Clear();
                if (allboundary != null)
                {
                    comboBox_已有边界.Items.AddRange(allboundary);

                }


            }
            else
            {
                comboBox_已有边界.Enabled = false;
                checkBox边界内部.Enabled = true;
                checkBox15.Enabled = true;
                textBox_公差.Enabled = true;
                checkBox16.Enabled = true;
                checkBox_顶部.Enabled = true;
                checkBox浮动.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void comboBox_已有边界_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_已有边界.SelectedItem != null)
            {
                激活边界(comboBox_已有边界.Text);
            }
        }

        void 激活边界(string name)
        {
            PM.Execute("ACTIVATE Boundary " + name);
        }

        /// <summary>
        /// 选择坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_坐标系_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_坐标系.Text != null)
            {
                坐标_激活(comboBox_坐标系.Text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (PM.Connect() == false)
            {
                //  MessageBox.Show("powermill连接失败,重新建立链接!");
                this.Text = "第一次链接pm失败";
                if (PM.ConnectToNew())
                {
                    this.Text = "第二次链接pm成功";

                }
                else
                {
                    this.Text = "第二次链接pm失败";
                }
                //  this.Close();
                //  return;
            }
            else
            {
                this.Text = "第一次链接pm成功";
            }




            morenqidong();//软件启动后设置默认项;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawImg();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button_计算当前_Click(object sender, EventArgs e)
        {
            计算当前();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            连接pm();
        }

        private void 连接pm()
        {
            if (PM.Connect() == false)
            {
                //  MessageBox.Show("powermill连接失败,重新建立链接!");
                this.Text = "链接pm失败";
                if (PM.ConnectToNew())
                {
                    this.Text = "链接pm成功";
                }
                else
                {
                    this.Text = "链接pm失败";
                }
                //  this.Close();
                //  return;
            }
            else
            {
                this.Text = "链接pm成功";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            创建刀具(comboBox_刀具.Text);
        }
        string type;
        string D;
        private void 创建刀具(string name)
        {

            if (name.Contains("D"))//说明是平底刀ENDMILL
            {
                type = " ENDMILL ";
                D = jy.StringHelper.GetRight(name, "D", false);


                PM.Execute("CREATE TOOL " + name + type);

                PM.Execute(" EDIT TOOL  " + name + " DIAMETER " + D);
            }
            else if (name.Contains("B"))//说明是圆笔刀 TIPRADIUSED  
            {
                type = " TIPRADIUSED   ";

            }
            else if (name.Contains("R"))//说明是球刀BALLNOSED
            {
                type = " BALLNOSED ";

            }





        }

        private void label28_Click(object sender, EventArgs e)
        {

        }


        private void button17_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标

                lvi.Text = "subitem" + i;

                lvi.SubItems.Add("第2列,第" + i + "行");

                lvi.SubItems.Add("第3列,第" + i + "行");

                this.listView1.Items.Add(lvi);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            getzuobiao();
        }


        //IniHelper ini = new IniHelper(@"D:\");
        private void button18_Click_1(object sender, EventArgs e)
        {


            //   ini.WriteValue(treeView1.SelectedNode.Text, textBox1.Text, textBox1.Text);
            // PMINI.WriteIniValue()
            // string tempdirectory=  PMFILE.GetTempDirectory();
            // string aa = "";

            //  object ob = "";
            //  string tit = "aa";
            //  string star = "";
            //  string tempdirectory = PMFILE.BrowseForFolder(ref ob, ref tit, ref star);
            //  print(tempdirectory);
            // print(aa);//  项目保存 PROJECT SAVE

            //   PMFILE.BrowseForFolder();
            //  string projectpath= PM.ExecuteEx("PROJECT SAVE");
          //  print(projectpath);

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            //  ini.ReadValue(treeView1.SelectedNode.Text, textBox1.Text);
        }
    }
}






