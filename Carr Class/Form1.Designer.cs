
namespace Carr_Class
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
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(63, 126);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 0;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(248, 126);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 23);
            this.brakeButton.TabIndex = 1;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(156, 45);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(88, 31);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "0 mph";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 161);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 206);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Name = "Form1";
            this.Text = "Car Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

