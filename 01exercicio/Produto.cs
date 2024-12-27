class Produto
{
  public string? Nome { get; set; }
  public double Valor { get; set; }
  public string? FormaPagamento { get; set; }


  public void Mensagem()
  {
    double valorFinalComDesconto = Valor - (Valor * 0.10);
    double calculoValor = Valor >= 500 && FormaPagamento == "à vista" ? valorFinalComDesconto : Valor;

    Console.WriteLine($"O produto {Nome} será pago de maneira: {FormaPagamento} no valor de R${calculoValor}");
  }
}