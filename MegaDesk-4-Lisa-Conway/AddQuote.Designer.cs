namespace MegaDesk_3_Lisa_Conway
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.ComboBox();
            this.lblRushOptions = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.submit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.quotePrice = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.NumericUpDown();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            this.calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(171, 51);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(204, 20);
            this.customerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size of Desk: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "width (min 24\"; max 96\")";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "depth (min 12\"; max 48\")";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "# of Drawers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.Location = new System.Drawing.Point(171, 146);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(46, 20);
            this.numberOfDrawers.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Surface Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rush Order Options";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaterial
            // 
            this.lblMaterial.FormattingEnabled = true;
            this.lblMaterial.Location = new System.Drawing.Point(170, 192);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(121, 21);
            this.lblMaterial.TabIndex = 15;
            this.lblMaterial.SelectedIndexChanged += new System.EventHandler(this.lblMaterial_SelectedIndexChanged);
            // 
            // lblRushOptions
            // 
            this.lblRushOptions.FormattingEnabled = true;
            this.lblRushOptions.Location = new System.Drawing.Point(168, 243);
            this.lblRushOptions.Name = "lblRushOptions";
            this.lblRushOptions.Size = new System.Drawing.Size(121, 21);
            this.lblRushOptions.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(482, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(384, 319);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 28);
            this.submit.TabIndex = 23;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Price of Quote";
            // 
            // quotePrice
            // 
            this.quotePrice.Location = new System.Drawing.Point(168, 300);
            this.quotePrice.Name = "quotePrice";
            this.quotePrice.Size = new System.Drawing.Size(92, 20);
            this.quotePrice.TabIndex = 25;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(505, 100);
            this.txtDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.txtDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(58, 20);
            this.txtDepth.TabIndex = 22;
            this.txtDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(298, 100);
            this.txtWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.txtWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(49, 20);
            this.txtWidth.TabIndex = 21;
            this.txtWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(285, 319);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(93, 28);
            this.calculate.TabIndex = 26;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 359);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.quotePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRushOptions);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberOfDrawers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lblMaterial;
        private System.Windows.Forms.ComboBox lblRushOptions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox quotePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtDepth;
        private System.Windows.Forms.NumericUpDown txtWidth;
        private System.Windows.Forms.Button calculate;
    }
}