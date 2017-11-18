<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenameParentFolder
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReplacement = New System.Windows.Forms.TextBox()
        Me.btnUndo = New MassFART.ccButton()
        Me.btnRename = New MassFART.ccButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRename)
        Me.Panel1.Controls.Add(Me.btnUndo)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 137)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(16, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Rename Parent Folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Replace with"
        '
        'txtReplacement
        '
        Me.txtReplacement.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtReplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReplacement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReplacement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtReplacement.Location = New System.Drawing.Point(125, 50)
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(169, 23)
        Me.txtReplacement.TabIndex = 22
        Me.txtReplacement.Text = "(displays current name)"
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnUndo.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.disabledBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnUndo.disabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.disabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUndo.Enabled = False
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.ForeColor = System.Drawing.Color.DarkGray
        Me.btnUndo.Location = New System.Drawing.Point(185, 95)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(105, 27)
        Me.btnUndo.TabIndex = 25
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRename.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.disabledBackColor = System.Drawing.Color.Empty
        Me.btnRename.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnRename.disabledForeColor = System.Drawing.Color.Empty
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRename.Location = New System.Drawing.Point(15, 95)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 24
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'RenameParentFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RenameParentFolder"
        Me.Size = New System.Drawing.Size(313, 142)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReplacement As TextBox
    Friend WithEvents btnUndo As ccButton
    Friend WithEvents btnRename As ccButton
End Class
