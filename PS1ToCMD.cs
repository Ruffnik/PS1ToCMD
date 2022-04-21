var InFile = Environment.GetCommandLineArgs()[1];
var OutFile = Path.ChangeExtension(InFile, "cmd");
File.WriteAllText(OutFile, "@PowerShell -ExecutionPolicy RemoteSigned -EncodedCommand " + Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(File.ReadAllText(InFile))));