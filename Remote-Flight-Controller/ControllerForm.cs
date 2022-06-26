using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace _15015009
{
    // struct that holds variables needed to control
    // the flight simulator
    public struct ControlsUpdate
    {
        public double Throttle;
        public double ElevatorPitch;
    }

    // struct that holds variables needed to show
    // telemetry data to the program
    public struct TelemetryUpdate
    {
        public double Altitude;
        public double Speed;
        public double Pitch;
        public double VerticalSpeed;
        public double Throttle;
        public double ElevatorPitch;
        public int WarningCode;
    }

    public delegate void ControlsUpdateHandler(ControlsUpdate  newcontroldata); // delegate that holds a 'ControlsUpdate' object
    public delegate void TelemetryUpdateHandler(TelemetryUpdate newtelemetrydata);  // delegate that holds a 'TelemetryUpdate' object
    public delegate void WarningUpdateHandler(string warning);  // delegate that accepts a string intended to be used for displaying warnings

    public partial class ControllerForm : Form
    {
        RemoteFlightController MyRemoteFlightController = new RemoteFlightController(); // initialising a new 'RemoteFlightController' object
        Thread PilotThread = null;  // initialising a thread here to prevent it from being reinitialised each time its called in the 'autopilot' method

        public ControllerForm()
        {
            // registering an event to a delegate on program startup
            MyRemoteFlightController.onTelemetryUpdate += new TelemetryUpdateHandler(showTelemetry);    // call 'showTelemetry' with the delegate given when the 'onTelemetryUpdate' is executed
            MyRemoteFlightController.onWarningUpdate += new WarningUpdateHandler(showWarning);          // call 'showWarning' with the delegate given when the 'onWarningUpdate' is executed
            MyRemoteFlightController.onControlsUpdate += new ControlsUpdateHandler(showControl);  // call 'showControl' with the delegate given when the 'onControlsUpdate' is executed
            InitializeComponent();
        }

        // updates the listbox with the control data that has been sent to the Flight Simulator
        public void showControl(ControlsUpdate controldata)
        {
            if (this.InvokeRequired)    // checks whether or not it needs to use the Invoke() method
            {
                // used to call a method on the UI thread
                this.Invoke(new ControlsUpdateHandler(showControl), new object[] { controldata });
            }
            else
            {
                // inserts the control data to the top/start of the listbox
                lbSentControlData.Items.Insert(0, "Elevator Pitch: " + controldata.ElevatorPitch + ", Throttle: " + controldata.Throttle);
            }
        }

        // updates the labels with the telemetry data that has been sent from the Flight Simulator
        public void showTelemetry(TelemetryUpdate telemetrydata)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new TelemetryUpdateHandler(showTelemetry), new object[] { telemetrydata });
            }
            else
            {
                lblAltitude.Text = Convert.ToString(telemetrydata.Altitude) + " ft";
                lblSpeed.Text = Convert.ToString(telemetrydata.Speed) + " Knts";
                lblPitch.Text = Convert.ToString(telemetrydata.Pitch) + " degrees";
                lblVerticalSpeed.Text = Convert.ToString(telemetrydata.VerticalSpeed) + " ft p/m";
                lblThrottle.Text = Convert.ToString(telemetrydata.Throttle) + "%";
                lblElevatorPitch.Text = Convert.ToString(telemetrydata.ElevatorPitch) + " degrees";
                lblWarningCode.Text = Convert.ToString(telemetrydata.WarningCode);
            }
        }

        // based on the warning code given, displays an warning message to the RemoteController program
        public void showWarning(string warning)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new WarningUpdateHandler(showWarning), warning);
            }
            else
            {
                lblWarningMessage.Text = warning;
            }
        }

        // connects to the FlightSimulator program by passing the entered 'IP' and 'Port' to the 
        // 'connectToFlightSimulator' method in the 'RemoteFlightController' class when clicked.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MyRemoteFlightController.connectToFlightSimulator(txtIPAddress.Text, txtPort.Text);
        }

        // sends inputted control data to the FlightSimulator program
        private void btnSend_Click(object sender, EventArgs e)
        {
            ControlsUpdate MyControlsUpdate = new ControlsUpdate();

            // if both controls are not empty
            if (!string.IsNullOrWhiteSpace(txtSendElevatorPitch.Text) && !string.IsNullOrWhiteSpace(txtSendThrottle.Text))
            {
                // used to check if both controls satisfy the correct range when input is given 
                bool pitchcheck;
                bool throttlecheck;

                // Elevator Pitch
                // if elevator pitch is within the range of <= 5 and >= -5, set pitchcheck to 'true', else false
                if (double.Parse(txtSendElevatorPitch.Text) <= 5 && double.Parse(txtSendElevatorPitch.Text) >= -5)
                {
                    pitchcheck = true;
                }
                else
                {
                    pitchcheck = false;
                    MessageBox.Show("Error! Please select a value ranging from -5.0 to 5.0 for Pitch control.");
                }

                // Throttle
                // if throttle is within the range of <= 100 and >= 0, set throttlecheck to 'true', else false
                if (double.Parse(txtSendThrottle.Text) <= 100 && double.Parse(txtSendThrottle.Text) >= 0)
                {
                    throttlecheck = true;
                }
                else
                {
                    throttlecheck = false;
                    MessageBox.Show("Error! Please select a value ranging from 0 to 100 for Throttle control.");
                }

                // if pitchcheck and throttle check are true, then send both control data to the FlightSimulator
                if (pitchcheck == true && throttlecheck == true)
                {
                    MyControlsUpdate.ElevatorPitch = double.Parse(txtSendElevatorPitch.Text);
                    MyControlsUpdate.Throttle = double.Parse(txtSendThrottle.Text);
                    MyRemoteFlightController.sendControlEvent(MyControlsUpdate);
                }
                // if pitchcheck is true and throttlecheck is false, only send 'ElevatorPitch' as the control data
                else if (pitchcheck == true && throttlecheck == false)
                {
                    MyControlsUpdate.ElevatorPitch = double.Parse(txtSendElevatorPitch.Text);
                    MyRemoteFlightController.sendControlEvent(MyControlsUpdate);
                }
                // if throttlecheck is true and pitchcheck is false, only send 'Throttle' as the control data
                else if (pitchcheck == false && throttlecheck == true)
                {
                    MyControlsUpdate.Throttle = double.Parse(txtSendThrottle.Text);
                    MyRemoteFlightController.sendControlEvent(MyControlsUpdate);
                }
                // if both checks are false, display an error message
                else if (pitchcheck == false && throttlecheck == false)
                {
                    MessageBox.Show("Error! Values out of range for Pitch and Throttle!");
                }
            }
            // If elevator pitch is not empty and throttle is, only send 'ElevatorPitch' as the control data
            else if (!string.IsNullOrWhiteSpace(txtSendElevatorPitch.Text) && string.IsNullOrWhiteSpace(txtSendThrottle.Text))
            {
                if (double.Parse(txtSendElevatorPitch.Text) <= 5 && double.Parse(txtSendElevatorPitch.Text) >= -5)
                {
                    MyControlsUpdate.ElevatorPitch = double.Parse(txtSendElevatorPitch.Text);
                    MyRemoteFlightController.sendControlEvent(MyControlsUpdate);
                }
                else
                {
                    MessageBox.Show("Error! Please select a value ranging from -5.0 to 5.0 for Pitch control.");
                }
            }
            // if elevator pitch is empty but throttle isnt, only send 'Throttle' as the control data
            else if (string.IsNullOrWhiteSpace(txtSendElevatorPitch.Text) && !string.IsNullOrWhiteSpace(txtSendThrottle.Text))
            {
                if (double.Parse(txtSendThrottle.Text) <= 100 && double.Parse(txtSendThrottle.Text) >= 0)
                {
                    MyControlsUpdate.Throttle = double.Parse(txtSendThrottle.Text);
                    MyRemoteFlightController.sendControlEvent(MyControlsUpdate);
                }
                else
                {
                    MessageBox.Show("Error! Please select a value ranging from 0 to 100 for Throttle control.");
                }
            }
            // if both are empty, display an error message
            else
            {
                MessageBox.Show("Error! Both controls are empty!");
            }
        }

        // activates or deactivates the autopilot when the checkbox is unticked/ticked
        // by starting or aborting a new thread for the autopilot
        private void chkAutoPilot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoPilot.Checked)
            {
                // creates a new thread with the method 'activateAutoPilot' called 'PilotThread'
                // which runs concurrently in the background as a process
                PilotThread = new Thread(new ThreadStart(MyRemoteFlightController.activateAutoPilot));
                PilotThread.Start();    // starts the 'PilotThread' thread
            }
            else if (!chkAutoPilot.Checked)
            {
                PilotThread.Abort();    // terminate the 'PilotThread' thread
            }
        }

        // all textboxes found on the ControllerForm use this method as an event when a key is pressed
        // it checks if the character entered is non-numeric and shows an error message
        // and prevents the entry of any non-numeric characters unless its an hyphen (-) or full stop (.)
        private void txtInsertOnKeyPress(object sender, KeyPressEventArgs e)
        {
            // prevents non-integer values from being entered e.g. string
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value!");
            }
        }
    }

    public class RemoteFlightController
    {
        // declaring events based on delegate type as given below
        public event ControlsUpdateHandler onControlsUpdate;
        public event TelemetryUpdateHandler onTelemetryUpdate;
        public event WarningUpdateHandler onWarningUpdate;

        TelemetryUpdate MyTelemetryData;    // object of 'TelemetryUpdate' declared inside class so it stays in scope for methods
        TcpClient sender = null;    // initialising a new instance of TCPClient and calling it 'sender' set to null

        // registers a new event when 'RemoteFlightController' is constructed
        public RemoteFlightController()
        {
            // call 'sendControlData' with the delegate given when the 'onControlsUpdate' is executed
            onControlsUpdate += new ControlsUpdateHandler(sendControlData);
        }

        public void sendControlEvent(ControlsUpdate newcontrolsupdate)
        {
            onControlsUpdate(newcontrolsupdate);    // calls all events of 'onControlsUpdate' passing 'newcontrolsdata' of type ControlsUpdate as its argumente 
        }

        // sends the given control data to FlightSimulator after serialising the data
        // in JSON format
        public void sendControlData(ControlsUpdate newcontrolsupdate)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonmessage = serializer.Serialize(newcontrolsupdate);   // serialises the controldata in JSON format
            NetworkStream stream = sender.GetStream();  // creates a stream from the TCPClient 'sender' which allows data to be sent and recieved by a network connection
            byte[] buffer = Encoding.ASCII.GetBytes(jsonmessage);   // encodes the JSON string message into ASCII bytes
            stream.Write(buffer, 0, buffer.Length); // sends/writes data to the network stream containing the encoded JSON message ready for the FlightSimulator to decode as a JSON message
        }

        // connects to the FlightSimulator with the given ip address and port
        // allowing data to be sent and recieved
        public void connectToFlightSimulator(string ipaddress, string portnumber)
        {
            IPAddress ip = IPAddress.Parse(ipaddress);  // converts the string 'ipaddress' to a instance of IPAddress named 'ip'
            sender = new TcpClient();   // creates a new instance of TCPClient named 'sender'
            int port = Convert.ToInt16(portnumber); // converts the string 'portnumber' to a 16-bit int

            // if an incorrect ip is entered, the program will 'hang' for a few moments
            // until it displays an error which prevents the program from crashing
            // this is due to the program not being able to tell if they've actually connected
            // to a host as it waits for data to be sent/recieved
            try
            {
                sender.Connect(ip, port);   // connects to the host using the specified ip address and port
                MessageBox.Show("Connected!");

                // creates a new thread with the method 'listenToFlightSimulator' called 'ListenThread'
                // which runs concurrently in the background as a process
                Thread ListenThread = new Thread(new ThreadStart(listenToFlightSimulator));
                ListenThread.Start();   // starts the 'PilotThread' thread
            }
            catch
            {
                MessageBox.Show("Error! Couldn't establish connection to Flight Simulator.");
            }
        }

        // runs as a constant thread which listens to the FlightSimulator
        // by taking readings of the 'TelemetryData' and updates the data on the
        // 'RemoteControllerProgram'
        public void listenToFlightSimulator()
        {
            NetworkStream stream = sender.GetStream();  // creates a stream from the TCPClient 'sender' which allows data to be sent and recieved by a network connection
            byte[] buffer = new byte[256];  // creates a buffer that will be used to read data from the FlightSimulator

            while(true)
            {
                int num_bytes = stream.Read(buffer, 0, 256);    // reads the stream from the FlightSimulator and stores it in 'num_bytes'
                string receivemessage = Encoding.ASCII.GetString(buffer, 0, num_bytes); // converts the bytes into ASCII string format

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                MyTelemetryData = serializer.Deserialize<TelemetryUpdate>(receivemessage);  // deserialises the JSON message into TelemetryData which is then stored in 'MyTelemetryData'
                onTelemetryUpdate(MyTelemetryData); // calls the 'onTelemetryUpdate' event passing the telemetry data as its argument

                // Updates the Warning message based on warning code received
                if (MyTelemetryData.WarningCode != 0)
                {
                    if (MyTelemetryData.WarningCode == 1)
                    {
                        onWarningUpdate("Too low! (less than 1000ft)"); // calls the 'onWarningUpdate' passing a string message as its argument
                    }
                    else if (MyTelemetryData.WarningCode == 2)
                    {
                        onWarningUpdate("Stalling!");   // calls the 'onWarningUpdate' passing a string message as its argument
                    }
                }
                // if WarningCode is equal to 0, override error message
                else if (MyTelemetryData.WarningCode == 0)
                {
                    onWarningUpdate("All systems functional. No warnings present.");    // calls the 'onWarningUpdate' passing a string message as its argument
                }
            }
        }

        // controls the FlightSimulator by sending control data every 0.2 seconds by
        // storing the current speed of the FlightSimulator and it tries to sustain that speed
        // whilst also trying to stabilise the pitch
        public void activateAutoPilot()
        {
            double speed = MyTelemetryData.Speed;   // stores the current speed of the FlightSimulator in a variable named 'speed'
            ControlsUpdate MyControlsUpdate = new ControlsUpdate(); // created a new instance of ControlsUpdate called 'MyControlsUpdate'

            while(true)
            {
                // Throttle and Speed Control
                // if the current speed is too fast, decrease throttle
                if (MyTelemetryData.Speed > speed)
                {
                    MyControlsUpdate.Throttle = 25;
                }
                // if the current speed is too slow, increase throttle
                else if (MyTelemetryData.Speed < speed)
                {
                    MyControlsUpdate.Throttle = 75;
                }
                else
                {
                    // this only activates once when autopilot is executed
                    // it is used to prevent the autopilot from sending
                    // '0' throttle to the Flight Simulator
                    MyControlsUpdate.Throttle = 50;
                }

                // Elevator Pitch and Altitude Control
                if (MyTelemetryData.Pitch > 0.5)
                {
                    MyControlsUpdate.ElevatorPitch = -2;
                }
                else if (MyTelemetryData.Pitch < -0.5)
                {
                    MyControlsUpdate.ElevatorPitch = 2;
                }

                onControlsUpdate(MyControlsUpdate); // call the 'onControlsUpdate' event passing the controls data as an argument
                Thread.Sleep(200);  // sleep for 0.2 seconds to prevent sending too many control requests to the Flight Sim
            }
        }
    }    
}