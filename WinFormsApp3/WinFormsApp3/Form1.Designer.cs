namespace PigLatinConverter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(169, 47);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(200, 22);
            this.textBoxWord.TabIndex = 0;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(29, 50);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(134, 17);
            this.labelInstruction.TabIndex = 1;
            this.labelInstruction.Text = "Enter a word:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(169, 89);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(94, 29);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(29, 143);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 3;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(453, 234);
            this.pictureBoxBackground.TabIndex = 4;
            this.pictureBoxBackground.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 234);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "MainForm";
            this.Text = "PigLatin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
    }
}
