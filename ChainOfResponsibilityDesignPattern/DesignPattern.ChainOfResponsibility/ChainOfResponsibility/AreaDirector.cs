using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
           Context context  = new Context();
            if (req.Amount <= 400000)
            {

                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmplopyeeName = "Bölge Müdürü - Arda İlhan";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Edilen Tutar Ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmplopyeeName = "Bölge Müdürü - Arda İlhan";
                customerProcess.Description = "Para Çekme Tutarı Şube Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Müşteri Günlük Maksimum Çekebileceği Tutar 400.000 tl Olup Daha Fazlası İçin Birden Fazla Gün Şubeye Gelmesi Gereklidir ...";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
