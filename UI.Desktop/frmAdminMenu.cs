using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void especialidadesButton_Click(object sender, EventArgs e)
        {
            specialityList specialityList = new specialityList();
            specialityList.ShowDialog();
        }

        private void planesButton_Click(object sender, EventArgs e)
        {
            plansList plansList = new plansList();
            plansList.ShowDialog();
        }

        private void comisionesButton_Click(object sender, EventArgs e)
        {
            comissionsList comissionsList = new comissionsList();
            comissionsList.ShowDialog();
        }

    }
}
