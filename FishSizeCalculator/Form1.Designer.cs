namespace FishSizeCalculator
{
    partial class frmFishWeightCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFishWeightCalculator));
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblThick = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtThick = new System.Windows.Forms.TextBox();
            this.tabParameters = new System.Windows.Forms.TabControl();
            this.tabSet1 = new System.Windows.Forms.TabPage();
            this.numCt = new System.Windows.Forms.NumericUpDown();
            this.numCf = new System.Windows.Forms.NumericUpDown();
            this.lblCt = new System.Windows.Forms.Label();
            this.lblCf = new System.Windows.Forms.Label();
            this.tabSet2 = new System.Windows.Forms.TabPage();
            this.numIntervals = new System.Windows.Forms.NumericUpDown();
            this.lblNumIntervals = new System.Windows.Forms.Label();
            this.numCV = new System.Windows.Forms.NumericUpDown();
            this.numAverage = new System.Windows.Forms.NumericUpDown();
            this.lblCV = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnGenGrading = new System.Windows.Forms.Button();
            this.tacCapacity = new System.Windows.Forms.TabPage();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCapacityMass = new System.Windows.Forms.Label();
            this.lblCounterCapacity = new System.Windows.Forms.Label();
            this.cbCounterType = new System.Windows.Forms.ComboBox();
            this.btnCounterCapacities = new System.Windows.Forms.Button();
            this.pnlGradingData = new System.Windows.Forms.Panel();
            this.dtgGrading = new System.Windows.Forms.DataGridView();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlDistribution = new System.Windows.Forms.Panel();
            this.lblBinWeights = new System.Windows.Forms.Label();
            this.numPctGrd4 = new System.Windows.Forms.NumericUpDown();
            this.numPctGrd3 = new System.Windows.Forms.NumericUpDown();
            this.numPctGrd2 = new System.Windows.Forms.NumericUpDown();
            this.numPctGrd1 = new System.Windows.Forms.NumericUpDown();
            this.chtDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrdSplit = new System.Windows.Forms.Label();
            this.toolTipCV = new System.Windows.Forms.ToolTip(this.components);
            this.tabParameters.SuspendLayout();
            this.tabSet1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCf)).BeginInit();
            this.tabSet2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAverage)).BeginInit();
            this.tacCapacity.SuspendLayout();
            this.pnlGradingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCapacity)).BeginInit();
            this.pnlMessages.SuspendLayout();
            this.pnlDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(39, 63);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(106, 24);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight: [gr]";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(39, 103);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(120, 24);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length: [mm]";
            // 
            // lblThick
            // 
            this.lblThick.AutoSize = true;
            this.lblThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThick.Location = new System.Drawing.Point(39, 145);
            this.lblThick.Name = "lblThick";
            this.lblThick.Size = new System.Drawing.Size(148, 24);
            this.lblThick.TabIndex = 2;
            this.lblThick.Text = "Thickness: [mm]";
            this.lblThick.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(244, 64);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Enter);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(244, 101);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 26);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Enter);
            // 
            // txtThick
            // 
            this.txtThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThick.Location = new System.Drawing.Point(244, 143);
            this.txtThick.Name = "txtThick";
            this.txtThick.Size = new System.Drawing.Size(100, 26);
            this.txtThick.TabIndex = 5;
            this.txtThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThick_KeyPress);
            this.txtThick.Leave += new System.EventHandler(this.txtThick_Enter);
            // 
            // tabParameters
            // 
            this.tabParameters.Controls.Add(this.tabSet1);
            this.tabParameters.Controls.Add(this.tabSet2);
            this.tabParameters.Controls.Add(this.tacCapacity);
            this.tabParameters.Location = new System.Drawing.Point(39, 222);
            this.tabParameters.Name = "tabParameters";
            this.tabParameters.SelectedIndex = 0;
            this.tabParameters.Size = new System.Drawing.Size(338, 254);
            this.tabParameters.TabIndex = 6;
            this.tabParameters.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabParameters_Selected);
            // 
            // tabSet1
            // 
            this.tabSet1.Controls.Add(this.numCt);
            this.tabSet1.Controls.Add(this.numCf);
            this.tabSet1.Controls.Add(this.lblCt);
            this.tabSet1.Controls.Add(this.lblCf);
            this.tabSet1.Location = new System.Drawing.Point(4, 22);
            this.tabSet1.Name = "tabSet1";
            this.tabSet1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSet1.Size = new System.Drawing.Size(330, 228);
            this.tabSet1.TabIndex = 0;
            this.tabSet1.Text = "Constants";
            this.tabSet1.UseVisualStyleBackColor = true;
            this.tabSet1.Click += new System.EventHandler(this.tabSet1_Click);
            this.tabSet1.Enter += new System.EventHandler(this.tabSet1_Click);
            // 
            // numCt
            // 
            this.numCt.DecimalPlaces = 1;
            this.numCt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCt.Location = new System.Drawing.Point(110, 52);
            this.numCt.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCt.Name = "numCt";
            this.numCt.Size = new System.Drawing.Size(120, 20);
            this.numCt.TabIndex = 3;
            this.numCt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCt.ValueChanged += new System.EventHandler(this.numCt_ValueChanged);
            // 
            // numCf
            // 
            this.numCf.DecimalPlaces = 1;
            this.numCf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCf.Location = new System.Drawing.Point(110, 22);
            this.numCf.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCf.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCf.Name = "numCf";
            this.numCf.Size = new System.Drawing.Size(120, 20);
            this.numCf.TabIndex = 2;
            this.numCf.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCf.ValueChanged += new System.EventHandler(this.numCf_ValueChanged);
            // 
            // lblCt
            // 
            this.lblCt.AutoSize = true;
            this.lblCt.Location = new System.Drawing.Point(16, 54);
            this.lblCt.Name = "lblCt";
            this.lblCt.Size = new System.Drawing.Size(57, 13);
            this.lblCt.TabIndex = 1;
            this.lblCt.Text = "L / T ratio:";
            // 
            // lblCf
            // 
            this.lblCf.AutoSize = true;
            this.lblCf.Location = new System.Drawing.Point(16, 24);
            this.lblCf.Name = "lblCf";
            this.lblCf.Size = new System.Drawing.Size(87, 13);
            this.lblCf.TabIndex = 0;
            this.lblCf.Text = "Condition Factor:";
            // 
            // tabSet2
            // 
            this.tabSet2.Controls.Add(this.numIntervals);
            this.tabSet2.Controls.Add(this.lblNumIntervals);
            this.tabSet2.Controls.Add(this.numCV);
            this.tabSet2.Controls.Add(this.numAverage);
            this.tabSet2.Controls.Add(this.lblCV);
            this.tabSet2.Controls.Add(this.lblAvg);
            this.tabSet2.Controls.Add(this.btnGenGrading);
            this.tabSet2.Location = new System.Drawing.Point(4, 22);
            this.tabSet2.Name = "tabSet2";
            this.tabSet2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSet2.Size = new System.Drawing.Size(330, 228);
            this.tabSet2.TabIndex = 1;
            this.tabSet2.Text = "Grading";
            this.tabSet2.UseVisualStyleBackColor = true;
            this.tabSet2.Click += new System.EventHandler(this.tabSet2_Click);
            this.tabSet2.Enter += new System.EventHandler(this.tabSet2_Click);
            // 
            // numIntervals
            // 
            this.numIntervals.Location = new System.Drawing.Point(127, 71);
            this.numIntervals.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numIntervals.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIntervals.Name = "numIntervals";
            this.numIntervals.Size = new System.Drawing.Size(98, 20);
            this.numIntervals.TabIndex = 6;
            this.numIntervals.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIntervals.Visible = false;
            // 
            // lblNumIntervals
            // 
            this.lblNumIntervals.AutoSize = true;
            this.lblNumIntervals.Location = new System.Drawing.Point(23, 73);
            this.lblNumIntervals.Name = "lblNumIntervals";
            this.lblNumIntervals.Size = new System.Drawing.Size(98, 13);
            this.lblNumIntervals.TabIndex = 5;
            this.lblNumIntervals.Text = "Number of intervals";
            this.lblNumIntervals.Visible = false;
            // 
            // numCV
            // 
            this.numCV.DecimalPlaces = 1;
            this.numCV.Location = new System.Drawing.Point(127, 46);
            this.numCV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCV.Name = "numCV";
            this.numCV.Size = new System.Drawing.Size(98, 20);
            this.numCV.TabIndex = 4;
            this.numCV.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numAverage
            // 
            this.numAverage.DecimalPlaces = 1;
            this.numAverage.Location = new System.Drawing.Point(127, 20);
            this.numAverage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAverage.Name = "numAverage";
            this.numAverage.Size = new System.Drawing.Size(98, 20);
            this.numAverage.TabIndex = 3;
            this.numAverage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Location = new System.Drawing.Point(23, 49);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(27, 13);
            this.lblCV.TabIndex = 2;
            this.lblCV.Text = "CV :";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(23, 20);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(87, 13);
            this.lblAvg.TabIndex = 1;
            this.lblAvg.Text = "Average Weight:";
            // 
            // btnGenGrading
            // 
            this.btnGenGrading.Location = new System.Drawing.Point(240, 185);
            this.btnGenGrading.Name = "btnGenGrading";
            this.btnGenGrading.Size = new System.Drawing.Size(75, 23);
            this.btnGenGrading.TabIndex = 0;
            this.btnGenGrading.Text = "Generate";
            this.btnGenGrading.UseVisualStyleBackColor = true;
            this.btnGenGrading.Click += new System.EventHandler(this.btnGenGrading_Click);
            // 
            // tacCapacity
            // 
            this.tacCapacity.Controls.Add(this.lblType);
            this.tacCapacity.Controls.Add(this.lblCapacityMass);
            this.tacCapacity.Controls.Add(this.lblCounterCapacity);
            this.tacCapacity.Controls.Add(this.cbCounterType);
            this.tacCapacity.Controls.Add(this.btnCounterCapacities);
            this.tacCapacity.Location = new System.Drawing.Point(4, 22);
            this.tacCapacity.Name = "tacCapacity";
            this.tacCapacity.Padding = new System.Windows.Forms.Padding(3);
            this.tacCapacity.Size = new System.Drawing.Size(330, 228);
            this.tacCapacity.TabIndex = 2;
            this.tacCapacity.Text = "Counter cap";
            this.tacCapacity.UseVisualStyleBackColor = true;
            this.tacCapacity.Click += new System.EventHandler(this.tabSet3_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(15, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // lblCapacityMass
            // 
            this.lblCapacityMass.AutoSize = true;
            this.lblCapacityMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityMass.Location = new System.Drawing.Point(15, 105);
            this.lblCapacityMass.Name = "lblCapacityMass";
            this.lblCapacityMass.Size = new System.Drawing.Size(56, 20);
            this.lblCapacityMass.TabIndex = 11;
            this.lblCapacityMass.Text = "Mass:";
            // 
            // lblCounterCapacity
            // 
            this.lblCounterCapacity.AutoSize = true;
            this.lblCounterCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterCapacity.Location = new System.Drawing.Point(15, 72);
            this.lblCounterCapacity.Name = "lblCounterCapacity";
            this.lblCounterCapacity.Size = new System.Drawing.Size(83, 20);
            this.lblCounterCapacity.TabIndex = 10;
            this.lblCounterCapacity.Text = "Capacity:";
            // 
            // cbCounterType
            // 
            this.cbCounterType.FormattingEnabled = true;
            this.cbCounterType.Location = new System.Drawing.Point(106, 34);
            this.cbCounterType.Name = "cbCounterType";
            this.cbCounterType.Size = new System.Drawing.Size(121, 21);
            this.cbCounterType.TabIndex = 9;
            this.cbCounterType.SelectedIndexChanged += new System.EventHandler(this.tabSet3_Click);
            // 
            // btnCounterCapacities
            // 
            this.btnCounterCapacities.Location = new System.Drawing.Point(211, 133);
            this.btnCounterCapacities.Name = "btnCounterCapacities";
            this.btnCounterCapacities.Size = new System.Drawing.Size(90, 23);
            this.btnCounterCapacities.TabIndex = 8;
            this.btnCounterCapacities.Text = "All Counters";
            this.btnCounterCapacities.UseVisualStyleBackColor = true;
            this.btnCounterCapacities.Click += new System.EventHandler(this.btnCounterCapacities_Click);
            // 
            // pnlGradingData
            // 
            this.pnlGradingData.Controls.Add(this.dtgGrading);
            this.pnlGradingData.Location = new System.Drawing.Point(908, 493);
            this.pnlGradingData.Name = "pnlGradingData";
            this.pnlGradingData.Size = new System.Drawing.Size(377, 404);
            this.pnlGradingData.TabIndex = 7;
            // 
            // dtgGrading
            // 
            this.dtgGrading.AllowUserToDeleteRows = false;
            this.dtgGrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thickness,
            this.Length,
            this.Weight});
            this.dtgGrading.Location = new System.Drawing.Point(3, 4);
            this.dtgGrading.Name = "dtgGrading";
            this.dtgGrading.ReadOnly = true;
            this.dtgGrading.Size = new System.Drawing.Size(346, 397);
            this.dtgGrading.TabIndex = 0;
            this.dtgGrading.Visible = false;
            // 
            // Thickness
            // 
            this.Thickness.HeaderText = "Thickness";
            this.Thickness.Name = "Thickness";
            this.Thickness.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // chtCapacity
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chtCapacity.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chtCapacity.Legends.Add(legend1);
            this.chtCapacity.Location = new System.Drawing.Point(383, 9);
            this.chtCapacity.Name = "chtCapacity";
            this.chtCapacity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Capacity";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "SelectedPoint";
            series3.BorderColor = System.Drawing.Color.White;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.MarkerBorderWidth = 3;
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Name = "MassCapacity";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chtCapacity.Series.Add(series1);
            this.chtCapacity.Series.Add(series2);
            this.chtCapacity.Series.Add(series3);
            this.chtCapacity.Size = new System.Drawing.Size(512, 429);
            this.chtCapacity.TabIndex = 8;
            this.chtCapacity.Text = "Capacity graph";
            // 
            // pnlMessages
            // 
            this.pnlMessages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMessages.Controls.Add(this.lblMessage);
            this.pnlMessages.Location = new System.Drawing.Point(43, 482);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(906, 46);
            this.pnlMessages.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(20, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(19, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "..";
            // 
            // pnlDistribution
            // 
            this.pnlDistribution.Controls.Add(this.lblGrdSplit);
            this.pnlDistribution.Controls.Add(this.lblBinWeights);
            this.pnlDistribution.Controls.Add(this.numPctGrd4);
            this.pnlDistribution.Controls.Add(this.numPctGrd3);
            this.pnlDistribution.Controls.Add(this.numPctGrd2);
            this.pnlDistribution.Controls.Add(this.numPctGrd1);
            this.pnlDistribution.Controls.Add(this.chtDistribution);
            this.pnlDistribution.Location = new System.Drawing.Point(400, 9);
            this.pnlDistribution.Name = "pnlDistribution";
            this.pnlDistribution.Size = new System.Drawing.Size(548, 467);
            this.pnlDistribution.TabIndex = 9;
            // 
            // lblBinWeights
            // 
            this.lblBinWeights.AllowDrop = true;
            this.lblBinWeights.AutoSize = true;
            this.lblBinWeights.Location = new System.Drawing.Point(5, 400);
            this.lblBinWeights.Name = "lblBinWeights";
            this.lblBinWeights.Size = new System.Drawing.Size(94, 13);
            this.lblBinWeights.TabIndex = 5;
            this.lblBinWeights.Text = "Avg weight in bin: ";
            // 
            // numPctGrd4
            // 
            this.numPctGrd4.DecimalPlaces = 1;
            this.numPctGrd4.Location = new System.Drawing.Point(322, 377);
            this.numPctGrd4.Name = "numPctGrd4";
            this.numPctGrd4.Size = new System.Drawing.Size(67, 20);
            this.numPctGrd4.TabIndex = 4;
            this.numPctGrd4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numPctGrd3
            // 
            this.numPctGrd3.DecimalPlaces = 1;
            this.numPctGrd3.Location = new System.Drawing.Point(245, 377);
            this.numPctGrd3.Name = "numPctGrd3";
            this.numPctGrd3.Size = new System.Drawing.Size(67, 20);
            this.numPctGrd3.TabIndex = 3;
            this.numPctGrd3.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numPctGrd2
            // 
            this.numPctGrd2.DecimalPlaces = 1;
            this.numPctGrd2.Location = new System.Drawing.Point(168, 377);
            this.numPctGrd2.Name = "numPctGrd2";
            this.numPctGrd2.Size = new System.Drawing.Size(67, 20);
            this.numPctGrd2.TabIndex = 2;
            this.numPctGrd2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numPctGrd1
            // 
            this.numPctGrd1.DecimalPlaces = 1;
            this.numPctGrd1.Location = new System.Drawing.Point(95, 377);
            this.numPctGrd1.Name = "numPctGrd1";
            this.numPctGrd1.Size = new System.Drawing.Size(67, 20);
            this.numPctGrd1.TabIndex = 1;
            this.numPctGrd1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chtDistribution
            // 
            chartArea2.Name = "ChartArea1";
            this.chtDistribution.ChartAreas.Add(chartArea2);
            this.chtDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chtDistribution.Legends.Add(legend2);
            this.chtDistribution.Location = new System.Drawing.Point(0, 0);
            this.chtDistribution.Name = "chtDistribution";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Normal";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Grade1";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Grade2";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Maroon;
            series7.Legend = "Legend1";
            series7.Name = "Grade3";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.MarkerBorderWidth = 2;
            series8.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series8.MarkerSize = 12;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series8.Name = "BinAvgPoints";
            this.chtDistribution.Series.Add(series4);
            this.chtDistribution.Series.Add(series5);
            this.chtDistribution.Series.Add(series6);
            this.chtDistribution.Series.Add(series7);
            this.chtDistribution.Series.Add(series8);
            this.chtDistribution.Size = new System.Drawing.Size(548, 371);
            this.chtDistribution.TabIndex = 0;
            this.chtDistribution.Text = "chart1";
            // 
            // lblGrdSplit
            // 
            this.lblGrdSplit.AllowDrop = true;
            this.lblGrdSplit.AutoSize = true;
            this.lblGrdSplit.Location = new System.Drawing.Point(5, 420);
            this.lblGrdSplit.Name = "lblGrdSplit";
            this.lblGrdSplit.Size = new System.Drawing.Size(79, 13);
            this.lblGrdSplit.TabIndex = 6;
            this.lblGrdSplit.Text = "Grader setting: ";
            // 
            // toolTipCV
            // 
            this.toolTipCV.IsBalloon = true;
            this.toolTipCV.ShowAlways = true;
            // 
            // frmFishWeightCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 540);
            this.Controls.Add(this.pnlDistribution);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.pnlGradingData);
            this.Controls.Add(this.tabParameters);
            this.Controls.Add(this.txtThick);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblThick);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.chtCapacity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFishWeightCalculator";
            this.Text = "VAKI - Fish Weight Calculator";
            this.Load += new System.EventHandler(this.frmFishWeightCalculator_Load);
            this.tabParameters.ResumeLayout(false);
            this.tabSet1.ResumeLayout(false);
            this.tabSet1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCf)).EndInit();
            this.tabSet2.ResumeLayout(false);
            this.tabSet2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAverage)).EndInit();
            this.tacCapacity.ResumeLayout(false);
            this.tacCapacity.PerformLayout();
            this.pnlGradingData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCapacity)).EndInit();
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            this.pnlDistribution.ResumeLayout(false);
            this.pnlDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPctGrd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblThick;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtThick;
        private System.Windows.Forms.TabControl tabParameters;
        private System.Windows.Forms.TabPage tabSet1;
        private System.Windows.Forms.NumericUpDown numCt;
        private System.Windows.Forms.NumericUpDown numCf;
        private System.Windows.Forms.Label lblCt;
        private System.Windows.Forms.Label lblCf;
        private System.Windows.Forms.TabPage tabSet2;
        private System.Windows.Forms.NumericUpDown numIntervals;
        private System.Windows.Forms.Label lblNumIntervals;
        private System.Windows.Forms.NumericUpDown numCV;
        private System.Windows.Forms.NumericUpDown numAverage;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnGenGrading;
        private System.Windows.Forms.Panel pnlGradingData;
        private System.Windows.Forms.DataGridView dtgGrading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.Button btnCounterCapacities;
        private System.Windows.Forms.TabPage tacCapacity;
        private System.Windows.Forms.ComboBox cbCounterType;
        private System.Windows.Forms.Label lblCounterCapacity;
        private System.Windows.Forms.Label lblCapacityMass;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCapacity;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDistribution;
        private System.Windows.Forms.NumericUpDown numPctGrd4;
        private System.Windows.Forms.NumericUpDown numPctGrd3;
        private System.Windows.Forms.NumericUpDown numPctGrd2;
        private System.Windows.Forms.NumericUpDown numPctGrd1;
        private System.Windows.Forms.Label lblBinWeights;
        private System.Windows.Forms.Label lblGrdSplit;
        private System.Windows.Forms.ToolTip toolTipCV;
    }
}

