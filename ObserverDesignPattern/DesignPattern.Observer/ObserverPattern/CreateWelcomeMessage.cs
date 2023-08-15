using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context= new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.welcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi Bültenine Kayıt Olduğunuz için Teşşekür Ederiz, Dergilerimize Web Sitemizden Ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
