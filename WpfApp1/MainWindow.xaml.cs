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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "😊","😊",
                "😒","😒",
                "🚗","‍🚗",
                "😘","😘",
                "😎","😎",
                "🧔","🧔",
                "‍🦼","🦼",
                "👮‍","👮",

            };

            Random random = new Random();
            var list = mainGrid.Children.OfType<TextBlock>().ToList();
            foreach(var item in list )
            {
                int index = random.Next(animalEmoji.Count);
                string nextMoji = animalEmoji[index];
                item.Text = nextMoji;
                animalEmoji.RemoveAt(index);
            }
            //var currentgridindex = 0;
            //for (int j = 0; j < animalEmoji.Count; j = 0)
            //{
            //    int index = random.Next(animalEmoji.Count);
            //    string nextMoji = animalEmoji[index];
            //    list[currentgridindex++].Text = nextMoji;
            //    animalEmoji.RemoveAt(index);
            //    for (int i = 0; i < animalEmoji.Count; i++)
            //    {
            //        if (nextMoji == animalEmoji[i])
            //        {
            //            list[currentgridindex++].Text = animalEmoji[i];

            //            animalEmoji.RemoveAt(i);
            //        }
            //    }
            //}


        }
    }
}
