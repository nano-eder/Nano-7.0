Public Class clsHistorico
    Public Shared Function Historico() As Boolean

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.5.3 - 15/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "E-mail - Inclus�o da op��o de inserir assinatura;" & vbCrLf
        HistoricoVersao &= "E-mail - Inclus�o da op��o de inserir imagem no corpo do e-mail;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no layout;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Ajuste n�o mostar usu�rios inativo;" & vbCrLf
        HistoricoVersao &= "Venda - Total pend�ncia do cliente na impress�o como op��o na configura��o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.5.2 - 15/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Bloqueio da exclus�o do cliente consumidor;" & vbCrLf
        HistoricoVersao &= "Cadastro Ve�culo - Ajuste na altera��o de um ve�culo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da coluna Qtd M�xima;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do campo desconto por Valor R$;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o da coluna Qtd M�xima;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na venda com cr�dito do cliente;" & vbCrLf
        HistoricoVersao &= "Venda - Impress�o do cupom da venda com o total de pend�ncia do cliente;" & vbCrLf
        HistoricoVersao &= "Venda - Impress�o do cupom da venda com o valor da parcela do cart�o parcelado;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da impress�o do vale presente;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da consulta da tabela de pre�o do produto selecionado;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste verficar se o pedido j� foi faturado antes de alterar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ao buscar o produto preencher o campo valor custo para  nivel de usu�rio administrador;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Ao buscar o produto mostrar o valor do produto de acordo com a tabela de pre�o selecionada;" & vbCrLf
        HistoricoVersao &= "Devolu��o - Inclus�o do n�mero da venda no relat�rio de devolu��o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.5.1 - 13/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da coluna auxiliar onde salva o nome do computador, data e hora;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Ajuste na tabela de pre�o;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Inclus�o do operador ao salvar o pedido ou a venda;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna operador;" & vbCrLf
        HistoricoVersao &= "Relat�rio Lucro - Inclus�o da coluna operador;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Inclus�o da coluna operador;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do campo Qtde M�xima;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao cancelar a entrada de nf;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rio - Ajuste ao bloquear a tela de venda;" & vbCrLf
        HistoricoVersao &= "MDI - Ajuste ao enviar email no canal;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.5.0 - 07/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Relat�rio Lucro - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Tabela IBPT - Atualiza��o da Tabela IBPT;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da impress�o de etiqueta ZT 230 Dupla (Zebra)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.9 - 30/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido Itens - Ajuste na coluna Obs;" & vbCrLf
        HistoricoVersao &= "Boleto Cobran�a - Ajuste no boleto de cobran�as da TI7;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Op��o de informa a Raz�o social se estiver preenchido o nome fantasia na configura��o;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste no c�digo do produto ao transformar pedido em venda;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da quantidade de vezes do cart�o no cupom da venda;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Ajustes ao abrir a tela por outra tela ex. entrada nf;" & vbCrLf
        HistoricoVersao &= "Sistema - Padronizar as casas decimais de acordo com o configurado;" & vbCrLf
        HistoricoVersao &= "Relatorio Transfer�ncia - Corrigido filtro por per�odo;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste ao calcular pessoas na mesa;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Inclus�o da coluna KM Entrada (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "MDI - Inclus�o da coluna KM Entrada no pedidos pendentes (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Relat�rio Entrada NF - Inclus�o da coluna Chave (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no nome dos campos para Nano Tipo 2 ex. Setor para Marca;" & vbCrLf
        HistoricoVersao &= "Relat�rio Produtos em Falta - Inclus�o da coluna Aplica��o (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Relat�rio Sat - Ajuste no calculo total j� descontar o valor dos cupons cancelados;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna Sat, se foi emitido um sat da venda ou n�o;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Ajuste no bloqueio de funcion�rio;" & vbCrLf
        HistoricoVersao &= "Caixa - Ao excluir uma movimenta��o do caixa e a mesma for transfer�ncia banc�ria excluir tamb�m a transfer�ncia banc�ria;" & vbCrLf
        HistoricoVersao &= "Log - Inclus�o do registro de exclus�o de uma movimenta��o banc�ria." & vbCrLf
        'HistoricoVersao &= "Ajuste no regustro nano email" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.8 - 24/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o da tabela de pre�o na comanda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na tabela de pre�o;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na tabela de pre�o." & vbCrLf
        'HistoricoVersao &= "Ajuste no regustro nano email" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.7 - 22/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajuste ao excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.6 - 17/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.5 - 15/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclus�o do Sat Control Id;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclus�o do Sat Custom;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no desconto por item por valor;" & vbCrLf
        HistoricoVersao &= "Sistema - Atualizar sistema sem arquivo;" & vbCrLf
        'HistoricoVersao &= "Caixa - Abrir Fechar Caixa;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Inclus�o da coluna c�digo produto;" & vbCrLf
        HistoricoVersao &= "Pedido - N�o mostrar campo data com 01/01/1900;" & vbCrLf
        HistoricoVersao &= "Consulta de Produto - Ajustar campo e coluna com casas descimais de acordo com o configurado no sistema;" & vbCrLf
        HistoricoVersao &= "Relat�rio Contas Recebidas - Impress�o com valor da parcela e valor recebido;" & vbCrLf
        HistoricoVersao &= "Relat�rio Gr�fico Vendedor - Inclus�o do valor total da venda;" & vbCrLf
        'HistoricoVersao &= "SAT Fiscal - Ajuste na descricao do produto pular linha e nao cortar;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################


        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.4 - 27/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Ajuste na coluna C�digo NF-e;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste desconto maximo por item com senha administrador." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.3 - 21/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste impress�o com unidade medida hora;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste na coluna c�digo do pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.2 - 20/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste campo VFCPST." & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Comanda bloqueio da impress�o automatica para cliente do Marcelo" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.1 - 19/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste comanda." & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste no nome da coluna juros para vlr. c/ juros R$;" & vbCrLf
        HistoricoVersao &= "Relat�rio Sat - Ajuste na coluna valor desconto;" & vbCrLf
        HistoricoVersao &= "MDI - Ajustes na impress�o do pedido pelo MDI." & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Comanda bloqueio da impress�o automatica para cliente do Marcelo" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.4.0 - 29/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da op��o Painel Pre�o KG;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste comanda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.9 - 29/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o dos campos Frete, Outras Despesas e Seguro nos itens." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.8 - 23/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no calculo de ipi;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no calculo de convers�o;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do campo VFCPST (Valor do Fundo de combate a pobreza)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.7 - 16/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impress�o campo complemento;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na impress�o com troca;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.6 - 14/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajuste nas colunas da grid." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.5 - 08/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.4 - 06/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes no boleto sicred, remessa e retorno;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajustes no calculo, no tipo desconto total;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do CPF/CNPJ na impress�o do pedido paisagem." & vbCrLf
        'HistoricoVersao &= "Ajuste Log filtro estoque somado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.3 - 09/03/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "MDI - Ajustes na impress�o do pedido pelo MDI." & vbCrLf
        'HistoricoVersao &= "Ajuste Log filtro estoque somado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.2 - 02/03/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.1 - 26/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.3.0 - 26/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da impress�o tipo paisagem;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da Unidade Medida na impress�o tipo paisagem;" & vbCrLf
        HistoricoVersao &= "Venda/Pedido- Inclus�o do campo frete;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Inclus�o da coluna Frete;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna Frete;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Ajustes na aba complementar;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do campo Qtd Embalagem." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.9 - 17/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da impress�o padr�o para o commerce;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes na impress�o padr�o para o automotivo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.8 - 10/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda/Pedido - Ajuste na coluna N� NF-e;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.7 - 07/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda/Pedido - Inclus�o da coluna N� NF-e;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rios - Ajustes no bloqueios;" & vbCrLf
        'HistoricoVersao &= "comserv no relatorio de venda;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.6 - 04/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Ajuste config coluna inexistente;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.5 - 30/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Ajuste config coluna inexistente;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.4 - 30/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da op��o de calcular ou n�o o impostos nos produtos;" & vbCrLf
        'HistoricoVersao &= "Venda ajuste na comissao quando inseri pelo valor;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.3 - 27/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Ajustes no bloqueio do cadastro de funcion�rio;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do campo cpf/cnpj do cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impress�o com imagem;" & vbCrLf
        HistoricoVersao &= "Invent�rio - Inclus�o da coluna fornecedor, nos produtos n�o adicionados;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do campo Total Produtos R$;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes no PIS/COFINS;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste no filtro de data no DAV." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.2 - 08/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes ao imprimir etiquetas com tamanho;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Ajuste na tabela preco verificar antes de salvar;" & vbCrLf
        'HistoricoVersao &= "Inclusao do tiponano na verificacao do cliente erasystems;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.1 - 06/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Ajuste no relat�rio quando cliente estiver configurado como multiloja;" & vbCrLf
        HistoricoVersao &= "Conta Receber/Pagar - Altualizar grid ap�s uma exclus�o." & vbCrLf
        HistoricoVersao &= "Conta Receber/Pagar - Ajustes na exclus�o." & vbCrLf
        'HistoricoVersao &= "Venda/Pedido - Ajuste no valor da entrada do pedido ao adicionar ou excluir um item;" & vbCrLf
        'HistoricoVersao &= "Forma Pagamento - Ajuste no campo banco;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.2.0 - 12/12/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Comanda - ao sair do campo comanda esta limpando o campo atendente;" & vbCrLf
        'HistoricoVersao &= "Comanda - nao esta mudando o cliente;" & vbCrLf
        'HistoricoVersao &= "Comanda - retirada e entrega nao esta mudando o cliente na grid;" & vbCrLf
        'HistoricoVersao &= "Comanda - erro na configuracao da grid;" & vbCrLf
        'HistoricoVersao &= "venda - esta conseguindo adicionar produto sem codigo pelo campo valor unitario;" & vbCrLf
        'HistoricoVersao &= "venda - ao colocar porcentagem de desconto e o mesmo nao calcular nao esta zerando;" & vbCrLf
        'HistoricoVersao &= "Pedido/Entradanf/transferencia - aumentar o campo tamanho;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.9 - 09/12/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Inclus�o do bloqueio de movimento banc�rio;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Inclus�o do bloqueio de transfer�ncia banc�ria;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Inclus�o do bloqueio de visualizar relat�rios de comiss�o;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes na consulta de servi�o para n�o verificar estoque zerado;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do motivo na exclus�o do pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do endere�o de entrega na impres�o do pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no modelo de impress�o com imagem do produto;" & vbCrLf
        HistoricoVersao &= "Contas Recebidas - Inclus�o da op��o de estornar varias contas recebidas;" & vbCrLf
        HistoricoVersao &= "Contas Pagas - Inclus�o da op��o de estornar varias contas pagas;" & vbCrLf
        HistoricoVersao &= "Recibo de Pagamento - Inclus�o da op��o para digitar o nome do funcionario ou fornecedor;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o do campo valor sem desconto na impress�o da venda." & vbCrLf
        'HistoricoVersao &= "Entrada NF - Inclus�o da op��o de aplica��o pela tela de cadastro de produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.8 - 18/11/2019"
        HistoricoVersao &= vbCrLf & vbCrLf

        HistoricoVersao &= "Comanda - Inclus�o da coluna observa��o na grid;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o do busca produto por (Descri��o, C�digo Interno, Grupo, Setor, Fabricante ou Obs);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do campo chave do xml;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no filtro de consulta dos pedidos;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o de um modelo de impress�o com imagem do produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o de endere�o para entrega na impress�o;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes na ordem dos campos utilizando a tecla TAB;" & vbCrLf
        If TipoNano = 5 Then
            HistoricoVersao &= "Comiss�o - Inclus�o da coluna placa e modelo do ve�culo;" & vbCrLf
            HistoricoVersao &= "Comiss�o - Inclus�o da coluna placa e modelo do ve�culo na impress�o;" & vbCrLf
        End If
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Conta Receber - Liberado a baixa parcial para as lojas CONSTRULAR e CONSTRU-NEI;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ajustes da quantidade por embalagem;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.7 - 14/10/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cliente - Inclus�o do cadastro de endere�o para entrega;" & vbCrLf
        HistoricoVersao &= "Produto - Inclus�o da quantidade por embalagem;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do valor total no visualizar;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o da coluna c�digo do pedido;" & vbCrLf
        HistoricoVersao &= "Contas Recebidas - Ajustes no titulo da impress�o;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no layout do cupom do pedido (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o da exclus�o de itens de forma padr�o da tela de venda;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Corre��o ao carregar coluna Observa��o;" & vbCrLf
        HistoricoVersao &= "MDI Todos Pedidos - Ajuste ao carregar placa e modelo;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da placa e modelo do ve�culo no cupom (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Pedido - Inclus�o da quantidade por embalagem;" & vbCrLf
        'HistoricoVersao &= "Cliente - Corre��o na consulta CPF;" & vbCrLf
        'HistoricoVersao &= "Banco - Inclus�o do BANCO SAFRA como op��o no cadastro;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.6 - 19/09/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Inclus�o do valor de venda na grid conforme tabela de pre�o;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do valor de venda na grid conforme tabela de pre�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Ajustes no filtro por itens;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Venda - Corre��o no cadastro de conta parcelada erro na coluna valorrecebido null;" & vbCrLf
        'HistoricoVersao &= "Produto - Remos�o da fun��o codigobarra na lojas caval�o, devido extrema lentid�o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.5 - 28/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes ao imprimir etiquetas;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ao puxar o produto cursor ir direto para o campo qtd;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do campo tipo de conta, custo fixo/vari�vel e centro de custo quando conter conta a pagar;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Inclus�o do bloqueio de data no caixa;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Inclus�o do bloqueio de desfaturar pedidos;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes na exclus�o;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do estorno no log;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes na exclus�o;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o do estorno no log;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da observa��o fixa no cupom;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da data retirada e data entrega no cupom;" & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Inclus�o da op��o de transfer�ncia entre bancos;" & vbCrLf
        HistoricoVersao &= "Cadastro/Consulta Produto - C�d. Similar podendo filtrar no meio da palavra/frase;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do Valor Total na impress�o;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da coluna c�digo interno e c�digo barra;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da coluna c�digo do pedido na consulta e na impress�o da venda, caso a venda seja vinculada ao pedido;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Inclus�o da pesquisa por Fam�lia;" & vbCrLf
        HistoricoVersao &= "Hist�rioco Cliente - Inclus�o do campo dias em atraso;" & vbCrLf
        HistoricoVersao &= "Funcion�rio - Inclus�o do campo comiss�o servi�o (Commerce);" & vbCrLf
        HistoricoVersao &= "E-mail - Inclus�o do campo c�pia na configura��o do e-mail;" & vbCrLf
        HistoricoVersao &= "PDV - Habilitar cadastro de transportadora (Nano PDV)." & vbCrLf

        'HistoricoVersao &= "Pedido - acrescimo no item colocando o sinal de menos;" & vbCrLf
        'HistoricoVersao &= "Fluxi Caixa - Saldo atual no config e no bloqueio usuario;" & vbCrLf
        'HistoricoVersao &= "Entrada NF - Etiqueta qtde, e estava abrindo ja com itens antigo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.4 - 26/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Cliente - Ajustes no hist�rico de vendas do cliente;" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclus�o da coluna loca��o na tela de venda e pedido;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o da coluna fam�lia;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao cancelar a entrada nf vinculada a conta a pagar." & vbCrLf
        'HistoricoVersao &= "TEF - ajustes;" & vbCrLf
        'HistoricoVersao &= "kit - ajustes botao montar somente no alterar;" & vbCrLf
        'HistoricoVersao &= "config - saldo caixa;" & vbCrLf
        'HistoricoVersao &= "Pedido - alterar cliente pela placa;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.3 - 19/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.2 - 15/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Inclus�o do n�mero da transfer�ncia na mensagem ao salvar ou transferir;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.1 - 14/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Ajustes tributa��o, inclus�o da op��o de inserir tributa��o para SAT e NF-e (SAT e NF-e);" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao selecionar varias parcelas para emiss�o de um unico boleto;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes no troco;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes ao inserir acr�scimo;" & vbCrLf
        HistoricoVersao &= "Comanda - Impress�o com identifica��o do atendente;" & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Ajustes casa decimal;" & vbCrLf
        HistoricoVersao &= "Campanha - Ajustes na campanha, op��o de inserir produtos em uma campanha lan�ada." & vbCrLf
        'HistoricoVersao &= "Construnei - Conta Receber - mensagem de valor diferente di recebido." & vbCrLf
        'HistoricoVersao &= "Construnei - Caixa - bloquear filtro caixa no bloqueio da data." & vbCrLf
        'HistoricoVersao &= "Criss - Nota Promissoria - EscPOS." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.1.0 - 10/07/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes Reimpress�o TEF para outras adquirintes;" & vbCrLf
        HistoricoVersao &= "Relat�rio Lucro - Ajustes na coluna Total R$ para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Comiss�o - Ajustes na comiss�o para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes no relat�rio de nfc-e na coluna Total R$ para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes na configura��o do boleto;" & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes na emiss�o do boleto;" & vbCrLf
        HistoricoVersao &= "Produto - Ajustes ao duplicar um produto;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao excluir ou estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da data atual no conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Inclus�o da configura��o de casas decimais;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no campo acr�scimo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.9 - 10/07/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Ajustes para diminuir o tempo ao abrir o fluxo de caixa;" & vbCrLf
        HistoricoVersao &= "Relat�rio Revis�o - Ajuste no filtro por data e placa (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ordenar Tipo de Conta por ordem alfab�tica;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o no erro ao tentar visualizar ou abrir uma promiss�ria sem ter selecionado um pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes data entrega e data retirada (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Relat�rio de Consumo - Inclus�o da coluna Grupo na pesquisa por produto;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes ao adicinar mais de uma qtd, ajuste vers�o anterior;" & vbCrLf
        HistoricoVersao &= "Kit - Ajustes ao montar um kit;" & vbCrLf
        HistoricoVersao &= "Gr�fico Consumo - Ajustes ao filtrar a data;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.8 - 13/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.7 - 11/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.6 - 11/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste ao digitar o ncm ja preenche os dados relacionados ao ncm ja cadastrado em outro produto;" & vbCrLf
        HistoricoVersao &= "Cadastro Ve�culo - Ajuste ao alterar uma placa (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclus�o do busca produto por (Descri��o, C�digo Interno, Grupo, Setor, Fabricante ou Obs);" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclus�o da op��o de adicionar a quantidade pela tela de consulta produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do tipo de produto Pe�a ou Servi�o (Nano Automotivo)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.5 - 27/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.4 - 27/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Op��o de agrupar valores das Entradas de NF dos fornecedores selecionados;" & vbCrLf
        HistoricoVersao &= "Relat�rio DRE - Ajuste nos valores dos dados do conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na op��o do vinculo funcion�rio/usu�rio;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Ao abrir o relat�rio traz somente os ultimos 30 dias, exceto tipo nano automotivo;" & vbCrLf
        HistoricoVersao &= "NANO - Inclus�o da aba Suporte;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Ajuste no layout;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.3 - 15/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.2 - 14/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o do CPF do cliente na impress�o do cupom n�o fiscal;" & vbCrLf
        HistoricoVersao &= "Relat�rio DRE Sint�tico - Ajuste no valor dos dados do conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na coluna Desconto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Giro - Inclus�o da coluna grupo do produto;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualiza��o da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.1 - 29/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Configura��o NFC-e - Ajuste na tela de configura��o;" & vbCrLf
        HistoricoVersao &= "Canal Era Systems - Inclus�o de mais um telefone Era Systems;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na coluna nome do produto na impress�o do pedido;" & vbCrLf
        HistoricoVersao &= "MDI Pedido Pendentes - Inclus�o da coluna Valor Custo para n�vel usu�rio administrador;" & vbCrLf
        HistoricoVersao &= "MDI Pedido Pendentes - Colunas Data Entrega e Data Retirada centralizadas;" & vbCrLf
        HistoricoVersao &= "Entrada NF / Produto - Ajuste ao cadastrar um produto novo pela tela de entrada nf, o mesmo estava sendo cadastrado sem unidade medida;" & vbCrLf
        HistoricoVersao &= "Ajustes Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 4.0.0 - 23/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio DRE - Ajuste no relat�rio;" & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Ajuste no bot�o filtrar;" & vbCrLf
        HistoricoVersao &= "Comiss�o - Ajuste na comiss�o venda com devolu��o;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o da op��o salvar motivo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.9 - 10/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste na consulta do pedido na tela de venda, n�o poder trazer pedidos ja faturados;" & vbCrLf
        HistoricoVersao &= "Comiss�o - Ajuste na comiss�o tipo nano 5 (automotivo);" & vbCrLf
        HistoricoVersao &= "Vender - Ajuste ao imprimir venda com devolu��o;" & vbCrLf
        HistoricoVersao &= "Descarte - Inclus�o da op��o de configura��o da grid;" & vbCrLf
        HistoricoVersao &= "Relat�rio Descarte - Inclus�o da op��o de configura��o da grid;" & vbCrLf
        HistoricoVersao &= "Relat�rio Descarte - Inclus�o das colunas Valor Total do produto e Funcion�rio no relat�rio de descarte;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao cadastrar o cliente e ve�culo pelo pedido tipo nano 5 (automotivo);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no bot�o Editar NF-e Entrada;" & vbCrLf
        HistoricoVersao &= "Movimenta��o Banc�rio - Ajuste no tipo receitas, lan�ar positivo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.8 - 01/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Vender - Ajuste na capacidade de caracteres no campo Tamanho;" & vbCrLf
        HistoricoVersao &= "Produto - Ajuste na capacidade de caracteres no campo C�d. Similar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no campo desconto por valor." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.7 - 25/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro/Consulta Produto - Ajuste no filtro do nome do produto, op��o de filtrar no meio da frase ou n�o;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no layout da grid Qtde e ajusto nos filtro da grid;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na fun��es/tribustos ao salvar tributa��o;" & vbCrLf
        HistoricoVersao &= "Pagamento - Inclus�o do recibo de pagamento e recebimento;" & vbCrLf
        HistoricoVersao &= "Pedido - Impress�o do cupom do pedido com os dados do ve�culo para tipo nano automotivo;" & vbCrLf
        HistoricoVersao &= "Pedido - Impress�o do cupom do pedido com hora;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao cadastrar um cliente pelo cadastro de pedido, puxar direto ao salvar;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na quantidade de pessoas na mesa ao vender;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o da coluna C�digo Interno e C�digo de Barras na consulta da Tabela de Pre�o." & vbCrLf
        'HistoricoVersao &= "Correcao relatorio funcionario" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.6 - 19/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.5 - 19/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Inclus�o da op��o de inserir produtos autom�tico;" & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Ajuste ao alterar transfer�ncia;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste ao abrir gaveta, op��o de abrir somente pelo computador onde est� a gaveta;" & vbCrLf
        HistoricoVersao &= "Forma de Pagamento - Ajuste nas formas de pagamento a prazo agora permite cadastrar com n�mero de dias zerado;" & vbCrLf
        HistoricoVersao &= "Pedido - Impress�o do pedido com entrada R$;" & vbCrLf
        HistoricoVersao &= "Pedido - Habilitado a op��o de maximizar a tela;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste na op��o de alterar pre�o custo no pedido;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Ajustes internos ao salvar o pedido de compra;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na capacidade de caracteres no campo Tamanho;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da Op��o vincular produto a um outro produto, quando abrir via xml;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Conta a Pagar e Conta a Receber na agenda no bloqueio de usu�rio;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Ajuste bloqueio Nfe;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Inclus�o do bloqueio do Kit." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.4 - 04/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio DRE - Ajuste ao carregar dados da venda;" & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Ajuste ao carregar o saldo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na capacidade de caracteres no campo C�d. Similar;" & vbCrLf
        HistoricoVersao &= "Cobran�a Era Systems - Agora permite atualizar o boleto vencido;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.3 - 18/02/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no leave do campo custo;" & vbCrLf
        'HistoricoVersao &= "Conta Receber - coluna recebimento e valor recebido no conta receber;" & vbCrLf
        HistoricoVersao &= "Cadastro Ve�culo - Ajuste no campo placa, inclus�o do novo modelo;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste hor�rio de ver�o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '#################################e##################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.2 - 04/02/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da Descri��o do C�digo ANP para emiss�o de NFC-e;" & vbCrLf
        HistoricoVersao &= "Login - Bloqueio da op��o de colar no campo senha;" & vbCrLf
        HistoricoVersao &= "Invent�rio - Ajuste a coluna qtde em estoque para estoque somando;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o da quantidade de pessoas na mesa ao finalizar a comanda;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o do campo observa��o;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na comanda ao finalizar a venda;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualiza��o da tabela IBPT." & vbCrLf
        'HistoricoVersao &= "Ajuste Relatorio customizado agrupar e somar valortotal agrupado." & vbCrLf
        'HistoricoVersao &= "Relatorio Giro trazer somente os produtos ativos." & vbCrLf
        'HistoricoVersao &= "Relatorio Consumo ajuste na tem desconto trazer o nome do produto pela tabela produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.1 - 22/01/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da etiqueta de promo��o;" & vbCrLf
        HistoricoVersao &= "Ajustes vers�o anterior." & vbCrLf
        'HistoricoVersao &= "Gaveta - Senha para abrir na reimpress�o;" & vbCrLf
        'HistoricoVersao &= "SAT - Tirar Try Cat;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.9.0 - 22/01/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o do campo C�digo Funcion�rio, para vincular o funcion�rio ao cliente, no Pedido;" & vbCrLf
        HistoricoVersao &= "Cupom n�o fiscal - Inclus�o do SubTotal;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da Loca��o por loja;" & vbCrLf
        HistoricoVersao &= "Dav - Inclus�o do valor total de vendas e valor total de itens da venda;" & vbCrLf
        HistoricoVersao &= "Ajustes no tipo nano 5 automotivo." & vbCrLf
        'HistoricoVersao &= "Gaveta - Senha para abrir na reimpress�o;" & vbCrLf
        'HistoricoVersao &= "SAT - Tirar Try Cat;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.9 - 18/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Giro 2 - Ajustes tipo de produtos;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste pagamento." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.8 - 13/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT FISCAL - Corre��o no CPF Destinatario do SAT Elgin;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao alterar um item no Pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Ajuste no em falta linha vermelha." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.7 - 12/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.6 - 10/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Pedido - Ajuste, ao salvar o carro ja puxar direto no pedido, foco na placa, inclus�o da coluna placa e modelo na consulta de pedido;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Comiss�o - Ajuste, somado por venda e inclus�o da coluna Cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste, removido bot�o vender na consulta do pedido;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Inclus�o do bloqueio do bot�o abrir gaveta;" & vbCrLf
        HistoricoVersao &= "TEF - Inclus�o da op��o de adquirente." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.5 - 21/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da coluna Porcentagem Comiss�o onde salva a porcentagem da comiss�o do funcion�rio;" & vbCrLf
        HistoricoVersao &= "TEF - Ajuste cancelamento e removido a op��o de abrir gaveta quando impresso o TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.4 - 21/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste QrCode;" & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Inclus�o da coluna Auxiliar onde salva o nome do computador, a data e a hora em que foi feito a transfer�ncia;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da coluna Auxiliar onde salva o nome do computador, a data e a hora em que foi feito o pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.3 - 05/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste hor�rio de ver�o;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Ajuste no bloqueio de usu�rio;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste campo desconto por item." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.2 - 29/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Agrupar produtos iguais;" & vbCrLf
        HistoricoVersao &= "Log - Altera��o no Pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.1 - 29/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.8.0 - 17/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.9 - 16/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste vers�o 4.0;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no desconto por item;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.8 - 15/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o do campo data da conta;" & vbCrLf
        HistoricoVersao &= "Relat�rio DRE - Ajuste no filtro por data da conta;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.7 - 01/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.6 - 14/08/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.5 - 13/08/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Pagamento - Ajuste nas casas decimais na taxa do cart�o;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Exclus�o dos produtos inativos da pesquisa tributos;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na tr�nsferencia de mesas;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste abrir arquivo XML;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.4 - 03/07/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do cadastro da unidade de medida;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.3 - 28/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.2 - 20/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "MDI - Inclus�o cadastro de computador;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o de status de pedido;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna comiss�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna lucro;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna margem;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.1 - 08/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o do extrado de caixa;" & vbCrLf
        HistoricoVersao &= "Cadastro Funcionario - Inclus�o do vinculo com o usuario;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da consulta tributa��o pelo NCM;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da op��o alterar valor na venda;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da op��o duplicar produto;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o da consulta assinatura;" & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.7.0 - 02/05/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes na entrada NF;" & vbCrLf
        HistoricoVersao &= "Caixa - Op��o de alterar a data;" & vbCrLf
        HistoricoVersao &= "Nano - Ajuste Balan�a." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.9 - 20/03/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes no estoque em:;" & vbCrLf
        HistoricoVersao &= "Cadastro de Receita - Ajustes ao salvar no cadastro de produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.8 - 12/03/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.7 - 28/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Ajuste;" & vbCrLf
        HistoricoVersao &= "Campanha - Op��o de excluir itens na campanha em andamento;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na tranfer�ncia de uma comanda pra outra." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.6 - 19/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior;" & vbCrLf
        HistoricoVersao &= "Nano - Inclus�o da impress�o para comanda via App." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.5 - 06/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da unidade medida metro quadrado (M2);" & vbCrLf
        HistoricoVersao &= "Nano - Ajuste banco parado;" & vbCrLf
        HistoricoVersao &= "Nano - Inclus�o do Relat�rio Customizado;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Impress�o via Esc Pos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.4 - 26/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.3 - 26/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Vers�o Anterior" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.2 - 25/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Nano - Inclus�o da comunica��o com a balan�a toledo;" & vbCrLf
        HistoricoVersao &= "Nano - Inclus�o da verifica��o do banco de dado parado;" & vbCrLf
        HistoricoVersao &= "Nano - Inclus�o do aviso nano;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o do envio autom�tico dos arquivos mensal ao email desejado;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Dav ao faturar manter o foco na linha de baixo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no hist�rio ordena��o da data;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - N�o excluir produto que esteja na campanha;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o da mensagem de produto inexistente, caso o produto nao esteja cadastrado;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na atualiza��o do custo no estoque por lote;" & vbCrLf
        HistoricoVersao &= "Descarte - Inclus�o do estorno;" & vbCrLf
        HistoricoVersao &= "Pedido - Op��o de impressao A4;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste no pagamento parcial, manter o vencimento;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajuste no pagamento parcial, manter o vencimento;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Ajuste no manter grid;" & vbCrLf
        HistoricoVersao &= "Invent�rio - Inclus�o do filtro." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.1 - 02/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Vendas - Ajuste no cancelamento do TEF;" & vbCrLf
        HistoricoVersao &= "Formas de Pagamento - Inclus�o da op��o usa TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.6.0 - 14/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueios Usu�rios - Inclus�o do cadastro de pedido, altera��o de pedido e consulta de pedido;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.9 - 13/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no Pesquisa Imp.;" & vbCrLf
        HistoricoVersao &= "Bloqueios Usu�rios - Inclus�o do cadastro de usu�rios;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impress�o do pedido sem valor;" & vbCrLf
        HistoricoVersao &= "Venda - Inserir senha ADMINISTRADOR ao excluir um item ou cancelar a venda se o usu�rio n�o for administrador;" & vbCrLf
        HistoricoVersao &= "Ajuste TEF" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.8 - 04/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior tributa��o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.7 - 30/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.6 - 29/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Ajuste busca CPF;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste tributa��o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.5 - 13/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Comanda - Inclus�o da columa Valor Total R$;" & vbCrLf
        HistoricoVersao &= "Cadastro Comanda - Inclus�o da op��o de inserir o produto diversos;" & vbCrLf
        HistoricoVersao &= "Relat�rio Gr�fico - Inclus�o do gr�fico por vendedor;" & vbCrLf
        HistoricoVersao &= "Relat�rio Gr�fico - Inclus�o do gr�fico produto por vendedor;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Inclus�o da coluna Data Ult. Venda por cliente;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na coluna Data." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.4 - 30/10/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste ao salvar tributa��o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna nome vendedor;" & vbCrLf
        HistoricoVersao &= "Ajuste TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.3 - 30/10/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Implementa��o do TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.2 - 20/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na tributa��o e no bot�o inserir para todos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.1 - 14/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.5.0 - 14/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na Aba Nfe/Sat Fiscal;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Hist�rico por per�odo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Manter grid na grid de qtde;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na entrada por xml, verificar codigo de barra adicional." & vbCrLf
        HistoricoVersao &= "Relat�rio Desempenho - Inclus�o do relat�rio de desempenho." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.9 - 04/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Tabela de pre�o padr�o por loja;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o do Relat�rio de Clientes;" & vbCrLf
        HistoricoVersao &= "SAT FIscal - Ordena��o das vendas na tela do DAV;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclus�o do SAT Epson." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.8 - 17/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.7 - 14/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da data que foi adicionado o produto;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.6 - 14/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do cadastro de c�digos de barras. Agora um produto pode ter mais de um c�digo de barras cadastrados;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclus�o das colunas Data Retirada e Data Entrega;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclus�o da op��o de ajustar o layout da grid;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o do nome fantasia do cliente no cupom n�o fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do nome fantasia do cliente no cupom n�o fiscal;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.5 - 02/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes, op��o de incluir mais de um sat de marcas diferentes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.4 - 25/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualiza��o da tabela IBPT;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no custo m�dio do produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.3 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no custo m�dio do produto;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.2 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Ao excluir um registro do caixa, foi inclu�do o valor do mesmo no log;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Comiss�o - Agora ser� carregado as informa��es do m�s vigente;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o de mensagem antes de fechar tela se a nota n�o tiver sido salva;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o de mensagem antes de abrir arquivo XML se a tela ja possuir produtos;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.1 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.4.0 - 26/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.9 - 20/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.8 - 19/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do hist�rico de ajuste para quantidade;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o da op��o para digitar o nome do cliente;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes na impress�o;" & vbCrLf
        HistoricoVersao &= "NFC-e - Inclus�o da Nota Fiscal de Consumidor Eletronica;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.7 - 07/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes calculo de capital;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o da impress�o de cupom;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes verifica��o para produto inativo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.6 - 25/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o 2� via do comprovante;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes calculo media custo;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da op��o para baixar xml da nota;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o verifica��o para produto inativo;" & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Inclus�o verifica��o para produto inativo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.5 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajustes diversos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.4 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajustes na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Giro 2 - Ajustes na ordena��o das colunas num�ricas;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do bot�o fonte para alterar a fonte da grid." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.3 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o do centro de custo na impress�o;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do centro de custo na impress�o;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o da op��o de imprimir o cupom sat;" & vbCrLf
        HistoricoVersao &= "Relat�rios - Inclus�o do per�odo no t�tulo;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ajustes na hora de vender direto estava com erro;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.2 - 03/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.1 - 02/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Imprimir direto;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no tamanho das colunas na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Lucro - Inclus�o das colunas N� Pedido e N� NFe ocultas;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.3.0 - 25/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.9 - 24/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o do campo loja para empresas multilojas;" & vbCrLf
        HistoricoVersao &= "Caixa - Ajuestes no relat�rio de Caixa Total." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.8 - 11/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da op��o de desconto no item por valor ou porcentagem;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o da Data Ult. Venda;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do filtro quantidade do estoque em determinada data, se o sistema for estoque somado;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do aviso se o produto for adicionado mais de uma vez;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o no codigo no cadastro de produto;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da coluna Valor Custo no hist�rico de Entrada NF;" & vbCrLf
        HistoricoVersao &= "Relat�rio Giro 2 - Ajuste na coluna Sa�da;" & vbCrLf
        HistoricoVersao &= "Tabela Pre�o - Corrigir valores automaicamente ao alterar o valor de custo do produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.7 - 27/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.6 - 27/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Salvar versao sat no sistema erasystems;" & vbCrLf
        HistoricoVersao &= "Receita/Kit - Corrigir auto numera��o do c�digo;" & vbCrLf
        HistoricoVersao &= "Configura��o - Op��o da observa��o do cliente no pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Ajuste na inscri��o estadual;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Verificar dados antes de gerar o cupom;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.5 - 20/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transfer�ncia - Corrigir arredondamento casa decimal;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Corrigir casa decimal;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.4 - 14/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Op��o de custo m�dio;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes no inserir produtos com quantidades zeradas;" & vbCrLf
        HistoricoVersao &= "Transfer�ncia de Produtos - Agora � permitido salvar, transferir, receber e devolver;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o da data na impress�o;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.3 - 06/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.2 - 01/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no acrescimo;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o da consulta de tabela de pre�o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.1 - 15/02/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da fun��o busca e remo��o automatica;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.2.0 - 06/02/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do campo C�digo Fornecedor;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.9 - 24/01/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio de Consumo - Inclus�o da coluna Codigo por Produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Consumo - Inclus�o da coluna Cidade por Cliente;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Lucro - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.8 - 17/01/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no acrescimo;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Corre��o no valor pago no pagamento de varias parcelas juntas." & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no bot�o abrir XML, na consulta do item;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualiza��o da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.7 - 20/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o do total de clientes cadastrados;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Inclus�o do total de fornecedores cadastrados;" & vbCrLf
        HistoricoVersao &= "Cadastro Funcion�rio - Inclus�o do total de funcion�rios cadastrados." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.6 - 20/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Op��o de agrupar ou n�o agrupar produtos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.5 - 12/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Corre��o bot�o calcular para coluna valor;" & vbCrLf
        HistoricoVersao &= "Caixa - Corre��o no bot�o calcular e na visualiza��o do relat�rio quando existia a palavra 'Troco';" & vbCrLf
        HistoricoVersao &= "Relat�rio Vendas - Corre��o no pre�o de custo para quem usa estoque por lote;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.4 - 07/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Movimento Banc�rio - Adicionado bot�o calcular para coluna valor;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes no Movimento Banc�rio ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Vers�o 3.1.3 - 30/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Corre��o da unidade de medida na venda e na impress�o da venda;" & vbCrLf
        HistoricoVersao &= "Caixa - Adicionado uma coluna com o nome do computador que foi feito a opera��o;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rio - Adicionado a op��o de bloquear os relat�rios de caixa." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.1.2 - 23/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ao pressionar F7 o cursor ser� direcionado para o campo CPF e n�o mais para o Nome do cliente, evitando assim que o usu�rio precise usar o mouse;" & vbCrLf
        HistoricoVersao &= "Venda - Adicionado atalhos para todas as fun��es na tela de Venda. Para os bot�es que n�o estiverem com o comando de atalho em sua descri��o, basta posicionar o cursor do mouse em cima para visualiz�-los;" & vbCrLf
        HistoricoVersao &= "Venda - Op��o de selecionar tabela de pre�o antes ou durante a venda. Basta pressionar F4;" & vbCrLf
        HistoricoVersao &= "Entrada de NF - Agora � poss�vel vincular o c�digo do fornecedor ao produto para que o sistema consiga identific�-lo pelo arquivo XML;" & vbCrLf
        HistoricoVersao &= "Comanda - Adicionado v�rios comandos de atalhos para as fun��es da tela;" & vbCrLf
        HistoricoVersao &= "Comanda - Ao clicar em Vender a tela de comanda n�o ir� mais fechar e ser� atualizada automaticamente." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.1.1 - 14/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.1.0 - 09/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Ajustes no Filtrar para coluna Fabricante." & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Inclus�o da coluna Fabricante;" & vbCrLf
        HistoricoVersao &= "Grafico Consumo - Inclus�o da op��o por pedido;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.9 - 31/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes na altera��o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.8 - 19/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Grafico - Inclus�o da op��o por pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes etiquetas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.7 - 17/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Log - Log no cancelamento de Entrada NF;" & vbCrLf
        HistoricoVersao &= "Log - Ajustes nos logs de altera��es de produto;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da etiqueta LB 1000;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no atualizar produtos em lojas sincronizadas;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no layout;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes ao desfaturar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Inclus�o das colunas Grupo e Setor;" & vbCrLf
        HistoricoVersao &= "Invent�rio - Inclus�o das colunas Grupo e Setor;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o do campo Contato;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da etiqueta caixa." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.6 - 06/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da coluna Val. Promo��o R$;" & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.5 - 03/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rio - Ajustes;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rio - Inclus�o da op��o bloquear bloqueio de usu�rio;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Campanha - Inclus�o do campo valor anterior para edi��o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.4 - 21/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Ajustes nos dados do cliente;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes no cadastro de produtos;" & vbCrLf
        HistoricoVersao &= "Ajustes no Layout." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.3 - 19/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.2 - 13/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.1 - 13/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido Compra - Abrir cadastro e consulta ao mesmo tempo;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclus�o do campo Em Pedido, para os produtos que est�o em pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na opcao de comanda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste ao inserir produtos pelo c�digo de barras gerados por balan�a;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        'HistoricoVersao &= "Locacao na impressao de pedido tipo nano 2." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 3.0.0 - 06/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o da coluna campanha, para os produtos que est�o em campanha;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o do per�odo na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Totais Somado - Inclus�o do per�odo na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Totais Detalhado - Inclus�o do per�odo na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Cat�es Somado - Inclus�o do per�odo na impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Cat�es Detalhado - Inclus�o do per�odo na impress�o;" & vbCrLf
        HistoricoVersao &= "Devolu��o - Inclus�o da data no cupom vale troca;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na comanda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.9 - 01/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste vers�o anterior;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes Sat Fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.8 - 01/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do campo Fam�lia;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes no Layout;" & vbCrLf
        HistoricoVersao &= "Pedido de Compra - Ajustes na impress�o do cupom;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na nf-e sa�da." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.7 - 30/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste nos produtos em falta;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no vendedor;" & vbCrLf
        HistoricoVersao &= "Venda - Observa��o do pedido no relat�rio de venda." & vbCrLf
        'HistoricoVersao &= "SaT e NFE por email." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.6 - 25/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no por cliente;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Ajustes no campo c�digo interno." & vbCrLf
        'HistoricoVersao &= "SaT e NFE por email." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.5 - 22/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Campanha - Ajuste no cadastro de campanha;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no desconto por item;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o do sat da Elgin;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Nova Vers�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Sat - Ajustes;" & vbCrLf
        HistoricoVersao &= "Impress�o Venda - Inclus�o da coluna Valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclus�o da op��o Dupla M�dia Argox." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.4 - 03/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Exclui o Movimento Banc�rio ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Exclui o Movimento Banc�rio ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Banco - Novo relat�rio de Movimento Banc�rio no padr�o de extrato;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usu�rio - Permiti bloquear o relat�rio de vendas na tela de venda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.3 - 27/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o do bot�o gerar aquivo;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o da opc�o de gr�fico;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do conta a pagar na pr�pria tela de entrada nf;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no layout da impress�o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.2 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.1 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio de Consumo - Inclus�o da coluna Fornecedor por Produto;" & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.9.0 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corrigir mascara inscri��o estadual de Goi�s;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclus�o do campo Banco;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclus�o do campo Banco, Ag�ncia e Conta Corrente;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclus�o do campo Meta, onde ir� comparar no gr�fico no MDI Analyzer, venda e meta do funcin�rio;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclus�o do bot�o visualizar;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Lucro - Inclus�o da coluna % Desconto;" & vbCrLf
        HistoricoVersao &= "Consultar Cr�ditos e D�bitos - Ajuste na impress�o;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto por item;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto total;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na entrada de pagamento;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclus�o dos Campos Perc. FCP e Perc. ICMS refer�nte ao ICMS UF Dest. para emiss�o de NF-e;" & vbCrLf
        HistoricoVersao &= "Bloqueios - inclus�o do Liberar Desconto por itens, no pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.9 - 12/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Estoque Negativo - Ajuste;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste Unidade Medida;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na impress�o." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.8 - 04/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o da op��o de pagamento parcial;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.7 - 22/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Banco - Inclus�o do banco SICOOB;" & vbCrLf
        HistoricoVersao &= "Campanha - Ajuste no cadastro de campanha;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.6 - 08/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no cadastro de fornecedor para quem usa o sistema sincronizado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.5 - 02/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna Valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Usu�rio - Inclus�o da op��o de inativar o usu�rio;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclus�o do bot�o vender para administrador." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.4 - 30/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclus�o dos campos Ag�ncia e Conta Corrente;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no converter p/, na altera��o do item;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.3 - 25/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Campanhas - Inclus�o do cadastro de campanhas;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.2 - 23/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueios - Ajustes no bloqueios de usuarios;" & vbCrLf
        HistoricoVersao &= "Caixa - Ajuste no relat�rio sem troco;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.1 - 18/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.8.0 - 17/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ao alterar um produto manter a posi��o na grid;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao maximiar a tela;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o no converter p/, multiplicar qtd por qtd prod.;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na impress�o de etiqueta dupla grande;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto por cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Op��o de inserir comanda;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do valor total com juros no comprovante;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclus�o da op��o bematech por dll;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.9 - 26/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= "Produto - Inclus�o tabela de pre�os dos produtos;" & vbCrLf
        HistoricoVersao &= "Pedido - Agora � possivel selecionar tabela de pre�os dos produtos;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste campo centro de custo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.8 - 14/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.7 - 13/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= "Produto - Inclus�o Impress�o de Etiqueta Pimaco Modelo A5Q1219;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Inclus�o pedido de mercadoria;" & vbCrLf
        HistoricoVersao &= "Cadastro Forma Pagamento - Inclus�o do campo N� Dias Venc., para formas de pagameto a prazo, numero de dias do vencimento." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.6 - 31/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o no bot�o consultar para cancelar uma nota fiscal de entrada." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.5 - 29/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Impress�o na impressora Daruma." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.4 - 28/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Corre��o filtrar carregar tipo produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Pedido - Corre��o filtrar carregar tipo produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Entrada NF Totais - Inclus�o da coluna c�digo fornecedor;" & vbCrLf
        HistoricoVersao &= "Relat�rio Entrada NF Por Itens - Inclus�o da coluna c�digo fornecedor;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o dos impostos de sa�da SAT Fiscal;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ocultar o tipo na grid;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o de verifica��o de senha ADM para adicionar desconto por item;" & vbCrLf
        HistoricoVersao &= "Config - Inclus�o manter porcentagem cadastro do produto;" & vbCrLf
        HistoricoVersao &= "Config - Inclus�o op��o de tr�s casas decimais para valor cadastro do produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.3 - 21/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Corre��o impress�o das etiquetas Pimaco4348;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do tipo servi�o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.2 - 15/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Corre��o impress�o das etiquetas Pimaco4348 e LB 1000 DUPLA;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Aumento do campo email;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o dos impostos de sa�da SAT Fiscal;" & vbCrLf
        HistoricoVersao &= "Sistema - Inclus�o da tecla Esc para fechar as principais telas do sistema." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.1 - 24/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o do nome do vendedor na impress�o da venda;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Editar CPF antes de gerar o cupom;" & vbCrLf
        HistoricoVersao &= "Excluir Venda - Inclus�o do total da venda no log;" & vbCrLf
        HistoricoVersao &= "Nano - Outras corre��es diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.7.0 - 22/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Nano - Ajuste na vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.9 - 22/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep, inclus�o do menu;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep, op��o de escolher a venda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no campo desconto;" & vbCrLf
        HistoricoVersao &= "Venda - Corre��o ao inserir produto nao aceitar produto inativo;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o ao inserir produto nao aceitar produto inativo;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da op��o de produto em estoque;" & vbCrLf
        HistoricoVersao &= "Consulta Produto por Tamanho - Inclus�o da coluna C�digo Barra e Grupo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.8 - 17/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep;" & vbCrLf
        HistoricoVersao &= "Nano - Outras corre��es diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.7 - 15/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclus�o do SAT Fiscal da Dimep." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.6 - 02/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Visualiza��o dos tamanhos do produtos para quem trabalha com grade de tamanhos;" & vbCrLf
        HistoricoVersao &= "Pedido - Corrigido problema no pre�o quando alterava Gaxeta;" & vbCrLf
        HistoricoVersao &= "Nano - Outras corre��es diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.5 - 26/01/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no campo Origem para quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualiza��o da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '##################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.4 - 08/12/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o do campo CEST para quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Agora as imagens podem ser tiradas pela WebCan;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o do campo Desconto;" & vbCrLf
        If TipoNano = 3 Then
            HistoricoVersao &= "Email - Inclus�o da op��o retorno;" & vbCrLf
        End If
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Relat�rio Recebimento - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.3 - 23/11/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Adicionado a Op��o 'Imprimir Direto' que permite optar por imprimir o pedido ou n�o;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o dos campos Data de Retirada e Data de Entrega;" & vbCrLf
        If TipoNano = 2 Then
            HistoricoVersao &= "Cadastro de Produto - Inclus�o do campo loca��o;" & vbCrLf
        End If
        If TipoNano = 1 Then
            HistoricoVersao &= "Cadastro de Receita - Agora ap�s cadastrar a receita a tela ser� limpa para o pr�ximo cadastro;" & vbCrLf
        End If
        HistoricoVersao &= "Relat�rio Consumo - Inclus�o da coluna entrada, onde informa a quantidade somanda do produto em entrada de nota fiscal no per�odo;" & vbCrLf
        HistoricoVersao &= "Relat�rio Venda - Inclus�o da coluna setor;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclus�o da campo complemento na etiqueta tripla;" & vbCrLf
        HistoricoVersao &= "Devolu��o - Ajuste no cadastro de devolu��o." & vbCrLf
        'HistoricoVersao &= "Nao fechar o cadastro de receita depois que salva" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.2 - 03/11/2015"
        HistoricoVersao &= vbCrLf & vbCrLf

        HistoricoVersao &= "Relat�rio Pedido - Corre��o no filtrar por per�odo;" & vbCrLf
        HistoricoVersao &= "Cadastrar Cr�ditos e D�bitos - Mensagem se o campo N� parcela n�o for preenchido;" & vbCrLf
        HistoricoVersao &= "Pedido - Mudar a descri��o (desconto) para acr�scimo se optar por acr�scimo;" & vbCrLf
        HistoricoVersao &= "Cadastro de Receita - Campo Qtd com 3 casas decimais;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impress�o." & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.1 - 15/10/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Corre��o relat�rio sem troco;" & vbCrLf
        HistoricoVersao &= "Configura��o Grid - Corre��o no manter grid em alguma telas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.6.0 - 13/10/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom N�o Fiscal - Inclus�o do operador;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produtos - Nova impress�o de etiquetas, impressora Argox etiqueta dupla m�dia." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.9 - 30/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Corre��o na nota promiss�ria." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.8 - 29/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom - Corre��o na data;" & vbCrLf
        HistoricoVersao &= "Recebimento - Inclus�o do troco;" & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o do total das parcelas na tela do credi�rio;" & vbCrLf
        HistoricoVersao &= "Cadastro de Clientes - Inclus�o dos bot�es vendas e consumo no hist�rico;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do bot�o Carn�/Promiss�ria;" & vbCrLf
        HistoricoVersao &= "Bloqueios - Corre��o no bloqueio de usu�rio." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.7 - 21/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Corre��o vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.6 - 21/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom - Inclus�o da hora;" & vbCrLf
        HistoricoVersao &= "Cadastro de Clientes - Agora � permitido cadastrar imagem ou foto;" & vbCrLf
        HistoricoVersao &= "Venda - Ao selecionar o cliente aparecer� a imagem se o mesmo tiver imagem cadastrada;" & vbCrLf
        HistoricoVersao &= "Venda - Ao selecionar o produto aparecer� a imagem se o mesmo tiver imagem cadastrada." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.5 - 08/09/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o no campo unidade medida." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.4 - 01/09/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Corre��o na etiqueta pimaco." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.3 - 31/08/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o dos impostos de entrada;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o do campo Custo do produto, Converter para e Qtd Produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclus�o da aba Hist�rico." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.2 - 10/08/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Altera��o do contas a receber;" & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Recebimento (baixa) do contas a receber;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Aba cupom fiscal, mensagem no bot�o inserir para todos, para quem imprime cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da op��o de acr�scimo;" & vbCrLf
        HistoricoVersao &= "Venda - Corre��o ao inserir forma de pagamento, quando n�o tem nenhum produto adicionado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.1 - 04/08/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Configura��es;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Compartilhado;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.5.0 - 30/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Implementa��o do SAT Fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.9 - 23/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o no busca produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.8 - 23/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do campo Vencimentos onde � permitido consultar as contas atrazadas, que vence hoje ou em dia;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o do campo Vencimentos onde � permitido consultar as contas atrazadas, que vence hoje ou em dia;" & vbCrLf
        HistoricoVersao &= "Cadastro de Devolu��o - Corre��o ao voltar pro estoque;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o da bot�o de pesquisa;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da bot�o de vender, salva o pedido e redireciona direto para a tela de venda;" & vbCrLf
        HistoricoVersao &= "Configura��o Grid - Corre��o no manter grid em alguma telas." & vbCrLf
        'Cadastro de cliente nome se o nome contem PROTESTADO a linha fica vermelha
        'Telefone do skype no canal era systems
        'Cadastro do animal colocar coluna telefone e endereco do cliente
        'Cadastro do animal colocar visualizar
        'Cadastro do animal corrigir webcam
        'Dav corrigir sele��o
        'Aumentar coluna parcial
        'Relatorio de vendas inclusao da coluna Grupo e Fabricante ocultas
        'Relatorio de tamanhos e qtd por venda na Cravo e canela

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.7 - 08/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Corre��o do modelos de etiquetas (LB-1000);" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Corre��o na aba NF-e." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.6 - 07/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclus�o de mais dois modelos de etiquetas (LB-1000);" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Campo nome agora aceita at� 200 caracteres;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Pedidos - Inclus�o do relat�rio de pedidos;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da entrada (pagamento);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclus�o de log para o cadastro da Entrada NF;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o do log na altera��o do valor do item, estava sem o numero da NF;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Inclus�o do campo nascimento;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Corre��o no busca CPF, campo a ser preenchidos para a busca (CPF e Nascimento);" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Corre��o no busca CPF, campo a ser preenchidos para a busca (CPF e Nascimento);" & vbCrLf
        HistoricoVersao &= "MDI - Corre��o no envio de e-mail do canal Era Systems;" & vbCrLf
        HistoricoVersao &= "Configura��o - Separar estoque por setor." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.5 - 08/06/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Corre��o na configura��o da grid;" & vbCrLf
        HistoricoVersao &= "Ajustes na vers�o anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.4 - 02/06/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Recebimento - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Lan�ar Cr�dito e D�bito - Inclus�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Inclus�o da op��o por funcion�rio;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Relat�rio Vis�o - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do bot�o compromisso." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.3 - 18/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cheque - Inclus�o do campo observa��o;" & vbCrLf
        HistoricoVersao &= "Caixa - Transferencia bancaria com o nome do banco;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o na m�dia lucro (%)." & vbCrLf
        'HistoricoVersao &= "coluna animal no consulta pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.2 - 14/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Corre��o no campo Banco;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o e ajuste do bot�o lucro (%)." & vbCrLf
        'HistoricoVersao &= "Busca CPFCNPJ opcional agora no config." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.1 - 11/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Corre��o ao salvar observa��o;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclus�o do Pesquisa imposto, NF-e e Cupom Fiscal, pra quem emite NF-e e Cupom fiscal respectivamente;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Campos inutilizados retirados, na aba Cupom Fiscal, pra quem emite cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Dav - Inclus�o das colunas Tributa��o, Al�quota e Ncm nos produtos da venda, pra quem emite cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o do bot�o lucro (%), ao clicar uma nova coluna ir� aparecer com o lucro dos produtos;" & vbCrLf
        HistoricoVersao &= "Cadastro de Forma de Pagamento - Agora � permitido vincular o banco na forma de pagamento BOLETO." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.4.0 - 28/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Alterar Valores - Inclus�o da op��o valor custo;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o do relat�rio totais." & vbCrLf
        'HistoricoVersao &= "Novo layout boleto cobran�a." & vbCrLf
        'HistoricoVersao &= "Inclusao uf no config;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.9 - 22/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadatro de Produto - Inclus�o da op��o imagem, onde pode-se cadastrar at� duas imagens;" & vbCrLf
        HistoricoVersao &= "Caixa - Relat�rio realizar os calculos somente dos itens visiveis na grid;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o na op��o de alterar tributos do produto pra quem emite nf-e." & vbCrLf
        'HistoricoVersao &= "Cad Cliente - coluna telefone." & vbCrLf
        'HistoricoVersao &= "EntradaNF - Configatu preco de custo;" & vbCrLf
        'HistoricoVersao &= "Cadastr Produto - Tipo nano 2 clicar na linha aparece na aplicacao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.8 - 15/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Configura��o Grid - Agora � permitido configurar a grid de algumas telas, ex: deixar uma coluna oculta, alterar o tamanho, a localiza�ao e a ordena��o." & vbCrLf
        'HistoricoVersao &= "Impress�o Pedido - Inclus�o do campo complemento no dados do cliente." & vbCrLf
        'HistoricoVersao &= "Pedido - corre��o desconto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.7 - 13/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclus�o da terceira casa decimal no valor unit�rio;" & vbCrLf
        HistoricoVersao &= "Cadatro de Produto - Pesquisa Tributos, agora � permitido alterar os tributos do produto pra quem emite nf-e;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Agora � permitido alterar os tributos do produto pra quem emite nf-e;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclus�o do busca nome do cliente pelo cpf;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Inclus�o do busca nome do fornecedor pelo cpf;" & vbCrLf
        'HistoricoVersao &= "Troca - mesmo produto de venda diferente;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.6 - 07/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclus�o da terceira casa decimal no valor unit�rio;" & vbCrLf
        HistoricoVersao &= "Cobran�a Era Systems - Agora permite atualizar o boleto vencido;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Corre��o no busca cnpj, por estado;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corre��o no busca cnpj, por estado;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Corre��o na inscri��o estadual do estado do Mato Grosso;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corre��o na inscri��o estadual do estado do Mato Grosso;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.5 - 30/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Auto ajuste da linha na descri��o do produto;" & vbCrLf
        HistoricoVersao &= "Log - Inclus�o da quantidade do produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Corre��o no busca cep, tratar caracteres inv�lidos;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corre��o no busca cnpj, tratar caracteres inv�lidos;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.4 - 24/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Observa��o do pedido na venda;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclus�o da coluna status;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclus�o do busca dados do cliente pelo cnpj;" & vbCrLf
        HistoricoVersao &= "Cobran�a Era Systems - Agora voc� pode gerar o boleto da Era Systems diretamente pelo sistema;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.3 - 11/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclus�o do Saldo Atual Dinheiro;" & vbCrLf
        HistoricoVersao &= "Entrada Nf - Novo produto corrigir validade;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Layout;" & vbCrLf
        'HistoricoVersao &= "Pedido Animal inserir Linha na Ficha;" & vbCrLf
        'HistoricoVersao &= "Pedido Animal inserir Linha na Ficha com a data;" & vbCrLf
        'HistoricoVersao &= "Tootip nos botoes pedido animal;" & vbCrLf
        'HistoricoVersao &= "Consumo corre�ao erro calculo porcentagem;" & vbCrLf
        'HistoricoVersao &= "Retorno pedido animal;" & vbCrLf
        'HistoricoVersao &= "Relatorio de retorno;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.2 - 04/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Help - Em todas as telas do sistema, precionando F1 abrir� o Help;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Entrada NF por xml, se tiver desconto tem a possibilidade de aplicar nos itens;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclus�o do campo n� dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclus�o do campo n� dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Credi�rio - Inclus�o do campo n� dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Configura��o - Inclus�o da op��o comiss�o por produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.1 - 26/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Gerar etiquetas, ao clicar no bot�o pra adicionar outro produto nao estava puxando com a quantidade em estoque;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Fornecedor - Estava sem o logo da empresa;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Descarte - Estava sem o logo da empresa;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Movimento Banc�rio - Estava sem o logo da empresa;" & vbCrLf
        'HistoricoVersao &= "Venda estava aceitando negativo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.3.0 - 18/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o no setor;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Nova impress�o de etiquetas." & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        HistoricoVersao &= "Cadastro de Funcion�rio - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        'HistoricoVersao &= "Cadastro de Produto layout via arquivo;" & vbCrLf
        'HistoricoVersao &= "Boleto;" & vbCrLf
        'HistoricoVersao &= "Cadastro de Produto calculo correto qtde negativa vira zero;" & vbCrLf
        'HistoricoVersao &= "Venda estava aceitando negativo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.9 - 28/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Invent�rio - Corre��o na ordena��o;" & vbCrLf
        HistoricoVersao &= "Cadastro Banco - Mais completo." & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.8 - 21/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Invent�rio - Barra de rolagem autom�tica;" & vbCrLf
        HistoricoVersao &= "Invent�rio - Inclus�o dos bot�es visualizar produtos adicionados e produtos n�o adicionados." & vbCrLf
        HistoricoVersao &= "Comanda - Corre��o Impress�o;" & vbCrLf
        HistoricoVersao &= "Relat�rio Entrada NF - Inclus�o da coluna Estoque Ok, informa se o estoque foi atualizado ou n�o;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.7 - 14/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Quando o sistema tiver confgurado para gerar comiss�o ser� obrigat�rio informar o vendedor;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Comiss�o - Inclus�o de um contador de vendas." & vbCrLf
        HistoricoVersao &= "Comanda - Impress�o da entrega e retirada;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.6 - 12/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Op��o se deseja imprimir o recibo;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o ao inserir tamanho." & vbCrLf
        'HistoricoVersao &= "Custodio pedido sem codigo interno;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.5 - 15/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Fluxo de caixa por per�odo;" & vbCrLf
        HistoricoVersao &= "Caixa - Tranfer�ncia para banco;" & vbCrLf
        HistoricoVersao &= "Relat�rio Consumo - Tirar coluna tamanho se a consulta n�o for por produto;" & vbCrLf
        HistoricoVersao &= "Gr�ficos - Implanta��o do gr�fico de contas a pagar e pagas;" & vbCrLf
        HistoricoVersao &= "Gr�ficos - Implanta��o do gr�fico de contas a receber e recebidas;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Implanta��o da consulta de pedidos em aberto no MDI Analyzer;" & vbCrLf
        HistoricoVersao &= "Venda - Ao excluir um item da venda se a qtde for maior que um, tem a op��o de escolher a qtde a ser exclu�da;" & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Inclus�o do saldo atual caixa." & vbCrLf
        'HistoricoVersao &= "Gerar Codigo Interno Produto verificar se ja existe;" & vbCrLf
        'HistoricoVersao &= "Corre��o Baixar cartoes;" & vbCrLf

        'HistoricoVersao &= "Na Venda pode clicar no meio pra abrir pagamento cliente ou desconto;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.4 - 10/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impress�o - Op��o de remover o c�digo de barra na impress�o de cupom n�o fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.3 - 01/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impress�o - Altera��es, corre��es e melhorias na impress�o de cupom n�o fiscal." & vbCrLf
        HistoricoVersao &= "Conta Receber - Adicionado o bot�o de 'Relat�rio de Venda' para consultar o itens vendidos." & vbCrLf
        HistoricoVersao &= "Conta Receber - Adicionado o bot�o de 'Remover Parcela' caso o cliente desista de pagar alguma parcela." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.2 - 18/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impress�o - Altera��es, corre��es e melhorias na impress�o de cupom n�o fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.1 - 17/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impress�o - Altera��o na impress�o da venda em cupom n�o fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.2.0 - 12/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Bot�o para Consulta de Produtos;" & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Impress�o de Etiqueta Pimaco Modelo A4348;" & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Impress�o de Etiqueta Pimaco Modelo A4360;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Consultar Produtos;" & vbCrLf
        HistoricoVersao &= "Devolu��o - Impress�o da Devolu��o em impressoras fiscais;" & vbCrLf
        HistoricoVersao &= "Pedido - A exclus�o de Pedidos s� ser� permitida por usu�rios Administradores;" & vbCrLf
        HistoricoVersao &= "Pedido - Na Consulta dos Pedidos agora � possivel visualizar a coluna Total;" & vbCrLf
        HistoricoVersao &= "Pedido - Na Consulta dos Pedidos agora � possivel imprimir a consulta;" & vbCrLf
        HistoricoVersao &= "Venda - Adicionado a Op��o 'Imprimir Direto' que permite optar por imprimir a venda ou n�o;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.9 - 31/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usu�rio - Nano Analyzer;" & vbCrLf
        HistoricoVersao &= "Nano Analyzer - Gr�fico por funcion�rio informar pelo c�digo;" & vbCrLf
        HistoricoVersao &= "Nano Analyzer - Corre��o gr�fico por funcion�rio;" & vbCrLf
        'cadastro produto custo e venda zerados da erro na porcentagem
        'Entrada Nf xml cadastrar fornecedor setar coluna inativo
        'Entrada Nf xml produto com o mesmo nome e codigo de barras diferentes esta cadastrando um s�
        'Nfe pasta compartilhada
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.8 - 27/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Impress�o da observa��o do Pedido para Auto Pe�as;" & vbCrLf
        HistoricoVersao &= "Implanta��o do Nano Analyzer" & vbCrLf & "Agora ser� poss�vel a visualiza��o por Administradores das seguintes fun��es:" & vbCrLf & "Gr�ficos de Vendas semanal ou a cada 10 dias." & vbCrLf & "Gr�fico de Vendas por Funcion�rio, di�rio ou semanal." & vbCrLf & "Resumo di�rio de Contas a Receber, Contas a Pagar, Clientes Aniversariantes e Resumo do Caixa." & vbCrLf & "Com a Agenda de Compromissos voc� conseguir� organizar o seu dia, com a cria��o de eventos ser� possivel receber alertas que lhe informar�o a data e hora do seu compromisso. A agenda tamb�m mostrar� suas contas e os aniversariantes de cada dia." & vbCrLf & "Com o Canal Era Systems voc� poder� enviar elogios, cr�ticas e sugest�es al�m de pedir suporte pelo pr�prio sistema." & vbCrLf & "E aqui onde voc� est� lendo essas informa��es � o Hist�rico de Vers�es, onde voc� encontrar� tudo o que h� novo no seu sistema Nano." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.7 - 21/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relat�rio Entrada NF Itens - Adicionado Coluna 'Valor Venda';" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Colocado c�digo munic�pio na tela;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.6 - 08/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Implanta��o de controle de clientes pela Era Systems;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'Atualizar("Update Config set VersaoNano ='2.1.6'")
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.5 - 06/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Campo de validade do produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Campo para inativar fornecedor;" & vbCrLf
        HistoricoVersao &= "Envio de E-mail - Corre��o para envio por qualquer servidor;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.4 - 29/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Usu�rio - Corre��o de mensagem ao abrir a tela;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.3 - 29/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Impress�o dos dados completo do cliente;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Giro - Corre��o de ortografia;" & vbCrLf
        HistoricoVersao &= "Cupom Fiscal - Corre��o de ortografia no Espelho;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.2 - 24/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'If para MSG impress�o Caval�o Auto Pe�as no pedido
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.1 - 22/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'If para impress�o C�digo Barra Caval�o Auto Pe�as
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.1.0 - 15/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.9 - 15/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Op��o de segunda via do cupom;" & vbCrLf
        'HistoricoVersao &= "Funcion�rio - Implanta��o Cr�dito e D�bito;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.8 - 09/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Op��o de v�rios emitentes;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.7 - 08/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Colocado C�digo ANP Combust�vel pra quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "NF-e - Colocado C�digo ANP Combust�vel;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.6 - 02/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Qtde m�nima se estiver vazio, inserir zero;" & vbCrLf
        HistoricoVersao &= "Venda - Incluir Mec�nico na Venda apenas pelo bot�o;" & vbCrLf
        HistoricoVersao &= "Pedido Impress�o - Colocar valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocado campo que mostra n�mero de itens;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################
        '###################################################
        HistoricoVersao &= "Vers�o 2.0.5 - 29/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Config - Colocado Tipo Nano para Auto Pe�as;" & vbCrLf
        HistoricoVersao &= "Venda - Incluir Mec�nico na Venda;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Corre��o do Representante;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.4 - 19/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Corre��o forma de pagamento ao selecionar credi�rio e cancelar;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Na aba NF-e na op��o de 'Inserir para todos', perguntar se � pra inserir NCM tamb�m;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.3 - 07/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Implanta��o de etiquetas Label Pimaco;" & vbCrLf
        HistoricoVersao &= "NF-e - Implanta��o do NANO NF-e;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.2 - 17/07/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Corre��o comanda zerada;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.1 - 16/07/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o da tela de tamanhos do produto;" & vbCrLf
        HistoricoVersao &= "Corre��o Nano Print;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 2.0.0 - 14/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Fun��o Estoque Somado;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################
        '###################################################
        HistoricoVersao &= "Vers�o 1.9.9 - 10/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Corre��o 'de olho no imposto';" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.8 - 09/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o na altera��o de item;" & vbCrLf
        HistoricoVersao &= "Implanta��o Nano Print;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.7 - 09/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Op��o 'Estoque Somado';" & vbCrLf
        HistoricoVersao &= "Entrada NF - Limpar filtro antes de salvar;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Limpar campos se n�o existir nota cadastrada;" & vbCrLf
        HistoricoVersao &= "Imagem Nano Commerce no grafico e Entrada NF;" & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Altera��o de valor de venda do produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Altera��o de valor de custo do produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Cadastro de produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Log - Altera��o do nome fantasia do Fornecedor;" & vbCrLf
        HistoricoVersao &= "Pedido - Impress�o com a data da venda;" & vbCrLf
        HistoricoVersao &= "Venda - Se emitir cupom fiscal permitir informar o cliente sem CPF/CNPJ;" & vbCrLf
        HistoricoVersao &= "Venda - Se o usu�rio tiver n�vel de 'USUARIO', n�o aparecer coluna valor de custo do produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocar desconto por produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Se o produto estiver em promo��o, informar o pre�o j� com o desconto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocar coluna valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Venda - Trazer o pedido com os descontos de promo��o;" & vbCrLf
        HistoricoVersao &= "Funcion�rio - N�o aparecer em nenhum cadastro se estiver inativo;" & vbCrLf
        HistoricoVersao &= "Funcion�rio - Implanta��o do relat�rio de comiss�o somado;" & vbCrLf
        HistoricoVersao &= "Devolu��o - Colocado coluna c�digo do produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio Devolu��o - Colocado coluna c�digo do produto;" & vbCrLf
        HistoricoVersao &= "Relat�rio de Giro - Ajustado para estoque somado ;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Op��o de casdatrar produtos pela Entrada de NF;" & vbCrLf
        HistoricoVersao &= "Config - Colocado 'de olho no imposto' fixo;" & vbCrLf
        HistoricoVersao &= "Entrada NF - N�o cadastrar duas vezes produtos iguais;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Colocado campo c�digo de barras;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.6 - 19/05/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corre��o de cidades com aspas pelo Cep;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Corre��o de cidades com aspas pelo Cep;" & vbCrLf
        HistoricoVersao &= "NF-e - Corre��o c�lculo de cr�dito;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.5 - 05/05/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Colocar c�digo da loja;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Op��o de estornar uma conta baixada;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Op��o de estornar uma conta baixada;" & vbCrLf
        HistoricoVersao &= "Pedido - Corre��o na impress�o do cupom;" & vbCrLf
        HistoricoVersao &= "Venda - Imprimir em impressora normal;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Imprimir recibo em impressora normal;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Corre��o CFOP na altera��o;" & vbCrLf
        HistoricoVersao &= "Venda - Abrir gaveta com impressora fiscal;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Nova busca de Cep;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Novo Busca de Cep;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o do XML com aspas e faltando cabe�alho;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.4 - 28/04/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom Fiscal - Corre��o do c�lculo com desconto;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Corre��o ao atualizar Estoque com unidade medida diferente do cadastro de produtos;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.3 - 07/04/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Fun��o para Inutiliza��o de Numera��o;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.2 - 17/03/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Altera��o da fonte dos Produtos Vendidos;" & vbCrLf
        'HistoricoVersao &= "Venda - Altera��o dos campos total e sub total para nano campo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Vers�o 1.9.1 - 03/03/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Emiss�o de Comprovante;" & vbCrLf
        HistoricoVersao &= "Relat�rio - Relat�rio de Comandas;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Imprimir etiqueta com a op��o de selecionar qual e quantas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        'O HIST�RIO DE VERS�O FOI INVERTIDO, AGORA A �LTIMA ATUALIZA��O APARECE EM PRIMEIRO LUGAR, POR ISSO VOLTE L� PRA CIMA


    End Function
End Class
