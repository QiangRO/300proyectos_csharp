using System;
using Utilities;

class TestApp {
	static void Main(string[] args)	{
		FileAssociation FA = new FileAssociation();
		FA.Extension = "xyz";
		FA.ContentType = "application/myprogram";
		FA.FullName = "My XYZ Files!";
		FA.ProperName = "XYZ File";
		FA.AddCommand("open", "C:\\mydir\\myprog.exe %1");
		FA.Create();
		// Remove the file type from the registry
		FA.Remove();
	}
}
