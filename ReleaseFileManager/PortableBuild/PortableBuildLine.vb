Imports System.ComponentModel

Class PortableBuildLine
	 Implements INotifyPropertyChanged

	 Const EXIT_LINE As String = "IF ERRORLEVEL 1 EXIT /B 1"

	 Dim _commentedOut As Boolean = False

	 Dim _filePath As String

	 Dim _lineType As PortableLineType

	 Dim _xCopyArgs As XCopyArgs

	 Dim Parsedline As String = String.Empty

	 Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	 Private Shared Function GetLineType(line As String) As PortableLineType
		  Select Case True
				Case line.StartsWith("rem")

					 Return PortableLineType.Comment
				Case line.StartsWith("xcopy")
					 Return PortableLineType.XCopy

				Case line.StartsWith("if errorlevel 1")
					 Return PortableLineType.ExitLine
				Case Else
					 Return PortableLineType.Other
		  End Select

	 End Function

	 Protected Overridable Sub OnPropertyChanged(e As PropertyChangedEventArgs)
		  RaiseEvent PropertyChanged(Me, e)
		  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Output)))
	 End Sub

	 Shared Function Parse(inputLine As String) As PortableBuildLine
		  If String.IsNullOrEmpty(inputLine) Then
				Return New PortableBuildLine With {.LineType = PortableLineType.Blank}
		  End If
		  inputLine = inputLine.Trim

		  Dim line As New PortableBuildLine
		  With line
				Dim lower As String = inputLine.ToLower

				.LineType = GetLineType(lower)
				If .LineType = PortableLineType.Comment Then
					 .LineType = GetLineType(lower.Replace("rem", String.Empty).Trim)
					 .CommentedOut = True
				End If
				Select Case .LineType
					 Case PortableLineType.XCopy
						  .XCopyArgs = New XCopyArgs
						  .XCopyArgs.OverWrite = lower.Contains("/y")
						  .XCopyArgs.OutputIsDirectory = lower.Contains("/i")
						  .FilePath = inputLine.Substring(inputLine.IndexOf(".."))
				End Select

				.Parsedline = inputLine


		  End With
		  Return line
	 End Function
	 Overrides Function ToString() As String
		  Dim result As String = If(CommentedOut, "REM ", String.Empty)
		  Select Case LineType
				Case PortableLineType.ExitLine
					 result &= EXIT_LINE
				Case PortableLineType.Other
					 result &= Parsedline
				Case PortableLineType.XCopy
					 result &= $"xcopy {XCopyArgs}{FilePath}"
				Case PortableLineType.Blank
					 Return String.Empty
		  End Select
		  Return result
	 End Function

	 Property CommentedOut As Boolean
		  Get
				Return _commentedOut
		  End Get
		  Set
				_commentedOut = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(CommentedOut)))
		  End Set
	 End Property
	 Property FilePath As String
		  Get
				Return _filePath
		  End Get
		  Set
				_filePath = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(FilePath)))
		  End Set
	 End Property
	 Property LineType As PortableLineType
		  Get
				Return _lineType
		  End Get
		  Set
				_lineType = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(LineType)))
		  End Set
	 End Property

	 ReadOnly Property Output
		  Get
				Return ToString()

		  End Get
	 End Property
	 Property XCopyArgs As XCopyArgs
		  Get
				Return _xCopyArgs
		  End Get
		  Set
				_xCopyArgs = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(XCopyArgs)))
		  End Set
	 End Property

	 Enum PortableLineType
		  Other = 0
		  Blank
		  Comment
		  ExitLine
		  XCopy
	 End Enum
End Class
