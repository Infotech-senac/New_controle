﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace New_controle.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class APPcontroleContainer : DbContext
    {
        public APPcontroleContainer()
            : base("name=APPcontroleContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ini_do_estoque> ini_do_estoqueSet { get; set; }
        public virtual DbSet<Quantidade_em_estoque> Quantidade_em_estoqueSet { get; set; }
        public virtual DbSet<Reposicao_estoque> Reposicao_estoqueSet { get; set; }
        public virtual DbSet<Baixa_produto> Baixa_produtoSet { get; set; }
        public virtual DbSet<produtos_em_reposicao> produtos_em_reposicaoSet { get; set; }
        public virtual DbSet<produtos_enviado> produtos_enviadoSet { get; set; }
        public virtual DbSet<Produtos> ProdutosSet { get; set; }
        public virtual DbSet<Produtos_em_estoque> Produtos_em_estoqueSet { get; set; }
    }
}