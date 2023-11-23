namespace GameOfLife_Visual
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
            this.components = new System.ComponentModel.Container();
            this.InputRows = new System.Windows.Forms.TextBox();
            this.InputLines = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Initialize_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputRows
            // 
            this.InputRows.Location = new System.Drawing.Point(432, 150);
            this.InputRows.Name = "InputRows";
            this.InputRows.Size = new System.Drawing.Size(354, 22);
            this.InputRows.TabIndex = 0;
            this.InputRows.Text = "Number of rows";
            this.InputRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputRows.Click += new System.EventHandler(this.InputRows_Click);
            this.InputRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputRows_KeyPress);
            // 
            // InputLines
            // 
            this.InputLines.Location = new System.Drawing.Point(432, 199);
            this.InputLines.Name = "InputLines";
            this.InputLines.Size = new System.Drawing.Size(354, 22);
            this.InputLines.TabIndex = 1;
            this.InputLines.Text = "Number of lines";
            this.InputLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputLines.Click += new System.EventHandler(this.InputLines_Click);
            this.InputLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputLines_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Initialize_Button
            // 
            this.Initialize_Button.Location = new System.Drawing.Point(451, 318);
            this.Initialize_Button.Name = "Initialize_Button";
            this.Initialize_Button.Size = new System.Drawing.Size(307, 121);
            this.Initialize_Button.TabIndex = 2;
            this.Initialize_Button.Text = "Start";
            this.Initialize_Button.UseVisualStyleBackColor = true;
            this.Initialize_Button.Click += new System.EventHandler(this.Initialize_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1174, 567);
            this.Controls.Add(this.Initialize_Button);
            this.Controls.Add(this.InputLines);
            this.Controls.Add(this.InputRows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputRows;
        private System.Windows.Forms.TextBox InputLines;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Initialize_Button;
    }
}

