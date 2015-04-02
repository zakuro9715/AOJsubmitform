using System.IO;
using System.Text;

namespace AOJsubmitform
{
  public class Config
  {
    public string Usename { get; set; }
    public string Password { get; set; }
    public string SaveDirectory { get; set; }
    public bool EnableAsciiFilter { get; set; }
    public bool IsSaveProblemName { get; set; }
    public bool IsTweetAll { get; set; }

    public string TwitterToken { get; set; }
    public string TwitterTokenSecret { get; set; }

    public Config()
    {
      Usename = Password = SaveDirectory = TwitterToken = TwitterTokenSecret = "";
    }

    public void Write()
    {
      File.WriteAllBytes("UserName.bin", Encoding.Unicode.GetBytes(Usename));
      File.WriteAllBytes("UserPassWord.bin", Encoding.Unicode.GetBytes(Password));
      File.WriteAllBytes("AsciiFilter.bin", Encoding.Unicode.GetBytes(EnableAsciiFilter ? "enabled" : ""));
      File.WriteAllBytes("WriteDirectory.bin", Encoding.Unicode.GetBytes(SaveDirectory));
      File.WriteAllBytes("SaveProblemName.bin", Encoding.Unicode.GetBytes(IsSaveProblemName ? "save" : ""));
      File.WriteAllBytes("TweetAll.bin", Encoding.Unicode.GetBytes(IsTweetAll ? "tweet" : ""));
      File.WriteAllBytes("TwitterToken.bin", Encoding.Unicode.GetBytes(TwitterToken));
      File.WriteAllBytes("TwitterTokenSecret.bin", Encoding.Unicode.GetBytes(TwitterTokenSecret));
    }

    public void Load()
    {
      //旧形式の設定記録ファイルから設定を呼び出して新形式の設定記録方式に変更する
      if (File.Exists("Config.txt"))
      {
        StreamReader configFileReader = new StreamReader("Config.txt");
        Usename = configFileReader.ReadLine();
        Password = configFileReader.ReadLine();
        SaveDirectory = configFileReader.ReadLine();
        IsSaveProblemName = configFileReader.ReadLine() == "save";
        configFileReader.Close();
        //旧形式の設定ファイルを削除する
        File.Delete(@"Config.txt");
      }

      //新しい方式の設定記録ファイル（無意味なバイナリ式）から設定を呼び出す
      if (File.Exists("UserName.bin"))
      {
        Usename = Encoding.Unicode.GetString(File.ReadAllBytes("UserName.bin"));
      }
      if (File.Exists("UserPassWord.bin"))
      {
        Password = Encoding.Unicode.GetString(File.ReadAllBytes("UserPassWord.bin"));
      }
      if(File.Exists("AsciiFilter.bin"))
      {
        EnableAsciiFilter = Encoding.Unicode.GetString(File.ReadAllBytes("AsciiFilter.bin")) == "enabled";
      }
      if (File.Exists("WriteDirectory.bin"))
      {
        SaveDirectory = Encoding.Unicode.GetString(File.ReadAllBytes("WriteDirectory.bin"));
      }
      if (File.Exists("SaveProblemName.bin"))
      {
        IsSaveProblemName = Encoding.Unicode.GetString(File.ReadAllBytes("SaveProblemName.bin")) == "save";
      }
      if (File.Exists("TweetAll.bin"))
      {
        IsTweetAll = Encoding.Unicode.GetString(File.ReadAllBytes("TweetAll.bin")) == "tweet";
      }

      //Twitterにおける設定も同様に行う
      if (File.Exists("TwitterConfig.txt"))
      {
        StreamReader twitterConfigFileReader = new StreamReader("TwitterConfig.txt");
        TwitterToken = twitterConfigFileReader.ReadLine();
        TwitterTokenSecret = twitterConfigFileReader.ReadLine();
        twitterConfigFileReader.Close();
        File.Delete(@"TwitterConfig.txt");
      }
      if (File.Exists("TwitterToken.bin"))
      {
        TwitterToken = Encoding.Unicode.GetString(File.ReadAllBytes("TwitterToken.bin"));
      }
      if (File.Exists("TwitterTokenSecret.bin"))
      {
        TwitterTokenSecret = Encoding.Unicode.GetString(File.ReadAllBytes("TwitterTokenSecret.bin"));
      }

      Write();
    }
  }
}
