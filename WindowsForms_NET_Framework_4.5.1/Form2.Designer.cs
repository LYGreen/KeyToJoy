namespace JoyStick_000
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButOK = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.LabMSG1 = new System.Windows.Forms.Label();
            this.ComboMouse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(139, 24);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(75, 23);
            this.ButOK.TabIndex = 0;
            this.ButOK.Text = "OK";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(220, 24);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 1;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // LabMSG1
            // 
            this.LabMSG1.AutoSize = true;
            this.LabMSG1.Location = new System.Drawing.Point(12, 9);
            this.LabMSG1.Name = "LabMSG1";
            this.LabMSG1.Size = new System.Drawing.Size(41, 12);
            this.LabMSG1.TabIndex = 2;
            this.LabMSG1.Text = "鼠标：";
            // 
            // ComboMouse
            // 
            this.ComboMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMouse.FormattingEnabled = true;
            this.ComboMouse.Location = new System.Drawing.Point(12, 24);
            this.ComboMouse.Name = "ComboMouse";
            this.ComboMouse.Size = new System.Drawing.Size(121, 20);
            this.ComboMouse.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 124);
            this.Controls.Add(this.ComboMouse);
            this.Controls.Add(this.LabMSG1);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButOK;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Label LabMSG1;
        public System.Windows.Forms.ComboBox ComboMouse;
    }
}