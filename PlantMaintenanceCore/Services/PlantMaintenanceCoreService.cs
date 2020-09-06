using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using PlantMaintenanceCore.Extensions;
using PlantMaintenanceCore.Models;
using PlantMaintenanceCore.Models.DataModels;
using PlantMaintenanceCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace PlantMaintenanceCore.Services
{
    public class PlantMaintenanceCoreService
    {
        private readonly PlantMaintenanceCoreDbContext _dbContext;

        public PlantMaintenanceCoreService(PlantMaintenanceCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUpdateTitle(Title item)
        {
            var entity = _dbContext.Titles.Find(item.Id) ?? new Title();
            entity.TitleName = item.TitleName;
            entity.Description = item.Description;
            entity.IsActive = item.IsActive;

            if (entity.Id!=0)
                _dbContext.Titles.Update(entity);
            else
                _dbContext.Titles.Add(entity);

            _dbContext.SaveChanges();
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
    }
}
