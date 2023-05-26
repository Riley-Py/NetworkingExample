namespace NetworkingExample
{
    partial class Form1
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
            this.textLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.recieveLabel = new System.Windows.Forms.Label();
            this.connectingLabel = new System.Windows.Forms.Label();
            this.clientCheck = new System.Windows.Forms.CheckBox();
            this.serverCheck = new System.Windows.Forms.CheckBox();
            this.clientConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(518, 66);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(151, 20);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Enter your message";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(521, 113);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(148, 26);
            this.messageBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(534, 163);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 35);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // recieveLabel
            // 
            this.recieveLabel.AutoSize = true;
            this.recieveLabel.Location = new System.Drawing.Point(548, 420);
            this.recieveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recieveLabel.Name = "recieveLabel";
            this.recieveLabel.Size = new System.Drawing.Size(98, 20);
            this.recieveLabel.TabIndex = 3;
            this.recieveLabel.Text = "recieveLabel";
            // 
            // connectingLabel
            // 
            this.connectingLabel.AutoSize = true;
            this.connectingLabel.Location = new System.Drawing.Point(566, 335);
            this.connectingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectingLabel.Name = "connectingLabel";
            this.connectingLabel.Size = new System.Drawing.Size(51, 20);
            this.connectingLabel.TabIndex = 4;
            this.connectingLabel.Text = "label1";
            // 
            // clientCheck
            // 
            this.clientCheck.AutoSize = true;
            this.clientCheck.Location = new System.Drawing.Point(753, 66);
            this.clientCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientCheck.Name = "clientCheck";
            this.clientCheck.Size = new System.Drawing.Size(75, 24);
            this.clientCheck.TabIndex = 5;
            this.clientCheck.Text = "Client";
            this.clientCheck.UseVisualStyleBackColor = true;
            // 
            // serverCheck
            // 
            this.serverCheck.AutoSize = true;
            this.serverCheck.Location = new System.Drawing.Point(350, 60);
            this.serverCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverCheck.Name = "serverCheck";
            this.serverCheck.Size = new System.Drawing.Size(81, 24);
            this.serverCheck.TabIndex = 6;
            this.serverCheck.Text = "Server";
            this.serverCheck.UseVisualStyleBackColor = true;
            // 
            // clientConnectButton
            // 
            this.clientConnectButton.Location = new System.Drawing.Point(716, 163);
            this.clientConnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientConnectButton.Name = "clientConnectButton";
            this.clientConnectButton.Size = new System.Drawing.Size(112, 35);
            this.clientConnectButton.TabIndex = 7;
            this.clientConnectButton.Text = "Connect";
            this.clientConnectButton.UseVisualStyleBackColor = true;
            this.clientConnectButton.Click += new System.EventHandler(this.clientConnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.clientConnectButton);
            this.Controls.Add(this.serverCheck);
            this.Controls.Add(this.clientCheck);
            this.Controls.Add(this.connectingLabel);
            this.Controls.Add(this.recieveLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.textLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label recieveLabel;
        private System.Windows.Forms.Label connectingLabel;
        private System.Windows.Forms.CheckBox clientCheck;
        private System.Windows.Forms.CheckBox serverCheck;
        private System.Windows.Forms.Button clientConnectButton;
    }
}

