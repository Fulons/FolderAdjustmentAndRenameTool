<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileExtensionEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cbSubfolders = New System.Windows.Forms.CheckBox()
        Me.txtReplacement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExistingFileTypes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbSubfolders
        '
        Me.cbSubfolders.AutoSize = True
        Me.cbSubfolders.ForeColor = System.Drawing.Color.White
        Me.cbSubfolders.Location = New System.Drawing.Point(189, 58)
        Me.cbSubfolders.Name = "cbSubfolders"
        Me.cbSubfolders.Size = New System.Drawing.Size(76, 17)
        Me.cbSubfolders.TabIndex = 15
        Me.cbSubfolders.Text = "Subfolders"
        Me.cbSubfolders.UseVisualStyleBackColor = True
        '
        'txtReplacement
        '
        Me.txtReplacement.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtReplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReplacement.ForeColor = System.Drawing.Color.White
        Me.txtReplacement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtReplacement.Location = New System.Drawing.Point(99, 32)
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(166, 20)
        Me.txtReplacement.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Replace with"
        '
        'cmbExistingFileTypes
        '
        Me.cmbExistingFileTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbExistingFileTypes.DropDownHeight = 82
        Me.cmbExistingFileTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingFileTypes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExistingFileTypes.ForeColor = System.Drawing.Color.White
        Me.cmbExistingFileTypes.FormattingEnabled = True
        Me.cmbExistingFileTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbExistingFileTypes.IntegralHeight = False
        Me.cmbExistingFileTypes.Location = New System.Drawing.Point(99, 3)
        Me.cmbExistingFileTypes.Name = "cmbExistingFileTypes"
        Me.cmbExistingFileTypes.Size = New System.Drawing.Size(166, 23)
        Me.cmbExistingFileTypes.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Find:"
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRename.Location = New System.Drawing.Point(8, 58)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 16
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'FileExtensionEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.cbSubfolders)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbExistingFileTypes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FileExtensionEditor"
        Me.Size = New System.Drawing.Size(273, 98)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSubfolders As CheckBox
    Friend WithEvents txtReplacement As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbExistingFileTypes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRename As Button
End Class
