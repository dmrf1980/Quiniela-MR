<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nudNumeros = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lbxApostados = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnSortear = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.lbxSorteados = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVaciarSorteados = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAciertos = New System.Windows.Forms.Label()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.rtxBoxAciertos = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.nudNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudNumeros
        '
        Me.nudNumeros.BackColor = System.Drawing.Color.LightGray
        Me.nudNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudNumeros.Location = New System.Drawing.Point(89, 146)
        Me.nudNumeros.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudNumeros.Name = "nudNumeros"
        Me.nudNumeros.Size = New System.Drawing.Size(69, 20)
        Me.nudNumeros.TabIndex = 0
        Me.nudNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.LightGray
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(187, 145)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lbxApostados
        '
        Me.lbxApostados.BackColor = System.Drawing.Color.LightGray
        Me.lbxApostados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxApostados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxApostados.FormattingEnabled = True
        Me.lbxApostados.Location = New System.Drawing.Point(40, 204)
        Me.lbxApostados.Name = "lbxApostados"
        Me.lbxApostados.Size = New System.Drawing.Size(118, 327)
        Me.lbxApostados.TabIndex = 2
        Me.lbxApostados.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "N° Apostados"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnX)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 35)
        Me.Panel1.TabIndex = 10
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.DarkGray
        Me.btnX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.Location = New System.Drawing.Point(526, 5)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(22, 23)
        Me.btnX.TabIndex = 0
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnSortear
        '
        Me.btnSortear.BackColor = System.Drawing.Color.LightGray
        Me.btnSortear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortear.Location = New System.Drawing.Point(428, 98)
        Me.btnSortear.Name = "btnSortear"
        Me.btnSortear.Size = New System.Drawing.Size(89, 53)
        Me.btnSortear.TabIndex = 6
        Me.btnSortear.Text = "Sortear"
        Me.btnSortear.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.LightGray
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(174, 156)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnVaciar
        '
        Me.btnVaciar.BackColor = System.Drawing.Color.LightGray
        Me.btnVaciar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVaciar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVaciar.Location = New System.Drawing.Point(174, 196)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 5
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = False
        '
        'lbxSorteados
        '
        Me.lbxSorteados.BackColor = System.Drawing.Color.LightGray
        Me.lbxSorteados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxSorteados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxSorteados.FormattingEnabled = True
        Me.lbxSorteados.Location = New System.Drawing.Point(285, 157)
        Me.lbxSorteados.Name = "lbxSorteados"
        Me.lbxSorteados.Size = New System.Drawing.Size(120, 327)
        Me.lbxSorteados.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(8, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 70)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "N°"
        '
        'btnVaciarSorteados
        '
        Me.btnVaciarSorteados.BackColor = System.Drawing.Color.LightGray
        Me.btnVaciarSorteados.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVaciarSorteados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVaciarSorteados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVaciarSorteados.Location = New System.Drawing.Point(442, 196)
        Me.btnVaciarSorteados.Name = "btnVaciarSorteados"
        Me.btnVaciarSorteados.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciarSorteados.TabIndex = 9
        Me.btnVaciarSorteados.Text = "Vaciar"
        Me.btnVaciarSorteados.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(442, 593)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "N° Sorteados"
        '
        'lblAciertos
        '
        Me.lblAciertos.AutoSize = True
        Me.lblAciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAciertos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblAciertos.Location = New System.Drawing.Point(28, 512)
        Me.lblAciertos.Name = "lblAciertos"
        Me.lblAciertos.Size = New System.Drawing.Size(101, 16)
        Me.lblAciertos.TabIndex = 10
        Me.lblAciertos.Text = "Hay Aciertos:"
        Me.lblAciertos.Visible = False
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiclo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblCiclo.Location = New System.Drawing.Point(138, 511)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(0, 20)
        Me.lblCiclo.TabIndex = 12
        '
        'rtxBoxAciertos
        '
        Me.rtxBoxAciertos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxBoxAciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxBoxAciertos.ForeColor = System.Drawing.Color.Red
        Me.rtxBoxAciertos.Location = New System.Drawing.Point(139, 536)
        Me.rtxBoxAciertos.Name = "rtxBoxAciertos"
        Me.rtxBoxAciertos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rtxBoxAciertos.Size = New System.Drawing.Size(266, 80)
        Me.rtxBoxAciertos.TabIndex = 13
        Me.rtxBoxAciertos.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rtxBoxAciertos)
        Me.Panel2.Controls.Add(Me.lblCiclo)
        Me.Panel2.Controls.Add(Me.lblAciertos)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnVaciarSorteados)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lbxSorteados)
        Me.Panel2.Controls.Add(Me.btnVaciar)
        Me.Panel2.Controls.Add(Me.btnQuitar)
        Me.Panel2.Controls.Add(Me.btnSortear)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 632)
        Me.Panel2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(556, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxApostados)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.nudNumeros)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiniela"
        CType(Me.nudNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudNumeros As NumericUpDown
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lbxApostados As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnX As Button
    Friend WithEvents btnSortear As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents lbxSorteados As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVaciarSorteados As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAciertos As Label
    Friend WithEvents lblCiclo As Label
    Friend WithEvents rtxBoxAciertos As RichTextBox
    Friend WithEvents Panel2 As Panel
End Class
