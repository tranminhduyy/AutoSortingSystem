using AutoSortingSystem.Application.Service;
using AutoSortingSystem.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSortingSystem.Admin.Views
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            //tbPassword.Text. = true;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        private void tbRePassword_OnValueChanged(object sender, EventArgs e)
        {
            tbRePassword.isPassword = true;
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text) ||
                string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbUserName.Text) ||
                string.IsNullOrEmpty(tbPassword.Text) ||
                string.IsNullOrEmpty(tbRePassword.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) ||
                string.IsNullOrEmpty(tbPhoneNo.Text) 
                //check datepicker
                )
            {
                Alert("Please fill all textbox!", Form_Alert.enmType.Warning);
            }
            else
            { 
                var checkPass = ValidatePassword(tbPassword.Text);
                var checkRePass = ValidatePassword(tbRePassword.Text);

                if (!checkPass || !checkRePass)
                {
                    Alert("Please check password again", Form_Alert.enmType.Warning);
                }

                if (tbPassword.Text == tbRePassword.Text)
                {
                    var newAccount = new UserVM()
                    {
                        UserName = tbUserName.Text,
                        Email = tbEmail.Text,
                        Password = tbPassword.Text,
                        PhoneNo = tbPhoneNo.Text,
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        Dob = dpkDob.Value,
                    };
                    var res = UserService.Ins.AddUser(newAccount);
                    switch(res)
                    {
                        case 0: 
                            Alert("Something went wrong", Form_Alert.enmType.Error);
                            break;
                        case 1:
                            Alert("Register account successed", Form_Alert.enmType.Success);
                            break;
                        case 2:
                            Alert("Account already existed", Form_Alert.enmType.Warning);
                            break;
                    }
                }
                else
                {
                    Alert("Password must be the same", Form_Alert.enmType.Warning);
                }
            }           
        }

        private bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                //char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                //if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
    }
}
