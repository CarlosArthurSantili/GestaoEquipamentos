using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoEquipamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeEquipamentoCadastrado = 0;
            int quantidadeManutencaoCadastrado = 0;
            int opcaoMenu = 0;

            int[] idEquipamentoCadastrado = new int[99];
            string[] nomeEquipamentoCadastrado = new string[99];
            string[] numeroSerieEquipamentoCadastrado = new string[99];
            double[] valorAquisicaoEquipamentoCadastrado = new double[99];
            DateTime[] dataFabricacaoEquipamentoCadastrado = new DateTime[99];
            string[] fabricanteEquipamentoCadastrado = new string[99];

            int[] idManutencaoCadastrado = new int[99];
            string[] tituloManutencaoCadastrado = new string[99];
            string[] descricaoManutencaoCadastrado = new string[99];
            int[] idEquipamentoManutencaoCadastrado = new int[99];
            DateTime[] dataAberturaManutencaoCadastrado = new DateTime[99];

            while (opcaoMenu != 3)
            {
                Console.WriteLine("Menu Inicial:");
                Console.WriteLine("Opção 1 - Equipamento");
                Console.WriteLine("Opção 2 - Manutenção");
                Console.WriteLine("Opção 3 - Sair da aplicação");

                Console.WriteLine("Digite a opcao desejada: ");
                opcaoMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (opcaoMenu)
                {
                    case 1: //Opcao Equipamentos
                        {
                            int opcaoEquipamento = '0';
                            while (opcaoEquipamento != 5)
                            {
                                Console.WriteLine("Menu de Equipamento:");
                                Console.WriteLine("Opção 1 - Cadastrar");
                                Console.WriteLine("Opção 2 - Editar");
                                Console.WriteLine("Opção 3 - Excluir");
                                Console.WriteLine("Opção 4 - Mostrar");
                                Console.WriteLine("Opção 5 - Voltar ao Menu");

                                Console.WriteLine("Digite a opcao desejada: ");
                                opcaoEquipamento = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                //Cadastro de Equipamento
                                if (opcaoEquipamento == 1)
                                {
                                    //Console.WriteLine("Cadastrar Equipamento");
                                    Console.WriteLine("Informe o nome do equipamento:");
                                    String nomeEquipamento = Console.ReadLine();

                                    Console.WriteLine("Informe o preço de aquisição do equipamento:");
                                    int valorAquisicaoEquipamento = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Informe o número de série do equipamento:");
                                    String numeroSerieEquipamento = Console.ReadLine();
                                    
                                    DateTime dataFabricacaoEquipamento;
                                    try
                                    {
                                        Console.WriteLine("Informe a data de fabricação do equipamento:");
                                        dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());

                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Data inválida, tente novamente");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }

                                    //dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());

                                    Console.WriteLine("Informe o fabricante do equipamento:");
                                    String fabricanteEquipamento = Console.ReadLine();

                                    Console.Clear();

                                    int idCorrecao = 0; //vai armazenar o equipamento no primeiro id zero que achar
                                    foreach(int id in idEquipamentoCadastrado)
                                    {
                                        if (id==0)
                                        {
                                            idEquipamentoCadastrado[idCorrecao] = idCorrecao + 1;
                                            nomeEquipamentoCadastrado[idCorrecao] = nomeEquipamento;
                                            valorAquisicaoEquipamentoCadastrado[idCorrecao] = valorAquisicaoEquipamento;
                                            numeroSerieEquipamentoCadastrado[idCorrecao] = numeroSerieEquipamento;
                                            dataFabricacaoEquipamentoCadastrado[idCorrecao] = dataFabricacaoEquipamento;
                                            fabricanteEquipamentoCadastrado[idCorrecao] = fabricanteEquipamento;
                                            break;
                                        }
                                        idCorrecao++;
                                    }

                                    quantidadeEquipamentoCadastrado++;
                                    //break;
                                }

                                //Editar Equipamento
                                else if (opcaoEquipamento == 2)
                                {
                                    int opcaoAlterarEquipamentoCampoSelecionado = 0;
                                    int opcaoAlterarEquipamentoSelecionado = 0;

                                    Console.Write("IDs dos Equipamentos Cadastrados: ");
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (id!=0)
                                        {
                                            Console.Write(id);
                                            Console.Write("  ");
                                        }
                                        
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Digite qual o id do equipamento que você deseja alterar: ");
                                    opcaoAlterarEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());
                                    


                                    int checaId = 0;
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (id == opcaoAlterarEquipamentoSelecionado)
                                        {
                                            checaId++;
                                            //caso valor seja 1, terá encontrado apenas 1 valor correspondente
                                            //caso valor seja maior que 1, terá encontrado mais que 1 valor correspondente
                                        }
                                    }
                                    if ((opcaoAlterarEquipamentoSelecionado == 0) || (checaId != 1))
                                    {
                                        Console.WriteLine("Valor de id inválido, tente novamente");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else 
                                    {
                                        opcaoAlterarEquipamentoSelecionado--;
                                        //isso acontece porque o vetor começa em 0, e não em 1
                                        Console.Clear();

                                        Console.WriteLine("Digite 1 para alterar nome");
                                        Console.WriteLine("Digite 2 para alterar valor de aquisição");
                                        Console.WriteLine("Digite 3 para alterar número de série");
                                        Console.WriteLine("Digite 4 para alterar data fabricação");
                                        Console.WriteLine("Digite 5 para alterar fabricante");
                                        opcaoAlterarEquipamentoCampoSelecionado = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();

                                        if (opcaoAlterarEquipamentoCampoSelecionado == 1)
                                        {
                                            Console.WriteLine("Digite o novo valor de nome");
                                            nomeEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = Console.ReadLine();
                                        }
                                        else if (opcaoAlterarEquipamentoCampoSelecionado == 2)
                                        {
                                            Console.WriteLine("Digite o novo valor de valor de aquisição");
                                            valorAquisicaoEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (opcaoAlterarEquipamentoCampoSelecionado == 3)
                                        {
                                            Console.WriteLine("Digite o novo valor de número de série");
                                            numeroSerieEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = Console.ReadLine();
                                        }
                                        else if (opcaoAlterarEquipamentoCampoSelecionado == 4)
                                        {
                                            Console.WriteLine("Digite o novo valor de data de fabricação");
                                            DateTime dataFabricacaoEquipamento;
                                            try
                                            {
                                                dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Data inválida, tente novamente");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            }
                                            dataFabricacaoEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = Convert.ToDateTime(Console.ReadLine());
                                        }
                                        else if (opcaoAlterarEquipamentoCampoSelecionado == 5)
                                        {
                                            Console.WriteLine("Digite o novo valor de fabricante");
                                            fabricanteEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Opção de campo inválido, tente novamente");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                    }
                                    



                                }

                                //Excluir Equipamento
                                else if (opcaoEquipamento == 3)
                                {
                                    int opcaoAlterarEquipamentoSelecionado = 0;

                                    Console.Write("IDs dos Equipamentos Cadastrados: ");
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (id != 0)
                                        {
                                            Console.Write(id);
                                            Console.Write("  ");
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Digite qual o índice do equipamento que você deseja EXCLUIR: ");
                                    opcaoAlterarEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());
                                    if (opcaoAlterarEquipamentoSelecionado == 0)
                                    {
                                        Console.WriteLine("Valor de id inválido, tente novamente");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }

                                    opcaoAlterarEquipamentoSelecionado--;
                                    //isso acontece porque o vetor começa em 0, e não em 1

                                                                       
                                    Console.Clear();

                                    quantidadeEquipamentoCadastrado--;
                                    idEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = 0;
                                    nomeEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = null;                                    
                                    valorAquisicaoEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = 0;                                    
                                    numeroSerieEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = null;                                    
                                    dataFabricacaoEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = DateTime.MinValue;                                    
                                    fabricanteEquipamentoCadastrado[opcaoAlterarEquipamentoSelecionado] = null;
                                    
                                }

                                //Mostrar Equipamento
                                else if (opcaoEquipamento == 4)
                                {
                                    int contador = 0;
                                    int qtdEquipamentos = 0;
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (idEquipamentoCadastrado[contador] != 0)
                                            qtdEquipamentos++;
                                        contador++;
                                    }
                                    if (qtdEquipamentos == 0)
                                    {
                                        Console.WriteLine("Não há equipamentos cadastrados");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        contador = 0;
                                        Console.WriteLine("Equipamentos Cadastrados: ");
                                        foreach (int id in idEquipamentoCadastrado)
                                        {
                                            if (id != 0) 
                                            {
                                                Console.Write("Nome:");
                                                Console.WriteLine(nomeEquipamentoCadastrado[contador]);

                                                Console.Write("Valor Aquisição:");
                                                Console.WriteLine(valorAquisicaoEquipamentoCadastrado[contador]);

                                                Console.Write("Número de Série:");
                                                Console.WriteLine(numeroSerieEquipamentoCadastrado[contador]);

                                                Console.Write("Data Fabricação:");
                                                Console.WriteLine(dataFabricacaoEquipamentoCadastrado[contador].ToShortDateString());

                                                Console.Write("Fabricante:");
                                                Console.WriteLine(fabricanteEquipamentoCadastrado[contador]);

                                                
                                                Console.WriteLine();
                                                Console.WriteLine();
                                            }
                                            contador++;

                                        }
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }

                                //Voltar ao Menu Inicial
                                else if (opcaoEquipamento == 5)
                                {
                                    break;
                                } 

                                //Opcao de Menu Equipamento Inválida
                                else
                                {
                                    Console.WriteLine("Opção de menu equipamento inválida, tente novamente");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        }
                    case 2: //Opcao Manutencao
                        {
                            int opcaoManutencao = 0;
                            while (opcaoManutencao != 5)
                            {
                                Console.WriteLine("Menu de Manutencao:");
                                Console.WriteLine("Opção 1 - Cadastrar");
                                Console.WriteLine("Opção 2 - Editar");
                                Console.WriteLine("Opção 3 - Excluir");
                                Console.WriteLine("Opção 4 - Mostrar");
                                Console.WriteLine("Opção 5 - Voltar ao Menu");

                                Console.WriteLine("Digite a opcao desejada: ");
                                opcaoManutencao = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                //cadastrar manutencao
                                if (opcaoManutencao == 1)
                                {
                                    //Manutencao (titulo, descricao, equipamento, dataAbertura)
                                    Console.WriteLine("Informe o titulo da manutenção:");
                                    string tituloManutencao = Console.ReadLine();

                                    Console.WriteLine("Informe a descrição da manutenção:");
                                    string descricaoManutencao = Console.ReadLine();

                                    Console.WriteLine("Informe o indice do equipamento da manutencao:");
                                    int idEquipamentoManutencao = Convert.ToInt32(Console.ReadLine());

                                    int validaIdEquipamento = 0;
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (idEquipamentoManutencao == id)
                                            validaIdEquipamento++;
                                    }
                                    if (validaIdEquipamento!=1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Valor de ID inválido, tente novamente");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Informe a data de abertura da manutenção:");

                                        DateTime dataAberturaManutencao;
                                        try
                                        {
                                            dataAberturaManutencao = Convert.ToDateTime(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Data inválida, tente novamente");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }

                                        //dataAberturaManutencao = Convert.ToDateTime(Console.ReadLine());

                                        Console.Clear();

                                        int idCorrecao = 0; //vai armazenar a manutencao no primeiro id zero que achar
                                        foreach (int id in idManutencaoCadastrado)
                                        {
                                            if (id == 0)
                                            {
                                                quantidadeManutencaoCadastrado++;
                                                idManutencaoCadastrado[idCorrecao] = idCorrecao + 1;
                                                tituloManutencaoCadastrado[idCorrecao] = tituloManutencao;
                                                descricaoManutencaoCadastrado[idCorrecao] = descricaoManutencao;
                                                idEquipamentoManutencaoCadastrado[idCorrecao] = idEquipamentoManutencao;
                                                dataAberturaManutencaoCadastrado[idCorrecao] = dataAberturaManutencao;
                                                break;
                                            }
                                            idCorrecao++;
                                        }
                                    }
                                }

                                //editar manutencao
                                else if (opcaoManutencao == 2)
                                {
                                    int opcaoAlterarManutencaoCampoSelecionado = 0;
                                    int opcaoAlterarManutencaoSelecionado = 0;
                                    int qtdManutencao = 0;

                                    foreach (int id in idManutencaoCadastrado)
                                    {
                                        if (id != 0)
                                            qtdManutencao++;
                                    }
                                    if (qtdManutencao == 0)
                                    {
                                        Console.WriteLine("Não há manutenções cadastradas");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {

                                        Console.Write("IDs das Manutenções Cadastrados: ");
                                        foreach (int id in idManutencaoCadastrado)
                                        {
                                            if (id != 0)
                                            {
                                                Console.Write(id);
                                                Console.Write("  ");
                                            }

                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Digite qual o id da manutenção que você deseja alterar: ");
                                        opcaoAlterarManutencaoSelecionado = Convert.ToInt32(Console.ReadLine());

                                        int checaId = 0;
                                        foreach (int id in idEquipamentoCadastrado)
                                        {
                                            if (id == opcaoAlterarManutencaoSelecionado)
                                            {
                                                checaId++;
                                                //caso valor seja 1, terá encontrado apenas 1 valor correspondente
                                                //caso valor seja maior que 1, terá encontrado mais que 1 valor correspondente
                                            }
                                        }
                                        if ((opcaoAlterarManutencaoSelecionado == 0) || (checaId != 1))
                                        {
                                            Console.WriteLine("Valor de id manutencao inválido, tente novamente");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            opcaoAlterarManutencaoSelecionado--;
                                            //isso acontece porque o vetor começa em 0, e não em 1
                                            Console.Clear();

                                            Console.WriteLine("Digite 1 para alterar titulo");
                                            Console.WriteLine("Digite 2 para alterar descrição");
                                            Console.WriteLine("Digite 3 para alterar id do equipamento");
                                            Console.WriteLine("Digite 4 para alterar data de abertura");
                                            opcaoAlterarManutencaoCampoSelecionado = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();

                                            if (opcaoAlterarManutencaoCampoSelecionado == 1)
                                            {
                                                Console.WriteLine("Digite o novo valor de titulo");
                                                tituloManutencaoCadastrado[opcaoAlterarManutencaoSelecionado] = Console.ReadLine();
                                            }
                                            else if (opcaoAlterarManutencaoCampoSelecionado == 2)
                                            {
                                                Console.WriteLine("Digite o novo valor de descrição");
                                                descricaoManutencaoCadastrado[opcaoAlterarManutencaoSelecionado] = Console.ReadLine();
                                            }
                                            else if (opcaoAlterarManutencaoCampoSelecionado == 3)
                                            {
                                                Console.WriteLine("Digite o novo valor de 'ID do Equipamento'");
                                                int novoId = Convert.ToInt32(Console.ReadLine());
                                                int validaId = 0;
                                                //checar se o novo id existe em equipamento
                                                foreach (int id in idEquipamentoCadastrado)
                                                {
                                                    if (id == novoId)
                                                    {
                                                        validaId++;
                                                        //caso valor seja 1, terá encontrado apenas 1 valor correspondente
                                                        //caso valor seja maior que 1, terá encontrado mais que 1 valor correspondente
                                                    }
                                                }

                                                if (validaId == 1)
                                                {
                                                    idEquipamentoManutencaoCadastrado[opcaoAlterarManutencaoSelecionado] = novoId;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Não há equipamento cadastrado com esse id, tente novamente");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                            }
                                            else if (opcaoAlterarManutencaoCampoSelecionado == 4)
                                            {
                                                Console.WriteLine("Digite o novo valor de data de abertura");

                                                DateTime dataAberturaManutencaoTestado;
                                                try
                                                {
                                                    dataAberturaManutencaoTestado = Convert.ToDateTime(Console.ReadLine());
                                                }
                                                catch
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data inválida, tente novamente");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }

                                                dataAberturaManutencaoCadastrado[opcaoAlterarManutencaoSelecionado] = dataAberturaManutencaoTestado;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opção de campo inválido, tente novamente");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                }

                                //excluir manutencao
                                else if (opcaoManutencao == 3)
                                {
                                    int opcaoExcluirManutencaoSelecionado = 0;

                                    Console.Write("IDs das Manutenções Cadastradas: ");
                                    foreach (int id in idManutencaoCadastrado)
                                    {
                                        if (id != 0)
                                        {
                                            Console.Write(id);
                                            Console.Write("  ");
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Digite qual o id da manutenção que você deseja EXCLUIR: ");
                                    opcaoExcluirManutencaoSelecionado = Convert.ToInt32(Console.ReadLine());


                                    int checaId = 0;
                                    foreach (int id in idEquipamentoCadastrado)
                                    {
                                        if (id == opcaoExcluirManutencaoSelecionado)
                                        {
                                            checaId++;
                                            //caso valor seja 1, terá encontrado apenas 1 valor correspondente
                                            //caso valor seja maior que 1, terá encontrado mais que 1 valor correspondente
                                        }
                                    }

                                    if ((opcaoExcluirManutencaoSelecionado == 0)||(checaId!=1))
                                    {
                                        Console.WriteLine("Valor de id inválido, tente novamente");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }

                                    opcaoExcluirManutencaoSelecionado--;
                                    //isso acontece porque o vetor começa em 0, e não em 1


                                    Console.Clear();

                                    quantidadeManutencaoCadastrado--;
                                    idManutencaoCadastrado[opcaoExcluirManutencaoSelecionado] = 0;
                                    tituloManutencaoCadastrado[opcaoExcluirManutencaoSelecionado] = null;
                                    descricaoManutencaoCadastrado[opcaoExcluirManutencaoSelecionado] = null;
                                    idEquipamentoManutencaoCadastrado[opcaoExcluirManutencaoSelecionado] = 0;
                                    dataAberturaManutencaoCadastrado[opcaoExcluirManutencaoSelecionado] = DateTime.MinValue;
                                }

                                //mostrar manutencao
                                else if (opcaoManutencao == 4)
                                {
                                    int contador = 0;
                                    int qtdManutencao = 0;
                                    foreach (int id in idManutencaoCadastrado)
                                    {
                                        if (idManutencaoCadastrado[contador] != 0)
                                            qtdManutencao++;
                                        contador++;
                                    }
                                    if (qtdManutencao == 0)
                                    {
                                        Console.WriteLine("Não há equipamentos cadastrados");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        contador = 0;
                                        Console.WriteLine("Manutenções Cadastrados: ");
                                        foreach (int id in idManutencaoCadastrado)
                                        {
                                            if (id != 0)
                                            {
                                                Console.Write("Titulo: ");
                                                Console.WriteLine(tituloManutencaoCadastrado[contador]);

                                                Console.Write("Descricao: ");
                                                Console.WriteLine(descricaoManutencaoCadastrado[contador]);

                                                Console.Write("ID do Equipamento: ");
                                                Console.WriteLine(idEquipamentoManutencaoCadastrado[contador]);

                                                Console.Write("Data Abertura: ");
                                                Console.WriteLine(dataAberturaManutencaoCadastrado[contador].ToShortDateString());

                                                DateTime dataAtual = DateTime.Now;
                                                TimeSpan tempoPassado = dataAtual - dataAberturaManutencaoCadastrado[contador];
                                                int quantidadeDiasPassados = tempoPassado.Days;
                                                Console.Write("Dias desde Abertura: ");
                                                Console.WriteLine(quantidadeDiasPassados);

                                                Console.WriteLine();
                                                Console.WriteLine();
                                            }
                                            contador++;

                                        }
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }

                                //sair do menu manutencao
                                else if (opcaoManutencao == 5)
                                {
                                    break;
                                }

                                //opcao de manutencao invalida
                                else
                                {
                                    Console.WriteLine("Opção de menu manutencao inválida, tente novamente");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        }
                    case 3: //Opcao Sair do Programa
                        {
                            break;
                        }
                    default: //Opcao Inválida
                        {
                            Console.WriteLine("Opção de menu inválida, tente novamente");
                            Console.ReadLine();
                            break;
                        }
                }
            }
        }
    }
}




