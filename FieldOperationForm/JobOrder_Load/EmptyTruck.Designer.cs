﻿namespace FieldOperationForm
{
    partial class EmptyTruck
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchTruck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Empty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.Ivory;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Search.Location = new System.Drawing.Point(597, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(83, 41);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.Text = "찾기";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_SearchTruck
            // 
            this.txt_SearchTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SearchTruck.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_SearchTruck.Location = new System.Drawing.Point(145, 15);
            this.txt_SearchTruck.Multiline = true;
            this.txt_SearchTruck.Name = "txt_SearchTruck";
            this.txt_SearchTruck.Size = new System.Drawing.Size(446, 41);
            this.txt_SearchTruck.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(11, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "대차 검색";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 548);
            this.dataGridView1.TabIndex = 34;
            // 
            // btn_Empty
            // 
            this.btn_Empty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Empty.BackColor = System.Drawing.Color.Ivory;
            this.btn_Empty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Empty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Empty.Location = new System.Drawing.Point(1290, 68);
            this.btn_Empty.Name = "btn_Empty";
            this.btn_Empty.Size = new System.Drawing.Size(243, 548);
            this.btn_Empty.TabIndex = 35;
            this.btn_Empty.Text = "대차 비우기";
            this.btn_Empty.UseVisualStyleBackColor = false;
            // 
            // EmptyTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.btn_Empty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchTruck);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmptyTruck";
            this.Text = "EmptyTruck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_SearchTruck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Empty;
    }
}