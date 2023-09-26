/*
 * Desafio de codificação – Reportar as IDs de pedido que precisam de uma 
 * investigação mais aprofundada Sua equipe encontrou um padrão. Pedidos 
 * que começam com a letra "B" têm uma taxa de incidência de fraude 
 * 25 vezes maior que o normal. Você escreverá um novo código para 
 * imprimir na saída a ID de novos pedidos que comecem com a letra "B". 
 * Isso será usado pela nossa equipe anti-fraude para investigar mais a fundo.
 * */

string[] IDsPedidosFraudulentos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string IDs in IDsPedidosFraudulentos)
{
    if (IDs.StartsWith("B"))
    {
        Console.WriteLine(IDs);
    }
}