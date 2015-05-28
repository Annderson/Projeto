using API_OrgaoRegulador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrado_A
{
    public partial class P_Integrado_A : Form
    {
        private EndPoint endPoint;

        int validador = 2;
        
        public P_Integrado_A()
        {
            endPoint = new EndPoint();
            InitializeComponent();

            LBLregras.Visible = false;
            BUTcons.Enabled = false;                           
        }

        private void BUTvap_Click(object sender, EventArgs e)
        {
            
            // Recebe os numeros da TXTent 
             
            int index;

            index = Convert.ToInt32(TXTent.Text.Replace(" ", "").Length);                     

            index = index / 2;

            // Declaração dos vetores utilizados para armazenar os valores.
             
            int [] vetnum = new int[index], vetgrup = new int[25];
            string[] vettimes = new string[25];
            
            int cv = 0, cs1 = 0, cs2 = 2;                     
            
            for (cv = 0; cv < index; cv++)
            {
                vetnum[cv] = Convert.ToInt32(TXTent.Text.Substring(cs1, cs2).Trim());                 
                cs1 = cs1 + 3;        
            }
            
            System.Array.Sort(vetnum);
            
            int cv2 = 1;

            for (cv = 0; cv < index - 1; cv++)  // -1 verificar
            {

                if (vetnum[cv] == vetnum[cv2])
                {
                    MessageBox.Show("O jogo MEGA TIME não aceita números repetidos.\n Refaça a aposta.");

                    BUTvap.Enabled = false;
                    TXTent.Text = "";
                    validador = validador-1;
                    break;
                }

                cv2++;
            }

            // Verificação se usuário escolheu números de pelo menos cinco times diferentes. 
            for (cv = 0; cv < index; cv++)
            {
                if (vetnum[cv] >= 1 && vetnum[cv] <= 4)
                {
                    vetgrup[0] = 1;
                    vettimes[0] = "Atlético Mineiro";
                }
                else if (vetnum[cv] > 4 && vetnum[cv] <= 8)
                {
                    vetgrup[1] = 1;
                    vettimes[1] = "Atlético Paranaense";
                }
                else if (vetnum[cv] > 8 && vetnum[cv] <= 12)
                {
                    vetgrup[2] = 1;
                    vettimes[2] = "Bahia";
                }
                else if (vetnum[cv] > 12 && vetnum[cv] <= 16)
                {
                    vetgrup[3] = 1;
                    vettimes[3] = "Botafogo";
                }
                else if (vetnum[cv] > 16 && vetnum[cv] <= 20)
                {
                    vetgrup[4] = 1;
                    vettimes[4] = "Ceara";
                }
                else if (vetnum[cv] > 20 && vetnum[cv] <= 24)
                {
                    vetgrup[5] = 1;
                    vettimes[5] = "Corinthians";
                }
                else if (vetnum[cv] > 24 && vetnum[cv] <= 28)
                {
                    vetgrup[6] = 1;
                    vettimes[6] = "Coritiba";
                }
                else if (vetnum[cv] > 28 && vetnum[cv] <= 32)
                {
                    vetgrup[7] = 1;
                    vettimes[7] = "Cruzeiro";
                }
                else if (vetnum[cv] > 32 && vetnum[cv] <= 36)
                {
                    vetgrup[8] = 1;
                    vettimes[8] = "Flamengo";
                }
                else if (vetnum[cv] > 36 && vetnum[cv] <= 40)
                {
                    vetgrup[9] = 1;
                    vettimes[9] = "Fluminense";
                }
                else if (vetnum[cv] > 40 && vetnum[cv] <= 44)
                {
                    vetgrup[10] = 1;
                    vettimes[10] = "Fortaleza";
                }
                else if (vetnum[cv] > 44 && vetnum[cv] <= 48)
                {
                    vetgrup[11] = 1;
                    vettimes[11] = "Goias";
                }
                else if (vetnum[cv] > 48 && vetnum[cv] <= 52)
                {
                    vetgrup[12] = 1;
                    vettimes[12] = "Gremio";
                }
                else if (vetnum[cv] > 52 && vetnum[cv] <= 56)
                {
                    vetgrup[13] = 1;
                    vettimes[13] = "Guarani";
                }
                else if (vetnum[cv] > 56 && vetnum[cv] <= 60)
                {
                    vetgrup[14] = 1;
                    vettimes[14] = "Internacional";
                }
                else if (vetnum[cv] > 60 && vetnum[cv] <= 64)
                {
                    vetgrup[15] = 1;
                    vettimes[15] = "Nautico";
                }
                else if (vetnum[cv] > 64 && vetnum[cv] <= 68)
                {
                    vetgrup[16] = 1;
                    vettimes[16] = "Palmeiras";
                }
                else if (vetnum[cv] > 68 && vetnum[cv] <= 72)
                {
                    vetgrup[17] = 1;
                    vettimes[17] = "Parana Clube";
                }
                else if (vetnum[cv] > 72 && vetnum[cv] <= 76)
                {
                    vetgrup[18] = 1;
                    vettimes[18] = "Ponte Preta";
                }
                else if (vetnum[cv] > 76 && vetnum[cv] <= 80)
                {
                    vetgrup[19] = 1;
                    vettimes[19] = "Santa Cruz";
                }
                else if (vetnum[cv] > 80 && vetnum[cv] <= 84)
                {
                    vetgrup[20] = 1;
                    vettimes[20] = "Santos";
                }
                else if (vetnum[cv] > 84 && vetnum[cv] <= 88)
                {
                    vetgrup[21] = 1;
                    vettimes[21] = "São Paulo";
                }
                else if (vetnum[cv] > 88 && vetnum[cv] <= 92)
                {
                    vetgrup[22] = 1;
                    vettimes[22] = "Sport";
                }
                else if (vetnum[cv] > 92 && vetnum[cv] <= 96)
                {
                    vetgrup[23] = 1;
                    vettimes[23] = "Vasco da Gama";
                }
                else if (vetnum[cv] > 96 && vetnum[cv] <= 99 || vetnum[cv] == 00)
                {
                    vetgrup[24] = 1;
                    vettimes[24] = "Vitória";
                }     

            }
            
            string times = "";

            for (cv = 0; cv < 25; cv++ )
            if (vettimes[cv] != null)
                times = times + "\n" + vettimes[cv];
            
            int rgrup = 0;
                        
            for (cv = 0; cv < 25; cv++)
            {
                rgrup = rgrup + vetgrup[cv];
            }           
                   
            
            if (rgrup < 5)
            {
                MessageBox.Show("É necessário escolher números de pelo menos cinco times diferentes.\nRefaça sua aposta.\n\nBoa Sorte!!!");
                TXTent.Text = "";                
                BUTvap.Enabled = false;
                BUTlimp.Enabled = false;
                validador = validador-1;
                
            }

            // Verificar o valor da aposta do usuário.           
            double vlap = 0;

            if (index==10)
               vlap = 5.00;                
            else if (index == 11)
                   vlap = 5.75;
            else if (index == 12)
                   vlap = 6.50;
            else if (index == 13)
                   vlap = 7.25;
            else if (index == 14)
                   vlap = 8.00;
            else if (index == 15)
                   vlap = 8.75;
            else if (index == 16)
                   vlap = 11.75;
            else if (index == 17)
                   vlap = 14.75;
            else if (index == 18)
                   vlap = 17.75;
            else if (index == 19)
                   vlap = 20.75;
            else
                   vlap = 27.75;

            int contador = 5;
            if (rgrup > 5 && index >= 10)
            {
                while (contador < rgrup)
                {
                    vlap = vlap + 1.25;
                    contador++;        
                }      
         
            }

            if (validador == 2)
            {
                long protocolo;
                protocolo = endPoint.gravarAposta(TXTent.Text);

                LBLsaida.Text = "JOGO MEGA TIME:\n\n" + "Números Apostados:\n" + TXTent.Text + "\n\nTimes Escolhidos:" + times + "\n\nValor da Aposta:\n" + "R$:" + vlap + "\n\nProtocolo Nº:\n" + protocolo;

                TXTent.Text = "";
                BUTcons.Enabled = false;
            }

            MessageBox.Show(LBLsaida.Text);
        }

        private void P_Integrado_A_Load(object sender, EventArgs e)
        {
            BUTvap.Enabled = false;
            BUTlimp.Enabled = false;
            LBLregras.Enabled = true; 

        }
        
        private void TXTent_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloqueio que permite somente a digitação de numeros na TXTent
             
 
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            {

                // Cria uma máscara para dar espaços entre os numeros digitados na TXTent   
                switch (TXTent.TextLength)
                {
                    case 0:
                        TXTent.Text = "";
                        break;

                    case 2:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 4;
                        break;

                    case 5:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 7;
                        break;

                    case 8:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 10;
                        break;

                    case 11:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 13;
                        break;

                    case 14:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 16;
                        break;

                    case 17:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 19;
                        break;

                    case 20:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 22;
                        break;

                    case 23:
                        TXTent.Text =  TXTent.Text + " ";
                        TXTent.SelectionStart = 25;
                        break;

                    case 26:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 28;
                        break;

                    case 29:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 31;
                        break;

                    case 32:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 34;
                        break;

                    case 35:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 37;
                        break;

                    case 38:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 40;
                        break;

                    case 41:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 43;
                        break;

                    case 44:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 46;
                        break;

                    case 47:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 49;
                        break;

                    case 50:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 52;
                        break;

                    case 53:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 55;
                        break;

                    case 56:
                        TXTent.Text = TXTent.Text + " ";
                        TXTent.SelectionStart = 58;
                        break;
                }
                TXTent.Text.Trim();
            }          
            
        }

        private void TXTent_TextChanged(object sender, EventArgs e)
        {
                              
            // Se na TXTent for digitado menos de 10 BUTvap não habilita.
            // Qualquer valor digitado, habilita o BUTlimpar.          

            if (TXTent.Text.Length > 28)
            {
                BUTvap.Enabled = true;
            }
            if
             (TXTent.Text.Length < 29)
            {
                BUTvap.Enabled = false;
            }
            if (TXTent.Text.Length > 1)
            {
                BUTlimp.Enabled = true;
            }

        }

        private void BUTlimp_Click(object sender, EventArgs e)
        {
            TXTent.Clear();
            LBLsaida.Text = "";
            BUTlimp.Enabled = false;
            BUTcons.Enabled = false;

            validador = 2;
        }

        private void BUTcons_Click(object sender, EventArgs e)
        {

            // Utilização da API fornecida para simular envio de aposta ao orgão regulador.  
            LBLsaida.Text = "";

            long rprotocolo, protocolo = Convert.ToInt64(TXTconsult.Text.Replace(" ", ""));
            rprotocolo = endPoint.obterQuantidadeDezenasApostadas(protocolo);
            if (rprotocolo == 0)
            {
                MessageBox.Show("Número de protocolo não localizado.\nTente novamente.");
                TXTconsult.Clear();
                BUTlimp.Enabled = false;
                BUTcons.Enabled = false;

            }
            string s = endPoint.obterTodasDezenasApostadas(protocolo);  
            if (rprotocolo != 0 && s != null)
            {
                LBLsaida.Text = "MEGA TIME:\n\n" + "Números Apostados:\n" + s + "\n\nQuantidade de Números:\n" + rprotocolo;

                BUTlimp.Enabled = true;

                MessageBox.Show(LBLsaida.Text);
            }
 
            string x = endPoint.obterNomeTimeSorteado();
            MessageBox.Show("Time sorteado: " + x);

            string v = endPoint.ObterTodosNumerosSorteados();
            String[] valores_sorteados = new String[v.Length];
            valores_sorteados = v.Split(',');

            String[] dezenas = new String[s.Length];
            dezenas = s.Split(',');

            int[] dezenas_int = new int[dezenas.Length];
            int[] valores_int_sorteados = new int[valores_sorteados.Length];

            int dezenas_acertadas = 0;

            for (int i = 0; i < valores_int_sorteados.Length; i++)
            {
                valores_int_sorteados[i] = int.Parse(valores_sorteados[i]);
            }
            
            
            for (int i = 0; i < dezenas_int.Length;i++)
            {
                dezenas_int[i] = int.Parse(dezenas[i]);
            }

            for (int i = 0; i < dezenas_int.Length; i++)
            {
                for (int j = 0; j < valores_int_sorteados.Length; j++)
                {
                    if (dezenas_int[i] == valores_int_sorteados[j])
                    {
                        dezenas_acertadas++;
                    }
                }
             }

            MessageBox.Show("Numeros sorteados " + v); 
            double z = endPoint.obterPremioPorAcertos(dezenas_acertadas);

            if (z == -1) MessageBox.Show("Nenhum numero sorteado");
            else MessageBox.Show("Valor do premio: " + z);
           

            TXTconsult.Clear();
        }

        private void BUTregras_Click(object sender, EventArgs e)
        {
            if (LBLregras.Visible == false)
            {
                LBLregras.Visible = true;
            }
            else if (LBLregras.Visible == true)
            {
                LBLregras.Visible = false;
            }
            LBLregras.Text = (" Regras do MEGA TIME:\n\nOs números devem ser digitados com DOIS ALGARISMOS: 01, 07, 93...\nEscolha entre dez e vinte números.\nOs números devem pertencer a pelo menos cinco times diferentes.\n\nVALORES:\n10 números R$5.00.\n11ª a 15ª acrescimo de R$0.75 por número.\n16ª  a 19ª acréscimo de R$3.00 por número.\n20ª acréscimo de R$7.00.\nOBS. Independente da quantidade de dezenas apostadas, caso aposte mais de um número no mesmo time haverá o acrescimo de R$1.25 para cada número a partir do segundo.\nOs valores são CUMULATIVOS.\n");
        }

        private void TXTconsult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void TXTconsult_TextChanged(object sender, EventArgs e)
        {
            BUTcons.Enabled = true;
        }

        private void LBLsaida_Click(object sender, EventArgs e)
        { }
        private void LBLregras_Click(object sender, EventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        { }
    }
}
