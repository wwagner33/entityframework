'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace AdvancedPatternsVB

    Partial Public Class OfficeMf
        Public Property Number As String
        Public Property BuildingId As System.Guid
    
        Private _Description As String
        Friend Property Description As String
            Get
                Return _Description
            End Get
            Private Set(ByVal value As String)
                _Description = value
            End Set
        End Property
    
        Private Property Building As BuildingMf
    
        Private _WhiteBoards As ICollection(Of WhiteboardMf) = New HashSet(Of WhiteboardMf)
        Public Overridable Property WhiteBoards As ICollection(Of WhiteboardMf)
            Friend Get
                Return _WhiteBoards
            End Get
            Set(ByVal value As ICollection(Of WhiteboardMf))
                _WhiteBoards = value
            End Set
        End Property
    
    End Class

End Namespace
