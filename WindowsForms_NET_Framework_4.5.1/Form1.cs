using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using SimWinInput;

namespace JoyStick_000
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboControllerNumber.Items.Add("0");
            ComboControllerNumber.Items.Add("1");
            ComboControllerNumber.Items.Add("2");
            ComboControllerNumber.Items.Add("3");
            ComboControllerNumber.SelectedIndex = 0;

            SimGamePad.Instance.Initialize();

            //Test
            Controllers[0] = new ControllerSetting();
            Controllers[1] = new ControllerSetting();
            Controllers[2] = new ControllerSetting();
            Controllers[3] = new ControllerSetting();
            ControllersPlugIn[0] = false;
            ControllersPlugIn[1] = false;
            ControllersPlugIn[2] = false;
            ControllersPlugIn[3] = false;

            //Controllers[0].LeftStick_Up = Keys.W;
            //Controllers[0].LeftStick_Down = Keys.S;
            //Controllers[0].LeftStick_Left = Keys.A;
            //Controllers[0].LeftStick_Right = Keys.D;
            //Controllers[0].LeftStick_Click = Keys.Q;
            //Controllers[0].LeftShoulder = Keys.R;
            //Controllers[0].LeftTrigger = Keys.RButton;

            //Controllers[0].DPad_Up = Keys.Up;
            //Controllers[0].DPad_Down = Keys.Down;
            //Controllers[0].DPad_Left = Keys.Left;
            //Controllers[0].DPad_Right = Keys.Right;

            //Controllers[0].RightStick_Up = Keys.NumPad8;
            //Controllers[0].RightStick_Down= Keys.NumPad5;
            //Controllers[0].RightStick_Left = Keys.NumPad4;
            //Controllers[0].RightStick_Right = Keys.NumPad6;
            //Controllers[0].RightStick_Click = Keys.E;
            //Controllers[0].RightShoulder = Keys.MButton ;
            //Controllers[0].RightTrigger = Keys.LButton;

            //Controllers[0].A = Keys.Space;
            //Controllers[0].B = Keys.F;
            //Controllers[0].X = Keys.Z;
            //Controllers[0].Y = Keys.C;

            //Controllers[0].Start = Keys.D1;
            //Controllers[0].Back = Keys.D2;
            //Controllers[0].Guide = Keys.D3;

            //Load data
            string[] files = Directory.GetFiles(Application.StartupPath);
            ComboLoad.Items.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                if (Path.GetExtension(files[i]) == ".dat")
                {
                    ComboLoad.Items.Add(Path.GetFileNameWithoutExtension(files[i]));
                }
            }
        }

        private void ButPlugIn_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(ComboControllerNumber.SelectedIndex);
            SimGamePad.Instance.PlugIn(index);
            ControllersPlugIn[index] = true;
        }

        private void ButUnplug_Click(object sender, EventArgs e)
        {
            thread_Keystate_Exit = true;
            int index = Convert.ToInt32(ComboControllerNumber.SelectedIndex);
            ControllersPlugIn[index] = false;
            SimGamePad.Instance.Unplug(index);

        }

        private void ButUnPlugAll_Click(object sender, EventArgs e)
        {
            int count = ComboControllerNumber.Items.Count;
            thread_Keystate_Exit = true;
            for (int i = 0; i < count;i++)
            {
                if (Controllers[i] != null)
                {
                    ControllersPlugIn[i] = false;
                }
                SimGamePad.Instance.Unplug(i);
            }
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            if (ControllersPlugIn[index] == true)
            {
                thread_Keystate_Exit = false;
                thread_KeyState = new Thread(new ThreadStart(thread_KeyState_Func));
                thread_KeyState.Start();
                ButStart.Enabled = false;
                ButStop.Enabled = true;
            }
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            thread_Keystate_Exit = true;
            ButStart.Enabled = true;
            ButStop.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                CheBoxLeftStickMouse.Checked = true;
                CheBoxRightStickMouse.Checked = true;
            }
            if (e.KeyCode == Keys.F12)
            {
                CheBoxLeftStickMouse.Checked = false;
                CheBoxRightStickMouse.Checked = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Opacity = TbOpacity.Value/100.0;
        }

        //Controller Settings
        private void CheBoxLeftStickMouse_CheckedChanged(object sender, EventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            if(CheBoxLeftStickMouse.Checked == true)
            {
                Controllers[index].LeftStickMouseControl = true;
                ButLeftStickUp.Enabled = false;
                ButLeftStickDown.Enabled = false;
                ButLeftStickLeft.Enabled = false;
                ButLeftStickRight.Enabled = false;
            }
            else if(CheBoxLeftStickMouse.Checked == false)
            {
                Controllers[index].LeftStickMouseControl = false;
                ButLeftStickUp.Enabled = true;
                ButLeftStickDown.Enabled = true;
                ButLeftStickLeft.Enabled = true;
                ButLeftStickRight.Enabled = true;
            }
        }

        private void CheBoxRightStickMouse_CheckedChanged(object sender, EventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            if (CheBoxRightStickMouse.Checked == true)
            {
                
                Controllers[index].RightStickMouseControl = true;
                ButRightStickUp.Enabled = false;
                ButRightStickDown.Enabled = false;
                ButRightStickLeft.Enabled = false;
                ButRightStickRight.Enabled = false;
            }
            else if (CheBoxRightStickMouse.Checked == false)
            {
                Controllers[index].RightStickMouseControl = false;
                ButRightStickUp.Enabled = true;
                ButRightStickDown.Enabled = true;
                ButRightStickLeft.Enabled = true;
                ButRightStickRight.Enabled = true;
            }
        }


        //Controls
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Left: { return false; }
                case Keys.Right: { return false; }
                case Keys.Up: { return false; }
                case Keys.Down: { return false; }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ButLeftStickTrigger_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftTrigger = (Keys)e.KeyValue;
            ButLeftStickTrigger.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickUp_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftStick_Up = (Keys)e.KeyValue;
            ButLeftStickUp.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickShoulder_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftShoulder = (Keys)e.KeyValue;
            ButLeftStickShoulder.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickLeft_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftStick_Left = (Keys)e.KeyValue;
            ButLeftStickLeft.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickClick_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftStick_Click = (Keys)e.KeyValue;
            ButLeftStickClick.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickRight_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftStick_Right = (Keys)e.KeyValue;
            ButLeftStickRight.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButLeftStickDown_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].LeftStick_Down = (Keys)e.KeyValue;
            ButLeftStickDown.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButDPadUp_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].DPad_Up = (Keys)e.KeyValue;
            ButDPadUp.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButDPadLeft_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].DPad_Left = (Keys)e.KeyValue;
            ButDPadLeft.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButDPadRight_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].DPad_Right = (Keys)e.KeyValue;
            ButDPadRight.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButDPadDown_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].DPad_Down = (Keys)e.KeyValue;
            ButDPadDown.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickTrigger_KeyDown(object sender, KeyEventArgs e)
        {
            Controllers[0].RightTrigger = (Keys)e.KeyValue;
            ButRightStickTrigger.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickUp_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightStick_Up= (Keys)e.KeyValue;
            ButRightStickUp.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickShoulder_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightShoulder = (Keys)e.KeyValue;
            ButRightStickShoulder.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickLeft_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightStick_Left = (Keys)e.KeyValue;
            ButRightStickLeft.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickClick_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightStick_Click = (Keys)e.KeyValue;
            ButRightStickClick.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickRight_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightStick_Right = (Keys)e.KeyValue;
            ButRightStickRight.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButRightStickDown_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].RightStick_Down = (Keys)e.KeyValue;
            ButRightStickDown.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButABXYY_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].Y = (Keys)e.KeyValue;
            ButABXYY.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButABXYX_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].X = (Keys)e.KeyValue;
            ButABXYX.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButABXYA_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].A = (Keys)e.KeyValue;
            ButABXYA.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButABXYB_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].B = (Keys)e.KeyValue;
            ButABXYB.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButMenuStart_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].Start = (Keys)e.KeyValue;
            ButMenuStart.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButMenuBack_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].Back = (Keys)e.KeyValue;
            ButMenuBack.Text = ((Keys)e.KeyValue).ToString();
        }

        private void ButMenuGuide_KeyDown(object sender, KeyEventArgs e)
        {
            int index = ComboControllerNumber.SelectedIndex;
            Controllers[index].Guide = (Keys)e.KeyValue;
            ButMenuGuide.Text = ((Keys)e.KeyValue).ToString();
        }

        //Save & Load
        private void ButSave_Click(object sender, EventArgs e)
        {
            LabRename.Visible = false;
            if (TexName.Text.Trim() == "")
            {
                TexName.Text = "";
                LabRename.Visible = true;
            }
            else
            {
                int index = ComboControllerNumber.SelectedIndex;
                //string path = Application.ExecutablePath;//包括文件名
                string path = Application.StartupPath;//不包括文件名
                path = path + "\\" + TexName.Text + ".dat";
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Controllers[index]);
                fs.Close();
                string[] files = Directory.GetFiles(Application.StartupPath);
                ComboLoad.Items.Clear();
                for (int i = 0; i < files.Length;i++)
                {
                    if(Path.GetExtension(files[i]) == ".dat")
                    {
                        ComboLoad.Items.Add( Path.GetFileNameWithoutExtension(files[i]));
                    }
                }
            }
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            if (ComboLoad.Text != "")
            {
                int index = ComboControllerNumber.SelectedIndex;
                string filename = Application.StartupPath + "\\" + ComboLoad.Text + ".dat";
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Controllers[index] = bf.Deserialize(fs) as ControllerSetting;
                fs.Close();
                CheBoxLeftStickMouse.Checked = (Controllers[index].LeftStickMouseControl == true ? true : false);
                ButLeftStickTrigger.Text = Convert.ToString(Controllers[index].LeftTrigger);
                ButLeftStickUp.Text = Convert.ToString(Controllers[index].LeftStick_Up);
                ButLeftStickShoulder.Text = Convert.ToString(Controllers[index].LeftShoulder);
                ButLeftStickLeft.Text = Convert.ToString(Controllers[index].LeftStick_Left);
                ButLeftStickClick.Text = Convert.ToString(Controllers[index].LeftStick_Click);
                ButLeftStickRight.Text = Convert.ToString(Controllers[index].LeftStick_Right);
                ButLeftStickDown.Text = Convert.ToString(Controllers[index].LeftStick_Down);
                ButDPadUp.Text = Convert.ToString(Controllers[index].DPad_Up);
                ButDPadLeft.Text = Convert.ToString(Controllers[index].DPad_Left);
                ButDPadRight.Text = Convert.ToString(Controllers[index].DPad_Right);
                ButDPadDown.Text = Convert.ToString(Controllers[index].DPad_Down);
                CheBoxRightStickMouse.Checked = (Controllers[index].RightStickMouseControl == true ? true : false);
                ButRightStickTrigger.Text = Convert.ToString(Controllers[index].RightTrigger);
                ButRightStickUp.Text = Convert.ToString(Controllers[index].RightStick_Up);
                ButRightStickShoulder.Text = Convert.ToString(Controllers[index].RightShoulder);
                ButRightStickLeft.Text = Convert.ToString(Controllers[index].RightStick_Left);
                ButRightStickClick.Text = Convert.ToString(Controllers[index].RightStick_Click);
                ButRightStickRight.Text = Convert.ToString(Controllers[index].RightStick_Right);
                ButRightStickDown.Text = Convert.ToString(Controllers[index].RightStick_Down);
                ButABXYY.Text = Convert.ToString(Controllers[index].Y);
                ButABXYX.Text = Convert.ToString(Controllers[index].X);
                ButABXYA.Text = Convert.ToString(Controllers[index].A);
                ButABXYB.Text = Convert.ToString(Controllers[index].B);
                ButMenuStart.Text = Convert.ToString(Controllers[index].Start);
                ButMenuBack.Text = Convert.ToString(Controllers[index].Back);
                ButMenuGuide.Text = Convert.ToString(Controllers[index].Guide);
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (ComboLoad.Text != "")
            {
                string name = ComboLoad.Text;
                string path = Application.StartupPath;
                string filename = path + "\\" + name + ".dat";
                File.Delete(filename);
                ComboLoad.Items.Remove(name);
            }
            
        }

        private void ComboControllerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Stop
            thread_Keystate_Exit = true;
            ButStart.Enabled = true;
            ButStop.Enabled = false;

            //Control
            int index = ComboControllerNumber.SelectedIndex;
            if (Controllers[index] != null)
            {
                CheBoxLeftStickMouse.Checked = (Controllers[index].LeftStickMouseControl == true ? true : false);
                ButLeftStickTrigger.Text = Convert.ToString(Controllers[index].LeftTrigger);
                ButLeftStickUp.Text = Convert.ToString(Controllers[index].LeftStick_Up);
                ButLeftStickShoulder.Text = Convert.ToString(Controllers[index].LeftShoulder);
                ButLeftStickLeft.Text = Convert.ToString(Controllers[index].LeftStick_Left);
                ButLeftStickClick.Text = Convert.ToString(Controllers[index].LeftStick_Click);
                ButLeftStickRight.Text = Convert.ToString(Controllers[index].LeftStick_Right);
                ButLeftStickDown.Text = Convert.ToString(Controllers[index].LeftStick_Down);
                ButDPadUp.Text = Convert.ToString(Controllers[index].DPad_Up);
                ButDPadLeft.Text = Convert.ToString(Controllers[index].DPad_Left);
                ButDPadRight.Text = Convert.ToString(Controllers[index].DPad_Right);
                ButDPadDown.Text = Convert.ToString(Controllers[index].DPad_Down);
                CheBoxRightStickMouse.Checked = (Controllers[index].RightStickMouseControl == true ? true : false);
                ButRightStickTrigger.Text = Convert.ToString(Controllers[index].RightTrigger);
                ButRightStickUp.Text = Convert.ToString(Controllers[index].RightStick_Up);
                ButRightStickShoulder.Text = Convert.ToString(Controllers[index].RightShoulder);
                ButRightStickLeft.Text = Convert.ToString(Controllers[index].RightStick_Left);
                ButRightStickClick.Text = Convert.ToString(Controllers[index].RightStick_Click);
                ButRightStickRight.Text = Convert.ToString(Controllers[index].RightStick_Right);
                ButRightStickDown.Text = Convert.ToString(Controllers[index].RightStick_Down);
                ButABXYY.Text = Convert.ToString(Controllers[index].Y);
                ButABXYX.Text = Convert.ToString(Controllers[index].X);
                ButABXYA.Text = Convert.ToString(Controllers[index].A);
                ButABXYB.Text = Convert.ToString(Controllers[index].B);
                ButMenuStart.Text = Convert.ToString(Controllers[index].Start);
                ButMenuBack.Text = Convert.ToString(Controllers[index].Back);
                ButMenuGuide.Text = Convert.ToString(Controllers[index].Guide);
            }
        }
        //

    }
}
