<Query Kind="VBProgram">
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.VisualBasic.dll</Reference>
  <Namespace>&lt;xmlns='http://schemas.microsoft.com/wix/2006/wi'&gt;</Namespace>
  <Namespace>Microsoft.VisualBasic</Namespace>
  <Namespace>System</Namespace>
</Query>

Sub Main
	Dim doc = XElement.Load("D:\git\gitextensions\Setup\Product.wxs")

	Dim installerFiles = doc...<File>.Select(Function(nd) New With {.Node = nd, .Path = io.Path.GetFullPath(IO.Path.Combine("D:\git\gitextensions\Setup\", nd.@Source.Replace("$(var.Configuration)", "Release")))})
	'installerFiles.GroupBy(Function(f) io.Path.GetExtension(f.Path)).Dump("Installer files By extension")


	Dim installerDetails = installerFiles.Select(Function(f) New With {.Node = f.Node, .ParentNode = f.Node.Parent, .Info = New io.FileInfo(f.Path), .Hash = Sha512Hash(f.Path)})


	Dim releaseFiles = IO.Directory.EnumerateFiles("D:\git\gitextensions\gitextensions\bin\Release\", "*.*", searchOption.AllDirectories)
	'releaseFiles.GroupBy(Function(f) io.Path.GetExtension(f)).Dump("Release files By extension")

	Dim releaseDetails = releaseFiles.Select(Function(f) New With {.Info = New io.FileInfo(f), .Hash = Sha512Hash(f)})

	Dim matched = From ReleaseFile In releaseDetails
				  Group Join InstallerFile In installerDetails On InstallerFile.Hash Equals ReleaseFile.Hash Into MatchedInstallerFiles = Group
				  Where MatchedInstallerFiles.Any(Function(f) Not f.Info.FullName.StartsWith("D:\git\gitextensions\GitExtensions\bin\Release\", StringComparison.CurrentCultureIgnoreCase))

	matched.Select(Function(f) New With {.ReleaseFile = f.ReleaseFile.Info.FullName, .ReleaseHash = f.ReleaseFile.Hash, .MatchedInstallerFiles = f.MatchedInstallerFiles}).Dump("Installer files that also exist in GitExtensions\bin\Release\")






End Sub

' Define other methods and classes here

Function Sha512Hash(path As String) As String
	Static sha As System.Security.Cryptography.SHA512 = System.Security.Cryptography.SHA512CryptoServiceProvider.Create()
	If Not file.Exists(path) Then Return String.Empty
	Using fstream As New IO.FileStream(path, FileMode.Open, FileAccess.Read)
		Return String.Join("", sha.ComputeHash(fstream).Select(Function(b) b.ToString("X2")))
	End Using

End Function