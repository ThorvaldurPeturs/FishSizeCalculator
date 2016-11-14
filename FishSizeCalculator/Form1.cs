using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;

namespace FishSizeCalculator
{
    public partial class frmFishWeightCalculator : Form
    {
        double dWeight, dLength, dThick;
        double Cf = 1.2;    //  Condition factor
        double Ct = 10.0;   //  Length Thickness ratio

        struct Fish
        {
            public double t;
            public double w;
            public double L;
        }

        struct SizeRange
        {
            public double low;
            public double high;            
        } 

        public frmFishWeightCalculator()
        {
            InitializeComponent();
            toolTipCV.SetToolTip(this.numCV, "CV = mean weight / Standard deviation "); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            dWeight = Convert.ToDouble(txtWeight.Text);
            dLength = dLengthFromWeight(dWeight);                  
            dThick = dLength / Ct;
            

            txtWeight.Text = dWeight.ToString("0.00");
            txtLength.Text = dLength.ToString("0.00");
            txtThick.Text  = dThick.ToString("0.00");
            txtWeight.ForeColor = Color.Red;
            txtLength.ForeColor = Color.Black;
            txtThick.ForeColor = Color.Black;

            tabSet3_Click(sender, e); 
        }


        private void txtLength_Enter(object sender, EventArgs e)
        {
            dLength= Convert.ToDouble(txtLength.Text);
            dWeight = dWeightFromLength(dLength);      //Math.Pow(dLength ,  3.0d) * Cf / 100000d;
            dThick = dLength / Ct;


            txtWeight.Text = dWeight.ToString("0.0");
            txtLength.Text = dLength.ToString("0.0");
            txtThick.Text = dThick.ToString("0.0");
            txtWeight.ForeColor = Color.Black;
            txtLength.ForeColor = Color.Red;
            txtThick.ForeColor = Color.Black;

            tabSet3_Click(sender, e); 
        }

