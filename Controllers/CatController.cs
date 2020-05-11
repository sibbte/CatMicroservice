using CatMicroservice.Enum;
using CatMicroservice.Manager;
using CatMicroservice.Models;
using CatMicroservice.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CatMicroservice.Controllers
{
    public class CatController : ControllerBase
    {
        private readonly CatManager catManager;
        private readonly CatContext _context;
        private readonly CatValidator validator = new CatValidator();

        public CatController(CatContext context)
        {
            _context = context;
            catManager = new CatManager(_context);

        }

        //GET: Api/Cat/GetAll
        [HttpGet]
        [Route("Api/Cat/GetAll")]
        public IEnumerable<Cat> GetCatList()
        {
            System.Console.WriteLine("Api/Cat/GetAll");
            return catManager.GetAllByName().ToList();
        }

        [HttpGet]
        [Route("Api/Cat/GetByCustomerId")]
        public IEnumerable<Cat> GetByCustomerId(Guid customer)
        {
            if (customer != null)
            {
                return catManager.GetCatOwner(customer).ToList();
            }
            else
            {
                throw new DataException($"Cant search for '{customer}'.");
            }
        }

        //GET: Api/Cat/GetByName
        [HttpGet]
        [Route("Api/Cat/GetByName")]
        public IEnumerable<Cat> GetByName(string name)
        {
            if (name.Trim() != null)
            {
                return catManager.GetByCatName(name.Trim()).ToList();
            }
            else
            {
                throw new DataException($"Cant search for '{name}'.");
            }
        }

        //GET: Api/Cat/GetByCatTagId
        [HttpGet]
        [Route("Api/Cat/GetByTagId")]
        public IEnumerable<Cat> GetByTagId(string tagId)
        {
            if (tagId.Trim() != null)
            {
                return catManager.GetCatByTagId(tagId.Trim()).ToList();
            }
            else
            {
                throw new DataException($"Cant search for '{tagId}'.");
            }
        }

        // POST: FuelType/Create
        [HttpPost]
        [Route("Api/Cat/Create")]
        public ActionResult Create(string TagID, bool Vaccination, DateTime DateOfLastVac, MealType MealType, string CatName, string CatLitter, string CatCharacter, string CatVetName,
            string CatVetAddress1, string CatVetAddress2, string CatVetPostCode, string CatVetCity, string CatVetPhoneNo, string CatMedicalCondition, Guid owner, string user)
        {
            Cat cat = new Cat()
            {
                TagID = TagID.Trim(),
                Vaccination = Vaccination,
                DateOfLastVac = DateOfLastVac,
                MealType = MealType,
                CatName = CatName.Trim(),
                CatLitter = CatLitter.Trim(),
                CatCharacter = CatCharacter.Trim(),
                CatVetName = CatVetName.Trim(),
                CatVetAddress1 = CatVetAddress1.Trim(),
                CatVetAddress2 = CatVetAddress2.Trim(),
                CatVetPostCode = CatVetPostCode.Trim(),
                CatVetCity = CatVetCity.Trim(),
                CatVetPhoneNo = CatVetPhoneNo.Trim(),
                CatMedicalCondition = null,
                Customer = owner,
                UserId = user
            };
            ValidationResult result = validator.Validate(cat);
            if (!result.IsValid)
            {
                validator.ValidateAndThrow(cat);
            }
            // else if (ModelState.IsValid)
            // {
            catManager.Create(cat);
            //  }

            return Ok(cat);
        }
        // POST: FuelType/Edit/5
        [HttpPost]
        [Route("Api/Cat/Edit")]
        public ActionResult Edit(Guid search, string TagID, bool Vaccination, DateTime DateOfLastVac, MealType MealType, string CatName, string CatLitter, string CatCharacter, string CatVetName,
             string CatVetAddress1, string CatVetAddress2, string CatVetPostCode, string CatVetCity, string CatVetPhoneNo, string CatMedicalCondition, Guid owner, string user)
        {
            Cat cat = new Cat()
            {
                TagID = TagID.Trim(),
                Vaccination = Vaccination,
                DateOfLastVac = DateOfLastVac,
                MealType = MealType,
                CatName = CatName.Trim(),
                CatLitter = CatLitter.Trim(),
                CatCharacter = CatCharacter.Trim(),
                CatVetName = CatVetName.Trim(),
                CatVetAddress1 = CatVetAddress1.Trim(),
                CatVetAddress2 = CatVetAddress2.Trim(),
                CatVetPostCode = CatVetPostCode.Trim(),
                CatVetCity = CatVetCity.Trim(),
                CatVetPhoneNo = CatVetPhoneNo.Trim(),
                CatMedicalCondition = null,
                Customer = owner,
                UserId = user
            };
            ValidationResult result = validator.Validate(cat);
            ;
            if (catManager.Find(search) == null)
            {
                throw new DataException("No Customer with that ID was found");
            }
            else if (!result.IsValid)
            {
                validator.ValidateAndThrow(cat);
            }
            else if (ModelState.IsValid)
            {
                catManager.Update(cat);
            }

            return Ok(cat);
        }

        [HttpPost]
        [Route("Api/Cat/Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            catManager.Delete(id);
            return Ok();
        }
    }
}
