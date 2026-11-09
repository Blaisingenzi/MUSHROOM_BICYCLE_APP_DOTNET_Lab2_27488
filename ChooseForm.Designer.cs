namespace BicycleMushroomApp
{
    partial class ChooseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnBicycle = new Button();
            btnMushroom = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(33, 38);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose a program";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBicycle
            // 
            btnBicycle.Location = new Point(67, 173);
            btnBicycle.Margin = new Padding(5, 6, 5, 6);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(250, 115);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle Rental";
            btnBicycle.BackColor = Color.SteelBlue;
            btnBicycle.ForeColor = Color.White;
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.Location = new Point(350, 173);
            btnMushroom.Margin = new Padding(5, 6, 5, 6);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(250, 115);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom Identifier";
            btnMushroom.BackColor = Color.DarkGoldenrod;
            btnMushroom.ForeColor = Color.White;
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(67, 315);
            btnLogout.Margin = new Padding(5, 6, 5, 6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(533, 35);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.ForeColor = Color.White;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 385);
            Controls.Add(lblTitle);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            FormClosed += ChooseForm_FormClosed;
            Load += ChooseForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;
        private System.Windows.Forms.Button btnLogout;
    }
}