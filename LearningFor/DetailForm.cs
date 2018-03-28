using Learning.ClassLibrary;
using LearningFor.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningFor
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = "56";
        }
        public void GetInfo(object sender, TransferInfoEvetargs e)
        {
            this.idTextBox.Text = e.Info;
        }
    }
}
