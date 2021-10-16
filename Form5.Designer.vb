<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rapport
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Prenom = New System.Windows.Forms.TextBox()
        Me.Sn = New System.Windows.Forms.TextBox()
        Me.InvNo = New System.Windows.Forms.TextBox()
        Me.detail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReportTitle = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 136)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(878, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(42, 32)
        Me.Nom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(110, 23)
        Me.Nom.TabIndex = 1
        '
        'Prenom
        '
        Me.Prenom.Location = New System.Drawing.Point(194, 32)
        Me.Prenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(110, 23)
        Me.Prenom.TabIndex = 2
        '
        'Sn
        '
        Me.Sn.Location = New System.Drawing.Point(337, 32)
        Me.Sn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sn.Name = "Sn"
        Me.Sn.Size = New System.Drawing.Size(110, 23)
        Me.Sn.TabIndex = 3
        '
        'InvNo
        '
        Me.InvNo.Location = New System.Drawing.Point(481, 32)
        Me.InvNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InvNo.Name = "InvNo"
        Me.InvNo.Size = New System.Drawing.Size(110, 23)
        Me.InvNo.TabIndex = 4
        '
        'detail
        '
        Me.detail.Location = New System.Drawing.Point(42, 110)
        Me.detail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(82, 22)
        Me.detail.TabIndex = 6
        Me.detail.Text = "Détail"
        Me.detail.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inventaire No"
        '
        'ReportTitle
        '
        Me.ReportTitle.AutoSize = True
        Me.ReportTitle.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReportTitle.Location = New System.Drawing.Point(337, 76)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Size = New System.Drawing.Size(88, 22)
        Me.ReportTitle.TabIndex = 11
        Me.ReportTitle.Text = "Report"
        '
        'Rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 406)
        Me.Controls.Add(Me.ReportTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.detail)
        Me.Controls.Add(Me.InvNo)
        Me.Controls.Add(Me.Sn)
        Me.Controls.Add(Me.Prenom)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Rapport"
        Me.Text = "Rapport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nom As TextBox
    Friend WithEvents Prenom As TextBox
    Friend WithEvents Sn As TextBox
    Friend WithEvents InvNo As TextBox
    Friend WithEvents detail As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ReportTitle As Label
End Class
