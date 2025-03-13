namespace winform_charts_visitor
{
    partial class IngameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngameMenu));
            this.attackButton = new ReaLTaiizor.Controls.AirButton();
            this.characterPanel = new System.Windows.Forms.Panel();
            this.runButton = new ReaLTaiizor.Controls.AirButton();
            this.dieButton = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.attackButton.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.attackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attackButton.Image = null;
            this.attackButton.Location = new System.Drawing.Point(243, 555);
            this.attackButton.Name = "attackButton";
            this.attackButton.NoRounding = false;
            this.attackButton.Size = new System.Drawing.Size(163, 63);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Attack";
            this.attackButton.Transparent = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // characterPanel
            // 
            this.characterPanel.BackColor = System.Drawing.Color.Transparent;
            this.characterPanel.Location = new System.Drawing.Point(75, 51);
            this.characterPanel.Name = "characterPanel";
            this.characterPanel.Size = new System.Drawing.Size(1154, 482);
            this.characterPanel.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.runButton.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.runButton.Image = null;
            this.runButton.Location = new System.Drawing.Point(531, 555);
            this.runButton.Name = "runButton";
            this.runButton.NoRounding = false;
            this.runButton.Size = new System.Drawing.Size(163, 63);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.Transparent = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // dieButton
            // 
            this.dieButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dieButton.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.dieButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dieButton.Image = null;
            this.dieButton.Location = new System.Drawing.Point(789, 555);
            this.dieButton.Name = "dieButton";
            this.dieButton.NoRounding = false;
            this.dieButton.Size = new System.Drawing.Size(163, 63);
            this.dieButton.TabIndex = 4;
            this.dieButton.Text = "Die";
            this.dieButton.Transparent = false;
            this.dieButton.Click += new System.EventHandler(this.dieButton_Click);
            // 
            // IngameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dieButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.characterPanel);
            this.Controls.Add(this.attackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IngameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngameMenu";
            this.Load += new System.EventHandler(this.IngameMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.AirButton attackButton;
        private System.Windows.Forms.Panel characterPanel;
        private ReaLTaiizor.Controls.AirButton runButton;
        private ReaLTaiizor.Controls.AirButton dieButton;
    }
}