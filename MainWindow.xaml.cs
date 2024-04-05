using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace TextStatWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();
        private string text = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
        }


        private void sent_Click(object sender, RoutedEventArgs e)
        {
            text = tbMult.Text;
            var l = new Label
            {
                Content = CountSentences(text)
            };
            stack.Children.Add(l);

        }

        private void symb_Click(object sender, RoutedEventArgs e)
        {
            text = tbMult.Text;
            var l = new Label
            {
                Content = CountSymbols(text)
            };
            stack.Children.Add(l);
        }

        private void word_Click(object sender, RoutedEventArgs e)
        {
            text = tbMult.Text;
            var l = new Label
            {
                Content = CountWords(text)
            };
            stack.Children.Add(l);
        }

        private void quest_Click(object sender, RoutedEventArgs e)
        {
            text = tbMult.Text;
            var l = new Label
            {
                Content = CountQuestions(text)
            };
            stack.Children.Add(l);
        }

        private void excl_Click(object sender, RoutedEventArgs e)
        {
            text = tbMult.Text;
            var l = new Label
            {
                Content = CountExclamations(text)
            };
            stack.Children.Add(l);
        }

        private string CountSentences(string text)
        {
            int num = text.TrimEnd('.').Split('.').Count();
            return $"Sentences: {num}";
        }

        private string CountWords(string text)
        {
            int num = text.Split(' ').Count();
            return $"Words: {num}";
        }

        private string CountSymbols(string text)
        {
            int num = text.Count();
            return $"Symbols: {num}";
        }
        private string CountQuestions(string text)
        {
            int num = text.Where(t => t == '?').Count();
            return $"Questions: {num}";
        }

        private string CountExclamations(string text)
        {
            int num = text.Where(t => t == '!').Count();
            return $"Exclamations: {num}";
        }

        private void tbMult_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = stack.Children.Count-1; i >= 1 ; i--)
            {
                stack.Children.RemoveAt(i);
            }
        }


    }
}