<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiletypeChanger
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExistingFileTypes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReplacement = New System.Windows.Forms.TextBox()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.Find = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Replace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbSubfolders = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find:"
        '
        'cmbExistingFileTypes
        '
        Me.cmbExistingFileTypes.FormattingEnabled = True
        Me.cmbExistingFileTypes.Location = New System.Drawing.Point(85, 15)
        Me.cmbExistingFileTypes.Name = "cmbExistingFileTypes"
        Me.cmbExistingFileTypes.Size = New System.Drawing.Size(150, 21)
        Me.cmbExistingFileTypes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Replace with"
        '
        'txtReplacement
        '
        Me.txtReplacement.Location = New System.Drawing.Point(86, 55)
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(149, 20)
        Me.txtReplacement.TabIndex = 3
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(12, 223)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(90, 23)
        Me.btnRename.TabIndex = 4
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(145, 91)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Find, Me.Replace})
        Me.lvItems.Location = New System.Drawing.Point(12, 120)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(223, 97)
        Me.lvItems.TabIndex = 7
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'Find
        '
        Me.Find.Text = "Find"
        Me.Find.Width = 91
        '
        'Replace
        '
        Me.Replace.Text = "Replace"
        Me.Replace.Width = 127
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 223)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbSubfolders
        '
        Me.cbSubfolders.AutoSize = True
        Me.cbSubfolders.Location = New System.Drawing.Point(26, 91)
        Me.cbSubfolders.Name = "cbSubfolders"
        Me.cbSubfolders.Size = New System.Drawing.Size(76, 17)
        Me.cbSubfolders.TabIndex = 9
        Me.cbSubfolders.Text = "Subfolders"
        Me.cbSubfolders.UseVisualStyleBackColor = True
        '
        'frmFiletypeChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 258)
        Me.Controls.Add(Me.cbSubfolders)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbExistingFileTypes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFiletypeChanger"
        Me.Text = "Advanced Rename"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbExistingFileTypes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReplacement As TextBox
    Friend WithEvents btnRename As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lvItems As ListView
    Friend WithEvents Find As ColumnHeader
    Friend WithEvents Replace As ColumnHeader
    Friend WithEvents btnExit As Button
    Friend WithEvents cbSubfolders As CheckBox
End Class
