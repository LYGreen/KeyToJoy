using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using SimWinInput;

namespace JoyStick_000
{
    [Serializable]
    internal class ControllerSetting
    {
        //public bool PlugIn = false;//Useless

        public bool LeftStickMouseControl = new bool();
        public Keys LeftStick_Up = new Keys();
        public Keys LeftStick_Down = new Keys();
        public Keys LeftStick_Left = new Keys();
        public Keys LeftStick_Right = new Keys();
        public Keys LeftStick_Click = new Keys();
        public Keys LeftShoulder = new Keys();
        public Keys LeftTrigger = new Keys();
        public Keys LeftStickAsAnalog = new Keys();

        public Keys DPad_Up = new Keys();
        public Keys DPad_Down = new Keys();
        public Keys DPad_Left = new Keys();
        public Keys DPad_Right = new Keys();
        public Keys DPadAsAnalog = new Keys();

        public bool RightStickMouseControl = new bool();
        public Keys RightStick_Up = new Keys();
        public Keys RightStick_Down = new Keys();
        public Keys RightStick_Left = new Keys();
        public Keys RightStick_Right = new Keys();
        public Keys RightStick_Click = new Keys();
        public Keys RightShoulder = new Keys();
        public Keys RightTrigger = new Keys();
        public Keys RightStickAsAnalog = new Keys();

        public Keys A = new Keys();
        public Keys B = new Keys();
        public Keys X = new Keys();
        public Keys Y = new Keys();

        public Keys Start = new Keys();
        public Keys Back = new Keys();
        public Keys Guide = new Keys();

        public Keys None = new Keys();
    }

    public partial class Form1 : Form
    {


        static ControllerSetting[] Controllers = new ControllerSetting[4];
        static bool[] ControllersPlugIn = new bool[4];
        static Thread thread_KeyState = null;
        static bool thread_Keystate_Exit = true;
        
        [DllImport("User32")]
        public static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);

