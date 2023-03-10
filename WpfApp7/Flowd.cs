using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.TextFormatting;
using System.Windows.Media;
using System.Windows;

namespace WpfApp7
{
    internal class Flowd
    {
        string _headerline;
        string _body;

        Color _three;
        DateTime _timestam;

        public Flowd(string headerline, string body)
        {
            _headerline = headerline;
            _body = body;
            _timestam= DateTime.Now;
        }

        public string Headerline { get => _headerline; set => _headerline = value; }
        public string Body { get => _body; set => _body = value; }
    }
    public Run runmethod(string headerline)
    {
        Run newrun = new Run(headerline);
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

    public override string ToString()
    {
        return _headerline;
    }


}
}


