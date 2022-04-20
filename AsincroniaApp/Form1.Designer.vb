<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.btnAsync = New System.Windows.Forms.Button()
        Me.btnAsyncWithValue = New System.Windows.Forms.Button()
        Me.LbLog = New System.Windows.Forms.Label()
        Me.lbRegistro = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSync
        '
        Me.btnSync.Location = New System.Drawing.Point(12, 76)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(150, 85)
        Me.btnSync.TabIndex = 0
        Me.btnSync.Text = "Sync"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'btnAsync
        '
        Me.btnAsync.Location = New System.Drawing.Point(12, 182)
        Me.btnAsync.Name = "btnAsync"
        Me.btnAsync.Size = New System.Drawing.Size(150, 85)
        Me.btnAsync.TabIndex = 1
        Me.btnAsync.Text = "Async"
        Me.btnAsync.UseVisualStyleBackColor = True
        '
        'btnAsyncWithValue
        '
        Me.btnAsyncWithValue.Location = New System.Drawing.Point(12, 290)
        Me.btnAsyncWithValue.Name = "btnAsyncWithValue"
        Me.btnAsyncWithValue.Size = New System.Drawing.Size(150, 85)
        Me.btnAsyncWithValue.TabIndex = 2
        Me.btnAsyncWithValue.Text = "Async with value"
        Me.btnAsyncWithValue.UseVisualStyleBackColor = True
        '
        'LbLog
        '
        Me.LbLog.AutoSize = True
        Me.LbLog.Location = New System.Drawing.Point(181, 50)
        Me.LbLog.Name = "LbLog"
        Me.LbLog.Size = New System.Drawing.Size(25, 13)
        Me.LbLog.TabIndex = 4
        Me.LbLog.Text = "Log"
        '
        'lbRegistro
        '
        Me.lbRegistro.FormattingEnabled = True
        Me.lbRegistro.Location = New System.Drawing.Point(184, 78)
        Me.lbRegistro.Name = "lbRegistro"
        Me.lbRegistro.Size = New System.Drawing.Size(309, 290)
        Me.lbRegistro.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 450)
        Me.Controls.Add(Me.lbRegistro)
        Me.Controls.Add(Me.LbLog)
        Me.Controls.Add(Me.btnAsyncWithValue)
        Me.Controls.Add(Me.btnAsync)
        Me.Controls.Add(Me.btnSync)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSync As Button
    Friend WithEvents btnAsync As Button
    Friend WithEvents btnAsyncWithValue As Button
    Friend WithEvents LbLog As Label
    Friend WithEvents lbRegistro As ListBox
End Class
