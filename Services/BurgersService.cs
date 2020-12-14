using System;
using System.Collections.Generic;
using latefall2020_burgershack.Models;
using latefall2020_burgershack.Repositories;

namespace latefall2020_burgershack.Services
{
    public class BurgersService
    {
        private readonly BurgersRepository _repo;

        public BurgersService(BurgersRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Burger> Get()
        {
            return _repo.Get();
        }

        public Burger Create(Burger burger)
        {
            return _repo.Create(burger);
        }

        public Burger GetById(int id)
        {
            Burger foundBurger = _repo.GetById(id);
            if (foundBurger == null)
            {
                throw new Exception("There is no burger with that id");
            }
            return foundBurger;
        }

        public string Delete(int id)
        {
            // Burger foundBurger = GetById(id);
            if (_repo.Delete(id))
            {
                return "Great Scuccessss, Delorted.!?";
            }
            throw new Exception("Yeah, no, that didn't work.");
        }


        // NOTE null check for update
        // Burger foundBurger = _repo.GetById(id);
        // updatedBurger.Id = foundBurger.Id
        // updatedBurger.title = updatedBurger.title == null ? foundBurger.title : updatedBurger.title


    }
}