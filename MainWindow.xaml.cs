using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Prokovefa_Ver_ToDoList.Date;
using Prokovefa_Ver_ToDoList.Model;
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

namespace Prokovefa_Ver_ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            B();
        }

        public void B()
        {
            DG.Items.Clear();
            var context = new TaskDbContact();
            foreach ( var item in context.task)
            {
                DG.Items.Add(item);
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new TaskDbContact())
            {
                   string textbox1 = textbox.Text;
                    if (!string.IsNullOrEmpty(textbox1))
                    {
                        var name_task = textbox1;

                        Model.Task task1 = new Model.Task()
                        {
                            Name = name_task
                        };

                        context.task.Add(task1);

                        context.SaveChanges();
                    }
                }
            B();
        }

        private void TextBlock_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            using (var context = new TaskDbContact())
            {
                if (e.Key == Key.Enter)
                {
                    string textbox1 = textbox.Text;
                    if (!string.IsNullOrEmpty(textbox1))
                    {
                        var name_task = textbox1;

                        Model.Task task1 = new Model.Task()
                        {
                            Name = name_task
                        };

                        context.task.Add(task1);

                        context.SaveChanges();
                    }
                }
            }
            B();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var context = new TaskDbContact();
            var task1 = (DG.SelectedItem as Model.Task);
            var id = task1.Id;
            context.Entry(task1).State = EntityState.Deleted;
            context.SaveChanges();
            B();
        }
        Model.Task task1;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Model.Task task = DG.SelectedItem as Model.Task;
            using (var context = new TaskDbContact())
            {
                task.Name = df.Text;
                context.task.Update(task);
                context.SaveChanges();
                //  task1. = (DG.SelectedItem as Model.Task);


            }
            B();

        }

        private void df_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            using (var context = new TaskDbContact())
            {
                if (e.Key == Key.Enter)
                {

                    if (!string.IsNullOrEmpty(df.Text))
                    {
                        var name_task = df.Text;
                      
                        task1.Name = name_task;
                        context.Entry(task1).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
            }
            B();
        }
    }
}
