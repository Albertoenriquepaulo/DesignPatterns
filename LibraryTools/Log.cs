using System;
using System.IO;

namespace LibraryTools
{
	 public sealed class Log
	 {
		  private static Log _instance = null;
		  private string _path;

		  public static Log GetInstance(string path) => _instance == null ? _instance = new Log(path) : _instance;

		  private Log(string path)
		  {
				_path = path;
		  }

		  public void Save(string logMessage) => File.AppendAllText(_path, logMessage + Environment.NewLine);
	 }
}
