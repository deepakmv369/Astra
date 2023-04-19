using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Microsoft.EntityFrameworkCore;

namespace Astra_MK1.Data
{
    public class bpMasterDataRepo : iBPMasterDataRepo
    {
        private readonly astraDbContext _dbContext;

        public bpMasterDataRepo(astraDbContext dbContext)
        {
            _dbContext = dbContext;
        }

//*******************************************************************************************************//
//******************************************* mdActorType ***********************************************// 
        public int createActorType(mdActorType actorType)
        {
            int newActorTypeId = 0;
            if (actorType != null)
            {
                _dbContext.mdActorTypes?.Add(actorType);
                _dbContext.SaveChanges();
                newActorTypeId = actorType.mdActorTypeId;
            }
            return newActorTypeId;
        }

        public bool deleteActorType(mdActorType actorType)
        {
            _dbContext.mdActorTypes?.Attach(actorType);
            _dbContext.mdActorTypes?.Remove(actorType);
            return saveChanges();
        }

        public mdActorType getActorTypeById(int Id)
        {
            return _dbContext.mdActorTypes.FirstOrDefault(a => a.mdActorTypeId == Id);
        }

        public IEnumerable<mdActorType> getActorTypes()
        {
            return _dbContext.mdActorTypes.ToList();
        }

        async Task<IEnumerable<mdActorType>> iBPMasterDataRepo.getActorTypesAsync()
        {
            return await _dbContext.mdActorTypes.ToListAsync();
        }

        public void updateActorType(mdActorType actorType)
        {
            if (actorType != null)
            {
                _dbContext.mdActorTypes?.Attach(actorType);
                _dbContext.Entry(actorType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }
        //*******************************************************************************************************//
        //****************************************** mdAssetCategory ********************************************// 

        public IEnumerable<mdAssetCategory> getAssetCategories()
        {
            var assetCategoryList = _dbContext.mdAssetCategories?.ToList();
            try
            {
            if (assetCategoryList == null)
            {
                throw new NullReferenceException();
            }
            return assetCategoryList;
            }
            catch (NullReferenceException)
            {
                assetCategoryList = null!;
                return assetCategoryList;
            }

        }

        public async Task<IEnumerable<mdAssetCategory>> getAssetCategoriesAsync()
        {
            var assetCategoryList = await _dbContext.mdAssetCategories.ToListAsync();
            try
            {
                if (assetCategoryList == null)
                {
                    throw new NullReferenceException();
                }
                return assetCategoryList;
            }
            catch
            {
                assetCategoryList = null!;
                return assetCategoryList;
            }
        }

        public mdAssetCategory getAssetCategoryById(int Id)
        {
            var assetCategory = _dbContext.mdAssetCategories?.FirstOrDefault(a => a.mdAssetCategoryId == Id);
            try
            {
                if (assetCategory == null)
                {
                    throw new NullReferenceException();
                }
                return assetCategory;
            }
            catch (NullReferenceException)
            {
                assetCategory = null!;
                return assetCategory;
            }
        }

        public async Task<mdAssetCategory> getAssetCategoryByIdAsync(int Id)
        {
            var assetCategory = await _dbContext.mdAssetCategories.FirstOrDefaultAsync(a => a.mdAssetCategoryId == Id);
            try
            {
                if (assetCategory == null)
                {
                    throw new NullReferenceException();
                }
                return assetCategory;
            }
            catch (NullReferenceException)
            {
                assetCategory = null!;
                return assetCategory;
            }
        }

        int iBPMasterDataRepo.createAssetCategory(mdAssetCategory assetCategory)
        {
            int newAssetCatetoryId = 0;
            if (assetCategory != null)
            {
                _dbContext.mdAssetCategories?.Add(assetCategory);
                _dbContext.SaveChanges();
                newAssetCatetoryId = assetCategory.mdAssetCategoryId;
            }
            return newAssetCatetoryId;
        }

        public async Task<int> createAssetCategoryAsync(mdAssetCategory assetCategory)
        {
            int newAssetCategoryId = 0;
            if (assetCategory != null)
            {
                _dbContext.mdAssetCategories?.AddAsync(assetCategory);
                await _dbContext.SaveChangesAsync();
                newAssetCategoryId = assetCategory.mdAssetCategoryId;
            }
            return newAssetCategoryId;
        }

        public void updateAssetCategory(mdAssetCategory assetCategory)
        {
            if (assetCategory != null)
            {
                _dbContext.mdAssetCategories?.Attach(assetCategory);
                _dbContext.Entry(assetCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public async Task updateAssetCategoryAsync(mdAssetCategory assetCategory)
        {
            if (assetCategory != null)
            {
                _dbContext.mdAssetCategories?.Attach(assetCategory);
                _dbContext.Entry(assetCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                
            }
            
        }

        public bool deleteAssetCategory(mdAssetCategory assetCategory)
        {
            _dbContext.mdAssetCategories?.Attach(assetCategory);
            _dbContext.mdAssetCategories?.Remove(assetCategory);
            return saveChanges();
        }

        public async Task<bool> deleteAssetCategoryAsync(mdAssetCategory assetCategory)
        {
           _dbContext.mdAssetCategories?.Attach(assetCategory);
           _dbContext.mdAssetCategories?.Remove(assetCategory);
           return await saveChangesAsync();
           
        }
        public bool saveChanges()
        {
            return (_dbContext.SaveChanges() > 0);
        }

        public async Task<bool> saveChangesAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
   
    }
}