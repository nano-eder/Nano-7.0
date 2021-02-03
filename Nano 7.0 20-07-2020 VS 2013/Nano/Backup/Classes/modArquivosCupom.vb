Module modArquivosCupom

    '************************************************************************************************************
    'PARAMETRO QUE INDICA O USO OU N�O DE CUPOM FISCAL
    Public ImprimirCupomFiscal As Boolean = False
    Public ClienteUsaTEF As Boolean = False
    Public CaminhoDaPastaMestra As String = ""




    '************************************************************************************************************
    'PARAMETROS QUE RECEBEM OS DADOS PARA CADA TIPO DE REGISTRO PARA EXPORTA��O PARA A EMISS�O DE CUPOM FISCAL

    'EXPLICA��O PARA NOMEA��O DO PARAMETROS
    'EX: RMREG1
    'RM = QUER DIZER "ARQUIVO DE REMESSA"
    'REG1 = QUER DIZER A QUAL REGISTRO PERTENCE ESSE PARAMETRO, NO CASO, REGISTRO N� 1
    'RMREG1 = ARQUIVO DE REMESSA REGISTRO 1

    Public RMREG1 As String ' � CARREGADO NA FUN��O "EscreveArquivoCupom"
    Public RMREG2 As String ' � CARREGADO NO CADASTRO DE USU�RIO
    Public RMREG3 As String ' � CARREGADO NA FUN��O "EscreveArquivoCupom", REGISTRO DE VENDEDOR
    Public RMREG4 As String ' � CARREGADO NO CADASTRO DE CLIENTE, REGISTRO DE CLIENTE
    Public RMREG5 As String ' � CARREGADO NA clsGerarArqs, REGISTRO DE PRODUTO
    Public RMREG6 As String ' � CARREGADO NA clsGerarArqs, REGISTRO DE PRE�O DE PRODUTO
    Public RMREG7 As String ' � CARREGADO NA clsGerarArqs, REGISTRO DO DAV, TOTAIS DO PEDIDO
    Public RMREG8 As String ' � CARREGADO NA clsGerarArqs, REGISTRO DO DAV, ITENS DO PEDIDO
    Public RMREG9 As String ' � CARREGADO NA clsGerarArqs, REGISTRO DE FORMA DE PAGAMENTO
    Public RMREG34 As String
    Public RMREG99 As String '� CARREGADO NA clsGerarArqs, FINALIZA O ARQUIVO E INFORMA QUANTOS REGISTROS GERADOS

End Module
