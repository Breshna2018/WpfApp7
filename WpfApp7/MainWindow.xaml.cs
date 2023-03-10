using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FlowDocument fddisplay=new FlowDocument();
        public MainWindow()
        {
            InitializeComponent();
            rtbname.Document=fddisplay;

            Paragraph pet = new Paragraph();
           // Paragraph pet1=new Paragraph();
             Run ran=new Run("hi all");
            ran.Background=new SolidColorBrush(Colors.DeepPink);
            ran.FontWeight = FontWeights.Bold;
            ran.Foreground = new SolidColorBrush(Colors.Aqua);
            ran.FontSize = 22;
            pet.Background = new SolidColorBrush(Colors.Green);//Color paragraph
            pet.Inlines.Add(ran);
            pet.Inlines.Add("\n");
            pet.Inlines.Add(new Run("what is name"     ));  
            fddisplay.Blocks.Add(pet);
            fddisplay.Background=new SolidColorBrush(Colors.BlueViolet);//color background richtextbox
            rtbname.Background = new SolidColorBrush
                (Color.FromRgb(0,0,0));

            rtbname.Document = fddisplay;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string headerline = textline.Text;
            string body = runboay.Text;
            BlogPost bb= new BlogPost(headerline, body);
            /* Paragraph newparagrap = new Paragraph();

             string headerline = textline.Text;
             string body = runboay.Text;
             Run newrun = runmethod(headerline);
             Run runnewbody=bodymethod(body);

            // Run newrun = new Run(headerline+body);
             newrun.Foreground=new SolidColorBrush(Colors.DeepSkyBlue);
             newrun.FontStyle = FontStyles.Italic;
             Run runnynew = new Run(body);
            runnynew.FontSize = 21;
            // Run runnewbody= new Run(body);
             runnewbody.FontSize = 26;
             Run headerrun = new Run(headerline);
             headerrun.FontStyle= FontStyles.Italic;
             newparagrap.Inlines.Add(newrun);
             newparagrap.Inlines.Add("\n");
             //newpet.Inlines.Add(new);


             newparagrap.Inlines.Add(newrun);
             newparagrap.Inlines.Add("\n");
             newparagrap.Inlines.Add(runnewbody);*/
            fddisplay.Blocks.Add(bb.mothedparagraph());

            displaylistbox();
        }

        public Run runmethod(string headerline)
        {
            Run newrun = new Run(headerline );
            newrun.Foreground = new SolidColorBrush(Colors.DeepSkyBlue);
            newrun.FontStyle = FontStyles.Italic;
            Run runnynew = new Run(headerline);
            runnynew.FontSize = 21;

            return newrun;
        }

        public Run bodymethod(string body)
        {
            Run runnynew = new Run(body);
            runnynew.FontSize = 21;
            Run runnewbody = new Run(body);
            runnewbody.FontSize = 26;
            return runnynew;
        }

        public Paragraph mothedparagraph(string headerline)
        {

           string headerline = textline.Text;
            string body = runboay.Text;
            Run newrun = runmethod(headerline);
            Run runnewbody = bodymethod(body);


            //paragraph newparagrap = new paragraph();
            Paragraph newparagrap = new Paragraph();
            newparagrap.Inlines.Add(newrun);
            newparagrap.Inlines.Add("\n");
            newparagrap.Inlines.Add(runnewbody);
            fddisplay.Blocks.Add(newparagrap);



            return newparagrap;
        }

        public void displaylistbox()
        {
            listshow.Items.Clear();
            foreach (BlogPost item in blogpost)
            {
                listshow.Items.Add(item);   

            }
        }

        public Color three()
        {
            int g=int.Parse(txg.Text);
            int r=int.Parse(txr.Text);
            int b=int.Parse(txb.Text);

            Color three = Color.FromRgb(g,r, b);
        }
       

        
    }
}
