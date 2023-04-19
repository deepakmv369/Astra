using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Data
{
    public interface iBPMasterDataRepo
    {
        public bool saveChanges();
        public Task<bool>saveChangesAsync();
        
        
        //*******************************************************************************************************//
        //******************************************** mdActorType **********************************************// 
        public IEnumerable<mdActorType> getActorTypes();
        public Task<IEnumerable<mdActorType>> getActorTypesAsync();
        public mdActorType getActorTypeById(int Id);
        public int createActorType(mdActorType actorType);
        public void updateActorType(mdActorType actorType);
        public bool deleteActorType(mdActorType actorType);
        //*******************************************************************************************************//
        //****************************************** mdAssetCategory ********************************************// 
        public IEnumerable<mdAssetCategory> getAssetCategories();
        public Task<IEnumerable<mdAssetCategory>> getAssetCategoriesAsync();
        public mdAssetCategory getAssetCategoryById(int Id);
        public Task<mdAssetCategory> getAssetCategoryByIdAsync(int Id);
        public int createAssetCategory(mdAssetCategory assetCategory);
        public Task<int> createAssetCategoryAsync(mdAssetCategory assetCategory);
        public void updateAssetCategory(mdAssetCategory assetCategory);
        public Task updateAssetCategoryAsync(mdAssetCategory assetCategory);
        public bool deleteAssetCategory(mdAssetCategory assetCategory);
        public Task<bool> deleteAssetCategoryAsync(mdAssetCategory assetCategory);

    }
}