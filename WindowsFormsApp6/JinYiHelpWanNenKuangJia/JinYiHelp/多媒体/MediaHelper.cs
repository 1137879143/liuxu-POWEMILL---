using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JinYiHelp.MediaHelp
{
   public class MediaHelper
    {
        #region 同步播放wav文件
        /// <summary>
        /// 以同步方式播放wav文件
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void SyncPlayWAV(SoundPlayer sp, string wavFilePath)
        {
            try
            {
                //设置wav文件的路径 
                sp.SoundLocation = wavFilePath;

                //使用异步方式加载wav文件
                sp.LoadAsync();

                //使用同步方式播放wav文件
                if (sp.IsLoadCompleted)
                {
                    sp.PlaySync();
                }
            }
            catch (Exception ex)
            {
                string errStr = ex.Message;
                throw ex;
            }
        }

        /// <summary>
        /// 以同步方式播放wav文件
        /// </summary>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void SyncPlayWAV(string wavFilePath)
        {
            try
            {
                //创建一个SoundPlaryer类，并设置wav文件的路径
                SoundPlayer sp = new SoundPlayer(wavFilePath);

                //使用异步方式加载wav文件
                sp.LoadAsync();

                //使用同步方式播放wav文件
                if (sp.IsLoadCompleted)
                {
                    sp.PlaySync();
                }
            }
            catch (Exception ex)
            {
                string errStr = ex.Message;
                throw ex;
            }
        }
        #endregion

        #region 异步播放wav文件
        /// <summary>
        /// 以异步方式播放wav文件
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void ASyncPlayWAV(SoundPlayer sp, string wavFilePath)
        {
            try
            {
                //设置wav文件的路径 
                sp.SoundLocation = wavFilePath;

                //使用异步方式加载wav文件
                sp.LoadAsync();

                //使用异步方式播放wav文件
                if (sp.IsLoadCompleted)
                {
                    sp.Play();
                }
            }
            catch (Exception ex)
            {
                string errStr = ex.Message;
                throw ex;
            }
        }

        /// <summary>
        /// 以异步方式播放wav文件
        /// </summary>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void ASyncPlayWAV(string wavFilePath)
        {
            try
            {
                //创建一个SoundPlaryer类，并设置wav文件的路径
                SoundPlayer sp = new SoundPlayer(wavFilePath);

                //使用异步方式加载wav文件
                sp.LoadAsync();

                //使用异步方式播放wav文件
                if (sp.IsLoadCompleted)
                {
                    sp.Play();
                }
            }
            catch (Exception ex)
            {
                string errStr = ex.Message;
                throw ex;
            }
        }
        #endregion

        #region 停止播放wav文件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        public static void StopWAV(SoundPlayer sp)
        {
            sp.Stop();
        }
        #endregion


        #region 峰鸣

        protected enum Tone//枚举 五线谱
        {
            REST = 0,
            A = 220,
            B = 247,
            C = 262,
            D = 294,
            E = 330,
            F = 349,
            G = 392,
        }

        protected enum Duration//枚举 发音时间
        {
            WHOLE = 1200,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        protected struct Note
        {
            Tone toneVal;  //初始化一个Tone对象
            Duration durVal;  //初始化一个Duration对象
            public Note(Tone frequency, Duration time)  //定义一个Note方法
            {
                toneVal = frequency;  //为变量toneVal赋值
                durVal = time;  //为变量durVal赋值
            }
            public Tone NoteTone
            {
                get
                {
                    return toneVal;    //定义一个Tone类型的属性
                }
                set
                {
                    toneVal = value;
                }
            }
            public Duration NoteDuration
            {
                get
                {
                    return durVal;    //定义一个Duration类型的属性
                }
                set
                {
                    durVal = value;
                }
            }
        }

        protected void Play(Note tune)
        {
            if (tune.NoteTone == Tone.REST)  //当没有选择RadioButton按钮时
                Thread.Sleep((int)tune.NoteDuration);  //将当前线程挂起指定的时间
            else //当选定某一个RadioButton按钮时
                 //通过控制台扬声器播放具有指定频率和持续时间的声音
                Console.Beep((int)tune.NoteTone, (int)tune.NoteDuration);
        }

        /// <summary>
        /// 发音方法
        /// </summary>
        /// <param name="a">1 - 7 音</param>
        /// <param name="b">声调 1长音 2中长音 3中音 4短长音 5短音</param>
        public void PlayMic(int a, int b)
        {
            Note note = new Note();
            switch (a)
            {
                case 1:
                    note.NoteTone = Tone.A;
                    break;
                case 2:
                    note.NoteTone = Tone.B;
                    break;
                case 3:
                    note.NoteTone = Tone.C;
                    break;
                case 4:
                    note.NoteTone = Tone.D;
                    break;
                case 5:
                    note.NoteTone = Tone.E;
                    break;
                case 6:
                    note.NoteTone = Tone.F;
                    break;
                case 7:
                    note.NoteTone = Tone.G;
                    break;
                default:
                    break;
            }
            switch (b)
            {
                case 1:
                    note.NoteDuration = Duration.WHOLE;
                    break;
                case 2:
                    note.NoteDuration = Duration.HALF;
                    break;
                case 3:
                    note.NoteDuration = Duration.QUARTER;
                    break;
                case 4:
                    note.NoteDuration = Duration.EIGHTH;
                    break;
                case 5:
                    note.NoteDuration = Duration.SIXTEENTH;
                    break;
            }
            Play(note);
        }



        #endregion




    }
}
