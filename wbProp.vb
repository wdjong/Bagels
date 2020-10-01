Option Strict Off
Option Explicit On
Friend Class FrmwbProp
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
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    'Public WithEvents Slider3 As AxComctlLib.AxSlider
    'Public WithEvents Slider2 As AxComctlLib.AxSlider
    'Public WithEvents Slider1 As AxComctlLib.AxSlider
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Slider3 As System.Windows.Forms.TrackBar
    Friend WithEvents Slider2 As System.Windows.Forms.TrackBar
    Friend WithEvents Slider1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmwbProp))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Slider3 = New System.Windows.Forms.TrackBar
        Me.Cancel = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Slider2 = New System.Windows.Forms.TrackBar
        Me.Slider1 = New System.Windows.Forms.TrackBar
        CType(Me.Slider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Slider3
        '
        Me.Slider3.Location = New System.Drawing.Point(5, 258)
        Me.Slider3.Minimum = 1
        Me.Slider3.Name = "Slider3"
        Me.Slider3.Size = New System.Drawing.Size(212, 45)
        Me.Slider3.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Slider3, "1")
        Me.Slider3.Value = 1
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancel.Location = New System.Drawing.Point(164, 333)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancel.Size = New System.Drawing.Size(57, 25)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(101, 333)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(57, 25)
        Me.Command1.TabIndex = 5
        Me.Command1.Text = "OK"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of guesses"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(193, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number or range of values"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(185, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of columns or digits"
        '
        'Slider2
        '
        Me.Slider2.Location = New System.Drawing.Point(5, 153)
        Me.Slider2.Minimum = 1
        Me.Slider2.Name = "Slider2"
        Me.Slider2.Size = New System.Drawing.Size(212, 45)
        Me.Slider2.TabIndex = 77
        Me.Slider2.Value = 1
        '
        'Slider1
        '
        Me.Slider1.Location = New System.Drawing.Point(5, 68)
        Me.Slider1.Maximum = 5
        Me.Slider1.Minimum = 1
        Me.Slider1.Name = "Slider1"
        Me.Slider1.Size = New System.Drawing.Size(220, 45)
        Me.Slider1.TabIndex = 76
        Me.Slider1.Value = 1
        '
        'frmwbProp
        '
        Me.AcceptButton = Me.Command1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(243, 378)
        Me.Controls.Add(Me.Slider3)
        Me.Controls.Add(Me.Slider2)
        Me.Controls.Add(Me.Slider1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(388, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmwbProp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Properties"
        CType(Me.Slider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmwbProp
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmwbProp
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmwbProp()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As FrmwbProp)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Cancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        My.Settings.Columns = Slider1.Value
        My.Settings.Numbers = Slider2.Value
        My.Settings.Guesses = Slider3.Value
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub FrmwbProp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Slider1.Value = My.Settings.Columns
            Slider2.Value = My.Settings.Numbers
            Slider3.Value = My.Settings.Guesses
        Catch ex As Exception
            MsgBox("frmWBProp_Load: " & ex.Message)
        End Try
    End Sub
End Class