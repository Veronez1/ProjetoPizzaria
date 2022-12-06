using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("====> Bem vindo a Pizzaria do seu Zé <====\n\n");
        // Cria Usuario Administrador
        Usuario usuario = new Usuario("Davi Veronez", "d", "1");


        Console.WriteLine("Para entrar no sistema\n" +
                          "Digite seu perfil de usuario:");
        var perfil = Console.ReadLine();

        Console.WriteLine("Digite sua senha:");
        var senha = Console.ReadLine();

        // Valida a senha do usuario para liberar entrada no sistema
        var validado = usuario.autententicador(perfil, senha);

        if (validado)
        {
            Console.WriteLine("Pode entrar no sistema\n");
        }
        else
        {
            Console.WriteLine("Não pode entrar no sistema\n");
        }

        // Enquanto o usuario for true executa o sistema
        while (validado)
        {
            int opcao;
            string sabor = "";
            string tamanho = "";
            double preco = 0;
            long cpfCliente = 0;



            Console.WriteLine("*********** MENU ***********\n" +
                              // "****************************\n" +
                              "1 - Cadastrar novo Usuario\n" +
                              "2 - Cadastrar novo Cliente\n" +
                              "3 - Criar novo pedido\n" +
                              "0 - Sair\n" +
                              "****************************\n");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    validado = false;
                    break;
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
            Console.WriteLine("Para qual Cliente será este pedido?\n" +
                                        "Digite o CPF do Cliente:\n");

            cpfCliente = long.Parse(Console.ReadLine());

            // Console.WriteLine("Escolha o sabor da pizza: \n" +
            //                   "1 - Mussarela\n" +
            //                   "2 - Calabresa\n");
            
            Console.WriteLine("Registre uma pizza: \n");
            // opcao = int.Parse(Console.ReadLine());

            //Pizza sabor = new Pizza("Mussarela", "Grande", 55);
            // switch (opcao)
            // {
            //     case 1:
            //         sabor = "Mussarela";
            //         break;
            //     case 2:
            //         sabor = "Calabresa";
            //         break;
            // }
                 
            Console.WriteLine("Escolha o tamanho da pizza: \n" +
                              "1 - Grande\n" +
                              "2 - Media\n" +
                              "3 - Pequena\n");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    tamanho = "Grande";
                    break;
                case 2:
                    tamanho = "Media";
                    break;
                case 3:
                    tamanho = "Pequena";
                    break;
            }

            Console.WriteLine("Digite o valor a ser pago:");


            preco = double.Parse(Console.ReadLine());

            Pedido pedido = usuario.criarPedido(sabor, tamanho, preco, cpfCliente);

            Console.WriteLine("===========================");
            Console.WriteLine("========== PEDIDO =========");
            Console.WriteLine("===========================");
            
Console.WriteLine("pedido: " + pedido.getId());
            Console.WriteLine("Pizza N°1: \n" + 
                              "Sabor:        " + pedido.pizza.getSabor());
            Console.WriteLine("Tamanho:      " + pedido.pizza.getTamanho());                   Console.WriteLine("Preço:      " + pedido.pizza.getPreco()         
                             );
          


Console.WriteLine("Pizza N°2: \n");
            // Console.WriteLine("Id do pedido: " + pedido.getId());
            //                     Console.WriteLine("Pizza N°1: \n" + 
            //                                       "Sabor:        " + pedido.pizza.getSabor());
            //                     Console.WriteLine("Tamanho:      " + pedido.pizza.getTamanho());
            //                     Console.WriteLine("Preço:        R$" + pedido.pizza.getPreco());

            // Console.WriteLine("Pizza N°2: \n");
            //                     Console.WriteLine("Cliente:      " + pedido.cliente.getCpf());                
            //                 Console.WriteLine("===========================\n");
            break;
        }
    }
}

        

    



    // //############

    // // int Sabor;
    // // int Tamanho;
    // // int Pagamento;    

    // // Console.WriteLine("Digite o sabor desejado: ");
    // //  Sabor=int.Parse(Console.ReadLine());
    // //   if (Sabor==1)
    // //   {
    //     Console.WriteLine("Sabor escolido: Mussarela");
    //   }else if(Sabor==2){
    //     Console.WriteLine("Escolha o tamanho da pizza: \n" +
    //                        "1 - Pequena\n" +
    //                        "2 - Média\n" +
    //                        "3 - Grande\n");
    //   }     Tamanho=int.Parse(Console.ReadLine());             
    //     if (Tamanho==1){
    //       Console.WriteLine("O preço da pizza de Calabresa pequena é 25,90:\n"+
    //                    "Escolha a forma de pagamento: \n" +
    //                        "1 - Débito\n" +
    //                        "2 - Crédito\n" +
    //                        "3 - dinheiro\n"    );
    //     }
    // Pagamento=int.Parse(Console.ReadLine());   if (Pagamento==1){
    //      Console.WriteLine("Pagamento realizado por débito");
    //    }

    // Pizza pizza = new Pizza("Mussarela", "Grande", 55);

    // Console.WriteLine(pizza.getSabor());
    // Console.WriteLine(pizza.getTamanho());
    // Console.WriteLine(pizza.getPreco());


    // Pizza pizza = new Pizza();
    // // Pizza pizza2 = new Pizza();

    // pizza.setSabor("Mussarela");
    // pizza.setTamanho("Grande");
    // pizza.setPreco(55); 

    // Usuario usuario = new Usuario();

    // usuario.setId(1);
    // usuario.setNome("Davi");
    // usuario.setPerfil("davi.veronez");
    // usuario.setSenha("12345");

    // Console.WriteLine(usuario.getId());
    // Console.WriteLine(usuario.getNome());
    // Console.WriteLine(usuario.getPerfil());


    // Usuario usuario2 = new Usuario(2,"Daniel","daniel.veronez","12345");









    // Usuario cria um pedido e cadastra um cliente


    // Console.WriteLine( );


