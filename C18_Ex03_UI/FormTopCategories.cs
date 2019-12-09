using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C18_Ex03_Logic;
using static C18_Ex03_Logic.LogicManager;

namespace C18_Ex03_UI
{
    public partial class FormTopCategories : Form
    {

        public const int THREE = 3;
        public const int SIX = 6;

        private CategoriesCounter m_CategoriesCounter = new CategoriesCounter();

        public FormTopCategories()
        {
            InitializeComponent();
            prepareFacade();
        }

        private void prepareFacade()
        {
            LogicServices.createFacadeTopCategories(LogicServices.GetFriends());

            textBoxFirst.Text = LogicServices.Facade.First;
            textBoxSecond.Text = LogicServices.Facade.Second;
            textBoxthird.Text = LogicServices.Facade.Third;
        }
    }
}

