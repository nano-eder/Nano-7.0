Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Namespace wsNFeConsulta4
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"), _
    System.Diagnostics.DebuggerStepThroughAttribute(), _
    System.ComponentModel.DesignerCategoryAttribute("code"), _
    System.Web.Services.WebServiceBindingAttribute(Name:="NFeConsultaProtocolo4ServiceBinding", [Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4")> _
    Partial Public Class NfeConsulta4

        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        Private nfeStatusServicoNFOperationCompleted As System.Threading.SendOrPostCallback
        Private useDefaultCredentialsSetExplicitly As Boolean
        Public Structure NumRecibo
            Dim Id As String
            Dim tpAmb As String
            Dim verAplic As String
            Dim chNFe As String
            Dim dhRecbto As String
            Dim digVal As String
            Dim cStat As String
            Dim xMotivo As String
            Dim nProt As String
            Dim XmlRecibo As String
        End Structure
        Public Sub New(ByVal urlRef As String)
            Me.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12
            Me.Url = urlRef
            If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
                Me.UseDefaultCredentials = True
                Me.useDefaultCredentialsSetExplicitly = False
            Else
                Me.useDefaultCredentialsSetExplicitly = True
            End If
        End Sub

        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set(ByVal value As String)
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) AndAlso (Me.IsLocalFileSystemWebService(value) = False)) Then
                    MyBase.UseDefaultCredentials = False
                End If
                MyBase.Url = value
            End Set
        End Property

        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set(ByVal value As Boolean)
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = True
            End Set
        End Property

        ''' <remarks/>
        Public Event nfeConsultaNFCompleted As nfeConsultaNFCompletedEventHandler

        ''' <remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4/nfeConsultaNF", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)> _
        Public Function nfeConsultaNF(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4")> ByVal nfeDadosMsg As System.Xml.XmlNode) As <System.Xml.Serialization.XmlElementAttribute("nfeResultMsg", [Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4")> System.Xml.XmlNode
            Dim results As Object() = Me.Invoke("nfeConsultaNF", New Object() {nfeDadosMsg})
            Return DirectCast(results(0), System.Xml.XmlNode)
        End Function

        ''' <remarks/>
        Public Sub nfeConsultaNFAsync(ByVal nfeDadosMsg As System.Xml.XmlNode)
            Me.nfeConsultaNFAsync(nfeDadosMsg)
        End Sub

        Private Sub OnnfeConsultaNFOperationCompleted(ByVal arg As Object)
            If arg IsNot Nothing Then
                'nfeAutorizacaoLoteCompleted 
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = DirectCast(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                'nfeAutorizacaoLoteCompleted(Me, New nfeAutorizacaoLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.[Error], invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        ''' <remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub

        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) OrElse (url = String.Empty)) Then
                Return False
            End If
            Dim wsUri As New System.Uri(url)
            If ((wsUri.Port >= 1024) AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return True
            End If
            Return False
        End Function
    End Class

    ''' <remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1"), _
    System.SerializableAttribute(), _
    System.Diagnostics.DebuggerStepThroughAttribute(), _
    System.ComponentModel.DesignerCategoryAttribute("code"), _
    System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsultaProtocolo4"), _
    System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsultaProtocolo4", IsNullable:=False)> _
    Partial Public Class nfeCabecMsg

        'Inherits System.Web.Services.Protocols.SoapHeader

        'Private cUFField As String

        'Private versaoDadosField As String

        'Public Property cUF() As String
        'Get
        'Return Me.cUFField
        'End Get
        'Set(value As String)
        'Me.cUFField = value
        'End Set
        'End Property
        '  Public Property versaoDados() As String
        'Get
        'Return Me.versaoDadosField
        'End Get
        'Set(value As String)
        'Me.versaoDadosField = value
        'End Set
        'End Property
    End Class

    ''' <remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")> _
    Public Delegate Sub nfeConsultaNFCompletedEventHandler(ByVal sender As Object, ByVal e As nfeConsultaNFCompletedEventArgs)

    ''' <remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"), _
    System.Diagnostics.DebuggerStepThroughAttribute(), _
    System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class nfeConsultaNFCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results As Object()

        Friend Sub New(ByVal results As Object(), ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        ''' <remarks/>
        Public ReadOnly Property Result() As System.Xml.XmlNode
            Get
                Me.RaiseExceptionIfNecessary()
                Return DirectCast(Me.results(0), System.Xml.XmlNode)
            End Get
        End Property
    End Class
End Namespace
