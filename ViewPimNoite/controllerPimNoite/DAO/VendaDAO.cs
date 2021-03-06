﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class VendaDAO : Conexao
    {
        public string mensagem;
        public int idInsertVenda;
        private static VendaDAO instance = null;

        private VendaDAO()
        {
        }

        public static VendaDAO getInstance()
        {
            if (instance == null)
            {
                instance = new VendaDAO();
            }

            return instance;
        }

        public List<VendaDTO> ConsultarVendas()
        {
            SqlCommand cmd = new SqlCommand(@"select IdTransacao, Total, DataVenda, Nome_produto  from tb_Transacoes
                                            inner join tb_ItensTransacoes_Produtos
                                            on tb_ItensTransacoes_Produtos.fk_Transacoes_IdTransacao = tb_Transacoes.IdTransacao
                                            inner join tb_Produtos
                                            on tb_ItensTransacoes_Produtos.fk_Produtos_IdProduto = tb_Produtos.IdProduto
                                            order by DataVenda desc", conn);

            List<VendaDTO> ListaVendas = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListaVendas = new List<VendaDTO>();
                VendaDTO venda = null;

                while (dr.Read())
                {
                    venda = new VendaDTO();

                    venda.Id = Convert.ToInt32(dr["IdTransacao"]);
                    venda.VlTotal = Convert.ToDouble(dr["Total"]);
                    venda.DtCompra = Convert.ToDateTime(dr["DataVenda"]);
                    venda.ProdutoDTO.Produto = Convert.ToString(dr["Nome_produto"]);

                    ListaVendas.Add(venda);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }

            return ListaVendas;
        }

        public List<ProdutoDTO> ChecarProdutoNome(ProdutoDTO produto)
        {
            SqlCommand cmd = new SqlCommand(@"select CodReferencia, ValorUnitario, Nome_produto from tb_Produtos
                                              inner join tb_Estoques
                                              on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                              where inativar = 0 and Nome_produto like @nome_Produto", conn);

            cmd.Parameters.AddWithValue("@nome_Produto", "%" + produto.Produto + "%");

            List<ProdutoDTO> listadeprodutos = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadeprodutos = new List<ProdutoDTO>();
                ProdutoDTO produtoDTO = null;

                while (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);

                    listadeprodutos.Add(produtoDTO);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            //codReferencia, vlVenda, produto, quantidade
            return listadeprodutos;
        }

        public List<ProdutoDTO> ChecarProdutoId(int produto)
        {
            SqlCommand cmd = new SqlCommand(@"select CodReferencia, ValorUnitario, Nome_produto from tb_Produtos
                                              inner join tb_Estoques
                                              on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                              where inativar = 0 and IdProduto = @Id_Produto", conn);

            cmd.Parameters.AddWithValue("@Id_Produto", produto);

            List<ProdutoDTO> listadeprodutos = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadeprodutos = new List<ProdutoDTO>();
                ProdutoDTO produtoDTO = null;

                while (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);

                    listadeprodutos.Add(produtoDTO);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            //codReferencia, vlVenda, produto, quantidade
            return listadeprodutos;
        }

        public int SalvarVenda(VendaDTO venda, int idFuncionario)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroVenda", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubTotal", venda.SbTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
            cmd.Parameters.AddWithValue("@Total", venda.VlTotal);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DtCompra);
            cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

            int id = 0;
            try
            {
                conn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());

                /*if (dr.Read())
                {
                    id = Convert.ToInt32(dr["@IdVenda"]);
                }*/
                conn.Close();
                this.mensagem = "Venda Realizada com sucesso";
                return id;
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                return id;
                throw ex;
            }
        }
    }
}