        private void txtThick_Enter(object sender, EventArgs e)
        {
            dThick = Convert.ToDouble(txtThick.Text);
            dLength = dLengthFromthickness(dThick);
            dWeight = dWeightFromLength(dLength);   
            


            txtWeight.Text = dWeight.ToString("0.0");
            txtLength.Text = dLength.ToString("0.0");
            txtThick.Text = dThick.ToString("0.0");
            txtWeight.ForeColor = Color.Black;
            txtLength.ForeColor = Color.Black;
            txtThick.ForeColor = Color.Red;

            tabSet3_Click(sender, e); 
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtWeight_Enter(this, new EventArgs());
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLength_Enter(this, new EventArgs());
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtThick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtThick_Enter(this, new EventArgs());
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmFishWeightCalculator_Load(object sender, EventArgs e)
        {
            numCf.Value = (decimal) Cf;
            numCt.Value = (decimal)Ct;

            string[] strCounters = new string[] { "Nano", "Micro", "Macro", "Macro XL","S-1400","S-2100","Y-1300 / B-1400","Y-1900 / B-2000","Bioscanner","PLC" };
            
            tabParameters.SelectedIndex = 2;
            cbCounterType.Items.AddRange(strCounters);
            this.cbCounterType.SelectedIndex = 0;    
            //
            //txtWeight.Select(txtWeight.Text.Length, 0); 
            txtWeight.Focus(); txtWeight.Text = "10"; 
            txtWeight_Enter(sender, e); 
            
 
        }

        private void numCf_ValueChanged(object sender, EventArgs e)
        {
            Cf = (double) numCf.Value; 
        }

        private void numCt_ValueChanged(object sender, EventArgs e)
        {
            Ct = (double)numCt.Value; 
        }

        double dLengthFromWeight(double weight)
        {
            return Math.Pow(weight / Cf, (1.0d / 3.0d)) * 46.416d;

        }

        double dWeightFromLength(double length)
        {
            return Math.Pow(length, 3.0d) * Cf / 100000d;
        }

        double dLengthFromthickness( double t)
        {
            return (t * Ct);
        }

        double dThicknessFromWeight(double w)
        {
            return Math.Pow( (w * 100000d / Cf), 0.333333333333333d) / Ct  ;
        }
        void vGradingTable()
        {
            // Generate the normal curve and calculate the properties for each grade
            int iNumberOfIntervals = 10;

            lblMessage.Text = " Enter value for average weight and CV then press 'Generate' "; lblMessage.ForeColor = Color.Blue;

            double pctGr1 = (double)numPctGrd1.Value / 100;
            double pctGr2 = (double)numPctGrd2.Value / 100;
            double pctGr3 = (double)numPctGrd3.Value / 100;
            double pctGr4 = (double)numPctGrd4.Value / 100;

            if( !( pctGr1+pctGr2+pctGr3+pctGr4 >= 0.99 && pctGr1+pctGr2+pctGr3+pctGr4 <= 1.00 ) )
            {
                MessageBox.Show("Grading percentage has to add up to 100%, reevaluate and press 'Generate' again ");
                return;
            }
            
            double my = (double) numAverage.Value;
            double std= (double) numCV.Value * my;

            chtDistribution.Series["Normal"].Points.Clear();
            chtDistribution.Series["Grade1"].Points.Clear();
            chtDistribution.Series["Grade2"].Points.Clear();
            chtDistribution.Series["Grade3"].Points.Clear();
            chtDistribution.Series["BinAvgPoints"].Points.Clear();

            

            
            Normal norm = new Normal(my, std); 

            double[] dens = new double[50]; 

            double incr = 3*std / 25;
            double x = -3 * std + my ;

            for (int i = 0; i < 50;i++ )
            {
                x += incr; 

              dens[i] = norm.Density(x);
              
              chtDistribution.Series["Normal"].Points.AddXY(x, dens[i]);
              //chtDistribution.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
              
            }

            //  Calculate and plot the grade dividers 
            double[] dGrd = new double[5];
            dGrd[0] = norm.InverseCumulativeDistribution(0.01);
            dGrd[1] = norm.InverseCumulativeDistribution(pctGr1);
            dGrd[2] = norm.InverseCumulativeDistribution(pctGr1 + pctGr2);
            dGrd[3] = norm.InverseCumulativeDistribution(pctGr1 + pctGr2 + pctGr3 );
            dGrd[4] = norm.InverseCumulativeDistribution(100);

            for(int i=1; i<4; i++ )
            {
              string temp = "Grade"+ i.ToString();
              chtDistribution.Series[temp].Points.AddXY(dGrd[i], 0);
              chtDistribution.Series[temp].Points.AddXY(dGrd[i], norm.Density(dGrd[i]));
            }

            // Calculate and plot the bin average weight's

            double[] dBinAvg = new double[4];


            double p = Phi(0);
            double r = stdN(0);

            double m = my;
            double s = std;
            string strBinWeights = "Bin avg weight:  ";
            string strBinSetting = "Bin settings:      ";

            for(int i=0; i<4;i++)
            { 
                double bs = dGrd[i];
                double be = dGrd[i+1];

                double rs = (bs - m) / s;
                double re = (be - m) / s;

                dBinAvg[i] = m + s * (stdN(rs) - stdN(re)) / (Phi(re) - Phi(rs));
                chtDistribution.Series["BinAvgPoints"].Points.AddXY(dBinAvg[i], norm.Density(dBinAvg[i])/2);

                strBinWeights += dBinAvg[i].ToString("N1") + " gr  /  ";
                strBinSetting += dThicknessFromWeight(dGrd[i + 1]).ToString("N1") + " mm / ";

            }

            lblBinWeights.Text = strBinWeights;
            lblGrdSplit.Text = strBinSetting; 

            
            
        }

        void vWeightPlot(double lowEnd, double heighEnd)
        {
            int iNumberOfIntervals = 10;
            double[] dWeightPoint = new double[10];


            double dStep = (heighEnd - lowEnd) / (iNumberOfIntervals - 1);

            // dtgGrading.Rows.Clear();

            for (int i = 0; i < iNumberOfIntervals; i++)
            {

                dWeightPoint[i] += i * dStep;


            }

        }

        private void btnGenGrading_Click(object sender, EventArgs e)
        {
            vGradingTable();

        }

        private void tabParameters_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabSet1_Click(object sender, EventArgs e)
        {
            pnlGradingData.Visible = false;
            pnlDistribution.Visible = false;
        }

        private void tabSet2_Click(object sender, EventArgs e)
        {
            pnlGradingData.Visible = false;  // true
            chtCapacity.Visible = false;
            pnlDistribution.Visible = true;
            lblMessage.Text = " Enter value for average weight and CV then press 'Generate' "; lblMessage.ForeColor = Color.Blue;
            btnGenGrading_Click(sender, e);
        }

        private void tabSet3_Click(object sender, EventArgs e)
        {
            //  Display the capacity calculation and the chart for capacity

            bool bPlotGraph = false;
            pnlGradingData.Visible = false;
            pnlDistribution.Visible = false;
            chtCapacity.Visible = true;
            lblMessage.Text = " Enter value for one of the fish dimensions or weight and press 'Enter' "; lblMessage.ForeColor = Color.Blue; 
            

            // constants for capacity calculation
            double[] b = new double[] { 3.571, 3.793, 4.094, 4.208, 4.354, 4.676, 4.155, 4.320,  3.287,  3.588  };
            double[] m = new double[] { -0.396, -0.396, -0.396, -0.396, -0.396, -0.396, -0.427, -0.427, -0.500, -0.500 };
            //  Counter limits
            SizeRange[] limits = new SizeRange[10];
            limits[0].low = 0.09;   limits[0].high = 30.1;    // Nano
            limits[1].low = 0.29;   limits[1].high = 300.1;   // Micro
            limits[2].low = 0.29;   limits[2].high = 300.1;   // Macro
            limits[3].low = 0.29;   limits[3].high = 500.1;   // Macro XL
            limits[4].low = 29.9;   limits[4].high = 800.1;   // S-1400
            limits[5].low = 29.9;   limits[5].high = 1200.1;  // S-2100
            limits[6].low = 99.9;   limits[6].high = 9000.1;  // Y-1300
            limits[7].low = 99.9;   limits[7].high = 9000.1;  // Y-1900
            limits[8].low = 2.9;    limits[8].high = 10000.1;    // Bioscanner
            limits[9].low = 9.9;    limits[9].high = 10000.1;    // PLC
 
            // end of counter limits

            int i = cbCounterType.SelectedIndex;
            double capacity = Math.Pow(dWeight, m[i]) * Math.Pow(10, b[i]);
            double massCapacity = capacity * dWeight * 60 / 1000;  // [kg/h]

            if( limits[i].low < dWeight &&  dWeight < limits[i].high)
            { 
              lblCounterCapacity.Text = "Capacity: " + capacity.ToString("#,###") + " pcs/min";
              lblCapacityMass.Text = "Mass: " + massCapacity.ToString("#,###") + " kg/h";
              lblMessage.Text = " Enter value for one of the fish dimensions or weight and press 'Enter' "; lblMessage.ForeColor = Color.Blue; 
              bPlotGraph = true;
            }
            else
            {
                lblCounterCapacity.Text = " Capacity: - ";
                lblMessage.Text = " WARNING : Fish size outside bounds for the selected counter "; lblMessage.ForeColor = Color.Red; 
                lblCapacityMass.Text = "Mass: -";
                chtCapacity.Visible = false;
                bPlotGraph = false;
            }

            if(bPlotGraph)
            {
                int iNumberOfIntervals = 20;
                double[] dWeightPoint = new double[20];

                chtCapacity.Series["Capacity"].Points.Clear();
                chtCapacity.Series["SelectedPoint"].Points.Clear();
                chtCapacity.Series["MassCapacity"].Points.Clear();
                chtCapacity.ChartAreas[0].AxisX.Maximum = limits[i].high;
                chtCapacity.ChartAreas[0].AxisX.Minimum = limits[i].low;

                chtCapacity.ChartAreas[0].AxisX.LabelStyle.Format = "{#,###.#}";
                chtCapacity.ChartAreas[0].AxisY.LabelStyle.Format = "{#,###}";
                chtCapacity.ChartAreas[0].AxisY2.LabelStyle.Format = "{#,###}";

                chtCapacity.ChartAreas[0].AxisX.Title = "Fish size [gr]";
                chtCapacity.ChartAreas[0].AxisY.Title = "Capacity [pcs/min]";
                chtCapacity.ChartAreas[0].AxisY2.Title = "Mass flow [kg/h]";

                chtCapacity.Series["SelectedPoint"].Points.AddXY(dWeight, capacity);

                double dStep = (limits[i].high - limits[i].low) / (iNumberOfIntervals - 1);

                for (int j = 0; j < iNumberOfIntervals; j++)
                {

                    dWeightPoint[j] = limits[i].low + j * dStep;

                    capacity = Math.Pow(dWeightPoint[j], m[i]) * Math.Pow(10, b[i]);
                    massCapacity = capacity * dWeightPoint[j] * 60 / 1000;  // [kg/h]
                    chtCapacity.Series["Capacity"].Points.AddXY(dWeightPoint[j], capacity);
                    chtCapacity.Series["MassCapacity"].Points.AddXY(dWeightPoint[j], massCapacity);
                }

                
            }
        }
        private void btnCounterCapacities_Click(object sender, EventArgs e)
        {
            // Display a new form with the log-log capacity chart for the Vaki Counter range 
            // Create a new instance of the form class

            frmCounterCapacityGraph f = new frmCounterCapacityGraph();

            // Show the chart form
            f.Show();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateNormalDist()
        {
        }


        static double Phi(double x)
        {
            //  Implementation of the standard cummulative normal distribution  from John D. Cook http://www.johndcook.com/blog/csharp_phi/ 
            //The function Φ(x) is the cumulative density function (CDF) of a standard normal (Gaussian) random variable. It is closely related to the error function erf(x).
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x) / Math.Sqrt(2.0);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return 0.5 * (1.0 + sign * y);
        }

        public static double stdN(double x)
        {  // StandardNormalPdf  -- Alex Hill,  littleDice blog. 
            // http://littledice.me/about/ http://littledice.me/2014/03/19/calculating-probabilities-in-c/
            var exponent = -1 * (0.5 * Math.Pow(x, 2));
            var numerator = Math.Pow(Math.E, exponent);
            var denominator = Math.Sqrt(2 * Math.PI);
            return numerator / denominator;
        }

    }
}

/*
            List<Fish> f = new List<Fish>();

            iNumberOfIntervals = (int) numIntervals.Value;
            dStartT = (double) numAverage.Value;
            dEndT = (double) numCV.Value;

            double dStep = (dEndT - dStartT) / (iNumberOfIntervals-1);

            dtgGrading.Rows.Clear();

            for(int i=0; i<iNumberOfIntervals;i++)
            {
                Fish a; 

                dStartT += i*dStep;
                a.t = dStartT;
                a.L = dLengthFromthickness(a.t);
                a.w = dWeightFromLength(a.L);

                f.Add(a);
                dtgGrading.Rows.Add(a.t, a.L, a.w);

                this.dtgGrading.Columns["Thickness"].DefaultCellStyle.Format = "#,###.#";
                this.dtgGrading.Columns["Weight"].DefaultCellStyle.Format = "#,###.#";
                this.dtgGrading.Columns["Length"].DefaultCellStyle.Format = "#,###.#";

                this.dtgGrading.Columns["Thickness"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dtgGrading.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dtgGrading.Columns["Length"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; }
*/
