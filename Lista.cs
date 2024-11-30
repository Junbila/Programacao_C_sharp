using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace lista_de_tarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // caminho para o banco de dados
            string dbfile = "tarefas.db";

            //string de conexão com o banco de dados
            string connectionString = $"data source={dbfile}: version = 3;";

            //Verifica se o arquivo do db ja existe; se não, cria o db e tabela
            if (!File.Exists(dbfile)) 
            {
                //cria novo arquivo
                SQLiteConnection.CreateFile(dbfile);

                //criar tabela no banco de dados
                using (SQLiteConnection con = new SQLiteConnection(connectionString)) 
                {
                    con.Open();

                    //comando sql para criar tabea tarefas
                    string sql = "CREATE TABLE tarefas (id INTENGER PRIMARY KEY AUTOINCREMENT, Descricao TEXT NOT NULL)";

                    using (SQLiteCommand cmd = SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            //List<string> tarefas = new List<string>();
            int opcao; 
            
            do //faça
            {
                Console.WriteLine("\n Lista de Tarefas");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Remover Tarefa");
                Console.WriteLine("3 - Exibir Tarefas");
                Console.WriteLine("4 - Atualiar");
                Console.WriteLine("5 - Limpar Console");
                Console.WriteLine("6 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a nova tarefa:");
                        string novaTarefa = Console.ReadLine();
                        //tarefas.Add(novaTarefa);

                        //Insere a nova tarefa do db
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();

                            //Comando SQL para inserir a nova tarefa
                            string sql_insert = "INSERT INTO Tarefas (Descricao) " + "VALUES (@Descricao)";
                            using (SQLiteCommand cmd = new SQLiteCommand(sql_insert, con))
                            {
                                //Adiciona o parâmetro @Descricao com o valor da nova tarefa
                                cmd.Parameters.AddWithValue("@Descricao", novaTarefa);
                                cmd.ExecuteNonQuery(); //Executa o comando SQL
                            }

                            con.Close();
                        }
                        Console.WriteLine("Sucesso! Tarefa adicionada");
                        break;

                    case 2:
                        Console.WriteLine("Digite a tarefa a ser removida:");
                        string tarefaRemover = Console.ReadLine();
                        
                        // Remova tarefa do bd com base no ID

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Tarefa removida com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de tarefas:\n");

                        //Selecionar todas as tarefas
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();
                            //
                            string sql_select = "SSELECT * FROM tarefas";

                            using (SQLiteCommand cmd = new SQLiteCommand(sql_select, con))
                            {
                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    //Lê cada registro retornando
                                    while(reader.Read())
                                    {
                                        //Exibe o ID e a descrição da tarefa
                                        Console.WriteLine($"ID: {reader["id"]} - Descrição:{reader["Descricao"]}");
                                    }
                                }
                            }
                                con.Close();
                        }

                            //foreach (string tarefa in tarefas)
                            //{
                            //    Console.WriteLine(tarefa);
                            //}
                            break;
                    case 4:
                    //    Console.WriteLine("Encerrando...");
                    //    break;
                    //default:
                    //    Console.WriteLine("Opção inválida");
                        
                        break;
                        case 5:
                        Console.Clear();
                        break;
                        case 6:
                        Console.WriteLine("Encerrando...");
                        break;
                }

            } while (opcao != 4); //enquanto
        }
    }
}
