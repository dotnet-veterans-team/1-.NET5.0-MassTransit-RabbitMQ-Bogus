
namespace AppQueueClient
{
    partial class FrmMain
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
            this.btnVendas = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.CARD_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRASACTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCESSED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPararVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(16, 14);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(133, 60);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "Iniciar Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CARD_NUMBER,
            this.CVV,
            this.NAME,
            this.AMOUNT,
            this.TRASACTION,
            this.PROCESSED});
            this.dgvMain.Location = new System.Drawing.Point(16, 82);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.Size = new System.Drawing.Size(1265, 495);
            this.dgvMain.TabIndex = 1;
            // 
            // CARD_NUMBER
            // 
            this.CARD_NUMBER.HeaderText = "Credit Card Number";
            this.CARD_NUMBER.MinimumWidth = 6;
            this.CARD_NUMBER.Name = "CARD_NUMBER";
            this.CARD_NUMBER.ReadOnly = true;
            this.CARD_NUMBER.Width = 148;
            // 
            // CVV
            // 
            this.CVV.HeaderText = "CVV";
            this.CVV.MinimumWidth = 6;
            this.CVV.Name = "CVV";
            this.CVV.ReadOnly = true;
            this.CVV.Width = 64;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Name";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 74;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "Amount";
            this.AMOUNT.MinimumWidth = 6;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.ReadOnly = true;
            this.AMOUNT.Width = 85;
            // 
            // TRASACTION
            // 
            this.TRASACTION.HeaderText = "Transaction";
            this.TRASACTION.MinimumWidth = 6;
            this.TRASACTION.Name = "TRASACTION";
            this.TRASACTION.ReadOnly = true;
            this.TRASACTION.Width = 112;
            // 
            // PROCESSED
            // 
            this.PROCESSED.HeaderText = "Processed";
            this.PROCESSED.MinimumWidth = 6;
            this.PROCESSED.Name = "PROCESSED";
            this.PROCESSED.ReadOnly = true;
            this.PROCESSED.Width = 81;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(1078, 596);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(203, 60);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPararVendas
            // 
            this.btnPararVendas.Location = new System.Drawing.Point(157, 13);
            this.btnPararVendas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPararVendas.Name = "btnPararVendas";
            this.btnPararVendas.Size = new System.Drawing.Size(133, 60);
            this.btnPararVendas.TabIndex = 5;
            this.btnPararVendas.Text = "Parar Vendas";
            this.btnPararVendas.UseVisualStyleBackColor = true;
            this.btnPararVendas.Click += new System.EventHandler(this.btnPararVendas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 671);
            this.Controls.Add(this.btnPararVendas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnVendas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARD_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASACTION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PROCESSED;
        private System.Windows.Forms.Button btnPararVendas;
    }
}

