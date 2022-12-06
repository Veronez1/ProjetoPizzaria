public class Cliente{
  
  // Atributos
  public long cpf;
  public string nome;
  public string endereco;

   // Getters and Setters
  public void setNome(string value){
    nome = value;
  }

  public string getNome(){
    return nome;
  }

  public void setEndereco(string value){
    endereco = value;
  }

  public string getEndereco(){
    return endereco;
  }

  public void setCpf(long value){
    cpf = value;
  }

  public long getCpf(){
    return cpf;
  }

}