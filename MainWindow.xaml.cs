
using System.Windows;
using WPFDB.DB;

namespace WPFDB
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.Name = tbName.Text;
            student.Group = tbGroup.Text;

            MS_SQL_Context _context = new MS_SQL_Context();

            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
