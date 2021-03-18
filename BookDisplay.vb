Module BookDisplay

    Public Sub load(ByRef books As List(Of Book))


    End Sub





    Public Sub updateBookVisuals()


        Dim rows As Integer
        Dim p As Integer

        rows = 5

        Main.books.Add(New Book)



        Dim pal As Integer = 0





        Main.DisplayBookPanel.Controls.Add(Main.books.Item(0))









    End Sub





End Module
