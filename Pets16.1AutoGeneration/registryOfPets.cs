using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pets16._1AutoGeneration
{
    public partial class registryOfPets : Form
    {
        private DataGridView currentDGVWF;
        private List<Button> currentIconsOfPets;
        private Dictionary<string, dynamic> filtersAndSort;

        public registryOfPets()
        {
            InitializeComponent();
        }

        public int CurrentPage
        {
            get => default;
            set
            {
            }
        }

        public bool PresentationType
        {
            get => default;
            set
            {
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void button8_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void ChangePresentationType()
        {
            throw new System.NotImplementedException();
        }

        public void event_CloseWindow(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void event_ExportExcel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void event_PetButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void event_registryOfPets_Click_ChangePresentationType(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void event_registryOfPets_DGVWF_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void event_registryOfPets_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void ExportToExcel()
        {
            throw new System.NotImplementedException();
        }

        public void OpenPet(int id_pet)
        {
            throw new System.NotImplementedException();
        }

        public void OpenRegistry()
        {
            throw new System.NotImplementedException();
        }
    }
}
