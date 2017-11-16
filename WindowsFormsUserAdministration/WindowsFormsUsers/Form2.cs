using DatabaseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUsers
{
    public partial class FormEditUser : Form
    {
        private readonly Form1 FormUserList;
        public FormEditUser(Form1 FormUsers) //zaprima 1.formu
        {
            FormUserList = FormUsers;
            InitializeComponent();          
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Convert.ToInt32(lblEditUserID.Text);
            oUser.sUserFirstName = inptEditName.Text;
            oUser.sUserLastName = inptEditSurname.Text;
            oUser.sUserPassword = inptEditPassword.Text;
            oUser.sUserName = lblEditUserName.Text;
            //PODATKOVNIM CLANOVIMA KLASE USER REDOM DODJELUJEM (PODATKE)??
            Crud Crud = new Crud();
            Crud.UpdateUsers(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
