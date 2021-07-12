namespace BailySports_Application
{
    partial class Menu
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
            this.btnPlayerMaint = new System.Windows.Forms.Button();
            this.btnEvaluations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayerMaint
            // 
            this.btnPlayerMaint.Location = new System.Drawing.Point(34, 25);
            this.btnPlayerMaint.Name = "btnPlayerMaint";
            this.btnPlayerMaint.Size = new System.Drawing.Size(153, 41);
            this.btnPlayerMaint.TabIndex = 0;
            this.btnPlayerMaint.Text = "Player Maintenance";
            this.btnPlayerMaint.UseVisualStyleBackColor = true;
            this.btnPlayerMaint.Click += new System.EventHandler(this.btnPlayerMaint_Click);
            // 
            // btnEvaluations
            // 
            this.btnEvaluations.Location = new System.Drawing.Point(34, 90);
            this.btnEvaluations.Name = "btnEvaluations";
            this.btnEvaluations.Size = new System.Drawing.Size(153, 41);
            this.btnEvaluations.TabIndex = 1;
            this.btnEvaluations.Text = "Evaluations";
            this.btnEvaluations.UseVisualStyleBackColor = true;
            this.btnEvaluations.Click += new System.EventHandler(this.btnEvaluations_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEvaluations);
            this.Controls.Add(this.btnPlayerMaint);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayerMaint;
        private System.Windows.Forms.Button btnEvaluations;
    }
}