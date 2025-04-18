﻿using ProjetoAvaliacao.DAO;
using ProjetoAvaliacao.Formularios.Avaliacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmLogar : Form
    {
        string Tipo;
        public frmLogar(string tipo)
        {
            InitializeComponent();
            Tipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
            string senha = textBox2.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "ANALISE")
            {
                frmAnalise analise = new frmAnalise(cpf);
                analise.ShowDialog();
            }

            else if (!InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "ANALISE")
            {
                if (InformacaoDAO.TemCpf(cpf))
                {
                    if (!InformacaoDAO.TemSenha(cpf))
                    {
                        frmCriarSenha criarSenha = new frmCriarSenha(cpf);
                        criarSenha.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha Invalida!");
                }
                else
                    MessageBox.Show("Esse CPF não está cadastrado, entre em contato com o RH");
            }
            
            else if (!InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "AVALIACAO")
            {
                if (InformacaoDAO.TemCpf(cpf))
                {
                    if (!InformacaoDAO.TemSenha(cpf))
                    {
                        frmCriarSenha criarSenha = new frmCriarSenha(cpf);
                        criarSenha.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha Invalida!");
                }
                else
                    MessageBox.Show("Esse CPF não está cadastrado, entre em contato com o RH");
            }

            else if (InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "AVALIACAO")
            {
                frmAvaliacao analise = new frmAvaliacao(cpf);
                analise.ShowDialog();
            }
        }
    }
}
