using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace список_книг
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Books selectedBook;

        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Books> Books { get; set; }
        public Books SelectedBook
        {
            get => selectedBook;

            set
            {
                selectedBook = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(SelectedBook)));
            }

        }

        public MainWindow()
        {
            InitializeComponent();

            Books = new List<Books>();
            Books.Add(new Books
            {
                BookName = "Чёрный обелиск",
                Author = "Эрих Мария Ремарк",
                Year= "1956",
                Genre= "Роман",
            });

            Books.Add(new Books
            {
                BookName = "Библия",
                Author = "Бог",
                Year = " 1513",
                Genre = "Фэнтези",
            });

            Books.Add(new Books
            {
                BookName = "Молот Ведьм",
                Author = " Генрих Крамер, Якоб Шпренгер",
                Year = "1487",
                Genre = "Богословие",
            });

            Books.Add(new Books
            {
                BookName = "Маленький принц",
                Author = "Антуан де Сент-Экзюпери",
                Year = "1943",
                Genre = "Детская Классика",
            });

            Books.Add(new Books
            {
                BookName = "Ночь в Лиссабоне",
                Author = "Эрих Мария Ремарк",
                Year = "1962",
                Genre = "Роман",
            });









            DataContext = this;

        }

    } 
}
    


