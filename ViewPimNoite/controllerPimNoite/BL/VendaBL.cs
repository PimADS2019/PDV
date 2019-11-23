﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class VendaBL
    {
        public string mensagem;
        private int codReferencia;
        private int qtdVenda;
        private ProdutoDTO produtoDTO;
        private VendaDTO vendaDTO;


        private static VendaBL instance = null;
        private VendaBL()
        {
        }

        public static VendaBL getInstance()
        {
            if (instance == null)
            {
                instance = new VendaBL();
            }

            return instance;
        }

        public List<ProdutoDTO> ChecarVendaProduto(string produto)
        {
            try
            {
                this.codReferencia = Convert.ToInt32(produto);
                return ChecarVendaProduto(codReferencia);
            }
            catch (Exception)
            {
                produtoDTO.Produto = produto;
                return ChecarVendaProduto(produtoDTO);
            }
        }

        private List<ProdutoDTO> ChecarVendaProduto(ProdutoDTO produto)
        {
            return VendaDAO.getInstance().ChecarProdutoNome(produto);
        }

        private List<ProdutoDTO> ChecarVendaProduto(int CodReferencia)
        {
            return VendaDAO.getInstance().ChecarProdutoId(codReferencia);
        }

        public VendaDTO CalculosVenda(List<ItensVendaDTO> listProdutos, string qtdVendida, ProdutoDTO produtos)
        {
            try
            {
                qtdVenda = Convert.ToInt32(qtdVendida);
            }
            catch (Exception)
            {
                this.mensagem = "Quantidade inválida";
                return null;
            }

            foreach(ItensVendaDTO itensPedido in listProdutos)
            {
                itensPedido.Quantidade = qtdVenda;
                itensPedido.ProdutoDTO = produtos;
            }

            vendaDTO.Itens = listProdutos.Count();
            vendaDTO.SbTotal += produtos.PrecoVenda * qtdVenda;

            if (vendaDTO.SbTotal > 150)
            {
                vendaDTO.Desconto = 0.05;
            }

            if (vendaDTO.SbTotal > 300)
            {
                vendaDTO.Desconto = 0.10;
            }

            if (vendaDTO.Desconto == 0)
            {
                vendaDTO.VlTotal = vendaDTO.SbTotal;
            }
            else
            {
                vendaDTO.VlTotal = Math.Round(vendaDTO.SbTotal - (vendaDTO.SbTotal * vendaDTO.Desconto), 2);
            }

            vendaDTO.ItensVendaDTO = listProdutos;

            return vendaDTO;
        }

        public void SalvarVenda(VendaDTO venda)
        {
            if(venda.Itens == 0)
            {
                this.mensagem = "É necessário que tenha pelo menos 1 item para registrar uma venda";
            }

            VendaDAO.getInstance().SalvarVenda(venda);
            
            foreach(ItensVendaDTO itens in venda.ItensVendaDTO)
            {
                ItensVendaDAO.getInstance().RegistrarItensVendidos(itens.ProdutoDTO.CodReferencia, itens.Quantidade);
            }

            this.mensagem = ItensVendaDAO.getInstance().mensagem;
            vendaDTO = new VendaDTO();
        }
    }
}
