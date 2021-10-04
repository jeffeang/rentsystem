<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPage
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
        Me.ReparationBt = New System.Windows.Forms.Button()
        Me.PretBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReparationBt
        '
        Me.ReparationBt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReparationBt.Location = New System.Drawing.Point(262, 101)
        Me.ReparationBt.Name = "ReparationBt"
        Me.ReparationBt.Size = New System.Drawing.Size(251, 62)
        Me.ReparationBt.TabIndex = 0
        Me.ReparationBt.Text = "Réparation"
        Me.ReparationBt.UseVisualStyleBackColor = True
        '
        'PretBt
        '
        Me.PretBt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PretBt.Location = New System.Drawing.Point(262, 220)
        Me.PretBt.Name = "PretBt"
        Me.PretBt.Size = New System.Drawing.Size(251, 62)
        Me.PretBt.TabIndex = 1
        Me.PretBt.Text = "Prêt ChromeBook"
        Me.PretBt.UseVisualStyleBackColor = True
        '
        'MenuPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 476)
        Me.Controls.Add(Me.PretBt)
        Me.Controls.Add(Me.ReparationBt)
        Me.Name = "MenuPage"
        Me.Text = "Menu Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReparationBt As Button
    Friend WithEvents PretBt As Button
End Class
