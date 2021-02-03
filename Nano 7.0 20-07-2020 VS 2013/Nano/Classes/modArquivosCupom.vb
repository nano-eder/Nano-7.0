Module modArquivosCupom

    '************************************************************************************************************
    'PARAMETRO QUE INDICA O USO OU NÃO DE CUPOM FISCAL
    Public ImprimirCupomFiscal As Boolean = False
    Public ClienteUsaTEF As Boolean = False
    Public CaminhoDaPastaMestra As String = ""




    '************************************************************************************************************
    'PARAMETROS QUE RECEBEM OS DADOS PARA CADA TIPO DE REGISTRO PARA EXPORTAÇÃO PARA A EMISSÃO DE CUPOM FISCAL

    'EXPLICAÇÃO PARA NOMEAÇÃO DO PARAMETROS
    'EX: RMREG1
    'RM = QUER DIZER "ARQUIVO DE REMESSA"
    'REG1 = QUER DIZER A QUAL REGISTRO PERTENCE ESSE PARAMETRO, NO CASO, REGISTRO Nº 1
    'RMREG1 = ARQUIVO DE REMESSA REGISTRO 1

    Public RMREG1 As String ' É CARREGADO NA FUNÇÃO "EscreveArquivoCupom"
    Public RMREG2 As String ' É CARREGADO NO CADASTRO DE USUÁRIO
    Public RMREG3 As String ' É CARREGADO NA FUNÇÃO "EscreveArquivoCupom", REGISTRO DE VENDEDOR
    Public RMREG4 As String ' É CARREGADO NO CADASTRO DE CLIENTE, REGISTRO DE CLIENTE
    Public RMREG5 As String ' É CARREGADO NA clsGerarArqs, REGISTRO DE PRODUTO
    Public RMREG6 As String ' É CARREGADO NA clsGerarArqs, REGISTRO DE PREÇO DE PRODUTO
    Public RMREG7 As String ' É CARREGADO NA clsGerarArqs, REGISTRO DO DAV, TOTAIS DO PEDIDO
    Public RMREG8 As String ' É CARREGADO NA clsGerarArqs, REGISTRO DO DAV, ITENS DO PEDIDO
    Public RMREG9 As String ' É CARREGADO NA clsGerarArqs, REGISTRO DE FORMA DE PAGAMENTO
    Public RMREG34 As String
    Public RMREG99 As String 'É CARREGADO NA clsGerarArqs, FINALIZA O ARQUIVO E INFORMA QUANTOS REGISTROS GERADOS

End Module
