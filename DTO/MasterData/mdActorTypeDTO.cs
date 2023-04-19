using System.ComponentModel.DataAnnotations;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.DTO.MasterData
{
    public class mdActorTypeDTORUD
    {
        public int mdActorTypeId { get; set; }
        [MaxLength(50)]
        public string? actorType { get; set; }
        public int? parentActorTypeId { get; set; }

        public static explicit operator mdActorTypeDTORUD(mdActorType MdActorType)
        {
            return new mdActorTypeDTORUD
            {
                mdActorTypeId = MdActorType.mdActorTypeId,
                actorType = MdActorType.actorType,
                parentActorTypeId = MdActorType.parentActorTypeId
            };        
        }

        public static explicit operator mdActorType(mdActorTypeDTORUD mdActorTypeDTO)
        {
            return new mdActorType
            {
                mdActorTypeId = mdActorTypeDTO.mdActorTypeId,
                actorType = mdActorTypeDTO.actorType,
                parentActorTypeId = mdActorTypeDTO.parentActorTypeId
            };
        }
    }

    public class mdActorTypeDTOC
    {
        [MaxLength(50)]
        public string? actorType { get; set; }
        public int? parentActorTypeId { get; set; }

        public static explicit operator mdActorType(mdActorTypeDTOC MdActorTypeDTOC)
        {
            return new mdActorType
            {
                actorType = MdActorTypeDTOC.actorType,
                parentActorTypeId = MdActorTypeDTOC.parentActorTypeId
            };
        }

    }
}