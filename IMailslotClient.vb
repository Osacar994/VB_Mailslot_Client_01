Public Interface IMailslotClient

    Function Connect() As Boolean
    Sub Disconnect()
    Sub Write(ByVal lpszMessage As String)

End Interface
