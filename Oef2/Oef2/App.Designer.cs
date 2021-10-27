namespace Oef2
{
    partial class Gemiddelde
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
            this.GetallenLijst = new System.Windows.Forms.ListBox();
            this.NieuwGetalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetallenLijst
            // 
            this.GetallenLijst.FormattingEnabled = true;
            this.GetallenLijst.ItemHeight = 20;
            this.GetallenLijst.Location = new System.Drawing.Point(233, 74);
            this.GetallenLijst.Name = "GetallenLijst";
            this.GetallenLijst.Size = new System.Drawing.Size(404, 224);
            this.GetallenLijst.TabIndex = 0;
            // 
            // NieuwGetalButton
            // 
            this.NieuwGetalButton.Location = new System.Drawing.Point(358, 317);
            this.NieuwGetalButton.Name = "NieuwGetalButton";
            this.NieuwGetalButton.Size = new System.Drawing.Size(170, 29);
            this.NieuwGetalButton.TabIndex = 1;
            this.NieuwGetalButton.Text = "Nieuw Getal";
            this.NieuwGetalButton.UseVisualStyleBackColor = true;
            this.NieuwGetalButton.Click += new System.EventHandler(this.NieuwGetalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "GemiddeldeBerekener";
            // 
            // gem
            // 
            this.gem.Enabled = false;
            this.gem.Location = new System.Drawing.Point(411, 373);
            this.gem.Name = "gem";
            this.gem.Size = new System.Drawing.Size(125, 27);
            this.gem.TabIndex = 3;
            // 
            // Gemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 541);
            this.Controls.Add(this.gem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NieuwGetalButton);
            this.Controls.Add(this.GetallenLijst);
            this.Name = "Gemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NieuwGetalButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox GetallenLijst;
        public System.Windows.Forms.TextBox gem;
    }
}
