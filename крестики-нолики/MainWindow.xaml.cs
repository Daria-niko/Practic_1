using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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


namespace крестики_нолики
{
    public partial class MainWindow : Window
    {
        public static List <Button> buttons = new List<Button>();
        public static List<Button> btn = new List<Button>();
        public int click;
        public MainWindow()
        {
            InitializeComponent();
            buttons.Add(Button1);
            buttons.Add(Button2);
            buttons.Add(Button3);
            buttons.Add(Button4);
            buttons.Add(Button5);
            buttons.Add(Button6);
            buttons.Add(Button7);
            buttons.Add(Button8);
            buttons.Add(Button9);
        }
        private void new_game_Click(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                button.IsEnabled = true;
                button.Content = "";
                Text.Text = "";
                click = 0;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                ((Button)sender).Content = "X";
                ((Button)sender).IsEnabled = false;
                computer(click);
            }
            else if (click % 2 == 0)
            {
                ((Button)sender).Content = "O";
                ((Button)sender).IsEnabled = false;
                computer(click);
            }
            if ((Button1.Content == "X" && Button2.Content == "X" && Button3.Content == "X") || (Button4.Content == "X" && Button5.Content == "X" && Button6.Content == "X") || (Button7.Content == "X" && Button8.Content == "X" && Button9.Content == "X"))
            {
                Text.Text = "Выиграли крестики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            else if ((Button1.Content == "X" && Button5.Content == "X" && Button9.Content == "X") || (Button3.Content == "X" && Button5.Content == "X" && Button7.Content == "X"))
            {
                Text.Text = "Выиграли крестики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            else if ((Button1.Content == "X" && Button4.Content == "X" && Button7.Content == "X") || (Button2.Content == "X" && Button5.Content == "X" && Button8.Content == "X") || (Button3.Content == "X" && Button6.Content == "X" && Button9.Content == "X"))
            {
                Text.Text = "Выиграли крестики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            if ((Button1.Content == "O" && Button2.Content == "O" && Button3.Content == "O") || (Button4.Content == "O" && Button5.Content == "O" && Button6.Content == "O") || (Button7.Content == "O" && Button8.Content == "O" && Button9.Content == "O"))
            {
                Text.Text = "Выиграли нолики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            else if ((Button1.Content == "O" && Button5.Content == "O" && Button9.Content == "O") || (Button3.Content == "O" && Button5.Content == "O" && Button7.Content == "O") || (Button1.Content == "O" && Button4.Content == "O" && Button7.Content == "O"))
            {
                Text.Text = "Выиграли нолики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            else if ((Button2.Content == "O" && Button5.Content == "O" && Button8.Content == "O") || (Button3.Content == "O" && Button6.Content == "O" && Button9.Content == "O"))
            {
                Text.Text = "Выиграли нолики";
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
            }
            else
            {
                Text.Text = "Ничья";
            }
        }
        public static void computer(int click)
        {
            Random rnd = new Random();
            int num_but = rnd.Next(0, 8);
            if (click % 2 == 0)
            {
                if (buttons[num_but].Content == "")
                {
                    buttons[num_but].Content = "X";
                    buttons[num_but].IsEnabled = false;
                    click++;
                };
            }
            else if (click % 2 != 0)
            {
                if (buttons[num_but].Content == "")
                {
                    buttons[num_but].Content = "O";
                    buttons[num_but].IsEnabled = false;
                    click++;
                }
            }
        }
    }
}
