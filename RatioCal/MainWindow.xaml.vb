Imports System.Windows.Threading

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim num1 As Integer
        Dim num2 As Integer
        num2 = TB_r1.Text.ToString

        If Integer.TryParse(TB_w.Text, num1) Then
            Dim result As Double = num1 / num2
            TB_h.Text = result * 9
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

    Private Sub Button_BG(sender As Object, e As RoutedEventArgs)
        If IMG_bg.Visibility = Visibility.Visible Then
            IMG_bg.Visibility = Visibility.Hidden
        Else
            IMG_bg.Visibility = Visibility.Visible
        End If

    End Sub

    Private timer As New DispatcherTimer()

    Public Sub New()
        InitializeComponent()

        timer.Interval = TimeSpan.FromTicks(1)
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Dim num1 As Integer
        Dim num2 As Integer
        num2 = TB_r1.Text.ToString

        If Integer.TryParse(TB_w.Text, num1) Then
            Dim result As Double = num1 / num2
            If Not String.IsNullOrWhiteSpace(TB_r2.Text) AndAlso IsNumeric(TB_r2.Text) Then
                TB_h.Text = (result * Double.Parse(TB_r2.Text)).ToString()
            Else
                TB_h.Text = "Yaaaaaaah"
            End If
        Else
            TB_h.Text = "Yaaaaaaah"
        End If
    End Sub

End Class