using System;
using System.Collections.Generic;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Cross_zero
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int user;
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            user = 1;
            False();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            /*Start.IsEnabled = false;*/


            if (user == 1)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "X");
                user = 0;
            }
            if (user == 0)
            {
                Bot();
                /*sender.GetType().GetProperty("Content").SetValue(sender, "O");*/
                user = 1;

            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            /*switch (user)
            {
                case 1:
            
                    sender.GetType().GetProperty("Content").SetValue(sender, "X");
                    user = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "O");
                    user = 1;
                break;
            }*/
            Proverka();
        }
        private void Proverka()
        {

            if (Button1.Content == Button2.Content && Button2.Content == Button3.Content)
            {
                if (Button1.Content == "X" && Button2.Content == "X" && Button3.Content == "X")
                {
                    if (Button1.Content != "")
                        Pobeda.Content = "Вы победили!";
                    if (Pobeda.Content == "Вы победили!")
                    {
                        False();
                    }
                }
                if (Button1.Content == "O" && Button2.Content == "O" && Button3.Content == "O")
                {
                    Pobeda.Content = "Вы проиграли компьютеру!";
                    False();
                }
            }
            if (Button4.Content == Button5.Content && Button5.Content == Button6.Content)
            {
                if (Button4.Content == "X" && Button5.Content == "X" && Button6.Content == "X")
                {
                    if (Button4.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button4.Content == "O" && Button5.Content == "O" && Button6.Content == "O")
                {
                    Pobeda.Content = "Вы проиграли компьютеру!";
                    False();
                }
            }
            if (Button7.Content == Button8.Content && Button8.Content == Button9.Content)
            {
                if (Button7.Content == "X" && Button8.Content == "X" && Button9.Content == "X")
                {
                    if (Button7.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button7.Content == "O" && Button8.Content == "O" && Button9.Content == "O")
                {
                    Pobeda.Content = "Вы проиграли компьютеру!";
                    False();
                }
            }
            if (Button1.Content == Button4.Content && Button4.Content == Button7.Content)
            {
                if (Button1.Content == "X" && Button4.Content == "X" && Button7.Content == "X")
                {
                    if (Button1.Content != "")
                    {

                        Pobeda.Content = "Вы победили!";
                        /*  if (Pobeda.Content == "Вы победили!")
                          {*/
                        False();
                    }
                }
                if (Button1.Content == "O" && Button4.Content == "O" && Button7.Content == "O")
                {
                    Pobeda.Content = "Вы проиграли компьютеру!";
                    False();
                }
            }
            if (Button1.Content == Button5.Content && Button5.Content == Button9.Content)
            {
                if (Button1.Content == "X" && Button5.Content == "X" && Button9.Content == "X")
                {
                    if (Button1.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button1.Content == "O" && Button5.Content == "O" && Button9.Content == "O")
                {
                    Pobeda.Content = "Вы проиграли компьютеру!";
                    False();
                }
            }
            if (Button2.Content == Button5.Content && Button5.Content == Button8.Content)
            {
                if (Button2.Content == "X" && Button5.Content == "X" && Button8.Content == "X")
                {
                    if (Button2.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button2.Content == "O" && Button5.Content == "O" && Button8.Content == "O")
                {
                    if (Button3.Content != "")
                    {
                        Pobeda.Content = "Вы проиграли компьютеру!";
                        False();
                    }
                }
            }
            if (Button3.Content == Button5.Content && Button5.Content == Button7.Content)
            {
                if (Button3.Content == "X" && Button5.Content == "X" && Button7.Content == "X")
                {
                    if (Button3.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button3.Content == "O" && Button5.Content == "O" && Button7.Content == "O")
                {
                    if (Button3.Content != "")
                    {
                        Pobeda.Content = "Вы проиграли компьютеру!";
                        False();
                    }
                }
            }
            if (Button3.Content == Button6.Content && Button6.Content == Button9.Content)
            {
                if (Button3.Content == "X" && Button6.Content == "X" && Button9.Content == "X")
                {
                    if (Button3.Content != "")
                    {
                        Pobeda.Content = "Вы победили!";
                        False();
                    }
                }
                if (Button3.Content == "O" && Button6.Content == "O" && Button9.Content == "O")
                {
                    if (Button3.Content != "")
                    {
                        Pobeda.Content = "Вы проиграли компьютеру!";
                        False();
                    }
                }
            }
            /*if (Button1.Content != Button2.Content && Button2 != Button3.Content && Button4.Content != Button5.Content && Button5.Content != Button6.Content && Button7.Content != Button8.Content 
                && Button8.Content != Button9.Content && Button1.Content != Button4.Content && Button4.Content != Button7.Content
                && Button2.Content != Button5.Content && Button5.Content != Button8.Content && Button3.Content != Button6.Content && Button6.Content != Button9.Content 
                && Button1.Content != Button5.Content && Button5.Content != Button9.Content && Button3.Content != Button5.Content && Button5.Content != Button7.Content)
            {
                False();
                Pobeda.Content = "Ничья!";
            }*/         
        }

        private void Bot()
        {
            if (user == 0)
            {
                int max = rnd.Next(1, 9);
                if (max == 1)
                {
                    if (Button1.Content == "")
                    {
                        Button1.Content = "O";
                        Button1.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        Bot();
                    }
                }
            
                else if (max == 2)
                {
                    if (Button2.Content == "")
                    {
                        Button2.Content = "O";
                        Button2.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                            /*Proverka();*/
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 3)
                {
                    if (Button3.Content == "")
                    {
                        Button3.Content = "O";
                        Button3.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 4)
                {
                    if (Button4.Content == "")
                    {
                        Button4.Content = "O";
                        Button4.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 5)
                {
                    if (Button5.Content == "")
                    {
                        Button5.Content = "O";
                        Button5.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 6)
                {
                    if (Button6.Content == "")
                    {
                        Button6.Content = "O";
                        Button6.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False(); ;
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 7)
                {
                    if (Button7.Content == "")
                    {
                        Button7.Content = "O";
                        Button7.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 8)
                {
                    if (Button8.Content == "")
                    {
                        Button8.Content = "O";
                        Button8.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                }
                else if (max == 9)
                {
                    if (Button9.Content == "")
                    {
                        Button9.Content = "O";
                        Button9.IsEnabled = false;
                        Proverka();
                    }
                    else
                    {
                        if (Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != "")
                        {
                            Pobeda.Content = "Ничья!";
                            False();
                        }
                        else
                        {
                            Bot();
                        }
                    }
                } 
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pobeda.Content = "";
            Button1.Content = "";
            Button2.Content = "";
            Button3.Content = "";
            Button4.Content = "";
            Button5.Content = "";
            Button6.Content = "";
            Button7.Content = "";
            Button8.Content = "";
            Button9.Content = "";
            if (Start.IsEnabled == true)
            {
                True();
            }
            //попробуй поставить в цикл чтобы выбор повторялся пока не будет верным
        }

        private void False()
        {
            Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
        }

        private void True()
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;
        }
    }
}
