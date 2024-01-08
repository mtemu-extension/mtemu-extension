
namespace mtemu
{
    partial class CtrlRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlRegForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCtrlRegValue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение\r\nрегистра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNameMapCall
            // 
            this.textBoxCtrlRegValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCtrlRegValue.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCtrlRegValue.Location = new System.Drawing.Point(89, 112);
            this.textBoxCtrlRegValue.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxCtrlRegValue.MaxLength = 8;
            this.textBoxCtrlRegValue.Name = "textBoxCtrlRegValue";
            this.textBoxCtrlRegValue.Size = new System.Drawing.Size(207, 54);
            this.textBoxCtrlRegValue.TabIndex = 20;
            this.textBoxCtrlRegValue.Text = "00000000";
            this.textBoxCtrlRegValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCtrlRegValue.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCtrlRegValue);
            this.panel1.Location = new System.Drawing.Point(20, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 186);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6);
            this.label3.Size = new System.Drawing.Size(337, 200);
            this.label3.TabIndex = 22;
            this.label3.Text = "BIT7: GPIOA=0/UART=1\r\nBIT6: GPIOC=0/SPI=1\r\nBIT5: GPIOE=0/I2C=1\r\nBIT4: не использу" +
    "ется\r\nBIT3: GPIOA OUTPUT=0/INPUT=1\r\nBIT2: GPIOC OUTPUT=0/INPUT=1\r\nBIT1: GPIOE OU" +
    "TPUT=0/INPUT=1\r\nBIT0: не используется";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "Справка\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 287);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(29, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 530);
            this.panel3.TabIndex = 24;
            // 
            // CtrlRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 556);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CtrlRegForm";
            this.Text = "Управляющий регистр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlRegFormClosing_);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxCtrlRegValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}