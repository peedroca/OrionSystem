using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class ClientFormControl : UserControl
    {
        public ClientFormControl()
        {
            InitializeComponent();
        }

        private void analyzesButton_Click(object sender, EventArgs e)
        {
            AnalyzeClientForm form = new AnalyzeClientForm();
            form.ShowDialog();
        }
    }
}
