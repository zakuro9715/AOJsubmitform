﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TweetSharp;

namespace AOJsubmitform
{
  public partial class MainForm : Form
  {
    private string _problemNumber = "";
    public static TwitterService TwitterService = new TwitterService("pE7l8lWq5dtB8kpx4TmeCC52M", "y11AazZjk43jHOAK2TzVX4nk1R397kjWVNmtRHs94e5HgwuLFy");
    public static OAuthRequestToken TwitterRequestToken;
    public static string TwitterVerifier;
    public static OAuthAccessToken TwitterAccess;

    public Config Config = new Config();

    public static string ProblemName = "";
    public MainForm()
    {
      InitializeComponent();
      //引数付きで実行されたとき引数のPATHを捜索しファイルを読み込む
      if (Program.FileName != "")
      {
        if (File.Exists(Program.FileName))
        {
          StreamReader sourceCodeReader = new StreamReader(Program.FileName);
          SourceCodeBox.Text = sourceCodeReader.ReadToEnd();
          sourceCodeReader.Close();
        }
        else
        {
          MessageBox.Show(@"読み込むファイルがありません!");
        }
      }
      Config.Load();
      if (Config.TwitterToken != "" && Config.TwitterTokenSecret != "")
        TwitterService.AuthenticateWith(Config.TwitterToken, Config.TwitterTokenSecret);
      //言語ボックスの初期化
      LanguageBox.Text = "C++";
    }

    //問題番号が変更されたとき
    private void ProblemNumberBoxChanged(object sender, EventArgs e)
    {
      _problemNumber = ProblemNumberBox.Text;
    }

    private void LanguageboxChanged(object sender, EventArgs e)
    {

    }

    private bool CanSubmit()
    {
      //ソースコードが入力されていなかった場合
      if (SourceCodeBox.Text == "")
      {
        MessageBox.Show(@"一切入力していないソースコードは提出できません！");
        return false;
      }
      //問題番号が不十分な場合
      if (_problemNumber.Length < 4)
      {
        MessageBox.Show(@"問題番号を入力してください!");
        return false;
      }
      //問題が存在していなかった場合
      if (ProblemName == "")
      {
        MessageBox.Show(@"正しい問題番号を入力してください!");
        return false;
      }
      //AOJアカウントの取得
      //ユーザー名が入力されていなかった場合
      if (Config.Usename == "")
      {
        MessageBox.Show(@"アカウント名を入力してください！");
        return false;
      }
      //ユーザーのパスワードが入力されていなかった場合
      if (Config.Password == "")
      {
        MessageBox.Show(@"パスワードを入力してください!");
        return false;
      }
      return true;
    }

    private string buildFileName()
    {
      string fileName = _problemNumber;
      if (Config.IsSaveProblemName)
      {
        fileName += " " + ProblemName;
      }
      //問題名を保存する設定にしていて使用できない文字が含まれていた場合その文字を排除する
      string[] CannotUseName = new[] { "\\", "/", ":", "*", "?", "\"", "<", ">", "|" };
      foreach (string c in CannotUseName)
      {
        fileName = fileName.Replace(c, "");
      }
      return fileName + GetExtension.getExtension(LanguageBox.Text);
    }

    private string buildDirectoryName()
    {
      var directoryName = "";
      if (Config.SaveDirectory != "")
        directoryName = Config.SaveDirectory + @"\\";
      return directoryName + @"Volume " + _problemNumber.Substring(0, _problemNumber.Length - 2) + @"\\";
    }

    private void TweetStatus(JudgeStatus status)
    {
      TwitterService.SendTweet(new SendTweetOptions
      {
        Status =
          Config.Usename + "がAOJ" + _problemNumber + ":" + ProblemName + "を言語:" + LanguageBox.Text +
          "で" + status.ToAbbreviation() + "しました!\nhttp://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=" +
          _problemNumber + "&lang=jp\n#AOJWAinfo #AOJ_WA #AOJsubmitinfo"
      });
    }

    private void SaveSourceCode(string sourceCode)
    {
      new FileWriter().Write(buildDirectoryName(), buildFileName(), sourceCode);
    }

    private void SubmitButtonClick(object sender, EventArgs e)
    {
      ProblemName = new AojGetProblemName().Getproblemname(_problemNumber);
      if (!CanSubmit())
        return;
      AojAccount aojuserAccount = new AojAccount(Config.Usename, Config.Password);

      JudgeStatus status;
      try
      {
        status = new AojSubmit(aojuserAccount).Submit(_problemNumber, LanguageBox.Text, SourceCodeBox.Text);
      }
      catch
      {
        MessageBox.Show("Submit Error occured!");
        return;
      }

      TopMost = true;
      MessageBox.Show(status.ToDisplayString());
      switch (status)
      {
        case JudgeStatus.Accepted:
          TweetStatus(status);
          SaveSourceCode(SourceCodeBox.Text);
          break;
        case JudgeStatus.ParialPoints:
          TweetStatus(status);
          SaveSourceCode("//Partial Points.\n" + SourceCodeBox.Text);
          break;
        default:
          if (Config.IsTweetAll)
            TweetStatus(status);
          break;
      }
      Close();
    }

    private void ConfigButtonClick(object sender, EventArgs e)
    {
      ConfigForm configForm2 = new ConfigForm(Config);
      configForm2.Show();
    }

  }
}
