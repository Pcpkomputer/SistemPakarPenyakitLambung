Public Class FormDiagnosis
    Private Sub FormDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.CheckBoxes = True

        ListView1.Columns.Add("", 30, HorizontalAlignment.Left)          'Add column 1
        ListView1.Columns.Add("ID Gejala", 50, HorizontalAlignment.Left) 'Add column 2
        ListView1.Columns.Add("Gejala Penyakit", 265, HorizontalAlignment.Left) 'Add column 3


        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbCommand(String.Format("SELECT * FROM gejala"), Koneksi.bukaKoneksi())
        Dim reader As OleDb.OleDbDataReader = adapter.ExecuteReader

        While reader.Read
            ListView1.Items.Add(New ListViewItem({"", reader.Item(0).ToString, reader.Item(1).ToString}))

        End While


        'Use this to set the first column to be displayed as the last column
        ListView1.Columns(0).DisplayIndex = ListView1.Columns.Count - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listq As New List(Of String)()

        For i = 0 To ListView1.Items.Count - 1

            If ListView1.Items(i).Checked = True Then
                Dim newitem As String = ListView1.Items(i).SubItems(1).Text
                Dim newitem1 As String = ListView1.Items(i).SubItems(2).Text

                FormDetailDiagnosis.tambahGejala(newitem, newitem1)

                'idgejala.Add(newitem)
                'namagejala.Add(newitem1)

                listq.Add("'" + newitem + "'")

            End If

        Next

        Dim stringJoin As String = String.Join(",", listq)
        Dim listpenyakit As New List(Of String)


        Dim n1 As New List(Of List(Of String))
        Dim n2 As New List(Of List(Of String))

        Koneksi.tutupKoneksi()
        Dim q1 As New OleDb.OleDbCommand("SELECT * FROM penyakit", Koneksi.bukaKoneksi())
        Dim r1 As OleDb.OleDbDataReader = q1.ExecuteReader

        While r1.Read
            listpenyakit.Add(r1.Item(0))
        End While

        For i = 0 To listpenyakit.Count - 1
            Koneksi.tutupKoneksi()
            Dim q2 As New OleDb.OleDbCommand(String.Format("SELECT aturan.id_penyakit,data_aturan.id_gejala, data_aturan.probabilitas FROM data_aturan INNER JOIN aturan ON aturan.id_aturan=data_aturan.id_aturan WHERE
data_aturan.id_gejala IN ({0}) AND aturan.id_penyakit='{1}'", stringJoin, listpenyakit(i)), Koneksi.bukaKoneksi())
            Dim r2 As OleDb.OleDbDataReader = q2.ExecuteReader

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))

            If r2.HasRows Then
                While r2.Read
                    payload.Add(r2.Item(2))
                End While
            Else
                payload.Add(0)
            End If

            n1.Add(payload)
        Next

        For i = 0 To n1.Count - 1

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))

            Dim zz As Double = 0
            For l = 0 To n1(i).Count - 1
                Try
                    zz = zz + n1(i)(l + 1)
                Catch ex As Exception

                End Try

            Next
            payload.Add(zz)
            n2.Add(payload)
        Next


        Dim n3 As New List(Of List(Of String))

        For i = 0 To n1.Count - 1

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))

            For l = 0 To n1(i).Count - 1
                Try
                    Dim nsatu = n1(i)(l + 1)
                    Dim bagi = nsatu / n2(i)(1)
                    payload.Add(bagi)

                Catch ex As Exception

                End Try

            Next
            n3.Add(payload)
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''
        '''

        Dim n4 As New List(Of List(Of String))


        For i = 0 To n1.Count - 1

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))
            Dim zz As Double = 0

            For l = 0 To n1(i).Count - 1
                Try
                    Dim nsatu = n1(i)(l + 1)
                    Dim ntiga = n3(i)(l + 1)
                    'MsgBox(nsatu)

                    zz = zz + (ntiga * nsatu)


                Catch ex As Exception

                End Try

            Next
            payload.Add(zz)
            n4.Add(payload)
        Next


        ''''''''''''''''''''''''''''''''''
        '''

        Dim n5 As New List(Of List(Of String))

        For i = 0 To n1.Count - 1

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))
            Dim zz As Double = 0

            For l = 0 To n1(i).Count - 1
                Try
                    Dim npat As Double = n4(i)(1)
                    Dim nsatu = n1(i)(l + 1)
                    Dim ntiga = n3(i)(l + 1)

                    Dim hasil = (ntiga * nsatu) / npat

                    payload.Add(hasil)


                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

            Next
            n5.Add(payload)
        Next




        '''''''''''''''''''''''''''''''''''''''''''
        '''


        Dim n6 As New List(Of List(Of String))

        For i = 0 To n1.Count - 1

            Dim payload As New List(Of String)
            payload.Add(listpenyakit(i))
            Dim zz As Double = 0

            For l = 0 To n1(i).Count - 1
                Try

                    Dim nsatu = n1(i)(l + 1)
                    Dim nlima = n5(i)(l + 1)

                    zz = zz + (nsatu * nlima)



                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

            Next
            payload.Add(zz)
            n6.Add(payload)
        Next


        For i = 0 To n6.Count - 1
            Try
                Koneksi.tutupKoneksi()
                Dim querynamapenyakit As New OleDb.OleDbCommand(String.Format("SELECT nama_penyakit FROM penyakit WHERE id_penyakit='{0}'", n6(i)(0)), Koneksi.bukaKoneksi)
                Dim readnamapenyakit As OleDb.OleDbDataReader = querynamapenyakit.ExecuteReader
                While readnamapenyakit.Read
                    FormDetailDiagnosis.tambahPresentase(readnamapenyakit.Item(0), n6(i)(1))
                End While
            Catch ex As Exception

            End Try


        Next

        FormDetailDiagnosis.Show()


    End Sub
End Class