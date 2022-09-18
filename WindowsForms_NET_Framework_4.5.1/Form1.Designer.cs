using System.Threading;
namespace JoyStick_000
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            thread_Keystate_Exit = true;
            while (thread_KeyState.IsAlive)
            {
                Thread.Sleep(1);
            }
            SimWinInput.SimGamePad.Instance.ShutDown();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboControllerNumber = new System.Windows.Forms.ComboBox();
            this.LabControllerNumber = new System.Windows.Forms.Label();
            this.ButPlugIn = new System.Windows.Forms.Button();
            this.ButUnplug = new System.Windows.Forms.Button();
            this.ButUnPlugAll = new System.Windows.Forms.Button();
            this.ButStart = new System.Windows.Forms.Button();
            this.ButStop = new System.Windows.Forms.Button();
            this.TbOpacity = new System.Windows.Forms.TrackBar();
            this.ButLeftStickUp = new System.Windows.Forms.Button();
            this.LabLeftStickUp = new System.Windows.Forms.Label();
            this.ButLeftStickClick = new System.Windows.Forms.Button();
            this.ButLeftStickDown = new System.Windows.Forms.Button();
            this.ButLeftStickRight = new System.Windows.Forms.Button();
            this.ButLeftStickTrigger = new System.Windows.Forms.Button();
            this.ButLeftStickShoulder = new System.Windows.Forms.Button();
            this.ButLeftStickLeft = new System.Windows.Forms.Button();
            this.LabLeftStick = new System.Windows.Forms.Label();
            this.LabLeftStickClick = new System.Windows.Forms.Label();
            this.LabLeftStickDown = new System.Windows.Forms.Label();
            this.LabLeftStickRight = new System.Windows.Forms.Label();
            this.LabLeftStickLeft = new System.Windows.Forms.Label();
            this.LabLeftStickTrigger = new System.Windows.Forms.Label();
            this.LabLeftStickShoulder = new System.Windows.Forms.Label();
            this.LabRightStickShoulder = new System.Windows.Forms.Label();
            this.LabRightStickTrigger = new System.Windows.Forms.Label();
            this.LabRightStickLeft = new System.Windows.Forms.Label();
            this.LabRightStickRight = new System.Windows.Forms.Label();
            this.LabRightStickDown = new System.Windows.Forms.Label();
            this.LabRightStickClick = new System.Windows.Forms.Label();
            this.LabRightStick = new System.Windows.Forms.Label();
            this.ButRightStickLeft = new System.Windows.Forms.Button();
            this.ButRightStickShoulder = new System.Windows.Forms.Button();
            this.ButRightStickTrigger = new System.Windows.Forms.Button();
            this.ButRightStickRight = new System.Windows.Forms.Button();
            this.ButRightStickDown = new System.Windows.Forms.Button();
            this.ButRightStickClick = new System.Windows.Forms.Button();
            this.LabRightStickUp = new System.Windows.Forms.Label();
            this.ButRightStickUp = new System.Windows.Forms.Button();
            this.LabFormOpacity = new System.Windows.Forms.Label();
            this.ButDPadUp = new System.Windows.Forms.Button();
            this.ButDPadLeft = new System.Windows.Forms.Button();
            this.ButDPadDown = new System.Windows.Forms.Button();
            this.ButDPadRight = new System.Windows.Forms.Button();
            this.LabDPad = new System.Windows.Forms.Label();
            this.LabDPadUp = new System.Windows.Forms.Label();
            this.LabDPadRight = new System.Windows.Forms.Label();
            this.LabDPadDown = new System.Windows.Forms.Label();
            this.LabDPadLeft = new System.Windows.Forms.Label();
            this.LabABXYX = new System.Windows.Forms.Label();
            this.LabABXYB = new System.Windows.Forms.Label();
            this.LabABXYA = new System.Windows.Forms.Label();
            this.LabABXYY = new System.Windows.Forms.Label();
            this.LabABXY = new System.Windows.Forms.Label();
            this.ButABXYA = new System.Windows.Forms.Button();
            this.ButABXYB = new System.Windows.Forms.Button();
            this.ButABXYX = new System.Windows.Forms.Button();
            this.ButABXYY = new System.Windows.Forms.Button();
            this.LabMenu = new System.Windows.Forms.Label();
            this.ButMenuStart = new System.Windows.Forms.Button();
            this.ButMenuBack = new System.Windows.Forms.Button();
            this.ButMenuGuide = new System.Windows.Forms.Button();
            this.LabMenuStart = new System.Windows.Forms.Label();
            this.LabMenuBack = new System.Windows.Forms.Label();
            this.LabMenuGuide = new System.Windows.Forms.Label();
            this.CheBoxLeftStickMouse = new System.Windows.Forms.CheckBox();
            this.CheBoxRightStickMouse = new System.Windows.Forms.CheckBox();
            this.LabTip = new System.Windows.Forms.Label();
            this.ButSave = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.ComboLoad = new System.Windows.Forms.ComboBox();
            this.ButLoad = new System.Windows.Forms.Button();
            this.TexName = new System.Windows.Forms.TextBox();
            this.LabRename = new System.Windows.Forms.Label();
            this.ButDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TbOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboControllerNumber
            // 
            this.ComboControllerNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboControllerNumber.FormattingEnabled = true;
            this.ComboControllerNumber.Location = new System.Drawing.Point(123, 8);
            this.ComboControllerNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboControllerNumber.Name = "ComboControllerNumber";
            this.ComboControllerNumber.Size = new System.Drawing.Size(111, 20);
            this.ComboControllerNumber.TabIndex = 0;
            this.ComboControllerNumber.SelectedIndexChanged += new System.EventHandler(this.ComboControllerNumber_SelectedIndexChanged);
            // 
            // LabControllerNumber
            // 
            this.LabControllerNumber.AutoSize = true;
            this.LabControllerNumber.Location = new System.Drawing.Point(10, 11);
            this.LabControllerNumber.Name = "LabControllerNumber";
            this.LabControllerNumber.Size = new System.Drawing.Size(107, 12);
            this.LabControllerNumber.TabIndex = 1;
            this.LabControllerNumber.Text = "Controller Number";
            // 
            // ButPlugIn
            // 
            this.ButPlugIn.Location = new System.Drawing.Point(10, 30);
            this.ButPlugIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButPlugIn.Name = "ButPlugIn";
            this.ButPlugIn.Size = new System.Drawing.Size(64, 20);
            this.ButPlugIn.TabIndex = 2;
            this.ButPlugIn.Text = "Plug In";
            this.ButPlugIn.UseVisualStyleBackColor = true;
            this.ButPlugIn.Click += new System.EventHandler(this.ButPlugIn_Click);
            // 
            // ButUnplug
            // 
            this.ButUnplug.Location = new System.Drawing.Point(80, 30);
            this.ButUnplug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButUnplug.Name = "ButUnplug";
            this.ButUnplug.Size = new System.Drawing.Size(64, 20);
            this.ButUnplug.TabIndex = 3;
            this.ButUnplug.Text = "Unplug";
            this.ButUnplug.UseVisualStyleBackColor = true;
            this.ButUnplug.Click += new System.EventHandler(this.ButUnplug_Click);
            // 
            // ButUnPlugAll
            // 
            this.ButUnPlugAll.Location = new System.Drawing.Point(146, 30);
            this.ButUnPlugAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButUnPlugAll.Name = "ButUnPlugAll";
            this.ButUnPlugAll.Size = new System.Drawing.Size(78, 20);
            this.ButUnPlugAll.TabIndex = 4;
            this.ButUnPlugAll.Text = "Unplug All";
            this.ButUnPlugAll.UseVisualStyleBackColor = true;
            this.ButUnPlugAll.Click += new System.EventHandler(this.ButUnPlugAll_Click);
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(10, 54);
            this.ButStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(64, 20);
            this.ButStart.TabIndex = 5;
            this.ButStart.Text = "Start";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // ButStop
            // 
            this.ButStop.Enabled = false;
            this.ButStop.Location = new System.Drawing.Point(80, 54);
            this.ButStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(64, 20);
            this.ButStop.TabIndex = 6;
            this.ButStop.Text = "Stop";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // TbOpacity
            // 
            this.TbOpacity.Location = new System.Drawing.Point(334, 8);
            this.TbOpacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbOpacity.Maximum = 100;
            this.TbOpacity.Minimum = 15;
            this.TbOpacity.Name = "TbOpacity";
            this.TbOpacity.Size = new System.Drawing.Size(411, 45);
            this.TbOpacity.TabIndex = 7;
            this.TbOpacity.Value = 100;
            this.TbOpacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ButLeftStickUp
            // 
            this.ButLeftStickUp.Location = new System.Drawing.Point(68, 111);
            this.ButLeftStickUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickUp.Name = "ButLeftStickUp";
            this.ButLeftStickUp.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickUp.TabIndex = 8;
            this.ButLeftStickUp.Text = "None";
            this.ButLeftStickUp.UseVisualStyleBackColor = true;
            this.ButLeftStickUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickUp_KeyDown);
            // 
            // LabLeftStickUp
            // 
            this.LabLeftStickUp.AutoSize = true;
            this.LabLeftStickUp.Location = new System.Drawing.Point(84, 97);
            this.LabLeftStickUp.Name = "LabLeftStickUp";
            this.LabLeftStickUp.Size = new System.Drawing.Size(17, 12);
            this.LabLeftStickUp.TabIndex = 9;
            this.LabLeftStickUp.Text = "Up";
            // 
            // ButLeftStickClick
            // 
            this.ButLeftStickClick.Location = new System.Drawing.Point(68, 175);
            this.ButLeftStickClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickClick.Name = "ButLeftStickClick";
            this.ButLeftStickClick.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickClick.TabIndex = 10;
            this.ButLeftStickClick.Text = "None";
            this.ButLeftStickClick.UseVisualStyleBackColor = true;
            this.ButLeftStickClick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickClick_KeyDown);
            // 
            // ButLeftStickDown
            // 
            this.ButLeftStickDown.Location = new System.Drawing.Point(68, 238);
            this.ButLeftStickDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickDown.Name = "ButLeftStickDown";
            this.ButLeftStickDown.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickDown.TabIndex = 13;
            this.ButLeftStickDown.Text = "None";
            this.ButLeftStickDown.UseVisualStyleBackColor = true;
            this.ButLeftStickDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickDown_KeyDown);
            // 
            // ButLeftStickRight
            // 
            this.ButLeftStickRight.Location = new System.Drawing.Point(122, 175);
            this.ButLeftStickRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickRight.Name = "ButLeftStickRight";
            this.ButLeftStickRight.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickRight.TabIndex = 14;
            this.ButLeftStickRight.Text = "None";
            this.ButLeftStickRight.UseVisualStyleBackColor = true;
            this.ButLeftStickRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickRight_KeyDown);
            // 
            // ButLeftStickTrigger
            // 
            this.ButLeftStickTrigger.Location = new System.Drawing.Point(12, 111);
            this.ButLeftStickTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickTrigger.Name = "ButLeftStickTrigger";
            this.ButLeftStickTrigger.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickTrigger.TabIndex = 15;
            this.ButLeftStickTrigger.Text = "None";
            this.ButLeftStickTrigger.UseVisualStyleBackColor = true;
            this.ButLeftStickTrigger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickTrigger_KeyDown);
            // 
            // ButLeftStickShoulder
            // 
            this.ButLeftStickShoulder.Location = new System.Drawing.Point(121, 111);
            this.ButLeftStickShoulder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickShoulder.Name = "ButLeftStickShoulder";
            this.ButLeftStickShoulder.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickShoulder.TabIndex = 16;
            this.ButLeftStickShoulder.Text = "None";
            this.ButLeftStickShoulder.UseVisualStyleBackColor = true;
            this.ButLeftStickShoulder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickShoulder_KeyDown);
            // 
            // ButLeftStickLeft
            // 
            this.ButLeftStickLeft.Location = new System.Drawing.Point(12, 175);
            this.ButLeftStickLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLeftStickLeft.Name = "ButLeftStickLeft";
            this.ButLeftStickLeft.Size = new System.Drawing.Size(50, 50);
            this.ButLeftStickLeft.TabIndex = 17;
            this.ButLeftStickLeft.Text = "None";
            this.ButLeftStickLeft.UseVisualStyleBackColor = true;
            this.ButLeftStickLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButLeftStickLeft_KeyDown);
            // 
            // LabLeftStick
            // 
            this.LabLeftStick.AutoSize = true;
            this.LabLeftStick.Location = new System.Drawing.Point(8, 76);
            this.LabLeftStick.Name = "LabLeftStick";
            this.LabLeftStick.Size = new System.Drawing.Size(59, 12);
            this.LabLeftStick.TabIndex = 24;
            this.LabLeftStick.Text = "LeftStick";
            // 
            // LabLeftStickClick
            // 
            this.LabLeftStickClick.AutoSize = true;
            this.LabLeftStickClick.Location = new System.Drawing.Point(75, 164);
            this.LabLeftStickClick.Name = "LabLeftStickClick";
            this.LabLeftStickClick.Size = new System.Drawing.Size(35, 12);
            this.LabLeftStickClick.TabIndex = 25;
            this.LabLeftStickClick.Text = "Click";
            // 
            // LabLeftStickDown
            // 
            this.LabLeftStickDown.AutoSize = true;
            this.LabLeftStickDown.Location = new System.Drawing.Point(72, 228);
            this.LabLeftStickDown.Name = "LabLeftStickDown";
            this.LabLeftStickDown.Size = new System.Drawing.Size(29, 12);
            this.LabLeftStickDown.TabIndex = 26;
            this.LabLeftStickDown.Text = "Down";
            // 
            // LabLeftStickRight
            // 
            this.LabLeftStickRight.AutoSize = true;
            this.LabLeftStickRight.Location = new System.Drawing.Point(128, 164);
            this.LabLeftStickRight.Name = "LabLeftStickRight";
            this.LabLeftStickRight.Size = new System.Drawing.Size(35, 12);
            this.LabLeftStickRight.TabIndex = 27;
            this.LabLeftStickRight.Text = "Right";
            // 
            // LabLeftStickLeft
            // 
            this.LabLeftStickLeft.AutoSize = true;
            this.LabLeftStickLeft.Location = new System.Drawing.Point(20, 164);
            this.LabLeftStickLeft.Name = "LabLeftStickLeft";
            this.LabLeftStickLeft.Size = new System.Drawing.Size(29, 12);
            this.LabLeftStickLeft.TabIndex = 28;
            this.LabLeftStickLeft.Text = "Left";
            // 
            // LabLeftStickTrigger
            // 
            this.LabLeftStickTrigger.AutoSize = true;
            this.LabLeftStickTrigger.Location = new System.Drawing.Point(10, 97);
            this.LabLeftStickTrigger.Name = "LabLeftStickTrigger";
            this.LabLeftStickTrigger.Size = new System.Drawing.Size(47, 12);
            this.LabLeftStickTrigger.TabIndex = 29;
            this.LabLeftStickTrigger.Text = "Trigger";
            // 
            // LabLeftStickShoulder
            // 
            this.LabLeftStickShoulder.AutoSize = true;
            this.LabLeftStickShoulder.Location = new System.Drawing.Point(119, 97);
            this.LabLeftStickShoulder.Name = "LabLeftStickShoulder";
            this.LabLeftStickShoulder.Size = new System.Drawing.Size(53, 12);
            this.LabLeftStickShoulder.TabIndex = 30;
            this.LabLeftStickShoulder.Text = "Shoulder";
            // 
            // LabRightStickShoulder
            // 
            this.LabRightStickShoulder.AutoSize = true;
            this.LabRightStickShoulder.Location = new System.Drawing.Point(448, 98);
            this.LabRightStickShoulder.Name = "LabRightStickShoulder";
            this.LabRightStickShoulder.Size = new System.Drawing.Size(53, 12);
            this.LabRightStickShoulder.TabIndex = 45;
            this.LabRightStickShoulder.Text = "Shoulder";
            // 
            // LabRightStickTrigger
            // 
            this.LabRightStickTrigger.AutoSize = true;
            this.LabRightStickTrigger.Location = new System.Drawing.Point(344, 98);
            this.LabRightStickTrigger.Name = "LabRightStickTrigger";
            this.LabRightStickTrigger.Size = new System.Drawing.Size(47, 12);
            this.LabRightStickTrigger.TabIndex = 44;
            this.LabRightStickTrigger.Text = "Trigger";
            // 
            // LabRightStickLeft
            // 
            this.LabRightStickLeft.AutoSize = true;
            this.LabRightStickLeft.Location = new System.Drawing.Point(352, 164);
            this.LabRightStickLeft.Name = "LabRightStickLeft";
            this.LabRightStickLeft.Size = new System.Drawing.Size(29, 12);
            this.LabRightStickLeft.TabIndex = 43;
            this.LabRightStickLeft.Text = "Left";
            // 
            // LabRightStickRight
            // 
            this.LabRightStickRight.AutoSize = true;
            this.LabRightStickRight.Location = new System.Drawing.Point(455, 163);
            this.LabRightStickRight.Name = "LabRightStickRight";
            this.LabRightStickRight.Size = new System.Drawing.Size(35, 12);
            this.LabRightStickRight.TabIndex = 42;
            this.LabRightStickRight.Text = "Right";
            // 
            // LabRightStickDown
            // 
            this.LabRightStickDown.AutoSize = true;
            this.LabRightStickDown.Location = new System.Drawing.Point(405, 224);
            this.LabRightStickDown.Name = "LabRightStickDown";
            this.LabRightStickDown.Size = new System.Drawing.Size(29, 12);
            this.LabRightStickDown.TabIndex = 41;
            this.LabRightStickDown.Text = "Down";
            // 
            // LabRightStickClick
            // 
            this.LabRightStickClick.AutoSize = true;
            this.LabRightStickClick.Location = new System.Drawing.Point(402, 164);
            this.LabRightStickClick.Name = "LabRightStickClick";
            this.LabRightStickClick.Size = new System.Drawing.Size(35, 12);
            this.LabRightStickClick.TabIndex = 40;
            this.LabRightStickClick.Text = "Click";
            // 
            // LabRightStick
            // 
            this.LabRightStick.AutoSize = true;
            this.LabRightStick.Location = new System.Drawing.Point(338, 82);
            this.LabRightStick.Name = "LabRightStick";
            this.LabRightStick.Size = new System.Drawing.Size(65, 12);
            this.LabRightStick.TabIndex = 39;
            this.LabRightStick.Text = "RightStick";
            // 
            // ButRightStickLeft
            // 
            this.ButRightStickLeft.Location = new System.Drawing.Point(340, 175);
            this.ButRightStickLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickLeft.Name = "ButRightStickLeft";
            this.ButRightStickLeft.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickLeft.TabIndex = 38;
            this.ButRightStickLeft.Text = "None";
            this.ButRightStickLeft.UseVisualStyleBackColor = true;
            this.ButRightStickLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickLeft_KeyDown);
            // 
            // ButRightStickShoulder
            // 
            this.ButRightStickShoulder.Location = new System.Drawing.Point(450, 111);
            this.ButRightStickShoulder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickShoulder.Name = "ButRightStickShoulder";
            this.ButRightStickShoulder.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickShoulder.TabIndex = 37;
            this.ButRightStickShoulder.Text = "None";
            this.ButRightStickShoulder.UseVisualStyleBackColor = true;
            this.ButRightStickShoulder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickShoulder_KeyDown);
            // 
            // ButRightStickTrigger
            // 
            this.ButRightStickTrigger.Location = new System.Drawing.Point(341, 112);
            this.ButRightStickTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickTrigger.Name = "ButRightStickTrigger";
            this.ButRightStickTrigger.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickTrigger.TabIndex = 36;
            this.ButRightStickTrigger.Text = "None";
            this.ButRightStickTrigger.UseVisualStyleBackColor = true;
            this.ButRightStickTrigger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickTrigger_KeyDown);
            // 
            // ButRightStickRight
            // 
            this.ButRightStickRight.Location = new System.Drawing.Point(450, 175);
            this.ButRightStickRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickRight.Name = "ButRightStickRight";
            this.ButRightStickRight.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickRight.TabIndex = 35;
            this.ButRightStickRight.Text = "None";
            this.ButRightStickRight.UseVisualStyleBackColor = true;
            this.ButRightStickRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickRight_KeyDown);
            // 
            // ButRightStickDown
            // 
            this.ButRightStickDown.Location = new System.Drawing.Point(394, 238);
            this.ButRightStickDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickDown.Name = "ButRightStickDown";
            this.ButRightStickDown.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickDown.TabIndex = 34;
            this.ButRightStickDown.Text = "Down";
            this.ButRightStickDown.UseVisualStyleBackColor = true;
            this.ButRightStickDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickDown_KeyDown);
            // 
            // ButRightStickClick
            // 
            this.ButRightStickClick.Location = new System.Drawing.Point(394, 175);
            this.ButRightStickClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickClick.Name = "ButRightStickClick";
            this.ButRightStickClick.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickClick.TabIndex = 33;
            this.ButRightStickClick.Text = "None";
            this.ButRightStickClick.UseVisualStyleBackColor = true;
            this.ButRightStickClick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickClick_KeyDown);
            // 
            // LabRightStickUp
            // 
            this.LabRightStickUp.AutoSize = true;
            this.LabRightStickUp.Location = new System.Drawing.Point(410, 98);
            this.LabRightStickUp.Name = "LabRightStickUp";
            this.LabRightStickUp.Size = new System.Drawing.Size(17, 12);
            this.LabRightStickUp.TabIndex = 32;
            this.LabRightStickUp.Text = "Up";
            // 
            // ButRightStickUp
            // 
            this.ButRightStickUp.Location = new System.Drawing.Point(394, 112);
            this.ButRightStickUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRightStickUp.Name = "ButRightStickUp";
            this.ButRightStickUp.Size = new System.Drawing.Size(50, 50);
            this.ButRightStickUp.TabIndex = 31;
            this.ButRightStickUp.Text = "None";
            this.ButRightStickUp.UseVisualStyleBackColor = true;
            this.ButRightStickUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButRightStickUp_KeyDown);
            // 
            // LabFormOpacity
            // 
            this.LabFormOpacity.AutoSize = true;
            this.LabFormOpacity.Location = new System.Drawing.Point(253, 16);
            this.LabFormOpacity.Name = "LabFormOpacity";
            this.LabFormOpacity.Size = new System.Drawing.Size(47, 12);
            this.LabFormOpacity.TabIndex = 46;
            this.LabFormOpacity.Text = "Opacity";
            // 
            // ButDPadUp
            // 
            this.ButDPadUp.Location = new System.Drawing.Point(232, 111);
            this.ButDPadUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButDPadUp.Name = "ButDPadUp";
            this.ButDPadUp.Size = new System.Drawing.Size(50, 50);
            this.ButDPadUp.TabIndex = 47;
            this.ButDPadUp.Text = "None";
            this.ButDPadUp.UseVisualStyleBackColor = true;
            this.ButDPadUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButDPadUp_KeyDown);
            // 
            // ButDPadLeft
            // 
            this.ButDPadLeft.Location = new System.Drawing.Point(178, 175);
            this.ButDPadLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButDPadLeft.Name = "ButDPadLeft";
            this.ButDPadLeft.Size = new System.Drawing.Size(50, 50);
            this.ButDPadLeft.TabIndex = 48;
            this.ButDPadLeft.Text = "None";
            this.ButDPadLeft.UseVisualStyleBackColor = true;
            this.ButDPadLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButDPadLeft_KeyDown);
            // 
            // ButDPadDown
            // 
            this.ButDPadDown.Location = new System.Drawing.Point(234, 238);
            this.ButDPadDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButDPadDown.Name = "ButDPadDown";
            this.ButDPadDown.Size = new System.Drawing.Size(50, 50);
            this.ButDPadDown.TabIndex = 49;
            this.ButDPadDown.Text = "None";
            this.ButDPadDown.UseVisualStyleBackColor = true;
            this.ButDPadDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButDPadDown_KeyDown);
            // 
            // ButDPadRight
            // 
            this.ButDPadRight.Location = new System.Drawing.Point(284, 175);
            this.ButDPadRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButDPadRight.Name = "ButDPadRight";
            this.ButDPadRight.Size = new System.Drawing.Size(50, 50);
            this.ButDPadRight.TabIndex = 50;
            this.ButDPadRight.Text = "None";
            this.ButDPadRight.UseVisualStyleBackColor = true;
            this.ButDPadRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButDPadRight_KeyDown);
            // 
            // LabDPad
            // 
            this.LabDPad.AutoSize = true;
            this.LabDPad.Location = new System.Drawing.Point(185, 82);
            this.LabDPad.Name = "LabDPad";
            this.LabDPad.Size = new System.Drawing.Size(29, 12);
            this.LabDPad.TabIndex = 51;
            this.LabDPad.Text = "DPad";
            // 
            // LabDPadUp
            // 
            this.LabDPadUp.AutoSize = true;
            this.LabDPadUp.Location = new System.Drawing.Point(248, 97);
            this.LabDPadUp.Name = "LabDPadUp";
            this.LabDPadUp.Size = new System.Drawing.Size(17, 12);
            this.LabDPadUp.TabIndex = 52;
            this.LabDPadUp.Text = "Up";
            // 
            // LabDPadRight
            // 
            this.LabDPadRight.AutoSize = true;
            this.LabDPadRight.Location = new System.Drawing.Point(292, 161);
            this.LabDPadRight.Name = "LabDPadRight";
            this.LabDPadRight.Size = new System.Drawing.Size(35, 12);
            this.LabDPadRight.TabIndex = 53;
            this.LabDPadRight.Text = "Right";
            // 
            // LabDPadDown
            // 
            this.LabDPadDown.AutoSize = true;
            this.LabDPadDown.Location = new System.Drawing.Point(238, 224);
            this.LabDPadDown.Name = "LabDPadDown";
            this.LabDPadDown.Size = new System.Drawing.Size(29, 12);
            this.LabDPadDown.TabIndex = 54;
            this.LabDPadDown.Text = "Down";
            // 
            // LabDPadLeft
            // 
            this.LabDPadLeft.AutoSize = true;
            this.LabDPadLeft.Location = new System.Drawing.Point(187, 161);
            this.LabDPadLeft.Name = "LabDPadLeft";
            this.LabDPadLeft.Size = new System.Drawing.Size(29, 12);
            this.LabDPadLeft.TabIndex = 55;
            this.LabDPadLeft.Text = "Left";
            // 
            // LabABXYX
            // 
            this.LabABXYX.AutoSize = true;
            this.LabABXYX.Location = new System.Drawing.Point(528, 160);
            this.LabABXYX.Name = "LabABXYX";
            this.LabABXYX.Size = new System.Drawing.Size(11, 12);
            this.LabABXYX.TabIndex = 64;
            this.LabABXYX.Text = "X";
            // 
            // LabABXYB
            // 
            this.LabABXYB.AutoSize = true;
            this.LabABXYB.Location = new System.Drawing.Point(584, 224);
            this.LabABXYB.Name = "LabABXYB";
            this.LabABXYB.Size = new System.Drawing.Size(11, 12);
            this.LabABXYB.TabIndex = 63;
            this.LabABXYB.Text = "B";
            // 
            // LabABXYA
            // 
            this.LabABXYA.AutoSize = true;
            this.LabABXYA.Location = new System.Drawing.Point(642, 163);
            this.LabABXYA.Name = "LabABXYA";
            this.LabABXYA.Size = new System.Drawing.Size(11, 12);
            this.LabABXYA.TabIndex = 62;
            this.LabABXYA.Text = "A";
            // 
            // LabABXYY
            // 
            this.LabABXYY.AutoSize = true;
            this.LabABXYY.Location = new System.Drawing.Point(584, 111);
            this.LabABXYY.Name = "LabABXYY";
            this.LabABXYY.Size = new System.Drawing.Size(11, 12);
            this.LabABXYY.TabIndex = 61;
            this.LabABXYY.Text = "Y";
            // 
            // LabABXY
            // 
            this.LabABXY.AutoSize = true;
            this.LabABXY.Location = new System.Drawing.Point(506, 82);
            this.LabABXY.Name = "LabABXY";
            this.LabABXY.Size = new System.Drawing.Size(29, 12);
            this.LabABXY.TabIndex = 60;
            this.LabABXY.Text = "ABXY";
            // 
            // ButABXYA
            // 
            this.ButABXYA.Location = new System.Drawing.Point(618, 180);
            this.ButABXYA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButABXYA.Name = "ButABXYA";
            this.ButABXYA.Size = new System.Drawing.Size(50, 50);
            this.ButABXYA.TabIndex = 59;
            this.ButABXYA.Text = "None";
            this.ButABXYA.UseVisualStyleBackColor = true;
            this.ButABXYA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButABXYA_KeyDown);
            // 
            // ButABXYB
            // 
            this.ButABXYB.Location = new System.Drawing.Point(564, 238);
            this.ButABXYB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButABXYB.Name = "ButABXYB";
            this.ButABXYB.Size = new System.Drawing.Size(50, 50);
            this.ButABXYB.TabIndex = 58;
            this.ButABXYB.Text = "None";
            this.ButABXYB.UseVisualStyleBackColor = true;
            this.ButABXYB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButABXYB_KeyDown);
            // 
            // ButABXYX
            // 
            this.ButABXYX.Location = new System.Drawing.Point(508, 175);
            this.ButABXYX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButABXYX.Name = "ButABXYX";
            this.ButABXYX.Size = new System.Drawing.Size(50, 50);
            this.ButABXYX.TabIndex = 57;
            this.ButABXYX.Text = "None";
            this.ButABXYX.UseVisualStyleBackColor = true;
            this.ButABXYX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButABXYX_KeyDown);
            // 
            // ButABXYY
            // 
            this.ButABXYY.Location = new System.Drawing.Point(564, 125);
            this.ButABXYY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButABXYY.Name = "ButABXYY";
            this.ButABXYY.Size = new System.Drawing.Size(50, 50);
            this.ButABXYY.TabIndex = 56;
            this.ButABXYY.Text = "None";
            this.ButABXYY.UseVisualStyleBackColor = true;
            this.ButABXYY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButABXYY_KeyDown);
            // 
            // LabMenu
            // 
            this.LabMenu.AutoSize = true;
            this.LabMenu.Location = new System.Drawing.Point(8, 291);
            this.LabMenu.Name = "LabMenu";
            this.LabMenu.Size = new System.Drawing.Size(29, 12);
            this.LabMenu.TabIndex = 65;
            this.LabMenu.Text = "Menu";
            // 
            // ButMenuStart
            // 
            this.ButMenuStart.Location = new System.Drawing.Point(10, 317);
            this.ButMenuStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMenuStart.Name = "ButMenuStart";
            this.ButMenuStart.Size = new System.Drawing.Size(50, 50);
            this.ButMenuStart.TabIndex = 66;
            this.ButMenuStart.Text = "None";
            this.ButMenuStart.UseVisualStyleBackColor = true;
            this.ButMenuStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButMenuStart_KeyDown);
            // 
            // ButMenuBack
            // 
            this.ButMenuBack.Location = new System.Drawing.Point(68, 317);
            this.ButMenuBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMenuBack.Name = "ButMenuBack";
            this.ButMenuBack.Size = new System.Drawing.Size(50, 50);
            this.ButMenuBack.TabIndex = 67;
            this.ButMenuBack.Text = "None";
            this.ButMenuBack.UseVisualStyleBackColor = true;
            this.ButMenuBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButMenuBack_KeyDown);
            // 
            // ButMenuGuide
            // 
            this.ButMenuGuide.Location = new System.Drawing.Point(124, 317);
            this.ButMenuGuide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMenuGuide.Name = "ButMenuGuide";
            this.ButMenuGuide.Size = new System.Drawing.Size(50, 50);
            this.ButMenuGuide.TabIndex = 68;
            this.ButMenuGuide.Text = "None";
            this.ButMenuGuide.UseVisualStyleBackColor = true;
            this.ButMenuGuide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButMenuGuide_KeyDown);
            // 
            // LabMenuStart
            // 
            this.LabMenuStart.AutoSize = true;
            this.LabMenuStart.Location = new System.Drawing.Point(8, 305);
            this.LabMenuStart.Name = "LabMenuStart";
            this.LabMenuStart.Size = new System.Drawing.Size(35, 12);
            this.LabMenuStart.TabIndex = 69;
            this.LabMenuStart.Text = "Start";
            // 
            // LabMenuBack
            // 
            this.LabMenuBack.AutoSize = true;
            this.LabMenuBack.Location = new System.Drawing.Point(75, 303);
            this.LabMenuBack.Name = "LabMenuBack";
            this.LabMenuBack.Size = new System.Drawing.Size(29, 12);
            this.LabMenuBack.TabIndex = 70;
            this.LabMenuBack.Text = "Back";
            // 
            // LabMenuGuide
            // 
            this.LabMenuGuide.AutoSize = true;
            this.LabMenuGuide.Location = new System.Drawing.Point(128, 305);
            this.LabMenuGuide.Name = "LabMenuGuide";
            this.LabMenuGuide.Size = new System.Drawing.Size(35, 12);
            this.LabMenuGuide.TabIndex = 71;
            this.LabMenuGuide.Text = "Guide";
            // 
            // CheBoxLeftStickMouse
            // 
            this.CheBoxLeftStickMouse.AutoSize = true;
            this.CheBoxLeftStickMouse.Location = new System.Drawing.Point(117, 78);
            this.CheBoxLeftStickMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheBoxLeftStickMouse.Name = "CheBoxLeftStickMouse";
            this.CheBoxLeftStickMouse.Size = new System.Drawing.Size(54, 16);
            this.CheBoxLeftStickMouse.TabIndex = 72;
            this.CheBoxLeftStickMouse.Text = "Mouse";
            this.CheBoxLeftStickMouse.UseVisualStyleBackColor = true;
            this.CheBoxLeftStickMouse.CheckedChanged += new System.EventHandler(this.CheBoxLeftStickMouse_CheckedChanged);
            // 
            // CheBoxRightStickMouse
            // 
            this.CheBoxRightStickMouse.AutoSize = true;
            this.CheBoxRightStickMouse.Location = new System.Drawing.Point(446, 78);
            this.CheBoxRightStickMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheBoxRightStickMouse.Name = "CheBoxRightStickMouse";
            this.CheBoxRightStickMouse.Size = new System.Drawing.Size(54, 16);
            this.CheBoxRightStickMouse.TabIndex = 73;
            this.CheBoxRightStickMouse.Text = "Mouse";
            this.CheBoxRightStickMouse.UseVisualStyleBackColor = true;
            this.CheBoxRightStickMouse.CheckedChanged += new System.EventHandler(this.CheBoxRightStickMouse_CheckedChanged);
            // 
            // LabTip
            // 
            this.LabTip.AutoSize = true;
            this.LabTip.Location = new System.Drawing.Point(183, 355);
            this.LabTip.Name = "LabTip";
            this.LabTip.Size = new System.Drawing.Size(485, 12);
            this.LabTip.TabIndex = 74;
            this.LabTip.Text = "提示：勾选Mouse的时候，快捷键是F12，需要键盘按组合键Alt+Tab聚焦到此窗口上再按F12";
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(586, 50);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 75;
            this.ButSave.Text = "Save";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Location = new System.Drawing.Point(253, 53);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(35, 12);
            this.LabName.TabIndex = 78;
            this.LabName.Text = "Name:";
            // 
            // ComboLoad
            // 
            this.ComboLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLoad.FormattingEnabled = true;
            this.ComboLoad.Location = new System.Drawing.Point(294, 50);
            this.ComboLoad.Name = "ComboLoad";
            this.ComboLoad.Size = new System.Drawing.Size(109, 20);
            this.ComboLoad.TabIndex = 79;
            // 
            // ButLoad
            // 
            this.ButLoad.Location = new System.Drawing.Point(667, 51);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(75, 23);
            this.ButLoad.TabIndex = 80;
            this.ButLoad.Text = "Load";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // TexName
            // 
            this.TexName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexName.Location = new System.Drawing.Point(490, 51);
            this.TexName.Name = "TexName";
            this.TexName.Size = new System.Drawing.Size(90, 21);
            this.TexName.TabIndex = 81;
            // 
            // LabRename
            // 
            this.LabRename.AutoSize = true;
            this.LabRename.Location = new System.Drawing.Point(653, 82);
            this.LabRename.Name = "LabRename";
            this.LabRename.Size = new System.Drawing.Size(89, 12);
            this.LabRename.TabIndex = 82;
            this.LabRename.Text = "请输入文件名！";
            this.LabRename.Visible = false;
            // 
            // ButDelete
            // 
            this.ButDelete.Location = new System.Drawing.Point(409, 50);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(75, 23);
            this.ButDelete.TabIndex = 83;
            this.ButDelete.Text = "Delete";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 376);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.LabRename);
            this.Controls.Add(this.TexName);
            this.Controls.Add(this.ButLoad);
            this.Controls.Add(this.ComboLoad);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.LabTip);
            this.Controls.Add(this.CheBoxRightStickMouse);
            this.Controls.Add(this.CheBoxLeftStickMouse);
            this.Controls.Add(this.LabMenuGuide);
            this.Controls.Add(this.LabMenuBack);
            this.Controls.Add(this.LabMenuStart);
            this.Controls.Add(this.ButMenuGuide);
            this.Controls.Add(this.ButMenuBack);
            this.Controls.Add(this.ButMenuStart);
            this.Controls.Add(this.LabMenu);
            this.Controls.Add(this.LabABXYX);
            this.Controls.Add(this.LabABXYB);
            this.Controls.Add(this.LabABXYA);
            this.Controls.Add(this.LabABXYY);
            this.Controls.Add(this.LabABXY);
            this.Controls.Add(this.ButABXYA);
            this.Controls.Add(this.ButABXYB);
            this.Controls.Add(this.ButABXYX);
            this.Controls.Add(this.ButABXYY);
            this.Controls.Add(this.LabDPadLeft);
            this.Controls.Add(this.LabDPadDown);
            this.Controls.Add(this.LabDPadRight);
            this.Controls.Add(this.LabDPadUp);
            this.Controls.Add(this.LabDPad);
            this.Controls.Add(this.ButDPadRight);
            this.Controls.Add(this.ButDPadDown);
            this.Controls.Add(this.ButDPadLeft);
            this.Controls.Add(this.ButDPadUp);
            this.Controls.Add(this.LabFormOpacity);
            this.Controls.Add(this.LabRightStickShoulder);
            this.Controls.Add(this.LabRightStickTrigger);
            this.Controls.Add(this.LabRightStickLeft);
            this.Controls.Add(this.LabRightStickRight);
            this.Controls.Add(this.LabRightStickDown);
            this.Controls.Add(this.LabRightStickClick);
            this.Controls.Add(this.LabRightStick);
            this.Controls.Add(this.ButRightStickLeft);
            this.Controls.Add(this.ButRightStickShoulder);
            this.Controls.Add(this.ButRightStickTrigger);
            this.Controls.Add(this.ButRightStickRight);
            this.Controls.Add(this.ButRightStickDown);
            this.Controls.Add(this.ButRightStickClick);
            this.Controls.Add(this.LabRightStickUp);
            this.Controls.Add(this.ButRightStickUp);
            this.Controls.Add(this.LabLeftStickShoulder);
            this.Controls.Add(this.LabLeftStickTrigger);
            this.Controls.Add(this.LabLeftStickLeft);
            this.Controls.Add(this.LabLeftStickRight);
            this.Controls.Add(this.LabLeftStickDown);
            this.Controls.Add(this.LabLeftStickClick);
            this.Controls.Add(this.LabLeftStick);
            this.Controls.Add(this.ButLeftStickLeft);
            this.Controls.Add(this.ButLeftStickShoulder);
            this.Controls.Add(this.ButLeftStickTrigger);
            this.Controls.Add(this.ButLeftStickRight);
            this.Controls.Add(this.ButLeftStickDown);
            this.Controls.Add(this.ButLeftStickClick);
            this.Controls.Add(this.LabLeftStickUp);
            this.Controls.Add(this.ButLeftStickUp);
            this.Controls.Add(this.TbOpacity);
            this.Controls.Add(this.ButStop);
            this.Controls.Add(this.ButStart);
            this.Controls.Add(this.ButUnPlugAll);
            this.Controls.Add(this.ButUnplug);
            this.Controls.Add(this.ButPlugIn);
            this.Controls.Add(this.LabControllerNumber);
            this.Controls.Add(this.ComboControllerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "KeyToJoy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TbOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboControllerNumber;
        private System.Windows.Forms.Label LabControllerNumber;
        private System.Windows.Forms.Button ButPlugIn;
        private System.Windows.Forms.Button ButUnplug;
        private System.Windows.Forms.Button ButUnPlugAll;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.Button ButStop;
        private System.Windows.Forms.TrackBar TbOpacity;
        private System.Windows.Forms.Button ButLeftStickUp;
        private System.Windows.Forms.Label LabLeftStickUp;
        private System.Windows.Forms.Button ButLeftStickClick;
        private System.Windows.Forms.Button ButLeftStickDown;
        private System.Windows.Forms.Button ButLeftStickRight;
        private System.Windows.Forms.Button ButLeftStickTrigger;
        private System.Windows.Forms.Button ButLeftStickShoulder;
        private System.Windows.Forms.Button ButLeftStickLeft;
        private System.Windows.Forms.Label LabLeftStick;
        private System.Windows.Forms.Label LabLeftStickClick;
        private System.Windows.Forms.Label LabLeftStickDown;
        private System.Windows.Forms.Label LabLeftStickRight;
        private System.Windows.Forms.Label LabLeftStickLeft;
        private System.Windows.Forms.Label LabLeftStickTrigger;
        private System.Windows.Forms.Label LabLeftStickShoulder;
        private System.Windows.Forms.Label LabRightStickShoulder;
        private System.Windows.Forms.Label LabRightStickTrigger;
        private System.Windows.Forms.Label LabRightStickLeft;
        private System.Windows.Forms.Label LabRightStickRight;
        private System.Windows.Forms.Label LabRightStickDown;
        private System.Windows.Forms.Label LabRightStickClick;
        private System.Windows.Forms.Label LabRightStick;
        private System.Windows.Forms.Button ButRightStickLeft;
        private System.Windows.Forms.Button ButRightStickShoulder;
        private System.Windows.Forms.Button ButRightStickTrigger;
        private System.Windows.Forms.Button ButRightStickRight;
        private System.Windows.Forms.Button ButRightStickDown;
        private System.Windows.Forms.Button ButRightStickClick;
        private System.Windows.Forms.Label LabRightStickUp;
        private System.Windows.Forms.Button ButRightStickUp;
        private System.Windows.Forms.Label LabFormOpacity;
        private System.Windows.Forms.Button ButDPadUp;
        private System.Windows.Forms.Button ButDPadLeft;
        private System.Windows.Forms.Button ButDPadDown;
        private System.Windows.Forms.Button ButDPadRight;
        private System.Windows.Forms.Label LabDPad;
        private System.Windows.Forms.Label LabDPadUp;
        private System.Windows.Forms.Label LabDPadRight;
        private System.Windows.Forms.Label LabDPadDown;
        private System.Windows.Forms.Label LabDPadLeft;
        private System.Windows.Forms.Label LabABXYX;
        private System.Windows.Forms.Label LabABXYB;
        private System.Windows.Forms.Label LabABXYA;
        private System.Windows.Forms.Label LabABXYY;
        private System.Windows.Forms.Label LabABXY;
        private System.Windows.Forms.Button ButABXYA;
        private System.Windows.Forms.Button ButABXYB;
        private System.Windows.Forms.Button ButABXYX;
        private System.Windows.Forms.Button ButABXYY;
        private System.Windows.Forms.Label LabMenu;
        private System.Windows.Forms.Button ButMenuStart;
        private System.Windows.Forms.Button ButMenuBack;
        private System.Windows.Forms.Button ButMenuGuide;
        private System.Windows.Forms.Label LabMenuStart;
        private System.Windows.Forms.Label LabMenuBack;
        private System.Windows.Forms.Label LabMenuGuide;
        private System.Windows.Forms.CheckBox CheBoxLeftStickMouse;
        private System.Windows.Forms.CheckBox CheBoxRightStickMouse;
        private System.Windows.Forms.Label LabTip;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.ComboBox ComboLoad;
        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.TextBox TexName;
        private System.Windows.Forms.Label LabRename;
        private System.Windows.Forms.Button ButDelete;
    }
}
