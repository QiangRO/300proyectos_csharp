using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Koders
{
	public class SearchResult : INotifyPropertyChanged
	{
		public SearchResult() {}

		public SearchResult(string path, string rawResult)
		{
			string[] parts = rawResult.Split(':');
			bool success = false;
			if (parts.Length >= 3)
			{
				this.Path = path.TrimEnd('\\') + @"\" + parts[0].Trim();
				int line;
				if (Int32.TryParse(parts[1], out line))
				{
					this.Line = line;
					string	results=string.Empty;
					for (int idx = 2; idx < parts.Length; idx++)
					{
						if (idx > 2)
						{
							results += (":" + parts[idx]);
						}
						else
						{
							results += parts[idx];
						}
					}

					this.Results = results.Trim().Replace('\t', ' ');
					success = true;
				}
			}

			if (!success)
			{
				throw new ArgumentException("Error parsing line: '" + rawResult + "'");
			}
		}

		public SearchResult(string path, int line, string results)
		{
			this.Path = path;
			this.Line = line;
			this.Results = results;
		}

		private string _path;

		public string Path
		{
			get { return _path; }
			set
			{
				if (value != _path)
				{
					_path = value;
					OnPropertyChanged(new PropertyChangedEventArgs("Path"));
					int idx = _path.LastIndexOf('.');

					if ((idx > 0) && (idx < _path.Length))
					{
						this.Extension = _path.Substring(idx + 1);
					}
					else
					{
						this.Extension = string.Empty;
					}
				}
			}
		}
		
		private string _ext;

		[Browsable(false)]
		public string Extension
		{
			get { return _ext; }
			set
			{
				if (value != _ext)
				{
					_ext = value;
					OnPropertyChanged(new PropertyChangedEventArgs("Extension"));
				}
			}
		}

		private int _line;

		public int Line
		{
			get { return _line; }
			set
			{
				if (value != _line)
				{
					_line = value;
					OnPropertyChanged(new PropertyChangedEventArgs("Line"));
				}
			}
		}

		private string _results;

		public string Results
		{
			get { return _results; }
			set
			{
				if (value != _results)
				{
					_results = value;
					OnPropertyChanged(new PropertyChangedEventArgs("Results"));
				}
			}
		}

		#region INotifyPropertyChanged Members

		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (null != this.PropertyChanged)
			{
				PropertyChanged(this, e);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}
