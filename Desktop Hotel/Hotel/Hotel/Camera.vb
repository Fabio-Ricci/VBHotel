Imports System.Runtime.InteropServices


Public Class Camera
    ' declaração de constantes
    ' constantes AVICAP
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    ' constantes do Windows
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    ' variaveis de uso global
    Private iDevice As Integer = 0 ' id do dispositivo
    Private hWnd As Integer        ' handle da janela do visualizador
    Private qtdDisp As Integer


    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
       (ByVal hwnd As Integer, ByVal wMsg As Integer, _
        ByVal wParam As Integer, _
       <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" _
        (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, _
         ByVal x As Integer, ByVal y As Integer, _
         ByVal cx As Integer, ByVal cy As Integer, _
         ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Sub enviarMensagem()
        SendMessage(hWnd, WM_CAP_EDIT_COPY, 0, 0)
    End Sub

    Public Sub enviarMensagemDriver()
        SendMessage(hWnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
    End Sub

    ' declaração das API do Windows para o capAVI
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" _
        (ByVal wDriver As Short, _
         ByVal lpszName As String, ByVal cbName As Integer, _
         ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean

    Public Sub destruirjanela()
        DestroyWindow(hWnd)
    End Sub

    Public Sub abreVideo(pbFoto As PictureBox)
        Dim iHeight As Integer = pbFoto.Height
        Dim iWidth As Integer = pbFoto.Width

        hWnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, _
                0, 0, 640, 200, pbFoto.Handle.ToInt32, 0)

        If SendMessage(hWnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            ' define a escala do preview
            SendMessage(hWnd, WM_CAP_SET_SCALE, True, 0)
            ' define a taxa de visualização 
            SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            ' habilita para a pre-visualização
            SendMessage(hWnd, WM_CAP_SET_PREVIEW, True, 0)
            ' redimensiona a janela para caber no picturebox
            SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, _
                         iWidth, iHeight, SWP_NOMOVE Or SWP_NOZORDER)
        End If
    End Sub


    Public Sub CarregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorno As Boolean
        qtdDisp = 0
        Do
            bRetorno = capGetDriverDescriptionA(qtdDisp, strNome, 100, strVer, 100)
            qtdDisp += 1
        Loop Until bRetorno = False
    End Sub


    Public Function getQtdDispositivos() As Integer
        Return Me.qtdDisp
    End Function

End Class


