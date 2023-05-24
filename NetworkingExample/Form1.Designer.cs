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
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(345, 43);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(100, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Enter your message";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(345, 95);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(100, 20);
            this.messageBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(358, 169);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // recieveLabel
            // 
            this.recieveLabel.AutoSize = true;
            this.recieveLabel.Location = new System.Drawing.Point(365, 273);
            this.recieveLabel.Name = "recieveLabel";
            this.recieveLabel.Size = new System.Drawing.Size(68, 13);
            this.recieveLabel.TabIndex = 3;
            this.recieveLabel.Text = "recieveLabel";
            // 
            // connectingLabel
            // 
            this.connectingLabel.AutoSize = true;
            this.connectingLabel.Location = new System.Drawing.Point(377, 218);
            this.connectingLabel.Name = "connectingLabel";
            this.connectingLabel.Size = new System.Drawing.Size(35, 13);
            this.connectingLabel.TabIndex = 4;
            this.connectingLabel.Text = "label1";
            // 
            // clientCheck
            // 
            this.clientCheck.AutoSize = true;
            this.clientCheck.Location = new System.Drawing.Point(502, 43);
            this.clientCheck.Name = "clientCheck";
            this.clientCheck.Size = new System.Drawing.Size(52, 17);
            this.clientCheck.TabIndex = 5;
            this.clientCheck.Text = "Client";
            this.clientCheck.UseVisualStyleBackColor = true;
            // 
            // serverCheck
            // 
            this.serverCheck.AutoSize = true;
            this.serverCheck.Location = new System.Drawing.Point(233, 39);
            this.serverCheck.Name = "serverCheck";
            this.serverCheck.Size = new System.Drawing.Size(57, 17);
            this.serverCheck.TabIndex = 6;
            this.serverCheck.Text = "Server";
            this.serverCheck.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(358, 130);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Send";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.serverCheck);
            this.Controls.Add(this.clientCheck);
            this.Controls.Add(this.connectingLabel);
            this.Controls.Add(this.recieveLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.textLabel);
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
        private System.Windows.Forms.Button startButton;
    }
}

