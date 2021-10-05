<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReparationForm
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
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Groupe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StudentSearchBt = New System.Windows.Forms.Button()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(594, 148)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(361, 198)
        Me.TextBox8.TabIndex = 7
        '
        'FirstName
        '
        Me.FirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirstName.Location = New System.Drawing.Point(130, 93)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(150, 34)
        Me.FirstName.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(594, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 34)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(594, 83)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 34)
        Me.TextBox4.TabIndex = 10
        '
        'Groupe
        '
        Me.Groupe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Groupe.Location = New System.Drawing.Point(130, 165)
        Me.Groupe.Name = "Groupe"
        Me.Groupe.Size = New System.Drawing.Size(150, 34)
        Me.Groupe.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(26, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Groupe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(414, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Numéro Sérial "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(377, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Numéro Inventaire"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(377, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 28)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cause/ Problème"
        '
        'StudentSearchBt
        '
        Me.StudentSearchBt.Location = New System.Drawing.Point(26, 234)
        Me.StudentSearchBt.Name = "StudentSearchBt"
        Me.StudentSearchBt.Size = New System.Drawing.Size(135, 29)
        Me.StudentSearchBt.TabIndex = 18
        Me.StudentSearchBt.Text = "Chercher Élève"
        Me.StudentSearchBt.UseVisualStyleBackColor = True
        '
        'LastName
        '
        Me.LastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LastName.Location = New System.Drawing.Point(130, 38)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(150, 34)
        Me.LastName.TabIndex = 19
        '
        'ReparationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 516)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.StudentSearchBt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Groupe)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.TextBox8)
        Me.Name = "ReparationForm"
        Me.Text = "Réparation Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Groupe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StudentSearchBt As Button
    Friend WithEvents LastName As TextBox
End Class
