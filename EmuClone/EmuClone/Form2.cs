using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UnicornManaged;
using UnicornManaged.Const;

namespace EmuClone
{
    public partial class Form2 : Form
    {

        int step = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strCmdText;
                //MessageBox.Show(Form1.file_name);
                //strCmdText = @"nasm C:\Users\Norbert\Downloads\nasm-2.15.05\exemplu.asm -f bin -o C:\Users\Norbert\Downloads\nasm-2.15.05\exemplu.bin";
                if (Form1.file_name != "Untitled.asm")
                {
                    //assemble the code
                    strCmdText = Form1.file_name + @" -f bin -o " + Form1.file_name.Replace(".asm", ".bin");
                    System.Diagnostics.Process.Start("nasm.exe", strCmdText);
                    //Console.WriteLine(strCmdText);
                    System.Threading.Thread.Sleep(1000);
                    //show binary code
                    try
                    {
                        var fs = new FileStream(Form1.file_name.Replace(".asm", ".bin"), FileMode.Open);
                        var len = (int)fs.Length;
                        Byte[] code = new Byte[len];
                        fs.Read(code, 0, len);
                        fs.Close();

                        hex_code_richTextBox.Text = "";
                        for (int i = 0; i < len; i++)
                            hex_code_richTextBox.Text += string.Format("0x{0:X}\n", code[i]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Assembly done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Firstly save your work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Assembly error with nasm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Form1.file_name != "Untitled.asm")
            {
                try
                {
                    var fs = new FileStream(Form1.file_name.Replace(".asm", ".bin"), FileMode.Open);
                    var len = (int)fs.Length;
                    Byte[] code = new Byte[len];
                    fs.Read(code, 0, len);
                    fs.Close();

                    //write hex code
                    hex_code_richTextBox.Text = "";
                    for (int i = 0; i < len; i++)
                        hex_code_richTextBox.Text += string.Format("0x{0:X}\n", code[i]);

                    Int64 address = 0x1000000;  // memory address where emulation starts

                    var u = new Unicorn(Common.UC_ARCH_X86, Common.UC_MODE_32);

                    int r_eax = 0x0000;
                    int r_ebx = 0x0000;
                    int r_ecx = 0x0000;
                    int r_edx = 0x0000;
                    //int r_esp = 0x0000;
                    int r_ebp = 0x0000;
                    int r_esi = 0x0000;
                    int r_edi = 0x0000;
                    //int r_flags = 0x0000;

                    //Console.WriteLine("Unicorn version: {0}", u.Version());

                    // map 2MB of memory for this emulation
                    u.MemMap(address, 2 * 1024 * 1024, Common.UC_PROT_ALL);

                    // write machine code to be emulated to memory
                    u.MemWrite(address, code);

                    // initialize machine registers
                    u.RegWrite(X86.UC_X86_REG_EAX, Utils.Int64ToBytes(r_eax));
                    u.RegWrite(X86.UC_X86_REG_EBX, Utils.Int64ToBytes(r_ebx));
                    u.RegWrite(X86.UC_X86_REG_ECX, Utils.Int64ToBytes(r_ecx));
                    u.RegWrite(X86.UC_X86_REG_EDX, Utils.Int64ToBytes(r_edx));
                    u.RegWrite(X86.UC_X86_REG_ESP, Utils.Int64ToBytes(address + 128));
                    u.RegWrite(X86.UC_X86_REG_EBP, Utils.Int64ToBytes(r_ebp));
                    u.RegWrite(X86.UC_X86_REG_ESI, Utils.Int64ToBytes(r_esi));
                    u.RegWrite(X86.UC_X86_REG_EDI, Utils.Int64ToBytes(r_edi));
                    //u.RegWrite(X86.UC_X86_REG_EFLAGS, Utils.Int64ToBytes(r_flags));
                    

                    // emulate machine code in infinite time
                    u.EmuStart(address, address + code.Length, 0u, 0u);


                    //read stack register values
                    var eax = u.RegRead(X86.UC_X86_REG_EAX);
                    var ebx = u.RegRead(X86.UC_X86_REG_EBX);
                    var ecx = u.RegRead(X86.UC_X86_REG_ECX);
                    var edx = u.RegRead(X86.UC_X86_REG_EDX);
                    var esp = u.RegRead(X86.UC_X86_REG_ESP);
                    var ebp = u.RegRead(X86.UC_X86_REG_EBP);
                    var esi = u.RegRead(X86.UC_X86_REG_ESI);
                    var edi = u.RegRead(X86.UC_X86_REG_EDI);
                    var flags = u.RegRead(X86.UC_X86_REG_EFLAGS);

                    var stack_info = new Byte[4];
                    var mem_info = new Byte[len];

                    //read stack
                    u.MemRead(esp, stack_info);

                    //read memory
                    u.MemRead(address, mem_info);


                    eax_textBox.Text = string.Format("0x{0:X}", eax);
                    ebx_textBox.Text = string.Format("0x{0:X}", ebx);
                    ecx_textBox.Text = string.Format("0x{0:X}", ecx);
                    edx_textBox.Text = string.Format("0x{0:X}", edx);
                    esp_textBox.Text = string.Format("0x{0:X}", esp);
                    ebp_textBox.Text = string.Format("0x{0:X}", ebp);
                    esi_textBox.Text = string.Format("0x{0:X}", esi);
                    edi_textBox.Text = string.Format("0x{0:X}", edi);
                    flags_textBox.Text = Convert.ToString(flags, 2);


                    //Print stack info                                                                 
                    stack_richTextBox.Text = "";
                    for (int i = 0; i < 4; i++)                        
                        stack_richTextBox.Text += string.Format(">> 0x{0:X}\n", stack_info[i]);

                    //Print memory info
                    mem_richTextBox.Text = "";
                    mem_richTextBox.Text = string.Format("Address: 0x{0:X}\n", address);                    
                    for (int i = 0; i < len; i++)
                    {
                        mem_richTextBox.Text += string.Format(">> 0x{0:X}: ", address + i);
                        mem_richTextBox.Text += string.Format("0x{0:X}\n", mem_info[i]);
                    }                                         

                    MessageBox.Show("Rulare terminata cu succes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnicornEngineException ex)
                {
                    MessageBox.Show(ex.Message, "Emulation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Firstly save your work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btn_step_Click_1(object sender, EventArgs e)
        {
            if (Form1.file_name != "Untitled.asm")
            {
                try
                {
                    var fs = new FileStream(Form1.file_name.Replace(".asm", ".bin"), FileMode.Open);
                    var len = (int)fs.Length;
                    Byte[] code = new Byte[len];
                    fs.Read(code, 0, len);
                    fs.Close();                    
                    
                    if (step > len - 1)
                        step = 1;
                    Debug.WriteLine(step);

                    hex_code_richTextBox.Text = "";
                    for (int i = 0; i < len; i++)
                    {
                        if (i == step - 1)
                            hex_code_richTextBox.Text += string.Format(">> 0x{0:X}\n", code[i]);
                        else
                            hex_code_richTextBox.Text += string.Format("0x{0:X}\n", code[i]);
                    }

                    Int64 address = 0x1000000;  // memory address where emulation starts

                    var u = new Unicorn(Common.UC_ARCH_X86, Common.UC_MODE_32);

                    int r_eax = 0x0000;
                    int r_ebx = 0x0000;
                    int r_ecx = 0x0000;
                    int r_edx = 0x0000;
                    int r_esp = 0x0000;
                    int r_ebp = 0x0000;
                    int r_esi = 0x0000;
                    int r_edi = 0x0000;
                    //int r_flags = 0x0000;


                    //Console.WriteLine("Unicorn version: {0}", u.Version());

                    // map 2MB of memory for this emulation
                    u.MemMap(address, 2 * 1024 * 1024, Common.UC_PROT_ALL);

                    // write machine code to be emulated to memory
                    u.MemWrite(address, code);

                    // initialize machine registers
                    u.RegWrite(X86.UC_X86_REG_EAX, Utils.Int64ToBytes(r_eax));
                    u.RegWrite(X86.UC_X86_REG_EBX, Utils.Int64ToBytes(r_ebx));
                    u.RegWrite(X86.UC_X86_REG_ECX, Utils.Int64ToBytes(r_ecx));
                    u.RegWrite(X86.UC_X86_REG_EDX, Utils.Int64ToBytes(r_edx));
                    u.RegWrite(X86.UC_X86_REG_ESP, Utils.Int64ToBytes(address + 128));
                    u.RegWrite(X86.UC_X86_REG_EBP, Utils.Int64ToBytes(r_ebp));
                    u.RegWrite(X86.UC_X86_REG_ESI, Utils.Int64ToBytes(r_esi));
                    u.RegWrite(X86.UC_X86_REG_EDI, Utils.Int64ToBytes(r_edi));
                    //u.RegWrite(X86.UC_X86_REG_EFLAGS, Utils.Int64ToBytes(r_flags));


                    // emulate machine code in infinite time
                    u.EmuStart(address, address + code.Length, 0u, step);


                    //read register values
                    var eax = u.RegRead(X86.UC_X86_REG_EAX);
                    var ebx = u.RegRead(X86.UC_X86_REG_EBX);
                    var ecx = u.RegRead(X86.UC_X86_REG_ECX);
                    var edx = u.RegRead(X86.UC_X86_REG_EDX);
                    var esp = u.RegRead(X86.UC_X86_REG_ESP);
                    var ebp = u.RegRead(X86.UC_X86_REG_EBP);
                    var esi = u.RegRead(X86.UC_X86_REG_ESI);
                    var edi = u.RegRead(X86.UC_X86_REG_EDI);
                    var flags = u.RegRead(X86.UC_X86_REG_EFLAGS);                 

                    var stack_info = new Byte[4];
                    var mem_info = new Byte[len];

                    //read stack
                    u.MemRead(esp, stack_info);

                    //read memory
                    u.MemRead(address, mem_info);


                    eax_textBox.Text = string.Format("0x{0:X}", eax);
                    ebx_textBox.Text = string.Format("0x{0:X}", ebx);
                    ecx_textBox.Text = string.Format("0x{0:X}", ecx);
                    edx_textBox.Text = string.Format("0x{0:X}", edx);
                    esp_textBox.Text = string.Format("0x{0:X}", esp);
                    ebp_textBox.Text = string.Format("0x{0:X}", ebp);
                    esi_textBox.Text = string.Format("0x{0:X}", esi);
                    edi_textBox.Text = string.Format("0x{0:X}", edi);
                    flags_textBox.Text = Convert.ToString(flags, 2);


                    //Print stack info                                                                 
                    stack_richTextBox.Text = "";
                    for (int i = 0; i < 4; i++)
                        stack_richTextBox.Text += string.Format(">> 0x{0:X}\n", stack_info[i]);

                    //Print memory info
                    mem_richTextBox.Text = "";
                    mem_richTextBox.Text = string.Format("Address: 0x{0:X}\n", address);
                    for (int i = 0; i < len; i++)
                    {
                        mem_richTextBox.Text += string.Format(">> 0x{0:X}: ", address + i);
                        mem_richTextBox.Text += string.Format("0x{0:X}\n", mem_info[i]);
                    }


                    step++;

                }
                catch (UnicornEngineException ex)
                {
                    MessageBox.Show(ex.Message, "Emulation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Firstly save your work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
