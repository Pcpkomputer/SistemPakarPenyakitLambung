﻿Imports SistemPakarPenyakitLambung

Public Class ControllerGejala : Implements InterfaceGejala

    Public Sub CreateData(objek As Object) Implements InterfaceGejala.CreateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("INSERT INTO gejala VALUES ('{0}','{1}')", objek.idgejala_, objek.namagejala_), Koneksi.bukaKoneksi)
        query.ExecuteNonQuery()
    End Sub

    Public Sub UpdateData(objek As Object) Implements InterfaceGejala.UpdateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("UPDATE gejala SET nama_gejala='{0}' WHERE id_gejala='{1}'", objek.namagejala_, objek.idgejala_), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Sub DeleteData(id As String) Implements InterfaceGejala.DeleteData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("DELETE FROM gejala WHERE id_gejala='{0}'", id), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Function ReadData() As DataSet Implements InterfaceGejala.ReadData
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter(String.Format("SELECT * FROM gejala"), Koneksi.bukaKoneksi())
        Dim ds As New DataSet
        adapter.Fill(ds, "tabelgejala")
        Return ds
    End Function
End Class
