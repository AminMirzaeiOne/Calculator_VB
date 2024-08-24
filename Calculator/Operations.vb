Module Operations
    Enum OperationStatus
        None
        Plus
        Minus
        Divide
        Multiply
    End Enum
    Public Property Status As Calculator.Operations.OperationStatus = OperationStatus.None
    Public Sub Plus()
        Calculator.Operations.Status = OperationStatus.Plus

    End Sub

    Public Sub Minus()
        Calculator.Operations.Status = OperationStatus.Minus
    End Sub

    Public Sub Divide()
        Calculator.Operations.Status = OperationStatus.Divide
    End Sub

    Public Sub Multiply()
        Calculator.Operations.Status = OperationStatus.Multiply
    End Sub

End Module
