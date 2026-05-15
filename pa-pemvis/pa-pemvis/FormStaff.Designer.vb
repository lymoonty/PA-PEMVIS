<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        Label1 = New Label()
        panelUtama = New Panel()
        panelSidebar = New Panel()
        picUtama = New PictureBox()
        panelLogout = New Panel()
        lblLogout = New Label()
        panelIndicatorLogout = New Panel()
        panelPembayaran = New Panel()
        lblPembayaran = New Label()
        PanelIndicatorPembayaran = New Panel()
        panelPerawatan = New Panel()
        lblPerawatan = New Label()
        panelIndicatorPerawatan = New Panel()
        panelKandang = New Panel()
        lblKandang = New Label()
        panelIndicatorKandang = New Panel()
        panelHewan = New Panel()
        lblHewn = New Label()
        panelIndicatorHewan = New Panel()
        panelOwner = New Panel()
        lblOwner = New Label()
        panelIndicatorOwner = New Panel()
        panelBooking = New Panel()
        lblBooking = New Label()
        panelIndicatorBooking = New Panel()
        panelDashboard = New Panel()
        lblDashboard = New Label()
        panelIndicatorDashboard = New Panel()
        Panel1.SuspendLayout()
        panelSidebar.SuspendLayout()
        CType(picUtama, ComponentModel.ISupportInitialize).BeginInit()
        panelLogout.SuspendLayout()
        panelPembayaran.SuspendLayout()
        panelPerawatan.SuspendLayout()
        panelKandang.SuspendLayout()
        panelHewan.SuspendLayout()
        panelOwner.SuspendLayout()
        panelBooking.SuspendLayout()
        panelDashboard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(231, -11)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1205, 85)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightBlue
        Label1.Location = New Point(12, 29)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 39)
        Label1.TabIndex = 0
        Label1.Text = "Sistem Manajemen Pet Hotel - Staff"
        ' 
        ' panelUtama
        ' 
        panelUtama.BackColor = Color.WhiteSmoke
        panelUtama.Location = New Point(231, 72)
        panelUtama.Margin = New Padding(2)
        panelUtama.Name = "panelUtama"
        panelUtama.Size = New Size(1203, 725)
        panelUtama.TabIndex = 2
        ' 
        ' panelSidebar
        ' 
        panelSidebar.BackColor = Color.SteelBlue
        panelSidebar.Controls.Add(picUtama)
        panelSidebar.Controls.Add(panelLogout)
        panelSidebar.Controls.Add(panelPembayaran)
        panelSidebar.Controls.Add(panelPerawatan)
        panelSidebar.Controls.Add(panelKandang)
        panelSidebar.Controls.Add(panelHewan)
        panelSidebar.Controls.Add(panelOwner)
        panelSidebar.Controls.Add(panelBooking)
        panelSidebar.Controls.Add(panelDashboard)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Margin = New Padding(2)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(231, 659)
        panelSidebar.TabIndex = 3
        ' 
        ' picUtama
        ' 
        picUtama.Location = New Point(55, 5)
        picUtama.Margin = New Padding(2)
        picUtama.Name = "picUtama"
        picUtama.Size = New Size(123, 62)
        picUtama.TabIndex = 10
        picUtama.TabStop = False
        ' 
        ' panelLogout
        ' 
        panelLogout.Controls.Add(lblLogout)
        panelLogout.Controls.Add(panelIndicatorLogout)
        panelLogout.Location = New Point(2, 544)
        panelLogout.Margin = New Padding(2)
        panelLogout.Name = "panelLogout"
        panelLogout.Size = New Size(231, 64)
        panelLogout.TabIndex = 8
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Dock = DockStyle.Fill
        lblLogout.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogout.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblLogout.Location = New Point(3, 0)
        lblLogout.Margin = New Padding(2, 0, 2, 0)
        lblLogout.Name = "lblLogout"
        lblLogout.Padding = New Padding(18, 22, 0, 0)
        lblLogout.Size = New Size(82, 44)
        lblLogout.TabIndex = 1
        lblLogout.Text = "Logout"
        lblLogout.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorLogout
        ' 
        panelIndicatorLogout.Dock = DockStyle.Left
        panelIndicatorLogout.Location = New Point(0, 0)
        panelIndicatorLogout.Margin = New Padding(2)
        panelIndicatorLogout.Name = "panelIndicatorLogout"
        panelIndicatorLogout.Size = New Size(3, 64)
        panelIndicatorLogout.TabIndex = 0
        ' 
        ' panelPembayaran
        ' 
        panelPembayaran.Controls.Add(lblPembayaran)
        panelPembayaran.Controls.Add(PanelIndicatorPembayaran)
        panelPembayaran.Location = New Point(2, 477)
        panelPembayaran.Margin = New Padding(2)
        panelPembayaran.Name = "panelPembayaran"
        panelPembayaran.Size = New Size(231, 64)
        panelPembayaran.TabIndex = 7
        ' 
        ' lblPembayaran
        ' 
        lblPembayaran.AutoSize = True
        lblPembayaran.Dock = DockStyle.Fill
        lblPembayaran.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPembayaran.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPembayaran.Location = New Point(3, 0)
        lblPembayaran.Margin = New Padding(2, 0, 2, 0)
        lblPembayaran.Name = "lblPembayaran"
        lblPembayaran.Padding = New Padding(18, 22, 0, 0)
        lblPembayaran.Size = New Size(123, 44)
        lblPembayaran.TabIndex = 1
        lblPembayaran.Text = "Pembayaran"
        lblPembayaran.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelIndicatorPembayaran
        ' 
        PanelIndicatorPembayaran.Dock = DockStyle.Left
        PanelIndicatorPembayaran.Location = New Point(0, 0)
        PanelIndicatorPembayaran.Margin = New Padding(2)
        PanelIndicatorPembayaran.Name = "PanelIndicatorPembayaran"
        PanelIndicatorPembayaran.Size = New Size(3, 64)
        PanelIndicatorPembayaran.TabIndex = 0
        ' 
        ' panelPerawatan
        ' 
        panelPerawatan.Controls.Add(lblPerawatan)
        panelPerawatan.Controls.Add(panelIndicatorPerawatan)
        panelPerawatan.Location = New Point(2, 409)
        panelPerawatan.Margin = New Padding(2)
        panelPerawatan.Name = "panelPerawatan"
        panelPerawatan.Size = New Size(231, 64)
        panelPerawatan.TabIndex = 6
        ' 
        ' lblPerawatan
        ' 
        lblPerawatan.AutoSize = True
        lblPerawatan.Dock = DockStyle.Fill
        lblPerawatan.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPerawatan.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPerawatan.Location = New Point(3, 0)
        lblPerawatan.Margin = New Padding(2, 0, 2, 0)
        lblPerawatan.Name = "lblPerawatan"
        lblPerawatan.Padding = New Padding(18, 22, 0, 0)
        lblPerawatan.Size = New Size(108, 44)
        lblPerawatan.TabIndex = 1
        lblPerawatan.Text = "Perawatan"
        lblPerawatan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorPerawatan
        ' 
        panelIndicatorPerawatan.Dock = DockStyle.Left
        panelIndicatorPerawatan.Location = New Point(0, 0)
        panelIndicatorPerawatan.Margin = New Padding(2)
        panelIndicatorPerawatan.Name = "panelIndicatorPerawatan"
        panelIndicatorPerawatan.Size = New Size(3, 64)
        panelIndicatorPerawatan.TabIndex = 0
        ' 
        ' panelKandang
        ' 
        panelKandang.Controls.Add(lblKandang)
        panelKandang.Controls.Add(panelIndicatorKandang)
        panelKandang.Location = New Point(2, 342)
        panelKandang.Margin = New Padding(2)
        panelKandang.Name = "panelKandang"
        panelKandang.Size = New Size(231, 64)
        panelKandang.TabIndex = 5
        ' 
        ' lblKandang
        ' 
        lblKandang.AutoSize = True
        lblKandang.Dock = DockStyle.Fill
        lblKandang.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKandang.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblKandang.Location = New Point(3, 0)
        lblKandang.Margin = New Padding(2, 0, 2, 0)
        lblKandang.Name = "lblKandang"
        lblKandang.Padding = New Padding(18, 22, 0, 0)
        lblKandang.Size = New Size(96, 44)
        lblKandang.TabIndex = 1
        lblKandang.Text = "Kandang"
        lblKandang.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorKandang
        ' 
        panelIndicatorKandang.Dock = DockStyle.Left
        panelIndicatorKandang.Location = New Point(0, 0)
        panelIndicatorKandang.Margin = New Padding(2)
        panelIndicatorKandang.Name = "panelIndicatorKandang"
        panelIndicatorKandang.Size = New Size(3, 64)
        panelIndicatorKandang.TabIndex = 0
        ' 
        ' panelHewan
        ' 
        panelHewan.Controls.Add(lblHewn)
        panelHewan.Controls.Add(panelIndicatorHewan)
        panelHewan.Location = New Point(2, 274)
        panelHewan.Margin = New Padding(2)
        panelHewan.Name = "panelHewan"
        panelHewan.Size = New Size(231, 64)
        panelHewan.TabIndex = 4
        ' 
        ' lblHewn
        ' 
        lblHewn.AutoSize = True
        lblHewn.Dock = DockStyle.Fill
        lblHewn.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHewn.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblHewn.Location = New Point(3, 0)
        lblHewn.Margin = New Padding(2, 0, 2, 0)
        lblHewn.Name = "lblHewn"
        lblHewn.Padding = New Padding(18, 22, 0, 0)
        lblHewn.Size = New Size(121, 44)
        lblHewn.TabIndex = 1
        lblHewn.Text = "Data Hewan"
        lblHewn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorHewan
        ' 
        panelIndicatorHewan.Dock = DockStyle.Left
        panelIndicatorHewan.Location = New Point(0, 0)
        panelIndicatorHewan.Margin = New Padding(2)
        panelIndicatorHewan.Name = "panelIndicatorHewan"
        panelIndicatorHewan.Size = New Size(3, 64)
        panelIndicatorHewan.TabIndex = 0
        ' 
        ' panelOwner
        ' 
        panelOwner.Controls.Add(lblOwner)
        panelOwner.Controls.Add(panelIndicatorOwner)
        panelOwner.Location = New Point(2, 207)
        panelOwner.Margin = New Padding(2)
        panelOwner.Name = "panelOwner"
        panelOwner.Size = New Size(231, 64)
        panelOwner.TabIndex = 3
        ' 
        ' lblOwner
        ' 
        lblOwner.AutoSize = True
        lblOwner.Dock = DockStyle.Fill
        lblOwner.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOwner.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblOwner.Location = New Point(3, 0)
        lblOwner.Margin = New Padding(2, 0, 2, 0)
        lblOwner.Name = "lblOwner"
        lblOwner.Padding = New Padding(18, 22, 0, 0)
        lblOwner.Size = New Size(119, 44)
        lblOwner.TabIndex = 1
        lblOwner.Text = "Data Owner"
        lblOwner.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorOwner
        ' 
        panelIndicatorOwner.Dock = DockStyle.Left
        panelIndicatorOwner.Location = New Point(0, 0)
        panelIndicatorOwner.Margin = New Padding(2)
        panelIndicatorOwner.Name = "panelIndicatorOwner"
        panelIndicatorOwner.Size = New Size(3, 64)
        panelIndicatorOwner.TabIndex = 0
        ' 
        ' panelBooking
        ' 
        panelBooking.Controls.Add(lblBooking)
        panelBooking.Controls.Add(panelIndicatorBooking)
        panelBooking.Location = New Point(2, 139)
        panelBooking.Margin = New Padding(2)
        panelBooking.Name = "panelBooking"
        panelBooking.Size = New Size(231, 64)
        panelBooking.TabIndex = 2
        ' 
        ' lblBooking
        ' 
        lblBooking.AutoSize = True
        lblBooking.Dock = DockStyle.Fill
        lblBooking.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBooking.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblBooking.Location = New Point(3, 0)
        lblBooking.Margin = New Padding(2, 0, 2, 0)
        lblBooking.Name = "lblBooking"
        lblBooking.Padding = New Padding(18, 22, 0, 0)
        lblBooking.Size = New Size(90, 44)
        lblBooking.TabIndex = 1
        lblBooking.Text = "Booking"
        lblBooking.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorBooking
        ' 
        panelIndicatorBooking.Dock = DockStyle.Left
        panelIndicatorBooking.Location = New Point(0, 0)
        panelIndicatorBooking.Margin = New Padding(2)
        panelIndicatorBooking.Name = "panelIndicatorBooking"
        panelIndicatorBooking.Size = New Size(3, 64)
        panelIndicatorBooking.TabIndex = 0
        ' 
        ' panelDashboard
        ' 
        panelDashboard.Controls.Add(lblDashboard)
        panelDashboard.Controls.Add(panelIndicatorDashboard)
        panelDashboard.Location = New Point(2, 72)
        panelDashboard.Margin = New Padding(2)
        panelDashboard.Name = "panelDashboard"
        panelDashboard.Size = New Size(231, 64)
        panelDashboard.TabIndex = 0
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Dock = DockStyle.Fill
        lblDashboard.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblDashboard.Location = New Point(3, 0)
        lblDashboard.Margin = New Padding(2, 0, 2, 0)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Padding = New Padding(18, 22, 0, 0)
        lblDashboard.Size = New Size(111, 44)
        lblDashboard.TabIndex = 1
        lblDashboard.Text = "Dashboard"
        lblDashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorDashboard
        ' 
        panelIndicatorDashboard.Dock = DockStyle.Left
        panelIndicatorDashboard.Location = New Point(0, 0)
        panelIndicatorDashboard.Margin = New Padding(2)
        panelIndicatorDashboard.Name = "panelIndicatorDashboard"
        panelIndicatorDashboard.Size = New Size(3, 64)
        panelIndicatorDashboard.TabIndex = 0
        ' 
        ' FormStaff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 659)
        Controls.Add(panelSidebar)
        Controls.Add(Panel1)
        Controls.Add(panelUtama)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "FormStaff"
        Text = "Sistem Manajemen Pet Hotel"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panelSidebar.ResumeLayout(False)
        CType(picUtama, ComponentModel.ISupportInitialize).EndInit()
        panelLogout.ResumeLayout(False)
        panelLogout.PerformLayout()
        panelPembayaran.ResumeLayout(False)
        panelPembayaran.PerformLayout()
        panelPerawatan.ResumeLayout(False)
        panelPerawatan.PerformLayout()
        panelKandang.ResumeLayout(False)
        panelKandang.PerformLayout()
        panelHewan.ResumeLayout(False)
        panelHewan.PerformLayout()
        panelOwner.ResumeLayout(False)
        panelOwner.PerformLayout()
        panelBooking.ResumeLayout(False)
        panelBooking.PerformLayout()
        panelDashboard.ResumeLayout(False)
        panelDashboard.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelUtama As Panel
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents panelDashboard As Panel
    Friend WithEvents panelIndicatorDashboard As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents panelBooking As Panel
    Friend WithEvents lblBooking As Label
    Friend WithEvents panelIndicatorBooking As Panel
    Friend WithEvents panelHewan As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHewn As Label
    Friend WithEvents panelIndicatorHewan As Panel
    Friend WithEvents panelOwner As Panel
    Friend WithEvents lblOwner As Label
    Friend WithEvents panelIndicatorOwner As Panel
    Friend WithEvents panelPembayaran As Panel
    Friend WithEvents lblPembayaran As Label
    Friend WithEvents PanelIndicatorPembayaran As Panel
    Friend WithEvents panelPerawatan As Panel
    Friend WithEvents lblPerawatan As Label
    Friend WithEvents panelIndicatorPerawatan As Panel
    Friend WithEvents panelKandang As Panel
    Friend WithEvents lblKandang As Label
    Friend WithEvents panelIndicatorKandang As Panel
    Friend WithEvents picUtama As PictureBox
    Friend WithEvents panelLogout As Panel
    Friend WithEvents lblLogout As Label
    Friend WithEvents panelIndicatorLogout As Panel

End Class
