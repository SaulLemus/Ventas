
Imports System.Data
Imports System.Data.SqlClient

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Shared.PaperSize
Imports System.Drawing.Printing

Public Class frm_rpt_ingCompra

    Public orden As Integer
    Public formula As String

    Private Sub frm_rpt_ingCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oRptprueba As RPT_IngCompra
        Dim oSumInfo As SummaryInfo
        Dim oConexioninfo As ConnectionInfo
        Dim olistatablas As Tables
        Dim otabla As Table
        Dim otableconexinfo As TableLogOnInfo


        oConexioninfo = New ConnectionInfo()
        oConexioninfo.ServerName = srv_tmp
        oConexioninfo.DatabaseName = db_tmp
        oConexioninfo.UserID = "sa"
        oConexioninfo.Password = psw

        oRptprueba = New RPT_IngCompra
        'oRptprueba.PrintOptions.PaperSize = DefaultPaperSize

        olistatablas = oRptprueba.Database.Tables

        For Each otabla In olistatablas
            otableconexinfo = otabla.LogOnInfo
            otableconexinfo.ConnectionInfo = oConexioninfo
            otabla.ApplyLogOnInfo(otableconexinfo)
        Next

        'oRptprueba.PrintOptions.PaperOrientation = PaperOrientation.Portrait
        oSumInfo = oRptprueba.SummaryInfo
        oSumInfo.ReportTitle = " "

        oRptprueba.RecordSelectionFormula = formula

        Me.CrystalReportViewer1.ReportSource = oRptprueba

    End Sub
End Class