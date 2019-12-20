namespace MineSweeperMax
{
    partial class MineSweeperV2
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
            this.tileGrid = new MineSweeperMax.MineSweeperV2.TileGrid();
            this.LoadGame = new System.Windows.Forms.Button();
            this.btnFlagV2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(13, 79);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(200, 100);
            this.tileGrid.TabIndex = 0;
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(13, 13);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(60, 60);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "Reset";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // btnFlagV2
            // 
            this.btnFlagV2.Location = new System.Drawing.Point(79, 13);
            this.btnFlagV2.Name = "btnFlagV2";
            this.btnFlagV2.Size = new System.Drawing.Size(60, 60);
            this.btnFlagV2.TabIndex = 3;
            this.btnFlagV2.Text = "Flag";
            this.btnFlagV2.UseVisualStyleBackColor = true;
            this.btnFlagV2.Click += new System.EventHandler(this.btnFlagV2_Click);
            // 
            // MineSweeperV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 262);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.btnFlagV2);
            this.Controls.Add(this.LoadGame);
            this.Name = "MineSweeperV2";
            this.Text = "MineSweeperV2";
            this.ResumeLayout(false);

        }

        #endregion

        private TileGrid tileGrid;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button btnFlagV2;
    }
}