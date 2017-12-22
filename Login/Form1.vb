Imports System.Data.Odbc
Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call koneksinya()
        cmd = New OdbcCommand("select * from pengguna", conn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Add("PILIH")
        ComboBox1.SelectedIndex = 0
        While dr.Read()
            ComboBox1.Items.Add(dr.Item("status"))
        End While

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Lengkapi Semua Isian")
        Else
            Call koneksinya()
            cmd = New OdbcCommand("select * from pengguna where user = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "' and status = '" & ComboBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MessageBox.Show("Login gagal Periksa username, password dan status anda")
            Else
                ' Me.Hide()
                Form2.Show()
                Form2.panel1.Text = "NAMA PENGGUNA : " + dr.Item("user")
                Form2.panel2.Text = "STATUS PENGGUNA : " + dr.Item("status")
                If ComboBox1.Text = "PIMPINAN" Then
                    Form2.BARANGToolStripMenuItem.Enabled = True
                    Form2.SUPPLIERToolStripMenuItem.Enabled = True
                    Form2.USERToolStripMenuItem.Enabled = True
                    Form2.GANTIPASSWORDToolStripMenuItem.Enabled = True
                    Form2.PENJUALANToolStripMenuItem.Enabled = False
                    Form2.PEMBELIANToolStripMenuItem.Enabled = False
                    Form2.LAPORANHARIANToolStripMenuItem.Enabled = True
                    Form2.LAPORANBULANANToolStripMenuItem.Enabled = True
                ElseIf ComboBox1.Text = "KASIR" Then
                    Form2.BARANGToolStripMenuItem.Enabled = False
                    Form2.SUPPLIERToolStripMenuItem.Enabled = False
                    Form2.USERToolStripMenuItem.Enabled = False
                    Form2.GANTIPASSWORDToolStripMenuItem.Enabled = True
                    Form2.PENJUALANToolStripMenuItem.Enabled = True
                    Form2.PEMBELIANToolStripMenuItem.Enabled = False
                    Form2.LAPORANHARIANToolStripMenuItem.Enabled = False
                    Form2.LAPORANBULANANToolStripMenuItem.Enabled = False
                Else
                    Form2.BARANGToolStripMenuItem.Enabled = False
                    Form2.SUPPLIERToolStripMenuItem.Enabled = False
                    Form2.USERToolStripMenuItem.Enabled = False
                    Form2.GANTIPASSWORDToolStripMenuItem.Enabled = True
                    Form2.PENJUALANToolStripMenuItem.Enabled = False
                    Form2.PEMBELIANToolStripMenuItem.Enabled = True
                    Form2.LAPORANHARIANToolStripMenuItem.Enabled = False
                    Form2.LAPORANBULANANToolStripMenuItem.Enabled = False
                End If
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
