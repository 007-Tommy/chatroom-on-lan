namespace ChatroomOnLAN
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            UsernameLbl = new Label();
            Username = new TextBox();
            Port = new TextBox();
            PortLbl = new Label();
            Connect = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(192, 30);
            Title.TabIndex = 0;
            Title.Text = "Chatroom on LAN";
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Location = new Point(24, 52);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(63, 15);
            UsernameLbl.TabIndex = 1;
            UsernameLbl.Text = "Username:";
            // 
            // Username
            // 
            Username.Location = new Point(93, 49);
            Username.Name = "Username";
            Username.Size = new Size(99, 23);
            Username.TabIndex = 2;
            // 
            // Port
            // 
            Port.Location = new Point(93, 78);
            Port.Name = "Port";
            Port.Size = new Size(99, 23);
            Port.TabIndex = 4;
            // 
            // PortLbl
            // 
            PortLbl.AutoSize = true;
            PortLbl.Location = new Point(55, 81);
            PortLbl.Name = "PortLbl";
            PortLbl.Size = new Size(32, 15);
            PortLbl.TabIndex = 3;
            PortLbl.Text = "Port:";
            // 
            // Connect
            // 
            Connect.Location = new Point(24, 108);
            Connect.Name = "Connect";
            Connect.Size = new Size(169, 23);
            Connect.TabIndex = 5;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 145);
            Controls.Add(Connect);
            Controls.Add(Port);
            Controls.Add(PortLbl);
            Controls.Add(Username);
            Controls.Add(UsernameLbl);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label UsernameLbl;
        private TextBox Username;
        private TextBox Port;
        private Label PortLbl;
        private Button Connect;
    }
}
