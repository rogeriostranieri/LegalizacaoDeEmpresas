﻿

Public Class FrmBuscaEmpresas

    Private Ultimabusca As Integer = 0

    Private Sub FrmBuscaEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged

        EmpresasBindingSource.Filter = "RazaoSocial like '%" & txtPesquisa.Text & "%'"
    End Sub


End Class