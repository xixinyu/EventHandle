using LearningFor.ClassLibrary;
using System;
using System.Windows.Forms;

namespace LearningFor
{
    public partial class MenuTreeForm : Form
    {
        public EventHandler<TransferInfoEvetargs> TransferInfo;
        public MenuTreeForm()
        {
            InitializeComponent();

        }


        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void MenuTreeForm_Load(object sender, EventArgs e)
        {
           
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            EventHandler<TransferInfoEvetargs> transferInfo = TransferInfo;
            if (transferInfo != null)
            {
                transferInfo(this, new TransferInfoEvetargs("info"));
            }
        }
    }
}
