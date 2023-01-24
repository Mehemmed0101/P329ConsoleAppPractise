using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services.Contracts;

namespace P329ConsoleAppPractise.Services
{
    internal class DepartmentManager : ICrudService, IPrintService
    {
        private Department[] _departments = new Department[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 9)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 10 kafedra elave etmek olar");

                return;
            }

            _departments[_currentIndex++] = (Department)entity;
            Console.WriteLine("Kafedra ugurla elave edildi!");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
