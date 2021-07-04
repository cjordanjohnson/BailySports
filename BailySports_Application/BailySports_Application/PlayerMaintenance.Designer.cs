namespace BailySports_Application
{
    partial class PlayerMaintenance
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
            this.bailySportsData1 = new BailySports_Application.BailySportsData();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new BailySports_Application.BailySportsDataTableAdapters.PlayersTableAdapter();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightInches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bailySportsData1
            // 
            this.bailySportsData1.DataSetName = "BailySportsData";
            this.bailySportsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.ClientDate,
            this.BirthDate,
            this.Arm,
            this.HeightInches,
            this.Weight,
            this.Update});
            this.dgvPlayers.DataSource = this.playersBindingSource;
            this.dgvPlayers.Location = new System.Drawing.Point(12, 12);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(1413, 230);
            this.dgvPlayers.TabIndex = 1;
            this.dgvPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellContentClick);
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.bailySportsData1;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "PlayerID";
            this.PlayerID.Name = "PlayerID";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            // 
            // ClientDate
            // 
            this.ClientDate.DataPropertyName = "ClientDate";
            this.ClientDate.HeaderText = "ClientDate";
            this.ClientDate.Name = "ClientDate";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // Arm
            // 
            this.Arm.DataPropertyName = "Arm";
            this.Arm.HeaderText = "Arm";
            this.Arm.Name = "Arm";
            // 
            // HeightInches
            // 
            this.HeightInches.DataPropertyName = "HeightInches";
            this.HeightInches.HeaderText = "HeightInches";
            this.HeightInches.Name = "HeightInches";
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // PlayerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 450);
            this.Controls.Add(this.dgvPlayers);
            this.Name = "PlayerMaintenance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlayerMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BailySportsData bailySportsData1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private BailySportsDataTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arm;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightInches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}

