namespace BMI
{
    public partial class Form1 : Form
    {
        private int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int bmi = 0;

            // read input controls
            try
            {
                int height = Int32.Parse(heightTB.Text);  
                int mass = Int32.Parse(massTB.Text);
                bmi = CalculateBMI(height, mass);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Failed to calculate BMI due to a format exception: " + ex.Message, "BMI App");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Failed to calculate BMI due to a divide by zero exception: " + ex.Message, "BMI App");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Failed to calculate BMI due to a argument out of range exception: " + ex.Message, "BMI App");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate BMI due to an exception: " + ex.Message, "BMI App");
            }
            finally
            {
                count++;
            }

            // display BMI
            bmiTB.Text = bmi.ToString();
            countTB.Text = count.ToString();
        }

        private static int CalculateBMI(int height, int mass)
        {
            if ((height <= 0) || (mass <= 0))
                throw new ArgumentOutOfRangeException();

            // calculate BMI
            return mass * 703 / (height * height);
        }

        private void calculate2Btn_Click(object sender, EventArgs e)
        {
            int bmi = 0;

            // read input controls
            try
            {
                int height = (int)heightNUD.Value; // Int32.Parse(heightTB.Text);
                int mass = (int)massNUD.Value; //Int32.Parse(massTB.Text);
                bmi = CalculateBMI(height, mass);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Failed to calculate BMI due to a argument out of range exception: " + ex.Message, "BMI App");
            }
            finally
            {
                count++;
            }

            // display BMI
            bmi2TB.Text = bmi.ToString();
            countTB.Text = count.ToString();
        }
    }
}