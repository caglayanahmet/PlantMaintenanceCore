using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using PlantMaintenanceCore.Extensions;
using PlantMaintenanceCore.Models;
using PlantMaintenanceCore.Models.DataModels;
using PlantMaintenanceCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;


namespace PlantMaintenanceCore.Services
{
    public class PlantMaintenanceCoreService
    {
        private readonly PlantMaintenanceCoreDbContext _dbContext;

        public PlantMaintenanceCoreService(PlantMaintenanceCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TitleViewModel> GetTitleItems()
        {
            var result = _dbContext.Titles.Select(x => new TitleViewModel()
            {
                Id = x.Id,
                TitleName = x.TitleName,
                Description = x.Description,
                IsActive = x.IsActive
            });
            return result;
        }

        public IEnumerable<UrgencyViewModel> GetUrgencyItems()
        {
            var result = _dbContext.Urgencies.Select(x => new UrgencyViewModel()
            {
                Id = x.Id,
                UrgencyLevel = x.UrgencyLevel,
                Description = x.Description,
                IsActive = x.IsActive
            });
            return result;
        }

        public IEnumerable<RoleViewModel> GetRoleItems()
        {
            var result = _dbContext.Roles.Select(x => new RoleViewModel()
            {
                Id = x.Id,
                RoleName = x.RoleName,
                Description = x.Description,
                IsActive = x.IsActive
            });
            return result;
        }

        public IEnumerable<PlantViewModel> GetPlantItems()
        {
            var result = _dbContext.Plants.Select(x=>new PlantViewModel()
            {
                Id =x.Id,
                PlantName = x.PlantName,
                IsActive = x.IsActive
            });
            return result;
        }

        public IEnumerable<DisplayPersonnelViewModelItem> GetPersonnelItems()
        {
            var result = from personnel in _dbContext.Personnels
                join role in _dbContext.Roles on personnel.RoleId equals role.Id
                join title in _dbContext.Titles on personnel.TitleId equals title.Id
                select new {personnel, title, role};


            return result.ToList().Select(x => new DisplayPersonnelViewModelItem
            {
                Id = x.personnel.Id,
                FirstName = x.personnel.FirstName,
                LastName = x.personnel.LastName,
                Role = x.role.RoleName,
                Title = x.title.TitleName,
                Performance = x.personnel.Performance,
                IsActive = x.personnel.IsActive,
                DateOfBirth = x.personnel.DateOfBirth
            });
        }

        public TitleViewModel GetTitleItem(int id)
        {
            var result = _dbContext.Titles.Find(id);
            var item = new TitleViewModel()
            {
                Id = result.Id,
                TitleName = result.TitleName,
                Description = result.Description,
                IsActive = result.IsActive
            };
            return item;
        }

        public UrgencyViewModel GetUrgencyItem(int id)
        {
            var result = _dbContext.Urgencies.Find(id);
            var item = new UrgencyViewModel()
            {
                Id= result.Id,
                UrgencyLevel = result.UrgencyLevel,
                Description = result.Description,
                IsActive = result.IsActive
            };
            return item;
        }

        public RoleViewModel GetRoleItem(int id)
        {
            var result = _dbContext.Roles.Find(id);
            var item = new RoleViewModel
            {
                Id = result.Id,
                RoleName = result.RoleName,
                Description = result.Description,
                IsActive = result.IsActive
            };
            return item;
        }

        public PlantViewModel GetPlantItem(int id)
        {
            var result = _dbContext.Plants.Find(id);
            var item = new PlantViewModel
            {
                Id = result.Id,
                PlantName = result.PlantName,
                IsActive = result.IsActive
            };
            return item;
        }

        public PersonnelViewModel GetPersonnelItem(int id)
        {
            var result = _dbContext.Personnels.Find(id);
            var item = new PersonnelViewModel()
            {
                Id=result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                DateOfBirth = result.DateOfBirth,
                Title = result.TitleId,
                Role = result.RoleId,
                Performance = result.Performance,
                IsActive = result.IsActive
            };
            return item;
        }

        public void AddUpdateTitle(TitleViewModel item)
        {
            var entity = _dbContext.Titles.Find(item.Id) ?? new Title();
            entity.TitleName = item.TitleName;
            entity.Description = item.Description;
            entity.IsActive = item.IsActive;

            if (entity.Id != 0)
                _dbContext.Titles.Update(entity);
            else
                _dbContext.Titles.Add(entity);

            _dbContext.SaveChanges();
        }

        public void AddUpdateUrgency(UrgencyViewModel item)
        {
            var entity = _dbContext.Urgencies.Find(item.Id) ?? new Urgency();
            entity.UrgencyLevel = item.UrgencyLevel;
            entity.Description = item.Description;
            entity.IsActive = item.IsActive;

            if (entity.Id != 0)
                _dbContext.Urgencies.Update(entity);
            else
                _dbContext.Urgencies.Add(entity);

            _dbContext.SaveChanges();
        }

        public void AddUpdateRole(RoleViewModel item)
        {
            var entity = _dbContext.Roles.Find(item.Id) ?? new Role();
            entity.RoleName = item.RoleName;
            entity.Description = item.Description;
            entity.IsActive = item.IsActive;

            if (entity.Id != 0)
                _dbContext.Roles.Update(entity);
            else
                _dbContext.Roles.Add(entity);

            _dbContext.SaveChanges();
        }

        public void AddUpdatePlant(PlantViewModel item)
        {
            var entity = _dbContext.Plants.Find(item.Id) ?? new Plant();
            entity.PlantName = item.PlantName;
            entity.IsActive = item.IsActive;

            if (entity.Id != 0)
                _dbContext.Plants.Update(entity);
            else
                _dbContext.Plants.Add(entity);

            _dbContext.SaveChanges();
        }

        public void AddUpdatePersonnel(PersonnelViewModel item)
        {
            var entity = _dbContext.Personnels.Find(item.Id) ?? new Personnel();
            entity.FirstName = item.FirstName;
            entity.LastName = item.LastName;
            entity.DateOfBirth = item.DateOfBirth;
            entity.Performance = item.Performance;
            entity.TitleId = item.Title;
            entity.RoleId = item.Role;
            entity.IsActive = item.IsActive;

            if (entity.Id != 0)
                _dbContext.Personnels.Update(entity);
            else
                _dbContext.Personnels.Add(entity);

            _dbContext.SaveChanges();
        }
    }
}
