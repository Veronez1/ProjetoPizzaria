public class Pizza
{
  // Atributos
  public string sabor;
  public string tamanho;
  public double preco;
  
  // Construtor Padrão
  public Pizza()
  {

  }

  // Construtor Personalizado
  public Pizza(string sabor, string tamanho, double preco)
  {
    this.sabor = sabor;
    this.tamanho = tamanho;
    this.preco = preco;
  }

  // Getters and Setters
  public void setSabor(string value)
  {
    sabor = value;
  }

  public string getSabor()
  {
    return sabor;
  }

  public void setTamanho(string value)
  {
    tamanho = value;
  }

  public string getTamanho()
  {
    return tamanho;
  }

  public void setPreco(double value)
  {
    preco = value;
  }

  public double getPreco()
  {
    return preco;
  }

}