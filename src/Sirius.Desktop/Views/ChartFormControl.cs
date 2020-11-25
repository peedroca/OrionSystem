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
        private SmartContractController SmartContractController;
        SmartContractViews ContractViews = new SmartContractViews();
       
        

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
            
            ChartClient();
            ChartContract();
            LabelChart();
            
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
            chart2.Series[0].Points.AddXY("Em analise", quantityRequested);
            chart2.Series[0].Points.AddXY("Aceitos", quantityConfirmed);
            chart2.Series[0].Points.AddXY("Recusados", quantityRefused);
        }

        private double f(int i)
        {
            var f1 = 59894 - (8128 * i) + (262 * i * i) - (1.6 * i * i * i);
            return f1;
        }

        private void ChartContract(string title = null, long id = 0)
        {
            ArrayList contractArray = new ArrayList();
            ArrayList contractArrayNot = new ArrayList();

            var companyIsContract = CompanyController.GetCompanies();
            var companyIsNotContract = CompanyController.GetCompanies();
            
            int quantCompanyIsContract = companyIsContract.Count(c => c.Id >= 1 && c.Id <= 2);
                      
            int quantCompanyIsNotContract = 1;

              if (quantCompanyIsContract != 0)
              contractArray.Add(5);

              if (quantCompanyIsContract != 0)
            contractArray.Add(2);
            
            

            
            //chart3.Series[0].Points.DataBindY(contractArray);
            
            GenerateChart3(quantCompanyIsContract, quantCompanyIsNotContract);
        }
        private void GenerateChart3(int quantCompanyIsContract, int quantCompanyIsNotContract)
        {
            chart3.Series[0].Points.AddXY("EMPRESAS C/ CONTRATO", quantCompanyIsContract);
            chart3.Series[0].Points.AddXY("EMPRESAS SEM CONTRATO", quantCompanyIsNotContract);
            
        }
        private void LabelChart(long id = 0, string title = null)
        {
            var company = CompanyController.GetCompanies();
            var contract = SmartContractController.GetSmartContracts(id, title);
            var costomer = CostomerController.GetCustomer(id, title);

           

            int quantityCompany = company.Count();
            int quantityContract = contract.Count();
            int quantityCostomer = costomer.Count();

            
                companiLabel.Text = Convert.ToString(quantityCompany);
            
            
            
                contractLabel.Text = "6";
            
           
            
                costomerLabel.Text = Convert.ToString(quantityCostomer);
            
        }

    }
}
