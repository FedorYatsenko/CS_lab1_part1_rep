namespace CS_lab1
{
    partial class Form1
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFileame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEntr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.checkBoxEnter = new System.Windows.Forms.CheckBox();
            this.checkBoxUpercase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(78, 138);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(200, 70);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Відкрити файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(400, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 516);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файл:";
            // 
            // labelFileame
            // 
            this.labelFileame.AutoSize = true;
            this.labelFileame.Location = new System.Drawing.Point(27, 286);
            this.labelFileame.Name = "labelFileame";
            this.labelFileame.Size = new System.Drawing.Size(46, 13);
            this.labelFileame.TabIndex = 3;
            this.labelFileame.Text = "filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Середня ентропія алфавіта:";
            // 
            // labelEntr
            // 
            this.labelEntr.AutoSize = true;
            this.labelEntr.Location = new System.Drawing.Point(27, 358);
            this.labelEntr.Name = "labelEntr";
            this.labelEntr.Size = new System.Drawing.Size(33, 13);
            this.labelEntr.TabIndex = 3;
            this.labelEntr.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість інформації в тексті :";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(27, 436);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(33, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Розмір файлу:";
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(27, 506);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(33, 13);
            this.labelFileSize.TabIndex = 3;
            this.labelFileSize.Text = "value";
            // 
            // checkBoxEnter
            // 
            this.checkBoxEnter.AutoSize = true;
            this.checkBoxEnter.Location = new System.Drawing.Point(30, 46);
            this.checkBoxEnter.Name = "checkBoxEnter";
            this.checkBoxEnter.Size = new System.Drawing.Size(232, 17);
            this.checkBoxEnter.TabIndex = 4;
            this.checkBoxEnter.Text = "Враховувати пернос на наступний рядок";
            this.checkBoxEnter.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpercase
            // 
            this.checkBoxUpercase.AutoSize = true;
            this.checkBoxUpercase.Location = new System.Drawing.Point(30, 94);
            this.checkBoxUpercase.Name = "checkBoxUpercase";
            this.checkBoxUpercase.Size = new System.Drawing.Size(129, 17);
            this.checkBoxUpercase.TabIndex = 5;
            this.checkBoxUpercase.Text = "Враховувати регістр";
            this.checkBoxUpercase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 558);
            this.Controls.Add(this.checkBoxUpercase);
            this.Controls.Add(this.checkBoxEnter);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelEntr);
            this.Controls.Add(this.labelFileame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFileame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEntr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.CheckBox checkBoxEnter;
        private System.Windows.Forms.CheckBox checkBoxUpercase;
    }
}

