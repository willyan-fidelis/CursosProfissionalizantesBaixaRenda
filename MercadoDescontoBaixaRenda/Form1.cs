using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataViewLib;
using DataViewLib.usercontrol.field.crud.EditObjectsFormSuportedClasses;
using DataViewLib.usercontrol.field.selection;

namespace MercadoDescontoBaixaRenda
{
    public partial class Form1 : Form
    {
        public List<Usuario> _Usuarios = new List<Usuario>();
        public List<BeneficiosSemanaGrid> _BeneficiosSemanaGrid = new List<BeneficiosSemanaGrid>();
        //Semana SemanaSelecionada = Semana.Semana1;
        public Form1()
        {
            InitializeComponent();
            ConfigGrid_Usuarios();
            ConfigGrid_BeneficiosSemana();
            ConfigEscolherSemana();
        }

        //Novo comentario realizado por convidado aqui! changed comment again by inveted user!

        //Primeira alteração feita por willyan(owner do repo) na sua branch(willyan)

        //primeira alteração apos mudar email principal do github para willyan.fidelis.dev@gmail.com

        //primeira alteração apos voltar para willyan.sergio.fidelis.@gmail.com como email principal e deletado email secundario willyan.fidelis.dev@gmail.com
        private void btn_editar_Click(object sender, EventArgs e)
        {
            var editObject = new DataViewLib.usercontrol.field.crud.EditObjectsForm();

            //editObject.EnableEditList = true;
            editObject.Config(_Usuarios, true, (FirstValue, LastValue, NewValue, Path, KeyValuePath) => {
                return NewValue;
            }, true);
            editObject.ShowDialog();
            _Usuarios = editObject.GetResult();

            //Atualizamos os usuarios:
            grid_usuarios.Update(_Usuarios);
        }

        private void ConfigGrid_Usuarios()
        {
            //--- Configura Recipes DataGrid --->


            Dictionary<string, string>[] RecipeHeader()
            {
                Dictionary<string, string>[] _dict = {
                    new Dictionary<string, string>() { ["Nome"] = "Nome do Usuario" },
                };
                return _dict;
            }

            grid_usuarios.Config<List<Usuario>>(RecipeHeader(), (int index, object element) => {
                Usuario el = (Usuario)element;


            });
            //--- Configura Recipes DataGrid <---


        }

        private void ConfigEscolherSemana()
        {
            radioBoxField1.ElementTitle = "Selecione a semana";
            var radioList = new List<RadioBoxFieldProps>() {
                new RadioBoxFieldProps() { ColorOn = Color.Orange, ColorOff = Color.Orange, Text = "Semana 1", Value = 0 },
                new RadioBoxFieldProps() { ColorOn = Color.Orange, ColorOff = Color.Orange, Text = "Semana 2", Value = 1 },
                new RadioBoxFieldProps() { ColorOn = Color.Orange, ColorOff = Color.Orange, Text = "Semana 3", Value = 2 },
                new RadioBoxFieldProps() { ColorOn = Color.Orange, ColorOff = Color.Orange, Text = "Semana 4", Value = 3 },
                new RadioBoxFieldProps() { ColorOn = Color.Orange, ColorOff = Color.Orange, Text = "Semana 5", Value = 4 },
            };
            radioBoxField1.Config(radioList, (int?)Semana.Semana1, () => { return true; }, (elem, index) => {
                Semana SemanaSelecionada = (Semana)index;

                //Vamos preencher o formulario conforme o programa selecionado:
                _BeneficiosSemanaGrid.Clear();
                foreach (var usuario in _Usuarios)
                {
                    foreach (var progama in usuario.UsuarioPrograma)
                    {
                        if (progama.Semana == SemanaSelecionada)
                        {
                            _BeneficiosSemanaGrid.Add(new BeneficiosSemanaGrid() { Nome = usuario.Nome, Tipo = progama.UsuarioProgramaTipo });
                            break;
                        }
                    }
                }
                grid_beneficios_semana.Update(_BeneficiosSemanaGrid);
                return true;
            });
        }
        private void ConfigGrid_BeneficiosSemana()
        {
            //--- Configura Recipes DataGrid --->


            Dictionary<string, string>[] RecipeHeader()
            {
                Dictionary<string, string>[] _dict = {
                    new Dictionary<string, string>() { ["Nome"] = "Nome do Usuario" },
                    new Dictionary<string, string>() { ["Tipo"] = "Tipo beneficio" },
                };
                return _dict;
            }

            grid_beneficios_semana.Config<List<BeneficiosSemanaGrid>>(RecipeHeader(), (int index, object element) => {
                BeneficiosSemanaGrid el = (BeneficiosSemanaGrid)element;


            });
            //--- Configura Recipes DataGrid <---


        }
    }
    public class BeneficiosSemanaGrid
    {
        public string Nome { get; set; }
        public UsuarioProgramaTipo Tipo { get; set; }
    }
}
