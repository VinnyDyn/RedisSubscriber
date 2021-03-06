﻿using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RedisSubscriber.Auxiliares;
using RedisSubscriber.Modelos.MensagemMds;
using RedisSubscriber.Interfaces.Aplicacao;
using Microsoft.Azure.CognitiveServices.Search.WebSearch;

namespace RedisSubscriber
{
    public partial class Mensagem : Form
    {
        public Mensagem() => InitializeComponent();

        private delegate void MensagemDeRetorno(string mensagem);

        private void BtnInscrever_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(this.Inscrever));
            th.Start();
            this.BtnInscrever.Enabled = false;
        }

        private void Inscrever()
        {
            ReceberMd comando = new ReceberMd(".NET14");

            if (this.TxtHistorico.InvokeRequired)
            {
                using (InjecaoDeDependencia injecao = new InjecaoDeDependencia())
                {
                    IOuvinteApp ouvinteApp = injecao.Invocar<IOuvinteApp>();
                    ouvinteApp.Inscrever().Subscribe(comando.Canal, (canal, mensagem) =>
                    {
                        if (!string.IsNullOrEmpty(mensagem))
                            this.Invoke(new MensagemDeRetorno(Aplicar), new object[] { mensagem.ToString() });
                    });
                }
            }
        }

        private void Aplicar(string texto)
        {
            StringBuilder sb = new StringBuilder();
            TxtHistorico.Text = sb.Append(TxtHistorico.Text)
                .Append($"\r\n Publicador: { texto }").ToString();
        }

        public void Pesquisa()
        {
            //string question = "Cotação Dollar";
            //string question = "Capital da Bahia";
            string question = "2+2";
            var client = new WebSearchClient(new ApiKeyServiceClientCredentials("cdab4adbb42a487a9e3423a4ec716739"));
            string answer = BingSearch.WebResults(client, question);
        }
    }
}
