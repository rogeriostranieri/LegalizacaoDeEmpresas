Public Class FrmControleEmpresas
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        If Application.OpenForms.OfType(Of FrmEmpresaAltStatus)().Count() > 0 Then

            FrmEmpresaAltStatus.Focus()
            FrmEmpresaAltStatus.Close()
            FrmEmpresaAltStatus.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmEmpresaAltStatus.Show()


        Else

            FrmEmpresaAltStatus.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmEmpresaAltStatus.Show()

        End If
    End Sub
End Class