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
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.cbSubfolders = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find:"
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
        Me.cmbExistingFileTypes.Location = New System.Drawing.Point(124, 28)
        Me.cmbExistingFileTypes.Name = "cmbExistingFileTypes"
        Me.cmbExistingFileTypes.Size = New System.Drawing.Size(166, 23)
        Me.cmbExistingFileTypes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Replace with"
        '
        'txtReplacement
        '
        Me.txtReplacement.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtReplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReplacement.ForeColor = System.Drawing.Color.White
        Me.txtReplacement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtReplacement.Location = New System.Drawing.Point(124, 76)
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(166, 23)
        Me.txtReplacement.TabIndex = 3
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRename.Location = New System.Drawing.Point(30, 379)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 4
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkGray
        Me.btnAdd.Location = New System.Drawing.Point(30, 161)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 27)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lvItems
        '
        Me.lvItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Find, Me.Replace})
        Me.lvItems.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItems.ForeColor = System.Drawing.Color.White
        Me.lvItems.FullRowSelect = True
        Me.lvItems.Location = New System.Drawing.Point(30, 202)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(260, 163)
        Me.lvItems.TabIndex = 7
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'Find
        '
        Me.Find.Text = "Find"
        Me.Find.Width = 131
        '
        'Replace
        '
        Me.Replace.Text = "Replace"
        Me.Replace.Width = 129
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUndo.Location = New System.Drawing.Point(185, 379)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(105, 27)
        Me.btnUndo.TabIndex = 8
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'cbSubfolders
        '
        Me.cbSubfolders.AutoSize = True
        Me.cbSubfolders.ForeColor = System.Drawing.Color.White
        Me.cbSubfolders.Location = New System.Drawing.Point(208, 117)
        Me.cbSubfolders.Name = "cbSubfolders"
        Me.cbSubfolders.Size = New System.Drawing.Size(82, 19)
        Me.cbSubfolders.TabIndex = 10
        Me.cbSubfolders.Text = "Subfolders"
        Me.cbSubfolders.UseVisualStyleBackColor = True
        '
        'frmFiletypeChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 425)
        Me.Controls.Add(Me.cbSubfolders)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbExistingFileTypes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFiletypeChanger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents btnUndo As Button
    Friend WithEvents cbSubfolders As CheckBox
End Class
