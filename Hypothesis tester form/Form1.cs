using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Math;
using Hypothesis_tester_core;
using Normal = Hypothesis_tester_core.Normal;
using Binomial = Hypothesis_tester_core.Binomial;

namespace Hypothesis_tester_form
{
    public partial class MainScreen : Form
    {
        /// <summary>
        /// This is if the user chooses to input the data instead of the mean. 
        /// </summary>
        public double[] Data { get; set; }

        private TestTypes SelectedRadioButton { get; set; }

        public AlternateHypo? AlternateHypo { get; set; }

        /// <summary>
        /// This is where the result of the hypothesis test is stored.
        /// </summary>
        public bool Result { get; set; }

        public MainScreen()
        {
            InitializeComponent();
            Normal.Computed += Normal_Computed;
            Binomial.Computed += Binomial_Computed;
            successRate.Maximum = n.Value;
            probLbl.Text = H0_bin.Value.ToString();
        }


        #region Normal distribution
        /// <summary>
        /// This will just allow decimals or not. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allowDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (allowDecimal.Checked)
            {
                mu.DecimalPlaces = 3;
                mu.Maximum = decimal.MaxValue;
                mu.Minimum = decimal.MinValue;

                sampleMean.DecimalPlaces = 3;
                sampleMean.Maximum = decimal.MaxValue;
                sampleMean.Minimum = decimal.MinValue;

                stdDev.DecimalPlaces = 3;
                stdDev.Maximum = decimal.MaxValue;
                stdDev.Minimum = decimal.MinValue;
            }
            else
            {
                mu.DecimalPlaces = 0;
                mu.Maximum = long.MaxValue;
                mu.Minimum = long.MinValue;

                sampleMean.DecimalPlaces = 0;
                sampleMean.Maximum = long.MaxValue;
                sampleMean.Minimum = long.MinValue;

                stdDev.DecimalPlaces = 0;
                stdDev.Maximum = long.MaxValue;
                stdDev.Minimum = long.MinValue;
            }
        }

        /// <summary>
        /// Data mode is when the user enters the data instead of just the mean. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataMode_CheckedChanged(object sender, EventArgs e)
        {
            if (dataMode.Checked)
            {
                dataLbl.Enabled = true;
                sampleData.Enabled = true;

                sampleMeanLbl.Enabled = false;
                sampleMean.Enabled = false;

                nNorm.Enabled = false;
                nNormLbl.Enabled = false;
            }
            else
            {
                dataLbl.Enabled = false;
                sampleData.Enabled = false;

                sampleMeanLbl.Enabled = true;
                sampleMean.Enabled = true;

                nNorm.Enabled = true;
                nNormLbl.Enabled = true;
            }
        }

        private void runBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sampleData.Enabled)
                    Data = sampleData.Text.Split(',', ';').Select(s => double.Parse(s)).ToArray();

                if (Data.Length < 2)
                    throw new ApplicationException();



                switch (SelectedRadioButton)
                {
                    case TestTypes.Increase:
                        AlternateHypo = Hypothesis_tester_core.AlternateHypo.GreaterThan;
                        break;

                    case TestTypes.Decrease:
                        AlternateHypo = Hypothesis_tester_core.AlternateHypo.LessThan;
                        break;

                    default:
                        AlternateHypo = null;
                        break;

                }

                double alpha = (double)(signLev.Value / 100);

                if (AlternateHypo != null)
                {
                    if (dataMode.Checked)
                        Result = Normal.OneTailNormalHypoTest(Data, (double)mu.Value, (double)stdDev.Value, Data.Length,
                            alpha, (AlternateHypo)AlternateHypo);
                    else
                        Result = Normal.OneTailNormalHypoTest((double)sampleMean.Value, (double)mu.Value,
                            (double)stdDev.Value, (int)nNorm.Value, alpha, (AlternateHypo)AlternateHypo);
                }
                else
                {
                    if (dataMode.Checked)
                        Result = Normal.NormalHypoTest(Data, (double)mu.Value, (double)stdDev.Value,
                            Data.Length, alpha);
                    else
                        Result = Normal.NormalHypoTest((double)sampleMean.Value, (double)mu.Value,
                            (double)stdDev.Value, (int)nNorm.Value, alpha);
                }

                Normal.HasComputed(sender, e);
            }
            catch (ApplicationException)
            {

                MessageBox.Show("You must enter more than one data item.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testTypeIncrease_CheckedChanged(object sender, EventArgs e)
        {
            if (testTypeIncrease.Checked)
                SelectedRadioButton = TestTypes.Increase;
        }

        private void testTypeDecrease_CheckedChanged(object sender, EventArgs e)
        {
            if (testTypeDecrease.Checked)
                SelectedRadioButton = TestTypes.Decrease;
        }

        private void testTypeChange_CheckedChanged(object sender, EventArgs e)
        {
            if (testTypeChange.Checked)
                SelectedRadioButton = TestTypes.Change;
        }

        private void Normal_Computed(object sender, EventArgs e)
        {
            H0_normRes.Visible = true;
            H0_normRes.Text = (Result) ? "Reject" : "Accept";
            normConcl.Visible = true;
            normConcl.Text = string.Format("There is {0}enough evidence to suggest that there has been a(n) {1} " +
                "in the mean of the sample.", (!Result) ? "not " : "", (SelectedRadioButton == TestTypes.Change) ?
                "change" : (SelectedRadioButton == TestTypes.Increase) ? "increase" : "decrease");
        }
        #endregion

        #region Binomial distribution
        private void runBtn1_Click(object sender, EventArgs e)
        {
            double alpha = (double)(signLevBin.Value / 100);

            switch (testType.Text)
            {
                case "<":
                    Result = Binomial.HypoTest((int)successRate.Value, (int)n.Value, (double)H0_bin.Value,
                        Hypothesis_tester_core.AlternateHypo.LessThan, alpha);
                    break;

                case ">":
                    Result = Binomial.HypoTest((int)successRate.Value, (int)n.Value, (double)H0_bin.Value,
                        Hypothesis_tester_core.AlternateHypo.GreaterThan, alpha);
                    break;

                case "≠":
                    Result = Binomial.HypoTest((int)successRate.Value, (int)n.Value, (double)H0_bin.Value, alpha);
                    break;
            }

            Binomial.HasComputed(sender, e);

        }

        /// <summary>
        /// This event is fired when a binomial test has been performed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Binomial_Computed(object sender, EventArgs e)
        {
            BinH0Res.Visible = true;
            conclusion.Visible = true;
            BinH0Res.Text = (Result) ? "Reject" : "Accept";
            conclusion.Text = string.Format("There is {0}enough evidence to suggest that the null hypothesis is false", (!Result) ? "not " : "");
        }

        private void n_ValueChanged(object sender, EventArgs e)
        {
            successRate.Maximum = n.Value;
        }

        private void H0_bin_ValueChanged(object sender, EventArgs e)
        {
            probLbl.Text = H0_bin.Value.ToString();
        } 
        #endregion

        /// <summary>
        /// This is used to identify which tail to perform the test in.
        /// </summary>
        private enum TestTypes
        {
            Increase,
            Decrease,
            Change
        }
    }
}
