using ControleAcessoClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleAcessoClass
{

    // USUARIO
    public class Usuario
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? TipoUsuario { get; set; }
        public string? Senha { get; set; }

        // construtores
        public Usuario(int id, string? nome, string? cpf, string? tipoUsuario, string? senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }
        public Usuario(string text)
        {
            
        }


        // metodos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert usuarios (nome, cpf, tipousuario, senha) " +
                $"values ('{Nome}','{Cpf}',('{TipoUsuario}'),md5('{Senha}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }


    }

    // ENTRADA E SAIDA
    public class RegistroAcesso
    {
        // propriedades da classe
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string? TipoOperacao { get; set; }

        // construtores
        public RegistroAcesso(int id, int usuarioId, DateTime dataHora, string? tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
    }

    // AUTENTICACAO
    //public class Autenticador
    //{
    //    public bool ValidarLogin(string cpf, string senha)
    //    {
    //        // simular verificação
    //    }
    //}










}




// ______________________________________________________________________________________________________________________



//        // métodos da classe!
//        public static Usuario ObterPorId(int id)
//        {
//            Usuario usuario = new();
//            var cmd = Banco.Abrir();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = $"select * from usuarios where id = {id}";
//            var dr = cmd.ExecuteReader();
//            while (dr.Read())
//            {
//                usuario = new(
//                        dr.GetInt32(0),
//                        dr.GetString(1),
//                        dr.GetString(2),
//                        dr.GetString(3),
//                        dr.GetBoolean(4)
//                    );
//            }
//            return usuario;
//        }

//        public static List<Usuario> ObterLista()
//        {
//            List<Usuario> lista = new();
//            var cmd = Banco.Abrir();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = "select * from usuarios order by nome";
//            var dr = cmd.ExecuteReader();
//            while (dr.Read())
//            {
//                lista.Add(new(
//                    dr.GetInt32(0),
//                    dr.GetString(1),
//                    dr.GetString(2),
//                    dr.GetString(3),
//                    dr.GetBoolean(4)
//                    )
//                );
//            }
//            return lista;
//        }
//        public void Inserir()
//        {
//            var cmd = Banco.Abrir();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = $"insert usuarios (nome, email, senha, ativo) " +
//                $"values ('{Nome}','{Email}',md5('{Senha}'), default)";
//            cmd.ExecuteNonQuery();
//            cmd.CommandText = "select last_insert_id()";
//            Id = Convert.ToInt32(cmd.ExecuteScalar());
//        }
//        public static void Arquivar(int id)
//        {
//            var usuario = ObterPorId(id);
//            if (usuario.Ativo)
//            {
//                var cmd = Banco.Abrir();
//                cmd.CommandType = CommandType.Text;
//                cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
//                cmd.ExecuteNonQuery();
//            }

//        }
//        public static void Restaurar(int id)
//        {
//            var usuario = ObterPorId(id);
//            if (!usuario.Ativo)
//            {
//                var cmd = Banco.Abrir();
//                cmd.CommandType = CommandType.Text;
//                cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
//                cmd.ExecuteNonQuery();
//            }
//        }
//        public void Alterar() // altera só o nome
//        {
//            var cmd = Banco.Abrir();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = $"update usuarios set nome = '{Nome}' where id = {Id}";
//            cmd.ExecuteNonQuery();
//            // comentários....
//        }

//        public static Usuario EfetuarLogin(string email, string senha)
//        {
//            Usuario usuario = new();
//            var cmd = Banco.Abrir();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = "select * from usuarios where email = @email and senha = md5(@senha)";
//            cmd.Parameters.AddWithValue("@email", email);
//            cmd.Parameters.AddWithValue("@senha", senha);
//            var dr = cmd.ExecuteReader();
//            if (dr.Read())
//            {
//                usuario.Id = dr.GetInt32(0);// campo id - int
//                usuario.Nome = dr.GetString(1);// campo nome - varchar
//                usuario.Email = dr.GetString(2);// campo email - varchar
//                usuario.Ativo = dr.GetBoolean(4); // campo ativo - bit
//            }
//            return usuario;
//        }



//    }
//}
