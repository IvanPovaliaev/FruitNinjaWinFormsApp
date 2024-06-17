namespace FruitNinjaWinFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            childFormPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            childFormPanel.Location = new System.Drawing.Point(0, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new System.Drawing.Size(784, 461);
            childFormPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(childFormPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FruitNinja";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel childFormPanel;
    }
}