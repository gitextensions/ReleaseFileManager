
Class XCopyArgs

	 Overrides Function ToString() As String
		  Return $"{If(OverWrite, "/y ", String.Empty)}{If(OutputIsDirectory, "/i ", String.Empty)}"
	 End Function

	 Property OutputIsDirectory As Boolean
	 Property OverWrite As Boolean

End Class