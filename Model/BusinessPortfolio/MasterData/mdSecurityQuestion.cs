using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdSecurityQuestions", Schema = "PortfolioMaster")]
    public class mdSecurityQuestion
    {
        [Key]
        public int mdSecurityQuestionId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? securityQuestion { get; set; }
        public ICollection<userCredential>? _userCredentials { get; set; }


    }
}