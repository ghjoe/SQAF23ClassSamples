﻿using System;
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
            if (IsCustomerInfoValid())
            {
                // initialize customer based on GUI
                Customer = new Customer();
                UpdateCustomerFromGUI();

                CalculateOutputs();
                customerLB.Items.Add(Customer);
            }
        }

        private void UpdateCustomerFromGUI()
        {
            Customer.FirstName = firstTB.Text;
            Customer.Active = activeCB.Checked;
            Customer.IsFemale = !femaleCB.Checked;

            Customer.Age = int.Parse(textBox1.Text);
            Customer.ActivityLevel = (ActivityLevel)activityLevelCB.SelectedIndex;
        }

        private bool IsCustomerInfoValid()
        {
            // Validate data entered
            if (firstTB.Text.Trim() == string.Empty)
            {
                statusLbl.Text = "Add failed!  Please specify a valid name";
                return false;
            }

            if (int.TryParse(textBox1.Text, out int value) == false)
            {
                statusLbl.Text = "Add failed!  Please specify a valid age";
                return false;
            }
            return true;
        }

        // https://www.verywellfit.com/maximum-heart-rate-1231221
        private void CalculateOutputs()
        {
            // calculate target heart ranges base on activity level and MHR
            Customer.ActivityLevel = (ActivityLevel)activityLevelCB.SelectedIndex;
            Customer.CalculateOutputs();

            // update MHR textbox
            mhrTB.Text = Customer.MHR.ToString();
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
