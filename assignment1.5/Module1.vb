Module Module1

    Sub Main()
        Dim inputstr As String
        Dim i As Integer
        Dim VC As Integer
        Dim cmpchar As Char
        Dim vowels As String
        vowels = "aeiou"

        inputstr = ""
        i = 0
        VC = 0
        cmpchar = ""

        Console.WriteLine("Enter the string : ")
        inputstr = Console.ReadLine()
        For i = 1 To Len(inputstr)
            cmpchar = Mid(inputstr, i, 1)
            If InStr(vowels, cmpchar) Then
                VC = VC + 1

            End If
        Next
        Console.WriteLine("TOTAL NUMBER OF VOWELS : " & VC)
        Console.ReadKey()

    End Sub

End Module
