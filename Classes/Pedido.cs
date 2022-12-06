public class Pedido
{
  // Atributos
  public static long count;
  public long id;
  public Pizza pizza;
  public Cliente cliente;

  // Construtor
  public Pedido(){
    count++;
    this.id = count;
  }
  
  // Getters and Setters
  public void setId(long value)
  {
    id = value;
  }

  public long getId()
  {
    return id;
  }
}