namespace paymentManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.introWindow = new System.Windows.Forms.Panel();
            this.showData = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.Button();
            this.addPaymentWindow = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.checkPaymentWindow = new System.Windows.Forms.Panel();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.introWindow.SuspendLayout();
            this.addPaymentWindow.SuspendLayout();
            this.checkPaymentWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // introWindow
            // 
            this.introWindow.Controls.Add(this.showData);
            this.introWindow.Controls.Add(this.addData);
            this.introWindow.Location = new System.Drawing.Point(0, 0);
            this.introWindow.MaximumSize = new System.Drawing.Size(800, 450);
            this.introWindow.Name = "introWindow";
            this.introWindow.Size = new System.Drawing.Size(800, 450);
            this.introWindow.TabIndex = 0;
            // 
            // showData
            // 
            this.showData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showData.Location = new System.Drawing.Point(330, 237);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(140, 43);
            this.showData.TabIndex = 1;
            this.showData.Text = "Check Entries";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // addData
            // 
            this.addData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addData.Location = new System.Drawing.Point(339, 150);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(122, 41);
            this.addData.TabIndex = 0;
            this.addData.Text = "Add Entry";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // addPaymentWindow
            // 
            this.addPaymentWindow.Controls.Add(this.lblValue);
            this.addPaymentWindow.Controls.Add(this.lblDescription);
            this.addPaymentWindow.Controls.Add(this.datePayment);
            this.addPaymentWindow.Controls.Add(this.btnClose);
            this.addPaymentWindow.Controls.Add(this.btnSubmit);
            this.addPaymentWindow.Controls.Add(this.txtPaymentName);
            this.addPaymentWindow.Controls.Add(this.txtValue);
            this.addPaymentWindow.Location = new System.Drawing.Point(0, 0);
            this.addPaymentWindow.MaximumSize = new System.Drawing.Size(800, 450);
            this.addPaymentWindow.Name = "addPaymentWindow";
            this.addPaymentWindow.Size = new System.Drawing.Size(0, 0);
            this.addPaymentWindow.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(146, 330);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 15);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(146, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Payment: ";
            // 
            // datePayment
            // 
            this.datePayment.Location = new System.Drawing.Point(146, 105);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(200, 23);
            this.datePayment.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(622, 105);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(585, 316);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Location = new System.Drawing.Point(212, 212);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(373, 23);
            this.txtPaymentName.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(212, 322);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(120, 23);
            this.txtValue.TabIndex = 0;
            // 
            // checkPaymentWindow
            // 
            this.checkPaymentWindow.Controls.Add(this.dataGridView1);
            this.checkPaymentWindow.Controls.Add(this.btnClose2);
            this.checkPaymentWindow.Location = new System.Drawing.Point(0, 0);
            this.checkPaymentWindow.MaximumSize = new System.Drawing.Size(800, 450);
            this.checkPaymentWindow.Name = "checkPaymentWindow";
            this.checkPaymentWindow.Size = new System.Drawing.Size(0, 0);
            this.checkPaymentWindow.TabIndex = 2;
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.btnClose2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose2.Location = new System.Drawing.Point(658, 32);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(41, 28);
            this.btnClose2.TabIndex = 0;
            this.btnClose2.Text = "X";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(506, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkPaymentWindow);
            this.Controls.Add(this.addPaymentWindow);
            this.Controls.Add(this.introWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.introWindow.ResumeLayout(false);
            this.addPaymentWindow.ResumeLayout(false);
            this.addPaymentWindow.PerformLayout();
            this.checkPaymentWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel introWindow;
        private System.Windows.Forms.Panel addPaymentWindow;
        private System.Windows.Forms.Panel checkPaymentWindow;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPaymentName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

