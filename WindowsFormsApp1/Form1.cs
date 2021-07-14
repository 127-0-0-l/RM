using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string Path = @"D:\text.txt";

        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            radioButton1.Checked = true;
        }
            private void Button1_Click(object sender, EventArgs e)
            {
                if (radioButton1.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеE.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                else if (radioButton2.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеF.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                else if (radioButton3.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеG.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;

                int a = 0,
                    i,
                    five = 500,
                    b = 0,
                    number;

                using (StreamReader fs = new StreamReader(Path))
                {
                    while (true)
                    {
                        string temp = fs.ReadLine();
                        a++;
                        if (temp == null)
                            break;
                    }
                }

                a--;

                label2.Text = a + " files";
                label3.Text = "Rename...";

                string newneme = "";
                int[] arr = new int[five];
                int[] Arr = new int[five];

                for (i = 0; i < 500; i++)
                    arr[i] = i + 1;
                for (i = 0; i < 500; i++)
                    Arr[i] = i + 501;

                using (StreamReader fs = new StreamReader(Path))
                {
                    while (b < a)
                    {
                        string temp = fs.ReadLine();

                        Random rnd = new Random();
                        i = rnd.Next(0, five);
                        number = Arr[i];
                        five--;
                        Arr[i] = Arr[five];

                        newneme = Convert.ToString(number);
                        if (radioButton1.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("E:\\" + temp, "E:\\" + newneme + ".mp3");
                            }
                            catch (Exception) {}
                        }
                        if (radioButton2.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("F:\\" + temp, "F:\\" + newneme + ".mp3");
                            }
                            catch (Exception) { }
                        }
                        if (radioButton3.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("G:\\" + temp, "G:\\" + newneme + ".mp3");
                            }
                            catch (Exception) { }
                        }

                        b++;

                        if (temp == "")
                        {
                            _ = new Process();

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "удаление.bat";
                            p.Start();

                            string output = p.StandardOutput.ReadToEnd();
                            p.WaitForExit();
                            break;
                        }
                    }
                }

                if (radioButton1.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеE.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                if (radioButton2.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеF.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                if (radioButton3.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "созданиеG.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                using (StreamReader fs = new StreamReader(Path))
                {
                    b = 0;

                    while (b < a)
                    {
                        string temp = fs.ReadLine();

                        Random rnd = new Random();
                        i = rnd.Next(0, five);
                        number = arr[i];
                        five--;
                        arr[i] = arr[five];

                        newneme = Convert.ToString(number);
                        if (radioButton1.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("E:\\" + temp, "E:\\" + newneme + ".mp3");
                            }
                            catch (Exception) { }
                        }
                        if (radioButton2.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("F:\\" + temp, "F:\\" + newneme + ".mp3");
                            }
                            catch (Exception) { }
                        }
                        if (radioButton3.Checked)
                        {
                            try
                            {
                                System.IO.File.Move("G:\\" + temp, "G:\\" + newneme + ".mp3");
                            }
                            catch (Exception) { }
                        }

                        b++;

                        if (temp == "")
                        {
                            _ = new Process();

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = "удаление.bat";
                            p.Start();

                            string output = p.StandardOutput.ReadToEnd();
                            p.WaitForExit();
                            break;
                        }
                    }
                }

                label3.Text = "Remove...";

                if (radioButton1.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "перемещениеE.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                if (radioButton2.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "перемещениеF.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                if (radioButton3.Checked)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "перемещениеG.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                if (true)
                {
                    _ = new Process();

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "удаление.bat";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }

                label3.Text = "FINISH";
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
        
    }
}
