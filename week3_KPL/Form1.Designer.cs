namespace week3_KPL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TombolInput = new Button();
            KolomBicara = new Label();
            inputNama = new TextBox();
            InputNIM = new TextBox();
            LabelOutput = new Label();
            SuspendLayout();
            // 
            // TombolInput
            // 
            TombolInput.BackColor = SystemColors.ActiveCaption;
            TombolInput.Location = new Point(435, 23);
            TombolInput.Name = "TombolInput";
            TombolInput.Size = new Size(192, 67);
            TombolInput.TabIndex = 1;
            TombolInput.Text = "Apply";
            TombolInput.UseVisualStyleBackColor = false;
            TombolInput.Click += TombolInput_Click;
            // 
            // KolomBicara
            // 
            KolomBicara.AutoSize = true;
            KolomBicara.Location = new Point(41, 183);
            KolomBicara.Name = "KolomBicara";
            KolomBicara.Size = new Size(0, 20);
            KolomBicara.TabIndex = 5;
            // 
            // inputNama
            // 
            inputNama.Location = new Point(41, 23);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(371, 27);
            inputNama.TabIndex = 6;
            inputNama.Text = "Silahkan Input Nama di sini";
            inputNama.TextChanged += input_TextChanged;
            // 
            // InputNIM
            // 
            InputNIM.Location = new Point(41, 63);
            InputNIM.Name = "InputNIM";
            InputNIM.Size = new Size(371, 27);
            InputNIM.TabIndex = 8;
            InputNIM.Text = "Silahkan Input NIM di sini";
            InputNIM.TextChanged += textBox1_TextChanged;
            // 
            // LabelOutput
            // 
            LabelOutput.AutoSize = true;
            LabelOutput.BackColor = SystemColors.ButtonHighlight;
            LabelOutput.Location = new Point(41, 120);
            LabelOutput.Name = "LabelOutput";
            LabelOutput.Size = new Size(127, 20);
            LabelOutput.TabIndex = 9;
            LabelOutput.Text = "Menunggu Input...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelOutput);
            Controls.Add(InputNIM);
            Controls.Add(inputNama);
            Controls.Add(KolomBicara);
            Controls.Add(TombolInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button TombolInput;
        private Label KolomBicara;
        private TextBox inputNama;
        private TextBox InputNIM;
        private Label LabelOutput;
    }
}
