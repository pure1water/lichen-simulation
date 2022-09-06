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
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>

    public class buton : Button
    {
        
        

        
        

        

        public void isInfected()
        {
            this.Content = "Заражена";
            this.Background = Brushes.Red;
         }
        public void isImmune()
        {
            this.Content = "Иммунна";
            this.Background = Brushes.Beige;
        }
        public void isHealthy()
        {
            this.Content = "Здорова";
            this.Background = Brushes.White;
        }
    }
        
        
    
        
    public partial class Game : Window
    {
        

        




        public Game()
        {
            InitializeComponent();

            Random rand = new Random();

            int[,] setka = new int[11, 11] {      { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,10,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                 { 0,0,0,0,0,0,0,0,0,0,0}};


            


            
            
        
            timer okno3 = new timer();
            okno3.Show();
            okno3.textblock.Text = Convert.ToString(0);
            
            
            void timerTick(object sender, EventArgs e) // таймер который делает что-то каждую секунду
            {
                okno3.textblock.Text = Convert.ToString(Convert.ToInt32(okno3.textblock.Text) + 1);

                for (int i = 0; i < 11; i++)// идет сама логика приложения
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (setka[i, j] <= 10 & setka[i, j] >= 5)
                        {
                            int choose = rand.Next(1, 9);
                            int pr = rand.Next(0, 2);
                            if (pr == 1)
                            {
                                switch (choose)
                                {
                                    case 1:
                                        try
                                        {
                                            if (setka[i - 1, j - 1] < 0)
                                            {
                                                setka[i - 1, j - 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            if (setka[i - 1, j] < 0)
                                            {
                                                setka[i - 1, j] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 3:
                                        try
                                        {
                                            if (setka[i - 1, j + 1] < 0)
                                            {
                                                setka[i - 1, j + 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 4:
                                        try
                                        {
                                            if (setka[i, j + 1] < 0)
                                            {
                                                setka[i, j + 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 5:
                                        try
                                        {
                                            if (setka[i + 1, j + 1] < 0)
                                            {
                                                setka[i + 1, j + 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 6:
                                        try
                                        {
                                            if (setka[i + 1, j] < 0)
                                            {
                                                setka[i + 1, j] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 7:
                                        try
                                        {
                                            if (setka[i + 1, j - 1] < 0)
                                            {
                                                setka[i + 1, j - 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    case 8:
                                        try
                                        {
                                            if (setka[i, j - 1] < 0)
                                            {
                                                setka[i, j - 1] = 10;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                        break;

                                }



                                setka[i, j]--;
                            }
                            else
                            {
                                setka[i, j]--;
                            }
                        }
                        else if (setka[i, j] <= 4 & setka[i, j] >= 0)
                        {
                            setka[i, j]--;
                        }
                        else if (setka[i, j] < 0)
                        {
                            setka[i, j]--;
                        }
                        // закрашивание клеток 
                        if (setka[0, 0] <= 10 & setka[0, 0] >= 5) // 0,0
                        {
                            b0I0.isInfected();
                        }
                        if (setka[0, 0] <= 4 & setka[0, 0] >= 0)
                        {
                            b0I0.isImmune();
                        }
                        if (setka[0, 0] < 0)
                        {
                            b0I0.isHealthy();
                        }
                        if (setka[0, 1] <= 10 & setka[0, 1] >= 5)// 0,1
                        {
                            b0I1.isInfected();
                        }
                        if (setka[0, 1] <= 4 & setka[0, 1] >= 0)
                        {
                            b0I1.isImmune();
                        }
                        if (setka[0, 1] < 0)
                        {
                            b0I1.isHealthy();
                        }
                        if (setka[0, 2] <= 10 & setka[0, 2] >= 5) // 0,2
                        {
                            b0I2.isInfected();
                        }
                        if (setka[0, 2] <= 4 & setka[0, 2] >= 0)
                        {
                            b0I2.isImmune();
                        }
                        if (setka[0, 2] < 0)
                        {
                            b0I2.isHealthy();
                        }
                        if (setka[0, 3] <= 10 & setka[0, 3] >= 5) // 0,3
                        {
                            b0I3.isInfected();
                        }
                        if (setka[0, 3] <= 4 & setka[0, 3] >= 0)
                        {
                            b0I3.isImmune();
                        }
                        if (setka[0, 3] < 0)
                        {
                            b0I3.isHealthy();
                        }
                        if (setka[0, 4] <= 10 & setka[0, 4] >= 5) // 0,4
                        {
                            b0I4.isInfected();
                        }
                        if (setka[0, 4] <= 4 & setka[0, 4] >= 0)
                        {
                            b0I4.isImmune();
                        }
                        if (setka[0, 4] < 0)
                        {
                            b0I4.isHealthy();
                        }
                        if (setka[0, 5] <= 10 & setka[0, 5] >= 5) // 0,5
                        {
                            b0I5.isInfected();
                        }
                        if (setka[0, 5] <= 4 & setka[0, 5] >= 0)
                        {
                            b0I5.isImmune();
                        }
                        if (setka[0, 5] < 0)
                        {
                            b0I5.isHealthy();
                        }
                        if (setka[0, 6] <= 10 & setka[0, 6] >= 5) // 0,6
                        {
                            b0I6.isInfected();
                        }
                        if (setka[0, 6] <= 4 & setka[0, 6] >= 0)
                        {
                            b0I6.isImmune();
                        }
                        if (setka[0, 6] < 0)
                        {
                            b0I6.isHealthy();
                        }
                        if (setka[0, 7] <= 10 & setka[0, 7] >= 5) // 0,7
                        {
                            b0I7.isInfected();
                        }
                        if (setka[0, 7] <= 4 & setka[0, 7] >= 0)
                        {
                            b0I7.isImmune();
                        }
                        if (setka[0, 7] < 0)
                        {
                            b0I7.isHealthy();
                        }
                        if (setka[0, 8] <= 10 & setka[0, 8] >= 5) // 0,8
                        {
                            b0I8.isInfected();
                        }
                        if (setka[0, 8] <= 4 & setka[0, 8] >= 0)
                        {
                            b0I8.isImmune();
                        }
                        if (setka[0, 8] < 0)
                        {
                            b0I8.isHealthy();
                        }
                        if (setka[0, 9] <= 10 & setka[0, 9] >= 5) // 0,9
                        {
                            b0I9.isInfected();
                        }
                        if (setka[0, 9] <= 4 & setka[0, 9] >= 0)
                        {
                            b0I9.isImmune();
                        }
                        if (setka[0, 9] < 0)
                        {
                            b0I9.isHealthy();
                        }
                        if (setka[0, 10] <= 10 & setka[0, 10] >= 5) // 0,10
                        {
                            b0I10.isInfected();
                        }
                        if (setka[0, 10] <= 4 & setka[0, 10] >= 0)
                        {
                            b0I10.isImmune();
                        }
                        if (setka[0, 10] < 0)
                        {
                            b0I10.isHealthy();
                        }
                        if (setka[1, 0] <= 10 & setka[1, 0] >= 5) // 1,0
                        {
                            b1I0.isInfected();
                        }
                        if (setka[1, 0] <= 4 & setka[1, 0] >= 0)
                        {
                            b1I0.isImmune();
                        }
                        if (setka[1, 0] < 0)
                        {
                            b1I0.isHealthy();
                        }
                        if (setka[1, 1] <= 10 & setka[1, 1] >= 5) // 1,1
                        {
                            b1I1.isInfected();
                        }
                        if (setka[1, 1] <= 4 & setka[1, 1] >= 0)
                        {
                            b1I1.isImmune();
                        }
                        if (setka[1, 1] < 0)
                        {
                            b1I1.isHealthy();
                        }
                        if (setka[1, 2] <= 10 & setka[1, 2] >= 5) // 1,2
                        {
                            b1I2.isInfected();
                        }
                        if (setka[1, 2] <= 4 & setka[1, 2] >= 0)
                        {
                            b1I2.isImmune();
                        }
                        if (setka[1, 2] < 0)
                        {
                            b1I2.isHealthy();
                        }
                        if (setka[1, 3] <= 10 & setka[1, 3] >= 5) // 1,3
                        {
                            b1I3.isInfected();
                        }
                        if (setka[1, 3] <= 4 & setka[1, 3] >= 0)
                        {
                            b1I3.isImmune();
                        }
                        if (setka[1, 3] < 0)
                        {
                            b1I3.isHealthy();
                        }
                        if (setka[1, 4] <= 10 & setka[1, 4] >= 5) // 1,4
                        {
                            b1I4.isInfected();
                        }
                        if (setka[1, 4] <= 4 & setka[1, 4] >= 0)
                        {
                            b1I4.isImmune();
                        }
                        if (setka[1, 4] < 0)
                        {
                            b1I4.isHealthy();
                        }
                        if (setka[1, 5] <= 10 & setka[1, 5] >= 5) // 1,5
                        {
                            b1I5.isInfected();
                        }
                        if (setka[1, 5] <= 4 & setka[1, 5] >= 0)
                        {
                            b1I5.isImmune();
                        }
                        if (setka[1, 5] < 0)
                        {
                            b1I5.isHealthy();
                        }
                        if (setka[1, 6] <= 10 & setka[1, 6] >= 5) // 1,6
                        {
                            b1I6.isInfected();
                        }
                        if (setka[1, 6] <= 4 & setka[1, 6] >= 0)
                        {
                            b1I6.isImmune();
                        }
                        if (setka[1, 6] < 0)
                        {
                            b1I6.isHealthy();
                        }
                        if (setka[1, 7] <= 10 & setka[1, 7] >= 5) // 1,7
                        {
                            b1I7.isInfected();
                        }
                        if (setka[1, 7] <= 4 & setka[1, 7] >= 0)
                        {
                            b1I7.isImmune();
                        }
                        if (setka[1, 7] < 0)
                        {
                            b1I7.isHealthy();
                        }
                        if (setka[1, 8] <= 10 & setka[1, 8] >= 5) // 1,8
                        {
                            b1I8.isInfected();
                        }
                        if (setka[1, 8] <= 4 & setka[1, 8] >= 0)
                        {
                            b1I8.isImmune();
                        }
                        if (setka[1, 8] < 0)
                        {
                            b1I8.isHealthy();
                        }
                        if (setka[1, 9] <= 10 & setka[1, 9] >= 5) // 1,9
                        {
                            b1I9.isInfected();
                        }
                        if (setka[1, 9] <= 4 & setka[1, 9] >= 0)
                        {
                            b1I9.isImmune();
                        }
                        if (setka[1, 9] < 0)
                        {
                            b1I9.isHealthy();
                        }
                        if (setka[1, 10] <= 10 & setka[1, 10] >= 5) // 1,10
                        {
                            b1I10.isInfected();
                        }
                        if (setka[1, 10] <= 4 & setka[1, 10] >= 0)
                        {
                            b1I10.isImmune();
                        }
                        if (setka[1, 10] < 0)
                        {
                            b1I10.isHealthy();
                        }

                        if (setka[2, 0] <= 10 & setka[2, 0] >= 5) // 2,0
                        {
                            b2I0.isInfected();
                        }
                        if (setka[2, 0] <= 4 & setka[2, 0] >= 0)
                        {
                            b2I0.isImmune();
                        }
                        if (setka[2, 0] < 0)
                        {
                            b2I0.isHealthy();
                        }
                        if (setka[2, 1] <= 10 & setka[2, 1] >= 5) // 2,1
                        {
                            b2I1.isInfected();
                        }
                        if (setka[2, 1] <= 4 & setka[2, 1] >= 0)
                        {
                            b2I1.isImmune();
                        }
                        if (setka[2, 1] < 0)
                        {
                            b2I1.isHealthy();
                        }
                        if (setka[2, 2] <= 10 & setka[2, 2] >= 5) // 2,2
                        {
                            b2I2.isInfected();
                        }
                        if (setka[2, 2] <= 4 & setka[2, 2] >= 0)
                        {
                            b2I2.isImmune();
                        }
                        if (setka[2, 2] < 0)
                        {
                            b2I2.isHealthy();
                        }
                        if (setka[2, 3] <= 10 & setka[2, 3] >= 5) // 2,3
                        {
                            b2I3.isInfected();
                        }
                        if (setka[2, 3] <= 4 & setka[2, 3] >= 0)
                        {
                            b2I3.isImmune();
                        }
                        if (setka[2, 3] < 0)
                        {
                            b2I3.isHealthy();
                        }
                        if (setka[2, 4] <= 10 & setka[2, 4] >= 5) // 2,4
                        {
                            b2I4.isInfected();
                        }
                        if (setka[2, 4] <= 4 & setka[2, 4] >= 0)
                        {
                            b2I4.isImmune();
                        }
                        if (setka[2, 4] < 0)
                        {
                            b2I4.isHealthy();
                        }
                        if (setka[2, 5] <= 10 & setka[2, 5] >= 5) // 2,5
                        {
                            b2I5.isInfected();
                        }
                        if (setka[2, 5] <= 4 & setka[2, 5] >= 0)
                        {
                            b2I5.isImmune();
                        }
                        if (setka[2, 5] < 0)
                        {
                            b2I5.isHealthy();
                        }
                        if (setka[2, 6] <= 10 & setka[2, 6] >= 5) // 2,6
                        {
                            b2I6.isInfected();
                        }
                        if (setka[2, 6] <= 4 & setka[2, 6] >= 0)
                        {
                            b2I6.isImmune();
                        }
                        if (setka[2, 6] < 0)
                        {
                            b2I6.isHealthy();
                        }
                        if (setka[2, 7] <= 10 & setka[2, 7] >= 5) // 2,7
                        {
                            b2I7.isInfected();
                        }
                        if (setka[2, 7] <= 4 & setka[2, 7] >= 0)
                        {
                            b2I7.isImmune();
                        }
                        if (setka[2, 7] < 0)
                        {
                            b2I7.isHealthy();
                        }
                        if (setka[2, 8] <= 10 & setka[2, 8] >= 5) // 2,8
                        {
                            b2I8.isInfected();
                        }
                        if (setka[2, 8] <= 4 & setka[2, 8] >= 0)
                        {
                            b2I8.isImmune();
                        }
                        if (setka[2, 8] < 0)
                        {
                            b2I8.isHealthy();
                        }
                        if (setka[2, 9] <= 10 & setka[2, 9] >= 5) // 2,9
                        {
                            b2I9.isInfected();
                        }
                        if (setka[2, 9] <= 4 & setka[2, 9] >= 0)
                        {
                            b2I9.isImmune();
                        }
                        if (setka[2, 9] < 0)
                        {
                            b2I9.isHealthy();
                        }
                        if (setka[2, 10] <= 10 & setka[2, 10] >= 5) // 2,10
                        {
                            b2I10.isInfected();
                        }
                        if (setka[2, 10] <= 4 & setka[2, 10] >= 0)
                        {
                            b2I10.isImmune();
                        }
                        if (setka[2, 10] < 0)
                        {
                            b2I10.isHealthy();
                        }
                        if (setka[3, 0] <= 10 & setka[3, 0] >= 5) // 3,0
                        {
                            b3I0.isInfected();
                        }
                        if (setka[3, 0] <= 4 & setka[3, 0] >= 0)
                        {
                            b3I0.isImmune();
                        }
                        if (setka[3, 0] < 0)
                        {
                            b3I0.isHealthy();
                        }
                        if (setka[3, 1] <= 10 & setka[3, 1] >= 5) // 3,1
                        {
                            b3I1.isInfected();
                        }
                        if (setka[3, 1] <= 4 & setka[3, 1] >= 0)
                        {
                            b3I1.isImmune();
                        }
                        if (setka[3, 1] < 0)
                        {
                            b3I1.isHealthy();
                        }
                        if (setka[3, 2] <= 10 & setka[3, 2] >= 5) // 3,2
                        {
                            b3I2.isInfected();
                        }
                        if (setka[3, 2] <= 4 & setka[3, 2] >= 0)
                        {
                            b3I2.isImmune();
                        }
                        if (setka[3, 2] < 0)
                        {
                            b3I2.isHealthy();
                        }
                        if (setka[3, 3] <= 10 & setka[3, 3] >= 5) // 3,3
                        {
                            b3I3.isInfected();
                        }
                        if (setka[3, 3] <= 4 & setka[3, 3] >= 0)
                        {
                            b3I3.isImmune();
                        }
                        if (setka[3, 3] < 0)
                        {
                            b3I3.isHealthy();
                        }
                        if (setka[3, 4] <= 10 & setka[3, 4] >= 5) // 3,4
                        {
                            b3I4.isInfected();
                        }
                        if (setka[3, 4] <= 4 & setka[3, 4] >= 0)
                        {
                            b3I4.isImmune();
                        }
                        if (setka[3, 4] < 0)
                        {
                            b3I4.isHealthy();
                        }
                        if (setka[3, 5] <= 10 & setka[3, 5] >= 5) // 3,5
                        {
                            b3I5.isInfected();
                        }
                        if (setka[3, 5] <= 4 & setka[3, 5] >= 0)
                        {
                            b3I5.isImmune();
                        }
                        if (setka[3, 5] < 0)
                        {
                            b3I5.isHealthy();
                        }
                        if (setka[3, 6] <= 10 & setka[3, 6] >= 5) // 3,6
                        {
                            b3I6.isInfected();
                        }
                        if (setka[3, 6] <= 4 & setka[3, 6] >= 0)
                        {
                            b3I6.isImmune();
                        }
                        if (setka[3, 6] < 0)
                        {
                            b3I6.isHealthy();
                        }
                        if (setka[3, 7] <= 10 & setka[3, 7] >= 5) // 3,7
                        {
                            b3I7.isInfected();
                        }
                        if (setka[3, 7] <= 4 & setka[3, 7] >= 0)
                        {
                            b3I7.isImmune();
                        }
                        if (setka[3, 7] < 0)
                        {
                            b3I7.isHealthy();
                        }
                        if (setka[3, 8] <= 10 & setka[3, 8] >= 5) // 3,8
                        {
                            b3I8.isInfected();
                        }
                        if (setka[3, 8] <= 4 & setka[3, 8] >= 0)
                        {
                            b3I8.isImmune();
                        }
                        if (setka[3, 8] < 0)
                        {
                            b3I8.isHealthy();
                        }
                        if (setka[3, 9] <= 10 & setka[3, 9] >= 5) // 3,9
                        {
                            b3I9.isInfected();
                        }
                        if (setka[3, 9] <= 4 & setka[3, 9] >= 0)
                        {
                            b3I9.isImmune();
                        }
                        if (setka[3, 9] < 0)
                        {
                            b3I9.isHealthy();
                        }
                        if (setka[3, 10] <= 10 & setka[3, 10] >= 5) // 3,10
                        {
                            b3I10.isInfected();
                        }
                        if (setka[3, 10] <= 4 & setka[3, 10] >= 0)
                        {
                            b3I10.isImmune();
                        }
                        if (setka[3, 10] < 0)
                        {
                            b3I10.isHealthy();
                        }
                        if (setka[4, 0] <= 10 & setka[4, 0] >= 5) // 4,0
                        {
                            b4I0.isInfected();
                        }
                        if (setka[4, 0] <= 4 & setka[4, 0] >= 0)
                        {
                            b4I0.isImmune();
                        }
                        if (setka[4, 0] < 0)
                        {
                            b4I0.isHealthy();
                        }
                        if (setka[4, 1] <= 10 & setka[4, 1] >= 5) // 4,1
                        {
                            b4I1.isInfected();
                        }
                        if (setka[4, 1] <= 4 & setka[4, 1] >= 0)
                        {
                            b4I1.isImmune();
                        }
                        if (setka[4, 1] < 0)
                        {
                            b4I1.isHealthy();
                        }
                        if (setka[4, 2] <= 10 & setka[4, 2] >= 5) // 4,2
                        {
                            b4I2.isInfected();
                        }
                        if (setka[4, 2] <= 4 & setka[4, 2] >= 0)
                        {
                            b4I2.isImmune();
                        }
                        if (setka[4, 2] < 0)
                        {
                            b4I2.isHealthy();
                        }
                        if (setka[4, 3] <= 10 & setka[4, 3] >= 5) // 4,3
                        {
                            b4I3.isInfected();
                        }
                        if (setka[4, 3] <= 4 & setka[4, 3] >= 0)
                        {
                            b4I3.isImmune();
                        }
                        if (setka[4, 3] < 0)
                        {
                            b4I3.isHealthy();
                        }
                        if (setka[4, 4] <= 10 & setka[4, 4] >= 5) // 4,4
                        {
                            b4I4.isInfected();
                        }
                        if (setka[4, 4] <= 4 & setka[4, 4] >= 0)
                        {
                            b4I4.isImmune();
                        }
                        if (setka[4, 4] < 0)
                        {
                            b4I4.isHealthy();
                        }
                        if (setka[4, 5] <= 10 & setka[4, 5] >= 5) // 4,5
                        {
                            b4I5.isInfected();
                        }
                        if (setka[4, 5] <= 4 & setka[4, 5] >= 0)
                        {
                            b4I5.isImmune();
                        }
                        if (setka[4, 5] < 0)
                        {
                            b4I5.isHealthy();
                        }
                        if (setka[4, 6] <= 10 & setka[4, 6] >= 5) // 4,6
                        {
                            b4I6.isInfected();
                        }
                        if (setka[4, 6] <= 4 & setka[4, 6] >= 0)
                        {
                            b4I6.isImmune();
                        }
                        if (setka[4, 6] < 0)
                        {
                            b4I6.isHealthy();
                        }
                        if (setka[4, 7] <= 10 & setka[4, 7] >= 5) // 4,7
                        {
                            b4I7.isInfected();
                        }
                        if (setka[4, 7] <= 4 & setka[4, 7] >= 0)
                        {
                            b4I7.isImmune();
                        }
                        if (setka[4, 7] < 0)
                        {
                            b4I7.isHealthy();
                        }
                        if (setka[4, 8] <= 10 & setka[4, 8] >= 5) // 4,8
                        {
                            b4I8.isInfected();
                        }
                        if (setka[4, 8] <= 4 & setka[4, 8] >= 0)
                        {
                            b4I8.isImmune();
                        }
                        if (setka[4, 8] < 0)
                        {
                            b4I8.isHealthy();
                        }
                        if (setka[4, 9] <= 10 & setka[4, 9] >= 5) // 4,9
                        {
                            b4I9.isInfected();
                        }
                        if (setka[4, 9] <= 4 & setka[4, 9] >= 0)
                        {
                            b4I9.isImmune();
                        }
                        if (setka[4, 9] < 0)
                        {
                            b4I9.isHealthy();
                        }
                        if (setka[4, 10] <= 10 & setka[4, 10] >= 5) // 4,10
                        {
                            b4I10.isInfected();
                        }
                        if (setka[4, 10] <= 4 & setka[4, 10] >= 0)
                        {
                            b4I10.isImmune();
                        }
                        if (setka[4, 10] < 0)
                        {
                            b4I10.isHealthy();
                        }
                        if (setka[5, 0] <= 10 & setka[5, 0] >= 5) // 5,0
                        {
                            b5I0.isInfected();
                        }
                        if (setka[5, 0] <= 4 & setka[5, 0] >= 0)
                        {
                            b5I0.isImmune();
                        }
                        if (setka[5, 0] < 0)
                        {
                            b5I0.isHealthy();
                        }
                        if (setka[5, 1] <= 10 & setka[5, 1] >= 5) // 5,1
                        {
                            b5I1.isInfected();
                        }
                        if (setka[5, 1] <= 4 & setka[5, 1] >= 0)
                        {
                            b5I1.isImmune();
                        }
                        if (setka[5, 1] < 0)
                        {
                            b5I1.isHealthy();
                        }
                        if (setka[5, 2] <= 10 & setka[5, 2] >= 5) // 5,2
                        {
                            b5I2.isInfected();
                        }
                        if (setka[5, 2] <= 4 & setka[5, 2] >= 0)
                        {
                            b5I2.isImmune();
                        }
                        if (setka[5, 2] < 0)
                        {
                            b5I2.isHealthy();
                        }
                        if (setka[5, 3] <= 10 & setka[5, 3] >= 5) // 5,3
                        {
                            b5I3.isInfected();
                        }
                        if (setka[5, 3] <= 4 & setka[5, 3] >= 0)
                        {
                            b5I3.isImmune();
                        }
                        if (setka[5, 3] < 0)
                        {
                            b5I3.isHealthy();
                        }
                        if (setka[5, 4] <= 10 & setka[5, 4] >= 5) // 5,4
                        {
                            b5I4.isInfected();
                        }
                        if (setka[5, 4] <= 4 & setka[5, 4] >= 0)
                        {
                            b5I4.isImmune();
                        }
                        if (setka[5, 4] < 0)
                        {
                            b5I4.isHealthy();
                        }
                        if (setka[5, 5] <= 10 & setka[5, 5] >= 5) // 5,5
                        {
                            b5I5.isInfected();
                        }
                        if (setka[5, 5] <= 4 & setka[5, 5] >= 0)
                        {
                            b5I5.isImmune();
                        }
                        if (setka[5, 5] < 0)
                        {
                            b5I5.isHealthy();
                        }
                        if (setka[5, 6] <= 10 & setka[5, 6] >= 5) // 5,6
                        {
                            b5I6.isInfected();
                        }
                        if (setka[5, 6] <= 4 & setka[5, 6] >= 0)
                        {
                            b5I6.isImmune();
                        }
                        if (setka[5, 6] < 0)
                        {
                            b5I6.isHealthy();
                        }
                        if (setka[5, 7] <= 10 & setka[5, 7] >= 5) // 5,7
                        {
                            b5I7.isInfected();
                        }
                        if (setka[5, 7] <= 4 & setka[5, 7] >= 0)
                        {
                            b5I7.isImmune();
                        }
                        if (setka[5, 7] < 0)
                        {
                            b5I7.isHealthy();
                        }
                        if (setka[5, 8] <= 10 & setka[5, 8] >= 5) // 5,8
                        {
                            b5I8.isInfected();
                        }
                        if (setka[5, 8] <= 4 & setka[5, 8] >= 0)
                        {
                            b5I8.isImmune();
                        }
                        if (setka[5, 8] < 0)
                        {
                            b5I8.isHealthy();
                        }
                        if (setka[5, 9] <= 10 & setka[5, 9] >= 5) // 5,9
                        {
                            b5I9.isInfected();
                        }
                        if (setka[5, 9] <= 4 & setka[5, 9] >= 0)
                        {
                            b5I9.isImmune();
                        }
                        if (setka[5, 9] < 0)
                        {
                            b5I9.isHealthy();
                        }
                        if (setka[5, 10] <= 10 & setka[5, 10] >= 5) // 5,10
                        {
                            b5I10.isInfected();
                        }
                        if (setka[5, 10] <= 4 & setka[5, 10] >= 0)
                        {
                            b5I10.isImmune();
                        }
                        if (setka[5, 10] < 0)
                        {
                            b5I10.isHealthy();
                        }
                        if (setka[6, 0] <= 10 & setka[6, 0] >= 5) // 6,0
                        {
                            b6I0.isInfected();
                        }
                        if (setka[6, 0] <= 4 & setka[6, 0] >= 0)
                        {
                            b6I0.isImmune();
                        }
                        if (setka[6, 0] < 0)
                        {
                            b6I0.isHealthy();
                        }
                        if (setka[6, 1] <= 10 & setka[6, 1] >= 5) // 6,1
                        {
                            b6I1.isInfected();
                        }
                        if (setka[6, 1] <= 4 & setka[6, 1] >= 0)
                        {
                            b6I1.isImmune();
                        }
                        if (setka[6, 1] < 0)
                        {
                            b6I1.isHealthy();
                        }
                        if (setka[6, 2] <= 10 & setka[6, 2] >= 5) // 6,2
                        {
                            b6I2.isInfected();
                        }
                        if (setka[6, 2] <= 4 & setka[6, 2] >= 0)
                        {
                            b6I2.isImmune();
                        }
                        if (setka[6, 2] < 0)
                        {
                            b6I2.isHealthy();
                        }
                        if (setka[6, 3] <= 10 & setka[6, 3] >= 5) // 6,3
                        {
                            b6I3.isInfected();
                        }
                        if (setka[6, 3] <= 4 & setka[6, 3] >= 0)
                        {
                            b6I3.isImmune();
                        }
                        if (setka[6, 3] < 0)
                        {
                            b6I3.isHealthy();
                        }
                        if (setka[6, 4] <= 10 & setka[6, 4] >= 5) // 6,4
                        {
                            b6I4.isInfected();
                        }
                        if (setka[6, 4] <= 4 & setka[6, 4] >= 0)
                        {
                            b6I4.isImmune();
                        }
                        if (setka[6, 4] < 0)
                        {
                            b6I4.isHealthy();
                        }
                        if (setka[6, 5] <= 10 & setka[6, 5] >= 5) // 6,5
                        {
                            b6I5.isInfected();
                        }
                        if (setka[6, 5] <= 4 & setka[6, 5] >= 0)
                        {
                            b6I5.isImmune();
                        }
                        if (setka[6, 5] < 0)
                        {
                            b6I5.isHealthy();
                        }
                        if (setka[6, 6] <= 10 & setka[6, 6] >= 5) // 6,6
                        {
                            b6I6.isInfected();
                        }
                        if (setka[6, 6] <= 4 & setka[6, 6] >= 0)
                        {
                            b6I6.isImmune();
                        }
                        if (setka[6, 6] < 0)
                        {
                            b6I6.isHealthy();
                        }
                        if (setka[6, 7] <= 10 & setka[6, 7] >= 5) // 6,7
                        {
                            b6I7.isInfected();
                        }
                        if (setka[6, 7] <= 4 & setka[6, 7] >= 0)
                        {
                            b6I7.isImmune();
                        }
                        if (setka[6, 7] < 0)
                        {
                            b6I7.isHealthy();
                        }
                        if (setka[6, 8] <= 10 & setka[6, 8] >= 5) // 6,8
                        {
                            b6I8.isInfected();
                        }
                        if (setka[6, 8] <= 4 & setka[6, 8] >= 0)
                        {
                            b6I8.isImmune();
                        }
                        if (setka[6, 8] < 0)
                        {
                            b6I8.isHealthy();
                        }
                        if (setka[6, 9] <= 10 & setka[6, 9] >= 5) // 6,9
                        {
                            b6I9.isInfected();
                        }
                        if (setka[6, 9] <= 4 & setka[6, 9] >= 0)
                        {
                            b6I9.isImmune();
                        }
                        if (setka[6, 9] < 0)
                        {
                            b6I9.isHealthy();
                        }
                        if (setka[6, 10] <= 10 & setka[6, 10] >= 5) // 6,10
                        {
                            b6I10.isInfected();
                        }
                        if (setka[6, 10] <= 4 & setka[6, 10] >= 0)
                        {
                            b6I10.isImmune();
                        }
                        if (setka[6, 10] < 0)
                        {
                            b6I10.isHealthy();
                        }
                        if (setka[7, 0] <= 10 & setka[7, 0] >= 5) // 7,0
                        {
                            b7I0.isInfected();
                        }
                        if (setka[7, 0] <= 4 & setka[7, 0] >= 0)
                        {
                            b7I0.isImmune();
                        }
                        if (setka[7, 0] < 0)
                        {
                            b7I0.isHealthy();
                        }
                        if (setka[7, 1] <= 10 & setka[7, 1] >= 5) // 7,1
                        {
                            b7I1.isInfected();
                        }
                        if (setka[7, 1] <= 4 & setka[7, 1] >= 0)
                        {
                            b7I1.isImmune();
                        }
                        if (setka[7, 1] < 0)
                        {
                            b7I1.isHealthy();
                        }
                        if (setka[7, 2] <= 10 & setka[7, 2] >= 5) // 7,2
                        {
                            b7I2.isInfected();
                        }
                        if (setka[7, 2] <= 4 & setka[7, 2] >= 0)
                        {
                            b7I2.isImmune();
                        }
                        if (setka[7, 2] < 0)
                        {
                            b7I2.isHealthy();
                        }
                        if (setka[7, 3] <= 10 & setka[7, 3] >= 5) // 7,3
                        {
                            b7I3.isInfected();
                        }
                        if (setka[7, 3] <= 4 & setka[7, 3] >= 0)
                        {
                            b7I3.isImmune();
                        }
                        if (setka[7, 3] < 0)
                        {
                            b7I3.isHealthy();
                        }
                        if (setka[7, 3] <= 10 & setka[7, 3] >= 5) // 7,3
                        {
                            b7I3.isInfected();
                        }
                        if (setka[7, 3] <= 4 & setka[7, 3] >= 0)
                        {
                            b7I3.isImmune();
                        }
                        if (setka[7, 3] < 0)
                        {
                            b7I3.isHealthy();
                        }
                        if (setka[7, 4] <= 10 & setka[7, 4] >= 5) // 7,4
                        {
                            b7I4.isInfected();
                        }
                        if (setka[7, 4] <= 4 & setka[7, 4] >= 0)
                        {
                            b7I4.isImmune();
                        }
                        if (setka[7, 4] < 0)
                        {
                            b7I4.isHealthy();
                        }
                        if (setka[7, 5] <= 10 & setka[7, 5] >= 5) // 7,5
                        {
                            b7I5.isInfected();
                        }
                        if (setka[7, 5] <= 4 & setka[7, 5] >= 0)
                        {
                            b7I5.isImmune();
                        }
                        if (setka[7, 5] < 0)
                        {
                            b7I5.isHealthy();
                        }
                        if (setka[7, 6] <= 10 & setka[7, 6] >= 5) // 7,6
                        {
                            b7I6.isInfected();
                        }
                        if (setka[7, 6] <= 4 & setka[7, 6] >= 0)
                        {
                            b7I6.isImmune();
                        }
                        if (setka[7, 6] < 0)
                        {
                            b7I6.isHealthy();
                        }
                        if (setka[7, 7] <= 10 & setka[7, 7] >= 5) // 7,7
                        {
                            b7I7.isInfected();
                        }
                        if (setka[7, 7] <= 4 & setka[7, 7] >= 0)
                        {
                            b7I7.isImmune();
                        }
                        if (setka[7, 7] < 0)
                        {
                            b7I7.isHealthy();
                        }
                        if (setka[7, 8] <= 10 & setka[7, 8] >= 5) // 7,8
                        {
                            b7I8.isInfected();
                        }
                        if (setka[7, 8] <= 4 & setka[7, 8] >= 0)
                        {
                            b7I8.isImmune();
                        }
                        if (setka[7, 8] < 0)
                        {
                            b7I8.isHealthy();
                        }
                        if (setka[7, 9] <= 10 & setka[7, 9] >= 5) // 7,9
                        {
                            b7I9.isInfected();
                        }
                        if (setka[7, 9] <= 4 & setka[7, 9] >= 0)
                        {
                            b7I9.isImmune();
                        }
                        if (setka[7, 9] < 0)
                        {
                            b7I9.isHealthy();
                        }
                        if (setka[7, 10] <= 10 & setka[7, 10] >= 5) // 7,10
                        {
                            b7I10.isInfected();
                        }
                        if (setka[7, 10] <= 4 & setka[7, 10] >= 0)
                        {
                            b7I10.isImmune();
                        }
                        if (setka[7, 10] < 0)
                        {
                            b7I10.isHealthy();
                        }
                        if (setka[8, 0] <= 10 & setka[8, 0] >= 5) // 8,0
                        {
                            b8I0.isInfected();
                        }
                        if (setka[8, 0] <= 4 & setka[8, 0] >= 0)
                        {
                            b8I0.isImmune();
                        }
                        if (setka[8, 0] < 0)
                        {
                            b8I0.isHealthy();
                        }
                        if (setka[8, 1] <= 10 & setka[8, 1] >= 5) // 8,1
                        {
                            b8I1.isInfected();
                        }
                        if (setka[8, 1] <= 4 & setka[8, 1] >= 0)
                        {
                            b8I1.isImmune();
                        }
                        if (setka[8, 1] < 0)
                        {
                            b8I1.isHealthy();
                        }
                        if (setka[8, 2] <= 10 & setka[8, 2] >= 5) // 8,2
                        {
                            b8I2.isInfected();
                        }
                        if (setka[8, 2] <= 4 & setka[8, 2] >= 0)
                        {
                            b8I2.isImmune();
                        }
                        if (setka[8, 2] < 0)
                        {
                            b8I2.isHealthy();
                        }
                        if (setka[8, 3] <= 10 & setka[8, 3] >= 5) // 8,3
                        {
                            b8I3.isInfected();
                        }
                        if (setka[8, 3] <= 4 & setka[8, 3] >= 0)
                        {
                            b8I3.isImmune();
                        }
                        if (setka[8, 3] < 0)
                        {
                            b8I3.isHealthy();
                        }
                        if (setka[8, 4] <= 10 & setka[8, 4] >= 5) // 8,4
                        {
                            b8I4.isInfected();
                        }
                        if (setka[8, 4] <= 4 & setka[8, 4] >= 0)
                        {
                            b8I4.isImmune();
                        }
                        if (setka[8, 4] < 0)
                        {
                            b8I4.isHealthy();
                        }
                        if (setka[8, 5] <= 10 & setka[8, 5] >= 5) // 8,5
                        {
                            b8I5.isInfected();
                        }
                        if (setka[8, 5] <= 4 & setka[8, 5] >= 0)
                        {
                            b8I5.isImmune();
                        }
                        if (setka[8, 5] < 0)
                        {
                            b8I5.isHealthy();
                        }
                        if (setka[8, 6] <= 10 & setka[8, 6] >= 5) // 8,6
                        {
                            b8I6.isInfected();
                        }
                        if (setka[8, 6] <= 4 & setka[8, 6] >= 0)
                        {
                            b8I6.isImmune();
                        }
                        if (setka[8, 6] < 0)
                        {
                            b8I6.isHealthy();
                        }
                        if (setka[8, 7] <= 10 & setka[8, 7] >= 5) // 8,7
                        {
                            b8I7.isInfected();
                        }
                        if (setka[8, 7] <= 4 & setka[8, 7] >= 0)
                        {
                            b8I7.isImmune();
                        }
                        if (setka[8, 7] < 0)
                        {
                            b8I7.isHealthy();
                        }
                        if (setka[8, 8] <= 10 & setka[8, 8] >= 5) // 8,8
                        {
                            b8I8.isInfected();
                        }
                        if (setka[8, 8] <= 4 & setka[8, 8] >= 0)
                        {
                            b8I8.isImmune();
                        }
                        if (setka[8, 8] < 0)
                        {
                            b8I8.isHealthy();
                        }
                        if (setka[8, 9] <= 10 & setka[8, 9] >= 5) // 8,9
                        {
                            b8I9.isInfected();
                        }
                        if (setka[8, 9] <= 4 & setka[8, 9] >= 0)
                        {
                            b8I9.isImmune();
                        }
                        if (setka[8, 9] < 0)
                        {
                            b8I9.isHealthy();
                        }
                        if (setka[8, 10] <= 10 & setka[8, 10] >= 5) // 8,10
                        {
                            b8I10.isInfected();
                        }
                        if (setka[8, 10] <= 4 & setka[8, 10] >= 0)
                        {
                            b8I10.isImmune();
                        }
                        if (setka[8, 10] < 0)
                        {
                            b8I10.isHealthy();
                        }
                        if (setka[9, 0] <= 10 & setka[9, 0] >= 5) // 9,0
                        {
                            b9I0.isInfected();
                        }
                        if (setka[9, 0] <= 4 & setka[9, 0] >= 0)
                        {
                            b9I0.isImmune();
                        }
                        if (setka[9, 0] < 0)
                        {
                            b9I0.isHealthy();
                        }
                        if (setka[9, 1] <= 10 & setka[9, 1] >= 5) // 9,1
                        {
                            b9I1.isInfected();
                        }
                        if (setka[9, 1] <= 4 & setka[9, 1] >= 0)
                        {
                            b9I1.isImmune();
                        }
                        if (setka[9, 1] < 0)
                        {
                            b9I1.isHealthy();
                        }
                        if (setka[9, 2] <= 10 & setka[9, 2] >= 5) // 9,2
                        {
                            b9I2.isInfected();
                        }
                        if (setka[9, 2] <= 4 & setka[9, 2] >= 0)
                        {
                            b9I2.isImmune();
                        }
                        if (setka[9, 2] < 0)
                        {
                            b9I2.isHealthy();
                        }
                        if (setka[9, 3] <= 10 & setka[9, 3] >= 5) // 9,3
                        {
                            b9I3.isInfected();
                        }
                        if (setka[9, 3] <= 4 & setka[9, 3] >= 0)
                        {
                            b9I3.isImmune();
                        }
                        if (setka[9, 3] < 0)
                        {
                            b9I3.isHealthy();
                        }
                        if (setka[9, 4] <= 10 & setka[9, 4] >= 5) // 9,4
                        {
                            b9I4.isInfected();
                        }
                        if (setka[9, 4] <= 4 & setka[9, 4] >= 0)
                        {
                            b9I4.isImmune();
                        }
                        if (setka[9, 4] < 0)
                        {
                            b9I4.isHealthy();
                        }
                        if (setka[9, 5] <= 10 & setka[9, 5] >= 5) // 9,5
                        {
                            b9I5.isInfected();
                        }
                        if (setka[9, 5] <= 4 & setka[9, 5] >= 0)
                        {
                            b9I5.isImmune();
                        }
                        if (setka[9, 5] < 0)
                        {
                            b9I5.isHealthy();
                        }
                        if (setka[9, 6] <= 10 & setka[9, 6] >= 5) // 9,6
                        {
                            b9I6.isInfected();
                        }
                        if (setka[9, 6] <= 4 & setka[9, 6] >= 0)
                        {
                            b9I6.isImmune();
                        }
                        if (setka[9, 6] < 0)
                        {
                            b9I6.isHealthy();
                        }
                        if (setka[9, 7] <= 10 & setka[9, 7] >= 5) // 9,7
                        {
                            b9I7.isInfected();
                        }
                        if (setka[9, 7] <= 4 & setka[9, 7] >= 0)
                        {
                            b9I7.isImmune();
                        }
                        if (setka[9, 7] < 0)
                        {
                            b9I7.isHealthy();
                        }
                        if (setka[9, 8] <= 10 & setka[9, 8] >= 5) // 9,8
                        {
                            b9I8.isInfected();
                        }
                        if (setka[9, 8] <= 4 & setka[9, 8] >= 0)
                        {
                            b9I8.isImmune();
                        }
                        if (setka[9, 8] < 0)
                        {
                            b9I8.isHealthy();
                        }
                        if (setka[9, 9] <= 10 & setka[9, 9] >= 5) // 9,9
                        {
                            b9I9.isInfected();
                        }
                        if (setka[9, 9] <= 4 & setka[9, 9] >= 0)
                        {
                            b9I9.isImmune();
                        }
                        if (setka[9, 9] < 0)
                        {
                            b9I9.isHealthy();
                        }
                        if (setka[9, 10] <= 10 & setka[9, 10] >= 5) // 9,10
                        {
                            b9I10.isInfected();
                        }
                        if (setka[9, 10] <= 4 & setka[9, 10] >= 0)
                        {
                            b9I10.isImmune();
                        }
                        if (setka[9, 10] < 0)
                        {
                            b9I10.isHealthy();
                        }
                        if (setka[10, 0] <= 10 & setka[10, 0] >= 5) // 10,0
                        {
                            b10I0.isInfected();
                        }
                        if (setka[10, 0] <= 4 & setka[10, 0] >= 0)
                        {
                            b10I0.isImmune();
                        }
                        if (setka[10, 0] < 0)
                        {
                            b10I0.isHealthy();
                        }
                        if (setka[10, 1] <= 10 & setka[10, 1] >= 5) // 10,1
                        {
                            b10I1.isInfected();
                        }
                        if (setka[10, 1] <= 4 & setka[10, 1] >= 0)
                        {
                            b10I1.isImmune();
                        }
                        if (setka[10, 1] < 0)
                        {
                            b10I1.isHealthy();
                        }
                        if (setka[10, 2] <= 10 & setka[10, 2] >= 5) // 10,2
                        {
                            b10I2.isInfected();
                        }
                        if (setka[10, 2] <= 4 & setka[10, 2] >= 0)
                        {
                            b10I2.isImmune();
                        }
                        if (setka[10, 2] < 0)
                        {
                            b10I2.isHealthy();
                        }
                        if (setka[10, 3] <= 10 & setka[10, 3] >= 5) // 10,3
                        {
                            b10I3.isInfected();
                        }
                        if (setka[10, 3] <= 4 & setka[10, 3] >= 0)
                        {
                            b10I3.isImmune();
                        }
                        if (setka[10, 3] < 0)
                        {
                            b10I3.isHealthy();
                        }
                        if (setka[10, 4] <= 10 & setka[10, 4] >= 5) // 10,4
                        {
                            b10I4.isInfected();
                        }
                        if (setka[10, 4] <= 4 & setka[10, 4] >= 0)
                        {
                            b10I4.isImmune();
                        }
                        if (setka[10, 4] < 0)
                        {
                            b10I4.isHealthy();
                        }
                        if (setka[10, 5] <= 10 & setka[10, 5] >= 5) // 10,5
                        {
                            b10I5.isInfected();
                        }
                        if (setka[10, 5] <= 4 & setka[10, 5] >= 0)
                        {
                            b10I5.isImmune();
                        }
                        if (setka[10, 5] < 0)
                        {
                            b10I5.isHealthy();
                        }
                        if (setka[10, 6] <= 10 & setka[10, 6] >= 5) // 10,6
                        {
                            b10I6.isInfected();
                        }
                        if (setka[10, 6] <= 4 & setka[10, 6] >= 0)
                        {
                            b10I6.isImmune();
                        }
                        if (setka[10, 6] < 0)
                        {
                            b10I6.isHealthy();
                        }
                        if (setka[10, 7] <= 10 & setka[10, 7] >= 5) // 10,7
                        {
                            b10I7.isInfected();
                        }
                        if (setka[10, 7] <= 4 & setka[10, 7] >= 0)
                        {
                            b10I7.isImmune();
                        }
                        if (setka[10, 7] < 0)
                        {
                            b10I7.isHealthy();
                        }
                        if (setka[10, 8] <= 10 & setka[10, 8] >= 5) // 10,8
                        {
                            b10I8.isInfected();
                        }
                        if (setka[10, 8] <= 4 & setka[10, 8] >= 0)
                        {
                            b10I8.isImmune();
                        }
                        if (setka[10, 8] < 0)
                        {
                            b10I8.isHealthy();
                        }
                        if (setka[10, 9] <= 10 & setka[10, 9] >= 5) // 10,9
                        {
                            b10I9.isInfected();
                        }
                        if (setka[10, 9] <= 4 & setka[10, 9] >= 0)
                        {
                            b10I9.isImmune();
                        }
                        if (setka[10, 9] < 0)
                        {
                            b10I9.isHealthy();
                        }
                        if (setka[10, 10] <= 10 & setka[10, 10] >= 5) // 10,10
                        {
                            b10I10.isInfected();
                        }
                        if (setka[10, 10] <= 4 & setka[10, 10] >= 0)
                        {
                            b10I10.isImmune();
                        }
                        if (setka[10, 10] < 0)
                        {
                            b10I10.isHealthy();
                        }
                    }
                }

            }
            
            System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
            timer1.Tick += new EventHandler(timerTick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();




            
            
                
                    }

        
    }
            }

      
