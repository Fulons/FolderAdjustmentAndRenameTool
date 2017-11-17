<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscardFiletype
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbSelectedFolders = New System.Windows.Forms.CheckBox()
        Me.cmbExistingFileTypes2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAllFolders = New System.Windows.Forms.CheckBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDisplayNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbSelectedFolders
        '
        Me.cbSelectedFolders.AutoSize = True
        Me.cbSelectedFolders.ForeColor = System.Drawing.Color.White
        Me.cbSelectedFolders.Location = New System.Drawing.Point(33, 75)
        Me.cbSelectedFolders.Name = "cbSelectedFolders"
        Me.cbSelectedFolders.Size = New System.Drawing.Size(119, 19)
        Me.cbSelectedFolders.TabIndex = 11
        Me.cbSelectedFolders.Text = "Selected Folder(s)"
        Me.cbSelectedFolders.UseVisualStyleBackColor = True
        '
        'cmbExistingFileTypes2
        '
        Me.cmbExistingFileTypes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbExistingFileTypes2.DropDownHeight = 82
        Me.cmbExistingFileTypes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingFileTypes2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExistingFileTypes2.ForeColor = System.Drawing.Color.White
        Me.cmbExistingFileTypes2.FormattingEnabled = True
        Me.cmbExistingFileTypes2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbExistingFileTypes2.IntegralHeight = False
        Me.cmbExistingFileTypes2.Location = New System.Drawing.Point(124, 28)
        Me.cmbExistingFileTypes2.Name = "cmbExistingFileTypes2"
        Me.cmbExistingFileTypes2.Size = New System.Drawing.Size(166, 23)
        Me.cmbExistingFileTypes2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Find:"
        '
        'cbAllFolders
        '
        Me.cbAllFolders.AutoSize = True
        Me.cbAllFolders.ForeColor = System.Drawing.Color.White
        Me.cbAllFolders.Location = New System.Drawing.Point(33, 100)
        Me.cbAllFolders.Name = "cbAllFolders"
        Me.cbAllFolders.Size = New System.Drawing.Size(81, 19)
        Me.cbAllFolders.TabIndex = 14
        Me.cbAllFolders.Text = "All Folders"
        Me.cbAllFolders.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestore.Location = New System.Drawing.Point(185, 146)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(105, 27)
        Me.btnRestore.TabIndex = 15
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkGray
        Me.btnDelete.Location = New System.Drawing.Point(30, 146)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 27)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtDisplayNumber
        '
        Me.txtDisplayNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtDisplayNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisplayNumber.ForeColor = System.Drawing.Color.White
        Me.txtDisplayNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDisplayNumber.Location = New System.Drawing.Point(185, 96)
        Me.txtDisplayNumber.Name = "txtDisplayNumber"
        Me.txtDisplayNumber.Size = New System.Drawing.Size(105, 23)
        Me.txtDisplayNumber.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(182, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "No. of Files"
        '
        'DiscardFiletype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 192)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisplayNumber)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.cbAllFolders)
        Me.Controls.Add(Me.cmbExistingFileTypes2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSelectedFolders)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DiscardFiletype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Filetype"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSelectedFolders As CheckBox
    Friend WithEvents cmbExistingFileTypes2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAllFolders As CheckBox
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDisplayNumber As TextBox
    Friend WithEvents Label2 As Label
End Class
