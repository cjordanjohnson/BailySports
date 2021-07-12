﻿namespace BailySports_Application
{
    partial class Evaluation
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
            this.ddEvaluationType = new System.Windows.Forms.ComboBox();
            this.evaluationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bailySportsData = new BailySports_Application.BailySportsData();
            this.evaluationTypesTableAdapter = new BailySports_Application.BailySportsDataTableAdapters.EvaluationTypesTableAdapter();
            this.ddPlayer = new System.Windows.Forms.ComboBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new BailySports_Application.BailySportsDataTableAdapters.PlayersTableAdapter();
            this.dgvFunctionalMovementScores = new System.Windows.Forms.DataGridView();
            this.functionalMovementScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bailySportsData1 = new BailySports_Application.BailySportsData();
            this.tbEvaluationID = new System.Windows.Forms.TextBox();
            this.functionalMovementScoresTableAdapter = new BailySports_Application.BailySportsDataTableAdapters.FunctionalMovementScoresTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.functionalMovementsQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.functionalMovementsQueryTableAdapter = new BailySports_Application.BailySportsDataTableAdapters.FunctionalMovementsQueryTableAdapter();
            this.FMScoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionalMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawScoreSingle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawScoreLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawScoreRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectiveExcersize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleScore = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionalMovementScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalMovementScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalMovementsQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ddEvaluationType
            // 
            this.ddEvaluationType.DataSource = this.evaluationTypesBindingSource;
            this.ddEvaluationType.DisplayMember = "EvaluationDescription";
            this.ddEvaluationType.FormattingEnabled = true;
            this.ddEvaluationType.Location = new System.Drawing.Point(12, 23);
            this.ddEvaluationType.Name = "ddEvaluationType";
            this.ddEvaluationType.Size = new System.Drawing.Size(244, 24);
            this.ddEvaluationType.TabIndex = 0;
            this.ddEvaluationType.ValueMember = "EvaluationType";
            // 
            // evaluationTypesBindingSource
            // 
            this.evaluationTypesBindingSource.DataMember = "EvaluationTypes";
            this.evaluationTypesBindingSource.DataSource = this.bailySportsData;
            // 
            // bailySportsData
            // 
            this.bailySportsData.DataSetName = "BailySportsData";
            this.bailySportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluationTypesTableAdapter
            // 
            this.evaluationTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ddPlayer
            // 
            this.ddPlayer.DataSource = this.playersBindingSource;
            this.ddPlayer.DisplayMember = "LastName";
            this.ddPlayer.FormattingEnabled = true;
            this.ddPlayer.Location = new System.Drawing.Point(12, 53);
            this.ddPlayer.Name = "ddPlayer";
            this.ddPlayer.Size = new System.Drawing.Size(244, 24);
            this.ddPlayer.TabIndex = 1;
            this.ddPlayer.ValueMember = "PlayerID";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.bailySportsData;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFunctionalMovementScores
            // 
            this.dgvFunctionalMovementScores.AutoGenerateColumns = false;
            this.dgvFunctionalMovementScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionalMovementScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FMScoreID,
            this.EvaluationID,
            this.FunctionalMovement,
            this.RawScoreSingle,
            this.RawScoreLeft,
            this.RawScoreRight,
            this.FinalScore,
            this.CorrectiveExcersize,
            this.SingleScore});
            this.dgvFunctionalMovementScores.DataSource = this.functionalMovementsQueryBindingSource;
            this.dgvFunctionalMovementScores.Location = new System.Drawing.Point(12, 139);
            this.dgvFunctionalMovementScores.Name = "dgvFunctionalMovementScores";
            this.dgvFunctionalMovementScores.RowTemplate.Height = 24;
            this.dgvFunctionalMovementScores.Size = new System.Drawing.Size(1360, 123);
            this.dgvFunctionalMovementScores.TabIndex = 2;
            // 
            // functionalMovementScoresBindingSource
            // 
            this.functionalMovementScoresBindingSource.DataMember = "FunctionalMovementScores";
            this.functionalMovementScoresBindingSource.DataSource = this.bailySportsData1;
            // 
            // bailySportsData1
            // 
            this.bailySportsData1.DataSetName = "BailySportsData";
            this.bailySportsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEvaluationID
            // 
            this.tbEvaluationID.Location = new System.Drawing.Point(448, 24);
            this.tbEvaluationID.Name = "tbEvaluationID";
            this.tbEvaluationID.Size = new System.Drawing.Size(93, 22);
            this.tbEvaluationID.TabIndex = 3;
            this.tbEvaluationID.Text = "-1";
            // 
            // functionalMovementScoresTableAdapter
            // 
            this.functionalMovementScoresTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // functionalMovementsQueryBindingSource
            // 
            this.functionalMovementsQueryBindingSource.DataMember = "FunctionalMovementsQuery";
            this.functionalMovementsQueryBindingSource.DataSource = this.bailySportsData;
            // 
            // functionalMovementsQueryTableAdapter
            // 
            this.functionalMovementsQueryTableAdapter.ClearBeforeFill = true;
            // 
            // FMScoreID
            // 
            this.FMScoreID.DataPropertyName = "FMScoreID";
            this.FMScoreID.HeaderText = "FMScoreID";
            this.FMScoreID.Name = "FMScoreID";
            // 
            // EvaluationID
            // 
            this.EvaluationID.DataPropertyName = "EvaluationID";
            this.EvaluationID.HeaderText = "EvaluationID";
            this.EvaluationID.Name = "EvaluationID";
            // 
            // FunctionalMovement
            // 
            this.FunctionalMovement.DataPropertyName = "FunctionalMovement";
            this.FunctionalMovement.HeaderText = "FunctionalMovement";
            this.FunctionalMovement.Name = "FunctionalMovement";
            // 
            // RawScoreSingle
            // 
            this.RawScoreSingle.DataPropertyName = "RawScoreSingle";
            this.RawScoreSingle.HeaderText = "RawScoreSingle";
            this.RawScoreSingle.Name = "RawScoreSingle";
            // 
            // RawScoreLeft
            // 
            this.RawScoreLeft.DataPropertyName = "RawScoreLeft";
            this.RawScoreLeft.HeaderText = "RawScoreLeft";
            this.RawScoreLeft.Name = "RawScoreLeft";
            // 
            // RawScoreRight
            // 
            this.RawScoreRight.DataPropertyName = "RawScoreRight";
            this.RawScoreRight.HeaderText = "RawScoreRight";
            this.RawScoreRight.Name = "RawScoreRight";
            // 
            // FinalScore
            // 
            this.FinalScore.DataPropertyName = "FinalScore";
            this.FinalScore.HeaderText = "FinalScore";
            this.FinalScore.Name = "FinalScore";
            // 
            // CorrectiveExcersize
            // 
            this.CorrectiveExcersize.DataPropertyName = "CorrectiveExcersize";
            this.CorrectiveExcersize.HeaderText = "CorrectiveExcersize";
            this.CorrectiveExcersize.Name = "CorrectiveExcersize";
            // 
            // SingleScore
            // 
            this.SingleScore.DataPropertyName = "SingleScore";
            this.SingleScore.HeaderText = "SingleScore";
            this.SingleScore.Name = "SingleScore";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEvaluationID);
            this.Controls.Add(this.dgvFunctionalMovementScores);
            this.Controls.Add(this.ddPlayer);
            this.Controls.Add(this.ddEvaluationType);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionalMovementScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalMovementScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailySportsData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalMovementsQueryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddEvaluationType;
        private BailySportsData bailySportsData;
        private System.Windows.Forms.BindingSource evaluationTypesBindingSource;
        private BailySportsDataTableAdapters.EvaluationTypesTableAdapter evaluationTypesTableAdapter;
        private System.Windows.Forms.ComboBox ddPlayer;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private BailySportsDataTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridView dgvFunctionalMovementScores;
        private System.Windows.Forms.TextBox tbEvaluationID;
        private BailySportsData bailySportsData1;
        private System.Windows.Forms.BindingSource functionalMovementScoresBindingSource;
        private BailySportsDataTableAdapters.FunctionalMovementScoresTableAdapter functionalMovementScoresTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource functionalMovementsQueryBindingSource;
        private BailySportsDataTableAdapters.FunctionalMovementsQueryTableAdapter functionalMovementsQueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FMScoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionalMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawScoreSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawScoreLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawScoreRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectiveExcersize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SingleScore;
    }
}