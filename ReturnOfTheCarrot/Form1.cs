using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnOfTheCarrot
{
    public partial class Form1 : Form
    {
        private List<Keys> _KeysPressed = new List<Keys>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tbHotKey_KeyUp(object sender, KeyEventArgs e)
        {
           
            e.Handled = true;
        }

        private void tbHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_KeysPressed.Contains(e.KeyCode))
            {
                _KeysPressed.Add(e.KeyCode);
                PrintKeys();
                e.Handled = true;
            }
        }

        private void PrintKeys()
        {
            tbHotKey.Text = string.Join("+", _KeysPressed);
        }

    }
}
