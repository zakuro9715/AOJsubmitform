﻿using System.IO;
using System.Text;

namespace AOJsubmitform {
	class ConfigWriter {
		public void ConfigWrite(string username, string userpassword, string writedirectory, bool saveproblemname)
		{
			StreamWriter configWriter = new StreamWriter(@"Config.txt", false, Encoding.Default);
			configWriter.WriteLine(username);
			configWriter.WriteLine(userpassword);
			configWriter.WriteLine(writedirectory);
			if (saveproblemname)
			{
				configWriter.WriteLine("save");
			}
			else
			{
				configWriter.WriteLine("");
			}
			configWriter.Close();
		}

		public void TwitterConfigWrite(string twitterToken, string twitterTokenSecret)
		{
			StreamWriter twitterconfigWriter = new StreamWriter(@"TwitterConfig.txt", false, Encoding.Default);
			twitterconfigWriter.WriteLine(twitterToken);
			twitterconfigWriter.WriteLine(twitterTokenSecret);
			twitterconfigWriter.Close();
		}
	}
}