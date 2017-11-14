<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyScileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BluescalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NagativToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrigtnessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConvertToolStripMenuItem, Me.BrigtnessToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyScileToolStripMenuItem, Me.BlueScaleToolStripMenuItem, Me.BinaryToolStripMenuItem, Me.NagativToolStripMenuItem})
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ConvertToolStripMenuItem.Text = "convert"
        '
        'GreyScileToolStripMenuItem
        '
        Me.GreyScileToolStripMenuItem.Name = "GreyScileToolStripMenuItem"
        Me.GreyScileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreyScileToolStripMenuItem.Text = "greyscile"
        '
        'BlueScaleToolStripMenuItem
        '
        Me.BlueScaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedscaleToolStripMenuItem, Me.GreenscaleToolStripMenuItem, Me.BluescalToolStripMenuItem})
        Me.BlueScaleToolStripMenuItem.Name = "BlueScaleToolStripMenuItem"
        Me.BlueScaleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueScaleToolStripMenuItem.Text = "multi channel"
        '
        'RedscaleToolStripMenuItem
        '
        Me.RedscaleToolStripMenuItem.Name = "RedscaleToolStripMenuItem"
        Me.RedscaleToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.RedscaleToolStripMenuItem.Text = "redscale"
        '
        'GreenscaleToolStripMenuItem
        '
        Me.GreenscaleToolStripMenuItem.Name = "GreenscaleToolStripMenuItem"
        Me.GreenscaleToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.GreenscaleToolStripMenuItem.Text = "greenscale"
        '
        'BluescalToolStripMenuItem
        '
        Me.BluescalToolStripMenuItem.Name = "BluescalToolStripMenuItem"
        Me.BluescalToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BluescalToolStripMenuItem.Text = "bluescal"
        '
        'BinaryToolStripMenuItem
        '
        Me.BinaryToolStripMenuItem.Name = "BinaryToolStripMenuItem"
        Me.BinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BinaryToolStripMenuItem.Text = "binary"
        '
        'NagativToolStripMenuItem
        '
        Me.NagativToolStripMenuItem.Name = "NagativToolStripMenuItem"
        Me.NagativToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NagativToolStripMenuItem.Text = "nagativ"
        '
        'BrigtnessToolStripMenuItem
        '
        Me.BrigtnessToolStripMenuItem.Name = "BrigtnessToolStripMenuItem"
        Me.BrigtnessToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.BrigtnessToolStripMenuItem.Text = "brigtness"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(416, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 346)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(750, 478)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreyScileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BlueScaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedscaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenscaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BluescalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NagativToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrigtnessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
