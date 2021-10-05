<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentList
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LastNameInpt = New System.Windows.Forms.TextBox()
        Me.FirstNameInpt = New System.Windows.Forms.TextBox()
        Me.GroupInpt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SelectBt = New System.Windows.Forms.Button()
        Me.LastNameLab = New System.Windows.Forms.Label()
        Me.FirstNameLab = New System.Windows.Forms.Label()
        Me.GroupLab = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastNameInpt
        '
        Me.LastNameInpt.Location = New System.Drawing.Point(121, 24)
        Me.LastNameInpt.Name = "LastNameInpt"
        Me.LastNameInpt.Size = New System.Drawing.Size(125, 27)
        Me.LastNameInpt.TabIndex = 0
        '
        'FirstNameInpt
        '
        Me.FirstNameInpt.Location = New System.Drawing.Point(336, 23)
        Me.FirstNameInpt.Name = "FirstNameInpt"
        Me.FirstNameInpt.Size = New System.Drawing.Size(125, 27)
        Me.FirstNameInpt.TabIndex = 1
        '
        'GroupInpt
        '
        Me.GroupInpt.Location = New System.Drawing.Point(543, 27)
        Me.GroupInpt.Name = "GroupInpt"
        Me.GroupInpt.Size = New System.Drawing.Size(80, 27)
        Me.GroupInpt.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 108)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(701, 330)
        Me.DataGridView1.TabIndex = 3
        '
        'SelectBt
        '
        Me.SelectBt.Location = New System.Drawing.Point(66, 73)
        Me.SelectBt.Name = "SelectBt"
        Me.SelectBt.Size = New System.Drawing.Size(94, 29)
        Me.SelectBt.TabIndex = 4
        Me.SelectBt.Text = "Choisir"
        Me.SelectBt.UseVisualStyleBackColor = True
        '
        'LastNameLab
        '
        Me.LastNameLab.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.LastNameLab.AutoSize = True
        Me.LastNameLab.Location = New System.Drawing.Point(62, 27)
        Me.LastNameLab.Name = "LastNameLab"
        Me.LastNameLab.Size = New System.Drawing.Size(42, 20)
        Me.LastNameLab.TabIndex = 5
        Me.LastNameLab.Text = "Nom"
        '
        'FirstNameLab
        '
        Me.FirstNameLab.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.FirstNameLab.AutoSize = True
        Me.FirstNameLab.Location = New System.Drawing.Point(267, 30)
        Me.FirstNameLab.Name = "FirstNameLab"
        Me.FirstNameLab.Size = New System.Drawing.Size(63, 20)
        Me.FirstNameLab.TabIndex = 6
        Me.FirstNameLab.Text = "PréNom"
        '
        'GroupLab
        '
        Me.GroupLab.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.GroupLab.AutoSize = True
        Me.GroupLab.Location = New System.Drawing.Point(479, 30)
        Me.GroupLab.Name = "GroupLab"
        Me.GroupLab.Size = New System.Drawing.Size(58, 20)
        Me.GroupLab.TabIndex = 7
        Me.GroupLab.Text = "Groupe"
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Location = New System.Drawing.Point(326, 73)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(53, 20)
        Me.message.TabIndex = 8
        Me.message.Text = "Label1"
        '
        'StudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.GroupLab)
        Me.Controls.Add(Me.FirstNameLab)
        Me.Controls.Add(Me.LastNameLab)
        Me.Controls.Add(Me.SelectBt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupInpt)
        Me.Controls.Add(Me.FirstNameInpt)
        Me.Controls.Add(Me.LastNameInpt)
        Me.Name = "StudentList"
        Me.Text = "Liste d'élève"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LastNameInpt As TextBox
    Friend WithEvents FirstNameInpt As TextBox
    Friend WithEvents GroupInpt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SelectBt As Button
    Friend WithEvents LastNameLab As Label
    Friend WithEvents FirstNameLab As Label
    Friend WithEvents GroupLab As Label
    Friend WithEvents message As Label
End Class
