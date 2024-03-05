using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Worknote
{
    public partial class Form1 : Form
    {
        /**| Fichier à serializer |**/
        private string filePath = "worknotes.bin";

        /**| Liste de toutes les Worknotes |**/
        private List<Aworknote> listOfWorknotes;

        public Form1()
        {
            InitializeComponent();

            /**| Récupère les worknotes |**/
            listOfWorknotes = ClientSerialization.Open(filePath);

            /**| Les affiche dans le datagridview |**/
            foreach (Aworknote worknote in listOfWorknotes)
            {
                int rowIndex = dataOfWorknotes.Rows.Add(null, worknote.Title, worknote.Description, worknote.Created.ToString("yyyy-MM-dd hh:mm:ss"), worknote.Deadline.ToString("yyyy-MM-dd hh:mm:ss"));

                dataOfWorknotes.Rows[rowIndex].Cells[0].Style.BackColor = worknote.Color;
            }

            /**| Collection des Polices |**/
            PrivateFontCollection AllFonts = new PrivateFontCollection();

            /**| Chemin du projet |**/
            string rootPath = Environment.CurrentDirectory;

            /**| Ajout des polices|**/
            AllFonts.AddFontFile(rootPath + "\\praetorian.ttf");
            AllFonts.AddFontFile(rootPath + "\\omegaflighttitle.ttf");

            /**| Applique les polices|**/
            labelLogo.Font = new Font(AllFonts.Families[1], 13, FontStyle.Regular);

            dataOfWorknotes.ColumnHeadersDefaultCellStyle.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            createBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonCreateColor.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonExit.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonCreateWorknote.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonDeleteWorknote.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCreateColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                buttonCreatePrintColor.BackColor = selectedColor;
            }
        }

        private void SortDataGridViewByDate()
        {
            if (dataOfWorknotes.Rows.Count > 0)
            {
                int columnIndex = dataOfWorknotes.Columns["deadline"].Index;

                dataOfWorknotes.Sort(dataOfWorknotes.Columns[columnIndex], System.ComponentModel.ListSortDirection.Ascending);
            }
        }

        private void ButtonCreateWorknote_Click(object sender, EventArgs e)
        {
            Color color = buttonCreatePrintColor.BackColor;
            string title = inputCreateTitle.Text;
            string description = inputCreateDescription.Text;
            DateTime created = DateTime.Now;
            DateTime deadline = dateTimePickerCreateDeadline.Value;

            if (color != null && title != "" && created != null && deadline != null)
            {
                Aworknote worknote = new Aworknote(color, title, description, created, deadline);

                int rowIndex = dataOfWorknotes.Rows.Add(null, worknote.Title, worknote.Description, worknote.Created.ToString("yyyy-MM-dd"), worknote.Deadline.ToString("yyyy-MM-dd"));

                dataOfWorknotes.Rows[rowIndex].Cells[0].Style.BackColor = color;

                SortDataGridViewByDate();

                listOfWorknotes.Add(worknote);

                ClientSerialization.Save(listOfWorknotes, filePath);

                MessageBox.Show("Worknote created.", "Worknote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Enter all informations for create a worknote.", "Worknote", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ButtonDeleteWorknote_Click(object sender, EventArgs e)
        {
            if (dataOfWorknotes.SelectedRows.Count > 0)
            {
                /**| On récupère la ligne à supprimer |**/
                DataGridViewRow selectedRow = dataOfWorknotes.SelectedRows[0];

                /**| On récupère la worknote séléctionnée |**/
                string worknoteTitle = selectedRow.Cells[1].Value.ToString();

                /**| On delete du datagridview |**/
                dataOfWorknotes.Rows.Remove(selectedRow);

                /**| On delete dans le file la worknote |**/
                ClientSerialization.Delete(worknoteTitle, filePath);

                /**| On recharge la collection des worknotes |**/
                listOfWorknotes = ClientSerialization.Open(filePath);

                MessageBox.Show("Worknote deleted.", "Worknote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Select a row.", "Worknote", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
