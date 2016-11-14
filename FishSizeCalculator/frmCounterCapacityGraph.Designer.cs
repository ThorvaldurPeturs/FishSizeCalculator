namespace FishSizeCalculator
{
    partial class frmCounterCapacityGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCounterCapacityGraph));
            this.pictCapacityGraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictCapacityGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // pictCapacityGraph
            // 
            this.pictCapacityGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictCapacityGraph.Image")));
            this.pictCapacityGraph.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictCapacityGraph.InitialImage")));
            this.pictCapacityGraph.Location = new System.Drawing.Point(13, 13);
            this.pictCapacityGraph.Name = "pictCapacityGraph";
            this.pictCapacityGraph.Size = new System.Drawing.Size(1135, 749);
            this.pictCapacityGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictCapacityGraph.TabIndex = 0;
            this.pictCapacityGraph.TabStop = false;
            this.pictCapacityGraph.Click += new System.EventHandler(this.pictCapacityGraph_Click);
            // 
            // frmCounterCapacityGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 762);
            this.Controls.Add(this.pictCapacityGraph);
            this.Name = "frmCounterCapacityGraph";
            this.Text = "Capacity";
            ((System.ComponentModel.ISupportInitialize)(this.pictCapacityGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictCapacityGraph;
    }
}