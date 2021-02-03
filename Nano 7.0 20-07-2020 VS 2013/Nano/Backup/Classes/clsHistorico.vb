Public Class clsHistorico
    Public Shared Function Historico() As Boolean

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.5.3 - 15/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "E-mail - Inclusão da opção de inserir assinatura;" & vbCrLf
        HistoricoVersao &= "E-mail - Inclusão da opção de inserir imagem no corpo do e-mail;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no layout;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Ajuste não mostar usuários inativo;" & vbCrLf
        HistoricoVersao &= "Venda - Total pendência do cliente na impressão como opção na configuração;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.5.2 - 15/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Bloqueio da exclusão do cliente consumidor;" & vbCrLf
        HistoricoVersao &= "Cadastro Veículo - Ajuste na alteração de um veículo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da coluna Qtd Máxima;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do campo desconto por Valor R$;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão da coluna Qtd Máxima;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na venda com crédito do cliente;" & vbCrLf
        HistoricoVersao &= "Venda - Impressão do cupom da venda com o total de pendência do cliente;" & vbCrLf
        HistoricoVersao &= "Venda - Impressão do cupom da venda com o valor da parcela do cartão parcelado;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da impressão do vale presente;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da consulta da tabela de preço do produto selecionado;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste verficar se o pedido já foi faturado antes de alterar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ao buscar o produto preencher o campo valor custo para  nivel de usuário administrador;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Ao buscar o produto mostrar o valor do produto de acordo com a tabela de preço selecionada;" & vbCrLf
        HistoricoVersao &= "Devolução - Inclusão do número da venda no relatório de devolução;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.5.1 - 13/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da coluna auxiliar onde salva o nome do computador, data e hora;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Ajuste na tabela de preço;" & vbCrLf
        HistoricoVersao &= "Pedido / Venda - Inclusão do operador ao salvar o pedido ou a venda;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna operador;" & vbCrLf
        HistoricoVersao &= "Relatório Lucro - Inclusão da coluna operador;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Inclusão da coluna operador;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do campo Qtde Máxima;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao cancelar a entrada de nf;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuário - Ajuste ao bloquear a tela de venda;" & vbCrLf
        HistoricoVersao &= "MDI - Ajuste ao enviar email no canal;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.5.0 - 07/07/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Relatório Lucro - Ajuste no filtro com hora;" & vbCrLf
        HistoricoVersao &= "Tabela IBPT - Atualização da Tabela IBPT;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da impressão de etiqueta ZT 230 Dupla (Zebra)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.9 - 30/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Pedido Itens - Ajuste na coluna Obs;" & vbCrLf
        HistoricoVersao &= "Boleto Cobrança - Ajuste no boleto de cobranças da TI7;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Opção de informa a Razão social se estiver preenchido o nome fantasia na configuração;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste no código do produto ao transformar pedido em venda;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da quantidade de vezes do cartão no cupom da venda;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Ajustes ao abrir a tela por outra tela ex. entrada nf;" & vbCrLf
        HistoricoVersao &= "Sistema - Padronizar as casas decimais de acordo com o configurado;" & vbCrLf
        HistoricoVersao &= "Relatorio Transferência - Corrigido filtro por período;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste ao calcular pessoas na mesa;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Inclusão da coluna KM Entrada (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "MDI - Inclusão da coluna KM Entrada no pedidos pendentes (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Relatório Entrada NF - Inclusão da coluna Chave (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no nome dos campos para Nano Tipo 2 ex. Setor para Marca;" & vbCrLf
        HistoricoVersao &= "Relatório Produtos em Falta - Inclusão da coluna Aplicação (Coluna Oculta);" & vbCrLf
        HistoricoVersao &= "Relatório Sat - Ajuste no calculo total já descontar o valor dos cupons cancelados;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna Sat, se foi emitido um sat da venda ou não;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Ajuste no bloqueio de funcionário;" & vbCrLf
        HistoricoVersao &= "Caixa - Ao excluir uma movimentação do caixa e a mesma for transferência bancária excluir também a transferência bancária;" & vbCrLf
        HistoricoVersao &= "Log - Inclusão do registro de exclusão de uma movimentação bancária." & vbCrLf
        'HistoricoVersao &= "Ajuste no regustro nano email" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.8 - 24/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão da tabela de preço na comanda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na tabela de preço;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na tabela de preço." & vbCrLf
        'HistoricoVersao &= "Ajuste no regustro nano email" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.7 - 22/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajuste ao excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.6 - 17/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.5 - 15/06/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclusão do Sat Control Id;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclusão do Sat Custom;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no desconto por item por valor;" & vbCrLf
        HistoricoVersao &= "Sistema - Atualizar sistema sem arquivo;" & vbCrLf
        'HistoricoVersao &= "Caixa - Abrir Fechar Caixa;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Inclusão da coluna código produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Não mostrar campo data com 01/01/1900;" & vbCrLf
        HistoricoVersao &= "Consulta de Produto - Ajustar campo e coluna com casas descimais de acordo com o configurado no sistema;" & vbCrLf
        HistoricoVersao &= "Relatório Contas Recebidas - Impressão com valor da parcela e valor recebido;" & vbCrLf
        HistoricoVersao &= "Relatório Gráfico Vendedor - Inclusão do valor total da venda;" & vbCrLf
        'HistoricoVersao &= "SAT Fiscal - Ajuste na descricao do produto pular linha e nao cortar;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################


        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.4 - 27/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda - Ajuste na coluna Código NF-e;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste desconto maximo por item com senha administrador." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.3 - 21/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste impressão com unidade medida hora;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste na coluna código do pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.2 - 20/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste campo VFCPST." & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Comanda bloqueio da impressão automatica para cliente do Marcelo" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.1 - 19/05/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste comanda." & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste no nome da coluna juros para vlr. c/ juros R$;" & vbCrLf
        HistoricoVersao &= "Relatório Sat - Ajuste na coluna valor desconto;" & vbCrLf
        HistoricoVersao &= "MDI - Ajustes na impressão do pedido pelo MDI." & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Comanda bloqueio da impressão automatica para cliente do Marcelo" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.4.0 - 29/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da opção Painel Preço KG;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste comanda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.9 - 29/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão dos campos Frete, Outras Despesas e Seguro nos itens." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.8 - 23/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no calculo de ipi;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no calculo de conversão;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do campo VFCPST (Valor do Fundo de combate a pobreza)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.7 - 16/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impressão campo complemento;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na impressão com troca;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.6 - 14/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajuste nas colunas da grid." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.5 - 08/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.4 - 06/04/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes no boleto sicred, remessa e retorno;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajustes no calculo, no tipo desconto total;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do CPF/CNPJ na impressão do pedido paisagem." & vbCrLf
        'HistoricoVersao &= "Ajuste Log filtro estoque somado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.3 - 09/03/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "MDI - Ajustes na impressão do pedido pelo MDI." & vbCrLf
        'HistoricoVersao &= "Ajuste Log filtro estoque somado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.2 - 02/03/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.1 - 26/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.3.0 - 26/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da impressão tipo paisagem;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da Unidade Medida na impressão tipo paisagem;" & vbCrLf
        HistoricoVersao &= "Venda/Pedido- Inclusão do campo frete;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Inclusão da coluna Frete;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna Frete;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Ajustes na aba complementar;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do campo Qtd Embalagem." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.9 - 17/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da impressão padrão para o commerce;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes na impressão padrão para o automotivo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.8 - 10/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda/Pedido - Ajuste na coluna Nº NF-e;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.7 - 07/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda/Pedido - Inclusão da coluna Nº NF-e;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuários - Ajustes no bloqueios;" & vbCrLf
        'HistoricoVersao &= "comserv no relatorio de venda;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.6 - 04/02/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Ajuste config coluna inexistente;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.5 - 30/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Ajuste config coluna inexistente;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.4 - 30/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da opção de calcular ou não o impostos nos produtos;" & vbCrLf
        'HistoricoVersao &= "Venda ajuste na comissao quando inseri pelo valor;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.3 - 27/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Ajustes no bloqueio do cadastro de funcionário;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do campo cpf/cnpj do cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impressão com imagem;" & vbCrLf
        HistoricoVersao &= "Inventário - Inclusão da coluna fornecedor, nos produtos não adicionados;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do campo Total Produtos R$;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes no PIS/COFINS;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste no filtro de data no DAV." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.2 - 08/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes ao imprimir etiquetas com tamanho;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Ajuste na tabela preco verificar antes de salvar;" & vbCrLf
        'HistoricoVersao &= "Inclusao do tiponano na verificacao do cliente erasystems;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.1 - 06/01/2020"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Ajuste no relatório quando cliente estiver configurado como multiloja;" & vbCrLf
        HistoricoVersao &= "Conta Receber/Pagar - Altualizar grid após uma exclusão." & vbCrLf
        HistoricoVersao &= "Conta Receber/Pagar - Ajustes na exclusão." & vbCrLf
        'HistoricoVersao &= "Venda/Pedido - Ajuste no valor da entrada do pedido ao adicionar ou excluir um item;" & vbCrLf
        'HistoricoVersao &= "Forma Pagamento - Ajuste no campo banco;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.2.0 - 12/12/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
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
        HistoricoVersao &= "Versão 4.1.9 - 09/12/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Inclusão do bloqueio de movimento bancário;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Inclusão do bloqueio de transferência bancária;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Inclusão do bloqueio de visualizar relatórios de comissão;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes na consulta de serviço para não verificar estoque zerado;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do motivo na exclusão do pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do endereço de entrega na impresão do pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no modelo de impressão com imagem do produto;" & vbCrLf
        HistoricoVersao &= "Contas Recebidas - Inclusão da opção de estornar varias contas recebidas;" & vbCrLf
        HistoricoVersao &= "Contas Pagas - Inclusão da opção de estornar varias contas pagas;" & vbCrLf
        HistoricoVersao &= "Recibo de Pagamento - Inclusão da opção para digitar o nome do funcionario ou fornecedor;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão do campo valor sem desconto na impressão da venda." & vbCrLf
        'HistoricoVersao &= "Entrada NF - Inclusão da opção de aplicação pela tela de cadastro de produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.8 - 18/11/2019"
        HistoricoVersao &= vbCrLf & vbCrLf

        HistoricoVersao &= "Comanda - Inclusão da coluna observação na grid;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão do busca produto por (Descrição, Código Interno, Grupo, Setor, Fabricante ou Obs);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do campo chave do xml;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no filtro de consulta dos pedidos;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão de um modelo de impressão com imagem do produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão de endereço para entrega na impressão;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes na ordem dos campos utilizando a tecla TAB;" & vbCrLf
        If TipoNano = 5 Then
            HistoricoVersao &= "Comissão - Inclusão da coluna placa e modelo do veículo;" & vbCrLf
            HistoricoVersao &= "Comissão - Inclusão da coluna placa e modelo do veículo na impressão;" & vbCrLf
        End If
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Conta Receber - Liberado a baixa parcial para as lojas CONSTRULAR e CONSTRU-NEI;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ajustes da quantidade por embalagem;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.7 - 14/10/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cliente - Inclusão do cadastro de endereço para entrega;" & vbCrLf
        HistoricoVersao &= "Produto - Inclusão da quantidade por embalagem;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do valor total no visualizar;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão da coluna código do pedido;" & vbCrLf
        HistoricoVersao &= "Contas Recebidas - Ajustes no titulo da impressão;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no layout do cupom do pedido (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão da exclusão de itens de forma padrão da tela de venda;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Correção ao carregar coluna Observação;" & vbCrLf
        HistoricoVersao &= "MDI Todos Pedidos - Ajuste ao carregar placa e modelo;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da placa e modelo do veículo no cupom (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Pedido - Inclusão da quantidade por embalagem;" & vbCrLf
        'HistoricoVersao &= "Cliente - Correção na consulta CPF;" & vbCrLf
        'HistoricoVersao &= "Banco - Inclusão do BANCO SAFRA como opção no cadastro;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.6 - 19/09/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Inclusão do valor de venda na grid conforme tabela de preço;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do valor de venda na grid conforme tabela de preço;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Ajustes no filtro por itens;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Venda - Correção no cadastro de conta parcelada erro na coluna valorrecebido null;" & vbCrLf
        'HistoricoVersao &= "Produto - Remosão da função codigobarra na lojas cavalão, devido extrema lentidão;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.5 - 28/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes ao imprimir etiquetas;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ao puxar o produto cursor ir direto para o campo qtd;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do campo tipo de conta, custo fixo/variável e centro de custo quando conter conta a pagar;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Inclusão do bloqueio de data no caixa;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Inclusão do bloqueio de desfaturar pedidos;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes na exclusão;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do estorno no log;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes na exclusão;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão do estorno no log;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da observação fixa no cupom;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da data retirada e data entrega no cupom;" & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Inclusão da opção de transferência entre bancos;" & vbCrLf
        HistoricoVersao &= "Cadastro/Consulta Produto - Cód. Similar podendo filtrar no meio da palavra/frase;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do Valor Total na impressão;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da coluna código interno e código barra;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da coluna código do pedido na consulta e na impressão da venda, caso a venda seja vinculada ao pedido;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Inclusão da pesquisa por Família;" & vbCrLf
        HistoricoVersao &= "Histórioco Cliente - Inclusão do campo dias em atraso;" & vbCrLf
        HistoricoVersao &= "Funcionário - Inclusão do campo comissão serviço (Commerce);" & vbCrLf
        HistoricoVersao &= "E-mail - Inclusão do campo cópia na configuração do e-mail;" & vbCrLf
        HistoricoVersao &= "PDV - Habilitar cadastro de transportadora (Nano PDV)." & vbCrLf

        'HistoricoVersao &= "Pedido - acrescimo no item colocando o sinal de menos;" & vbCrLf
        'HistoricoVersao &= "Fluxi Caixa - Saldo atual no config e no bloqueio usuario;" & vbCrLf
        'HistoricoVersao &= "Entrada NF - Etiqueta qtde, e estava abrindo ja com itens antigo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.4 - 26/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Cliente - Ajustes no histórico de vendas do cliente;" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclusão da coluna locação na tela de venda e pedido;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão da coluna família;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao cancelar a entrada nf vinculada a conta a pagar." & vbCrLf
        'HistoricoVersao &= "TEF - ajustes;" & vbCrLf
        'HistoricoVersao &= "kit - ajustes botao montar somente no alterar;" & vbCrLf
        'HistoricoVersao &= "config - saldo caixa;" & vbCrLf
        'HistoricoVersao &= "Pedido - alterar cliente pela placa;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.3 - 19/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.2 - 15/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Transferência - Inclusão do número da transferência na mensagem ao salvar ou transferir;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.1 - 14/08/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Ajustes tributação, inclusão da opção de inserir tributação para SAT e NF-e (SAT e NF-e);" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao selecionar varias parcelas para emissão de um unico boleto;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes no troco;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes ao inserir acréscimo;" & vbCrLf
        HistoricoVersao &= "Comanda - Impressão com identificação do atendente;" & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Ajustes casa decimal;" & vbCrLf
        HistoricoVersao &= "Campanha - Ajustes na campanha, opção de inserir produtos em uma campanha lançada." & vbCrLf
        'HistoricoVersao &= "Construnei - Conta Receber - mensagem de valor diferente di recebido." & vbCrLf
        'HistoricoVersao &= "Construnei - Caixa - bloquear filtro caixa no bloqueio da data." & vbCrLf
        'HistoricoVersao &= "Criss - Nota Promissoria - EscPOS." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.1.0 - 10/07/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes Reimpressão TEF para outras adquirintes;" & vbCrLf
        HistoricoVersao &= "Relatório Lucro - Ajustes na coluna Total R$ para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Comissão - Ajustes na comissão para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes no relatório de nfc-e na coluna Total R$ para tipo desconto Total (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes na configuração do boleto;" & vbCrLf
        HistoricoVersao &= "Boleto - Ajustes na emissão do boleto;" & vbCrLf
        HistoricoVersao &= "Produto - Ajustes ao duplicar um produto;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes ao excluir ou estornar uma conta;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da data atual no conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Inclusão da configuração de casas decimais;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no campo acréscimo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.9 - 10/07/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Ajustes para diminuir o tempo ao abrir o fluxo de caixa;" & vbCrLf
        HistoricoVersao &= "Relatório Revisão - Ajuste no filtro por data e placa (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ordenar Tipo de Conta por ordem alfabética;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção no erro ao tentar visualizar ou abrir uma promissória sem ter selecionado um pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes data entrega e data retirada (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Relatório de Consumo - Inclusão da coluna Grupo na pesquisa por produto;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes ao adicinar mais de uma qtd, ajuste versão anterior;" & vbCrLf
        HistoricoVersao &= "Kit - Ajustes ao montar um kit;" & vbCrLf
        HistoricoVersao &= "Gráfico Consumo - Ajustes ao filtrar a data;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.8 - 13/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.7 - 11/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.6 - 11/06/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste ao digitar o ncm ja preenche os dados relacionados ao ncm ja cadastrado em outro produto;" & vbCrLf
        HistoricoVersao &= "Cadastro Veículo - Ajuste ao alterar uma placa (Nano Automotivo);" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclusão do busca produto por (Descrição, Código Interno, Grupo, Setor, Fabricante ou Obs);" & vbCrLf
        HistoricoVersao &= "Venda/Pedido - Inclusão da opção de adicionar a quantidade pela tela de consulta produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do tipo de produto Peça ou Serviço (Nano Automotivo)." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.5 - 27/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.4 - 27/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Opção de agrupar valores das Entradas de NF dos fornecedores selecionados;" & vbCrLf
        HistoricoVersao &= "Relatório DRE - Ajuste nos valores dos dados do conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na opção do vinculo funcionário/usuário;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Ao abrir o relatório traz somente os ultimos 30 dias, exceto tipo nano automotivo;" & vbCrLf
        HistoricoVersao &= "NANO - Inclusão da aba Suporte;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Ajuste no layout;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.3 - 15/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.2 - 14/05/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclusão do CPF do cliente na impressão do cupom não fiscal;" & vbCrLf
        HistoricoVersao &= "Relatório DRE Sintético - Ajuste no valor dos dados do conta a pagar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na coluna Desconto;" & vbCrLf
        HistoricoVersao &= "Relatório Giro - Inclusão da coluna grupo do produto;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualização da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.1 - 29/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Configuração NFC-e - Ajuste na tela de configuração;" & vbCrLf
        HistoricoVersao &= "Canal Era Systems - Inclusão de mais um telefone Era Systems;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na coluna nome do produto na impressão do pedido;" & vbCrLf
        HistoricoVersao &= "MDI Pedido Pendentes - Inclusão da coluna Valor Custo para nível usuário administrador;" & vbCrLf
        HistoricoVersao &= "MDI Pedido Pendentes - Colunas Data Entrega e Data Retirada centralizadas;" & vbCrLf
        HistoricoVersao &= "Entrada NF / Produto - Ajuste ao cadastrar um produto novo pela tela de entrada nf, o mesmo estava sendo cadastrado sem unidade medida;" & vbCrLf
        HistoricoVersao &= "Ajustes Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 4.0.0 - 23/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório DRE - Ajuste no relatório;" & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Ajuste no botão filtrar;" & vbCrLf
        HistoricoVersao &= "Comissão - Ajuste na comissão venda com devolução;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão da opção salvar motivo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.9 - 10/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste na consulta do pedido na tela de venda, não poder trazer pedidos ja faturados;" & vbCrLf
        HistoricoVersao &= "Comissão - Ajuste na comissão tipo nano 5 (automotivo);" & vbCrLf
        HistoricoVersao &= "Vender - Ajuste ao imprimir venda com devolução;" & vbCrLf
        HistoricoVersao &= "Descarte - Inclusão da opção de configuração da grid;" & vbCrLf
        HistoricoVersao &= "Relatório Descarte - Inclusão da opção de configuração da grid;" & vbCrLf
        HistoricoVersao &= "Relatório Descarte - Inclusão das colunas Valor Total do produto e Funcionário no relatório de descarte;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao cadastrar o cliente e veículo pelo pedido tipo nano 5 (automotivo);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no botão Editar NF-e Entrada;" & vbCrLf
        HistoricoVersao &= "Movimentação Bancário - Ajuste no tipo receitas, lançar positivo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.8 - 01/04/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Vender - Ajuste na capacidade de caracteres no campo Tamanho;" & vbCrLf
        HistoricoVersao &= "Produto - Ajuste na capacidade de caracteres no campo Cód. Similar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no campo desconto por valor." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.7 - 25/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro/Consulta Produto - Ajuste no filtro do nome do produto, opção de filtrar no meio da frase ou não;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no layout da grid Qtde e ajusto nos filtro da grid;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na funções/tribustos ao salvar tributação;" & vbCrLf
        HistoricoVersao &= "Pagamento - Inclusão do recibo de pagamento e recebimento;" & vbCrLf
        HistoricoVersao &= "Pedido - Impressão do cupom do pedido com os dados do veículo para tipo nano automotivo;" & vbCrLf
        HistoricoVersao &= "Pedido - Impressão do cupom do pedido com hora;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao cadastrar um cliente pelo cadastro de pedido, puxar direto ao salvar;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na quantidade de pessoas na mesa ao vender;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão da coluna Código Interno e Código de Barras na consulta da Tabela de Preço." & vbCrLf
        'HistoricoVersao &= "Correcao relatorio funcionario" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.6 - 19/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.5 - 19/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transferência - Inclusão da opção de inserir produtos automático;" & vbCrLf
        HistoricoVersao &= "Transferência - Ajuste ao alterar transferência;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste ao abrir gaveta, opção de abrir somente pelo computador onde está a gaveta;" & vbCrLf
        HistoricoVersao &= "Forma de Pagamento - Ajuste nas formas de pagamento a prazo agora permite cadastrar com número de dias zerado;" & vbCrLf
        HistoricoVersao &= "Pedido - Impressão do pedido com entrada R$;" & vbCrLf
        HistoricoVersao &= "Pedido - Habilitado a opção de maximizar a tela;" & vbCrLf
        HistoricoVersao &= "Pedido/Venda - Ajuste na opção de alterar preço custo no pedido;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Ajustes internos ao salvar o pedido de compra;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na capacidade de caracteres no campo Tamanho;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da Opção vincular produto a um outro produto, quando abrir via xml;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Conta a Pagar e Conta a Receber na agenda no bloqueio de usuário;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Ajuste bloqueio Nfe;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Inclusão do bloqueio do Kit." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.4 - 04/03/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório DRE - Ajuste ao carregar dados da venda;" & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Ajuste ao carregar o saldo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na capacidade de caracteres no campo Cód. Similar;" & vbCrLf
        HistoricoVersao &= "Cobrança Era Systems - Agora permite atualizar o boleto vencido;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.3 - 18/02/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no leave do campo custo;" & vbCrLf
        'HistoricoVersao &= "Conta Receber - coluna recebimento e valor recebido no conta receber;" & vbCrLf
        HistoricoVersao &= "Cadastro Veículo - Ajuste no campo placa, inclusão do novo modelo;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste horário de verão." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '#################################e##################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.2 - 04/02/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da Descrição do Código ANP para emissão de NFC-e;" & vbCrLf
        HistoricoVersao &= "Login - Bloqueio da opção de colar no campo senha;" & vbCrLf
        HistoricoVersao &= "Inventário - Ajuste a coluna qtde em estoque para estoque somando;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão da quantidade de pessoas na mesa ao finalizar a comanda;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão do campo observação;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na comanda ao finalizar a venda;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualização da tabela IBPT." & vbCrLf
        'HistoricoVersao &= "Ajuste Relatorio customizado agrupar e somar valortotal agrupado." & vbCrLf
        'HistoricoVersao &= "Relatorio Giro trazer somente os produtos ativos." & vbCrLf
        'HistoricoVersao &= "Relatorio Consumo ajuste na tem desconto trazer o nome do produto pela tabela produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.1 - 22/01/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da etiqueta de promoção;" & vbCrLf
        HistoricoVersao &= "Ajustes versão anterior." & vbCrLf
        'HistoricoVersao &= "Gaveta - Senha para abrir na reimpressão;" & vbCrLf
        'HistoricoVersao &= "SAT - Tirar Try Cat;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.9.0 - 22/01/2019"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão do campo Código Funcionário, para vincular o funcionário ao cliente, no Pedido;" & vbCrLf
        HistoricoVersao &= "Cupom não fiscal - Inclusão do SubTotal;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da Locação por loja;" & vbCrLf
        HistoricoVersao &= "Dav - Inclusão do valor total de vendas e valor total de itens da venda;" & vbCrLf
        HistoricoVersao &= "Ajustes no tipo nano 5 automotivo." & vbCrLf
        'HistoricoVersao &= "Gaveta - Senha para abrir na reimpressão;" & vbCrLf
        'HistoricoVersao &= "SAT - Tirar Try Cat;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.9 - 18/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Giro 2 - Ajustes tipo de produtos;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste pagamento." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.8 - 13/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT FISCAL - Correção no CPF Destinatario do SAT Elgin;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste ao alterar um item no Pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Ajuste no em falta linha vermelha." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.7 - 12/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.6 - 10/12/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Pedido - Ajuste, ao salvar o carro ja puxar direto no pedido, foco na placa, inclusão da coluna placa e modelo na consulta de pedido;" & vbCrLf
        HistoricoVersao &= "Relatório de Comissão - Ajuste, somado por venda e inclusão da coluna Cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste, removido botão vender na consulta do pedido;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuario - Inclusão do bloqueio do botão abrir gaveta;" & vbCrLf
        HistoricoVersao &= "TEF - Inclusão da opção de adquirente." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.5 - 21/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da coluna Porcentagem Comissão onde salva a porcentagem da comissão do funcionário;" & vbCrLf
        HistoricoVersao &= "TEF - Ajuste cancelamento e removido a opção de abrir gaveta quando impresso o TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.4 - 21/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste QrCode;" & vbCrLf
        HistoricoVersao &= "Transferência - Inclusão da coluna Auxiliar onde salva o nome do computador, a data e a hora em que foi feito a transferência;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da coluna Auxiliar onde salva o nome do computador, a data e a hora em que foi feito o pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.3 - 05/11/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste horário de verão;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Ajuste no bloqueio de usuário;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste campo desconto por item." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.2 - 29/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transferência - Agrupar produtos iguais;" & vbCrLf
        HistoricoVersao &= "Log - Alteração no Pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.1 - 29/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.8.0 - 17/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.9 - 16/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajuste versão 4.0;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no desconto por item;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.8 - 15/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão do campo data da conta;" & vbCrLf
        HistoricoVersao &= "Relatório DRE - Ajuste no filtro por data da conta;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.7 - 01/10/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.6 - 14/08/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.5 - 13/08/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Pagamento - Ajuste nas casas decimais na taxa do cartão;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Exclusão dos produtos inativos da pesquisa tributos;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na trânsferencia de mesas;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste abrir arquivo XML;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.4 - 03/07/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do cadastro da unidade de medida;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.3 - 28/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.2 - 20/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "MDI - Inclusão cadastro de computador;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão de status de pedido;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna comissão;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna lucro;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna margem;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.1 - 08/06/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão do extrado de caixa;" & vbCrLf
        HistoricoVersao &= "Cadastro Funcionario - Inclusão do vinculo com o usuario;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da consulta tributação pelo NCM;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da opção alterar valor na venda;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da opção duplicar produto;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão da consulta assinatura;" & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.7.0 - 02/05/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes na entrada NF;" & vbCrLf
        HistoricoVersao &= "Caixa - Opção de alterar a data;" & vbCrLf
        HistoricoVersao &= "Nano - Ajuste Balança." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.9 - 20/03/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes no estoque em:;" & vbCrLf
        HistoricoVersao &= "Cadastro de Receita - Ajustes ao salvar no cadastro de produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.8 - 12/03/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Log - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.7 - 28/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Ajuste;" & vbCrLf
        HistoricoVersao &= "Campanha - Opção de excluir itens na campanha em andamento;" & vbCrLf
        HistoricoVersao &= "Comanda - Ajuste na tranferência de uma comanda pra outra." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.6 - 19/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior;" & vbCrLf
        HistoricoVersao &= "Nano - Inclusão da impressão para comanda via App." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.5 - 06/02/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da unidade medida metro quadrado (M2);" & vbCrLf
        HistoricoVersao &= "Nano - Ajuste banco parado;" & vbCrLf
        HistoricoVersao &= "Nano - Inclusão do Relatório Customizado;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Impressão via Esc Pos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.4 - 26/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.3 - 26/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste Versão Anterior" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.2 - 25/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Nano - Inclusão da comunicação com a balança toledo;" & vbCrLf
        HistoricoVersao &= "Nano - Inclusão da verificação do banco de dado parado;" & vbCrLf
        HistoricoVersao &= "Nano - Inclusão do aviso nano;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão do envio automático dos arquivos mensal ao email desejado;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Dav ao faturar manter o foco na linha de baixo;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no histório ordenação da data;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Não excluir produto que esteja na campanha;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão da mensagem de produto inexistente, caso o produto nao esteja cadastrado;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na atualização do custo no estoque por lote;" & vbCrLf
        HistoricoVersao &= "Descarte - Inclusão do estorno;" & vbCrLf
        HistoricoVersao &= "Pedido - Opção de impressao A4;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste no pagamento parcial, manter o vencimento;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Ajuste no pagamento parcial, manter o vencimento;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Ajuste no manter grid;" & vbCrLf
        HistoricoVersao &= "Inventário - Inclusão do filtro." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.1 - 02/01/2018"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Vendas - Ajuste no cancelamento do TEF;" & vbCrLf
        HistoricoVersao &= "Formas de Pagamento - Inclusão da opção usa TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.6.0 - 14/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueios Usuários - Inclusão do cadastro de pedido, alteração de pedido e consulta de pedido;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.9 - 13/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no Pesquisa Imp.;" & vbCrLf
        HistoricoVersao &= "Bloqueios Usuários - Inclusão do cadastro de usuários;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impressão do pedido sem valor;" & vbCrLf
        HistoricoVersao &= "Venda - Inserir senha ADMINISTRADOR ao excluir um item ou cancelar a venda se o usuário não for administrador;" & vbCrLf
        HistoricoVersao &= "Ajuste TEF" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.8 - 04/12/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior tributação." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.7 - 30/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.6 - 29/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Ajuste busca CPF;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste tributação." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.5 - 13/11/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Comanda - Inclusão da columa Valor Total R$;" & vbCrLf
        HistoricoVersao &= "Cadastro Comanda - Inclusão da opção de inserir o produto diversos;" & vbCrLf
        HistoricoVersao &= "Relatório Gráfico - Inclusão do gráfico por vendedor;" & vbCrLf
        HistoricoVersao &= "Relatório Gráfico - Inclusão do gráfico produto por vendedor;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Inclusão da coluna Data Ult. Venda por cliente;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na coluna Data." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.4 - 30/10/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste ao salvar tributação;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna nome vendedor;" & vbCrLf
        HistoricoVersao &= "Ajuste TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.3 - 30/10/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Implementação do TEF." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.2 - 20/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na tributação e no botão inserir para todos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.1 - 14/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.5.0 - 14/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste na Aba Nfe/Sat Fiscal;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Histórico por período;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Manter grid na grid de qtde;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na entrada por xml, verificar codigo de barra adicional." & vbCrLf
        HistoricoVersao &= "Relatório Desempenho - Inclusão do relatório de desempenho." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.9 - 04/09/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Tabela de preço padrão por loja;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão do Relatório de Clientes;" & vbCrLf
        HistoricoVersao &= "SAT FIscal - Ordenação das vendas na tela do DAV;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclusão do SAT Epson." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.8 - 17/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.7 - 14/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da data que foi adicionado o produto;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.6 - 14/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do cadastro de códigos de barras. Agora um produto pode ter mais de um código de barras cadastrados;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclusão das colunas Data Retirada e Data Entrega;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclusão da opção de ajustar o layout da grid;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão do nome fantasia do cliente no cupom não fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do nome fantasia do cliente no cupom não fiscal;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.5 - 02/08/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes, opção de incluir mais de um sat de marcas diferentes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.4 - 25/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualização da tabela IBPT;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no custo médio do produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.3 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no custo médio do produto;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.2 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Ao excluir um registro do caixa, foi incluído o valor do mesmo no log;" & vbCrLf
        HistoricoVersao &= "Relatório de Comissão - Agora será carregado as informações do mês vigente;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão de mensagem antes de fechar tela se a nota não tiver sido salva;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão de mensagem antes de abrir arquivo XML se a tela ja possuir produtos;" & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.1 - 18/07/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.4.0 - 26/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NFC-e - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.9 - 20/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.8 - 19/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do histórico de ajuste para quantidade;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão da opção para digitar o nome do cliente;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes na impressão;" & vbCrLf
        HistoricoVersao &= "NFC-e - Inclusão da Nota Fiscal de Consumidor Eletronica;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.7 - 07/06/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Ajustes calculo de capital;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão da impressão de cupom;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes verificação para produto inativo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.6 - 25/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão 2º via do comprovante;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes calculo media custo;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da opção para baixar xml da nota;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão verificação para produto inativo;" & vbCrLf
        HistoricoVersao &= "Transferência - Inclusão verificação para produto inativo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.5 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajustes diversos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.4 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Ajustes na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Giro 2 - Ajustes na ordenação das colunas numéricas;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do botão fonte para alterar a fonte da grid." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.3 - 08/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão do centro de custo na impressão;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do centro de custo na impressão;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão da opção de imprimir o cupom sat;" & vbCrLf
        HistoricoVersao &= "Relatórios - Inclusão do período no título;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ajustes na hora de vender direto estava com erro;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.2 - 03/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.1 - 02/05/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Imprimir direto;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no tamanho das colunas na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Lucro - Inclusão das colunas Nº Pedido e Nº NFe ocultas;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.3.0 - 25/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.9 - 24/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão do campo loja para empresas multilojas;" & vbCrLf
        HistoricoVersao &= "Caixa - Ajuestes no relatório de Caixa Total." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.8 - 11/04/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da opção de desconto no item por valor ou porcentagem;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão da Data Ult. Venda;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do filtro quantidade do estoque em determinada data, se o sistema for estoque somado;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do aviso se o produto for adicionado mais de uma vez;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção no codigo no cadastro de produto;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da coluna Valor Custo no histórico de Entrada NF;" & vbCrLf
        HistoricoVersao &= "Relatório Giro 2 - Ajuste na coluna Saída;" & vbCrLf
        HistoricoVersao &= "Tabela Preço - Corrigir valores automaicamente ao alterar o valor de custo do produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.7 - 27/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.6 - 27/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        'HistoricoVersao &= "Salvar versao sat no sistema erasystems;" & vbCrLf
        HistoricoVersao &= "Receita/Kit - Corrigir auto numeração do código;" & vbCrLf
        HistoricoVersao &= "Configuração - Opção da observação do cliente no pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Ajuste na inscrição estadual;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Verificar dados antes de gerar o cupom;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.5 - 20/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Transferência - Corrigir arredondamento casa decimal;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Corrigir casa decimal;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.4 - 14/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Opção de custo médio;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes no inserir produtos com quantidades zeradas;" & vbCrLf
        HistoricoVersao &= "Transferência de Produtos - Agora é permitido salvar, transferir, receber e devolver;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão da data na impressão;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.3 - 06/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.2 - 01/03/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no acrescimo;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão da consulta de tabela de preço." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.1 - 15/02/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da função busca e remoção automatica;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.2.0 - 06/02/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do campo Código Fornecedor;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.9 - 24/01/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório de Consumo - Inclusão da coluna Codigo por Produto;" & vbCrLf
        HistoricoVersao &= "Relatório de Consumo - Inclusão da coluna Cidade por Cliente;" & vbCrLf
        HistoricoVersao &= "Relatório de Lucro - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.8 - 17/01/2017"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no acrescimo;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Correção no valor pago no pagamento de varias parcelas juntas." & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no botão abrir XML, na consulta do item;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualização da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.7 - 20/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão do total de clientes cadastrados;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Inclusão do total de fornecedores cadastrados;" & vbCrLf
        HistoricoVersao &= "Cadastro Funcionário - Inclusão do total de funcionários cadastrados." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.6 - 20/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Opção de agrupar ou não agrupar produtos." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.5 - 12/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Correção botão calcular para coluna valor;" & vbCrLf
        HistoricoVersao &= "Caixa - Correção no botão calcular e na visualização do relatório quando existia a palavra 'Troco';" & vbCrLf
        HistoricoVersao &= "Relatório Vendas - Correção no preço de custo para quem usa estoque por lote;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.4 - 07/12/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Movimento Bancário - Adicionado botão calcular para coluna valor;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajustes no Movimento Bancário ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= vbCrLf
        HistoricoVersao &= "Versão 3.1.3 - 30/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Correção da unidade de medida na venda e na impressão da venda;" & vbCrLf
        HistoricoVersao &= "Caixa - Adicionado uma coluna com o nome do computador que foi feito a operação;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuário - Adicionado a opção de bloquear os relatórios de caixa." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.1.2 - 23/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ao pressionar F7 o cursor será direcionado para o campo CPF e não mais para o Nome do cliente, evitando assim que o usuário precise usar o mouse;" & vbCrLf
        HistoricoVersao &= "Venda - Adicionado atalhos para todas as funções na tela de Venda. Para os botões que não estiverem com o comando de atalho em sua descrição, basta posicionar o cursor do mouse em cima para visualizá-los;" & vbCrLf
        HistoricoVersao &= "Venda - Opção de selecionar tabela de preço antes ou durante a venda. Basta pressionar F4;" & vbCrLf
        HistoricoVersao &= "Entrada de NF - Agora é possível vincular o código do fornecedor ao produto para que o sistema consiga identificá-lo pelo arquivo XML;" & vbCrLf
        HistoricoVersao &= "Comanda - Adicionado vários comandos de atalhos para as funções da tela;" & vbCrLf
        HistoricoVersao &= "Comanda - Ao clicar em Vender a tela de comanda não irá mais fechar e será atualizada automaticamente." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.1.1 - 14/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.1.0 - 09/11/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda - Ajustes no Filtrar para coluna Fabricante." & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Inclusão da coluna Fabricante;" & vbCrLf
        HistoricoVersao &= "Grafico Consumo - Inclusão da opção por pedido;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.9 - 31/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes na alteração." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.8 - 19/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Grafico - Inclusão da opção por pedido;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes etiquetas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.7 - 17/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Log - Log no cancelamento de Entrada NF;" & vbCrLf
        HistoricoVersao &= "Log - Ajustes nos logs de alterações de produto;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da etiqueta LB 1000;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes no atualizar produtos em lojas sincronizadas;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes no layout;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes ao desfaturar;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Inclusão das colunas Grupo e Setor;" & vbCrLf
        HistoricoVersao &= "Inventário - Inclusão das colunas Grupo e Setor;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão do campo Contato;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da etiqueta caixa." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.6 - 06/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da coluna Val. Promoção R$;" & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.5 - 03/10/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuário - Ajustes;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuário - Inclusão da opção bloquear bloqueio de usuário;" & vbCrLf
        HistoricoVersao &= "Venda - Ajustes;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Campanha - Inclusão do campo valor anterior para edição;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.4 - 21/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda - Ajustes nos dados do cliente;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes no cadastro de produtos;" & vbCrLf
        HistoricoVersao &= "Ajustes no Layout." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.3 - 19/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.2 - 13/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.1 - 13/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido Compra - Abrir cadastro e consulta ao mesmo tempo;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Inclusão do campo Em Pedido, para os produtos que estão em pedido;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na opcao de comanda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste ao inserir produtos pelo código de barras gerados por balança;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        'HistoricoVersao &= "Locacao na impressao de pedido tipo nano 2." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 3.0.0 - 06/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão da coluna campanha, para os produtos que estão em campanha;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão do período na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Totais Somado - Inclusão do período na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Totais Detalhado - Inclusão do período na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Catões Somado - Inclusão do período na impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Catões Detalhado - Inclusão do período na impressão;" & vbCrLf
        HistoricoVersao &= "Devolução - Inclusão da data no cupom vale troca;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na comanda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.9 - 01/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajuste versão anterior;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes Sat Fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.8 - 01/09/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do campo Família;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajustes no Layout;" & vbCrLf
        HistoricoVersao &= "Pedido de Compra - Ajustes na impressão do cupom;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na nf-e saída." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.7 - 30/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste nos produtos em falta;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no vendedor;" & vbCrLf
        HistoricoVersao &= "Venda - Observação do pedido no relatório de venda." & vbCrLf
        'HistoricoVersao &= "SaT e NFE por email." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.6 - 25/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no por cliente;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Ajustes no campo código interno." & vbCrLf
        'HistoricoVersao &= "SaT e NFE por email." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.5 - 22/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Campanha - Ajuste no cadastro de campanha;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no desconto por item;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão do sat da Elgin;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Nova Versão;" & vbCrLf
        HistoricoVersao &= "Relatório Sat - Ajustes;" & vbCrLf
        HistoricoVersao &= "Impressão Venda - Inclusão da coluna Valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclusão da opção Dupla Média Argox." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.4 - 03/08/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Exclui o Movimento Bancário ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Exclui o Movimento Bancário ao estornar ou excluir uma conta;" & vbCrLf
        HistoricoVersao &= "Banco - Novo relatório de Movimento Bancário no padrão de extrato;" & vbCrLf
        HistoricoVersao &= "Bloqueio de Usuário - Permiti bloquear o relatório de vendas na tela de venda." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.3 - 27/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão do botão gerar aquivo;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão da opcão de gráfico;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do conta a pagar na própria tela de entrada nf;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste no layout da impressão." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.2 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.1 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório de Consumo - Inclusão da coluna Fornecedor por Produto;" & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.9.0 - 20/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Corrigir mascara inscrição estadual de Goiás;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclusão do campo Banco;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclusão do campo Banco, Agência e Conta Corrente;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclusão do campo Meta, onde irá comparar no gráfico no MDI Analyzer, venda e meta do funcinário;" & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionario - Inclusão do botão visualizar;" & vbCrLf
        HistoricoVersao &= "Relatório de Lucro - Inclusão da coluna % Desconto;" & vbCrLf
        HistoricoVersao &= "Consultar Créditos e Débitos - Ajuste na impressão;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto por item;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto total;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na entrada de pagamento;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclusão dos Campos Perc. FCP e Perc. ICMS referênte ao ICMS UF Dest. para emissão de NF-e;" & vbCrLf
        HistoricoVersao &= "Bloqueios - inclusão do Liberar Desconto por itens, no pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.9 - 12/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Estoque Negativo - Ajuste;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste Unidade Medida;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste na impressão." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.8 - 04/07/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão da opção de pagamento parcial;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.7 - 22/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Banco - Inclusão do banco SICOOB;" & vbCrLf
        HistoricoVersao &= "Campanha - Ajuste no cadastro de campanha;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.6 - 08/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no cadastro de fornecedor para quem usa o sistema sincronizado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.5 - 02/06/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna Valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Usuário - Inclusão da opção de inativar o usuário;" & vbCrLf
        HistoricoVersao &= "Comanda - Inclusão do botão vender para administrador." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.4 - 30/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclusão dos campos Agência e Conta Corrente;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste no converter p/, na alteração do item;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.3 - 25/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Campanhas - Inclusão do cadastro de campanhas;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.2 - 23/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueios - Ajustes no bloqueios de usuarios;" & vbCrLf
        HistoricoVersao &= "Caixa - Ajuste no relatório sem troco;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.1 - 18/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.8.0 - 17/05/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ao alterar um produto manter a posição na grid;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste ao maximiar a tela;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção no converter p/, multiplicar qtd por qtd prod.;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajuste na impressão de etiqueta dupla grande;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste desconto por cliente;" & vbCrLf
        HistoricoVersao &= "Pedido - Opção de inserir comanda;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do valor total com juros no comprovante;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Inclusão da opção bematech por dll;" & vbCrLf
        HistoricoVersao &= "Sat Fiscal - Ajustes." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.9 - 26/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= "Produto - Inclusão tabela de preços dos produtos;" & vbCrLf
        HistoricoVersao &= "Pedido - Agora é possivel selecionar tabela de preços dos produtos;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Ajuste campo centro de custo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.8 - 14/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.7 - 13/04/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= "Produto - Inclusão Impressão de Etiqueta Pimaco Modelo A5Q1219;" & vbCrLf
        HistoricoVersao &= "Pedido Compra - Inclusão pedido de mercadoria;" & vbCrLf
        HistoricoVersao &= "Cadastro Forma Pagamento - Inclusão do campo Nº Dias Venc., para formas de pagameto a prazo, numero de dias do vencimento." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.6 - 31/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção no botão consultar para cancelar uma nota fiscal de entrada." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.5 - 29/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Impressão na impressora Daruma." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.4 - 28/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= "Relatório Venda - Correção filtrar carregar tipo produto;" & vbCrLf
        HistoricoVersao &= "Relatório Pedido - Correção filtrar carregar tipo produto;" & vbCrLf
        HistoricoVersao &= "Relatório Entrada NF Totais - Inclusão da coluna código fornecedor;" & vbCrLf
        HistoricoVersao &= "Relatório Entrada NF Por Itens - Inclusão da coluna código fornecedor;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção dos impostos de saída SAT Fiscal;" & vbCrLf
        'HistoricoVersao &= "Pedido - Ocultar o tipo na grid;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão de verificação de senha ADM para adicionar desconto por item;" & vbCrLf
        HistoricoVersao &= "Config - Inclusão manter porcentagem cadastro do produto;" & vbCrLf
        HistoricoVersao &= "Config - Inclusão opção de três casas decimais para valor cadastro do produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.3 - 21/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Correção impressão das etiquetas Pimaco4348;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do tipo serviço;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.2 - 15/03/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Correção impressão das etiquetas Pimaco4348 e LB 1000 DUPLA;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Aumento do campo email;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão dos impostos de saída SAT Fiscal;" & vbCrLf
        HistoricoVersao &= "Sistema - Inclusão da tecla Esc para fechar as principais telas do sistema." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.1 - 24/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclusão do nome do vendedor na impressão da venda;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Editar CPF antes de gerar o cupom;" & vbCrLf
        HistoricoVersao &= "Excluir Venda - Inclusão do total da venda no log;" & vbCrLf
        HistoricoVersao &= "Nano - Outras correções diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.7.0 - 22/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Nano - Ajuste na versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.9 - 22/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep, inclusão do menu;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep, opção de escolher a venda;" & vbCrLf
        HistoricoVersao &= "Venda - Ajuste no campo desconto;" & vbCrLf
        HistoricoVersao &= "Venda - Correção ao inserir produto nao aceitar produto inativo;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção ao inserir produto nao aceitar produto inativo;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da opção de produto em estoque;" & vbCrLf
        HistoricoVersao &= "Consulta Produto por Tamanho - Inclusão da coluna Código Barra e Grupo." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.8 - 17/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Ajuste SAT Fiscal Dimep;" & vbCrLf
        HistoricoVersao &= "Nano - Outras correções diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.7 - 15/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Inclusão do SAT Fiscal da Dimep." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.6 - 02/02/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Visualização dos tamanhos do produtos para quem trabalha com grade de tamanhos;" & vbCrLf
        HistoricoVersao &= "Pedido - Corrigido problema no preço quando alterava Gaxeta;" & vbCrLf
        HistoricoVersao &= "Nano - Outras correções diversas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.5 - 26/01/2016"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Ajuste no campo Origem para quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "De Olho no Imposto - Atualização da tabela IBPT." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '##################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.4 - 08/12/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão do campo CEST para quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Agora as imagens podem ser tiradas pela WebCan;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão do campo Desconto;" & vbCrLf
        If TipoNano = 3 Then
            HistoricoVersao &= "Email - Inclusão da opção retorno;" & vbCrLf
        End If
        HistoricoVersao &= "Pedido - Ajustes;" & vbCrLf
        HistoricoVersao &= "Relatório Recebimento - Ajuste." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.3 - 23/11/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Adicionado a Opção 'Imprimir Direto' que permite optar por imprimir o pedido ou não;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão dos campos Data de Retirada e Data de Entrega;" & vbCrLf
        If TipoNano = 2 Then
            HistoricoVersao &= "Cadastro de Produto - Inclusão do campo locação;" & vbCrLf
        End If
        If TipoNano = 1 Then
            HistoricoVersao &= "Cadastro de Receita - Agora após cadastrar a receita a tela será limpa para o próximo cadastro;" & vbCrLf
        End If
        HistoricoVersao &= "Relatório Consumo - Inclusão da coluna entrada, onde informa a quantidade somanda do produto em entrada de nota fiscal no período;" & vbCrLf
        HistoricoVersao &= "Relatório Venda - Inclusão da coluna setor;" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Inclusão da campo complemento na etiqueta tripla;" & vbCrLf
        HistoricoVersao &= "Devolução - Ajuste no cadastro de devolução." & vbCrLf
        'HistoricoVersao &= "Nao fechar o cadastro de receita depois que salva" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.2 - 03/11/2015"
        HistoricoVersao &= vbCrLf & vbCrLf

        HistoricoVersao &= "Relatório Pedido - Correção no filtrar por período;" & vbCrLf
        HistoricoVersao &= "Cadastrar Créditos e Débitos - Mensagem se o campo Nº parcela não for preenchido;" & vbCrLf
        HistoricoVersao &= "Pedido - Mudar a descrição (desconto) para acréscimo se optar por acréscimo;" & vbCrLf
        HistoricoVersao &= "Cadastro de Receita - Campo Qtd com 3 casas decimais;" & vbCrLf
        HistoricoVersao &= "Pedido - Ajuste na impressão." & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.1 - 15/10/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Correção relatório sem troco;" & vbCrLf
        HistoricoVersao &= "Configuração Grid - Correção no manter grid em alguma telas." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.6.0 - 13/10/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom Não Fiscal - Inclusão do operador;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produtos - Nova impressão de etiquetas, impressora Argox etiqueta dupla média." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.9 - 30/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Correção na nota promissória." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.8 - 29/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom - Correção na data;" & vbCrLf
        HistoricoVersao &= "Recebimento - Inclusão do troco;" & vbCrLf
        HistoricoVersao &= "Venda - Inclusão do total das parcelas na tela do crediário;" & vbCrLf
        HistoricoVersao &= "Cadastro de Clientes - Inclusão dos botões vendas e consumo no histórico;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do botão Carnê/Promissória;" & vbCrLf
        HistoricoVersao &= "Bloqueios - Correção no bloqueio de usuário." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.7 - 21/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Correção versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.6 - 21/09/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom - Inclusão da hora;" & vbCrLf
        HistoricoVersao &= "Cadastro de Clientes - Agora é permitido cadastrar imagem ou foto;" & vbCrLf
        HistoricoVersao &= "Venda - Ao selecionar o cliente aparecerá a imagem se o mesmo tiver imagem cadastrada;" & vbCrLf
        HistoricoVersao &= "Venda - Ao selecionar o produto aparecerá a imagem se o mesmo tiver imagem cadastrada." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.5 - 08/09/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Ajustes;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção no campo unidade medida." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.4 - 01/09/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Correção na etiqueta pimaco." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.3 - 31/08/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão dos impostos de entrada;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão do campo Custo do produto, Converter para e Qtd Produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclusão da aba Histórico." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.2 - 10/08/2015"

        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Log - Alteração do contas a receber;" & vbCrLf
        HistoricoVersao &= "Relatório Log - Recebimento (baixa) do contas a receber;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Aba cupom fiscal, mensagem no botão inserir para todos, para quem imprime cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da opção de acréscimo;" & vbCrLf
        HistoricoVersao &= "Venda - Correção ao inserir forma de pagamento, quando não tem nenhum produto adicionado." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf

        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.1 - 04/08/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Configurações;" & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Compartilhado;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.5.0 - 30/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "SAT Fiscal - Implementação do SAT Fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.9 - 23/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Correção no busca produto." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.8 - 23/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do campo Vencimentos onde é permitido consultar as contas atrazadas, que vence hoje ou em dia;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão do campo Vencimentos onde é permitido consultar as contas atrazadas, que vence hoje ou em dia;" & vbCrLf
        HistoricoVersao &= "Cadastro de Devolução - Correção ao voltar pro estoque;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão da botão de pesquisa;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da botão de vender, salva o pedido e redireciona direto para a tela de venda;" & vbCrLf
        HistoricoVersao &= "Configuração Grid - Correção no manter grid em alguma telas." & vbCrLf
        'Cadastro de cliente nome se o nome contem PROTESTADO a linha fica vermelha
        'Telefone do skype no canal era systems
        'Cadastro do animal colocar coluna telefone e endereco do cliente
        'Cadastro do animal colocar visualizar
        'Cadastro do animal corrigir webcam
        'Dav corrigir seleção
        'Aumentar coluna parcial
        'Relatorio de vendas inclusao da coluna Grupo e Fabricante ocultas
        'Relatorio de tamanhos e qtd por venda na Cravo e canela

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.7 - 08/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Correção do modelos de etiquetas (LB-1000);" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Correção na aba NF-e." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.6 - 07/07/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Inclusão de mais dois modelos de etiquetas (LB-1000);" & vbCrLf
        HistoricoVersao &= "Cadastro Produto - Campo nome agora aceita até 200 caracteres;" & vbCrLf
        HistoricoVersao &= "Relatório de Pedidos - Inclusão do relatório de pedidos;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da entrada (pagamento);" & vbCrLf
        HistoricoVersao &= "Entrada NF - Inclusão de log para o cadastro da Entrada NF;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção do log na alteração do valor do item, estava sem o numero da NF;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Inclusão do campo nascimento;" & vbCrLf
        HistoricoVersao &= "Cadastro Fornecedor - Correção no busca CPF, campo a ser preenchidos para a busca (CPF e Nascimento);" & vbCrLf
        HistoricoVersao &= "Cadastro Cliente - Correção no busca CPF, campo a ser preenchidos para a busca (CPF e Nascimento);" & vbCrLf
        HistoricoVersao &= "MDI - Correção no envio de e-mail do canal Era Systems;" & vbCrLf
        HistoricoVersao &= "Configuração - Separar estoque por setor." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.5 - 08/06/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Consulta Produto - Correção na configuração da grid;" & vbCrLf
        HistoricoVersao &= "Ajustes na versão anterior." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.4 - 02/06/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Recebimento - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Lançar Crédito e Débito - Inclusão;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Inclusão da opção por funcionário;" & vbCrLf
        HistoricoVersao &= "Consulta Produto - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Relatório Visão - Novo Layout;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do botão compromisso." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.3 - 18/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cheque - Inclusão do campo observação;" & vbCrLf
        HistoricoVersao &= "Caixa - Transferencia bancaria com o nome do banco;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção na média lucro (%)." & vbCrLf
        'HistoricoVersao &= "coluna animal no consulta pedido." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.2 - 14/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Correção no campo Banco;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção e ajuste do botão lucro (%)." & vbCrLf
        'HistoricoVersao &= "Busca CPFCNPJ opcional agora no config." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.1 - 11/05/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Correção ao salvar observação;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Inclusão do Pesquisa imposto, NF-e e Cupom Fiscal, pra quem emite NF-e e Cupom fiscal respectivamente;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Campos inutilizados retirados, na aba Cupom Fiscal, pra quem emite cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Dav - Inclusão das colunas Tributação, Alíquota e Ncm nos produtos da venda, pra quem emite cupom fiscal;" & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão do botão lucro (%), ao clicar uma nova coluna irá aparecer com o lucro dos produtos;" & vbCrLf
        HistoricoVersao &= "Cadastro de Forma de Pagamento - Agora é permitido vincular o banco na forma de pagamento BOLETO." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.4.0 - 28/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Alterar Valores - Inclusão da opção valor custo;" & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão do relatório totais." & vbCrLf
        'HistoricoVersao &= "Novo layout boleto cobrança." & vbCrLf
        'HistoricoVersao &= "Inclusao uf no config;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.9 - 22/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadatro de Produto - Inclusão da opção imagem, onde pode-se cadastrar até duas imagens;" & vbCrLf
        HistoricoVersao &= "Caixa - Relatório realizar os calculos somente dos itens visiveis na grid;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção na opção de alterar tributos do produto pra quem emite nf-e." & vbCrLf
        'HistoricoVersao &= "Cad Cliente - coluna telefone." & vbCrLf
        'HistoricoVersao &= "EntradaNF - Configatu preco de custo;" & vbCrLf
        'HistoricoVersao &= "Cadastr Produto - Tipo nano 2 clicar na linha aparece na aplicacao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.8 - 15/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Configuração Grid - Agora é permitido configurar a grid de algumas telas, ex: deixar uma coluna oculta, alterar o tamanho, a localizaçao e a ordenação." & vbCrLf
        'HistoricoVersao &= "Impressão Pedido - Inclusão do campo complemento no dados do cliente." & vbCrLf
        'HistoricoVersao &= "Pedido - correção desconto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.7 - 13/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Inclusão da terceira casa decimal no valor unitário;" & vbCrLf
        HistoricoVersao &= "Cadatro de Produto - Pesquisa Tributos, agora é permitido alterar os tributos do produto pra quem emite nf-e;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Agora é permitido alterar os tributos do produto pra quem emite nf-e;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclusão do busca nome do cliente pelo cpf;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Inclusão do busca nome do fornecedor pelo cpf;" & vbCrLf
        'HistoricoVersao &= "Troca - mesmo produto de venda diferente;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.6 - 07/04/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Inclusão da terceira casa decimal no valor unitário;" & vbCrLf
        HistoricoVersao &= "Cobrança Era Systems - Agora permite atualizar o boleto vencido;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Correção no busca cnpj, por estado;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Correção no busca cnpj, por estado;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Correção na inscrição estadual do estado do Mato Grosso;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Correção na inscrição estadual do estado do Mato Grosso;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.5 - 30/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Auto ajuste da linha na descrição do produto;" & vbCrLf
        HistoricoVersao &= "Log - Inclusão da quantidade do produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Correção no busca cep, tratar caracteres inválidos;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Correção no busca cnpj, tratar caracteres inválidos;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.4 - 24/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Observação do pedido na venda;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Pedidos pendentes, inclusão da coluna status;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Inclusão do busca dados do cliente pelo cnpj;" & vbCrLf
        HistoricoVersao &= "Cobrança Era Systems - Agora você pode gerar o boleto da Era Systems diretamente pelo sistema;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.3 - 11/03/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Inclusão do Saldo Atual Dinheiro;" & vbCrLf
        HistoricoVersao &= "Entrada Nf - Novo produto corrigir validade;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Layout;" & vbCrLf
        'HistoricoVersao &= "Pedido Animal inserir Linha na Ficha;" & vbCrLf
        'HistoricoVersao &= "Pedido Animal inserir Linha na Ficha com a data;" & vbCrLf
        'HistoricoVersao &= "Tootip nos botoes pedido animal;" & vbCrLf
        'HistoricoVersao &= "Consumo correçao erro calculo porcentagem;" & vbCrLf
        'HistoricoVersao &= "Retorno pedido animal;" & vbCrLf
        'HistoricoVersao &= "Relatorio de retorno;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.2 - 04/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Help - Em todas as telas do sistema, precionando F1 abrirá o Help;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Entrada NF por xml, se tiver desconto tem a possibilidade de aplicar nos itens;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Inclusão do campo nº dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Inclusão do campo nº dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Crediário - Inclusão do campo nº dias entre as parcelas;" & vbCrLf
        HistoricoVersao &= "Configuração - Inclusão da opção comissão por produto;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.1 - 26/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Gerar etiquetas, ao clicar no botão pra adicionar outro produto nao estava puxando com a quantidade em estoque;" & vbCrLf
        HistoricoVersao &= "Relatório de Fornecedor - Estava sem o logo da empresa;" & vbCrLf
        HistoricoVersao &= "Relatório de Descarte - Estava sem o logo da empresa;" & vbCrLf
        HistoricoVersao &= "Relatório de Movimento Bancário - Estava sem o logo da empresa;" & vbCrLf
        'HistoricoVersao &= "Venda estava aceitando negativo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.3.0 - 18/02/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção no setor;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Nova impressão de etiquetas." & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        HistoricoVersao &= "Cadastro de Funcionário - Campos CPF e Cep agora aceita o backspace." & vbCrLf
        'HistoricoVersao &= "Cadastro de Produto layout via arquivo;" & vbCrLf
        'HistoricoVersao &= "Boleto;" & vbCrLf
        'HistoricoVersao &= "Cadastro de Produto calculo correto qtde negativa vira zero;" & vbCrLf
        'HistoricoVersao &= "Venda estava aceitando negativo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.9 - 28/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Inventário - Correção na ordenação;" & vbCrLf
        HistoricoVersao &= "Cadastro Banco - Mais completo." & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.8 - 21/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Inventário - Barra de rolagem automática;" & vbCrLf
        HistoricoVersao &= "Inventário - Inclusão dos botões visualizar produtos adicionados e produtos não adicionados." & vbCrLf
        HistoricoVersao &= "Comanda - Correção Impressão;" & vbCrLf
        HistoricoVersao &= "Relatório Entrada NF - Inclusão da coluna Estoque Ok, informa se o estoque foi atualizado ou não;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.7 - 14/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Quando o sistema tiver confgurado para gerar comissão será obrigatório informar o vendedor;" & vbCrLf
        HistoricoVersao &= "Relatório de Comissão - Inclusão de um contador de vendas." & vbCrLf
        HistoricoVersao &= "Comanda - Impressão da entrega e retirada;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.6 - 12/01/2015"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Conta Receber - Opção se deseja imprimir o recibo;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção ao inserir tamanho." & vbCrLf
        'HistoricoVersao &= "Custodio pedido sem codigo interno;" & vbCrLf
        'HistoricoVersao &= "Porta finessi impressao;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.5 - 15/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Fluxo de caixa por período;" & vbCrLf
        HistoricoVersao &= "Caixa - Tranferência para banco;" & vbCrLf
        HistoricoVersao &= "Relatório Consumo - Tirar coluna tamanho se a consulta não for por produto;" & vbCrLf
        HistoricoVersao &= "Gráficos - Implantação do gráfico de contas a pagar e pagas;" & vbCrLf
        HistoricoVersao &= "Gráficos - Implantação do gráfico de contas a receber e recebidas;" & vbCrLf
        HistoricoVersao &= "MDI Analyzer - Implantação da consulta de pedidos em aberto no MDI Analyzer;" & vbCrLf
        HistoricoVersao &= "Venda - Ao excluir um item da venda se a qtde for maior que um, tem a opção de escolher a qtde a ser excluída;" & vbCrLf
        HistoricoVersao &= "Fluxo de Caixa - Inclusão do saldo atual caixa." & vbCrLf
        'HistoricoVersao &= "Gerar Codigo Interno Produto verificar se ja existe;" & vbCrLf
        'HistoricoVersao &= "Correção Baixar cartoes;" & vbCrLf

        'HistoricoVersao &= "Na Venda pode clicar no meio pra abrir pagamento cliente ou desconto;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.4 - 10/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impressão - Opção de remover o código de barra na impressão de cupom não fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.3 - 01/12/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impressão - Alterações, correções e melhorias na impressão de cupom não fiscal." & vbCrLf
        HistoricoVersao &= "Conta Receber - Adicionado o botão de 'Relatório de Venda' para consultar o itens vendidos." & vbCrLf
        HistoricoVersao &= "Conta Receber - Adicionado o botão de 'Remover Parcela' caso o cliente desista de pagar alguma parcela." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.2 - 18/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impressão - Alterações, correções e melhorias na impressão de cupom não fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.1 - 17/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Impressão - Alteração na impressão da venda em cupom não fiscal." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.2.0 - 12/11/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Botão para Consulta de Produtos;" & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Impressão de Etiqueta Pimaco Modelo A4348;" & vbCrLf
        HistoricoVersao &= "Produto - Adicionado Impressão de Etiqueta Pimaco Modelo A4360;" & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Consultar Produtos;" & vbCrLf
        HistoricoVersao &= "Devolução - Impressão da Devolução em impressoras fiscais;" & vbCrLf
        HistoricoVersao &= "Pedido - A exclusão de Pedidos só será permitida por usuários Administradores;" & vbCrLf
        HistoricoVersao &= "Pedido - Na Consulta dos Pedidos agora é possivel visualizar a coluna Total;" & vbCrLf
        HistoricoVersao &= "Pedido - Na Consulta dos Pedidos agora é possivel imprimir a consulta;" & vbCrLf
        HistoricoVersao &= "Venda - Adicionado a Opção 'Imprimir Direto' que permite optar por imprimir a venda ou não;" & vbCrLf

        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.9 - 31/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Bloqueio Usuário - Nano Analyzer;" & vbCrLf
        HistoricoVersao &= "Nano Analyzer - Gráfico por funcionário informar pelo código;" & vbCrLf
        HistoricoVersao &= "Nano Analyzer - Correção gráfico por funcionário;" & vbCrLf
        'cadastro produto custo e venda zerados da erro na porcentagem
        'Entrada Nf xml cadastrar fornecedor setar coluna inativo
        'Entrada Nf xml produto com o mesmo nome e codigo de barras diferentes esta cadastrando um só
        'Nfe pasta compartilhada
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.8 - 27/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Impressão da observação do Pedido para Auto Peças;" & vbCrLf
        HistoricoVersao &= "Implantação do Nano Analyzer" & vbCrLf & "Agora será possível a visualização por Administradores das seguintes funções:" & vbCrLf & "Gráficos de Vendas semanal ou a cada 10 dias." & vbCrLf & "Gráfico de Vendas por Funcionário, diário ou semanal." & vbCrLf & "Resumo diário de Contas a Receber, Contas a Pagar, Clientes Aniversariantes e Resumo do Caixa." & vbCrLf & "Com a Agenda de Compromissos você conseguirá organizar o seu dia, com a criação de eventos será possivel receber alertas que lhe informarão a data e hora do seu compromisso. A agenda também mostrará suas contas e os aniversariantes de cada dia." & vbCrLf & "Com o Canal Era Systems você poderá enviar elogios, críticas e sugestões além de pedir suporte pelo próprio sistema." & vbCrLf & "E aqui onde você está lendo essas informações é o Histórico de Versões, onde você encontrará tudo o que há novo no seu sistema Nano." & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.7 - 21/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Relatório Entrada NF Itens - Adicionado Coluna 'Valor Venda';" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Colocado código município na tela;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.6 - 08/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Implantação de controle de clientes pela Era Systems;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'Atualizar("Update Config set VersaoNano ='2.1.6'")
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.5 - 06/10/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Campo de validade do produto;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Campo para inativar fornecedor;" & vbCrLf
        HistoricoVersao &= "Envio de E-mail - Correção para envio por qualquer servidor;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.4 - 29/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Usuário - Correção de mensagem ao abrir a tela;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.3 - 29/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Impressão dos dados completo do cliente;" & vbCrLf
        HistoricoVersao &= "Relatório de Giro - Correção de ortografia;" & vbCrLf
        HistoricoVersao &= "Cupom Fiscal - Correção de ortografia no Espelho;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.2 - 24/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'If para MSG impressão Cavalão Auto Peças no pedido
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.1 - 22/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        'If para impressão Código Barra Cavalão Auto Peças
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.1.0 - 15/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Layout das telas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.9 - 15/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Opção de segunda via do cupom;" & vbCrLf
        'HistoricoVersao &= "Funcionário - Implantação Crédito e Débito;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.8 - 09/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Opção de vários emitentes;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.7 - 08/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Colocado Código ANP Combustível pra quem emite NF-e;" & vbCrLf
        HistoricoVersao &= "NF-e - Colocado Código ANP Combustível;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.6 - 02/09/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Qtde mínima se estiver vazio, inserir zero;" & vbCrLf
        HistoricoVersao &= "Venda - Incluir Mecânico na Venda apenas pelo botão;" & vbCrLf
        HistoricoVersao &= "Pedido Impressão - Colocar valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocado campo que mostra número de itens;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################
        '###################################################
        HistoricoVersao &= "Versão 2.0.5 - 29/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Config - Colocado Tipo Nano para Auto Peças;" & vbCrLf
        HistoricoVersao &= "Venda - Incluir Mecânico na Venda;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Correção do Representante;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.4 - 19/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Correção forma de pagamento ao selecionar crediário e cancelar;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Na aba NF-e na opção de 'Inserir para todos', perguntar se é pra inserir NCM também;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.3 - 07/08/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Implantação de etiquetas Label Pimaco;" & vbCrLf
        HistoricoVersao &= "NF-e - Implantação do NANO NF-e;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.2 - 17/07/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Comanda - Correção comanda zerada;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.1 - 16/07/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Correção da tela de tamanhos do produto;" & vbCrLf
        HistoricoVersao &= "Correção Nano Print;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 2.0.0 - 14/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Função Estoque Somado;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################
        '###################################################
        HistoricoVersao &= "Versão 1.9.9 - 10/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Correção 'de olho no imposto';" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.8 - 09/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Pedido - Correção na alteração de item;" & vbCrLf
        HistoricoVersao &= "Implantação Nano Print;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.7 - 09/06/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Sistema - Opção 'Estoque Somado';" & vbCrLf
        HistoricoVersao &= "Entrada NF - Limpar filtro antes de salvar;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Limpar campos se não existir nota cadastrada;" & vbCrLf
        HistoricoVersao &= "Imagem Nano Commerce no grafico e Entrada NF;" & vbCrLf
        HistoricoVersao &= "Relatório Log - Alteração de valor de venda do produto;" & vbCrLf
        HistoricoVersao &= "Relatório Log - Alteração de valor de custo do produto;" & vbCrLf
        HistoricoVersao &= "Relatório Log - Cadastro de produto;" & vbCrLf
        HistoricoVersao &= "Relatório Log - Alteração do nome fantasia do Fornecedor;" & vbCrLf
        HistoricoVersao &= "Pedido - Impressão com a data da venda;" & vbCrLf
        HistoricoVersao &= "Venda - Se emitir cupom fiscal permitir informar o cliente sem CPF/CNPJ;" & vbCrLf
        HistoricoVersao &= "Venda - Se o usuário tiver nível de 'USUARIO', não aparecer coluna valor de custo do produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocar desconto por produto;" & vbCrLf
        HistoricoVersao &= "Pedido - Se o produto estiver em promoção, informar o preço já com o desconto;" & vbCrLf
        HistoricoVersao &= "Pedido - Colocar coluna valor sem desconto;" & vbCrLf
        HistoricoVersao &= "Venda - Trazer o pedido com os descontos de promoção;" & vbCrLf
        HistoricoVersao &= "Funcionário - Não aparecer em nenhum cadastro se estiver inativo;" & vbCrLf
        HistoricoVersao &= "Funcionário - Implantação do relatório de comissão somado;" & vbCrLf
        HistoricoVersao &= "Devolução - Colocado coluna código do produto;" & vbCrLf
        HistoricoVersao &= "Relatório Devolução - Colocado coluna código do produto;" & vbCrLf
        HistoricoVersao &= "Relatório de Giro - Ajustado para estoque somado ;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Opção de casdatrar produtos pela Entrada de NF;" & vbCrLf
        HistoricoVersao &= "Config - Colocado 'de olho no imposto' fixo;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Não cadastrar duas vezes produtos iguais;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Colocado campo código de barras;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.6 - 19/05/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Correção de cidades com aspas pelo Cep;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Correção de cidades com aspas pelo Cep;" & vbCrLf
        HistoricoVersao &= "NF-e - Correção cálculo de crédito;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.5 - 05/05/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Colocar código da loja;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Opção de estornar uma conta baixada;" & vbCrLf
        HistoricoVersao &= "Conta Pagar - Opção de estornar uma conta baixada;" & vbCrLf
        HistoricoVersao &= "Pedido - Correção na impressão do cupom;" & vbCrLf
        HistoricoVersao &= "Venda - Imprimir em impressora normal;" & vbCrLf
        HistoricoVersao &= "Conta Receber - Imprimir recibo em impressora normal;" & vbCrLf
        HistoricoVersao &= "Cadastro de Produto - Correção CFOP na alteração;" & vbCrLf
        HistoricoVersao &= "Venda - Abrir gaveta com impressora fiscal;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Nova busca de Cep;" & vbCrLf
        HistoricoVersao &= "Cadastro de Fornecedor - Novo Busca de Cep;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção do XML com aspas e faltando cabeçalho;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.4 - 28/04/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Cupom Fiscal - Correção do cálculo com desconto;" & vbCrLf
        HistoricoVersao &= "Entrada NF - Correção ao atualizar Estoque com unidade medida diferente do cadastro de produtos;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.3 - 07/04/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "NF-e - Função para Inutilização de Numeração;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.2 - 17/03/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Venda - Alteração da fonte dos Produtos Vendidos;" & vbCrLf
        'HistoricoVersao &= "Venda - Alteração dos campos total e sub total para nano campo;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        '###################################################
        HistoricoVersao &= "Versão 1.9.1 - 03/03/2014"
        HistoricoVersao &= vbCrLf & vbCrLf
        HistoricoVersao &= "Caixa - Emissão de Comprovante;" & vbCrLf
        HistoricoVersao &= "Relatório - Relatório de Comandas;" & vbCrLf
        HistoricoVersao &= "Cadastro de Cliente - Imprimir etiqueta com a opção de selecionar qual e quantas;" & vbCrLf
        HistoricoVersao &= vbCrLf & vbCrLf
        '###################################################

        'O HISTÓRIO DE VERSÃO FOI INVERTIDO, AGORA A ÚLTIMA ATUALIZAÇÃO APARECE EM PRIMEIRO LUGAR, POR ISSO VOLTE LÁ PRA CIMA


    End Function
End Class
