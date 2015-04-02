using System;
using System.Windows.Forms;

namespace AOJsubmitform
{
  public partial class ConfigForm : Form
  {
    private Config config;

    public ConfigForm(Config config)
    {
      InitializeComponent();
      this.config = config;
      Initialize();
    }

    private void Initialize()
    {
      UserNameBox.Text = config.Usename;
      PassWordBox.Text = config.Password;
      DirectoryNameBox.Text = config.SaveDirectory;
      asciiFilterCheckBox.Checked = config.IsSaveProblemName;
      TweetAllCheckBox.Checked = config.IsTweetAll;
    }

    private void Save()
    {
      config.Usename = UserNameBox.Text;
      config.Password = PassWordBox.Text;
      config.EnableAsciiFilter = asciiFilterCheckBox.Checked;
      config.SaveDirectory = DirectoryNameBox.Text;
      config.IsSaveProblemName = asciiFilterCheckBox.Checked;
      config.IsTweetAll = TweetAllCheckBox.Checked;
      config.Write();
    }

    private void twitterConfigButton_Click(object sender, EventArgs e)
    {
      TwitterAttestationForm twitterAttestationForm = new TwitterAttestationForm(config);
      twitterAttestationForm.Show();
    }

    private void OkButtonClick(object sender, EventArgs e)
    {
      Save();
      Close();
    }
  }
}
