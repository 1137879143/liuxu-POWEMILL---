using System;
using System.Collections;
using System.Windows.Forms;
using PM = PowerSolutionDOTNetOLE.clsPowerMILLOLE;

namespace PMclass
{

    //
    class PMclass
    {
        /// <summary>
        /// 连接成功返回true,连接失败返回false;
        /// </summary>
        /// <returns></returns>
        public bool 连接pm()
        {
            bool aa = PM.Connect();
            if (aa)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 创建行的pm进行连接,成功返回true,失败返回false;
        /// </summary>
        /// <returns></returns>
        public bool 创建新的pm并连接()
        {
            bool aa = PM.ConnectToNew();
            if (aa)
            {
                return true;
            }
            return false;


        }


        /// <summary>
        /// 向连接的pm发送命令,此无返回值
        /// </summary>
        /// <param name="aa"></param>
        public void 发送命令(string aa)
        {
            PM.Execute(aa);
        }

        /// <summary>
        /// 向连接的pm发送命令,此方法有返回值
        /// </summary>
        /// <param name="aa"></param>
        /// <returns></returns>
        public string 发送命名EX(string aa)
        {
            string bb = PM.ExecuteEx(aa);
            return bb;
        }

        /// <summary>
        /// 错误命令的开与关
        /// </summary>
        /// <param name="开关"></param>
        public void 设置_错误命令的开与关(bool 开关)
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


        /// <summary>
        /// 返回项目路径,已经带有"\"
        /// </summary>
        /// <returns></returns>
        public string 取运行目录()
        {
            string pftf = AppDomain.CurrentDomain.BaseDirectory;
            return pftf;
        }

        /// <summary>
        /// 返回pm中当前激活的坐标系名字
        /// </summary>
        /// <returns></returns>
        public string 获取_激活的坐标系()
        {
            string zuobiao = PM.GetActiveEntityName(PM.enumPowerMILLEntityType.pmWorkplane);

            return zuobiao;
        }

        /// <summary>
        /// 返回pm中所有的坐标系名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的坐标名称()
        {
            //获取所有的坐标
            int num = 1;
            string[] zb = new string[100];
            int id = 1;
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmWorkplane, ref num, ref zb, ref id);
            return zb;

        }

        /// <summary>
        /// 获取_所有的模型名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的模型名称()
        {
            int num = 1;
            string[] Model = new string[100];
            int id = 1;
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmModel, ref num, ref Model, ref id);

            return Model;
        }

