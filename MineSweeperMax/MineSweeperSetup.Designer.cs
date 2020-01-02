namespace MineSweeperMax
{
    partial class MineSweeperSetup
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
            this.NewGameCustom = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewGameCustom
            // 
            this.NewGameCustom.Location = new System.Drawing.Point(12, 12);
            this.NewGameCustom.Name = "NewGameCustom";
            this.NewGameCustom.Size = new System.Drawing.Size(100, 50);
            this.NewGameCustom.TabIndex = 83;
            this.NewGameCustom.Text = "Start Game";
            this.NewGameCustom.UseVisualStyleBackColor = true;
            this.NewGameCustom.Click += new System.EventHandler(this.NewGameCustom_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(115, 12);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(103, 17);
            this.lblWidth.TabIndex = 84;
            this.lblWidth.Text = "Width (5 - 25) :";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(224, 12);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(49, 22);
            this.textBoxWidth.TabIndex = 85;
            this.textBoxWidth.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Hight (5 - 25) :";
            // 
            // textBoxHight
            // 
            this.textBoxHight.Location = new System.Drawing.Point(224, 45);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(49, 22);
            this.textBoxHight.TabIndex = 87;
            this.textBoxHight.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 86);
            this.Controls.Add(this.textBoxHight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.NewGameCustom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mine Sweeper Max";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewGameCustom;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHight;
    }
}

