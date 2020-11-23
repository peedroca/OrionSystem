using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sirius.Desktop.Controllers;
using System.Collections;
using Sirius.Desktop.Models;
using Sirius.Service;
using Sirius.Domain.Interfaces;
using Sirius.Desktop.Extesions;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sirius.Desktop.Views
{
    public partial class ChartFormControl : UserControl
    {
        CostomerController CostomerController;
        CompanyController CompanyController;
        SmartContractController SmartContractController;
        SmartContractViews ContractViews = new SmartContractViews();
        private ISmartContractService smartContractService;
        private CompanyView CompanyView;

        public ChartFormControl()
        {
            InitializeComponent();

        }        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartFormControl_Load(object sender, EventArgs e)
        {
            CostomerController = new CostomerController();
            CompanyController = new CompanyController();
            SmartContractController = new SmartContractController();
            ContractViews = new SmartContractViews();
            ChartClient();
            
        }

        private void ChartClient(string fristName = null, long id = 0)
        {
            ArrayList customerArray = new ArrayList();
            
            var customersRequested = CostomerController.GetCustomerRequests(id , fristName);
            var customers = CostomerController.GetCustomer(id, fristName);

            int quantityRequested = customersRequested.Count(c => c.costumerRefusal == null);
            int quantityConfirmed = customers.Count();
            int quantityRefused = customersRequested.Count(c => c.costumerRefusal != null);

            if (customersRequested != null)
                customerArray.Add(quantityRequested);               

            if(customers != null)
                customerArray.Add(quantityConfirmed);

            chart1.Series[0].Points.DataBindY(customerArray);
            GenerateChart(quantityConfirmed, quantityRequested, quantityRefused);
        }

        private void GenerateChart(int quantityConfirmed, int quantityRequested, int quantityRefused)
        {
            chart2.Series["Em analise"].Points.AddXY("CLIENTES", quantityRequested);
            chart2.Series["Aceitos"].Points.AddXY("CLIENTES", quantityConfirmed);
            chart2.Series["Recusados"].Points.AddXY("CLIENTES", quantityRefused);
        }

        private double f(int i)
        {
            var f1 = 59894 - (8128 * i) + (262 * i * i) - (1.6 * i * i * i);
            return f1;
        }
    }
}
