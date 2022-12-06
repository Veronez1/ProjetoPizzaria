public class Usuario{

  // Atributos
  public static long count;
  public long id;
  public string nome;
  public string senha;
  public string perfil;
  public Pedido pedido;

  // Faz o usuario criar um pedido
  public Pedido criarPedido(string sabor, string tamanho, double preco, long cpfCliente){
    
    pedido = new Pedido();
    pedido.pizza = new Pizza();
    pedido.pizza.setSabor(sabor);
    pedido.pizza.setTamanho(tamanho);
    pedido.pizza.setPreco(preco);
    
    pedido.cliente = new Cliente();
    pedido.cliente.setCpf(cpfCliente);

    return pedido;
  }

  // Autentica um usuario
  public bool autententicador(string perfil ,string senha){
    if(this.senha == senha && this.perfil == perfil)
      return true;
    else
      return false;
  }
  
  // Construtor Padrão
   public Usuario()
   {
    
   }

  // Construtor Personalizado
  public Usuario(string nome, string perfil, string senha)
  {
    this.id = count++;
    this.nome = nome;
    this.senha = senha;
    this.perfil = perfil;
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

    public void setNome(string value)
    {
      nome = value;
    }

    public string getNome()
    {
      return nome;
    }

    public void setSenha(string value)
    {
      senha = value;
    }

    public string getSenha()
    {
      return senha;
    }

    public void setPerfil(string value)
    {
      perfil = value;
    }

    public string getPerfil()
    {
      return perfil;
    }

}