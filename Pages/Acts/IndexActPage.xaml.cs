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
using Word = Microsoft.Office.Interop.Word;

namespace WpfFarm.Pages.Acts
{
    /// <summary>
    /// Логика взаимодействия для IndexActPage.xaml
    /// </summary>
    public partial class IndexActPage : Page
    {
        public IndexActPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGrid.ItemsSource = EFContext.Context.АктСписанияКормов.ToList();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditActPage());
        }
        private readonly string TemplateFileName = System.IO.Path.GetFullPath(@"Word/Act.docx");
        void ReplaceWordStub(String stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        private void WordClick(object sender, RoutedEventArgs e)
        {
            var wordApp = new Word.Application();

            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName);

            List<АктСписанияКормов> Acts = DGrid.ItemsSource as List<АктСписанияКормов>;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            foreach (var item in Acts)
            {
                string text = $"Дата:{item.Date}; {item.Животные.Название}, Корм: {item.Корм.Имя} Х {item.Количество} ШТ; Сумма {item.Количество*item.Корм.Цена} руб";
                sb.AppendLine(text);
            }
            ReplaceWordStub("(text)", sb.ToString(), wordDocument);
            wordDocument.SaveAs2(System.IO.Path.GetFullPath($@"Word/Act{Guid.NewGuid()}.docx"));

            wordApp.Visible = true;
        }
    }
}
