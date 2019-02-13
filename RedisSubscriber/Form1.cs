using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.CognitiveServices.Search.WebSearch;
using Microsoft.Azure.CognitiveServices.Search.WebSearch.Models;

namespace RedisSubscriber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X();
        }

        public void X()
        {
            //string question = "Cotação Dollar";
            //string question = "Capital da Bahia";
            //string question = "2+2";
            var client = new WebSearchClient(new ApiKeyServiceClientCredentials("cdab4adbb42a487a9e3423a4ec716739"));
            string answer = BingSearch.WebResults(client, question);            
        }
    }
}
