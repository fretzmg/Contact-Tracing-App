
namespace Contact_Tracing_App
{
    partial class LoadInfo
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
            this.infostxtbx = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infostxtbx
            // 
            this.infostxtbx.Location = new System.Drawing.Point(12, 12);
            this.infostxtbx.Multiline = true;
            this.infostxtbx.Name = "infostxtbx";
            this.infostxtbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infostxtbx.Size = new System.Drawing.Size(619, 294);
            this.infostxtbx.TabIndex = 0;
            this.infostxtbx.TextChanged += new System.EventHandler(this.infostxtbx_TextChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(537, 320);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(94, 29);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(12, 320);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(94, 29);
            this.Loadbtn.TabIndex = 2;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 361);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.infostxtbx);
            this.Name = "LoadInfo";
            this.Text = "Contact Tracing Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infostxtbx;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button Loadbtn;
    }
}