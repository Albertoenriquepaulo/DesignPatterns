using System;
using System.IO;

namespace LibraryTools
{
	 public sealed class Log
	 {
		  private readonly static Log _instance = new Log();
		  private string _path = "log.txt";

		  public static Log Instance
		  {
				get
				{
					 return _instance;
				}
		  }

		  private Log()
		  {

		  }

		  public void Save(string logMessage) => File.AppendAllText(_path, logMessage + Environment.NewLine);
	 }
}
