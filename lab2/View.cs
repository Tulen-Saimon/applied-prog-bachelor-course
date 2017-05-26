using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labar2
{
    public partial class View : Form
    {
        Controller controller = new Controller();
        public View()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")  
                MessageBox.Show(controller.Question(textBox2.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
