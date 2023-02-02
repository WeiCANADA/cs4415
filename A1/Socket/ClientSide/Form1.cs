using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ClientSide
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(352, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Connect";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(424, 23);
			this.label3.TabIndex = 19;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(440, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 21);
			this.button2.TabIndex = 18;
			this.button2.Text = "Disconnect";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.textBox3.Location = new System.Drawing.Point(8, 72);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox3.Size = new System.Drawing.Size(424, 72);
			this.textBox3.TabIndex = 17;
			this.textBox3.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Remote Port Number";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Remote Machine Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(152, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 21);
			this.textBox2.TabIndex = 14;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(152, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.textBox4.ForeColor = System.Drawing.Color.Blue;
			this.textBox4.Location = new System.Drawing.Point(8, 152);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox4.Size = new System.Drawing.Size(424, 144);
			this.textBox4.TabIndex = 20;
			this.textBox4.Text = "";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(440, 72);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 21);
			this.button3.TabIndex = 21;
			this.button3.Text = "Send";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(440, 296);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 21);
			this.button4.TabIndex = 22;
			this.button4.Text = "Exit";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 325);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{			
			label3.Text = "NO CONNECTION ESTABLISHED.";
//            button2.Enabled = false;
//			button3.Enabled = false;
		}

		private Socket clientSender;
		private void button1_Click(object sender, System.EventArgs e)
		{
			IPHostEntry ipHostInfo = Dns.Resolve(textBox1.Text);
			IPAddress ipAddress = ipHostInfo.AddressList[0];
			IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress,Convert.ToInt16(textBox2.Text));

			clientSender = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp );
			//clientSender = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp );
			clientSender.Connect(remoteEndPoint);

//			textBox1.Enabled = false;
//			textBox2.Enabled = false;
//			button1.Enabled = false;
//			button2.Enabled = true;
//			button3.Enabled = true;
			label3.Text = "CONNECTION ESTABLISHED.";
			
			timer1.Enabled=true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			clientSender.Shutdown(SocketShutdown.Both);
			clientSender.Close();
			//clientSender.Close();
//			button1.Enabled = true;
//			button3.Enabled = false;
			label3.Text = "CONNECTION CLOSED.";
		}

		private byte[] incomingMsg = new byte[1024];
		private int incomingMsgLength = 0;
		private void timer1_Tick(object sender, System.EventArgs e)
		{			
			if (clientSender.Available != 0)
			{
				incomingMsgLength = clientSender.Receive(incomingMsg);
				textBox4.Text += Encoding.UTF8.GetString(incomingMsg,0,incomingMsgLength);
			}
		}

		private byte[] sendingMsg = new byte[1024];
		private void button3_Click(object sender, System.EventArgs e)
		{
			sendingMsg = Encoding.UTF8.GetBytes(textBox3.Text + Environment.NewLine);
			clientSender.Send(sendingMsg);
			textBox3.Text = "";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (clientSender.Connected)
			{
				clientSender.Shutdown(SocketShutdown.Both);
			}
			Application.Exit();
		}
	}
}
