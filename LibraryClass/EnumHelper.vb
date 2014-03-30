Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices

<AttributeUsage(AttributeTargets.Field)>
Public Class EnumDescriptionAttribute : Inherits Attribute

    Property Description As String

    Public Sub New(ByVal description As String)
        Me.Description = description
    End Sub

End Class

Public Module EnumHelper

    <Extension()> _
    Public Function GetEnumDescription(Of TEnum)(enumObj As TEnum) As String
        Dim fi As FieldInfo = enumObj.GetType().GetField(enumObj.ToString())

        Dim attribute As EnumDescriptionAttribute = fi.GetCustomAttributes(GetType(EnumDescriptionAttribute), False).SingleOrDefault()

        Return If(attribute IsNot Nothing, attribute.Description, enumObj.ToString())
    End Function
End Module