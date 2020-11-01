using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class RandomCorlorChanging : Form
    {
        public RandomCorlorChanging()
        {
            InitializeComponent();
            
        }

        private void button_ChangeColor_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int R, G, B;
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);

            BackColor = Color.FromArgb(R, G, B); 
        }

      
    }
}
