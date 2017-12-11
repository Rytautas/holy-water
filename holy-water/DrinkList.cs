using holy_water.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    public partial class DrinkList : Form
    {
        public event OnDrinkChanged DrinkChanged;
        public delegate void OnDrinkChanged(int barId);

        

        private int barId;
        private string barName;

        public DrinkList(int barId, String barName)
        {
 

            InitializeComponent();

            BarChanged(barId, barName);

            
        }
        
        public void BarChanged(int barId, string barName)
        {
            this.barId = barId;
            this.barName = barName;

            this.Text = string.Format(Resource1.BarStringFormat, barId, barName);
            this.drinksTableAdapter.FillByBar(this.hollyWaterDbDataSet.Drinks, barId);
            this.Invalidate();
            this.dataGridView1.Invalidate();
        }

        private void DrinkList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hollyWaterDbDataSet.Drinks' table. You can move, or remove it, as needed.
            //this.drinksTableAdapter.Fill(this.hollyWaterDbDataSet.Drinks);
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            InputDrink inputDrink = new InputDrink();

            if (inputDrink.ShowDialog() == DialogResult.Cancel)
                return;

            this.drinksTableAdapter.InsertDrink(
                this.barId, 
                inputDrink.DrinkTime, 
                inputDrink.GlassVolume, 
                inputDrink.FillPercentage);

            this.drinksTableAdapter.FillByBar(this.hollyWaterDbDataSet.Drinks, barId);

            if (this.DrinkChanged != null)
                DrinkChanged(barId);
        }


    }
}
