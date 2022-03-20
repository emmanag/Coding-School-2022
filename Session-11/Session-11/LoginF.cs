using DataLibrary.DataClasses;
using DataLibrary.ItemHandlers;
using Session_11.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.IO;

namespace Session_11
{
    public partial class LoginF : Form
    {
        private const string FILE_NAME = "accounts.txt";
        private SecurityHandler _securityHandler;
        private MessagesHelper _messagesHelper;
        private List<Credential> _users;
        private Credential _user;
        private string _userPassword;

        public LoginF()
        {
            InitializeComponent();

            // Set Default Theme
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019DarkGray);

            _securityHandler = new SecurityHandler();
            _messagesHelper = new MessagesHelper();
            _userPassword = string.Empty;
        }

        private void LoginF_Load(object sender, EventArgs e)
        {
            //RUN THIS FIRST -> Creating new user - ONLY FOR DEBBUGING!
            if (!File.Exists(FILE_NAME))
            {
                var user = new Credential("Admin");
                user.Password = _securityHandler.EncryptUserPassword("1234");
                _securityHandler.WritePassFile(FILE_NAME, user);
            }

            _users = _securityHandler.ReadPassFile(FILE_NAME);

            PopulateControls();

            bsUsers.DataSource = _user;
        }
        private void Btnenter_Click(object sender, EventArgs e)
        {
            _user = _users.Find(u => u.ID == new Guid(ctrlUsername.EditValue.ToString()));
            if (ctrlPassword.EditValue != null)
                _userPassword = ctrlPassword.EditValue.ToString();

            if (_securityHandler.ValidateUserCredentials(_user, _userPassword))
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenApp));
                t.Start();
                this.Close();
            }
            else
            {
                _messagesHelper.MessageError("Account username and password don't match.\nPlease try again.");
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateControls()
        {
            var helper = new ControlsHelper();
            helper.PopulateAccounts(ctrlUsername.Properties, _users);
        }

        public void SetDataBindings()
        {
            ctrlUsername.DataBindings.Add(new Binding("EditValue", bsUsers, "Username"));
        }

        public static void OpenApp()
        {
            Application.Run(new CarCenter());
        }

    }
}
