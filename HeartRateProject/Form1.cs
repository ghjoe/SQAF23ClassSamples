using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRate
{
    public partial class Form1 : Form
    {
        private Customer Customer { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // initialize customer based on GUI
            Customer = new Customer();
            UpdateCustomerFromGUI();

            CalculateOutputs();
            customerLB.Items.Add(Customer);
        }

        private void UpdateCustomerFromGUI()
        {
            Customer.FirstName = firstTB.Text;
            Customer.Active = activeCB.Checked;
            Customer.IsFemale = !femaleCB.Checked;
            Customer.Age = int.Parse(textBox1.Text);
            Customer.ActivityLevel = (ActivityLevel)activityLevelCB.SelectedIndex;
        }

        private bool ValidationSuccessful()
        {
            // Validate data entered
            if (firstTB.Text == string.Empty)
            {
                statusLbl.Text = "Add failed!  Please specify a valid name";
                return true;
            }
            return false;
        }

        private void CalculateOutputs()
        {
            // determine which formula to use and calculate MHR using this formula
            if (Customer.Active)
            {
                Customer.FormulaType = "Hunt";
                Customer.MHR = (int)(211 - .64 * Customer.Age);
            }
            else if (Customer.IsFemale)
            {
                Customer.FormulaType = "Galati";
                Customer.MHR = (int)(206 - .88 * Customer.Age);
            }
            else if (Customer.Age > 40)
            {
                Customer.FormulaType = "Tanuka";
                Customer.MHR = (int)(208 - .7 * Customer.Age);
            }
            else
            {
                Customer.FormulaType = "Fox";
                Customer.MHR = 220 - Customer.Age;
            }

            // update MHR textbox
            mhrTB.Text = Customer.MHR.ToString();

            // calculate target heart ranges base on activity level and MHR
            Customer.ActivityLevel = (ActivityLevel)activityLevelCB.SelectedIndex;
            if (Customer.ActivityLevel == ActivityLevel.SEDENTARY)
            {
                Customer.TargetMin = (int)(Customer.MHR * .57);
                Customer.TargetMax = (int)(Customer.MHR * .67);
            }
            else if (Customer.ActivityLevel == ActivityLevel.SPORADIC)
            {
                Customer.TargetMin = (int)(Customer.MHR * .64);
                Customer.TargetMax = (int)(Customer.MHR * .74);
            }
            else if (Customer.ActivityLevel == ActivityLevel.MINIMAL) 
            {
                Customer.TargetMin = (int)(Customer.MHR * .74);
                Customer.TargetMax = (int)(Customer.MHR * .84);
            }
            else if (Customer.ActivityLevel == ActivityLevel.REGULAR)
            {
                Customer.TargetMin = (int)(Customer.MHR * .80);
                Customer.TargetMax = (int)(Customer.MHR * .91);
            }
            else if (Customer.ActivityLevel == ActivityLevel.HIGH)
            {
                Customer.TargetMin = (int)(Customer.MHR * .84);
                Customer.TargetMax = (int)(Customer.MHR * .84);
            }
            else
            {
                // error, no activity level chosen
            }
            targetMinTB.Text = Customer.TargetMax.ToString();
            targetMaxTB.Text = Customer.TargetMin.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
                customerLB.Items.RemoveAt(customerLB.SelectedIndex);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
                UpdateCustomerFromGUI();
                CalculateOutputs();
                customerLB.Update();
        }

        private void customerLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerFromList();
        }

        private void LoadCustomerFromList()
        {
            Customer = customerLB.SelectedItem as Customer;
            firstTB.Text = Customer.FirstName;
            activeCB.Checked = Customer.IsFemale;  
            femaleCB.Checked = Customer.Active;
            textBox1.Text = Customer.Age.ToString();
            activityLevelCB.SelectedIndex = (int)Customer.ActivityLevel;
            CalculateOutputs();
        }
    }
}
