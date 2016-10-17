using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        Administration admin;
 
        public AdministrationForm()
        {
            InitializeComponent();
            admin = new Administration();
            animalTypeComboBox.SelectedIndex = 0;
            nudChipNumber.Enabled = true;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            
            int chipNumber = chipNumberCounter(nudChipNumber.Value);
            if (animalTypeComboBox.Text == "Cat")
            {
                SimpleDate simpleDate = new SimpleDate(Convert.ToInt32(nudDayBirthday.Value),
                                                       Convert.ToInt32(nudMonthBirthday.Value),
                                                       Convert.ToInt32(nudYearBirthday.Value));
                try
                {
                    if (admin.CheckChipNrIsAvailable(chipNumber))
                    {
                        Cat cat = new Cat(chipNumber, simpleDate, tbName.Text, tbBadHabits.Text);
                        if (!rbIsReserved.Checked)
                        {                            
                            admin.Add(cat);
                            lbNotReserved.Items.Add(cat);
                        }                        
                        if (rbIsReserved.Checked)
                        {
                            cat.IsReserved = true;
                            admin.Add(cat);
                            lbIsReserved.Items.Add(cat);
                        }
                    }
                    else if (!admin.CheckChipNrIsAvailable(chipNumber))
                    {
                        MessageBox.Show("Toevoegen niet gelukt");
                    }                   
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Vul alle waardes in voor cat");
                }
            }
            else if (animalTypeComboBox.Text == "Dog")
            {
                SimpleDate simpleDate = new SimpleDate(Convert.ToInt32(nudDayBirthday.Value),
                                                       Convert.ToInt32(nudMonthBirthday.Value),
                                                       Convert.ToInt32(nudYearBirthday.Value));
                SimpleDate walkDate = new SimpleDate(Convert.ToInt32(nudWalkDay.Value),
                                                       Convert.ToInt32(nudWalkMonth.Value),
                                                       Convert.ToInt32(nudWalkYear.Value));
                try
                {
                    if (admin.CheckChipNrIsAvailable(chipNumber))
                    {                        
                        Dog dog = new Dog(chipNumber, simpleDate, tbName.Text, walkDate);
                        if (!rbIsReserved.Checked)
                        {
                            lbNotReserved.Items.Add(dog);
                            admin.Add(dog);
                        }
                        
                        if (rbIsReserved.Checked)
                        {
                            dog.IsReserved = true;
                            admin.Add(dog);
                            lbIsReserved.Items.Add(dog);
                        }
                    }
                    else if (!admin.CheckChipNrIsAvailable(chipNumber))
                    {
                        MessageBox.Show("Toevoegen niet gelukt");
                    }
                    
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Vul alle waardes in voor dog");
                }
            }
            else
            {
                MessageBox.Show("Select an Animal!");
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            Animal a = admin.FindAnimal(Convert.ToInt32(nudFindAnimal.Value));
            
            if(a != null)
            {
                MessageBox.Show(a.ToString());
            }
            else
            {
                MessageBox.Show("die diertje is nie echt bruh");
            }      
        }

        private int chipNumberCounter(decimal chipNumber)
        {
            int chipNumberOld = (int)chipNumber;

            if(chipNumber == nudChipNumber.Value)
            {
                chipNumber++;
            }
            nudChipNumber.Value = chipNumber;

            return chipNumberOld;
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region formhandling dog
            if (animalTypeComboBox.Text == "Dog")
            {
                lblBadHabits.Visible = false;
                lblWalkDate.Visible = true;
                nudWalkDay.Visible = true;
                nudWalkMonth.Visible = true;
                nudWalkYear.Visible = true;
                tbBadHabits.Visible = false;
            }

            #endregion

            #region formhandling cat
            if (animalTypeComboBox.Text == "Cat")
            {
                lblBadHabits.Visible = true;
                lblWalkDate.Visible = false;
                nudWalkDay.Visible = false;
                nudWalkMonth.Visible = false;
                nudWalkYear.Visible = false;
                tbBadHabits.Visible = true;
            }

            #endregion
        }

        private void btnDeleteSelectedAnimal_Click(object sender, EventArgs e)
        {
            if (lbNotReserved.SelectedItem != null)
            {
                Animal a = (Animal)lbNotReserved.SelectedItem;
                admin.RemoveAnimal(a.ChipRegistrationNumber);
            }
            if (lbIsReserved.SelectedItem != null)
            {
                Animal a = (Animal)lbIsReserved.SelectedItem;
                admin.RemoveAnimal(a.ChipRegistrationNumber);
            }
            lbIsReserved.Items.Remove(lbIsReserved.SelectedItem);
            lbNotReserved.Items.Remove(lbNotReserved.SelectedItem);
            lbIsReserved.Update();
            lbNotReserved.Update();                 
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            admin.RemoveAnimal(Convert.ToInt32(nudFindAnimal.Value));                         
        }

        private void btnSortReserved_Click(object sender, EventArgs e)
        {
            admin.Animals.Sort(new ChipNrBasedComparer());
            updateListBoxes();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            int chipNr = (int)nudFindAnimal.Value;
            admin.AddOrRemoveReservation(chipNr);

            updateListBoxes();
        }

        private void updateListBoxes()
        {
            lbIsReserved.Items.Clear();
            lbNotReserved.Items.Clear();

            foreach (Animal a in admin.Animals)
            {
                if (a.IsReserved == true)
                {
                    lbIsReserved.Items.Add(a);
                }
                else lbNotReserved.Items.Add(a);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog1.FileName;
                admin.Save(savePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string loadPath = openFileDialog1.FileName;
                admin.Load(loadPath);
            }
            updateListBoxes();
        }
    }
}
