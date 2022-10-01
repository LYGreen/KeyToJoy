using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyStick_000
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ComboMouse.Items.Add("Left");
            ComboMouse.Items.Add("Right");
            ComboMouse.Items.Add("Middle");
            ComboMouse.Items.Add("XButton1");
            ComboMouse.Items.Add("XButton2");
            ComboMouse.SelectedIndex = 0;
            this.DialogResult = DialogResult.None;
        }

        private void ButOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
