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
            this.bailySportsData1 = new BailySports_Application.BailySportsData();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).BeginInit();
            this.SuspendLayout();
            // 
            // bailySportsData1
            // 
            this.bailySportsData1.DataSetName = "BailySportsData";
            this.bailySportsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "PlayerMaintenance";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BailySportsData bailySportsData1;
        private System.Windows.Forms.Button button1;
    }
}

