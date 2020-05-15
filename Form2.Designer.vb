<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.NewSymbol = New System.Windows.Forms.Button()
        Me.DelSymbol = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.NullColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Symbol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExitProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewSymbol
        '
        Me.NewSymbol.Location = New System.Drawing.Point(13, 288)
        Me.NewSymbol.Name = "NewSymbol"
        Me.NewSymbol.Size = New System.Drawing.Size(106, 23)
        Me.NewSymbol.TabIndex = 1
        Me.NewSymbol.Text = "New"
        Me.NewSymbol.UseVisualStyleBackColor = True
        '
        'DelSymbol
        '
        Me.DelSymbol.Location = New System.Drawing.Point(125, 288)
        Me.DelSymbol.Name = "DelSymbol"
        Me.DelSymbol.Size = New System.Drawing.Size(106, 23)
        Me.DelSymbol.TabIndex = 2
        Me.DelSymbol.Text = "Delete"
        Me.DelSymbol.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NullColumn, Me.Code, Me.Symbol})
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 12)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(218, 270)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NullColumn
        '
        Me.NullColumn.Text = "Null"
        Me.NullColumn.Width = 0
        '
        'Code
        '
        Me.Code.Text = "Code"
        Me.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Code.Width = 100
        '
        'Symbol
        '
        Me.Symbol.Text = "Symbol"
        Me.Symbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Symbol.Width = 100
        '
        'ExitProgram
        '
        Me.ExitProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitProgram.Location = New System.Drawing.Point(83, 338)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(75, 23)
        Me.ExitProgram.TabIndex = 5
        Me.ExitProgram.Text = "Exit"
        Me.ExitProgram.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitProgram
        Me.ClientSize = New System.Drawing.Size(243, 318)
        Me.Controls.Add(Me.ExitProgram)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DelSymbol)
        Me.Controls.Add(Me.NewSymbol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unicode Input"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewSymbol As Button
    Friend WithEvents DelSymbol As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents NullColumn As ColumnHeader
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents Symbol As ColumnHeader
    Friend WithEvents ExitProgram As Button
End Class
