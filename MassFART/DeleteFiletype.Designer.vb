﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteFiletype
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbSubfolders = New System.Windows.Forms.CheckBox()
        Me.btnUndo = New MassFART.ccButton()
        Me.btnRename = New MassFART.ccButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExistingFileTypes2 = New System.Windows.Forms.ComboBox()
        Me.txtDisplayNoFiles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbSubfolders)
        Me.Panel1.Controls.Add(Me.btnUndo)
        Me.Panel1.Controls.Add(Me.btnRename)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbExistingFileTypes2)
        Me.Panel1.Controls.Add(Me.txtDisplayNoFiles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 198)
        Me.Panel1.TabIndex = 20
        '
        'cbSubfolders
        '
        Me.cbSubfolders.AutoSize = True
        Me.cbSubfolders.ForeColor = System.Drawing.Color.White
        Me.cbSubfolders.Location = New System.Drawing.Point(15, 87)
        Me.cbSubfolders.Name = "cbSubfolders"
        Me.cbSubfolders.Size = New System.Drawing.Size(124, 19)
        Me.cbSubfolders.TabIndex = 19
        Me.cbSubfolders.Text = "Include Subfolders"
        Me.cbSubfolders.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnUndo.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.disabledBackColor = System.Drawing.Color.Empty
        Me.btnUndo.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnUndo.disabledForeColor = System.Drawing.Color.Empty
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.DarkGray
        Me.btnUndo.Location = New System.Drawing.Point(185, 156)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(105, 27)
        Me.btnUndo.TabIndex = 18
        Me.btnUndo.Text = "Restore"
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
        Me.btnRename.Location = New System.Drawing.Point(15, 156)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 17
        Me.btnRename.Text = "Delete"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(182, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "No. of Files"
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
        Me.cmbExistingFileTypes2.Location = New System.Drawing.Point(121, 45)
        Me.cmbExistingFileTypes2.Name = "cmbExistingFileTypes2"
        Me.cmbExistingFileTypes2.Size = New System.Drawing.Size(169, 23)
        Me.cmbExistingFileTypes2.TabIndex = 12
        '
        'txtDisplayNoFiles
        '
        Me.txtDisplayNoFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtDisplayNoFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisplayNoFiles.ForeColor = System.Drawing.Color.White
        Me.txtDisplayNoFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDisplayNoFiles.Location = New System.Drawing.Point(185, 107)
        Me.txtDisplayNoFiles.Name = "txtDisplayNoFiles"
        Me.txtDisplayNoFiles.Size = New System.Drawing.Size(105, 23)
        Me.txtDisplayNoFiles.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Find Filetype:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "File Deletion Utility"
        '
        'DeleteFiletype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DeleteFiletype"
        Me.Size = New System.Drawing.Size(313, 204)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbExistingFileTypes2 As ComboBox
    Friend WithEvents txtDisplayNoFiles As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRename As ccButton
    Friend WithEvents btnUndo As ccButton
    Friend WithEvents cbSubfolders As CheckBox
    Public WithEvents Label3 As Label
End Class
