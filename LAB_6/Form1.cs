namespace LAB_6
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        void selectMonth(int dates, out int day, out string month, int year)
        {
         
            
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                if (dates > 60)
                {
                    dates = dates - 1;
                }
                
            }
            int new_dates;
            if (dates >= 500)
            {
                new_dates = dates - 500;

            }
            else
            {
                new_dates = dates;
            }

            DateTime resultdate = new DateTime(DateTime.Now.Year, 1, 1).AddDays(new_dates - 1);
            bool isLeapYear = DateTime.IsLeapYear(resultdate.Year);
            day = resultdate.Day;
            month = resultdate.ToString("MMMM");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            if (textBox1.Text.Length == 10)
            {
                //Valid NIC number
                if (textBox1.Text[9] == 'V' || textBox1.Text[9] == 'v')
                {
                    //Valid NIC number
                    bool isNumeric = true;
                    string part = textBox1.Text.Substring(0, 9);

                    foreach (char c in part)
                    {
                        if (!char.IsDigit(c))
                        {
                            isNumeric = false;
                            break;
                        }
                    }

                    if (isNumeric)
                    {
                        //Valid NIC number

                        int day;
                        string month;
                        int dayOfYear = int.Parse(textBox1.Text.Substring(2, 3));
                        year = int.Parse(textBox1.Text.Substring(0, 2)) + 1900;
                        //outputBox.Text = "Year of Birth: " + year.ToString() + Environment.NewLine;
                        if (dayOfYear <= 366)
                        {
                            //Valid NIC number
                            outputBox.Text = "Gender: \t\t\tMale" + Environment.NewLine;
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            selectMonth(dayOfYear, out day, out month, year);
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            outputBox.Text += "Year of Birth: \t\t" + year.ToString() + Environment.NewLine;
                            outputBox.Text += "Month of Birth: \t\t" + month + Environment.NewLine;
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            outputBox.Text += "Day of Birth: \t\t" + day + Environment.NewLine;

                        }
                        else if (dayOfYear >= 500 && dayOfYear <= 866)
                        {
                            //Valid NIC number
                            outputBox.Text += "Gender: \t\t\tFemale" + Environment.NewLine;
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            selectMonth(dayOfYear, out day, out month, year);
                            outputBox.Text += "Year of Birth: \t\t" + year.ToString() + Environment.NewLine;
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            outputBox.Text += "Month of Birth: \t\t" + month + Environment.NewLine;
                            outputBox.Text += Environment.NewLine + Environment.NewLine;
                            outputBox.Text += "Day of Birth: \t\t" + day + Environment.NewLine;
                        }
                        else
                        {
                            MessageBox.Show("Invalid NIC Number. Please enter a valid NIC number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid NIC Number. Please enter a valid NIC number.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid NIC Number. Please enter a valid NIC number.");
                }


            }
            else if (textBox1.Text.Length == 12)
            {
                //Valid NIC number
                int day;
                string month;
                int dayOfYear = int.Parse(textBox1.Text.Substring(4, 3));
                year = int.Parse(textBox1.Text.Substring(0, 4));
                

                if (dayOfYear <= 366)
                {
                    //Valid NIC number
                    outputBox.Text = "Gender: \t\t\tMale" + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    selectMonth(dayOfYear, out day, out month, year);
                    outputBox.Text += "Year of Birth: \t\t" + year.ToString() + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    outputBox.Text += "Month of Birth: \t\t" + month + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    outputBox.Text += "Day of Birth: \t\t" + day + Environment.NewLine;

                }
                else if (dayOfYear >= 500 && dayOfYear <= 866)
                {
                    //Valid NIC number
                    outputBox.Text = "Gender: \t\t\tFemale" + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    outputBox.Text += "Year of Birth: \t\t" + year.ToString() + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    selectMonth(dayOfYear, out day, out month, year);
                    outputBox.Text += "Month of Birth: \t\t" + month + Environment.NewLine;
                    outputBox.Text += Environment.NewLine + Environment.NewLine;
                    outputBox.Text += "Day of Birth: \t\t" + day + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Invalid NIC Number. Please enter a valid NIC number. test erro");
                }
                

            }
            else
            {
                MessageBox.Show("Invalid NIC Number. Please enter a valid NIC number.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
