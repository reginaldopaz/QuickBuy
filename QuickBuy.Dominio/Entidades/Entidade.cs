﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public abstract class Entidade
    {
        public List<string> _mensagenValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagenValidacao ?? (_mensagenValidacao = new List<string>()); }
        }
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear(); 
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
