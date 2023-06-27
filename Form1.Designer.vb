<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Nama = New TextBox()
        Jabatan = New TextBox()
        LamaBekerja = New TextBox()
        GajiPokok = New TextBox()
        Tunjangan = New TextBox()
        Lembur = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Thr = New TextBox()
        Label11 = New Label()
        HitungGaji = New Button()
        TotalGaji = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jabatan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 2
        Label3.Text = "Lama Bekerja"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 3
        Label4.Text = "Gaji Pokok"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 4
        Label5.Text = "Tunjangan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 5
        Label6.Text = "Lembur"
        ' 
        ' Nama
        ' 
        Nama.Location = New Point(240, 26)
        Nama.Name = "Nama"
        Nama.Size = New Size(267, 27)
        Nama.TabIndex = 6
        ' 
        ' Jabatan
        ' 
        Jabatan.Location = New Point(240, 64)
        Jabatan.Name = "Jabatan"
        Jabatan.Size = New Size(267, 27)
        Jabatan.TabIndex = 7
        ' 
        ' LamaBekerja
        ' 
        LamaBekerja.Location = New Point(240, 99)
        LamaBekerja.Name = "LamaBekerja"
        LamaBekerja.Size = New Size(125, 27)
        LamaBekerja.TabIndex = 8
        ' 
        ' GajiPokok
        ' 
        GajiPokok.Location = New Point(240, 135)
        GajiPokok.Name = "GajiPokok"
        GajiPokok.Size = New Size(125, 27)
        GajiPokok.TabIndex = 9
        ' 
        ' Tunjangan
        ' 
        Tunjangan.Location = New Point(240, 173)
        Tunjangan.Name = "Tunjangan"
        Tunjangan.Size = New Size(125, 27)
        Tunjangan.TabIndex = 10
        ' 
        ' Lembur
        ' 
        Lembur.Location = New Point(240, 214)
        Lembur.Name = "Lembur"
        Lembur.Size = New Size(125, 27)
        Lembur.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(380, 102)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 20)
        Label7.TabIndex = 12
        Label7.Text = "Rp. 200.000 / Hari"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(380, 221)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 20)
        Label8.TabIndex = 13
        Label8.Text = "Rp. 20.000 / Jam"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(34, 306)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 20)
        Label9.TabIndex = 14
        Label9.Text = "Total Gaji"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(34, 259)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 20)
        Label10.TabIndex = 15
        Label10.Text = "THR"
        ' 
        ' Thr
        ' 
        Thr.Location = New Point(240, 252)
        Thr.Name = "Thr"
        Thr.Size = New Size(125, 27)
        Thr.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(380, 259)
        Label11.Name = "Label11"
        Label11.Size = New Size(150, 20)
        Label11.TabIndex = 17
        Label11.Text = "Hanya pada hari raya"
        ' 
        ' HitungGaji
        ' 
        HitungGaji.Location = New Point(240, 340)
        HitungGaji.Name = "HitungGaji"
        HitungGaji.Size = New Size(94, 29)
        HitungGaji.TabIndex = 18
        HitungGaji.Text = "Hitung!"
        HitungGaji.UseVisualStyleBackColor = True
        ' 
        ' TotalGaji
        ' 
        TotalGaji.Location = New Point(240, 299)
        TotalGaji.Name = "TotalGaji"
        TotalGaji.Size = New Size(125, 27)
        TotalGaji.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 397)
        Controls.Add(TotalGaji)
        Controls.Add(HitungGaji)
        Controls.Add(Label11)
        Controls.Add(Thr)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Lembur)
        Controls.Add(Tunjangan)
        Controls.Add(GajiPokok)
        Controls.Add(LamaBekerja)
        Controls.Add(Jabatan)
        Controls.Add(Nama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents Jabatan As TextBox
    Friend WithEvents LamaBekerja As TextBox
    Friend WithEvents GajiPokok As TextBox
    Friend WithEvents Tunjangan As TextBox
    Friend WithEvents Lembur As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Thr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents HitungGaji As Button
    Friend WithEvents TotalGaji As TextBox
End Class
