﻿using CatMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CatMicroservice.Manager
{
    public class CatManager
    {
        private readonly CatContext _context;

        public CatManager(CatContext context)
        {
            _context = context;
        }

        public Cat Find(Guid id)
        {
            return _context.Cats.Find(id);
        }

        public IEnumerable<Cat> GetAllByName()
        {
            return _context.Cats.Include(c => c.Customer).AsNoTracking().OrderBy(x => x.CatName).ToList();
        }

        public void Update(Cat cat)
        {
            _context.Cats.Update(cat);
            _context.SaveChanges();
        }

        public IEnumerable<Cat> GetByCatName(string name)
        {
            IList<Cat> result = new List<Cat>();
            var cat = GetAllByName().OrderBy(x => x.CatName).ToList();
            for (int i = 0; i < cat.Count(); i++)
            {
                if (cat[i].CatName.ToString() == name)
                {
                    result.Add(cat[i]);
                }
            }
            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new DataException($"No Cats with the '{name}'.");
            }
        }
        public IEnumerable<Cat> GetCatByTagId(string tagId)
        {
            IList<Cat> result = new List<Cat>();
            var cat = GetAllByName().OrderBy(x => x.TagID).ToList();
            for (int i = 0; i < cat.Count(); i++)
            {
                if (cat[i].TagID.ToString() == tagId)
                {
                    result.Add(cat[i]);
                }
            }
            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new DataException($"No Cats with the '{tagId}'.");
            }
        }

        public IEnumerable<Cat> GetCatByVetName(string vetName)
        {
            IList<Cat> result = new List<Cat>();
            var cat = GetAllByName().OrderBy(x => x.CatVetName).ToList();
            for (int i = 0; i < cat.Count(); i++)
            {
                if (cat[i].CatVetName.ToString() == vetName)
                {
                    result.Add(cat[i]);
                }
            }
            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new DataException($"No Cats with the Vet name '{vetName}'.");
            }
        }
        public IEnumerable<Cat> GetCatOwner(Guid customer)
        {
            IList<Cat> result = new List<Cat>();
            var cat = GetAllByName().OrderBy(x => x.Customer).ToList();
            for (int i = 0; i < cat.Count(); i++)
            {
                if (cat[i].Customer == customer)
                {
                    result.Add(cat[i]);
                }
            }
            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new DataException($"No Cats with the '{customer}'.");
            }
        }

        public void Create(Cat cat)
        {


            if (_context.Cats.Any(x => x.TagID == cat.TagID))
            {
                throw new DataException("Two Cats with the same Tag Id can't exsist. Please Double check details and try again");

            }
            else if (DateTime.Now < cat.DateOfLastVac)
            {
                throw new DataException("The Cats Last Vacination date cant be in the future");

            }
            else if (_context.Cats.Any(x => x.ID == cat.ID && x.CatName == cat.CatName))
            {
                throw new DataException("A cat with this Id and Name already exsists");

            }
            else
            {

                _context.Cats.Add(cat);
                _context.SaveChanges();
            }

        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new DataException("Cat Id provided doesnt exsist");
            }
            else
            {
                _context.Cats.Remove(_context.Cats.Find(id));
                _context.SaveChanges();
            }
        }

        public bool Exists(Guid id)
        {
            return _context.Cats.Any(x => x.ID == id);
        }
    }
}
