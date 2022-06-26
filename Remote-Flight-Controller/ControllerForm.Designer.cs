namespace _15015009
{
    partial class ControllerForm
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
            this.lblConnect = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblShowAltitude = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblShowSpeed = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.lblShowPitch = new System.Windows.Forms.Label();
            this.lblShowVerticalSpeed = new System.Windows.Forms.Label();
            this.lblShowThrottle = new System.Windows.Forms.Label();
            this.lblShowElevatorPitch = new System.Windows.Forms.Label();
            this.lblWarningCode = new System.Windows.Forms.Label();
            this.lblShowWarningCode = new System.Windows.Forms.Label();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendThrottle = new System.Windows.Forms.TextBox();
            this.txtSendElevatorPitch = new System.Windows.Forms.TextBox();
            this.lblEnterElePitch = new System.Windows.Forms.Label();
            this.lblEnterThrottle = new System.Windows.Forms.Label();
            this.lbSentControlData = new System.Windows.Forms.ListBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.chkAutoPilot = new System.Windows.Forms.CheckBox();
            this.grpConnectToSim = new System.Windows.Forms.GroupBox();
            this.grpTelemetryData = new System.Windows.Forms.GroupBox();
            this.grpControlData = new System.Windows.Forms.GroupBox();
            this.grpMessagesSent = new System.Windows.Forms.GroupBox();
            this.grpWarning = new System.Windows.Forms.GroupBox();
            this.lblDisplayWarningNote = new System.Windows.Forms.Label();
            this.grpConnectToSim.SuspendLayout();
            this.grpTelemetryData.SuspendLayout();
            this.grpControlData.SuspendLayout();
            this.grpMessagesSent.SuspendLayout();
            this.grpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(5, 16);
            this.lblConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(201, 13);
            this.lblConnect.TabIndex = 0;
            this.lblConnect.Text = "Please enter the IP Adress to connect to:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(34, 40);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(101, 20);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertOnKeyPress);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(142, 97);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(64, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(94, 20);
            this.lblAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(13, 13);
            this.lblAltitude.TabIndex = 3;
            this.lblAltitude.Text = "0";
            // 
            // lblShowAltitude
            // 
            this.lblShowAltitude.AutoSize = true;
            this.lblShowAltitude.Location = new System.Drawing.Point(5, 20);
            this.lblShowAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowAltitude.Name = "lblShowAltitude";
            this.lblShowAltitude.Size = new System.Drawing.Size(45, 13);
            this.lblShowAltitude.TabIndex = 5;
            this.lblShowAltitude.Text = "Altitude:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(94, 43);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "0";
            // 
            // lblShowSpeed
            // 
            this.lblShowSpeed.AutoSize = true;
            this.lblShowSpeed.Location = new System.Drawing.Point(5, 43);
            this.lblShowSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowSpeed.Name = "lblShowSpeed";
            this.lblShowSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblShowSpeed.TabIndex = 7;
            this.lblShowSpeed.Text = "Speed:";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(94, 65);
            this.lblPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(13, 13);
            this.lblPitch.TabIndex = 8;
            this.lblPitch.Text = "0";
            // 
            // lblVerticalSpeed
            // 
            this.lblVerticalSpeed.AutoSize = true;
            this.lblVerticalSpeed.Location = new System.Drawing.Point(94, 88);
            this.lblVerticalSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            this.lblVerticalSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblVerticalSpeed.TabIndex = 9;
            this.lblVerticalSpeed.Text = "0";
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(94, 110);
            this.lblThrottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(13, 13);
            this.lblThrottle.TabIndex = 10;
            this.lblThrottle.Text = "0";
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(94, 133);
            this.lblElevatorPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(13, 13);
            this.lblElevatorPitch.TabIndex = 11;
            this.lblElevatorPitch.Text = "0";
            // 
            // lblShowPitch
            // 
            this.lblShowPitch.AutoSize = true;
            this.lblShowPitch.Location = new System.Drawing.Point(5, 65);
            this.lblShowPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowPitch.Name = "lblShowPitch";
            this.lblShowPitch.Size = new System.Drawing.Size(34, 13);
            this.lblShowPitch.TabIndex = 12;
            this.lblShowPitch.Text = "Pitch:";
            // 
            // lblShowVerticalSpeed
            // 
            this.lblShowVerticalSpeed.AutoSize = true;
            this.lblShowVerticalSpeed.Location = new System.Drawing.Point(5, 88);
            this.lblShowVerticalSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowVerticalSpeed.Name = "lblShowVerticalSpeed";
            this.lblShowVerticalSpeed.Size = new System.Drawing.Size(79, 13);
            this.lblShowVerticalSpeed.TabIndex = 13;
            this.lblShowVerticalSpeed.Text = "Vertical Speed:";
            // 
            // lblShowThrottle
            // 
            this.lblShowThrottle.AutoSize = true;
            this.lblShowThrottle.Location = new System.Drawing.Point(5, 110);
            this.lblShowThrottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowThrottle.Name = "lblShowThrottle";
            this.lblShowThrottle.Size = new System.Drawing.Size(46, 13);
            this.lblShowThrottle.TabIndex = 14;
            this.lblShowThrottle.Text = "Throttle:";
            // 
            // lblShowElevatorPitch
            // 
            this.lblShowElevatorPitch.AutoSize = true;
            this.lblShowElevatorPitch.Location = new System.Drawing.Point(5, 133);
            this.lblShowElevatorPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowElevatorPitch.Name = "lblShowElevatorPitch";
            this.lblShowElevatorPitch.Size = new System.Drawing.Size(76, 13);
            this.lblShowElevatorPitch.TabIndex = 15;
            this.lblShowElevatorPitch.Text = "Elevator Pitch:";
            // 
            // lblWarningCode
            // 
            this.lblWarningCode.AutoSize = true;
            this.lblWarningCode.Location = new System.Drawing.Point(94, 155);
            this.lblWarningCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningCode.Name = "lblWarningCode";
            this.lblWarningCode.Size = new System.Drawing.Size(13, 13);
            this.lblWarningCode.TabIndex = 16;
            this.lblWarningCode.Text = "0";
            // 
            // lblShowWarningCode
            // 
            this.lblShowWarningCode.AutoSize = true;
            this.lblShowWarningCode.Location = new System.Drawing.Point(5, 155);
            this.lblShowWarningCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowWarningCode.Name = "lblShowWarningCode";
            this.lblShowWarningCode.Size = new System.Drawing.Size(78, 13);
            this.lblShowWarningCode.TabIndex = 17;
            this.lblShowWarningCode.Text = "Warning Code:";
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Location = new System.Drawing.Point(6, 21);
            this.lblWarningMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(13, 13);
            this.lblWarningMessage.TabIndex = 18;
            this.lblWarningMessage.Text = "..";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 89);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 28);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendThrottle
            // 
            this.txtSendThrottle.Location = new System.Drawing.Point(82, 51);
            this.txtSendThrottle.Margin = new System.Windows.Forms.Padding(2);
            this.txtSendThrottle.Name = "txtSendThrottle";
            this.txtSendThrottle.Size = new System.Drawing.Size(101, 20);
            this.txtSendThrottle.TabIndex = 20;
            this.txtSendThrottle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertOnKeyPress);
            // 
            // txtSendElevatorPitch
            // 
            this.txtSendElevatorPitch.Location = new System.Drawing.Point(82, 21);
            this.txtSendElevatorPitch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSendElevatorPitch.Name = "txtSendElevatorPitch";
            this.txtSendElevatorPitch.Size = new System.Drawing.Size(101, 20);
            this.txtSendElevatorPitch.TabIndex = 21;
            this.txtSendElevatorPitch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertOnKeyPress);
            // 
            // lblEnterElePitch
            // 
            this.lblEnterElePitch.AutoSize = true;
            this.lblEnterElePitch.Location = new System.Drawing.Point(5, 23);
            this.lblEnterElePitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterElePitch.Name = "lblEnterElePitch";
            this.lblEnterElePitch.Size = new System.Drawing.Size(76, 13);
            this.lblEnterElePitch.TabIndex = 22;
            this.lblEnterElePitch.Text = "Elevator Pitch:";
            // 
            // lblEnterThrottle
            // 
            this.lblEnterThrottle.AutoSize = true;
            this.lblEnterThrottle.Location = new System.Drawing.Point(5, 53);
            this.lblEnterThrottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterThrottle.Name = "lblEnterThrottle";
            this.lblEnterThrottle.Size = new System.Drawing.Size(46, 13);
            this.lblEnterThrottle.TabIndex = 23;
            this.lblEnterThrottle.Text = "Throttle:";
            // 
            // lbSentControlData
            // 
            this.lbSentControlData.FormattingEnabled = true;
            this.lbSentControlData.Location = new System.Drawing.Point(6, 20);
            this.lbSentControlData.Name = "lbSentControlData";
            this.lbSentControlData.Size = new System.Drawing.Size(188, 147);
            this.lbSentControlData.TabIndex = 26;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(34, 70);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 20);
            this.txtPort.TabIndex = 27;
            this.txtPort.Text = "9999";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertOnKeyPress);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(2, 42);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(20, 13);
            this.lblIPAddress.TabIndex = 28;
            this.lblIPAddress.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(2, 72);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 29;
            this.lblPort.Text = "Port:";
            // 
            // chkAutoPilot
            // 
            this.chkAutoPilot.AutoSize = true;
            this.chkAutoPilot.Location = new System.Drawing.Point(7, 96);
            this.chkAutoPilot.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoPilot.Name = "chkAutoPilot";
            this.chkAutoPilot.Size = new System.Drawing.Size(68, 17);
            this.chkAutoPilot.TabIndex = 31;
            this.chkAutoPilot.Text = "AutoPilot";
            this.chkAutoPilot.UseVisualStyleBackColor = true;
            this.chkAutoPilot.CheckedChanged += new System.EventHandler(this.chkAutoPilot_CheckedChanged);
            // 
            // grpConnectToSim
            // 
            this.grpConnectToSim.Controls.Add(this.lblConnect);
            this.grpConnectToSim.Controls.Add(this.txtIPAddress);
            this.grpConnectToSim.Controls.Add(this.lblPort);
            this.grpConnectToSim.Controls.Add(this.lblIPAddress);
            this.grpConnectToSim.Controls.Add(this.txtPort);
            this.grpConnectToSim.Controls.Add(this.btnConnect);
            this.grpConnectToSim.Location = new System.Drawing.Point(10, 12);
            this.grpConnectToSim.Name = "grpConnectToSim";
            this.grpConnectToSim.Size = new System.Drawing.Size(244, 139);
            this.grpConnectToSim.TabIndex = 32;
            this.grpConnectToSim.TabStop = false;
            this.grpConnectToSim.Text = "Connect To Simulator";
            // 
            // grpTelemetryData
            // 
            this.grpTelemetryData.Controls.Add(this.lblShowAltitude);
            this.grpTelemetryData.Controls.Add(this.lblShowVerticalSpeed);
            this.grpTelemetryData.Controls.Add(this.lblAltitude);
            this.grpTelemetryData.Controls.Add(this.lblSpeed);
            this.grpTelemetryData.Controls.Add(this.lblShowSpeed);
            this.grpTelemetryData.Controls.Add(this.lblPitch);
            this.grpTelemetryData.Controls.Add(this.lblVerticalSpeed);
            this.grpTelemetryData.Controls.Add(this.lblThrottle);
            this.grpTelemetryData.Controls.Add(this.lblElevatorPitch);
            this.grpTelemetryData.Controls.Add(this.lblShowPitch);
            this.grpTelemetryData.Controls.Add(this.lblShowWarningCode);
            this.grpTelemetryData.Controls.Add(this.lblShowThrottle);
            this.grpTelemetryData.Controls.Add(this.lblWarningCode);
            this.grpTelemetryData.Controls.Add(this.lblShowElevatorPitch);
            this.grpTelemetryData.Location = new System.Drawing.Point(10, 168);
            this.grpTelemetryData.Name = "grpTelemetryData";
            this.grpTelemetryData.Size = new System.Drawing.Size(244, 175);
            this.grpTelemetryData.TabIndex = 33;
            this.grpTelemetryData.TabStop = false;
            this.grpTelemetryData.Text = "Telemetry Data";
            // 
            // grpControlData
            // 
            this.grpControlData.Controls.Add(this.lblEnterElePitch);
            this.grpControlData.Controls.Add(this.btnSend);
            this.grpControlData.Controls.Add(this.txtSendThrottle);
            this.grpControlData.Controls.Add(this.chkAutoPilot);
            this.grpControlData.Controls.Add(this.txtSendElevatorPitch);
            this.grpControlData.Controls.Add(this.lblEnterThrottle);
            this.grpControlData.Location = new System.Drawing.Point(287, 15);
            this.grpControlData.Name = "grpControlData";
            this.grpControlData.Size = new System.Drawing.Size(200, 123);
            this.grpControlData.TabIndex = 34;
            this.grpControlData.TabStop = false;
            this.grpControlData.Text = "Control Data";
            // 
            // grpMessagesSent
            // 
            this.grpMessagesSent.Controls.Add(this.lbSentControlData);
            this.grpMessagesSent.Location = new System.Drawing.Point(287, 170);
            this.grpMessagesSent.Name = "grpMessagesSent";
            this.grpMessagesSent.Size = new System.Drawing.Size(200, 173);
            this.grpMessagesSent.TabIndex = 35;
            this.grpMessagesSent.TabStop = false;
            this.grpMessagesSent.Text = "Messages Sent By User";
            // 
            // grpWarning
            // 
            this.grpWarning.Controls.Add(this.lblWarningMessage);
            this.grpWarning.Location = new System.Drawing.Point(10, 360);
            this.grpWarning.Name = "grpWarning";
            this.grpWarning.Size = new System.Drawing.Size(231, 42);
            this.grpWarning.TabIndex = 36;
            this.grpWarning.TabStop = false;
            this.grpWarning.Text = "Warning";
            // 
            // lblDisplayWarningNote
            // 
            this.lblDisplayWarningNote.Location = new System.Drawing.Point(292, 369);
            this.lblDisplayWarningNote.Name = "lblDisplayWarningNote";
            this.lblDisplayWarningNote.Size = new System.Drawing.Size(183, 33);
            this.lblDisplayWarningNote.TabIndex = 37;
            this.lblDisplayWarningNote.Text = "NOTE: AutoPilot should be used to stay at a constant speed only!";
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(497, 425);
            this.Controls.Add(this.lblDisplayWarningNote);
            this.Controls.Add(this.grpWarning);
            this.Controls.Add(this.grpMessagesSent);
            this.Controls.Add(this.grpControlData);
            this.Controls.Add(this.grpTelemetryData);
            this.Controls.Add(this.grpConnectToSim);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControllerForm";
            this.Text = "Remote Flight Controller";
            this.grpConnectToSim.ResumeLayout(false);
            this.grpConnectToSim.PerformLayout();
            this.grpTelemetryData.ResumeLayout(false);
            this.grpTelemetryData.PerformLayout();
            this.grpControlData.ResumeLayout(false);
            this.grpControlData.PerformLayout();
            this.grpMessagesSent.ResumeLayout(false);
            this.grpWarning.ResumeLayout(false);
            this.grpWarning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblShowAltitude;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblShowSpeed;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.Label lblShowPitch;
        private System.Windows.Forms.Label lblShowVerticalSpeed;
        private System.Windows.Forms.Label lblShowThrottle;
        private System.Windows.Forms.Label lblShowElevatorPitch;
        private System.Windows.Forms.Label lblWarningCode;
        private System.Windows.Forms.Label lblShowWarningCode;
        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendThrottle;
        private System.Windows.Forms.TextBox txtSendElevatorPitch;
        private System.Windows.Forms.Label lblEnterElePitch;
        private System.Windows.Forms.Label lblEnterThrottle;
        private System.Windows.Forms.ListBox lbSentControlData;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckBox chkAutoPilot;
        private System.Windows.Forms.GroupBox grpConnectToSim;
        private System.Windows.Forms.GroupBox grpTelemetryData;
        private System.Windows.Forms.GroupBox grpControlData;
        private System.Windows.Forms.GroupBox grpMessagesSent;
        private System.Windows.Forms.GroupBox grpWarning;
        private System.Windows.Forms.Label lblDisplayWarningNote;
    }
}

