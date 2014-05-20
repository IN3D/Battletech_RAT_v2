Public Class Dice

    Property dice1 As Integer
    Property dice2 As Integer

    ' default constructor
    Public Sub New()

        Me.dice1 = 0
        Me.dice2 = 0
    End Sub

    ' standard constructor
    Public Sub New(ByVal value1 As Integer, ByVal value2 As Integer)

        Me.dice1 = value1
        Me.dice2 = value2
    End Sub

    ' deep copy constructor
    Public Sub New(ByVal dice As Dice)

        Me.dice1 = dice.dice1
        Me.dice2 = dice.dice2
    End Sub
End Class
