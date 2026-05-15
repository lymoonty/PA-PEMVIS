Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormAdmin

    ' ─────────────────────────────────────────────────────
    ' KONSTANTA UI & STATE
    ' ─────────────────────────────────────────────────────
    Private ReadOnly COLOR_DEFAULT As Color = Color.Transparent
    Private ReadOnly COLOR_HOVER As Color = Color.FromArgb(214, 219, 223)
    Private ReadOnly COLOR_ACTIVE As Color = Color.SteelBlue

    ' Cache UserControl agar tidak di-instantiate ulang setiap klik
    ' & state (misal: filter, scroll, input) tidak hilang saat berpindah menu
    Private ReadOnly pageCache As New Dictionary(Of Panel, UserControl)()

    ' ─────────────────────────────────────────────────────
    ' LOAD FORM — Tampilkan halaman default
    ' ─────────────────────────────────────────────────────
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ganti UCKandang() sesuai menu default yang Anda inginkan
        LoadPage(panelKandang, New uc_Kandang())
        SetMenuActive(panelKandang)
    End Sub

    ' ─────────────────────────────────────────────────────
    ' RESET SEMUA MENU KE STATE DEFAULT
    ' ─────────────────────────────────────────────────────
    Private Sub ResetMenu()
        panelDashboard.BackColor = COLOR_DEFAULT : panelIndicatorDashboard.BackColor = COLOR_DEFAULT
        panelKandang.BackColor = COLOR_DEFAULT : panelIndicatorKandang.BackColor = COLOR_DEFAULT
        panelPerawatan.BackColor = COLOR_DEFAULT : panelIndicatorPerawatan.BackColor = COLOR_DEFAULT
        panelPembayaran.BackColor = COLOR_DEFAULT : panelIndicatorPembayaran.BackColor = COLOR_DEFAULT
        panelUser.BackColor = COLOR_DEFAULT : panelIndicatorUser.BackColor = COLOR_DEFAULT
        panelTarif.BackColor = COLOR_DEFAULT : panelIndicatorTarif.BackColor = COLOR_DEFAULT
        panelLogout.BackColor = COLOR_DEFAULT : panelIndicatorLogout.BackColor = COLOR_DEFAULT
    End Sub

    ' ─────────────────────────────────────────────────────
    ' SET MENU AKTIF
    ' ─────────────────────────────────────────────────────
    Private Sub SetMenuActive(menuPanel As Panel)
        ResetMenu()
        menuPanel.BackColor = COLOR_HOVER

        ' Aktifkan indikator yang sesuai
        Select Case menuPanel.Name
            Case "panelDashboard" : panelIndicatorDashboard.BackColor = COLOR_ACTIVE
            Case "panelKandang" : panelIndicatorKandang.BackColor = COLOR_ACTIVE
            Case "panelPerawatan" : panelIndicatorPerawatan.BackColor = COLOR_ACTIVE
            Case "panelPembayaran" : panelIndicatorPembayaran.BackColor = COLOR_ACTIVE
            Case "panelUser" : panelIndicatorUser.BackColor = COLOR_ACTIVE
            Case "panelTarif" : panelIndicatorTarif.BackColor = COLOR_ACTIVE
            Case "panelLogout" : panelIndicatorLogout.BackColor = COLOR_ACTIVE
        End Select
    End Sub

    ' ═════════════════════════════════════════════════════
    '  SHARED EVENT HANDLER (HOVER)
    ' ═════════════════════════════════════════════════════
    Private Sub MenuPanels_MouseEnter(sender As Object, e As EventArgs) _
        Handles panelDashboard.MouseEnter, panelKandang.MouseEnter, panelPerawatan.MouseEnter,
                panelPembayaran.MouseEnter, panelUser.MouseEnter, panelTarif.MouseEnter,
                panelLogout.MouseEnter, lblDashboard.MouseEnter, lblKandang.MouseEnter,
                lblPerawatan.MouseEnter, lblPembayaran.MouseEnter, lblUser.MouseEnter,
                lblTarif.MouseEnter, lblLogout.MouseEnter

        Dim pnl As Panel = TryCast(sender, Panel)
        If pnl IsNot Nothing Then
            Dim lbl As Label = TryCast(sender, Label)
            If lbl IsNot Nothing Then pnl = TryCast(lbl.Parent, Panel)
        End If
    End Sub

    Private Sub MenuPanels_MouseLeave(sender As Object, e As EventArgs) _
        Handles panelDashboard.MouseLeave, panelKandang.MouseLeave, panelPerawatan.MouseLeave,
                panelPembayaran.MouseLeave, panelUser.MouseLeave, panelTarif.MouseLeave,
                panelLogout.MouseLeave, lblDashboard.MouseLeave, lblKandang.MouseLeave,
                lblPerawatan.MouseLeave, lblPembayaran.MouseLeave, lblUser.MouseLeave,
                lblTarif.MouseLeave, lblLogout.MouseLeave

        Dim pnl = TryCast(sender, Panel)
        If pnl IsNot Nothing AndAlso pnl.BackColor <> COLOR_ACTIVE Then
            pnl.BackColor = COLOR_DEFAULT
        End If
    End Sub

    ' ═════════════════════════════════════════════════════
    '  SHARED EVENT HANDLER (CLICK)
    ' ═════════════════════════════════════════════════════
    Private Sub MenuPanels_Click(sender As Object, e As EventArgs) _
        Handles panelDashboard.Click, panelKandang.Click, panelPerawatan.Click,
                panelPembayaran.Click, panelUser.Click, panelTarif.Click,
                panelLogout.Click, lblDashboard.Click, lblKandang.Click,
                lblPerawatan.Click, lblPembayaran.Click, lblUser.Click,
                lblTarif.Click, lblLogout.Click

        Dim pnl = TryCast(sender, Panel)
        If pnl Is Nothing Then Return

        SetMenuActive(pnl)

        ' Routing berdasarkan nama panel
        Select Case pnl.Name
            Case "panelDashboard" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_Dashboard()))
            Case "panelKandang" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_Kandang()))
            Case "panelPerawatan" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_Perawatan()))
            Case "panelPembayaran" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_MetodePembayaran()))
          '  Case "panelUser" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_User()))
            Case "panelTarif" : LoadPage(panelUtama, GetOrCreatePage(pnl, New uc_Tarif()))
            Case "panelLogout" : HandleLogout()
        End Select
    End Sub

    ' ─────────────────────────────────────────────────────
    ' HELPER: CACHE & LOAD USERCONTROL
    ' ─────────────────────────────────────────────────────
    Private Function GetOrCreatePage(key As Panel, newInstance As UserControl) As UserControl
        If Not pageCache.ContainsKey(key) Then
            pageCache(key) = newInstance
        End If
        Return pageCache(key)
    End Function

    Private Sub LoadPage(container As Panel, uc As UserControl)
        Try
            container.Controls.Clear()
            uc.Dock = DockStyle.Fill
            container.Controls.Add(uc)
            uc.BringToFront()
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat halaman: {ex.Message}", "Error LoadPage",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ─────────────────────────────────────────────────────
    ' LOGOUT HANDLER
    ' ─────────────────────────────────────────────────────
    Private Sub HandleLogout()
        Dim result = MessageBox.Show("Yakin ingin keluar dari aplikasi?",
                                     "Konfirmasi Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' TODO: Jika ada FormLogin, uncomment baris di bawah:
            ' Dim frmLogin As New FormLogin()
            ' frmLogin.Show()

            Application.Exit()
        End If
    End Sub

    Private Sub panelUtama_Paint(sender As Object, e As PaintEventArgs) Handles panelUtama.Paint

    End Sub
End Class