        /// <summary>
        /// 读取PM中的所有刀具路径
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的刀具路径名称()
        {
            int aa = 1;
            int id = 1;
            string[] toolpath = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmToolpath, ref aa, ref toolpath, ref id);
            return toolpath;
        }

        /// <summary>
        /// 获取_所有的残留模型名称()
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的残留模型名称()
        {
            int aa = 0;
            int id = 0;
            string[] StockModel = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmStockModel, ref aa, ref StockModel, ref id);
            return StockModel;
        }


        /// <summary>
        /// 获取_所有的孔特征集名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的孔特征集名称()
        {
            int aa = 0;
            int id = 0;
            string[] Featureset = new string[200];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmFeatureSet, ref aa, ref Featureset, ref id);
            return Featureset;
        }


        /// <summary>
        /// 获取函数层组合和夹持
        /// </summary>
        /// <returns></returns>
        public string[] 获取_函数层组合和夹持()
        {
            int num = 1;
            int id = 1;
            string[] readLevel = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmLevel, ref num, ref readLevel, ref id);
            return readLevel;
        }

        /// <summary>
        /// 获取_所有的边界名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的边界名称()
        {
            int num = 1;
            int id = 1;
            string[] readBoundary = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmBoundary, ref num, ref readBoundary, ref id);
            return readBoundary;
        }

        /// <summary>
        /// 获取_所有的参考线名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的参考线名称()
        {
            int num = 1;
            int id = 1;
            string[] referenceline = new string[1000];
            PM.GetEntityList(PM.enumPowerMILLEntityType.pmPattern, ref num, ref referenceline, ref id);
            return referenceline;
        }

        /// <summary>
        /// 获取所有的刀具名称
        /// </summary>
        /// <returns></returns>
        public string[] 获取_所有的刀具名称()
        {
            int num = 1;
            int id = 1;
            string[] toolname = new string[1000];

            PM.GetEntityList(PM.enumPowerMILLEntityType.pmTool, ref num, ref toolname, ref id);

            return toolname;
        }

        /// <summary>
        /// 获取_指定名称的刀具详细信息
        /// </summary>
        /// <param name="toolname"></param>
        /// <returns></returns>
        public string[] 获取_指定名称的刀具详细信息(string toolname)
        {
            string[] testtoolname = PM.GetEntityParameterInfo(PM.enumPowerMILLEntityType.pmTool, toolname);
            return testtoolname;
        }

        /// <summary>
        /// 获取某个刀具路径的详细信息
        /// </summary>
        /// <param name="toolpath"></param>
        /// <returns></returns>
        public string[] 获取_指定的刀具路径详细信息(string toolpath)
        {
            //获取某个刀具路径的详细信息
            string[] aa = PM.GetEntityParameterInfo(PM.enumPowerMILLEntityType.pmToolpath, toolpath);
            return aa;
        }

        /// <summary>
        /// 激活坐标
        /// </summary>
        /// <param name="开关"></param>
        public void 设置_激活坐标(string name)
        {
            PM.Execute("ACTIVATE Workplane " + name);
        }

        /// <summary>
        ///  取消边界激活
        /// </summary>
        public void 设置_边界取消激活()
        {
            PM.Execute("DEACTIVATE Boundary");
        }
        /// <summary>
        /// 设置_激活刀具
        /// </summary>
        /// <param name="刀具名称"></param>
        public void 设置_激活刀具(string 刀具名称)
        {
            PM.Execute(" ACTIVATE TOOL " + 刀具名称);//改刀具
        }

        /// <summary>
        /// /// <summary>
        /// 获取毛坯大小  从0开始 11结束    从第6个数开始为XMIN, Xmax , Ymin  ,Ymax  , Zmin,Zmax
        /// </summary>
        /// <param name="name"></param>
        /// </summary>
        /// <returns></returns>
        public ArrayList 获取毛坯大小()
        {
            string blocksize = PM.ExecuteEx("size block");
            ArrayList size = new ArrayList();
            if (blocksize == "")
            {
                System.Windows.Forms.MessageBox.Show("当前无毛坯");
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

        /// <summary>
        /// 预览毛坯
        /// </summary>
        /// <param name="XY偏置"></param>
        /// <param name="正Z偏置"></param>
        /// <param name="负Z偏置"></param>
        public void 设置_按偏置量毛坯(string XY偏置, string 正Z偏置, string 负Z偏置)
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
        /// 创建_浅滩边界
        /// </summary>
        /// <param name="name"></param>
        /// <param name="上限角"></param>
        /// <param name="下限角"></param>
        /// <param name="公差"></param>
        /// <param name="径向余量"></param>
        /// <param name="轴向余量"></param>
        /// <param name="使用轴向余量"></param>
        /// <param name="刀具名称"></param>
        public void 创建_浅滩边界(string name, string 上限角, string 下限角, string 公差, string 径向余量, string 轴向余量, bool 使用轴向余量, string 刀具名称)
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
        /// <summary>
        /// 创建_接触点边界
        /// </summary>
        /// <param name="name"></param>
        /// <param name="模型公差"></param>
        /// <param name="边缘公差"></param>
        public void 创建_接触点边界(string name, string 模型公差, string 边缘公差)
        {

            PM.Execute("CREATE BOUNDARY " + name + " CONTACTPOINT FORM BOUNDARY");//边界类型
            PM.Execute("EDIT BOUNDARY " + name + " TOLERANCE  " + 模型公差);//模型公差
            PM.Execute("EDIT BOUNDARY " + name + " EDGE_TOLERANCE  " + 边缘公差);//边缘公差
            PM.Execute("EDIT BOUNDARY " + name + " INSERT MODEL  ");//插入已选模型
            PM.Execute("EDIT BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT  ");//接受


        }
        /// <summary>
        /// 创建_毛呸边界
        /// </summary>
        /// <param name="name"></param>
        public void 创建_毛呸边界(string name)
        {


            PM.Execute("CREATE BOUNDARY " + name + " BLOCK FORM BOUNDARY");//边界类型
            PM.Execute("EDIT  BOUNDARY " + name + " CALCULATE");//计算
            PM.Execute("EDIT  BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT");//接受

        }

        /// <summary>
        /// 创建已选曲面边界
        /// </summary>
        /// <param name="name"></param>
        /// <param name="顶部"></param>
        /// <param name="浮动"></param>
        /// <param name="公差"></param>
        /// <param name="侧面余量"></param>
        /// <param name="轴向余量开关"></param>
        /// <param name="刀具名称"></param>
        public void 创建_已选曲面边界(string name, bool 顶部, bool 浮动, string 公差, string 侧面余量, bool 轴向余量开关, string 刀具名称)
        {


            PM.Execute("CREATE BOUNDARY  " + name + " SELECTED FORM BOUNDARY");//边界类型

            if (顶部)
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELVERTICAL UP");//顶部勾选
            }
            else
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELVERTICAL down");//顶部不勾选
            }
            if (浮动)
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELROLLOVER ON");//浮动开
            }
            else
            {
                PM.Execute("EDIT BOUNDARY " + name + " SELROLLOVER off");//浮动关
            }

            PM.Execute("EDIT BOUNDARY " + name + " TOLERANCE " + 公差);//公差
            PM.Execute("EDIT BOUNDARY " + name + " THICKNESS '" + "'" + 侧面余量 + "'");//余量

            if (轴向余量开关)
            {
                PM.Execute("EDIT BOUNDARY " + name + " THICKNESS AXIAL_RADIAL ON");//轴向余量开
            }
            else
            {
                PM.Execute("EDIT BOUNDARY " + name + " THICKNESS AXIAL_RADIAL OFF");//轴向余量关
            }


            PM.Execute("EDIT BOUNDARY " + name + " TOOL NAME " + 刀具名称);//更换刀具
            PM.Execute("EDIT BOUNDARY " + name + " CALCULATE");//计算
            PM.Execute("EDIT BOUNDARY " + name + " ACCEPT BOUNDARY ACCEPT");//接受

        }



        /// <summary>
        /// 边界名称如果存在返回true,不存在返回false;
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool 判断_边界是否存在(string name)
        {
            string[] aa = 获取_所有的边界名称();
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
        public bool 判断_刀具路径是否存在(string name)
        {
            string[] toolpathname = 获取_所有的刀具路径名称();
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


        /// <summary>
        /// 编辑加工方向 自动 由外向内 由内向外
        /// </summary>
        public void 刀路编辑_加工方向(string 加工顺序)
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
        public void 刀路编辑_保持保持切削方向(bool 保持切削方向)
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
        public void 刀路编辑_增加从外侧进刀(bool 增加)
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
        public void 刀路编辑_光顺余量(bool 光顺余量, string 光顺值)
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
        public void 刀路编辑_轮廓光顺(bool 轮廓光顺, string 光顺值)
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
        public void 刀路编辑_连接(string 连接方式)
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
        public bool 刀路编辑_平坦面加工(string 平坦区域方式)
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

        public void 刀路编辑_轮廓切削方向(int 方向)
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
        public void 刀路编辑_区域切削方向(int 方向)
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
        public void 刀路编辑_不安全段删除(bool 区域过滤, bool 仅闭合区域, string 分界值)
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
        public void 刀路编辑_允许毛坯外(bool 允许)
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
        public void 刀路编辑_裁剪(bool 保留内部)
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


        public string 铣刀_创建端铣刀 = "CREATE TOOL ; ENDMILL FORM TOOL";


    }
}
