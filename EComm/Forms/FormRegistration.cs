using System;
using System.Collections.Generic;
using System.Linq;
using EComm.Components;
using EComm.Forms;
using EComm;
using EComm.Models;

namespace EComm.Forms
{
    public partial class FormRegistration : BaseForm
    {

        List<Validator> validators = new List<Validator>();

        public override bool IsFullScreen()
        {
            return false;
        }

        public override void OnLoad()
        {
            ParentForm.AcceptButton = BtnSubmit;
        }

        public FormRegistration()
        {
            InitializeComponent();
            validators.Add(new Validator(TextName, LabelNameError, "Name", "required|name|min:5"));
            validators.Add(new Validator(TextEmail, LabelEmailError, "Email", "required|email|unique:users,email"));
            validators.Add(new Validator(TextPassword, LabelPasswordError, "Password", "required|min:8"));
            validators.Add(new Validator(TextConfirmPassword, LabelConfirmPasswordError, "Confirm Password", "required|min:8|compare") { compare_control = TextPassword });
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                User new_user = new User();
                new_user.Fullname = TextName.Text.Trim();
                new_user.Email = TextEmail.Text.Trim();
                new_user.Password = Util.GetHashSHA256(TextPassword.Text.Trim());
                new_user.Role = "Administrator";
                new_user.Save();

                AlertNotification.ShowAlertMessage("Registered Successfully", AlertNotification.AlertType.SUCCESS);

                MainForm.LoadForm(new FormAdminLogin());
            }
        }
    }
}
