Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmWinBag
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
    End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Cod3 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_0 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_1 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_2 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_3 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_4 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_5 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_6 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_7 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_8 As System.Windows.Forms.TextBox
	Public WithEvents _GD3_9 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_9 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_8 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_7 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_6 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_5 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_4 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_3 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_2 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_1 As System.Windows.Forms.TextBox
	Public WithEvents _GD4_0 As System.Windows.Forms.TextBox
	Public WithEvents Cod4 As System.Windows.Forms.TextBox
	Public WithEvents Dig4 As System.Windows.Forms.ComboBox
	Public WithEvents Dig3 As System.Windows.Forms.ComboBox
	Public WithEvents Dig1 As System.Windows.Forms.ComboBox
	Public WithEvents Dig2 As System.Windows.Forms.ComboBox
	Public WithEvents Cod2 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_0 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_1 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_2 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_3 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_4 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_5 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_6 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_7 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_8 As System.Windows.Forms.TextBox
	Public WithEvents _GD2_9 As System.Windows.Forms.TextBox
	Public WithEvents _FD_9 As System.Windows.Forms.TextBox
	Public WithEvents _FD_8 As System.Windows.Forms.TextBox
	Public WithEvents _FD_7 As System.Windows.Forms.TextBox
	Public WithEvents _FD_6 As System.Windows.Forms.TextBox
	Public WithEvents _FD_5 As System.Windows.Forms.TextBox
	Public WithEvents _FD_4 As System.Windows.Forms.TextBox
	Public WithEvents _FD_3 As System.Windows.Forms.TextBox
	Public WithEvents _FD_2 As System.Windows.Forms.TextBox
	Public WithEvents _FD_1 As System.Windows.Forms.TextBox
	Public WithEvents _FD_0 As System.Windows.Forms.TextBox
	Public WithEvents _PD_9 As System.Windows.Forms.TextBox
	Public WithEvents _PD_8 As System.Windows.Forms.TextBox
	Public WithEvents _PD_7 As System.Windows.Forms.TextBox
	Public WithEvents _PD_6 As System.Windows.Forms.TextBox
	Public WithEvents _PD_5 As System.Windows.Forms.TextBox
	Public WithEvents _PD_4 As System.Windows.Forms.TextBox
	Public WithEvents _PD_3 As System.Windows.Forms.TextBox
	Public WithEvents _PD_2 As System.Windows.Forms.TextBox
	Public WithEvents _PD_1 As System.Windows.Forms.TextBox
	Public WithEvents _PD_0 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_9 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_8 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_7 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_6 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_5 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_4 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_3 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_2 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_1 As System.Windows.Forms.TextBox
	Public WithEvents _GD1_0 As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Cod1 As System.Windows.Forms.TextBox
    'Public WithEvents StatusBar1 As AxComctlLib.AxStatusBar
	Public WithEvents lblFermi As System.Windows.Forms.Label
	Public WithEvents lblPico As System.Windows.Forms.Label
	Public WithEvents FD As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents GD1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents GD2 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents GD3 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents GD4 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents PD As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents mnuFileNew As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Public WithEvents _GD5_9 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_8 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_7 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_6 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_5 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_4 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_3 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_2 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_1 As System.Windows.Forms.TextBox
    Public WithEvents _GD5_0 As System.Windows.Forms.TextBox
    Public WithEvents Cod5 As System.Windows.Forms.TextBox
    Public WithEvents Dig5 As System.Windows.Forms.ComboBox
    Public WithEvents GD5 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWinBag))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cod3 = New System.Windows.Forms.TextBox
        Me._GD3_0 = New System.Windows.Forms.TextBox
        Me._GD3_1 = New System.Windows.Forms.TextBox
        Me._GD3_2 = New System.Windows.Forms.TextBox
        Me._GD3_3 = New System.Windows.Forms.TextBox
        Me._GD3_4 = New System.Windows.Forms.TextBox
        Me._GD3_5 = New System.Windows.Forms.TextBox
        Me._GD3_6 = New System.Windows.Forms.TextBox
        Me._GD3_7 = New System.Windows.Forms.TextBox
        Me._GD3_8 = New System.Windows.Forms.TextBox
        Me._GD3_9 = New System.Windows.Forms.TextBox
        Me._GD4_9 = New System.Windows.Forms.TextBox
        Me._GD4_8 = New System.Windows.Forms.TextBox
        Me._GD4_7 = New System.Windows.Forms.TextBox
        Me._GD4_6 = New System.Windows.Forms.TextBox
        Me._GD4_5 = New System.Windows.Forms.TextBox
        Me._GD4_4 = New System.Windows.Forms.TextBox
        Me._GD4_3 = New System.Windows.Forms.TextBox
        Me._GD4_2 = New System.Windows.Forms.TextBox
        Me._GD4_1 = New System.Windows.Forms.TextBox
        Me._GD4_0 = New System.Windows.Forms.TextBox
        Me.Cod4 = New System.Windows.Forms.TextBox
        Me.Dig4 = New System.Windows.Forms.ComboBox
        Me.Dig3 = New System.Windows.Forms.ComboBox
        Me.Dig1 = New System.Windows.Forms.ComboBox
        Me.Dig2 = New System.Windows.Forms.ComboBox
        Me.Cod2 = New System.Windows.Forms.TextBox
        Me._GD2_0 = New System.Windows.Forms.TextBox
        Me._GD2_1 = New System.Windows.Forms.TextBox
        Me._GD2_2 = New System.Windows.Forms.TextBox
        Me._GD2_3 = New System.Windows.Forms.TextBox
        Me._GD2_4 = New System.Windows.Forms.TextBox
        Me._GD2_5 = New System.Windows.Forms.TextBox
        Me._GD2_6 = New System.Windows.Forms.TextBox
        Me._GD2_7 = New System.Windows.Forms.TextBox
        Me._GD2_8 = New System.Windows.Forms.TextBox
        Me._GD2_9 = New System.Windows.Forms.TextBox
        Me._FD_9 = New System.Windows.Forms.TextBox
        Me._FD_8 = New System.Windows.Forms.TextBox
        Me._FD_7 = New System.Windows.Forms.TextBox
        Me._FD_6 = New System.Windows.Forms.TextBox
        Me._FD_5 = New System.Windows.Forms.TextBox
        Me._FD_4 = New System.Windows.Forms.TextBox
        Me._FD_3 = New System.Windows.Forms.TextBox
        Me._FD_2 = New System.Windows.Forms.TextBox
        Me._FD_1 = New System.Windows.Forms.TextBox
        Me._FD_0 = New System.Windows.Forms.TextBox
        Me._PD_9 = New System.Windows.Forms.TextBox
        Me._PD_8 = New System.Windows.Forms.TextBox
        Me._PD_7 = New System.Windows.Forms.TextBox
        Me._PD_6 = New System.Windows.Forms.TextBox
        Me._PD_5 = New System.Windows.Forms.TextBox
        Me._PD_4 = New System.Windows.Forms.TextBox
        Me._PD_3 = New System.Windows.Forms.TextBox
        Me._PD_2 = New System.Windows.Forms.TextBox
        Me._PD_1 = New System.Windows.Forms.TextBox
        Me._PD_0 = New System.Windows.Forms.TextBox
        Me._GD1_9 = New System.Windows.Forms.TextBox
        Me._GD1_8 = New System.Windows.Forms.TextBox
        Me._GD1_7 = New System.Windows.Forms.TextBox
        Me._GD1_6 = New System.Windows.Forms.TextBox
        Me._GD1_5 = New System.Windows.Forms.TextBox
        Me._GD1_4 = New System.Windows.Forms.TextBox
        Me._GD1_3 = New System.Windows.Forms.TextBox
        Me._GD1_2 = New System.Windows.Forms.TextBox
        Me._GD1_1 = New System.Windows.Forms.TextBox
        Me._GD1_0 = New System.Windows.Forms.TextBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.Cod1 = New System.Windows.Forms.TextBox
        Me.lblFermi = New System.Windows.Forms.Label
        Me.lblPico = New System.Windows.Forms.Label
        Me.FD = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD2 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD3 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD4 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.PD = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileNew = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me._GD5_9 = New System.Windows.Forms.TextBox
        Me._GD5_8 = New System.Windows.Forms.TextBox
        Me._GD5_7 = New System.Windows.Forms.TextBox
        Me._GD5_6 = New System.Windows.Forms.TextBox
        Me._GD5_5 = New System.Windows.Forms.TextBox
        Me._GD5_4 = New System.Windows.Forms.TextBox
        Me._GD5_3 = New System.Windows.Forms.TextBox
        Me._GD5_2 = New System.Windows.Forms.TextBox
        Me._GD5_1 = New System.Windows.Forms.TextBox
        Me._GD5_0 = New System.Windows.Forms.TextBox
        Me.Cod5 = New System.Windows.Forms.TextBox
        Me.Dig5 = New System.Windows.Forms.ComboBox
        Me.GD5 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        CType(Me.FD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GD5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod3
        '
        Me.Cod3.AcceptsReturn = True
        Me.Cod3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cod3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cod3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cod3.Location = New System.Drawing.Point(93, 12)
        Me.Cod3.MaxLength = 0
        Me.Cod3.Name = "Cod3"
        Me.Cod3.ReadOnly = True
        Me.Cod3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cod3.Size = New System.Drawing.Size(17, 20)
        Me.Cod3.TabIndex = 71
        Me.Cod3.TabStop = False
        Me.Cod3.Visible = False
        '
        '_GD3_0
        '
        Me._GD3_0.AcceptsReturn = True
        Me._GD3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_0, CType(0, Short))
        Me._GD3_0.Location = New System.Drawing.Point(93, 68)
        Me._GD3_0.MaxLength = 0
        Me._GD3_0.Name = "_GD3_0"
        Me._GD3_0.ReadOnly = True
        Me._GD3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_0.Size = New System.Drawing.Size(17, 20)
        Me._GD3_0.TabIndex = 70
        Me._GD3_0.TabStop = False
        '
        '_GD3_1
        '
        Me._GD3_1.AcceptsReturn = True
        Me._GD3_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_1, CType(1, Short))
        Me._GD3_1.Location = New System.Drawing.Point(93, 92)
        Me._GD3_1.MaxLength = 0
        Me._GD3_1.Name = "_GD3_1"
        Me._GD3_1.ReadOnly = True
        Me._GD3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_1.Size = New System.Drawing.Size(17, 20)
        Me._GD3_1.TabIndex = 69
        Me._GD3_1.TabStop = False
        '
        '_GD3_2
        '
        Me._GD3_2.AcceptsReturn = True
        Me._GD3_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_2, CType(2, Short))
        Me._GD3_2.Location = New System.Drawing.Point(93, 116)
        Me._GD3_2.MaxLength = 0
        Me._GD3_2.Name = "_GD3_2"
        Me._GD3_2.ReadOnly = True
        Me._GD3_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_2.Size = New System.Drawing.Size(17, 20)
        Me._GD3_2.TabIndex = 68
        Me._GD3_2.TabStop = False
        '
        '_GD3_3
        '
        Me._GD3_3.AcceptsReturn = True
        Me._GD3_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_3, CType(3, Short))
        Me._GD3_3.Location = New System.Drawing.Point(93, 140)
        Me._GD3_3.MaxLength = 0
        Me._GD3_3.Name = "_GD3_3"
        Me._GD3_3.ReadOnly = True
        Me._GD3_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_3.Size = New System.Drawing.Size(17, 20)
        Me._GD3_3.TabIndex = 67
        Me._GD3_3.TabStop = False
        '
        '_GD3_4
        '
        Me._GD3_4.AcceptsReturn = True
        Me._GD3_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_4, CType(4, Short))
        Me._GD3_4.Location = New System.Drawing.Point(93, 164)
        Me._GD3_4.MaxLength = 0
        Me._GD3_4.Name = "_GD3_4"
        Me._GD3_4.ReadOnly = True
        Me._GD3_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_4.Size = New System.Drawing.Size(17, 20)
        Me._GD3_4.TabIndex = 66
        Me._GD3_4.TabStop = False
        '
        '_GD3_5
        '
        Me._GD3_5.AcceptsReturn = True
        Me._GD3_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_5, CType(5, Short))
        Me._GD3_5.Location = New System.Drawing.Point(93, 188)
        Me._GD3_5.MaxLength = 0
        Me._GD3_5.Name = "_GD3_5"
        Me._GD3_5.ReadOnly = True
        Me._GD3_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_5.Size = New System.Drawing.Size(17, 20)
        Me._GD3_5.TabIndex = 65
        Me._GD3_5.TabStop = False
        '
        '_GD3_6
        '
        Me._GD3_6.AcceptsReturn = True
        Me._GD3_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_6, CType(6, Short))
        Me._GD3_6.Location = New System.Drawing.Point(93, 212)
        Me._GD3_6.MaxLength = 0
        Me._GD3_6.Name = "_GD3_6"
        Me._GD3_6.ReadOnly = True
        Me._GD3_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_6.Size = New System.Drawing.Size(17, 20)
        Me._GD3_6.TabIndex = 64
        Me._GD3_6.TabStop = False
        '
        '_GD3_7
        '
        Me._GD3_7.AcceptsReturn = True
        Me._GD3_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_7, CType(7, Short))
        Me._GD3_7.Location = New System.Drawing.Point(93, 236)
        Me._GD3_7.MaxLength = 0
        Me._GD3_7.Name = "_GD3_7"
        Me._GD3_7.ReadOnly = True
        Me._GD3_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_7.Size = New System.Drawing.Size(17, 20)
        Me._GD3_7.TabIndex = 63
        Me._GD3_7.TabStop = False
        '
        '_GD3_8
        '
        Me._GD3_8.AcceptsReturn = True
        Me._GD3_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_8, CType(8, Short))
        Me._GD3_8.Location = New System.Drawing.Point(93, 260)
        Me._GD3_8.MaxLength = 0
        Me._GD3_8.Name = "_GD3_8"
        Me._GD3_8.ReadOnly = True
        Me._GD3_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_8.Size = New System.Drawing.Size(17, 20)
        Me._GD3_8.TabIndex = 62
        Me._GD3_8.TabStop = False
        '
        '_GD3_9
        '
        Me._GD3_9.AcceptsReturn = True
        Me._GD3_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD3_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD3_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD3_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me._GD3_9, CType(9, Short))
        Me._GD3_9.Location = New System.Drawing.Point(93, 284)
        Me._GD3_9.MaxLength = 0
        Me._GD3_9.Name = "_GD3_9"
        Me._GD3_9.ReadOnly = True
        Me._GD3_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD3_9.Size = New System.Drawing.Size(17, 20)
        Me._GD3_9.TabIndex = 61
        Me._GD3_9.TabStop = False
        '
        '_GD4_9
        '
        Me._GD4_9.AcceptsReturn = True
        Me._GD4_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_9, CType(9, Short))
        Me._GD4_9.Location = New System.Drawing.Point(53, 284)
        Me._GD4_9.MaxLength = 0
        Me._GD4_9.Name = "_GD4_9"
        Me._GD4_9.ReadOnly = True
        Me._GD4_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_9.Size = New System.Drawing.Size(17, 20)
        Me._GD4_9.TabIndex = 60
        Me._GD4_9.TabStop = False
        '
        '_GD4_8
        '
        Me._GD4_8.AcceptsReturn = True
        Me._GD4_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_8, CType(8, Short))
        Me._GD4_8.Location = New System.Drawing.Point(53, 260)
        Me._GD4_8.MaxLength = 0
        Me._GD4_8.Name = "_GD4_8"
        Me._GD4_8.ReadOnly = True
        Me._GD4_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_8.Size = New System.Drawing.Size(17, 20)
        Me._GD4_8.TabIndex = 59
        Me._GD4_8.TabStop = False
        '
        '_GD4_7
        '
        Me._GD4_7.AcceptsReturn = True
        Me._GD4_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_7, CType(7, Short))
        Me._GD4_7.Location = New System.Drawing.Point(53, 236)
        Me._GD4_7.MaxLength = 0
        Me._GD4_7.Name = "_GD4_7"
        Me._GD4_7.ReadOnly = True
        Me._GD4_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_7.Size = New System.Drawing.Size(17, 20)
        Me._GD4_7.TabIndex = 58
        Me._GD4_7.TabStop = False
        '
        '_GD4_6
        '
        Me._GD4_6.AcceptsReturn = True
        Me._GD4_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_6, CType(6, Short))
        Me._GD4_6.Location = New System.Drawing.Point(53, 212)
        Me._GD4_6.MaxLength = 0
        Me._GD4_6.Name = "_GD4_6"
        Me._GD4_6.ReadOnly = True
        Me._GD4_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_6.Size = New System.Drawing.Size(17, 20)
        Me._GD4_6.TabIndex = 57
        Me._GD4_6.TabStop = False
        '
        '_GD4_5
        '
        Me._GD4_5.AcceptsReturn = True
        Me._GD4_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_5, CType(5, Short))
        Me._GD4_5.Location = New System.Drawing.Point(53, 188)
        Me._GD4_5.MaxLength = 0
        Me._GD4_5.Name = "_GD4_5"
        Me._GD4_5.ReadOnly = True
        Me._GD4_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_5.Size = New System.Drawing.Size(17, 20)
        Me._GD4_5.TabIndex = 56
        Me._GD4_5.TabStop = False
        '
        '_GD4_4
        '
        Me._GD4_4.AcceptsReturn = True
        Me._GD4_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_4, CType(4, Short))
        Me._GD4_4.Location = New System.Drawing.Point(53, 164)
        Me._GD4_4.MaxLength = 0
        Me._GD4_4.Name = "_GD4_4"
        Me._GD4_4.ReadOnly = True
        Me._GD4_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_4.Size = New System.Drawing.Size(17, 20)
        Me._GD4_4.TabIndex = 55
        Me._GD4_4.TabStop = False
        '
        '_GD4_3
        '
        Me._GD4_3.AcceptsReturn = True
        Me._GD4_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_3, CType(3, Short))
        Me._GD4_3.Location = New System.Drawing.Point(53, 140)
        Me._GD4_3.MaxLength = 0
        Me._GD4_3.Name = "_GD4_3"
        Me._GD4_3.ReadOnly = True
        Me._GD4_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_3.Size = New System.Drawing.Size(17, 20)
        Me._GD4_3.TabIndex = 54
        Me._GD4_3.TabStop = False
        '
        '_GD4_2
        '
        Me._GD4_2.AcceptsReturn = True
        Me._GD4_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_2, CType(2, Short))
        Me._GD4_2.Location = New System.Drawing.Point(53, 116)
        Me._GD4_2.MaxLength = 0
        Me._GD4_2.Name = "_GD4_2"
        Me._GD4_2.ReadOnly = True
        Me._GD4_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_2.Size = New System.Drawing.Size(17, 20)
        Me._GD4_2.TabIndex = 53
        Me._GD4_2.TabStop = False
        '
        '_GD4_1
        '
        Me._GD4_1.AcceptsReturn = True
        Me._GD4_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_1, CType(1, Short))
        Me._GD4_1.Location = New System.Drawing.Point(53, 92)
        Me._GD4_1.MaxLength = 0
        Me._GD4_1.Name = "_GD4_1"
        Me._GD4_1.ReadOnly = True
        Me._GD4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_1.Size = New System.Drawing.Size(17, 20)
        Me._GD4_1.TabIndex = 52
        Me._GD4_1.TabStop = False
        '
        '_GD4_0
        '
        Me._GD4_0.AcceptsReturn = True
        Me._GD4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD4_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD4_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD4_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me._GD4_0, CType(0, Short))
        Me._GD4_0.Location = New System.Drawing.Point(53, 68)
        Me._GD4_0.MaxLength = 0
        Me._GD4_0.Name = "_GD4_0"
        Me._GD4_0.ReadOnly = True
        Me._GD4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD4_0.Size = New System.Drawing.Size(17, 20)
        Me._GD4_0.TabIndex = 51
        Me._GD4_0.TabStop = False
        '
        'Cod4
        '
        Me.Cod4.AcceptsReturn = True
        Me.Cod4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cod4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cod4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cod4.Location = New System.Drawing.Point(53, 12)
        Me.Cod4.MaxLength = 0
        Me.Cod4.Name = "Cod4"
        Me.Cod4.ReadOnly = True
        Me.Cod4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cod4.Size = New System.Drawing.Size(17, 20)
        Me.Cod4.TabIndex = 50
        Me.Cod4.TabStop = False
        Me.Cod4.Visible = False
        '
        'Dig4
        '
        Me.Dig4.BackColor = System.Drawing.SystemColors.Window
        Me.Dig4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dig4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dig4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dig4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Dig4.Location = New System.Drawing.Point(53, 332)
        Me.Dig4.Name = "Dig4"
        Me.Dig4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dig4.Size = New System.Drawing.Size(33, 22)
        Me.Dig4.TabIndex = 1
        '
        'Dig3
        '
        Me.Dig3.BackColor = System.Drawing.SystemColors.Window
        Me.Dig3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dig3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dig3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dig3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Dig3.Location = New System.Drawing.Point(93, 332)
        Me.Dig3.Name = "Dig3"
        Me.Dig3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dig3.Size = New System.Drawing.Size(33, 22)
        Me.Dig3.TabIndex = 2
        '
        'Dig1
        '
        Me.Dig1.BackColor = System.Drawing.SystemColors.Window
        Me.Dig1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dig1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dig1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dig1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Dig1.Location = New System.Drawing.Point(173, 332)
        Me.Dig1.Name = "Dig1"
        Me.Dig1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dig1.Size = New System.Drawing.Size(33, 22)
        Me.Dig1.TabIndex = 4
        '
        'Dig2
        '
        Me.Dig2.BackColor = System.Drawing.SystemColors.Window
        Me.Dig2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dig2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dig2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dig2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Dig2.Location = New System.Drawing.Point(133, 332)
        Me.Dig2.Name = "Dig2"
        Me.Dig2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dig2.Size = New System.Drawing.Size(33, 22)
        Me.Dig2.TabIndex = 3
        '
        'Cod2
        '
        Me.Cod2.AcceptsReturn = True
        Me.Cod2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cod2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cod2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cod2.Location = New System.Drawing.Point(133, 12)
        Me.Cod2.MaxLength = 0
        Me.Cod2.Name = "Cod2"
        Me.Cod2.ReadOnly = True
        Me.Cod2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cod2.Size = New System.Drawing.Size(17, 20)
        Me.Cod2.TabIndex = 47
        Me.Cod2.TabStop = False
        Me.Cod2.Visible = False
        '
        '_GD2_0
        '
        Me._GD2_0.AcceptsReturn = True
        Me._GD2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_0, CType(0, Short))
        Me._GD2_0.Location = New System.Drawing.Point(133, 68)
        Me._GD2_0.MaxLength = 0
        Me._GD2_0.Name = "_GD2_0"
        Me._GD2_0.ReadOnly = True
        Me._GD2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_0.Size = New System.Drawing.Size(17, 20)
        Me._GD2_0.TabIndex = 46
        Me._GD2_0.TabStop = False
        '
        '_GD2_1
        '
        Me._GD2_1.AcceptsReturn = True
        Me._GD2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_1, CType(1, Short))
        Me._GD2_1.Location = New System.Drawing.Point(133, 92)
        Me._GD2_1.MaxLength = 0
        Me._GD2_1.Name = "_GD2_1"
        Me._GD2_1.ReadOnly = True
        Me._GD2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_1.Size = New System.Drawing.Size(17, 20)
        Me._GD2_1.TabIndex = 45
        Me._GD2_1.TabStop = False
        '
        '_GD2_2
        '
        Me._GD2_2.AcceptsReturn = True
        Me._GD2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_2, CType(2, Short))
        Me._GD2_2.Location = New System.Drawing.Point(133, 116)
        Me._GD2_2.MaxLength = 0
        Me._GD2_2.Name = "_GD2_2"
        Me._GD2_2.ReadOnly = True
        Me._GD2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_2.Size = New System.Drawing.Size(17, 20)
        Me._GD2_2.TabIndex = 44
        Me._GD2_2.TabStop = False
        '
        '_GD2_3
        '
        Me._GD2_3.AcceptsReturn = True
        Me._GD2_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_3, CType(3, Short))
        Me._GD2_3.Location = New System.Drawing.Point(133, 140)
        Me._GD2_3.MaxLength = 0
        Me._GD2_3.Name = "_GD2_3"
        Me._GD2_3.ReadOnly = True
        Me._GD2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_3.Size = New System.Drawing.Size(17, 20)
        Me._GD2_3.TabIndex = 43
        Me._GD2_3.TabStop = False
        '
        '_GD2_4
        '
        Me._GD2_4.AcceptsReturn = True
        Me._GD2_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_4, CType(4, Short))
        Me._GD2_4.Location = New System.Drawing.Point(133, 164)
        Me._GD2_4.MaxLength = 0
        Me._GD2_4.Name = "_GD2_4"
        Me._GD2_4.ReadOnly = True
        Me._GD2_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_4.Size = New System.Drawing.Size(17, 20)
        Me._GD2_4.TabIndex = 42
        Me._GD2_4.TabStop = False
        '
        '_GD2_5
        '
        Me._GD2_5.AcceptsReturn = True
        Me._GD2_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_5, CType(5, Short))
        Me._GD2_5.Location = New System.Drawing.Point(133, 188)
        Me._GD2_5.MaxLength = 0
        Me._GD2_5.Name = "_GD2_5"
        Me._GD2_5.ReadOnly = True
        Me._GD2_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_5.Size = New System.Drawing.Size(17, 20)
        Me._GD2_5.TabIndex = 41
        Me._GD2_5.TabStop = False
        '
        '_GD2_6
        '
        Me._GD2_6.AcceptsReturn = True
        Me._GD2_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_6, CType(6, Short))
        Me._GD2_6.Location = New System.Drawing.Point(133, 212)
        Me._GD2_6.MaxLength = 0
        Me._GD2_6.Name = "_GD2_6"
        Me._GD2_6.ReadOnly = True
        Me._GD2_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_6.Size = New System.Drawing.Size(17, 20)
        Me._GD2_6.TabIndex = 40
        Me._GD2_6.TabStop = False
        '
        '_GD2_7
        '
        Me._GD2_7.AcceptsReturn = True
        Me._GD2_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_7, CType(7, Short))
        Me._GD2_7.Location = New System.Drawing.Point(133, 236)
        Me._GD2_7.MaxLength = 0
        Me._GD2_7.Name = "_GD2_7"
        Me._GD2_7.ReadOnly = True
        Me._GD2_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_7.Size = New System.Drawing.Size(17, 20)
        Me._GD2_7.TabIndex = 39
        Me._GD2_7.TabStop = False
        '
        '_GD2_8
        '
        Me._GD2_8.AcceptsReturn = True
        Me._GD2_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_8, CType(8, Short))
        Me._GD2_8.Location = New System.Drawing.Point(133, 260)
        Me._GD2_8.MaxLength = 0
        Me._GD2_8.Name = "_GD2_8"
        Me._GD2_8.ReadOnly = True
        Me._GD2_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_8.Size = New System.Drawing.Size(17, 20)
        Me._GD2_8.TabIndex = 38
        Me._GD2_8.TabStop = False
        '
        '_GD2_9
        '
        Me._GD2_9.AcceptsReturn = True
        Me._GD2_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD2_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD2_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD2_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me._GD2_9, CType(9, Short))
        Me._GD2_9.Location = New System.Drawing.Point(133, 284)
        Me._GD2_9.MaxLength = 0
        Me._GD2_9.Name = "_GD2_9"
        Me._GD2_9.ReadOnly = True
        Me._GD2_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD2_9.Size = New System.Drawing.Size(17, 20)
        Me._GD2_9.TabIndex = 37
        Me._GD2_9.TabStop = False
        '
        '_FD_9
        '
        Me._FD_9.AcceptsReturn = True
        Me._FD_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_9, CType(9, Short))
        Me._FD_9.Location = New System.Drawing.Point(253, 284)
        Me._FD_9.MaxLength = 0
        Me._FD_9.Name = "_FD_9"
        Me._FD_9.ReadOnly = True
        Me._FD_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_9.Size = New System.Drawing.Size(17, 20)
        Me._FD_9.TabIndex = 35
        Me._FD_9.TabStop = False
        '
        '_FD_8
        '
        Me._FD_8.AcceptsReturn = True
        Me._FD_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_8, CType(8, Short))
        Me._FD_8.Location = New System.Drawing.Point(253, 260)
        Me._FD_8.MaxLength = 0
        Me._FD_8.Name = "_FD_8"
        Me._FD_8.ReadOnly = True
        Me._FD_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_8.Size = New System.Drawing.Size(17, 20)
        Me._FD_8.TabIndex = 34
        Me._FD_8.TabStop = False
        '
        '_FD_7
        '
        Me._FD_7.AcceptsReturn = True
        Me._FD_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_7, CType(7, Short))
        Me._FD_7.Location = New System.Drawing.Point(253, 236)
        Me._FD_7.MaxLength = 0
        Me._FD_7.Name = "_FD_7"
        Me._FD_7.ReadOnly = True
        Me._FD_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_7.Size = New System.Drawing.Size(17, 20)
        Me._FD_7.TabIndex = 33
        Me._FD_7.TabStop = False
        '
        '_FD_6
        '
        Me._FD_6.AcceptsReturn = True
        Me._FD_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_6, CType(6, Short))
        Me._FD_6.Location = New System.Drawing.Point(253, 212)
        Me._FD_6.MaxLength = 0
        Me._FD_6.Name = "_FD_6"
        Me._FD_6.ReadOnly = True
        Me._FD_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_6.Size = New System.Drawing.Size(17, 20)
        Me._FD_6.TabIndex = 32
        Me._FD_6.TabStop = False
        '
        '_FD_5
        '
        Me._FD_5.AcceptsReturn = True
        Me._FD_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_5, CType(5, Short))
        Me._FD_5.Location = New System.Drawing.Point(253, 188)
        Me._FD_5.MaxLength = 0
        Me._FD_5.Name = "_FD_5"
        Me._FD_5.ReadOnly = True
        Me._FD_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_5.Size = New System.Drawing.Size(17, 20)
        Me._FD_5.TabIndex = 31
        Me._FD_5.TabStop = False
        '
        '_FD_4
        '
        Me._FD_4.AcceptsReturn = True
        Me._FD_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_4, CType(4, Short))
        Me._FD_4.Location = New System.Drawing.Point(253, 164)
        Me._FD_4.MaxLength = 0
        Me._FD_4.Name = "_FD_4"
        Me._FD_4.ReadOnly = True
        Me._FD_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_4.Size = New System.Drawing.Size(17, 20)
        Me._FD_4.TabIndex = 30
        Me._FD_4.TabStop = False
        '
        '_FD_3
        '
        Me._FD_3.AcceptsReturn = True
        Me._FD_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_3, CType(3, Short))
        Me._FD_3.Location = New System.Drawing.Point(253, 140)
        Me._FD_3.MaxLength = 0
        Me._FD_3.Name = "_FD_3"
        Me._FD_3.ReadOnly = True
        Me._FD_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_3.Size = New System.Drawing.Size(17, 20)
        Me._FD_3.TabIndex = 29
        Me._FD_3.TabStop = False
        '
        '_FD_2
        '
        Me._FD_2.AcceptsReturn = True
        Me._FD_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_2, CType(2, Short))
        Me._FD_2.Location = New System.Drawing.Point(253, 116)
        Me._FD_2.MaxLength = 0
        Me._FD_2.Name = "_FD_2"
        Me._FD_2.ReadOnly = True
        Me._FD_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_2.Size = New System.Drawing.Size(17, 20)
        Me._FD_2.TabIndex = 28
        Me._FD_2.TabStop = False
        '
        '_FD_1
        '
        Me._FD_1.AcceptsReturn = True
        Me._FD_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_1, CType(1, Short))
        Me._FD_1.Location = New System.Drawing.Point(253, 92)
        Me._FD_1.MaxLength = 0
        Me._FD_1.Name = "_FD_1"
        Me._FD_1.ReadOnly = True
        Me._FD_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_1.Size = New System.Drawing.Size(17, 20)
        Me._FD_1.TabIndex = 27
        Me._FD_1.TabStop = False
        '
        '_FD_0
        '
        Me._FD_0.AcceptsReturn = True
        Me._FD_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._FD_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._FD_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FD_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me._FD_0, CType(0, Short))
        Me._FD_0.Location = New System.Drawing.Point(253, 68)
        Me._FD_0.MaxLength = 0
        Me._FD_0.Name = "_FD_0"
        Me._FD_0.ReadOnly = True
        Me._FD_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FD_0.Size = New System.Drawing.Size(17, 20)
        Me._FD_0.TabIndex = 26
        Me._FD_0.TabStop = False
        '
        '_PD_9
        '
        Me._PD_9.AcceptsReturn = True
        Me._PD_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_9, CType(9, Short))
        Me._PD_9.Location = New System.Drawing.Point(213, 284)
        Me._PD_9.MaxLength = 0
        Me._PD_9.Name = "_PD_9"
        Me._PD_9.ReadOnly = True
        Me._PD_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_9.Size = New System.Drawing.Size(17, 20)
        Me._PD_9.TabIndex = 25
        Me._PD_9.TabStop = False
        '
        '_PD_8
        '
        Me._PD_8.AcceptsReturn = True
        Me._PD_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_8, CType(8, Short))
        Me._PD_8.Location = New System.Drawing.Point(213, 260)
        Me._PD_8.MaxLength = 0
        Me._PD_8.Name = "_PD_8"
        Me._PD_8.ReadOnly = True
        Me._PD_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_8.Size = New System.Drawing.Size(17, 20)
        Me._PD_8.TabIndex = 24
        Me._PD_8.TabStop = False
        '
        '_PD_7
        '
        Me._PD_7.AcceptsReturn = True
        Me._PD_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_7, CType(7, Short))
        Me._PD_7.Location = New System.Drawing.Point(213, 236)
        Me._PD_7.MaxLength = 0
        Me._PD_7.Name = "_PD_7"
        Me._PD_7.ReadOnly = True
        Me._PD_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_7.Size = New System.Drawing.Size(17, 20)
        Me._PD_7.TabIndex = 23
        Me._PD_7.TabStop = False
        '
        '_PD_6
        '
        Me._PD_6.AcceptsReturn = True
        Me._PD_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_6, CType(6, Short))
        Me._PD_6.Location = New System.Drawing.Point(213, 212)
        Me._PD_6.MaxLength = 0
        Me._PD_6.Name = "_PD_6"
        Me._PD_6.ReadOnly = True
        Me._PD_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_6.Size = New System.Drawing.Size(17, 20)
        Me._PD_6.TabIndex = 22
        Me._PD_6.TabStop = False
        '
        '_PD_5
        '
        Me._PD_5.AcceptsReturn = True
        Me._PD_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_5, CType(5, Short))
        Me._PD_5.Location = New System.Drawing.Point(213, 188)
        Me._PD_5.MaxLength = 0
        Me._PD_5.Name = "_PD_5"
        Me._PD_5.ReadOnly = True
        Me._PD_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_5.Size = New System.Drawing.Size(17, 20)
        Me._PD_5.TabIndex = 21
        Me._PD_5.TabStop = False
        '
        '_PD_4
        '
        Me._PD_4.AcceptsReturn = True
        Me._PD_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_4, CType(4, Short))
        Me._PD_4.Location = New System.Drawing.Point(213, 164)
        Me._PD_4.MaxLength = 0
        Me._PD_4.Name = "_PD_4"
        Me._PD_4.ReadOnly = True
        Me._PD_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_4.Size = New System.Drawing.Size(17, 20)
        Me._PD_4.TabIndex = 20
        Me._PD_4.TabStop = False
        '
        '_PD_3
        '
        Me._PD_3.AcceptsReturn = True
        Me._PD_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_3, CType(3, Short))
        Me._PD_3.Location = New System.Drawing.Point(213, 140)
        Me._PD_3.MaxLength = 0
        Me._PD_3.Name = "_PD_3"
        Me._PD_3.ReadOnly = True
        Me._PD_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_3.Size = New System.Drawing.Size(17, 20)
        Me._PD_3.TabIndex = 19
        Me._PD_3.TabStop = False
        '
        '_PD_2
        '
        Me._PD_2.AcceptsReturn = True
        Me._PD_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_2, CType(2, Short))
        Me._PD_2.Location = New System.Drawing.Point(213, 116)
        Me._PD_2.MaxLength = 0
        Me._PD_2.Name = "_PD_2"
        Me._PD_2.ReadOnly = True
        Me._PD_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_2.Size = New System.Drawing.Size(17, 20)
        Me._PD_2.TabIndex = 18
        Me._PD_2.TabStop = False
        '
        '_PD_1
        '
        Me._PD_1.AcceptsReturn = True
        Me._PD_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_1, CType(1, Short))
        Me._PD_1.Location = New System.Drawing.Point(213, 92)
        Me._PD_1.MaxLength = 0
        Me._PD_1.Name = "_PD_1"
        Me._PD_1.ReadOnly = True
        Me._PD_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_1.Size = New System.Drawing.Size(17, 20)
        Me._PD_1.TabIndex = 17
        Me._PD_1.TabStop = False
        '
        '_PD_0
        '
        Me._PD_0.AcceptsReturn = True
        Me._PD_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._PD_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._PD_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._PD_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me._PD_0, CType(0, Short))
        Me._PD_0.Location = New System.Drawing.Point(213, 68)
        Me._PD_0.MaxLength = 0
        Me._PD_0.Name = "_PD_0"
        Me._PD_0.ReadOnly = True
        Me._PD_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._PD_0.Size = New System.Drawing.Size(17, 20)
        Me._PD_0.TabIndex = 16
        Me._PD_0.TabStop = False
        '
        '_GD1_9
        '
        Me._GD1_9.AcceptsReturn = True
        Me._GD1_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_9, CType(9, Short))
        Me._GD1_9.Location = New System.Drawing.Point(173, 284)
        Me._GD1_9.MaxLength = 0
        Me._GD1_9.Name = "_GD1_9"
        Me._GD1_9.ReadOnly = True
        Me._GD1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_9.Size = New System.Drawing.Size(17, 20)
        Me._GD1_9.TabIndex = 15
        Me._GD1_9.TabStop = False
        '
        '_GD1_8
        '
        Me._GD1_8.AcceptsReturn = True
        Me._GD1_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_8, CType(8, Short))
        Me._GD1_8.Location = New System.Drawing.Point(173, 260)
        Me._GD1_8.MaxLength = 0
        Me._GD1_8.Name = "_GD1_8"
        Me._GD1_8.ReadOnly = True
        Me._GD1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_8.Size = New System.Drawing.Size(17, 20)
        Me._GD1_8.TabIndex = 14
        Me._GD1_8.TabStop = False
        '
        '_GD1_7
        '
        Me._GD1_7.AcceptsReturn = True
        Me._GD1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_7, CType(7, Short))
        Me._GD1_7.Location = New System.Drawing.Point(173, 236)
        Me._GD1_7.MaxLength = 0
        Me._GD1_7.Name = "_GD1_7"
        Me._GD1_7.ReadOnly = True
        Me._GD1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_7.Size = New System.Drawing.Size(17, 20)
        Me._GD1_7.TabIndex = 13
        Me._GD1_7.TabStop = False
        '
        '_GD1_6
        '
        Me._GD1_6.AcceptsReturn = True
        Me._GD1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_6, CType(6, Short))
        Me._GD1_6.Location = New System.Drawing.Point(173, 212)
        Me._GD1_6.MaxLength = 0
        Me._GD1_6.Name = "_GD1_6"
        Me._GD1_6.ReadOnly = True
        Me._GD1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_6.Size = New System.Drawing.Size(17, 20)
        Me._GD1_6.TabIndex = 12
        Me._GD1_6.TabStop = False
        '
        '_GD1_5
        '
        Me._GD1_5.AcceptsReturn = True
        Me._GD1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_5, CType(5, Short))
        Me._GD1_5.Location = New System.Drawing.Point(173, 188)
        Me._GD1_5.MaxLength = 0
        Me._GD1_5.Name = "_GD1_5"
        Me._GD1_5.ReadOnly = True
        Me._GD1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_5.Size = New System.Drawing.Size(17, 20)
        Me._GD1_5.TabIndex = 11
        Me._GD1_5.TabStop = False
        '
        '_GD1_4
        '
        Me._GD1_4.AcceptsReturn = True
        Me._GD1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_4, CType(4, Short))
        Me._GD1_4.Location = New System.Drawing.Point(173, 164)
        Me._GD1_4.MaxLength = 0
        Me._GD1_4.Name = "_GD1_4"
        Me._GD1_4.ReadOnly = True
        Me._GD1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_4.Size = New System.Drawing.Size(17, 20)
        Me._GD1_4.TabIndex = 10
        Me._GD1_4.TabStop = False
        '
        '_GD1_3
        '
        Me._GD1_3.AcceptsReturn = True
        Me._GD1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_3, CType(3, Short))
        Me._GD1_3.Location = New System.Drawing.Point(173, 140)
        Me._GD1_3.MaxLength = 0
        Me._GD1_3.Name = "_GD1_3"
        Me._GD1_3.ReadOnly = True
        Me._GD1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_3.Size = New System.Drawing.Size(17, 20)
        Me._GD1_3.TabIndex = 9
        Me._GD1_3.TabStop = False
        '
        '_GD1_2
        '
        Me._GD1_2.AcceptsReturn = True
        Me._GD1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_2, CType(2, Short))
        Me._GD1_2.Location = New System.Drawing.Point(173, 116)
        Me._GD1_2.MaxLength = 0
        Me._GD1_2.Name = "_GD1_2"
        Me._GD1_2.ReadOnly = True
        Me._GD1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_2.Size = New System.Drawing.Size(17, 20)
        Me._GD1_2.TabIndex = 8
        Me._GD1_2.TabStop = False
        '
        '_GD1_1
        '
        Me._GD1_1.AcceptsReturn = True
        Me._GD1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_1, CType(1, Short))
        Me._GD1_1.Location = New System.Drawing.Point(173, 92)
        Me._GD1_1.MaxLength = 0
        Me._GD1_1.Name = "_GD1_1"
        Me._GD1_1.ReadOnly = True
        Me._GD1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_1.Size = New System.Drawing.Size(17, 20)
        Me._GD1_1.TabIndex = 7
        Me._GD1_1.TabStop = False
        '
        '_GD1_0
        '
        Me._GD1_0.AcceptsReturn = True
        Me._GD1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me._GD1_0, CType(0, Short))
        Me._GD1_0.Location = New System.Drawing.Point(173, 68)
        Me._GD1_0.MaxLength = 0
        Me._GD1_0.Name = "_GD1_0"
        Me._GD1_0.ReadOnly = True
        Me._GD1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD1_0.Size = New System.Drawing.Size(17, 20)
        Me._GD1_0.TabIndex = 6
        Me._GD1_0.TabStop = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(221, 332)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(49, 25)
        Me.Command1.TabIndex = 6
        Me.Command1.Text = "Mark it"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Cod1
        '
        Me.Cod1.AcceptsReturn = True
        Me.Cod1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cod1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cod1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cod1.Location = New System.Drawing.Point(173, 12)
        Me.Cod1.MaxLength = 0
        Me.Cod1.Name = "Cod1"
        Me.Cod1.ReadOnly = True
        Me.Cod1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cod1.Size = New System.Drawing.Size(17, 20)
        Me.Cod1.TabIndex = 4
        Me.Cod1.TabStop = False
        Me.Cod1.Visible = False
        '
        'lblFermi
        '
        Me.lblFermi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFermi.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFermi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFermi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFermi.Location = New System.Drawing.Point(245, 12)
        Me.lblFermi.Name = "lblFermi"
        Me.lblFermi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFermi.Size = New System.Drawing.Size(32, 57)
        Me.lblFermi.TabIndex = 49
        Me.lblFermi.Text = "Right in right place"
        '
        'lblPico
        '
        Me.lblPico.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPico.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPico.Location = New System.Drawing.Point(205, 12)
        Me.lblPico.Name = "lblPico"
        Me.lblPico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPico.Size = New System.Drawing.Size(40, 57)
        Me.lblPico.TabIndex = 48
        Me.lblPico.Text = "Right but in wrong place"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.MenuItem1, Me.MenuItem3, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNew, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Index = 0
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 1
        Me.mnuFileExit.Text = "E&xit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&Edit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Preferences"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem3.Text = "&Tools"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&Clue"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "&Enter Code"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 0
        Me.mnuHelpAbout.Text = "&About"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 381)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(296, 22)
        Me.StatusBar1.TabIndex = 72
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        '
        '_GD5_9
        '
        Me._GD5_9.AcceptsReturn = True
        Me._GD5_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_9, CType(9, Short))
        Me._GD5_9.Location = New System.Drawing.Point(12, 284)
        Me._GD5_9.MaxLength = 0
        Me._GD5_9.Name = "_GD5_9"
        Me._GD5_9.ReadOnly = True
        Me._GD5_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_9.Size = New System.Drawing.Size(17, 20)
        Me._GD5_9.TabIndex = 84
        Me._GD5_9.TabStop = False
        '
        '_GD5_8
        '
        Me._GD5_8.AcceptsReturn = True
        Me._GD5_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_8, CType(8, Short))
        Me._GD5_8.Location = New System.Drawing.Point(12, 260)
        Me._GD5_8.MaxLength = 0
        Me._GD5_8.Name = "_GD5_8"
        Me._GD5_8.ReadOnly = True
        Me._GD5_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_8.Size = New System.Drawing.Size(17, 20)
        Me._GD5_8.TabIndex = 83
        Me._GD5_8.TabStop = False
        '
        '_GD5_7
        '
        Me._GD5_7.AcceptsReturn = True
        Me._GD5_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_7, CType(7, Short))
        Me._GD5_7.Location = New System.Drawing.Point(12, 236)
        Me._GD5_7.MaxLength = 0
        Me._GD5_7.Name = "_GD5_7"
        Me._GD5_7.ReadOnly = True
        Me._GD5_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_7.Size = New System.Drawing.Size(17, 20)
        Me._GD5_7.TabIndex = 82
        Me._GD5_7.TabStop = False
        '
        '_GD5_6
        '
        Me._GD5_6.AcceptsReturn = True
        Me._GD5_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_6, CType(6, Short))
        Me._GD5_6.Location = New System.Drawing.Point(12, 212)
        Me._GD5_6.MaxLength = 0
        Me._GD5_6.Name = "_GD5_6"
        Me._GD5_6.ReadOnly = True
        Me._GD5_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_6.Size = New System.Drawing.Size(17, 20)
        Me._GD5_6.TabIndex = 81
        Me._GD5_6.TabStop = False
        '
        '_GD5_5
        '
        Me._GD5_5.AcceptsReturn = True
        Me._GD5_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_5, CType(5, Short))
        Me._GD5_5.Location = New System.Drawing.Point(12, 188)
        Me._GD5_5.MaxLength = 0
        Me._GD5_5.Name = "_GD5_5"
        Me._GD5_5.ReadOnly = True
        Me._GD5_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_5.Size = New System.Drawing.Size(17, 20)
        Me._GD5_5.TabIndex = 80
        Me._GD5_5.TabStop = False
        '
        '_GD5_4
        '
        Me._GD5_4.AcceptsReturn = True
        Me._GD5_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_4, CType(4, Short))
        Me._GD5_4.Location = New System.Drawing.Point(12, 164)
        Me._GD5_4.MaxLength = 0
        Me._GD5_4.Name = "_GD5_4"
        Me._GD5_4.ReadOnly = True
        Me._GD5_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_4.Size = New System.Drawing.Size(17, 20)
        Me._GD5_4.TabIndex = 79
        Me._GD5_4.TabStop = False
        '
        '_GD5_3
        '
        Me._GD5_3.AcceptsReturn = True
        Me._GD5_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_3, CType(3, Short))
        Me._GD5_3.Location = New System.Drawing.Point(12, 140)
        Me._GD5_3.MaxLength = 0
        Me._GD5_3.Name = "_GD5_3"
        Me._GD5_3.ReadOnly = True
        Me._GD5_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_3.Size = New System.Drawing.Size(17, 20)
        Me._GD5_3.TabIndex = 78
        Me._GD5_3.TabStop = False
        '
        '_GD5_2
        '
        Me._GD5_2.AcceptsReturn = True
        Me._GD5_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_2, CType(2, Short))
        Me._GD5_2.Location = New System.Drawing.Point(12, 116)
        Me._GD5_2.MaxLength = 0
        Me._GD5_2.Name = "_GD5_2"
        Me._GD5_2.ReadOnly = True
        Me._GD5_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_2.Size = New System.Drawing.Size(17, 20)
        Me._GD5_2.TabIndex = 77
        Me._GD5_2.TabStop = False
        '
        '_GD5_1
        '
        Me._GD5_1.AcceptsReturn = True
        Me._GD5_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_1, CType(1, Short))
        Me._GD5_1.Location = New System.Drawing.Point(12, 92)
        Me._GD5_1.MaxLength = 0
        Me._GD5_1.Name = "_GD5_1"
        Me._GD5_1.ReadOnly = True
        Me._GD5_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_1.Size = New System.Drawing.Size(17, 20)
        Me._GD5_1.TabIndex = 76
        Me._GD5_1.TabStop = False
        '
        '_GD5_0
        '
        Me._GD5_0.AcceptsReturn = True
        Me._GD5_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._GD5_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._GD5_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._GD5_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me._GD5_0, CType(0, Short))
        Me._GD5_0.Location = New System.Drawing.Point(12, 68)
        Me._GD5_0.MaxLength = 0
        Me._GD5_0.Name = "_GD5_0"
        Me._GD5_0.ReadOnly = True
        Me._GD5_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._GD5_0.Size = New System.Drawing.Size(17, 20)
        Me._GD5_0.TabIndex = 75
        Me._GD5_0.TabStop = False
        '
        'Cod5
        '
        Me.Cod5.AcceptsReturn = True
        Me.Cod5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cod5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cod5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cod5.Location = New System.Drawing.Point(12, 12)
        Me.Cod5.MaxLength = 0
        Me.Cod5.Name = "Cod5"
        Me.Cod5.ReadOnly = True
        Me.Cod5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cod5.Size = New System.Drawing.Size(17, 20)
        Me.Cod5.TabIndex = 74
        Me.Cod5.TabStop = False
        Me.Cod5.Visible = False
        '
        'Dig5
        '
        Me.Dig5.BackColor = System.Drawing.SystemColors.Window
        Me.Dig5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dig5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dig5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dig5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.Dig5.Location = New System.Drawing.Point(12, 332)
        Me.Dig5.Name = "Dig5"
        Me.Dig5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dig5.Size = New System.Drawing.Size(33, 22)
        Me.Dig5.TabIndex = 0
        '
        'frmWinBag
        '
        Me.AcceptButton = Me.Command1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 403)
        Me.Controls.Add(Me._GD5_9)
        Me.Controls.Add(Me._GD5_8)
        Me.Controls.Add(Me._GD5_7)
        Me.Controls.Add(Me._GD5_6)
        Me.Controls.Add(Me._GD5_5)
        Me.Controls.Add(Me._GD5_4)
        Me.Controls.Add(Me._GD5_3)
        Me.Controls.Add(Me._GD5_2)
        Me.Controls.Add(Me._GD5_1)
        Me.Controls.Add(Me._GD5_0)
        Me.Controls.Add(Me.Cod5)
        Me.Controls.Add(Me.Dig5)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Cod3)
        Me.Controls.Add(Me._GD3_0)
        Me.Controls.Add(Me._GD3_1)
        Me.Controls.Add(Me._GD3_2)
        Me.Controls.Add(Me._GD3_3)
        Me.Controls.Add(Me._GD3_4)
        Me.Controls.Add(Me._GD3_5)
        Me.Controls.Add(Me._GD3_6)
        Me.Controls.Add(Me._GD3_7)
        Me.Controls.Add(Me._GD3_8)
        Me.Controls.Add(Me._GD3_9)
        Me.Controls.Add(Me._GD4_9)
        Me.Controls.Add(Me._GD4_8)
        Me.Controls.Add(Me._GD4_7)
        Me.Controls.Add(Me._GD4_6)
        Me.Controls.Add(Me._GD4_5)
        Me.Controls.Add(Me._GD4_4)
        Me.Controls.Add(Me._GD4_3)
        Me.Controls.Add(Me._GD4_2)
        Me.Controls.Add(Me._GD4_1)
        Me.Controls.Add(Me._GD4_0)
        Me.Controls.Add(Me.Cod4)
        Me.Controls.Add(Me.Dig4)
        Me.Controls.Add(Me.Dig3)
        Me.Controls.Add(Me.Dig1)
        Me.Controls.Add(Me.Dig2)
        Me.Controls.Add(Me.Cod2)
        Me.Controls.Add(Me._GD2_0)
        Me.Controls.Add(Me._GD2_1)
        Me.Controls.Add(Me._GD2_2)
        Me.Controls.Add(Me._GD2_3)
        Me.Controls.Add(Me._GD2_4)
        Me.Controls.Add(Me._GD2_5)
        Me.Controls.Add(Me._GD2_6)
        Me.Controls.Add(Me._GD2_7)
        Me.Controls.Add(Me._GD2_8)
        Me.Controls.Add(Me._GD2_9)
        Me.Controls.Add(Me._FD_9)
        Me.Controls.Add(Me._FD_8)
        Me.Controls.Add(Me._FD_7)
        Me.Controls.Add(Me._FD_6)
        Me.Controls.Add(Me._FD_5)
        Me.Controls.Add(Me._FD_4)
        Me.Controls.Add(Me._FD_3)
        Me.Controls.Add(Me._FD_2)
        Me.Controls.Add(Me._FD_1)
        Me.Controls.Add(Me._FD_0)
        Me.Controls.Add(Me._PD_9)
        Me.Controls.Add(Me._PD_8)
        Me.Controls.Add(Me._PD_7)
        Me.Controls.Add(Me._PD_6)
        Me.Controls.Add(Me._PD_5)
        Me.Controls.Add(Me._PD_4)
        Me.Controls.Add(Me._PD_3)
        Me.Controls.Add(Me._PD_2)
        Me.Controls.Add(Me._PD_1)
        Me.Controls.Add(Me._PD_0)
        Me.Controls.Add(Me._GD1_9)
        Me.Controls.Add(Me._GD1_8)
        Me.Controls.Add(Me._GD1_7)
        Me.Controls.Add(Me._GD1_6)
        Me.Controls.Add(Me._GD1_5)
        Me.Controls.Add(Me._GD1_4)
        Me.Controls.Add(Me._GD1_3)
        Me.Controls.Add(Me._GD1_2)
        Me.Controls.Add(Me._GD1_1)
        Me.Controls.Add(Me._GD1_0)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Cod1)
        Me.Controls.Add(Me.lblFermi)
        Me.Controls.Add(Me.lblPico)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(273, 76)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmWinBag"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "winBag"
        CType(Me.FD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GD5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As frmWinBag
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmWinBag
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmWinBag()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As frmWinBag)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        MarkIt()
    End Sub

    Private Sub dig1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig1.TextChanged
        setBGround(Me.Dig1, Val(VB.Left(Me.Dig1.Text, 1)))
    End Sub

    Private Sub dig1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig1.SelectedIndexChanged
        setBGround(Me.Dig1, Val(VB.Left(Me.Dig1.Text, 1)))
    End Sub

    Private Sub dig2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig2.TextChanged
        setBGround(Me.Dig2, Val(VB.Left(Me.Dig2.Text, 1)))
    End Sub

    Private Sub dig2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig2.SelectedIndexChanged
        setBGround(Me.Dig2, Val(VB.Left(Me.Dig2.Text, 1)))
    End Sub

    Private Sub dig3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig3.TextChanged
        setBGround(Me.Dig3, Val(VB.Left(Me.Dig3.Text, 1)))
    End Sub

    Private Sub dig3_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig3.SelectedIndexChanged
        setBGround(Me.Dig3, Val(VB.Left(Me.Dig3.Text, 1)))
    End Sub

    Private Sub dig4_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig4.TextChanged
        setBGround(Me.Dig4, Val(VB.Left(Me.Dig4.Text, 1)))
    End Sub

    Private Sub dig4_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig4.SelectedIndexChanged
        setBGround(Me.Dig4, Val(VB.Left(Me.Dig4.Text, 1)))
    End Sub

    Private Sub dig5_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig5.TextChanged
        setBGround(Me.Dig5, Val(VB.Left(Me.Dig5.Text, 1)))
    End Sub

    Private Sub dig5_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig5.SelectedIndexChanged
        setBGround(Me.Dig5, Val(VB.Left(Me.Dig5.Text, 1)))
    End Sub

    Private Sub frmWinBag_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        SetFocus()
        SetStatus()
    End Sub

    Private Sub frmWinBag_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        frmwbProp.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        MsgBox("You could try: " & CGuess())
    End Sub

    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Public Sub mnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileNew.Click
        Main_Renamed()
    End Sub

    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub frmWinBag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main_Renamed()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim aCode As String
        Dim iCode As Integer

        aCode = InputBox("Enter a code for someone to guess.", "Manual code", GetCode())
        If aCode <> "" Then
            iCode = Int(aCode) '  SetCode(CInt(aCode))
            If isValidCode(iCode) Then
                curGuess = 0
                ClearAll()
                SetCode(iCode)
            Else
                MsgBox("Code not changed. You should include " & My.Settings.Columns & " digits from 0 to " & My.Settings.Numbers)
            End If
        Else
            MsgBox("Code not changed. You should include " & My.Settings.Columns & " digits from 0 to " & My.Settings.Numbers)
        End If
    End Sub
End Class