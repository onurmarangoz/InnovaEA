using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Büyük varlıklar küçüklere değil küçük varlıklar büyüklere dependent olmalı.
             *     Elektrik sistemi                        lamba
             *     
             */
            MailSender mailSender = new MailSender();
            Report report = new Report(mailSender);

            report.Sender = new SlackSender();

            
            report.Send();

        }
    }

    public class Report
    {
        private readonly ISender sender;

        public ISender Sender { get; set; }
        public Report(ISender mailSender)
        {
            this.sender = mailSender;
        }
        public void Send()
        {
            //sender.Attach(this);
            sender.Send();
        }
    }

    //public class ReportSenderComponent
    //{
    //    private ISender sender;
    //    private Report report;

    //    public ReportSenderComponent(ISender sender, Report report)
    //    {
    //        this.sender = sender;
    //        this.report = report;
    //    }

    //    public void Send()
    //    {
    //        sender.Send();
    //    }
    //}

    public interface ISender
    {
        void Send();
        
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("send with email");
        }
    }
    public class SlackSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("send with slack");
        }
    }


}
