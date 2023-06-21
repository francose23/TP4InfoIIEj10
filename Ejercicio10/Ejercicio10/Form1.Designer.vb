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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgSalida = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgSalida2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.dgVector = New System.Windows.Forms.DataGridView()
        CType(Me.dgSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSalida2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ejecutar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgSalida
        '
        Me.dgSalida.AllowUserToAddRows = False
        Me.dgSalida.AllowUserToDeleteRows = False
        Me.dgSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSalida.ColumnHeadersVisible = False
        Me.dgSalida.Location = New System.Drawing.Point(39, 36)
        Me.dgSalida.Name = "dgSalida"
        Me.dgSalida.RowHeadersVisible = False
        Me.dgSalida.Size = New System.Drawing.Size(283, 157)
        Me.dgSalida.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dada la matriz:"
        '
        'dgSalida2
        '
        Me.dgSalida2.AllowUserToAddRows = False
        Me.dgSalida2.AllowUserToDeleteRows = False
        Me.dgSalida2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSalida2.ColumnHeadersVisible = False
        Me.dgSalida2.Location = New System.Drawing.Point(209, 271)
        Me.dgSalida2.Name = "dgSalida2"
        Me.dgSalida2.RowHeadersVisible = False
        Me.dgSalida2.Size = New System.Drawing.Size(163, 69)
        Me.dgSalida2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "a) Se obtuvo el vector:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "b) Matriz de 3X4 obtenida:"
        '
        'txtSalida
        '
        Me.txtSalida.Location = New System.Drawing.Point(147, 371)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(280, 20)
        Me.txtSalida.TabIndex = 8
        '
        'dgVector
        '
        Me.dgVector.AllowUserToAddRows = False
        Me.dgVector.AllowUserToDeleteRows = False
        Me.dgVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVector.ColumnHeadersVisible = False
        Me.dgVector.Location = New System.Drawing.Point(56, 245)
        Me.dgVector.Name = "dgVector"
        Me.dgVector.RowHeadersVisible = False
        Me.dgVector.Size = New System.Drawing.Size(43, 157)
        Me.dgVector.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 414)
        Me.Controls.Add(Me.dgVector)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgSalida2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgSalida)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSalida2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgSalida As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgSalida2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSalida As System.Windows.Forms.TextBox
    Friend WithEvents dgVector As System.Windows.Forms.DataGridView

End Class
