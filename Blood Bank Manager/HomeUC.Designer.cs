namespace Blood_Bank_Manager {
    partial class HomeUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.input_text_box = new System.Windows.Forms.TextBox();
            this.view_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // input_text_box
            // 
            this.input_text_box.Location = new System.Drawing.Point(210, 188);
            this.input_text_box.Name = "input_text_box";
            this.input_text_box.Size = new System.Drawing.Size(189, 20);
            this.input_text_box.TabIndex = 1;
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(270, 251);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(75, 23);
            this.view_button.TabIndex = 2;
            this.view_button.Text = "view";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.input_text_box);
            this.Controls.Add(this.label1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(808, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_text_box;
        private System.Windows.Forms.Button view_button;
    }
}
