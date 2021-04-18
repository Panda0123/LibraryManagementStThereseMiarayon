Module GlobalSource
    Property classifications As List(Of ClassificationDTO)
    Property classificationNames As New List(Of String)

    Property authors As List(Of AuthorDTO)
    Property authorFullNames As New List(Of String)

    Public Sub setClass()
        classifications = CategoryController.getCategories()
        classifications.Sort(Function(x, y) x.id.CompareTo(y.id))
        For Each classificationDto As ClassificationDTO In classifications
            classificationNames.Add(classificationDto.name)
        Next
    End Sub

    Public Sub setAuthors()
        authors = AuthorController.getAuthors()
        For Each authorDTO As AuthorDTO In authors
            authorFullNames.Add(String.Format("{0} {1} {2}", authorDTO.f_name, authorDTO.m_name, authorDTO.l_name))
        Next
    End Sub
End Module
