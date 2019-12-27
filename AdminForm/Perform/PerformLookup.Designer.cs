namespace AdminForm
{
    partial class PerformLookup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerformDivide = new System.Windows.Forms.Button();
            this.btnPerformChange = new System.Windows.Forms.Button();
            this.fcWorkPlace = new AdminForm.FIndCategory();
            this.label4 = new System.Windows.Forms.Label();
            this.fcFactory = new AdminForm.FIndCategory();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnPerformDivide);
            this.panel1.Controls.Add(this.btnPerformChange);
            this.panel1.Controls.Add(this.fcWorkPlace);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fcFactory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnPerformDivide
            // 
            this.btnPerformDivide.Location = new System.Drawing.Point(1007, 20);
            this.btnPerformDivide.Name = "btnPerformDivide";
            this.btnPerformDivide.Size = new System.Drawing.Size(97, 33);
            this.btnPerformDivide.TabIndex = 10;
            this.btnPerformDivide.Text = "실적분할";
            this.btnPerformDivide.UseVisualStyleBackColor = true;
            // 
            // btnPerformChange
            // 
            this.btnPerformChange.Location = new System.Drawing.Point(885, 20);
            this.btnPerformChange.Name = "btnPerformChange";
            this.btnPerformChange.Size = new System.Drawing.Size(97, 33);
            this.btnPerformChange.TabIndex = 8;
            this.btnPerformChange.Text = "실적보정";
            this.btnPerformChange.UseVisualStyleBackColor = true;
            // 
            // fcWorkPlace
            // 
            this.fcWorkPlace.Location = new System.Drawing.Point(665, 22);
            this.fcWorkPlace.Name = "fcWorkPlace";
            this.fcWorkPlace.Size = new System.Drawing.Size(190, 27);
            this.fcWorkPlace.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(603, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "작업장";
            // 
            // fcFactory
            // 
            this.fcFactory.Location = new System.Drawing.Point(403, 22);
            this.fcFactory.Name = "fcFactory";
            this.fcFactory.Size = new System.Drawing.Size(190, 27);
            this.fcFactory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(357, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "공정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(245, 25);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(98, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(118, 24);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(98, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업지시일자";
            // 
            // PerformLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel1);
            this.Name = "PerformLookup";
            this.Text = "PerformLookup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FIndCategory fcWorkPlace;
        private System.Windows.Forms.Label label4;
        private FIndCategory fcFactory;
        private System.Windows.Forms.Button btnPerformDivide;
        private System.Windows.Forms.Button btnPerformChange;
    }
}