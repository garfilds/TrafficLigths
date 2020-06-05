namespace TrafficLigths
{
    partial class TrafficLights
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
            this.redLigth = new System.Windows.Forms.PictureBox();
            this.yellowLigth = new System.Windows.Forms.PictureBox();
            this.greenLigth = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redLigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLigth)).BeginInit();
            this.SuspendLayout();
            // 
            // redLigth
            // 
            this.redLigth.Location = new System.Drawing.Point(21, 20);
            this.redLigth.Name = "redLigth";
            this.redLigth.Size = new System.Drawing.Size(130, 130);
            this.redLigth.TabIndex = 0;
            this.redLigth.TabStop = false;
            // 
            // yellowLigth
            // 
            this.yellowLigth.Location = new System.Drawing.Point(21, 160);
            this.yellowLigth.Name = "yellowLigth";
            this.yellowLigth.Size = new System.Drawing.Size(130, 130);
            this.yellowLigth.TabIndex = 1;
            this.yellowLigth.TabStop = false;
            // 
            // greenLigth
            // 
            this.greenLigth.Location = new System.Drawing.Point(21, 301);
            this.greenLigth.Name = "greenLigth";
            this.greenLigth.Size = new System.Drawing.Size(130, 130);
            this.greenLigth.TabIndex = 2;
            this.greenLigth.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(21, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(87, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.greenLigth);
            this.Controls.Add(this.yellowLigth);
            this.Controls.Add(this.redLigth);
            this.Name = "TrafficLights";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redLigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLigth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redLigth;
        private System.Windows.Forms.PictureBox yellowLigth;
        private System.Windows.Forms.PictureBox greenLigth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

