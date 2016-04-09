Module FuncionesAyuda

    ''' <summary>
    ''' Función que puede tanto activar como desactivar los controles de un panel
    ''' </summary>
    ''' <param name="panel">The panel.</param>
    Public Sub ActivaDesactiva(ByRef panel As Panel)
        Dim objects As Control
        Dim group As Control
        For Each objects In panel.Controls
            If TypeOf objects Is GroupBox Then
                For Each group In objects.Controls
                    If TypeOf group Is TextBox Then
                        If group.Enabled = True Then
                            group.Enabled = False
                        Else
                            group.Enabled = True
                        End If
                    End If
                    If TypeOf group Is MaskedTextBox Then
                        If group.Enabled = True Then
                            group.Enabled = False
                        Else
                            group.Enabled = True
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    ''' <summary>
    ''' Función para borrar las TextBox, RichTextBox y MaskedTextBox, poner el Combo-box con el indice 0.
    ''' </summary>
    ''' <param name="panel">The panel.</param>
    Public Sub BorradoCajas(ByRef panel As Panel)
        Dim objects As Control
        Dim group As Control
        For Each objects In panel.Controls
            If TypeOf objects Is GroupBox Then
                For Each group In objects.Controls
                    If TypeOf group Is TextBox Then
                        group.Text = Nothing
                    End If
                    Dim comboBox = TryCast(group, ComboBox)
                    If (comboBox IsNot Nothing) Then
                        If comboBox.Items.Count > 0 Then
                            comboBox.SelectedIndex = 0
                        End If
                    End If
                    If TypeOf group Is RichTextBox Then
                        group.Text = Nothing
                    End If
                    If TypeOf group Is MaskedTextBox Then
                        group.Text = Nothing
                    End If
                Next
            End If
        Next
    End Sub

    ''' <summary>
    ''' Permite capturar el evento de KeyPress y evitar que se escriban caracteres diferentes a los números
    ''' </summary>
    ''' <param name="e"><see cref="KeyPressEventArgs"/> La instancia del evento que contiene los datos.</param>
    Public Sub OnlyNumbers(ByRef e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Función que comprueba si las TextBox, RichTextBox y MaskedTextBox contienen caracteres, devuelve True si es así y False si no lo es
    ''' </summary>
    ''' <param name="panel">EL panel donde se encuentran los controles.</param>
    ''' <returns></returns>
    Public Function Comprobacion(ByRef panel As Panel) As Boolean
        Dim objects As Control
        Dim group As Control
        For Each objects In panel.Controls
            If TypeOf objects Is GroupBox Then
                For Each group In objects.Controls
                    If TypeOf group Is TextBox Then
                        If group.Text.Length = 0 Then
                            Return False
                        End If
                    End If
                    If TypeOf group Is RichTextBox Then
                        If group.Text.Length = 0 Then
                            Return False
                        End If
                    End If
                    If TypeOf group Is MaskedTextBox Then
                        If group.Text.Length = 0 Then
                            Return False
                        End If
                    End If
                Next
            End If
        Next
        Return True
    End Function

    ''' <summary>
    ''' Permite capturar el evento de KeyPress y evitar que se escriban caracteres diferentes a las letras
    ''' </summary>
    ''' <param name="e"><see cref="KeyPressEventArgs"/> La instancia del evento que contiene los datos.</param>
    Public Sub OnlyLetters(ByRef e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Public Sub SizeColumnsToContent(dataGrid As DataGrid, nRowsToScan As Integer)
        ' Create graphics object for measuring widths.
        Dim Graphics As Graphics = dataGrid.CreateGraphics()

        ' Define new table style.
        Dim tableStyle As New DataGridTableStyle()

        Try
            Dim dataTable As DataTable = DirectCast(dataGrid.DataSource, DataTable)

            If -1 = nRowsToScan Then
                nRowsToScan = dataTable.Rows.Count
            Else
                ' Can only scan rows if they exist.
                nRowsToScan = System.Math.Min(nRowsToScan, dataTable.Rows.Count)
            End If
            With tableStyle
                .AlternatingBackColor = dataGrid.AlternatingBackColor
                .BackColor = dataGrid.BackColor
                .ForeColor = dataGrid.ForeColor
                .GridLineColor = dataGrid.GridLineColor
                .HeaderBackColor = dataGrid.HeaderBackColor
                .HeaderForeColor = dataGrid.HeaderForeColor
                .SelectionBackColor = dataGrid.SelectionBackColor
                .SelectionForeColor = dataGrid.SelectionForeColor
            End With

            ' Clear any existing table styles.
            dataGrid.TableStyles.Clear()

            ' Use mapping name that is defined in the data source.
            tableStyle.MappingName = dataTable.TableName

            ' Now create the column styles within the table style.
            Dim columnStyle As DataGridTextBoxColumn
            Dim iWidth As Integer

            For iCurrCol As Integer = 0 To dataTable.Columns.Count - 1
                Dim dataColumn As DataColumn = dataTable.Columns(iCurrCol)

                columnStyle = New DataGridTextBoxColumn()

                columnStyle.TextBox.Enabled = True
                columnStyle.HeaderText = dataColumn.ColumnName
                columnStyle.MappingName = dataColumn.ColumnName

                ' Set width to header text width.
                iWidth = CInt(Graphics.MeasureString(columnStyle.HeaderText, dataGrid.Font).Width)

                ' Change width, if data width is wider than header text width.
                ' Check the width of the data in the first X rows.
                Dim dataRow As DataRow
                For iRow As Integer = 0 To nRowsToScan - 1
                    dataRow = dataTable.Rows(iRow)

                    If dataRow(dataColumn.ColumnName) IsNot Nothing Then
                        Dim iColWidth As Integer = CInt(Graphics.MeasureString(dataRow.ItemArray(iCurrCol).ToString(), dataGrid.Font).Width)
                        iWidth = CInt(System.Math.Max(iWidth, iColWidth))
                    End If
                Next
                columnStyle.Width = iWidth + 4

                ' Add the new column style to the table style.
                tableStyle.GridColumnStyles.Add(columnStyle)
            Next
            ' Add the new table style to the data grid.
            dataGrid.TableStyles.Add(tableStyle)
        Catch e As Exception
            MessageBox.Show(e.Message)
        Finally
            Graphics.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Da formato al numero de forma que : 000x
    ''' </summary>
    ''' <param name="number">Numero a dar formato.</param>
    ''' <returns></returns>
    Public Function FormatNumber(number As Integer) As String
        Return [String].Format("{0:0000}", number)
    End Function

End Module



