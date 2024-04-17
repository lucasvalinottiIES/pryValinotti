namespace pryValinotti
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            label1 = new Label();
            txtName = new TextBox();
            cmdPlay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "Player Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(12, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 43);
            txtName.TabIndex = 1;
            // 
            // cmdPlay
            // 
            cmdPlay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmdPlay.Location = new Point(12, 107);
            cmdPlay.Name = "cmdPlay";
            cmdPlay.Size = new Size(332, 71);
            cmdPlay.TabIndex = 2;
            cmdPlay.Text = "Play!";
            cmdPlay.UseVisualStyleBackColor = true;
            cmdPlay.Click += cmdPlay_Click;
            // 
            // frmPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 190);
            Controls.Add(cmdPlay);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button cmdPlay;
    }
}