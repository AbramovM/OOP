namespace Голосование
{
    partial class Form4
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
            this.Golos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedCandidateBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.votingDataSet = new Голосование.VotingDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatesTableAdapter = new Голосование.VotingDataSetTableAdapters.candidatesTableAdapter();
            this.candidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polyticalpartyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Golos
            // 
            this.Golos.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Golos.Location = new System.Drawing.Point(16, 310);
            this.Golos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Golos.Name = "Golos";
            this.Golos.Size = new System.Drawing.Size(206, 35);
            this.Golos.TabIndex = 0;
            this.Golos.Text = "Проголосувати";
            this.Golos.UseVisualStyleBackColor = true;
            this.Golos.Click += new System.EventHandler(this.Golos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваш вибір";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список кандидатів";
            // 
            // SelectedCandidateBox
            // 
            this.SelectedCandidateBox.DataSource = this.candidatesBindingSource1;
            this.SelectedCandidateBox.DisplayMember = "Id";
            this.SelectedCandidateBox.FormattingEnabled = true;
            this.SelectedCandidateBox.Location = new System.Drawing.Point(16, 270);
            this.SelectedCandidateBox.Name = "SelectedCandidateBox";
            this.SelectedCandidateBox.Size = new System.Drawing.Size(247, 24);
            this.SelectedCandidateBox.TabIndex = 5;
            this.SelectedCandidateBox.Text = "Оберіть Id кандидата";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.votingDataSet;
            this.bindingSource1.Position = 0;
            // 
            // votingDataSet
            // 
            this.votingDataSet.DataSetName = "VotingDataSet";
            this.votingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.polyticalpartyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 182);
            this.dataGridView1.TabIndex = 6;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "candidates";
            this.candidatesBindingSource.DataSource = this.bindingSource1;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // candidatesBindingSource1
            // 
            this.candidatesBindingSource1.DataMember = "candidates";
            this.candidatesBindingSource1.DataSource = this.bindingSource1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polyticalpartyDataGridViewTextBoxColumn
            // 
            this.polyticalpartyDataGridViewTextBoxColumn.DataPropertyName = "Polytical_party";
            this.polyticalpartyDataGridViewTextBoxColumn.HeaderText = "Політична партія";
            this.polyticalpartyDataGridViewTextBoxColumn.Name = "polyticalpartyDataGridViewTextBoxColumn";
            this.polyticalpartyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Голосование.Properties.Resources._141011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectedCandidateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Golos);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список кандидатів";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Golos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectedCandidateBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private VotingDataSet votingDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private VotingDataSetTableAdapters.candidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.BindingSource candidatesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polyticalpartyDataGridViewTextBoxColumn;
    }
}