Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "HotelDataSet.appart_type". При необходимости она может быть перемещена или удалена.
        Me.Appart_typeTableAdapter.Fill(Me.HotelDataSet.appart_type)

    End Sub

    Private Sub Appart_typeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Appart_typeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Appart_typeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub Appart_typeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Appart_typeDataGridView.CellContentClick

    End Sub
End Class