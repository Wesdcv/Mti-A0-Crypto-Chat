
namespace ChatP2P
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ChatButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.OtherPortTextBox = new System.Windows.Forms.TextBox();
            this.OtherIPTextBox = new System.Windows.Forms.TextBox();
            this.MyPortTextBox = new System.Windows.Forms.TextBox();
            this.MyIPTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AccessibleDescription = "";
            this.HeaderPanel.AccessibleName = "";
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.label6);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 41);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.Tag = "";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(745, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "MTI/A(0) Chat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::ChatP2P.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(764, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 33);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChatButton
            // 
            this.ChatButton.Location = new System.Drawing.Point(0, 0);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Size = new System.Drawing.Size(75, 23);
            this.ChatButton.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Controls.Add(this.ChatPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 507);
            this.MainPanel.TabIndex = 2;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.OtherPortTextBox);
            this.SettingsPanel.Controls.Add(this.OtherIPTextBox);
            this.SettingsPanel.Controls.Add(this.MyPortTextBox);
            this.SettingsPanel.Controls.Add(this.MyIPTextBox);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.NicknameTextBox);
            this.SettingsPanel.Controls.Add(this.ConnectButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(800, 507);
            this.SettingsPanel.TabIndex = 1;
            // 
            // OtherPortTextBox
            // 
            this.OtherPortTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.OtherPortTextBox.Location = new System.Drawing.Point(400, 121);
            this.OtherPortTextBox.Name = "OtherPortTextBox";
            this.OtherPortTextBox.Size = new System.Drawing.Size(388, 33);
            this.OtherPortTextBox.TabIndex = 10;
            this.OtherPortTextBox.Text = "8002";
            // 
            // OtherIPTextBox
            // 
            this.OtherIPTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.OtherIPTextBox.Location = new System.Drawing.Point(400, 50);
            this.OtherIPTextBox.Name = "OtherIPTextBox";
            this.OtherIPTextBox.Size = new System.Drawing.Size(388, 33);
            this.OtherIPTextBox.TabIndex = 9;
            // 
            // MyPortTextBox
            // 
            this.MyPortTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MyPortTextBox.Location = new System.Drawing.Point(31, 121);
            this.MyPortTextBox.Name = "MyPortTextBox";
            this.MyPortTextBox.Size = new System.Drawing.Size(359, 33);
            this.MyPortTextBox.TabIndex = 8;
            this.MyPortTextBox.Text = "8001";
            // 
            // MyIPTextBox
            // 
            this.MyIPTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MyIPTextBox.Location = new System.Drawing.Point(31, 48);
            this.MyIPTextBox.Name = "MyIPTextBox";
            this.MyIPTextBox.Size = new System.Drawing.Size(359, 33);
            this.MyIPTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label5.Location = new System.Drawing.Point(396, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Remote Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label4.Location = new System.Drawing.Point(396, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Remote IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP";
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.NicknameTextBox.Location = new System.Drawing.Point(31, 194);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(359, 33);
            this.NicknameTextBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Image = global::ChatP2P.Properties.Resources.saveSettings;
            this.ConnectButton.Location = new System.Drawing.Point(686, 406);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 64);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.SendButton);
            this.ChatPanel.Controls.Add(this.MessageTextBox);
            this.ChatPanel.Controls.Add(this.ChatTextBox);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(800, 507);
            this.ChatPanel.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Aqua;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Text= "Send ->";
            this.SendButton.Location = new System.Drawing.Point(720, 400);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(80, 107);
            this.SendButton.TabIndex = 2;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageTextBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.MessageTextBox.Location = new System.Drawing.Point(0, 400);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(720, 107);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatTextBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ChatTextBox.Location = new System.Drawing.Point(0, 0);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(800, 400);
            this.ChatTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.HeaderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button ChatButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.TextBox OtherPortTextBox;
        private System.Windows.Forms.TextBox OtherIPTextBox;
        private System.Windows.Forms.TextBox MyPortTextBox;
        private System.Windows.Forms.TextBox MyIPTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label6;
    }
}

