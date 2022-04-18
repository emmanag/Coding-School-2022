using Gas_Station.Model;
using Gas_Station.Shared;
using Gas_Station.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gas_Station.Win.ItemForms
{
    public partial class ItemEditF : Form
    {

        private ItemListViewModel _item;
        private HttpClient _client;

        public ItemEditF(HttpClient client)
        {
            InitializeComponent();
            _client = client;
        }

        public ItemEditF(HttpClient client, ItemListViewModel item): this(client)
        {
            _item = item;
        }

        private void CustomerEditF_Load(object sender, EventArgs e)
        {
            if (_item == null)
            {
                _item = new ItemListViewModel();
            }
            bsItem.DataSource = _item;

            SetDataBindings();
        }

        private void SetDataBindings()
        {
            txtDescription.DataBindings.Add(new Binding("Text", bsItem, "Description", true));
            txtCost.DataBindings.Add(new Binding("Text", bsItem, "Cost", true));
            txtPrice.DataBindings.Add(new Binding("Text", bsItem,"Price", true));
            txtCode.DataBindings.Add(new Binding("Text", bsItem, "Code", true));

            string[] itemType = Enum.GetNames(typeof(ItemType));
            comboItemType.Items.AddRange(itemType);

            comboItemType.DataBindings.Add(new Binding("Text", bsItem, "ItemType", true));
           
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || 
                string.IsNullOrWhiteSpace(txtCost.Text) || 
                string.IsNullOrWhiteSpace(txtPrice.Text))
                return;

            if (_item.ID == Guid.Empty)
            {
                var response = await _client.PostAsJsonAsync("item", _item);
            }
            else
            {
                var response = await _client.PutAsJsonAsync("item", _item);
            }
            Close();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
