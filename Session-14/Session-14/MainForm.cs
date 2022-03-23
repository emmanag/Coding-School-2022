using Session_14.App.Repositories;
using Session_14.model;
using TodoApp.EF.Repositories;

namespace Session_14
{
    public partial class MainForm : Form
    {
        private readonly IEntityRepo<Transaction> _transactionRepository;
        private object selectedTransaction;

        public MainForm(IEntityRepo<Transaction> transactionRepository)
        {
            InitializeComponent();
            _transactionRepository = transactionRepository;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            var TransactionTile = textBox1.Text;
            if (string.IsNullOrEmpty(TransactionTile))
                return;
            var Transaction = new Transaction(TransactionLine);
            _transactionRepository.Create(Transaction);
            textBox1.Text = String.Empty;
            RefreshTodos();

        }    
                         

        private void Btnfinish_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedTodo = selectedRow.DataBoundItem as TransactionLine;
                if (selectedTodo is not null)
                {
                    selectedTodo.Finished = true;
                    TransactionRepository.Update(selectedTransaction.ID, selectedTransaction);
                    RefreshTodos();
                }
    }
            }
    }
}
       




        
    
