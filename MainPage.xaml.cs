using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private String id, senha;

        private void btnOk_Clicked(object sender, EventArgs e)
        {
            id = txtId.Text;
            senha = txtSenha.Text;

            if (id.Equals("adm") && senha.Equals("12345"))
                DisplayAlert("Login efetuado com sucesso", "Seja Bem vindo!!!", "Ok");
            else
                DisplayAlert("Invalido", "ID e/ou Senha Incorretos", "Ok");

            limpar();
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCreditos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Ketheleen Cristine CB3011836               Luiz Carlos Mendes CB3012123", "OK");
        }

        private void limpar()
        {
            txtId.Text = null;
            txtSenha.Text = null;
        }
    }
}
