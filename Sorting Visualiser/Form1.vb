Public Class Form1
    Dim nums(40) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 1 To 40
            nums(i) = i
        Next

        Display()

    End Sub

    Private Sub Display()
        LstBx.Items.Clear()
        For i = 1 To 40
            LstBx.Items.Add(nums(i))
        Next
    End Sub

    Private Sub Btn_Rand_Click(sender As Object, e As EventArgs) Handles Btn_Rand.Click

        Dim max_index As Integer = (nums.Length - 1)
        Dim j As Integer
        Dim rnd As New Random

        For i = 1 To (max_index)

            'Get a radonom index
            j = rnd.Next(1, max_index)

            Dim temp As Integer = nums(i)
            nums(i) = nums(j)
            nums(j) = temp
        Next
        Display()

    End Sub

    Private Sub Btn_BubbleSort_Click(sender As Object, e As EventArgs) Handles Btn_BubbleSort.Click

        Dim comparisons As Integer = 0
        Dim count As Integer = nums.Length - 1
        Dim temp As Integer
        While 1 <> count

            For i = 1 To (count - 1)
                If nums(i) > nums(i + 1) Then
                    temp = nums(i)
                    nums(i) = nums(i + 1)
                    nums(i + 1) = temp

                Else
                    Continue For
                End If
                comparisons += 1
            Next
            count -= 1

        End While
        Display()
        LstBx.Items.Add("Comparisons: " + Convert.ToString(comparisons))

    End Sub

    Private Sub Btn_SelectSort_Click(sender As Object, e As EventArgs) Handles Btn_SelectSort.Click

        Dim min_index As Integer = 1
        Dim temp As Integer
        Dim comparisons As Integer = 0
        Dim small As Integer
        Dim small_index As Int16

        'Make a loop that loops over from Start to End, then next loop is from start + 1 to the end. 
        'Make a negative loop.
        '{
        'Find the smallest value of that list, then swap it with the start value. 
        '}
        While min_index <= nums.Length - 1
            small = 9999
            For i = min_index To nums.Length - 1
                If nums(i) < small Then

                    small = nums(i)
                    small_index = i
                End If
                comparisons += 1
            Next

            temp = nums(min_index)
            nums(min_index) = nums(small_index)
            nums(small_index) = temp
            min_index += 1

        End While
        Display()
        LstBx.Items.Add("Comparisons: " + Convert.ToString(comparisons))
    End Sub
End Class
