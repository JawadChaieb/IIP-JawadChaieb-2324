using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            TodoItem todoItem = new TodoItem
            {
                Content = txtTodo.Text,
                Priority = (Priority)cbxPrioriteit.SelectedIndex
            };

            AddTodoItemToList(todoItem);
            ClearInputFields();
        }

        private void AddTodoItemToList(TodoItem todoItem)
        {
            ListBoxItem item = new ListBoxItem
            {
                Content = todoItem.Content,
                Foreground = GetPriorityBrush(todoItem.Priority)
            };

            ltbTodo.Items.Add(item);
        }

        private void ClearInputFields()
        {
            txtTodo.Text = "";
            cbxPrioriteit.SelectedIndex = 0; 
        }

        private Brush GetPriorityBrush(Priority priority)
        {
            Brush priorityBrush = Brushes.Black;

            if (priority == Priority.High)
            {
                priorityBrush = Brushes.DarkRed;
            }
            else if (priority == Priority.Medium)
            {
                priorityBrush = Brushes.DarkOrange;
            }
            else if (priority == Priority.Low)
            {
                priorityBrush = Brushes.DarkGreen;
            }

            return priorityBrush;
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            ltbTodo.Items.Clear();
        }
    }

    public class TodoItem
    {
        public string Content { get; set; }
        public Priority Priority { get; set; }
    }

    public enum Priority
    {
        High,
        Medium,
        Low
    }
}
