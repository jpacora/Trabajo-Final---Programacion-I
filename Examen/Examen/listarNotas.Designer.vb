<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarNotas
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
        Me.components = New System.ComponentModel.Container()
        Me.dtgv_notas = New System.Windows.Forms.DataGridView()
        Me.IngresarNotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtgv_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresarNotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_notas
        '
        Me.dtgv_notas.AllowUserToAddRows = False
        Me.dtgv_notas.AllowUserToDeleteRows = False
        Me.dtgv_notas.AllowUserToOrderColumns = True
        Me.dtgv_notas.AllowUserToResizeColumns = False
        Me.dtgv_notas.AllowUserToResizeRows = False
        Me.dtgv_notas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_notas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_notas.Location = New System.Drawing.Point(-2, -1)
        Me.dtgv_notas.Name = "dtgv_notas"
        Me.dtgv_notas.Size = New System.Drawing.Size(787, 447)
        Me.dtgv_notas.TabIndex = 0
        '
        'IngresarNotasBindingSource
        '
        Me.IngresarNotasBindingSource.DataSource = GetType(ProyectoFinal.ingresarNotas)
        '
        'listarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 444)
        Me.Controls.Add(Me.dtgv_notas)
        Me.Name = "listarNotas"
        Me.Text = "Notas"
        CType(Me.dtgv_notas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresarNotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgv_notas As System.Windows.Forms.DataGridView
    Friend WithEvents IngresarNotasBindingSource As System.Windows.Forms.BindingSource
End Class
