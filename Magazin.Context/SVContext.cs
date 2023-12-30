using Svyaznoi.Context.Contracts.Models;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Svyaznoi.Context
{
    public class SVContext : IContext
    {
        private ICollection<Magazin> magazins;
        private ICollection<Client> clients;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;

        public SVContext()
        {
            magazins = new HashSet<Magazin>();
            clients = new HashSet<Client>();
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            Seed();
        }

        public ICollection<Client> Clients => clients;

        public ICollection<Magazin> Magazins => magazins;

        public ICollection<Tovar> Tovars => tovars;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        void IContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "artur@mail.ru",
                Name = "Артур",
                Adres = "Санкт-Петербург, ул. Тореза 47",
                Index = 147318,
                Inn = 1234567812,
                RS = 43434234
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "goloand@mail.ru",
                Name = "Голанд",
                Adres = "Санкт-Петербург, ул. Ленина 28",
                Index = 112334,
                Inn = 1235675,
                RS = 4575674
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Павел",
                Number = 799102950,
                Email = "chekpeck@mail.ru",
                Card = 21312,
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Артур",
                Number = 793202950,
                Email = "pol@mail.ru",
                Card = 21312,
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Андрей",
                Number = 799454950,
                Email = "kukol@mail.ru",
                Card = 21312,
            });
            Magazins.Add(new Magazin
            {
                Id = Guid.NewGuid(),
                Name = "ООО <Автоцентр>",
                Address = "Комендантский 51",
                City = "Санкт-Петербург"
            });
            Magazins.Add(new Magazin
            {
                Id = Guid.NewGuid(),
                Name = "ООО <Автоцентр>",
                Address = "Вонючки 21",
                City = "Санкт-Петербург"
            });
            Magazins.Add(new Magazin
            {
                Id = Guid.NewGuid(),
                Name = "ООО <Автоцентр>",
                Address = "Пыжиков 12",
                City = "Санкт-Петербург"
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Фары",
                Edizmer = "5",
                Value = 25000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Лобовое стекло",
                Edizmer = "87",
                Value = 67000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "ДВС",
                Edizmer = "10",
                Value = 131000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Шины",
                Edizmer = "45",
                Value = 23999
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Диски",
                Edizmer = "35",
                Value = 35000
            });
        }
    }
}
