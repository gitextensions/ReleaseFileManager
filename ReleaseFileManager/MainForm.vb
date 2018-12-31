Public Class MainForm


	 Private Sub dgvPortable_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvPortable.CurrentCellDirtyStateChanged
		  If TypeOf dgvPortable.CurrentCell Is DataGridViewCheckBoxCell Then
				dgvPortable.EndEdit()
		  End If
	 End Sub

	 Private Sub dgvPortable_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPortable.RowHeaderMouseDoubleClick
		  Dim line As PortableBuildLine = dgvPortable.Rows(e.RowIndex).DataBoundItem

	 End Sub

	 Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		  cboConfiguration.SelectedItem = "Release"

		  Dim lines As New List(Of PortableBuildLine)

		  'TODO Add File selection
		  Using rdr As New IO.StreamReader("D:\git\gitextensions\Setup\MakePortableArchive.cmd")
				While Not rdr.EndOfStream
					 Dim line As String = rdr.ReadLine
					 Dim Portable As PortableBuildLine = PortableBuildLine.Parse(line)
					 Console.WriteLine($"{Portable} << {Portable.LineType}{If(Portable.CommentedOut, ", Commented Out", "")} >>")
					 lines.Add(Portable)

				End While
		  End Using
		  PortableBuildLineBindingSource.DataSource = lines
		  dgvPortable.AutoResizeColumns()
	 End Sub
End Class
