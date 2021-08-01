
namespace Lab4_Ex5_Task
{
    partial class FormRange
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonС = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Границы интервала";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(36, 83);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(104, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxB_Validating);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(169, 83);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(106, 20);
            this.textBoxE.TabIndex = 2;
            this.textBoxE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxE_Validating);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(36, 141);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(128, 34);
            this.buttonS.TabIndex = 3;
            this.buttonS.Text = "Передать данные";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonС
            // 
            this.buttonС.Location = new System.Drawing.Point(183, 140);
            this.buttonС.Name = "buttonС";
            this.buttonС.Size = new System.Drawing.Size(125, 35);
            this.buttonС.TabIndex = 4;
            this.buttonС.Text = "Отменить передачу";
            this.buttonС.UseVisualStyleBackColor = true;
            this.buttonС.Click += new System.EventHandler(this.buttonС_Click);
            // 
            // FormRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.buttonС);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label1);
            this.Name = "FormRange";
            this.Text = "FormRange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonС;
    }
}