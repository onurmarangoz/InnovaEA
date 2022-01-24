using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
           // Bir interface'den gelen tüm fonksiyonlar o nesnede kullanılmalıdır. Her fonksiyon bir interface'e bağlı olmak zorunda DEĞİLDİR!   

        }


    }

    public interface IReport
    {
        string Title { get; set; }
        object Source { get; set; }
       

      

       
    }

    public interface IExcelReport : IReport
    {
        int SheetsCount { get; set; }
        void GeneratePie() { }
    }

    public interface IHtmlReport : IReport
    {
        string StyleSheet { get; set; }
    }

    public interface IPDFReport : IReport
    {
        public int PageSize { get; set; }
    }

    public class ExcelReport : IExcelReport
    {
        public int SheetsCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Source { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


}
