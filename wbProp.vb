Option Strict Off
Option Explicit On
Friend Class FrmWVProp
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
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents CmdOK As System.Windows.Forms.Button
    'Public WithEvents Slider3 As AxComctlLib.AxSlider
    'Public WithEvents Slider2 As AxComctlLib.AxSlider
    'Public WithEvents Slider1 As AxComctlLib.AxSlider
    Public WithEvents LblGuess As System.Windows.Forms.Label
    Public WithEvents LblRange As System.Windows.Forms.Label
    Public WithEvents LblColumn As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents SldGuess As System.Windows.Forms.TrackBar
    Friend WithEvents SldRange As System.Windows.Forms.TrackBar
    Friend WithEvents LblColumnVal As Label
    Friend WithEvents LblRangeVal As Label
    Friend WithEvents LblGuessVal As Label
    Friend WithEvents lblProbability As Label
    Friend WithEvents txtProbability As TextBox
    Friend WithEvents SldColumn As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWVProp))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SldGuess = New System.Windows.Forms.TrackBar()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.LblGuess = New System.Windows.Forms.Label()
        Me.LblRange = New System.Windows.Forms.Label()
        Me.LblColumn = New System.Windows.Forms.Label()
        Me.SldRange = New System.Windows.Forms.TrackBar()
        Me.SldColumn = New System.Windows.Forms.TrackBar()
        Me.LblColumnVal = New System.Windows.Forms.Label()
        Me.LblRangeVal = New System.Windows.Forms.Label()
        Me.LblGuessVal = New System.Windows.Forms.Label()
        Me.lblProbability = New System.Windows.Forms.Label()
        Me.txtProbability = New System.Windows.Forms.TextBox()
        CType(Me.SldGuess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SldRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SldColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SldGuess
        '
        Me.SldGuess.Location = New System.Drawing.Point(5, 167)
        Me.SldGuess.Minimum = 1
        Me.SldGuess.Name = "SldGuess"
        Me.SldGuess.Size = New System.Drawing.Size(220, 45)
        Me.SldGuess.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.SldGuess, "1")
        Me.SldGuess.Value = 1
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Location = New System.Drawing.Point(164, 333)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancel.Size = New System.Drawing.Size(57, 25)
        Me.CmdCancel.TabIndex = 4
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOK.Location = New System.Drawing.Point(101, 333)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOK.Size = New System.Drawing.Size(57, 25)
        Me.CmdOK.TabIndex = 5
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'LblGuess
        '
        Me.LblGuess.BackColor = System.Drawing.SystemColors.Control
        Me.LblGuess.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblGuess.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuess.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblGuess.Location = New System.Drawing.Point(32, 139)
        Me.LblGuess.Name = "LblGuess"
        Me.LblGuess.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblGuess.Size = New System.Drawing.Size(201, 25)
        Me.LblGuess.TabIndex = 7
        Me.LblGuess.Text = "Number of guesses"
        '
        'LblRange
        '
        Me.LblRange.BackColor = System.Drawing.SystemColors.Control
        Me.LblRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblRange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblRange.Location = New System.Drawing.Point(32, 74)
        Me.LblRange.Name = "LblRange"
        Me.LblRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblRange.Size = New System.Drawing.Size(193, 25)
        Me.LblRange.TabIndex = 6
        Me.LblRange.Text = "Number or range of values"
        '
        'LblColumn
        '
        Me.LblColumn.BackColor = System.Drawing.SystemColors.Control
        Me.LblColumn.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblColumn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColumn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblColumn.Location = New System.Drawing.Point(32, 11)
        Me.LblColumn.Name = "LblColumn"
        Me.LblColumn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblColumn.Size = New System.Drawing.Size(185, 17)
        Me.LblColumn.TabIndex = 0
        Me.LblColumn.Text = "Number of columns or digits"
        '
        'SldRange
        '
        Me.SldRange.Location = New System.Drawing.Point(5, 91)
        Me.SldRange.Minimum = 1
        Me.SldRange.Name = "SldRange"
        Me.SldRange.Size = New System.Drawing.Size(220, 45)
        Me.SldRange.TabIndex = 77
        Me.SldRange.Value = 1
        '
        'SldColumn
        '
        Me.SldColumn.Location = New System.Drawing.Point(5, 31)
        Me.SldColumn.Maximum = 5
        Me.SldColumn.Minimum = 1
        Me.SldColumn.Name = "SldColumn"
        Me.SldColumn.Size = New System.Drawing.Size(220, 45)
        Me.SldColumn.TabIndex = 76
        Me.SldColumn.Value = 1
        '
        'LblColumnVal
        '
        Me.LblColumnVal.AutoSize = True
        Me.LblColumnVal.Location = New System.Drawing.Point(257, 31)
        Me.LblColumnVal.Name = "LblColumnVal"
        Me.LblColumnVal.Size = New System.Drawing.Size(0, 14)
        Me.LblColumnVal.TabIndex = 79
        '
        'LblRangeVal
        '
        Me.LblRangeVal.AutoSize = True
        Me.LblRangeVal.Location = New System.Drawing.Point(257, 91)
        Me.LblRangeVal.Name = "LblRangeVal"
        Me.LblRangeVal.Size = New System.Drawing.Size(0, 14)
        Me.LblRangeVal.TabIndex = 80
        '
        'LblGuessVal
        '
        Me.LblGuessVal.AutoSize = True
        Me.LblGuessVal.Location = New System.Drawing.Point(257, 167)
        Me.LblGuessVal.Name = "LblGuessVal"
        Me.LblGuessVal.Size = New System.Drawing.Size(0, 14)
        Me.LblGuessVal.TabIndex = 81
        '
        'lblProbability
        '
        Me.lblProbability.AutoSize = True
        Me.lblProbability.Location = New System.Drawing.Point(13, 219)
        Me.lblProbability.Name = "lblProbability"
        Me.lblProbability.Size = New System.Drawing.Size(69, 14)
        Me.lblProbability.TabIndex = 82
        Me.lblProbability.Text = "Permutations"
        '
        'txtProbability
        '
        Me.txtProbability.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProbability.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProbability.Location = New System.Drawing.Point(88, 216)
        Me.txtProbability.Name = "txtProbability"
        Me.txtProbability.ReadOnly = True
        Me.txtProbability.Size = New System.Drawing.Size(129, 20)
        Me.txtProbability.TabIndex = 83
        '
        'FrmWVProp
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(329, 378)
        Me.Controls.Add(Me.txtProbability)
        Me.Controls.Add(Me.lblProbability)
        Me.Controls.Add(Me.LblGuessVal)
        Me.Controls.Add(Me.LblRangeVal)
        Me.Controls.Add(Me.LblColumnVal)
        Me.Controls.Add(Me.SldGuess)
        Me.Controls.Add(Me.SldRange)
        Me.Controls.Add(Me.SldColumn)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.LblGuess)
        Me.Controls.Add(Me.LblRange)
        Me.Controls.Add(Me.LblColumn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(388, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWVProp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Preferences"
        CType(Me.SldGuess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SldRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SldColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmWVProp
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmWVProp
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmWVProp()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As FrmWVProp)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Cancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        My.Settings.Columns = SldColumn.Value
        My.Settings.Numbers = SldRange.Value
        My.Settings.Guesses = SldGuess.Value
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub FrmwbProp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            SldColumn.Value = My.Settings.Columns
            SldRange.Value = My.Settings.Numbers
            SldGuess.Value = My.Settings.Guesses
            txtProbability.Text = SldRange.Value ^ SldColumn.Value
        Catch ex As Exception
            MsgBox("frmWBProp_Load: " & ex.Message)
        End Try
    End Sub

    Private Sub SldColumn_ValueChanged(sender As Object, e As EventArgs) Handles SldColumn.ValueChanged
        LblColumnVal.Text = SldColumn.Value
        txtProbability.Text = SldRange.Value ^ SldColumn.Value
    End Sub

    Private Sub SldRange_ValueChanged(sender As Object, e As EventArgs) Handles SldRange.ValueChanged
        LblRangeVal.Text = "0 - " & SldRange.Value - 1
        txtProbability.Text = SldRange.Value ^ SldColumn.Value
    End Sub

    Private Sub SldGuess_ValueChanged(sender As Object, e As EventArgs) Handles SldGuess.ValueChanged
        LblGuessVal.Text = SldGuess.Value
    End Sub

End Class