        void thread_KeyState_Func()
        {
            var simPad = SimGamePad.Instance;
            var simState = SimGamePad.Instance.State[0];
            Point MouseLastPos = new Point(MousePosition.X,MousePosition.Y);
            Point MouseDir = new Point();
            while (!thread_Keystate_Exit)
            {
                Thread.Sleep(1);
                int index = ComboControllerNumber.SelectedIndex;
                simState = SimGamePad.Instance.State[index];
                if (ControllersPlugIn[index] == false)
                {
                    break;
                }

                //Key
                if(GetAsyncKeyState((int)Keys.Escape) != 0)/*||((GetAsyncKeyState((int)Keys.Alt)!= 0)&&(GetAsyncKeyState((int)Keys.Q))!= 0))*/
                {
                    thread_Keystate_Exit = true;
                    ButStart.Enabled = true;
                    ButStop.Enabled = false;
                }

                //Control

                if(Controllers[index].LeftStickMouseControl == true || Controllers[index].RightStickMouseControl == true)
                {
                    MouseDir.X = MousePosition.X - MouseLastPos.X;
                    MouseDir.Y = MousePosition.Y - MouseLastPos.Y;
                    SetCursorPos(MouseLastPos.X, MouseLastPos.Y);
                }
                else
                {
                    MouseLastPos.X = MousePosition.X;
                    MouseLastPos.Y = MousePosition.Y;
                }
                
                simState.Reset();
                //LeftStick
                if (Controllers[index].LeftStickMouseControl == false)
                {
                    if (GetAsyncKeyState((Int32)Controllers[index].LeftStick_Up) != 0)
                    {
                        simState.LeftStickY = short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].LeftStick_Down) != 0)
                    {
                        simState.LeftStickY = -short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].LeftStick_Left) != 0)
                    {
                        simState.LeftStickX = -short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].LeftStick_Right) != 0)
                    {
                        simState.LeftStickX = short.MaxValue;
                    }
                }
                else
                {
                    if (MouseDir.Y < 0)
                    {
                        simState.LeftStickY = short.MaxValue;
                    }
                    else if (MouseDir.Y > 0)
                    {
                        simState.LeftStickY = -short.MaxValue;
                    }
                    if (MouseDir.X < 0)
                    {
                        simState.LeftStickX = -short.MaxValue;
                    }
                    else if(MouseDir.X > 0)
                    {
                        simState.LeftStickX = short.MaxValue;
                    }

                }
                if (GetAsyncKeyState((Int32)Controllers[index].LeftStick_Click) != 0)
                {
                    simState.Buttons |= GamePadControl.LeftStickClick;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].LeftShoulder) != 0)
                {
                    simState.Buttons |= GamePadControl.LeftShoulder;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].LeftTrigger) != 0)
                {
                    simState.LeftTrigger = byte.MaxValue;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].LeftStickAsAnalog) != 0)
                {
                    simState.Buttons |= GamePadControl.LeftStickAsAnalog;
                }
                //DPad
                if (GetAsyncKeyState((Int32)Controllers[index].DPad_Up) != 0)
                {
                    simState.Buttons |= GamePadControl.DPadUp;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].DPad_Down) != 0)
                {
                    simState.Buttons |= GamePadControl.DPadDown;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].DPad_Left) != 0)
                {
                    simState.Buttons |= GamePadControl.DPadLeft;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].DPad_Right) != 0)
                {
                    simState.Buttons |= GamePadControl.DPadRight;
                }
                if (GetAsyncKeyState((Int32)Controllers[index].DPadAsAnalog) != 0)
                {
                    simState.Buttons |= GamePadControl.DPadAsAnalog;
                }
                //RightStick
                if (Controllers[index].RightStickMouseControl == false)
                {

                    if (GetAsyncKeyState((Int32)Controllers[index].RightStick_Up) != 0)
                    {
                        simState.RightStickY = short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightStick_Down) != 0)
                    {
                        simState.RightStickY = -short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightStick_Left) != 0)
                    {
                        simState.RightStickX = -short.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightStick_Right) != 0)
                    {
                        simState.RightStickX = short.MaxValue;
                    }
                }
                else
                {
                    if (MouseDir.Y < 0)
                    {
                        simState.RightStickY = short.MaxValue;
                    }
                    else if (MouseDir.Y > 0)
                    {
                        simState.RightStickY = -short.MaxValue;
                    }
                    if (MouseDir.X < 0)
                    {
                        simState.RightStickX = -short.MaxValue;
                    }
                    else if (MouseDir.X > 0)
                    {
                        simState.RightStickX = short.MaxValue;
                    }
                }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightStick_Click) != 0)
                    {
                        simState.Buttons |= GamePadControl.RightStickClick;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightShoulder) != 0)
                    {
                        simState.Buttons |= GamePadControl.RightShoulder;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightTrigger) != 0)
                    {
                        simState.RightTrigger = byte.MaxValue;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].RightStickAsAnalog) != 0)
                    {
                        simState.Buttons |= GamePadControl.RightStickClick;
                    }
                    //MainKeys
                    if (GetAsyncKeyState((Int32)Controllers[index].A) != 0)
                    {
                        simState.Buttons |= GamePadControl.A;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].B) != 0)
                    {
                        simState.Buttons |= GamePadControl.B;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].X) != 0)
                    {
                        simState.Buttons |= GamePadControl.X;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].Y) != 0)
                    {
                        simState.Buttons |= GamePadControl.Y;
                    }
                    //OtherKeys
                    if (GetAsyncKeyState((Int32)Controllers[index].Start) != 0)
                    {
                        simState.Buttons |= GamePadControl.Start;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].Back) != 0)
                    {
                        simState.Buttons |= GamePadControl.Back;
                    }
                    if (GetAsyncKeyState((Int32)Controllers[index].Guide) != 0)
                    {
                        simState.Buttons |= GamePadControl.Guide;
                    }

                    //GamePad Update
                    SimGamePad.Instance.Update(index);
                
                
            }
            thread_Keystate_Exit = false;
        }

    }
}
