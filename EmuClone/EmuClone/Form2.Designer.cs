
namespace EmuClone
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_assemble = new System.Windows.Forms.Button();
            this.EBX = new System.Windows.Forms.Label();
            this.EAX = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.registers = new System.Windows.Forms.Panel();
            this.flags_textBox = new System.Windows.Forms.TextBox();
            this.edi_textBox = new System.Windows.Forms.TextBox();
            this.esi_textBox = new System.Windows.Forms.TextBox();
            this.ebp_textBox = new System.Windows.Forms.TextBox();
            this.esp_textBox = new System.Windows.Forms.TextBox();
            this.edx_textBox = new System.Windows.Forms.TextBox();
            this.ecx_textBox = new System.Windows.Forms.TextBox();
            this.ebx_textBox = new System.Windows.Forms.TextBox();
            this.eax_textBox = new System.Windows.Forms.TextBox();
            this.flags = new System.Windows.Forms.Label();
            this.EDI = new System.Windows.Forms.Label();
            this.ESI = new System.Windows.Forms.Label();
            this.EBP = new System.Windows.Forms.Label();
            this.ESP = new System.Windows.Forms.Label();
            this.EDX = new System.Windows.Forms.Label();
            this.ECX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stack_richTextBox = new System.Windows.Forms.RichTextBox();
            this.stack_label = new System.Windows.Forms.Label();
            this.hex_code_label = new System.Windows.Forms.Label();
            this.hex_code_richTextBox = new System.Windows.Forms.RichTextBox();
            this.mem_label = new System.Windows.Forms.Label();
            this.mem_richTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_step = new System.Windows.Forms.Button();
            this.registers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_assemble
            // 
            this.btn_assemble.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_assemble.Image = ((System.Drawing.Image)(resources.GetObject("btn_assemble.Image")));
            this.btn_assemble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_assemble.Location = new System.Drawing.Point(119, 26);
            this.btn_assemble.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_assemble.Name = "btn_assemble";
            this.btn_assemble.Size = new System.Drawing.Size(171, 60);
            this.btn_assemble.TabIndex = 10;
            this.btn_assemble.Text = "Assemble";
            this.btn_assemble.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_assemble.UseVisualStyleBackColor = true;
            this.btn_assemble.Click += new System.EventHandler(this.button1_Click);
            // 
            // EBX
            // 
            this.EBX.AutoSize = true;
            this.EBX.Location = new System.Drawing.Point(13, 58);
            this.EBX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EBX.Name = "EBX";
            this.EBX.Size = new System.Drawing.Size(35, 20);
            this.EBX.TabIndex = 7;
            this.EBX.Text = "EBX";
            this.EBX.Click += new System.EventHandler(this.label2_Click);
            // 
            // EAX
            // 
            this.EAX.AutoSize = true;
            this.EAX.Location = new System.Drawing.Point(13, 22);
            this.EAX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EAX.Name = "EAX";
            this.EAX.Size = new System.Drawing.Size(36, 20);
            this.EAX.TabIndex = 6;
            this.EAX.Text = "EAX";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(546, 26);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(141, 60);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // registers
            // 
            this.registers.BackColor = System.Drawing.Color.LimeGreen;
            this.registers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registers.Controls.Add(this.flags_textBox);
            this.registers.Controls.Add(this.edi_textBox);
            this.registers.Controls.Add(this.esi_textBox);
            this.registers.Controls.Add(this.ebp_textBox);
            this.registers.Controls.Add(this.esp_textBox);
            this.registers.Controls.Add(this.edx_textBox);
            this.registers.Controls.Add(this.ecx_textBox);
            this.registers.Controls.Add(this.ebx_textBox);
            this.registers.Controls.Add(this.eax_textBox);
            this.registers.Controls.Add(this.flags);
            this.registers.Controls.Add(this.EDI);
            this.registers.Controls.Add(this.ESI);
            this.registers.Controls.Add(this.EBP);
            this.registers.Controls.Add(this.ESP);
            this.registers.Controls.Add(this.EDX);
            this.registers.Controls.Add(this.ECX);
            this.registers.Controls.Add(this.EAX);
            this.registers.Controls.Add(this.EBX);
            this.registers.Location = new System.Drawing.Point(43, 130);
            this.registers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registers.Name = "registers";
            this.registers.Size = new System.Drawing.Size(177, 392);
            this.registers.TabIndex = 12;
            // 
            // flags_textBox
            // 
            this.flags_textBox.Location = new System.Drawing.Point(58, 344);
            this.flags_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flags_textBox.Name = "flags_textBox";
            this.flags_textBox.Size = new System.Drawing.Size(107, 27);
            this.flags_textBox.TabIndex = 36;
            // 
            // edi_textBox
            // 
            this.edi_textBox.Location = new System.Drawing.Point(83, 222);
            this.edi_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edi_textBox.Name = "edi_textBox";
            this.edi_textBox.Size = new System.Drawing.Size(61, 27);
            this.edi_textBox.TabIndex = 32;
            // 
            // esi_textBox
            // 
            this.esi_textBox.Location = new System.Drawing.Point(83, 194);
            this.esi_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esi_textBox.Name = "esi_textBox";
            this.esi_textBox.Size = new System.Drawing.Size(61, 27);
            this.esi_textBox.TabIndex = 31;
            // 
            // ebp_textBox
            // 
            this.ebp_textBox.Location = new System.Drawing.Point(83, 166);
            this.ebp_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ebp_textBox.Name = "ebp_textBox";
            this.ebp_textBox.Size = new System.Drawing.Size(61, 27);
            this.ebp_textBox.TabIndex = 30;
            // 
            // esp_textBox
            // 
            this.esp_textBox.Location = new System.Drawing.Point(83, 136);
            this.esp_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esp_textBox.Name = "esp_textBox";
            this.esp_textBox.Size = new System.Drawing.Size(61, 27);
            this.esp_textBox.TabIndex = 29;
            // 
            // edx_textBox
            // 
            this.edx_textBox.Location = new System.Drawing.Point(83, 106);
            this.edx_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edx_textBox.Multiline = true;
            this.edx_textBox.Name = "edx_textBox";
            this.edx_textBox.Size = new System.Drawing.Size(61, 26);
            this.edx_textBox.TabIndex = 27;
            // 
            // ecx_textBox
            // 
            this.ecx_textBox.Location = new System.Drawing.Point(83, 78);
            this.ecx_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ecx_textBox.Multiline = true;
            this.ecx_textBox.Name = "ecx_textBox";
            this.ecx_textBox.Size = new System.Drawing.Size(61, 26);
            this.ecx_textBox.TabIndex = 23;
            // 
            // ebx_textBox
            // 
            this.ebx_textBox.Location = new System.Drawing.Point(83, 50);
            this.ebx_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ebx_textBox.Multiline = true;
            this.ebx_textBox.Name = "ebx_textBox";
            this.ebx_textBox.Size = new System.Drawing.Size(61, 26);
            this.ebx_textBox.TabIndex = 21;
            // 
            // eax_textBox
            // 
            this.eax_textBox.Location = new System.Drawing.Point(83, 22);
            this.eax_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eax_textBox.Multiline = true;
            this.eax_textBox.Name = "eax_textBox";
            this.eax_textBox.Size = new System.Drawing.Size(61, 26);
            this.eax_textBox.TabIndex = 19;
            // 
            // flags
            // 
            this.flags.AutoSize = true;
            this.flags.Location = new System.Drawing.Point(11, 344);
            this.flags.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(43, 20);
            this.flags.TabIndex = 17;
            this.flags.Text = "Flags";
            // 
            // EDI
            // 
            this.EDI.AutoSize = true;
            this.EDI.Location = new System.Drawing.Point(13, 230);
            this.EDI.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EDI.Name = "EDI";
            this.EDI.Size = new System.Drawing.Size(32, 20);
            this.EDI.TabIndex = 13;
            this.EDI.Text = "EDI";
            // 
            // ESI
            // 
            this.ESI.AutoSize = true;
            this.ESI.Location = new System.Drawing.Point(15, 198);
            this.ESI.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ESI.Name = "ESI";
            this.ESI.Size = new System.Drawing.Size(29, 20);
            this.ESI.TabIndex = 12;
            this.ESI.Text = "ESI";
            // 
            // EBP
            // 
            this.EBP.AutoSize = true;
            this.EBP.Location = new System.Drawing.Point(16, 172);
            this.EBP.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EBP.Name = "EBP";
            this.EBP.Size = new System.Drawing.Size(34, 20);
            this.EBP.TabIndex = 11;
            this.EBP.Text = "EBP";
            // 
            // ESP
            // 
            this.ESP.AutoSize = true;
            this.ESP.Location = new System.Drawing.Point(13, 142);
            this.ESP.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(33, 20);
            this.ESP.TabIndex = 10;
            this.ESP.Text = "ESP";
            // 
            // EDX
            // 
            this.EDX.AutoSize = true;
            this.EDX.Location = new System.Drawing.Point(13, 112);
            this.EDX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EDX.Name = "EDX";
            this.EDX.Size = new System.Drawing.Size(37, 20);
            this.EDX.TabIndex = 9;
            this.EDX.Text = "EDX";
            // 
            // ECX
            // 
            this.ECX.AutoSize = true;
            this.ECX.Location = new System.Drawing.Point(13, 86);
            this.ECX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ECX.Name = "ECX";
            this.ECX.Size = new System.Drawing.Size(35, 20);
            this.ECX.TabIndex = 8;
            this.ECX.Text = "ECX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(43, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "registers";
            // 
            // stack_richTextBox
            // 
            this.stack_richTextBox.Location = new System.Drawing.Point(626, 130);
            this.stack_richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stack_richTextBox.Name = "stack_richTextBox";
            this.stack_richTextBox.Size = new System.Drawing.Size(159, 322);
            this.stack_richTextBox.TabIndex = 14;
            this.stack_richTextBox.Text = "";
            // 
            // stack_label
            // 
            this.stack_label.AutoSize = true;
            this.stack_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stack_label.Location = new System.Drawing.Point(632, 106);
            this.stack_label.Name = "stack_label";
            this.stack_label.Size = new System.Drawing.Size(58, 23);
            this.stack_label.TabIndex = 15;
            this.stack_label.Text = "Stack";
            this.stack_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // hex_code_label
            // 
            this.hex_code_label.AutoSize = true;
            this.hex_code_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hex_code_label.Location = new System.Drawing.Point(440, 106);
            this.hex_code_label.Name = "hex_code_label";
            this.hex_code_label.Size = new System.Drawing.Size(131, 23);
            this.hex_code_label.TabIndex = 17;
            this.hex_code_label.Text = "Machine Code";
            // 
            // hex_code_richTextBox
            // 
            this.hex_code_richTextBox.Location = new System.Drawing.Point(432, 130);
            this.hex_code_richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hex_code_richTextBox.Name = "hex_code_richTextBox";
            this.hex_code_richTextBox.Size = new System.Drawing.Size(175, 322);
            this.hex_code_richTextBox.TabIndex = 16;
            this.hex_code_richTextBox.Text = "";
            // 
            // mem_label
            // 
            this.mem_label.AutoSize = true;
            this.mem_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mem_label.Location = new System.Drawing.Point(246, 106);
            this.mem_label.Name = "mem_label";
            this.mem_label.Size = new System.Drawing.Size(81, 23);
            this.mem_label.TabIndex = 19;
            this.mem_label.Text = "Memory";
            // 
            // mem_richTextBox
            // 
            this.mem_richTextBox.Location = new System.Drawing.Point(238, 130);
            this.mem_richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mem_richTextBox.Name = "mem_richTextBox";
            this.mem_richTextBox.Size = new System.Drawing.Size(176, 322);
            this.mem_richTextBox.TabIndex = 18;
            this.mem_richTextBox.Text = "";
            // 
            // btn_step
            // 
            this.btn_step.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_step.Image = ((System.Drawing.Image)(resources.GetObject("btn_step.Image")));
            this.btn_step.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_step.Location = new System.Drawing.Point(346, 26);
            this.btn_step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(134, 60);
            this.btn_step.TabIndex = 20;
            this.btn_step.Text = "Step";
            this.btn_step.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btn_step);
            this.Controls.Add(this.mem_label);
            this.Controls.Add(this.mem_richTextBox);
            this.Controls.Add(this.hex_code_label);
            this.Controls.Add(this.hex_code_richTextBox);
            this.Controls.Add(this.stack_label);
            this.Controls.Add(this.stack_richTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registers);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btn_assemble);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "8086 microprocessor emulator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.registers.ResumeLayout(false);
            this.registers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_assemble;
        private System.Windows.Forms.Label EBX;
        private System.Windows.Forms.Label EAX;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel registers;
        private System.Windows.Forms.Label flags;
        private System.Windows.Forms.Label EDI;
        private System.Windows.Forms.Label ESI;
        private System.Windows.Forms.Label EBP;
        private System.Windows.Forms.Label ESP;
        private System.Windows.Forms.Label EDX;
        private System.Windows.Forms.Label ECX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox stack_richTextBox;
        private System.Windows.Forms.Label stack_label;
        private System.Windows.Forms.TextBox ecx_textBox;
        private System.Windows.Forms.TextBox ebx_textBox;
        private System.Windows.Forms.TextBox eax_textBox;
        private System.Windows.Forms.TextBox flags_textBox;
        private System.Windows.Forms.TextBox edi_textBox;
        private System.Windows.Forms.TextBox esi_textBox;
        private System.Windows.Forms.TextBox ebp_textBox;
        private System.Windows.Forms.TextBox esp_textBox;
        private System.Windows.Forms.TextBox edx_textBox;
        private System.Windows.Forms.Label hex_code_label;
        private System.Windows.Forms.RichTextBox hex_code_richTextBox;
        private System.Windows.Forms.Label mem_label;
        private System.Windows.Forms.RichTextBox mem_richTextBox;
        private System.Windows.Forms.Button btn_step;
    }
}