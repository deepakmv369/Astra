using Astra_MK1.Data;
using Astra_MK1.DTO.MasterData;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Microsoft.AspNetCore.Mvc;

namespace Astra_MK1.Controllers.BusinessPortfolio.MasterData
{
    [Route("Astra/[controller]/[action]")]
    [ApiController]
    public class bpMasterDataController: ControllerBase
    {
        private readonly iBPMasterDataRepo _bpMasterDataRepo;

        public bpMasterDataController(iBPMasterDataRepo BPMasterDataRepo)
        {
            _bpMasterDataRepo = BPMasterDataRepo;
        }
//*******************************************************************************************************//
//******************************************* mdActorType ***********************************************// 
        [HttpGet]
        public ActionResult<IEnumerable<mdActorTypeDTORUD>> fetchActorTypes()
        {
            List<mdActorTypeDTORUD> actorTypesDTOR = new List<mdActorTypeDTORUD>();
            IEnumerable<mdActorType> actorTypes = _bpMasterDataRepo.getActorTypes().ToList();
            foreach(var actorType in actorTypes)
            {
                actorTypesDTOR.Add((mdActorTypeDTORUD) actorType);
            }
            if (actorTypesDTOR != null)
            {
            return Ok(actorTypesDTOR);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet]
        // public async Task<ActionResult<IEnumerable<mdActorTypeDTORUD>>> getActorTypesAsync()
        // {
        //     List<mdActorTypeDTORUD> actorTypesDTOR = new List<mdActorTypeDTORUD>();
        //     IEnumerable<mdActorType> actorTypes = await _bpMasterDataRepo.getActorTypesAsync();
        //     foreach(var actorType in actorTypes)
        //     {
        //         actorTypesDTOR.Add((mdActorTypeDTORUD) actorType);
        //     }
        //     if (actorTypesDTOR != null)
        //     {
        //         return Ok(actorTypesDTOR);
        //     }
        //     else
        //     {
        //         return StatusCode(500);
        //     }
        // }

        [HttpGet("{Id}", Name ="fetchActorTypeById")]
        public ActionResult<mdActorTypeDTORUD> fetchActorTypeById(int ID)
        {
            var actorType = _bpMasterDataRepo.getActorTypeById(ID);
            if (actorType != null)
            {
            return Ok((mdActorTypeDTORUD) actorType);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<int> addActorType(mdActorTypeDTOC newActorType)
        {
            try
            {
            int newActorTypeId = _bpMasterDataRepo.createActorType((mdActorType) newActorType);
            return Ok(newActorTypeId);
            }
            catch 
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public ActionResult editActorType(mdActorTypeDTORUD actorType)
        {
            try
            {
            _bpMasterDataRepo.updateActorType((mdActorType) actorType);
            bool saveResult = _bpMasterDataRepo.saveChanges();
            return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        } 
        [HttpPost]
        public ActionResult removeActorType(mdActorTypeDTORUD actorType)
        {
            try
            {
                if (_bpMasterDataRepo.deleteActorType((mdActorType) actorType))
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }

            }
            catch
            {
                return StatusCode(500);
            }

        }
//*******************************************************************************************************//
//****************************************** mdAssetCategory ********************************************// 
       
    }
}