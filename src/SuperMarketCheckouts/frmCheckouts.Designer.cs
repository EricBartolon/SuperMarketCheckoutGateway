namespace SuperMarketCheckouts {
    partial class frmCheckouts {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnEnqueue = new Button();
            txtCartNumber = new TextBox();
            gbCartInfo = new GroupBox();
            ntxtCartSize = new NumericUpDown();
            lblSize = new Label();
            lblCartNumber = new Label();
            btnDequeue = new Button();
            dgvCheckout1 = new DataGridView();
            dgvCheckout4 = new DataGridView();
            dgvCheckout5 = new DataGridView();
            dgvCheckout3 = new DataGridView();
            dgvCheckout2 = new DataGridView();
            dgvCheckout7 = new DataGridView();
            dgvCheckout6 = new DataGridView();
            dgvCheckout8 = new DataGridView();
            dgvCheckout9 = new DataGridView();
            dgvCheckout10 = new DataGridView();
            gbCheckouts = new GroupBox();
            ntxtCheckoutToDequeue = new NumericUpDown();
            lblCheckoutToDequeue = new Label();
            gbDequeue = new GroupBox();
            btnAutoFill = new Button();
            gbCartInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ntxtCartSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout10).BeginInit();
            gbCheckouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ntxtCheckoutToDequeue).BeginInit();
            gbDequeue.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(17, 91);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(168, 29);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "&Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // txtCartNumber
            // 
            txtCartNumber.Enabled = false;
            txtCartNumber.Location = new Point(60, 22);
            txtCartNumber.Name = "txtCartNumber";
            txtCartNumber.Size = new Size(125, 27);
            txtCartNumber.TabIndex = 1;
            // 
            // gbCartInfo
            // 
            gbCartInfo.Controls.Add(ntxtCartSize);
            gbCartInfo.Controls.Add(lblSize);
            gbCartInfo.Controls.Add(lblCartNumber);
            gbCartInfo.Controls.Add(txtCartNumber);
            gbCartInfo.Controls.Add(btnEnqueue);
            gbCartInfo.Location = new Point(132, 12);
            gbCartInfo.Name = "gbCartInfo";
            gbCartInfo.Size = new Size(200, 131);
            gbCartInfo.TabIndex = 2;
            gbCartInfo.TabStop = false;
            gbCartInfo.Text = "Cart";
            // 
            // ntxtCartSize
            // 
            ntxtCartSize.Location = new Point(60, 58);
            ntxtCartSize.Name = "ntxtCartSize";
            ntxtCartSize.Size = new Size(125, 27);
            ntxtCartSize.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(17, 65);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // lblCartNumber
            // 
            lblCartNumber.AutoSize = true;
            lblCartNumber.Location = new Point(17, 29);
            lblCartNumber.Name = "lblCartNumber";
            lblCartNumber.Size = new Size(29, 20);
            lblCartNumber.TabIndex = 2;
            lblCartNumber.Text = "# : ";
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(42, 91);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(127, 29);
            btnDequeue.TabIndex = 3;
            btnDequeue.Text = "&Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // dgvCheckout1
            // 
            dgvCheckout1.AllowUserToAddRows = false;
            dgvCheckout1.AllowUserToDeleteRows = false;
            dgvCheckout1.AllowUserToResizeColumns = false;
            dgvCheckout1.AllowUserToResizeRows = false;
            dgvCheckout1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout1.Location = new Point(14, 26);
            dgvCheckout1.MultiSelect = false;
            dgvCheckout1.Name = "dgvCheckout1";
            dgvCheckout1.ReadOnly = true;
            dgvCheckout1.RowHeadersVisible = false;
            dgvCheckout1.RowHeadersWidth = 51;
            dgvCheckout1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout1.Size = new Size(200, 250);
            dgvCheckout1.TabIndex = 3;
            // 
            // dgvCheckout4
            // 
            dgvCheckout4.AllowUserToAddRows = false;
            dgvCheckout4.AllowUserToDeleteRows = false;
            dgvCheckout4.AllowUserToResizeColumns = false;
            dgvCheckout4.AllowUserToResizeRows = false;
            dgvCheckout4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout4.Location = new Point(632, 26);
            dgvCheckout4.MultiSelect = false;
            dgvCheckout4.Name = "dgvCheckout4";
            dgvCheckout4.ReadOnly = true;
            dgvCheckout4.RowHeadersVisible = false;
            dgvCheckout4.RowHeadersWidth = 51;
            dgvCheckout4.Size = new Size(200, 250);
            dgvCheckout4.TabIndex = 6;
            // 
            // dgvCheckout5
            // 
            dgvCheckout5.AllowUserToAddRows = false;
            dgvCheckout5.AllowUserToDeleteRows = false;
            dgvCheckout5.AllowUserToResizeColumns = false;
            dgvCheckout5.AllowUserToResizeRows = false;
            dgvCheckout5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout5.Location = new Point(838, 26);
            dgvCheckout5.MultiSelect = false;
            dgvCheckout5.Name = "dgvCheckout5";
            dgvCheckout5.ReadOnly = true;
            dgvCheckout5.RowHeadersVisible = false;
            dgvCheckout5.RowHeadersWidth = 51;
            dgvCheckout5.Size = new Size(200, 250);
            dgvCheckout5.TabIndex = 7;
            // 
            // dgvCheckout3
            // 
            dgvCheckout3.AllowUserToAddRows = false;
            dgvCheckout3.AllowUserToDeleteRows = false;
            dgvCheckout3.AllowUserToResizeColumns = false;
            dgvCheckout3.AllowUserToResizeRows = false;
            dgvCheckout3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout3.Location = new Point(426, 26);
            dgvCheckout3.MultiSelect = false;
            dgvCheckout3.Name = "dgvCheckout3";
            dgvCheckout3.ReadOnly = true;
            dgvCheckout3.RowHeadersVisible = false;
            dgvCheckout3.RowHeadersWidth = 51;
            dgvCheckout3.Size = new Size(200, 250);
            dgvCheckout3.TabIndex = 5;
            // 
            // dgvCheckout2
            // 
            dgvCheckout2.AllowUserToAddRows = false;
            dgvCheckout2.AllowUserToDeleteRows = false;
            dgvCheckout2.AllowUserToResizeColumns = false;
            dgvCheckout2.AllowUserToResizeRows = false;
            dgvCheckout2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout2.Location = new Point(220, 26);
            dgvCheckout2.MultiSelect = false;
            dgvCheckout2.Name = "dgvCheckout2";
            dgvCheckout2.ReadOnly = true;
            dgvCheckout2.RowHeadersVisible = false;
            dgvCheckout2.RowHeadersWidth = 51;
            dgvCheckout2.Size = new Size(200, 250);
            dgvCheckout2.TabIndex = 4;
            // 
            // dgvCheckout7
            // 
            dgvCheckout7.AllowUserToAddRows = false;
            dgvCheckout7.AllowUserToDeleteRows = false;
            dgvCheckout7.AllowUserToResizeColumns = false;
            dgvCheckout7.AllowUserToResizeRows = false;
            dgvCheckout7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout7.Location = new Point(220, 294);
            dgvCheckout7.MultiSelect = false;
            dgvCheckout7.Name = "dgvCheckout7";
            dgvCheckout7.ReadOnly = true;
            dgvCheckout7.RowHeadersVisible = false;
            dgvCheckout7.RowHeadersWidth = 51;
            dgvCheckout7.Size = new Size(200, 250);
            dgvCheckout7.TabIndex = 9;
            // 
            // dgvCheckout6
            // 
            dgvCheckout6.AllowUserToAddRows = false;
            dgvCheckout6.AllowUserToDeleteRows = false;
            dgvCheckout6.AllowUserToResizeColumns = false;
            dgvCheckout6.AllowUserToResizeRows = false;
            dgvCheckout6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout6.Location = new Point(14, 294);
            dgvCheckout6.MultiSelect = false;
            dgvCheckout6.Name = "dgvCheckout6";
            dgvCheckout6.ReadOnly = true;
            dgvCheckout6.RowHeadersVisible = false;
            dgvCheckout6.RowHeadersWidth = 51;
            dgvCheckout6.Size = new Size(200, 250);
            dgvCheckout6.TabIndex = 8;
            // 
            // dgvCheckout8
            // 
            dgvCheckout8.AllowUserToAddRows = false;
            dgvCheckout8.AllowUserToDeleteRows = false;
            dgvCheckout8.AllowUserToResizeColumns = false;
            dgvCheckout8.AllowUserToResizeRows = false;
            dgvCheckout8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout8.Location = new Point(426, 294);
            dgvCheckout8.MultiSelect = false;
            dgvCheckout8.Name = "dgvCheckout8";
            dgvCheckout8.ReadOnly = true;
            dgvCheckout8.RowHeadersVisible = false;
            dgvCheckout8.RowHeadersWidth = 51;
            dgvCheckout8.Size = new Size(200, 250);
            dgvCheckout8.TabIndex = 10;
            // 
            // dgvCheckout9
            // 
            dgvCheckout9.AllowUserToAddRows = false;
            dgvCheckout9.AllowUserToDeleteRows = false;
            dgvCheckout9.AllowUserToResizeColumns = false;
            dgvCheckout9.AllowUserToResizeRows = false;
            dgvCheckout9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout9.Location = new Point(632, 294);
            dgvCheckout9.MultiSelect = false;
            dgvCheckout9.Name = "dgvCheckout9";
            dgvCheckout9.ReadOnly = true;
            dgvCheckout9.RowHeadersVisible = false;
            dgvCheckout9.RowHeadersWidth = 51;
            dgvCheckout9.Size = new Size(200, 250);
            dgvCheckout9.TabIndex = 11;
            // 
            // dgvCheckout10
            // 
            dgvCheckout10.AllowUserToAddRows = false;
            dgvCheckout10.AllowUserToDeleteRows = false;
            dgvCheckout10.AllowUserToResizeColumns = false;
            dgvCheckout10.AllowUserToResizeRows = false;
            dgvCheckout10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout10.Location = new Point(838, 294);
            dgvCheckout10.MultiSelect = false;
            dgvCheckout10.Name = "dgvCheckout10";
            dgvCheckout10.ReadOnly = true;
            dgvCheckout10.RowHeadersVisible = false;
            dgvCheckout10.RowHeadersWidth = 51;
            dgvCheckout10.Size = new Size(200, 250);
            dgvCheckout10.TabIndex = 12;
            // 
            // gbCheckouts
            // 
            gbCheckouts.Controls.Add(dgvCheckout1);
            gbCheckouts.Controls.Add(dgvCheckout10);
            gbCheckouts.Controls.Add(dgvCheckout4);
            gbCheckouts.Controls.Add(dgvCheckout9);
            gbCheckouts.Controls.Add(dgvCheckout5);
            gbCheckouts.Controls.Add(dgvCheckout8);
            gbCheckouts.Controls.Add(dgvCheckout3);
            gbCheckouts.Controls.Add(dgvCheckout6);
            gbCheckouts.Controls.Add(dgvCheckout2);
            gbCheckouts.Controls.Add(dgvCheckout7);
            gbCheckouts.Location = new Point(12, 142);
            gbCheckouts.Name = "gbCheckouts";
            gbCheckouts.Size = new Size(1056, 559);
            gbCheckouts.TabIndex = 13;
            gbCheckouts.TabStop = false;
            gbCheckouts.Text = "Checkouts";
            // 
            // ntxtCheckoutToDequeue
            // 
            ntxtCheckoutToDequeue.Location = new Point(42, 58);
            ntxtCheckoutToDequeue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ntxtCheckoutToDequeue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ntxtCheckoutToDequeue.Name = "ntxtCheckoutToDequeue";
            ntxtCheckoutToDequeue.Size = new Size(127, 27);
            ntxtCheckoutToDequeue.TabIndex = 4;
            ntxtCheckoutToDequeue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCheckoutToDequeue
            // 
            lblCheckoutToDequeue.AutoSize = true;
            lblCheckoutToDequeue.Location = new Point(42, 29);
            lblCheckoutToDequeue.Name = "lblCheckoutToDequeue";
            lblCheckoutToDequeue.Size = new Size(76, 20);
            lblCheckoutToDequeue.TabIndex = 4;
            lblCheckoutToDequeue.Text = "Cechout #";
            // 
            // gbDequeue
            // 
            gbDequeue.Controls.Add(ntxtCheckoutToDequeue);
            gbDequeue.Controls.Add(lblCheckoutToDequeue);
            gbDequeue.Controls.Add(btnDequeue);
            gbDequeue.Location = new Point(751, 12);
            gbDequeue.Name = "gbDequeue";
            gbDequeue.Size = new Size(200, 131);
            gbDequeue.TabIndex = 4;
            gbDequeue.TabStop = false;
            gbDequeue.Text = "Dequeue";
            // 
            // btnAutoFill
            // 
            btnAutoFill.Location = new Point(451, 55);
            btnAutoFill.Name = "btnAutoFill";
            btnAutoFill.Size = new Size(168, 55);
            btnAutoFill.TabIndex = 4;
            btnAutoFill.Text = "&Auto Fill";
            btnAutoFill.UseVisualStyleBackColor = true;
            btnAutoFill.Click += btnAutoFill_Click;
            // 
            // frmCheckouts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 707);
            Controls.Add(btnAutoFill);
            Controls.Add(gbDequeue);
            Controls.Add(gbCheckouts);
            Controls.Add(gbCartInfo);
            Name = "frmCheckouts";
            Text = "Form1";
            gbCartInfo.ResumeLayout(false);
            gbCartInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ntxtCartSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout10).EndInit();
            gbCheckouts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ntxtCheckoutToDequeue).EndInit();
            gbDequeue.ResumeLayout(false);
            gbDequeue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnqueue;
        private TextBox txtCartNumber;
        private GroupBox gbCartInfo;
        private Label lblSize;
        private Label lblCartNumber;
        private NumericUpDown ntxtCartSize;
        private Button btnDequeue;
        private DataGridView dgvCheckout1;
        private DataGridView dgvCheckout4;
        private DataGridView dgvCheckout5;
        private DataGridView dgvCheckout3;
        private DataGridView dgvCheckout2;
        private DataGridView dgvCheckout7;
        private DataGridView dgvCheckout6;
        private DataGridView dgvCheckout8;
        private DataGridView dgvCheckout9;
        private DataGridView dgvCheckout10;
        private GroupBox gbCheckouts;
        private NumericUpDown ntxtCheckoutToDequeue;
        private Label lblCheckoutToDequeue;
        private GroupBox gbDequeue;
        private Button btnAutoFill;
    }
}
