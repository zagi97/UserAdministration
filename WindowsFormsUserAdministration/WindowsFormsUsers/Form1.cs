using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;

namespace WindowsFormsUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud Crud = new Crud();
            List <User> lUsers = Crud.GetUsers();
            DataGridViewUsers.DataSource = lUsers;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();//nova kolona koja je tipa image
            oEditButton.Image = Image.FromFile("C:\\Users\\student\\Source\\Repos\\UserAdministration\\if_brush-pencil_1055103.png");
            oEditButton.Width = 20; //širina slike
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            DataGridViewUsers.Columns.Add(oEditButton);

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();//nova kolona koja je tipa image
            oDeleteButton.Image = Image.FromFile("C:\\Users\\student\\Source\\Repos\\UserAdministration\\if_icon-90_667351.png");
            oDeleteButton.Width = 20; //širina slike
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);

            DataGridViewUsers.AutoGenerateColumns = false;//program nece sam stvoriti sve kolone, tako da on lijep nam složi kolone od prve do zadnje
        }                                                 //da to nemamo kolona nam bi bila na sredini stranice

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)//parametar ove funkcije je e- event da znamo koju smo celiju stisnili
        {
            // MessageBox.Show("Gumbić");
            DataGridViewUsers.Rows[e.RowIndex].Selected = true; // tu se postavlja da je redak 
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                //this- je objekt prve forme, ako necemo da pise this mogli smo ovako:
                //form1 FormUserList =this; i onda staviti tu ispod.
                FormEditUser FormEditUser = new FormEditUser(this); //kreiraj mi novu formu za editiranje usera , this. je sam svoj objekt salje sebe u iz 1.forme u 2.formu, objekt klase form edit user ciji konsttrukot
                FormEditUser.lblEditUserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString(); //imamo datagridview znamo na koji smo redak stisnili zbog e-eventa, kolonu citamo kod cells[0] indeks
                FormEditUser.lblEditUserName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show(); // prikazi mi formu
            }

            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                
                Form3 Form3 = new Form3(this);
                Form3.ID = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
               /* Form3.Name = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                Form3.Surname = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                Form3.Password = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                Form3.Username = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();*/
                Form3.Show(); 
            }

        }

        
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4(this);
            Form4.Show();
        }
    }
}
