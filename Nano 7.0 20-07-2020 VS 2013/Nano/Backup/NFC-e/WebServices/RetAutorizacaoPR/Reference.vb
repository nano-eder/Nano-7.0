﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.8009
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by wsdl, Version=2.0.50727.3038.
'
Namespace wsNFeRetAutorizacaoPR

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="NfeRetAutorizacaoSoap12", [Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3")> _
    Partial Public Class NfeRetAutorizacao3
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private nfeCabecMsgValueField As nfeCabecMsg

        Private nfeRetAutorizacaoLoteOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New(ByVal xUrl As String)
            MyBase.New()
            Me.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12
            Me.Url = xUrl   '"https://nfe.fazenda.sp.gov.br/ws/nferetautorizacao.asmx"
        End Sub

        Public Property nfeCabecMsgValue() As nfeCabecMsg
            Get
                Return Me.nfeCabecMsgValueField
            End Get
            Set(ByVal value As nfeCabecMsg)
                Me.nfeCabecMsgValueField = value
            End Set
        End Property

        '''<remarks/>
        Public Event nfeRetAutorizacaoLoteCompleted As nfeRetAutorizacaoLoteCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.InOut), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3/NfeRetAutorizacaoLote", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)> _
        Public Function nfeRetAutorizacao(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3")> ByVal nfeDadosMsg As System.Xml.XmlNode) As <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3")> System.Xml.XmlNode
            Dim results() As Object = Me.Invoke("nfeRetAutorizacao", New Object() {nfeDadosMsg})

            Return CType(results(0), System.Xml.XmlNode)
        End Function

        '''<remarks/>
        Public Function BeginnfeRetAutorizacaoLote(ByVal nfeDadosMsg As System.Xml.XmlNode, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("nfeRetAutorizacao", New Object() {nfeDadosMsg}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndnfeRetAutorizacaoLote(ByVal asyncResult As System.IAsyncResult) As System.Xml.XmlNode
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Xml.XmlNode)
        End Function

        '''<remarks/>
        Public Overloads Sub nfeRetAutorizacaoLoteAsync(ByVal nfeDadosMsg As System.Xml.XmlNode)
            Me.nfeRetAutorizacaoLoteAsync(nfeDadosMsg, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub nfeRetAutorizacaoLoteAsync(ByVal nfeDadosMsg As System.Xml.XmlNode, ByVal userState As Object)
            If (Me.nfeRetAutorizacaoLoteOperationCompleted Is Nothing) Then
                Me.nfeRetAutorizacaoLoteOperationCompleted = AddressOf Me.OnnfeRetAutorizacaoLoteOperationCompleted
            End If
            Me.InvokeAsync("nfeRetAutorizacao", New Object() {nfeDadosMsg}, Me.nfeRetAutorizacaoLoteOperationCompleted, userState)
        End Sub

        Private Sub OnnfeRetAutorizacaoLoteOperationCompleted(ByVal arg As Object)
            If (Not (Me.nfeRetAutorizacaoLoteCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent nfeRetAutorizacaoLoteCompleted(Me, New nfeRetAutorizacaoLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetAutorizacao3", IsNullable:=False)> _
    Partial Public Class nfeCabecMsg
        Inherits System.Web.Services.Protocols.SoapHeader

        Private versaoDadosField As String

        Private cUFField As String


        Private anyAttrField() As System.Xml.XmlAttribute



        '''<remarks/>
        Public Property versaoDados() As String
            Get
                Return Me.versaoDadosField
            End Get
            Set(ByVal value As String)
                Me.versaoDadosField = value
                '   Me.RaisePropertyChanged("versaoDados")
            End Set
        End Property

        '''<remarks/>
        Public Property cUF() As String
            Get
                Return Me.cUFField
            End Get
            Set(ByVal value As String)
                Me.cUFField = value
                '       Me.RaisePropertyChanged("cUF")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()> _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set(ByVal value As System.Xml.XmlAttribute())
                Me.anyAttrField = value
                '  Me.RaisePropertyChanged("AnyAttr")
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub nfeRetAutorizacaoLoteCompletedEventHandler(ByVal sender As Object, ByVal e As nfeRetAutorizacaoLoteCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class nfeRetAutorizacaoLoteCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As System.Xml.XmlNode
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), System.Xml.XmlNode)
            End Get
        End Property
    End Class
End Namespace
