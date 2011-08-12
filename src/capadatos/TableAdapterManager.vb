Imports System.ComponentModel

Friend Class TableAdapterManager


    Private _opfabricaDB As opfabricaTableAdapter
    Private _detalle_opfabrica As detallesOpFabricaTableAdapter
    Private _connection As IDbConnection
    Private _backupDataSetBeforeUpdate As Boolean

    Public Enum UpdateOrderOption

        InsertUpdateDelete = 0

        UpdateInsertDelete = 1
    End Enum
    Private _updateOrder As UpdateOrderOption

    Public Property UpdateOrder() As UpdateOrderOption
        Get
            Return Me._updateOrder
        End Get
        Set(ByVal value As UpdateOrderOption)
            Me._updateOrder = value
        End Set
    End Property
    Public Property BackupDataSetBeforeUpdate() As Boolean
        Get
            Return Me._backupDataSetBeforeUpdate
        End Get
        Set(ByVal value As Boolean)
            Me._backupDataSetBeforeUpdate = value
        End Set
    End Property
    Public Property Detalle_opfabricaDB As detallesOpFabricaTableAdapter
        Get
            Return Me._detalle_opfabrica
        End Get
        Set(ByVal value As detallesOpFabricaTableAdapter)
            Me._detalle_opfabrica = value
        End Set
    End Property
    Public Property OpfabricaDB As opfabricaTableAdapter
        Get
            Return Me._opfabricaDB
        End Get
        Set(ByVal value As opfabricaTableAdapter)
            Me._opfabricaDB = value
        End Set
    End Property
    <Global.System.ComponentModel.Browsable(False)> _
    Public Property Connection() As IDbConnection
        Get
            If Not Me._connection Is Nothing Then
                Return Me._connection
            End If
            If ((Not (Me._opfabricaDB) Is Nothing) AndAlso (Not (Me._opfabricaDB.Connection) Is Nothing)) Then
                Return Me._opfabricaDB.Connection
            End If
            If ((Not (Me._detalle_opfabrica) Is Nothing) _
                           AndAlso (Not (Me._detalle_opfabrica.Connection) Is Nothing)) Then
                Return Me._detalle_opfabrica.Connection
            End If
            Return Nothing
        End Get
        Set(ByVal value As IDbConnection)
            Me._connection = value
        End Set
    End Property
    <Global.System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property TableAdapterInstanceCount As Integer
        Get
            Dim count As Integer = 0

            If (Not (Me._opfabricaDB) Is Nothing) Then
                count += 1
            End If
            If (Not (Me._detalle_opfabrica) Is Nothing) Then
                count += 1
            End If

            Return count
        End Get
    End Property
    Public Overridable Function UpdateAll(ByVal oleosigds As oleosigDB) As Integer
        If (oleosigds Is Nothing) Then
            Throw New Global.System.ArgumentNullException("oleosig")
        End If
        If oleosigds.HasChanges = False Then
            Return 0
        End If
        If ((Not (Me._opfabricaDB) Is Nothing) AndAlso (Me.MatchTableAdapterConnection(Me._opfabricaDB.Connection) = False)) Then
            Throw New Global.System.ArgumentException("Todos los TableAdapters administrados por un TableAdapterManager deben usar la mi" & _
                    "sma cadena de conexión.")
        End If
        If ((Not (Me._detalle_opfabrica) Is Nothing) _
                    AndAlso (Me.MatchTableAdapterConnection(Me._detalle_opfabrica.Connection) = False)) Then
            Throw New Global.System.ArgumentException("Todos los TableAdapters administrados por un TableAdapterManager deben usar la mi" & _
                    "sma cadena de conexión.")
        End If
        Dim workConnection As IDbConnection = Me.Connection
        Dim workConnOpened As Boolean = False
        If (workConnection.State And ConnectionState.Broken) = ConnectionState.Broken Then
            workConnection.Close()
        End If
        If (workConnection.State And ConnectionState.Closed) = ConnectionState.Closed Then
            workConnection.Open()
            workConnOpened = True
        End If

        Dim workTransaction As Global.System.Data.IDbTransaction = workConnection.BeginTransaction
        If (workTransaction Is Nothing) Then
            Throw New Global.System.ApplicationException("La transacción no puede comenzar. La conexión de datos actual no es compatible co" & _
                    "n las transacciones o el estado actual no permite que comience la transacción.")
        End If

        Dim allchangedRows As List(Of DataRow) = New List(Of DataRow)
        Dim alladdedRows As List(Of DataRow) = New List(Of DataRow)
        Dim adaptersWithAcceptChangesDuringUpdate As Global.System.Collections.Generic.List(Of Global.System.Data.Common.DataAdapter) = New Global.System.Collections.Generic.List(Of Global.System.Data.Common.DataAdapter)
        Dim revertConnections As Global.System.Collections.Generic.Dictionary(Of Object, Global.System.Data.IDbConnection) = New Global.System.Collections.Generic.Dictionary(Of Object, Global.System.Data.IDbConnection)
        Dim result As Integer = 0
        Dim backupDataSet As Global.System.Data.DataSet = Nothing
        If Me.BackupDataSetBeforeUpdate Then
            backupDataSet = New Global.System.Data.DataSet
            backupDataSet.Merge(oleosigds)
        End If
        Try
            If (Not Me._opfabricaDB Is Nothing) Then
                revertConnections.Add(Me._opfabricaDB, Me._opfabricaDB.Connection)
                Me._opfabricaDB.Connection = CType(workConnection, System.Data.Common.DbConnection)
                Me._opfabricaDB.Transaction = CType(workTransaction, Global.System.Data.Common.DbTransaction)
            End If
            If (Not (Me._detalle_opfabrica) Is Nothing) Then
                revertConnections.Add(Me._detalle_opfabrica, Me._detalle_opfabrica.Connection)
                Me._detalle_opfabrica.Connection = CType(workConnection, Global.System.Data.Common.DbConnection)
                Me._detalle_opfabrica.Transaction = CType(workTransaction, Global.System.Data.Common.DbTransaction)

            End If
            If (Me.UpdateOrder = UpdateOrderOption.UpdateInsertDelete) Then
                result = (result + Me.UpdateUpdatedRows(oleosigds, allchangedRows, alladdedRows))
                result = (result + Me.UpdateInsertedRows(oleosigds, alladdedRows))
            Else
                result = (result + Me.UpdateInsertedRows(oleosigds, alladdedRows))
                result = (result + Me.UpdateUpdatedRows(oleosigds, allchangedRows, alladdedRows))
            End If
            result = (result + Me.UpdateDeletedRows(oleosigds, allchangedRows))

            '   workTransaction.Commit()
            '   If (0 < alladdedRows.Count) Then
            ' Dim rows((alladdedRows.Count) - 1) As Global.System.Data.DataRow
            ' alladdedRows.CopyTo(rows)
            ' Dim i As Integer = 0
            ' Do While (i < rows.Length)
            ' Dim row As Global.System.Data.DataRow = rows(i)
            ' row.AcceptChanges()
            ' i = (i + 1)
            ' Loop
            ' End If
            'If (0 < allchangedRows.Count) Then
            ' Dim rows((allchangedRows.Count) - 1) As Global.System.Data.DataRow
            ' allchangedRows.CopyTo(rows)
            ' Dim i As Integer = 0
            ' Do While (i < rows.Length)
            ' Dim row As Global.System.Data.DataRow = rows(i)
            ' row.AcceptChanges()
            ' i = (i + 1)
            ' Loop
            'End If
        Catch ex As Exception
            workTransaction.Rollback()
            '---- Restore the dataset -----------
            If Me.BackupDataSetBeforeUpdate Then
                Global.System.Diagnostics.Debug.Assert((Not (backupDataSet) Is Nothing))
                oleosigds.Clear()
                oleosigds.Merge(backupDataSet)
            Else
                If (0 < alladdedRows.Count) Then
                    Dim rows((alladdedRows.Count) - 1) As Global.System.Data.DataRow
                    alladdedRows.CopyTo(rows)
                    Dim i As Integer = 0
                    Do While (i < rows.Length)
                        Dim row As Global.System.Data.DataRow = rows(i)
                        row.AcceptChanges()
                        row.SetAdded()
                        i = (i + 1)
                    Loop
                End If
            End If
            Throw ex
        Finally
            If workConnOpened Then
                workConnection.Close()
            End If
            If (Not (Me._opfabricaDB) Is Nothing) Then
                Me._opfabricaDB.Connection = CType(revertConnections(Me._opfabricaDB), Global.System.Data.Common.DbConnection)
                Me._opfabricaDB.Transaction = Nothing
            End If
            If (Not (Me._detalle_opfabrica) Is Nothing) Then
                Me._detalle_opfabrica.Connection = CType(revertConnections(Me._detalle_opfabrica), Global.System.Data.Common.DbConnection)
                Me._detalle_opfabrica.Transaction = Nothing
            End If

            If (0 < adaptersWithAcceptChangesDuringUpdate.Count) Then
                Dim adapters((adaptersWithAcceptChangesDuringUpdate.Count) - 1) As Global.System.Data.Common.DataAdapter
                adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters)
                Dim i As Integer = 0
                Do While (i < adapters.Length)
                    Dim adapter As Global.System.Data.Common.DataAdapter = adapters(i)
                    adapter.AcceptChangesDuringUpdate = True
                    i = (i + 1)
                Loop
            End If
        End Try
        Return result
    End Function
    Protected Overridable Function MatchTableAdapterConnection(ByVal inputConnection As Global.System.Data.IDbConnection) As Boolean
        If (Not (Me._connection) Is Nothing) Then
            Return True
        End If
        If ((Me.Connection Is Nothing) _
                    OrElse (inputConnection Is Nothing)) Then
            Return True
        End If
        If String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, Global.System.StringComparison.Ordinal) Then
            Return True
        End If
        Return False
    End Function
    Private Function UpdateUpdatedRows(ByVal dataSet As oleosigDB, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow), ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer = 0

        If (Not (Me._opfabricaDB) Is Nothing) Then
            Dim updatedRows() As Global.System.Data.DataRow = dataSet.opfabrica.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.ModifiedCurrent)
            updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
            If ((Not (updatedRows) Is Nothing) _
                        AndAlso (0 < updatedRows.Length)) Then
                result = (result + Me._opfabricaDB.Update(updatedRows))
                allChangedRows.AddRange(updatedRows)
            End If
        End If
        If (Not (Me._detalle_opfabrica) Is Nothing) Then
            Dim updatedRows() As Global.System.Data.DataRow = dataSet.detalles_opfabrica.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.ModifiedCurrent)
            updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
            If ((Not (updatedRows) Is Nothing) AndAlso (0 < updatedRows.Length)) Then
                result = (result + Me._detalle_opfabrica.Update(updatedRows))
                allChangedRows.AddRange(updatedRows)
            End If
        End If
        Return result
    End Function
    Private Function UpdateDeletedRows(ByVal dataSet As oleosigDB, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer
        If (Not (Me._opfabricaDB) Is Nothing) Then
            Dim deletedRows() As Global.System.Data.DataRow = dataSet.opfabrica.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.Deleted)
            If ((Not (deletedRows) Is Nothing) _
                        AndAlso (0 < deletedRows.Length)) Then
                result = (result + Me._opfabricaDB.Update(deletedRows))
                allChangedRows.AddRange(deletedRows)
            End If
        End If
        If (Not (Me._detalle_opfabrica) Is Nothing) Then
            Dim deletedRows() As DataRow = dataSet.detalles_opfabrica.Select(Nothing, Nothing, DataViewRowState.Deleted)
            If ((Not (deletedRows) Is Nothing) AndAlso (0 < deletedRows.Length)) Then
                result = (result + Me._detalle_opfabrica.Update(deletedRows))
                allChangedRows.AddRange(deletedRows)
            End If
        End If

        Return result
    End Function
    Private Function UpdateInsertedRows(ByVal dataSet As oleosigDB, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer = 0
        If (Not (Me._opfabricaDB) Is Nothing) Then
            Dim addedRows() As Global.System.Data.DataRow = dataSet.opfabrica.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.Added)
            If ((Not (addedRows) Is Nothing) _
                        AndAlso (0 < addedRows.Length)) Then
                result = (result + Me._opfabricaDB.Update(addedRows))
                allAddedRows.AddRange(addedRows)
            End If
        End If
        If (Not (Me._detalle_opfabrica) Is Nothing) Then
            Dim addedRows() As Global.System.Data.DataRow = dataSet.detalles_opfabrica.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.Added)
            If ((Not (addedRows) Is Nothing) _
                        AndAlso (0 < addedRows.Length)) Then
                result = (result + Me._detalle_opfabrica.Update(addedRows))
                allAddedRows.AddRange(addedRows)
            End If
        End If
        Return result
    End Function

    Private Function GetRealUpdatedRows(ByVal updatedRows() As Global.System.Data.DataRow, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Global.System.Data.DataRow()
        If ((updatedRows Is Nothing) _
                    OrElse (updatedRows.Length < 1)) Then
            Return updatedRows
        End If
        If ((allAddedRows Is Nothing) _
                    OrElse (allAddedRows.Count < 1)) Then
            Return updatedRows
        End If
        Dim realUpdatedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow) = New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)
        Dim i As Integer = 0
        Do While (i < updatedRows.Length)
            Dim row As Global.System.Data.DataRow = updatedRows(i)
            If (allAddedRows.Contains(row) = False) Then
                realUpdatedRows.Add(row)
            End If
            i = (i + 1)
        Loop
        Return realUpdatedRows.ToArray
    End Function
    Protected Overridable Sub SortSelfReferenceRows(ByVal rows() As Global.System.Data.DataRow, ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
        Global.System.Array.Sort(Of Global.System.Data.DataRow)(rows, New SelfReferenceComparer(relation, childFirst))
    End Sub

    Private Class SelfReferenceComparer
        Inherits Object
        Implements Global.System.Collections.Generic.IComparer(Of Global.System.Data.DataRow)

        Private _relation As Global.System.Data.DataRelation

        Private _childFirst As Integer

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Friend Sub New(ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
            MyBase.New()
            Me._relation = relation
            If childFirst Then
                Me._childFirst = -1
            Else
                Me._childFirst = 1
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private Function IsChildAndParent(ByVal child As Global.System.Data.DataRow, ByVal parent As Global.System.Data.DataRow) As Boolean
            Global.System.Diagnostics.Debug.Assert((Not (child) Is Nothing))
            Global.System.Diagnostics.Debug.Assert((Not (parent) Is Nothing))
            Dim newParent As Global.System.Data.DataRow = child.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.[Default])

            Do While ((Not (newParent) Is Nothing) _
                        AndAlso ((Object.ReferenceEquals(newParent, child) = False) _
                        AndAlso (Object.ReferenceEquals(newParent, parent) = False)))
                newParent = newParent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.[Default])

            Loop
            If (newParent Is Nothing) Then
                newParent = child.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)
                Do While ((Not (newParent) Is Nothing) _
                            AndAlso ((Object.ReferenceEquals(newParent, child) = False) _
                            AndAlso (Object.ReferenceEquals(newParent, parent) = False)))
                    newParent = newParent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)

                Loop
            End If
            If Object.ReferenceEquals(newParent, parent) Then
                Return True
            End If
            Return False
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function Compare(ByVal row1 As Global.System.Data.DataRow, ByVal row2 As Global.System.Data.DataRow) As Integer Implements Global.System.Collections.Generic.IComparer(Of Global.System.Data.DataRow).Compare
            If Object.ReferenceEquals(row1, row2) Then
                Return 0
            End If
            If (row1 Is Nothing) Then
                Return -1
            End If
            If (row2 Is Nothing) Then
                Return 1
            End If

            'Is row1 the child or grandchild of row2
            If Me.IsChildAndParent(row1, row2) Then
                Return Me._childFirst
            End If

            'Is row2 the child or grandchild of row1
            If Me.IsChildAndParent(row2, row1) Then
                Return (-1 * Me._childFirst)
            End If
            Return 0
        End Function
    End Class


End Class

