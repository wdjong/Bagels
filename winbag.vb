Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmWinBag
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
    Public WithEvents GD3_0 As System.Windows.Forms.TextBox
    Public WithEvents GD3_1 As System.Windows.Forms.TextBox
    Public WithEvents GD3_2 As System.Windows.Forms.TextBox
    Public WithEvents GD3_3 As System.Windows.Forms.TextBox
    Public WithEvents GD3_4 As System.Windows.Forms.TextBox
    Public WithEvents GD3_5 As System.Windows.Forms.TextBox
    Public WithEvents GD3_6 As System.Windows.Forms.TextBox
    Public WithEvents GD3_7 As System.Windows.Forms.TextBox
    Public WithEvents GD3_8 As System.Windows.Forms.TextBox
    Public WithEvents GD3_9 As System.Windows.Forms.TextBox
    Public WithEvents GD4_9 As System.Windows.Forms.TextBox
    Public WithEvents GD4_8 As System.Windows.Forms.TextBox
    Public WithEvents GD4_7 As System.Windows.Forms.TextBox
    Public WithEvents GD4_6 As System.Windows.Forms.TextBox
    Public WithEvents GD4_5 As System.Windows.Forms.TextBox
    Public WithEvents GD4_4 As System.Windows.Forms.TextBox
    Public WithEvents GD4_3 As System.Windows.Forms.TextBox
    Public WithEvents GD4_2 As System.Windows.Forms.TextBox
    Public WithEvents GD4_1 As System.Windows.Forms.TextBox
    Public WithEvents GD4_0 As System.Windows.Forms.TextBox
    Public WithEvents Cod4 As System.Windows.Forms.TextBox
    Public WithEvents Dig4 As System.Windows.Forms.ComboBox
    Public WithEvents Dig3 As System.Windows.Forms.ComboBox
    Public WithEvents Dig1 As System.Windows.Forms.ComboBox
    Public WithEvents Dig2 As System.Windows.Forms.ComboBox
    Public WithEvents Cod2 As System.Windows.Forms.TextBox
    Public WithEvents GD2_0 As System.Windows.Forms.TextBox
    Public WithEvents GD2_1 As System.Windows.Forms.TextBox
    Public WithEvents GD2_2 As System.Windows.Forms.TextBox
    Public WithEvents GD2_3 As System.Windows.Forms.TextBox
    Public WithEvents GD2_4 As System.Windows.Forms.TextBox
    Public WithEvents GD2_5 As System.Windows.Forms.TextBox
    Public WithEvents GD2_6 As System.Windows.Forms.TextBox
    Public WithEvents GD2_7 As System.Windows.Forms.TextBox
    Public WithEvents GD2_8 As System.Windows.Forms.TextBox
    Public WithEvents GD2_9 As System.Windows.Forms.TextBox
    Public WithEvents FD_9 As System.Windows.Forms.TextBox
    Public WithEvents FD_8 As System.Windows.Forms.TextBox
    Public WithEvents FD_7 As System.Windows.Forms.TextBox
    Public WithEvents FD_6 As System.Windows.Forms.TextBox
    Public WithEvents FD_5 As System.Windows.Forms.TextBox
    Public WithEvents FD_4 As System.Windows.Forms.TextBox
    Public WithEvents FD_3 As System.Windows.Forms.TextBox
    Public WithEvents FD_2 As System.Windows.Forms.TextBox
    Public WithEvents FD_1 As System.Windows.Forms.TextBox
    Public WithEvents FD_0 As System.Windows.Forms.TextBox
    Public WithEvents PD_9 As System.Windows.Forms.TextBox
    Public WithEvents PD_8 As System.Windows.Forms.TextBox
    Public WithEvents PD_7 As System.Windows.Forms.TextBox
    Public WithEvents PD_6 As System.Windows.Forms.TextBox
    Public WithEvents PD_5 As System.Windows.Forms.TextBox
    Public WithEvents PD_4 As System.Windows.Forms.TextBox
    Public WithEvents PD_3 As System.Windows.Forms.TextBox
    Public WithEvents PD_2 As System.Windows.Forms.TextBox
    Public WithEvents PD_1 As System.Windows.Forms.TextBox
    Public WithEvents PD_0 As System.Windows.Forms.TextBox
    Public WithEvents GD1_9 As System.Windows.Forms.TextBox
    Public WithEvents GD1_8 As System.Windows.Forms.TextBox
    Public WithEvents GD1_7 As System.Windows.Forms.TextBox
    Public WithEvents GD1_6 As System.Windows.Forms.TextBox
    Public WithEvents GD1_5 As System.Windows.Forms.TextBox
    Public WithEvents GD1_4 As System.Windows.Forms.TextBox
    Public WithEvents GD1_3 As System.Windows.Forms.TextBox
    Public WithEvents GD1_2 As System.Windows.Forms.TextBox
    Public WithEvents GD1_1 As System.Windows.Forms.TextBox
    Public WithEvents GD1_0 As System.Windows.Forms.TextBox
    Public WithEvents CmdMarkIt As System.Windows.Forms.Button
    Public WithEvents Cod1 As System.Windows.Forms.TextBox
    'Public WithEvents StatusBar1 As AxComctlLib.AxStatusBar
    Public WithEvents LblFermi As System.Windows.Forms.Label
    Public WithEvents LblPico As System.Windows.Forms.Label
    Public WithEvents FD As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents GD1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents GD2 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents GD3 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents GD4 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents PD As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents MnuFileNew As System.Windows.Forms.MenuItem
    Public WithEvents MnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents MnuFile As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelpAbout As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelp As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuEditPreferences As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuToolsClue As System.Windows.Forms.MenuItem
    Public WithEvents GD5_9 As System.Windows.Forms.TextBox
    Public WithEvents GD5_8 As System.Windows.Forms.TextBox
    Public WithEvents GD5_7 As System.Windows.Forms.TextBox
    Public WithEvents GD5_6 As System.Windows.Forms.TextBox
    Public WithEvents GD5_5 As System.Windows.Forms.TextBox
    Public WithEvents GD5_4 As System.Windows.Forms.TextBox
    Public WithEvents GD5_3 As System.Windows.Forms.TextBox
    Public WithEvents GD5_2 As System.Windows.Forms.TextBox
    Public WithEvents GD5_1 As System.Windows.Forms.TextBox
    Public WithEvents GD5_0 As System.Windows.Forms.TextBox
    Public WithEvents Cod5 As System.Windows.Forms.TextBox
    Public WithEvents Dig5 As System.Windows.Forms.ComboBox
    Public WithEvents GD5 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Friend WithEvents MnuToolsEnter As System.Windows.Forms.MenuItem
    Friend WithEvents MnuToolsGuess As MenuItem
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWinBag))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cod3 = New System.Windows.Forms.TextBox()
        Me.GD3_0 = New System.Windows.Forms.TextBox()
        Me.GD3_1 = New System.Windows.Forms.TextBox()
        Me.GD3_2 = New System.Windows.Forms.TextBox()
        Me.GD3_3 = New System.Windows.Forms.TextBox()
        Me.GD3_4 = New System.Windows.Forms.TextBox()
        Me.GD3_5 = New System.Windows.Forms.TextBox()
        Me.GD3_6 = New System.Windows.Forms.TextBox()
        Me.GD3_7 = New System.Windows.Forms.TextBox()
        Me.GD3_8 = New System.Windows.Forms.TextBox()
        Me.GD3_9 = New System.Windows.Forms.TextBox()
        Me.GD4_9 = New System.Windows.Forms.TextBox()
        Me.GD4_8 = New System.Windows.Forms.TextBox()
        Me.GD4_7 = New System.Windows.Forms.TextBox()
        Me.GD4_6 = New System.Windows.Forms.TextBox()
        Me.GD4_5 = New System.Windows.Forms.TextBox()
        Me.GD4_4 = New System.Windows.Forms.TextBox()
        Me.GD4_3 = New System.Windows.Forms.TextBox()
        Me.GD4_2 = New System.Windows.Forms.TextBox()
        Me.GD4_1 = New System.Windows.Forms.TextBox()
        Me.GD4_0 = New System.Windows.Forms.TextBox()
        Me.Cod4 = New System.Windows.Forms.TextBox()
        Me.Dig4 = New System.Windows.Forms.ComboBox()
        Me.Dig3 = New System.Windows.Forms.ComboBox()
        Me.Dig1 = New System.Windows.Forms.ComboBox()
        Me.Dig2 = New System.Windows.Forms.ComboBox()
        Me.Cod2 = New System.Windows.Forms.TextBox()
        Me.GD2_0 = New System.Windows.Forms.TextBox()
        Me.GD2_1 = New System.Windows.Forms.TextBox()
        Me.GD2_2 = New System.Windows.Forms.TextBox()
        Me.GD2_3 = New System.Windows.Forms.TextBox()
        Me.GD2_4 = New System.Windows.Forms.TextBox()
        Me.GD2_5 = New System.Windows.Forms.TextBox()
        Me.GD2_6 = New System.Windows.Forms.TextBox()
        Me.GD2_7 = New System.Windows.Forms.TextBox()
        Me.GD2_8 = New System.Windows.Forms.TextBox()
        Me.GD2_9 = New System.Windows.Forms.TextBox()
        Me.FD_9 = New System.Windows.Forms.TextBox()
        Me.FD_8 = New System.Windows.Forms.TextBox()
        Me.FD_7 = New System.Windows.Forms.TextBox()
        Me.FD_6 = New System.Windows.Forms.TextBox()
        Me.FD_5 = New System.Windows.Forms.TextBox()
        Me.FD_4 = New System.Windows.Forms.TextBox()
        Me.FD_3 = New System.Windows.Forms.TextBox()
        Me.FD_2 = New System.Windows.Forms.TextBox()
        Me.FD_1 = New System.Windows.Forms.TextBox()
        Me.FD_0 = New System.Windows.Forms.TextBox()
        Me.PD_9 = New System.Windows.Forms.TextBox()
        Me.PD_8 = New System.Windows.Forms.TextBox()
        Me.PD_7 = New System.Windows.Forms.TextBox()
        Me.PD_6 = New System.Windows.Forms.TextBox()
        Me.PD_5 = New System.Windows.Forms.TextBox()
        Me.PD_4 = New System.Windows.Forms.TextBox()
        Me.PD_3 = New System.Windows.Forms.TextBox()
        Me.PD_2 = New System.Windows.Forms.TextBox()
        Me.PD_1 = New System.Windows.Forms.TextBox()
        Me.PD_0 = New System.Windows.Forms.TextBox()
        Me.GD1_9 = New System.Windows.Forms.TextBox()
        Me.GD1_8 = New System.Windows.Forms.TextBox()
        Me.GD1_7 = New System.Windows.Forms.TextBox()
        Me.GD1_6 = New System.Windows.Forms.TextBox()
        Me.GD1_5 = New System.Windows.Forms.TextBox()
        Me.GD1_4 = New System.Windows.Forms.TextBox()
        Me.GD1_3 = New System.Windows.Forms.TextBox()
        Me.GD1_2 = New System.Windows.Forms.TextBox()
        Me.GD1_1 = New System.Windows.Forms.TextBox()
        Me.GD1_0 = New System.Windows.Forms.TextBox()
        Me.CmdMarkIt = New System.Windows.Forms.Button()
        Me.Cod1 = New System.Windows.Forms.TextBox()
        Me.LblFermi = New System.Windows.Forms.Label()
        Me.LblPico = New System.Windows.Forms.Label()
        Me.FD = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD2 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD3 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GD4 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.PD = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuFile = New System.Windows.Forms.MenuItem()
        Me.MnuFileNew = New System.Windows.Forms.MenuItem()
        Me.MnuFileExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MnuEditPreferences = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MnuToolsClue = New System.Windows.Forms.MenuItem()
        Me.MnuToolsEnter = New System.Windows.Forms.MenuItem()
        Me.MnuHelp = New System.Windows.Forms.MenuItem()
        Me.MnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.GD5_9 = New System.Windows.Forms.TextBox()
        Me.GD5_8 = New System.Windows.Forms.TextBox()
        Me.GD5_7 = New System.Windows.Forms.TextBox()
        Me.GD5_6 = New System.Windows.Forms.TextBox()
        Me.GD5_5 = New System.Windows.Forms.TextBox()
        Me.GD5_4 = New System.Windows.Forms.TextBox()
        Me.GD5_3 = New System.Windows.Forms.TextBox()
        Me.GD5_2 = New System.Windows.Forms.TextBox()
        Me.GD5_1 = New System.Windows.Forms.TextBox()
        Me.GD5_0 = New System.Windows.Forms.TextBox()
        Me.Cod5 = New System.Windows.Forms.TextBox()
        Me.Dig5 = New System.Windows.Forms.ComboBox()
        Me.GD5 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.MnuToolsGuess = New System.Windows.Forms.MenuItem()
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
        'GD3_0
        '
        Me.GD3_0.AcceptsReturn = True
        Me.GD3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_0, CType(0, Short))
        Me.GD3_0.Location = New System.Drawing.Point(93, 68)
        Me.GD3_0.MaxLength = 0
        Me.GD3_0.Name = "GD3_0"
        Me.GD3_0.ReadOnly = True
        Me.GD3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_0.Size = New System.Drawing.Size(17, 20)
        Me.GD3_0.TabIndex = 70
        Me.GD3_0.TabStop = False
        '
        'GD3_1
        '
        Me.GD3_1.AcceptsReturn = True
        Me.GD3_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_1, CType(1, Short))
        Me.GD3_1.Location = New System.Drawing.Point(93, 92)
        Me.GD3_1.MaxLength = 0
        Me.GD3_1.Name = "GD3_1"
        Me.GD3_1.ReadOnly = True
        Me.GD3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_1.Size = New System.Drawing.Size(17, 20)
        Me.GD3_1.TabIndex = 69
        Me.GD3_1.TabStop = False
        '
        'GD3_2
        '
        Me.GD3_2.AcceptsReturn = True
        Me.GD3_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_2, CType(2, Short))
        Me.GD3_2.Location = New System.Drawing.Point(93, 116)
        Me.GD3_2.MaxLength = 0
        Me.GD3_2.Name = "GD3_2"
        Me.GD3_2.ReadOnly = True
        Me.GD3_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_2.Size = New System.Drawing.Size(17, 20)
        Me.GD3_2.TabIndex = 68
        Me.GD3_2.TabStop = False
        '
        'GD3_3
        '
        Me.GD3_3.AcceptsReturn = True
        Me.GD3_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_3, CType(3, Short))
        Me.GD3_3.Location = New System.Drawing.Point(93, 140)
        Me.GD3_3.MaxLength = 0
        Me.GD3_3.Name = "GD3_3"
        Me.GD3_3.ReadOnly = True
        Me.GD3_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_3.Size = New System.Drawing.Size(17, 20)
        Me.GD3_3.TabIndex = 67
        Me.GD3_3.TabStop = False
        '
        'GD3_4
        '
        Me.GD3_4.AcceptsReturn = True
        Me.GD3_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_4, CType(4, Short))
        Me.GD3_4.Location = New System.Drawing.Point(93, 164)
        Me.GD3_4.MaxLength = 0
        Me.GD3_4.Name = "GD3_4"
        Me.GD3_4.ReadOnly = True
        Me.GD3_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_4.Size = New System.Drawing.Size(17, 20)
        Me.GD3_4.TabIndex = 66
        Me.GD3_4.TabStop = False
        '
        'GD3_5
        '
        Me.GD3_5.AcceptsReturn = True
        Me.GD3_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_5, CType(5, Short))
        Me.GD3_5.Location = New System.Drawing.Point(93, 188)
        Me.GD3_5.MaxLength = 0
        Me.GD3_5.Name = "GD3_5"
        Me.GD3_5.ReadOnly = True
        Me.GD3_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_5.Size = New System.Drawing.Size(17, 20)
        Me.GD3_5.TabIndex = 65
        Me.GD3_5.TabStop = False
        '
        'GD3_6
        '
        Me.GD3_6.AcceptsReturn = True
        Me.GD3_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_6, CType(6, Short))
        Me.GD3_6.Location = New System.Drawing.Point(93, 212)
        Me.GD3_6.MaxLength = 0
        Me.GD3_6.Name = "GD3_6"
        Me.GD3_6.ReadOnly = True
        Me.GD3_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_6.Size = New System.Drawing.Size(17, 20)
        Me.GD3_6.TabIndex = 64
        Me.GD3_6.TabStop = False
        '
        'GD3_7
        '
        Me.GD3_7.AcceptsReturn = True
        Me.GD3_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_7, CType(7, Short))
        Me.GD3_7.Location = New System.Drawing.Point(93, 236)
        Me.GD3_7.MaxLength = 0
        Me.GD3_7.Name = "GD3_7"
        Me.GD3_7.ReadOnly = True
        Me.GD3_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_7.Size = New System.Drawing.Size(17, 20)
        Me.GD3_7.TabIndex = 63
        Me.GD3_7.TabStop = False
        '
        'GD3_8
        '
        Me.GD3_8.AcceptsReturn = True
        Me.GD3_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_8, CType(8, Short))
        Me.GD3_8.Location = New System.Drawing.Point(93, 260)
        Me.GD3_8.MaxLength = 0
        Me.GD3_8.Name = "GD3_8"
        Me.GD3_8.ReadOnly = True
        Me.GD3_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_8.Size = New System.Drawing.Size(17, 20)
        Me.GD3_8.TabIndex = 62
        Me.GD3_8.TabStop = False
        '
        'GD3_9
        '
        Me.GD3_9.AcceptsReturn = True
        Me.GD3_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD3_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD3_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD3_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD3.SetIndex(Me.GD3_9, CType(9, Short))
        Me.GD3_9.Location = New System.Drawing.Point(93, 284)
        Me.GD3_9.MaxLength = 0
        Me.GD3_9.Name = "GD3_9"
        Me.GD3_9.ReadOnly = True
        Me.GD3_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD3_9.Size = New System.Drawing.Size(17, 20)
        Me.GD3_9.TabIndex = 61
        Me.GD3_9.TabStop = False
        '
        'GD4_9
        '
        Me.GD4_9.AcceptsReturn = True
        Me.GD4_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_9, CType(9, Short))
        Me.GD4_9.Location = New System.Drawing.Point(53, 284)
        Me.GD4_9.MaxLength = 0
        Me.GD4_9.Name = "GD4_9"
        Me.GD4_9.ReadOnly = True
        Me.GD4_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_9.Size = New System.Drawing.Size(17, 20)
        Me.GD4_9.TabIndex = 60
        Me.GD4_9.TabStop = False
        '
        'GD4_8
        '
        Me.GD4_8.AcceptsReturn = True
        Me.GD4_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_8, CType(8, Short))
        Me.GD4_8.Location = New System.Drawing.Point(53, 260)
        Me.GD4_8.MaxLength = 0
        Me.GD4_8.Name = "GD4_8"
        Me.GD4_8.ReadOnly = True
        Me.GD4_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_8.Size = New System.Drawing.Size(17, 20)
        Me.GD4_8.TabIndex = 59
        Me.GD4_8.TabStop = False
        '
        'GD4_7
        '
        Me.GD4_7.AcceptsReturn = True
        Me.GD4_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_7, CType(7, Short))
        Me.GD4_7.Location = New System.Drawing.Point(53, 236)
        Me.GD4_7.MaxLength = 0
        Me.GD4_7.Name = "GD4_7"
        Me.GD4_7.ReadOnly = True
        Me.GD4_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_7.Size = New System.Drawing.Size(17, 20)
        Me.GD4_7.TabIndex = 58
        Me.GD4_7.TabStop = False
        '
        'GD4_6
        '
        Me.GD4_6.AcceptsReturn = True
        Me.GD4_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_6, CType(6, Short))
        Me.GD4_6.Location = New System.Drawing.Point(53, 212)
        Me.GD4_6.MaxLength = 0
        Me.GD4_6.Name = "GD4_6"
        Me.GD4_6.ReadOnly = True
        Me.GD4_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_6.Size = New System.Drawing.Size(17, 20)
        Me.GD4_6.TabIndex = 57
        Me.GD4_6.TabStop = False
        '
        'GD4_5
        '
        Me.GD4_5.AcceptsReturn = True
        Me.GD4_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_5, CType(5, Short))
        Me.GD4_5.Location = New System.Drawing.Point(53, 188)
        Me.GD4_5.MaxLength = 0
        Me.GD4_5.Name = "GD4_5"
        Me.GD4_5.ReadOnly = True
        Me.GD4_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_5.Size = New System.Drawing.Size(17, 20)
        Me.GD4_5.TabIndex = 56
        Me.GD4_5.TabStop = False
        '
        'GD4_4
        '
        Me.GD4_4.AcceptsReturn = True
        Me.GD4_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_4, CType(4, Short))
        Me.GD4_4.Location = New System.Drawing.Point(53, 164)
        Me.GD4_4.MaxLength = 0
        Me.GD4_4.Name = "GD4_4"
        Me.GD4_4.ReadOnly = True
        Me.GD4_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_4.Size = New System.Drawing.Size(17, 20)
        Me.GD4_4.TabIndex = 55
        Me.GD4_4.TabStop = False
        '
        'GD4_3
        '
        Me.GD4_3.AcceptsReturn = True
        Me.GD4_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_3, CType(3, Short))
        Me.GD4_3.Location = New System.Drawing.Point(53, 140)
        Me.GD4_3.MaxLength = 0
        Me.GD4_3.Name = "GD4_3"
        Me.GD4_3.ReadOnly = True
        Me.GD4_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_3.Size = New System.Drawing.Size(17, 20)
        Me.GD4_3.TabIndex = 54
        Me.GD4_3.TabStop = False
        '
        'GD4_2
        '
        Me.GD4_2.AcceptsReturn = True
        Me.GD4_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_2, CType(2, Short))
        Me.GD4_2.Location = New System.Drawing.Point(53, 116)
        Me.GD4_2.MaxLength = 0
        Me.GD4_2.Name = "GD4_2"
        Me.GD4_2.ReadOnly = True
        Me.GD4_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_2.Size = New System.Drawing.Size(17, 20)
        Me.GD4_2.TabIndex = 53
        Me.GD4_2.TabStop = False
        '
        'GD4_1
        '
        Me.GD4_1.AcceptsReturn = True
        Me.GD4_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_1, CType(1, Short))
        Me.GD4_1.Location = New System.Drawing.Point(53, 92)
        Me.GD4_1.MaxLength = 0
        Me.GD4_1.Name = "GD4_1"
        Me.GD4_1.ReadOnly = True
        Me.GD4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_1.Size = New System.Drawing.Size(17, 20)
        Me.GD4_1.TabIndex = 52
        Me.GD4_1.TabStop = False
        '
        'GD4_0
        '
        Me.GD4_0.AcceptsReturn = True
        Me.GD4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD4_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD4_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD4_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD4.SetIndex(Me.GD4_0, CType(0, Short))
        Me.GD4_0.Location = New System.Drawing.Point(53, 68)
        Me.GD4_0.MaxLength = 0
        Me.GD4_0.Name = "GD4_0"
        Me.GD4_0.ReadOnly = True
        Me.GD4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD4_0.Size = New System.Drawing.Size(17, 20)
        Me.GD4_0.TabIndex = 51
        Me.GD4_0.TabStop = False
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
        'GD2_0
        '
        Me.GD2_0.AcceptsReturn = True
        Me.GD2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_0, CType(0, Short))
        Me.GD2_0.Location = New System.Drawing.Point(133, 68)
        Me.GD2_0.MaxLength = 0
        Me.GD2_0.Name = "GD2_0"
        Me.GD2_0.ReadOnly = True
        Me.GD2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_0.Size = New System.Drawing.Size(17, 20)
        Me.GD2_0.TabIndex = 46
        Me.GD2_0.TabStop = False
        '
        'GD2_1
        '
        Me.GD2_1.AcceptsReturn = True
        Me.GD2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_1, CType(1, Short))
        Me.GD2_1.Location = New System.Drawing.Point(133, 92)
        Me.GD2_1.MaxLength = 0
        Me.GD2_1.Name = "GD2_1"
        Me.GD2_1.ReadOnly = True
        Me.GD2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_1.Size = New System.Drawing.Size(17, 20)
        Me.GD2_1.TabIndex = 45
        Me.GD2_1.TabStop = False
        '
        'GD2_2
        '
        Me.GD2_2.AcceptsReturn = True
        Me.GD2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_2, CType(2, Short))
        Me.GD2_2.Location = New System.Drawing.Point(133, 116)
        Me.GD2_2.MaxLength = 0
        Me.GD2_2.Name = "GD2_2"
        Me.GD2_2.ReadOnly = True
        Me.GD2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_2.Size = New System.Drawing.Size(17, 20)
        Me.GD2_2.TabIndex = 44
        Me.GD2_2.TabStop = False
        '
        'GD2_3
        '
        Me.GD2_3.AcceptsReturn = True
        Me.GD2_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_3, CType(3, Short))
        Me.GD2_3.Location = New System.Drawing.Point(133, 140)
        Me.GD2_3.MaxLength = 0
        Me.GD2_3.Name = "GD2_3"
        Me.GD2_3.ReadOnly = True
        Me.GD2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_3.Size = New System.Drawing.Size(17, 20)
        Me.GD2_3.TabIndex = 43
        Me.GD2_3.TabStop = False
        '
        'GD2_4
        '
        Me.GD2_4.AcceptsReturn = True
        Me.GD2_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_4, CType(4, Short))
        Me.GD2_4.Location = New System.Drawing.Point(133, 164)
        Me.GD2_4.MaxLength = 0
        Me.GD2_4.Name = "GD2_4"
        Me.GD2_4.ReadOnly = True
        Me.GD2_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_4.Size = New System.Drawing.Size(17, 20)
        Me.GD2_4.TabIndex = 42
        Me.GD2_4.TabStop = False
        '
        'GD2_5
        '
        Me.GD2_5.AcceptsReturn = True
        Me.GD2_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_5, CType(5, Short))
        Me.GD2_5.Location = New System.Drawing.Point(133, 188)
        Me.GD2_5.MaxLength = 0
        Me.GD2_5.Name = "GD2_5"
        Me.GD2_5.ReadOnly = True
        Me.GD2_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_5.Size = New System.Drawing.Size(17, 20)
        Me.GD2_5.TabIndex = 41
        Me.GD2_5.TabStop = False
        '
        'GD2_6
        '
        Me.GD2_6.AcceptsReturn = True
        Me.GD2_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_6, CType(6, Short))
        Me.GD2_6.Location = New System.Drawing.Point(133, 212)
        Me.GD2_6.MaxLength = 0
        Me.GD2_6.Name = "GD2_6"
        Me.GD2_6.ReadOnly = True
        Me.GD2_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_6.Size = New System.Drawing.Size(17, 20)
        Me.GD2_6.TabIndex = 40
        Me.GD2_6.TabStop = False
        '
        'GD2_7
        '
        Me.GD2_7.AcceptsReturn = True
        Me.GD2_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_7, CType(7, Short))
        Me.GD2_7.Location = New System.Drawing.Point(133, 236)
        Me.GD2_7.MaxLength = 0
        Me.GD2_7.Name = "GD2_7"
        Me.GD2_7.ReadOnly = True
        Me.GD2_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_7.Size = New System.Drawing.Size(17, 20)
        Me.GD2_7.TabIndex = 39
        Me.GD2_7.TabStop = False
        '
        'GD2_8
        '
        Me.GD2_8.AcceptsReturn = True
        Me.GD2_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_8, CType(8, Short))
        Me.GD2_8.Location = New System.Drawing.Point(133, 260)
        Me.GD2_8.MaxLength = 0
        Me.GD2_8.Name = "GD2_8"
        Me.GD2_8.ReadOnly = True
        Me.GD2_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_8.Size = New System.Drawing.Size(17, 20)
        Me.GD2_8.TabIndex = 38
        Me.GD2_8.TabStop = False
        '
        'GD2_9
        '
        Me.GD2_9.AcceptsReturn = True
        Me.GD2_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD2_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD2_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD2_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD2.SetIndex(Me.GD2_9, CType(9, Short))
        Me.GD2_9.Location = New System.Drawing.Point(133, 284)
        Me.GD2_9.MaxLength = 0
        Me.GD2_9.Name = "GD2_9"
        Me.GD2_9.ReadOnly = True
        Me.GD2_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD2_9.Size = New System.Drawing.Size(17, 20)
        Me.GD2_9.TabIndex = 37
        Me.GD2_9.TabStop = False
        '
        'FD_9
        '
        Me.FD_9.AcceptsReturn = True
        Me.FD_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_9, CType(9, Short))
        Me.FD_9.Location = New System.Drawing.Point(253, 284)
        Me.FD_9.MaxLength = 0
        Me.FD_9.Name = "FD_9"
        Me.FD_9.ReadOnly = True
        Me.FD_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_9.Size = New System.Drawing.Size(17, 20)
        Me.FD_9.TabIndex = 35
        Me.FD_9.TabStop = False
        '
        'FD_8
        '
        Me.FD_8.AcceptsReturn = True
        Me.FD_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_8, CType(8, Short))
        Me.FD_8.Location = New System.Drawing.Point(253, 260)
        Me.FD_8.MaxLength = 0
        Me.FD_8.Name = "FD_8"
        Me.FD_8.ReadOnly = True
        Me.FD_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_8.Size = New System.Drawing.Size(17, 20)
        Me.FD_8.TabIndex = 34
        Me.FD_8.TabStop = False
        '
        'FD_7
        '
        Me.FD_7.AcceptsReturn = True
        Me.FD_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_7, CType(7, Short))
        Me.FD_7.Location = New System.Drawing.Point(253, 236)
        Me.FD_7.MaxLength = 0
        Me.FD_7.Name = "FD_7"
        Me.FD_7.ReadOnly = True
        Me.FD_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_7.Size = New System.Drawing.Size(17, 20)
        Me.FD_7.TabIndex = 33
        Me.FD_7.TabStop = False
        '
        'FD_6
        '
        Me.FD_6.AcceptsReturn = True
        Me.FD_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_6, CType(6, Short))
        Me.FD_6.Location = New System.Drawing.Point(253, 212)
        Me.FD_6.MaxLength = 0
        Me.FD_6.Name = "FD_6"
        Me.FD_6.ReadOnly = True
        Me.FD_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_6.Size = New System.Drawing.Size(17, 20)
        Me.FD_6.TabIndex = 32
        Me.FD_6.TabStop = False
        '
        'FD_5
        '
        Me.FD_5.AcceptsReturn = True
        Me.FD_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_5, CType(5, Short))
        Me.FD_5.Location = New System.Drawing.Point(253, 188)
        Me.FD_5.MaxLength = 0
        Me.FD_5.Name = "FD_5"
        Me.FD_5.ReadOnly = True
        Me.FD_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_5.Size = New System.Drawing.Size(17, 20)
        Me.FD_5.TabIndex = 31
        Me.FD_5.TabStop = False
        '
        'FD_4
        '
        Me.FD_4.AcceptsReturn = True
        Me.FD_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_4, CType(4, Short))
        Me.FD_4.Location = New System.Drawing.Point(253, 164)
        Me.FD_4.MaxLength = 0
        Me.FD_4.Name = "FD_4"
        Me.FD_4.ReadOnly = True
        Me.FD_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_4.Size = New System.Drawing.Size(17, 20)
        Me.FD_4.TabIndex = 30
        Me.FD_4.TabStop = False
        '
        'FD_3
        '
        Me.FD_3.AcceptsReturn = True
        Me.FD_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_3, CType(3, Short))
        Me.FD_3.Location = New System.Drawing.Point(253, 140)
        Me.FD_3.MaxLength = 0
        Me.FD_3.Name = "FD_3"
        Me.FD_3.ReadOnly = True
        Me.FD_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_3.Size = New System.Drawing.Size(17, 20)
        Me.FD_3.TabIndex = 29
        Me.FD_3.TabStop = False
        '
        'FD_2
        '
        Me.FD_2.AcceptsReturn = True
        Me.FD_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_2, CType(2, Short))
        Me.FD_2.Location = New System.Drawing.Point(253, 116)
        Me.FD_2.MaxLength = 0
        Me.FD_2.Name = "FD_2"
        Me.FD_2.ReadOnly = True
        Me.FD_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_2.Size = New System.Drawing.Size(17, 20)
        Me.FD_2.TabIndex = 28
        Me.FD_2.TabStop = False
        '
        'FD_1
        '
        Me.FD_1.AcceptsReturn = True
        Me.FD_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_1, CType(1, Short))
        Me.FD_1.Location = New System.Drawing.Point(253, 92)
        Me.FD_1.MaxLength = 0
        Me.FD_1.Name = "FD_1"
        Me.FD_1.ReadOnly = True
        Me.FD_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_1.Size = New System.Drawing.Size(17, 20)
        Me.FD_1.TabIndex = 27
        Me.FD_1.TabStop = False
        '
        'FD_0
        '
        Me.FD_0.AcceptsReturn = True
        Me.FD_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FD_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FD_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FD.SetIndex(Me.FD_0, CType(0, Short))
        Me.FD_0.Location = New System.Drawing.Point(253, 68)
        Me.FD_0.MaxLength = 0
        Me.FD_0.Name = "FD_0"
        Me.FD_0.ReadOnly = True
        Me.FD_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FD_0.Size = New System.Drawing.Size(17, 20)
        Me.FD_0.TabIndex = 26
        Me.FD_0.TabStop = False
        '
        'PD_9
        '
        Me.PD_9.AcceptsReturn = True
        Me.PD_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_9, CType(9, Short))
        Me.PD_9.Location = New System.Drawing.Point(213, 284)
        Me.PD_9.MaxLength = 0
        Me.PD_9.Name = "PD_9"
        Me.PD_9.ReadOnly = True
        Me.PD_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_9.Size = New System.Drawing.Size(17, 20)
        Me.PD_9.TabIndex = 25
        Me.PD_9.TabStop = False
        '
        'PD_8
        '
        Me.PD_8.AcceptsReturn = True
        Me.PD_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_8, CType(8, Short))
        Me.PD_8.Location = New System.Drawing.Point(213, 260)
        Me.PD_8.MaxLength = 0
        Me.PD_8.Name = "PD_8"
        Me.PD_8.ReadOnly = True
        Me.PD_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_8.Size = New System.Drawing.Size(17, 20)
        Me.PD_8.TabIndex = 24
        Me.PD_8.TabStop = False
        '
        'PD_7
        '
        Me.PD_7.AcceptsReturn = True
        Me.PD_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_7, CType(7, Short))
        Me.PD_7.Location = New System.Drawing.Point(213, 236)
        Me.PD_7.MaxLength = 0
        Me.PD_7.Name = "PD_7"
        Me.PD_7.ReadOnly = True
        Me.PD_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_7.Size = New System.Drawing.Size(17, 20)
        Me.PD_7.TabIndex = 23
        Me.PD_7.TabStop = False
        '
        'PD_6
        '
        Me.PD_6.AcceptsReturn = True
        Me.PD_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_6, CType(6, Short))
        Me.PD_6.Location = New System.Drawing.Point(213, 212)
        Me.PD_6.MaxLength = 0
        Me.PD_6.Name = "PD_6"
        Me.PD_6.ReadOnly = True
        Me.PD_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_6.Size = New System.Drawing.Size(17, 20)
        Me.PD_6.TabIndex = 22
        Me.PD_6.TabStop = False
        '
        'PD_5
        '
        Me.PD_5.AcceptsReturn = True
        Me.PD_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_5, CType(5, Short))
        Me.PD_5.Location = New System.Drawing.Point(213, 188)
        Me.PD_5.MaxLength = 0
        Me.PD_5.Name = "PD_5"
        Me.PD_5.ReadOnly = True
        Me.PD_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_5.Size = New System.Drawing.Size(17, 20)
        Me.PD_5.TabIndex = 21
        Me.PD_5.TabStop = False
        '
        'PD_4
        '
        Me.PD_4.AcceptsReturn = True
        Me.PD_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_4, CType(4, Short))
        Me.PD_4.Location = New System.Drawing.Point(213, 164)
        Me.PD_4.MaxLength = 0
        Me.PD_4.Name = "PD_4"
        Me.PD_4.ReadOnly = True
        Me.PD_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_4.Size = New System.Drawing.Size(17, 20)
        Me.PD_4.TabIndex = 20
        Me.PD_4.TabStop = False
        '
        'PD_3
        '
        Me.PD_3.AcceptsReturn = True
        Me.PD_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_3, CType(3, Short))
        Me.PD_3.Location = New System.Drawing.Point(213, 140)
        Me.PD_3.MaxLength = 0
        Me.PD_3.Name = "PD_3"
        Me.PD_3.ReadOnly = True
        Me.PD_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_3.Size = New System.Drawing.Size(17, 20)
        Me.PD_3.TabIndex = 19
        Me.PD_3.TabStop = False
        '
        'PD_2
        '
        Me.PD_2.AcceptsReturn = True
        Me.PD_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_2, CType(2, Short))
        Me.PD_2.Location = New System.Drawing.Point(213, 116)
        Me.PD_2.MaxLength = 0
        Me.PD_2.Name = "PD_2"
        Me.PD_2.ReadOnly = True
        Me.PD_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_2.Size = New System.Drawing.Size(17, 20)
        Me.PD_2.TabIndex = 18
        Me.PD_2.TabStop = False
        '
        'PD_1
        '
        Me.PD_1.AcceptsReturn = True
        Me.PD_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_1, CType(1, Short))
        Me.PD_1.Location = New System.Drawing.Point(213, 92)
        Me.PD_1.MaxLength = 0
        Me.PD_1.Name = "PD_1"
        Me.PD_1.ReadOnly = True
        Me.PD_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_1.Size = New System.Drawing.Size(17, 20)
        Me.PD_1.TabIndex = 17
        Me.PD_1.TabStop = False
        '
        'PD_0
        '
        Me.PD_0.AcceptsReturn = True
        Me.PD_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PD_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PD_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PD.SetIndex(Me.PD_0, CType(0, Short))
        Me.PD_0.Location = New System.Drawing.Point(213, 68)
        Me.PD_0.MaxLength = 0
        Me.PD_0.Name = "PD_0"
        Me.PD_0.ReadOnly = True
        Me.PD_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PD_0.Size = New System.Drawing.Size(17, 20)
        Me.PD_0.TabIndex = 16
        Me.PD_0.TabStop = False
        '
        'GD1_9
        '
        Me.GD1_9.AcceptsReturn = True
        Me.GD1_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_9, CType(9, Short))
        Me.GD1_9.Location = New System.Drawing.Point(173, 284)
        Me.GD1_9.MaxLength = 0
        Me.GD1_9.Name = "GD1_9"
        Me.GD1_9.ReadOnly = True
        Me.GD1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_9.Size = New System.Drawing.Size(17, 20)
        Me.GD1_9.TabIndex = 15
        Me.GD1_9.TabStop = False
        '
        'GD1_8
        '
        Me.GD1_8.AcceptsReturn = True
        Me.GD1_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_8, CType(8, Short))
        Me.GD1_8.Location = New System.Drawing.Point(173, 260)
        Me.GD1_8.MaxLength = 0
        Me.GD1_8.Name = "GD1_8"
        Me.GD1_8.ReadOnly = True
        Me.GD1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_8.Size = New System.Drawing.Size(17, 20)
        Me.GD1_8.TabIndex = 14
        Me.GD1_8.TabStop = False
        '
        'GD1_7
        '
        Me.GD1_7.AcceptsReturn = True
        Me.GD1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_7, CType(7, Short))
        Me.GD1_7.Location = New System.Drawing.Point(173, 236)
        Me.GD1_7.MaxLength = 0
        Me.GD1_7.Name = "GD1_7"
        Me.GD1_7.ReadOnly = True
        Me.GD1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_7.Size = New System.Drawing.Size(17, 20)
        Me.GD1_7.TabIndex = 13
        Me.GD1_7.TabStop = False
        '
        'GD1_6
        '
        Me.GD1_6.AcceptsReturn = True
        Me.GD1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_6, CType(6, Short))
        Me.GD1_6.Location = New System.Drawing.Point(173, 212)
        Me.GD1_6.MaxLength = 0
        Me.GD1_6.Name = "GD1_6"
        Me.GD1_6.ReadOnly = True
        Me.GD1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_6.Size = New System.Drawing.Size(17, 20)
        Me.GD1_6.TabIndex = 12
        Me.GD1_6.TabStop = False
        '
        'GD1_5
        '
        Me.GD1_5.AcceptsReturn = True
        Me.GD1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_5, CType(5, Short))
        Me.GD1_5.Location = New System.Drawing.Point(173, 188)
        Me.GD1_5.MaxLength = 0
        Me.GD1_5.Name = "GD1_5"
        Me.GD1_5.ReadOnly = True
        Me.GD1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_5.Size = New System.Drawing.Size(17, 20)
        Me.GD1_5.TabIndex = 11
        Me.GD1_5.TabStop = False
        '
        'GD1_4
        '
        Me.GD1_4.AcceptsReturn = True
        Me.GD1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_4, CType(4, Short))
        Me.GD1_4.Location = New System.Drawing.Point(173, 164)
        Me.GD1_4.MaxLength = 0
        Me.GD1_4.Name = "GD1_4"
        Me.GD1_4.ReadOnly = True
        Me.GD1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_4.Size = New System.Drawing.Size(17, 20)
        Me.GD1_4.TabIndex = 10
        Me.GD1_4.TabStop = False
        '
        'GD1_3
        '
        Me.GD1_3.AcceptsReturn = True
        Me.GD1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_3, CType(3, Short))
        Me.GD1_3.Location = New System.Drawing.Point(173, 140)
        Me.GD1_3.MaxLength = 0
        Me.GD1_3.Name = "GD1_3"
        Me.GD1_3.ReadOnly = True
        Me.GD1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_3.Size = New System.Drawing.Size(17, 20)
        Me.GD1_3.TabIndex = 9
        Me.GD1_3.TabStop = False
        '
        'GD1_2
        '
        Me.GD1_2.AcceptsReturn = True
        Me.GD1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_2, CType(2, Short))
        Me.GD1_2.Location = New System.Drawing.Point(173, 116)
        Me.GD1_2.MaxLength = 0
        Me.GD1_2.Name = "GD1_2"
        Me.GD1_2.ReadOnly = True
        Me.GD1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_2.Size = New System.Drawing.Size(17, 20)
        Me.GD1_2.TabIndex = 8
        Me.GD1_2.TabStop = False
        '
        'GD1_1
        '
        Me.GD1_1.AcceptsReturn = True
        Me.GD1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_1, CType(1, Short))
        Me.GD1_1.Location = New System.Drawing.Point(173, 92)
        Me.GD1_1.MaxLength = 0
        Me.GD1_1.Name = "GD1_1"
        Me.GD1_1.ReadOnly = True
        Me.GD1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_1.Size = New System.Drawing.Size(17, 20)
        Me.GD1_1.TabIndex = 7
        Me.GD1_1.TabStop = False
        '
        'GD1_0
        '
        Me.GD1_0.AcceptsReturn = True
        Me.GD1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD1.SetIndex(Me.GD1_0, CType(0, Short))
        Me.GD1_0.Location = New System.Drawing.Point(173, 68)
        Me.GD1_0.MaxLength = 0
        Me.GD1_0.Name = "GD1_0"
        Me.GD1_0.ReadOnly = True
        Me.GD1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD1_0.Size = New System.Drawing.Size(17, 20)
        Me.GD1_0.TabIndex = 6
        Me.GD1_0.TabStop = False
        '
        'CmdMarkIt
        '
        Me.CmdMarkIt.BackColor = System.Drawing.SystemColors.Control
        Me.CmdMarkIt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdMarkIt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMarkIt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdMarkIt.Location = New System.Drawing.Point(221, 332)
        Me.CmdMarkIt.Name = "CmdMarkIt"
        Me.CmdMarkIt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdMarkIt.Size = New System.Drawing.Size(49, 25)
        Me.CmdMarkIt.TabIndex = 6
        Me.CmdMarkIt.Text = "Mark it"
        Me.CmdMarkIt.UseVisualStyleBackColor = False
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
        'LblFermi
        '
        Me.LblFermi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblFermi.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFermi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFermi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFermi.Location = New System.Drawing.Point(245, 12)
        Me.LblFermi.Name = "LblFermi"
        Me.LblFermi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblFermi.Size = New System.Drawing.Size(32, 57)
        Me.LblFermi.TabIndex = 49
        Me.LblFermi.Text = "Right in right place"
        '
        'LblPico
        '
        Me.LblPico.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPico.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPico.Location = New System.Drawing.Point(205, 12)
        Me.LblPico.Name = "LblPico"
        Me.LblPico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPico.Size = New System.Drawing.Size(40, 57)
        Me.LblPico.TabIndex = 48
        Me.LblPico.Text = "Right but in wrong place"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFile, Me.MenuItem1, Me.MenuItem3, Me.MnuHelp})
        '
        'MnuFile
        '
        Me.MnuFile.Index = 0
        Me.MnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFileNew, Me.MnuFileExit})
        Me.MnuFile.Text = "&File"
        '
        'MnuFileNew
        '
        Me.MnuFileNew.Index = 0
        Me.MnuFileNew.Text = "&New"
        '
        'MnuFileExit
        '
        Me.MnuFileExit.Index = 1
        Me.MnuFileExit.Text = "E&xit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuEditPreferences})
        Me.MenuItem1.Text = "&Edit"
        '
        'MnuEditPreferences
        '
        Me.MnuEditPreferences.Index = 0
        Me.MnuEditPreferences.Text = "&Preferences"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuToolsClue, Me.MnuToolsGuess, Me.MnuToolsEnter})
        Me.MenuItem3.Text = "&Tools"
        '
        'MnuToolsClue
        '
        Me.MnuToolsClue.Index = 0
        Me.MnuToolsClue.Text = "&Clue"
        '
        'MnuToolsEnter
        '
        Me.MnuToolsEnter.Index = 2
        Me.MnuToolsEnter.Text = "&Enter Code"
        '
        'MnuHelp
        '
        Me.MnuHelp.Index = 3
        Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuHelpAbout})
        Me.MnuHelp.Text = "&Help"
        '
        'MnuHelpAbout
        '
        Me.MnuHelpAbout.Index = 0
        Me.MnuHelpAbout.Text = "&About"
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
        'GD5_9
        '
        Me.GD5_9.AcceptsReturn = True
        Me.GD5_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_9, CType(9, Short))
        Me.GD5_9.Location = New System.Drawing.Point(12, 284)
        Me.GD5_9.MaxLength = 0
        Me.GD5_9.Name = "GD5_9"
        Me.GD5_9.ReadOnly = True
        Me.GD5_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_9.Size = New System.Drawing.Size(17, 20)
        Me.GD5_9.TabIndex = 84
        Me.GD5_9.TabStop = False
        '
        'GD5_8
        '
        Me.GD5_8.AcceptsReturn = True
        Me.GD5_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_8, CType(8, Short))
        Me.GD5_8.Location = New System.Drawing.Point(12, 260)
        Me.GD5_8.MaxLength = 0
        Me.GD5_8.Name = "GD5_8"
        Me.GD5_8.ReadOnly = True
        Me.GD5_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_8.Size = New System.Drawing.Size(17, 20)
        Me.GD5_8.TabIndex = 83
        Me.GD5_8.TabStop = False
        '
        'GD5_7
        '
        Me.GD5_7.AcceptsReturn = True
        Me.GD5_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_7, CType(7, Short))
        Me.GD5_7.Location = New System.Drawing.Point(12, 236)
        Me.GD5_7.MaxLength = 0
        Me.GD5_7.Name = "GD5_7"
        Me.GD5_7.ReadOnly = True
        Me.GD5_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_7.Size = New System.Drawing.Size(17, 20)
        Me.GD5_7.TabIndex = 82
        Me.GD5_7.TabStop = False
        '
        'GD5_6
        '
        Me.GD5_6.AcceptsReturn = True
        Me.GD5_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_6, CType(6, Short))
        Me.GD5_6.Location = New System.Drawing.Point(12, 212)
        Me.GD5_6.MaxLength = 0
        Me.GD5_6.Name = "GD5_6"
        Me.GD5_6.ReadOnly = True
        Me.GD5_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_6.Size = New System.Drawing.Size(17, 20)
        Me.GD5_6.TabIndex = 81
        Me.GD5_6.TabStop = False
        '
        'GD5_5
        '
        Me.GD5_5.AcceptsReturn = True
        Me.GD5_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_5, CType(5, Short))
        Me.GD5_5.Location = New System.Drawing.Point(12, 188)
        Me.GD5_5.MaxLength = 0
        Me.GD5_5.Name = "GD5_5"
        Me.GD5_5.ReadOnly = True
        Me.GD5_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_5.Size = New System.Drawing.Size(17, 20)
        Me.GD5_5.TabIndex = 80
        Me.GD5_5.TabStop = False
        '
        'GD5_4
        '
        Me.GD5_4.AcceptsReturn = True
        Me.GD5_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_4, CType(4, Short))
        Me.GD5_4.Location = New System.Drawing.Point(12, 164)
        Me.GD5_4.MaxLength = 0
        Me.GD5_4.Name = "GD5_4"
        Me.GD5_4.ReadOnly = True
        Me.GD5_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_4.Size = New System.Drawing.Size(17, 20)
        Me.GD5_4.TabIndex = 79
        Me.GD5_4.TabStop = False
        '
        'GD5_3
        '
        Me.GD5_3.AcceptsReturn = True
        Me.GD5_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_3, CType(3, Short))
        Me.GD5_3.Location = New System.Drawing.Point(12, 140)
        Me.GD5_3.MaxLength = 0
        Me.GD5_3.Name = "GD5_3"
        Me.GD5_3.ReadOnly = True
        Me.GD5_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_3.Size = New System.Drawing.Size(17, 20)
        Me.GD5_3.TabIndex = 78
        Me.GD5_3.TabStop = False
        '
        'GD5_2
        '
        Me.GD5_2.AcceptsReturn = True
        Me.GD5_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_2, CType(2, Short))
        Me.GD5_2.Location = New System.Drawing.Point(12, 116)
        Me.GD5_2.MaxLength = 0
        Me.GD5_2.Name = "GD5_2"
        Me.GD5_2.ReadOnly = True
        Me.GD5_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_2.Size = New System.Drawing.Size(17, 20)
        Me.GD5_2.TabIndex = 77
        Me.GD5_2.TabStop = False
        '
        'GD5_1
        '
        Me.GD5_1.AcceptsReturn = True
        Me.GD5_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_1, CType(1, Short))
        Me.GD5_1.Location = New System.Drawing.Point(12, 92)
        Me.GD5_1.MaxLength = 0
        Me.GD5_1.Name = "GD5_1"
        Me.GD5_1.ReadOnly = True
        Me.GD5_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_1.Size = New System.Drawing.Size(17, 20)
        Me.GD5_1.TabIndex = 76
        Me.GD5_1.TabStop = False
        '
        'GD5_0
        '
        Me.GD5_0.AcceptsReturn = True
        Me.GD5_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GD5_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GD5_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GD5_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GD5.SetIndex(Me.GD5_0, CType(0, Short))
        Me.GD5_0.Location = New System.Drawing.Point(12, 68)
        Me.GD5_0.MaxLength = 0
        Me.GD5_0.Name = "GD5_0"
        Me.GD5_0.ReadOnly = True
        Me.GD5_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GD5_0.Size = New System.Drawing.Size(17, 20)
        Me.GD5_0.TabIndex = 75
        Me.GD5_0.TabStop = False
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
        'MnuToolsGuess
        '
        Me.MnuToolsGuess.Index = 1
        Me.MnuToolsGuess.Text = "Comp &Guess"
        '
        'FrmWinBag
        '
        Me.AcceptButton = Me.CmdMarkIt
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 403)
        Me.Controls.Add(Me.GD5_9)
        Me.Controls.Add(Me.GD5_8)
        Me.Controls.Add(Me.GD5_7)
        Me.Controls.Add(Me.GD5_6)
        Me.Controls.Add(Me.GD5_5)
        Me.Controls.Add(Me.GD5_4)
        Me.Controls.Add(Me.GD5_3)
        Me.Controls.Add(Me.GD5_2)
        Me.Controls.Add(Me.GD5_1)
        Me.Controls.Add(Me.GD5_0)
        Me.Controls.Add(Me.Cod5)
        Me.Controls.Add(Me.Dig5)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Cod3)
        Me.Controls.Add(Me.GD3_0)
        Me.Controls.Add(Me.GD3_1)
        Me.Controls.Add(Me.GD3_2)
        Me.Controls.Add(Me.GD3_3)
        Me.Controls.Add(Me.GD3_4)
        Me.Controls.Add(Me.GD3_5)
        Me.Controls.Add(Me.GD3_6)
        Me.Controls.Add(Me.GD3_7)
        Me.Controls.Add(Me.GD3_8)
        Me.Controls.Add(Me.GD3_9)
        Me.Controls.Add(Me.GD4_9)
        Me.Controls.Add(Me.GD4_8)
        Me.Controls.Add(Me.GD4_7)
        Me.Controls.Add(Me.GD4_6)
        Me.Controls.Add(Me.GD4_5)
        Me.Controls.Add(Me.GD4_4)
        Me.Controls.Add(Me.GD4_3)
        Me.Controls.Add(Me.GD4_2)
        Me.Controls.Add(Me.GD4_1)
        Me.Controls.Add(Me.GD4_0)
        Me.Controls.Add(Me.Cod4)
        Me.Controls.Add(Me.Dig4)
        Me.Controls.Add(Me.Dig3)
        Me.Controls.Add(Me.Dig1)
        Me.Controls.Add(Me.Dig2)
        Me.Controls.Add(Me.Cod2)
        Me.Controls.Add(Me.GD2_0)
        Me.Controls.Add(Me.GD2_1)
        Me.Controls.Add(Me.GD2_2)
        Me.Controls.Add(Me.GD2_3)
        Me.Controls.Add(Me.GD2_4)
        Me.Controls.Add(Me.GD2_5)
        Me.Controls.Add(Me.GD2_6)
        Me.Controls.Add(Me.GD2_7)
        Me.Controls.Add(Me.GD2_8)
        Me.Controls.Add(Me.GD2_9)
        Me.Controls.Add(Me.FD_9)
        Me.Controls.Add(Me.FD_8)
        Me.Controls.Add(Me.FD_7)
        Me.Controls.Add(Me.FD_6)
        Me.Controls.Add(Me.FD_5)
        Me.Controls.Add(Me.FD_4)
        Me.Controls.Add(Me.FD_3)
        Me.Controls.Add(Me.FD_2)
        Me.Controls.Add(Me.FD_1)
        Me.Controls.Add(Me.FD_0)
        Me.Controls.Add(Me.PD_9)
        Me.Controls.Add(Me.PD_8)
        Me.Controls.Add(Me.PD_7)
        Me.Controls.Add(Me.PD_6)
        Me.Controls.Add(Me.PD_5)
        Me.Controls.Add(Me.PD_4)
        Me.Controls.Add(Me.PD_3)
        Me.Controls.Add(Me.PD_2)
        Me.Controls.Add(Me.PD_1)
        Me.Controls.Add(Me.PD_0)
        Me.Controls.Add(Me.GD1_9)
        Me.Controls.Add(Me.GD1_8)
        Me.Controls.Add(Me.GD1_7)
        Me.Controls.Add(Me.GD1_6)
        Me.Controls.Add(Me.GD1_5)
        Me.Controls.Add(Me.GD1_4)
        Me.Controls.Add(Me.GD1_3)
        Me.Controls.Add(Me.GD1_2)
        Me.Controls.Add(Me.GD1_1)
        Me.Controls.Add(Me.GD1_0)
        Me.Controls.Add(Me.CmdMarkIt)
        Me.Controls.Add(Me.Cod1)
        Me.Controls.Add(Me.LblFermi)
        Me.Controls.Add(Me.LblPico)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(273, 76)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "FrmWinBag"
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
    Private Shared m_vb6FormDefInstance As FrmWinBag
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmWinBag
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmWinBag()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As FrmWinBag)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub CmdMarkIt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdMarkIt.Click
        MarkIt()
    End Sub

    Private Sub Dig1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig1.TextChanged
        SetBGround(Me.Dig1, Val(VB.Left(Me.Dig1.Text, 1)))
    End Sub

    Private Sub Dig1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig1.SelectedIndexChanged
        SetBGround(Me.Dig1, Val(VB.Left(Me.Dig1.Text, 1)))
    End Sub

    Private Sub Dig2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig2.TextChanged
        SetBGround(Me.Dig2, Val(VB.Left(Me.Dig2.Text, 1)))
    End Sub

    Private Sub Dig2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig2.SelectedIndexChanged
        SetBGround(Me.Dig2, Val(VB.Left(Me.Dig2.Text, 1)))
    End Sub

    Private Sub Dig3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig3.TextChanged
        SetBGround(Me.Dig3, Val(VB.Left(Me.Dig3.Text, 1)))
    End Sub

    Private Sub Dig3_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig3.SelectedIndexChanged
        SetBGround(Me.Dig3, Val(VB.Left(Me.Dig3.Text, 1)))
    End Sub

    Private Sub Dig4_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig4.TextChanged
        SetBGround(Me.Dig4, Val(VB.Left(Me.Dig4.Text, 1)))
    End Sub

    Private Sub Dig4_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig4.SelectedIndexChanged
        SetBGround(Me.Dig4, Val(VB.Left(Me.Dig4.Text, 1)))
    End Sub

    Private Sub Dig5_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig5.TextChanged
        SetBGround(Me.Dig5, Val(VB.Left(Me.Dig5.Text, 1)))
    End Sub

    Private Sub Dig5_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dig5.SelectedIndexChanged
        SetBGround(Me.Dig5, Val(VB.Left(Me.Dig5.Text, 1)))
    End Sub

    Private Sub FrmWinBag_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        SetFocus()
        SetStatus()
    End Sub

    Private Sub FrmWinBag_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub FrmWinBag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main_Renamed()
    End Sub

    Private Sub MnuEditPreferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEditPreferences.Click
        FrmWVProp.ShowDialog()
        Main_Renamed()
    End Sub

    Public Sub MnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuFileExit.Click
        End
    End Sub

    Public Sub MnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuFileNew.Click
        Main_Renamed()
    End Sub

    Public Sub MnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub MnuToolsClue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuToolsClue.Click
        'MsgBox("You could try: " & CGuess())
        ShowGuess(CGuess())
    End Sub

    Private Sub MnuToolsEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuToolsEnter.Click
        Dim aCode As String
        Dim iCode As Integer

        aCode = InputBox("Enter a code for someone to guess.", "Manual code", GetCode())
        If aCode <> "" Then
            iCode = Int(aCode) '  SetCode(CInt(aCode))
            If IsValidCode(iCode) Then
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

    Private Sub MnuToolsGuess_Click(sender As Object, e As EventArgs) Handles MnuToolsGuess.Click
        'MsgBox("You could try: " & CGuess())
        ShowGuess(CGuessRandom())
    End Sub
End Class