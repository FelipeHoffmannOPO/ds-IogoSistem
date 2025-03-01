﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IogoSistem_vs1
{
    /// <summary>
    /// Lógica interna para ConsultarProdutos.xaml
    /// </summary>
    public partial class ConsultarProdutos : Window
    {
        public ConsultarProdutos()
        {
            InitializeComponent();

            Loaded += Agenda_Loaded;
        }
        private void Agenda_Loaded(object sender, RoutedEventArgs e)
        {
            List<Util> ListaConsultarProd = new List<Util>();

            for (int i = 1; i <= 24; i++)
            {
                ListaConsultarProd.Add(new Util()
                {
                    Codigo = "X",
                    Nome = "x",
                    Sabor = "X",
                    Categoria = "X",
                    Peso_Litros = "X",
                    Preco_Custo = "X",
                    Preco_Venda = "X",
                    Qtd_Estoque = "x",
                    Descrição = "X",
                    checkbox = false

                });

                

            }
            
            dataGridConsultarProd.ItemsSource = ListaConsultarProd;
        }

        private void x(object sender, DataGridCellClipboardEventArgs e)
        {
            Content = true;
        }
    }
}
