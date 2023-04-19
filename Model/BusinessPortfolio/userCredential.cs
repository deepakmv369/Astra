using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("userCredentials", Schema = "Portfolio")]
    public class userCredential
    {
        [Key]
        public long userCredentialId { get; set; }
        [Required]
        public bool isIntegratedLogin { get; set; } = false;
        [Required]
        public byte[]? passwordSalt { get; set; }
        [Required]
        public byte[]? passwordHash { get; set; }
        public DateTime? passwordExpiryDate { get; set; }
        public DateTime? createdOn { get; set; }
        public byte[]? securityAnswer { get; set; } //Should be encrypted
        public int? securityQuestionId { get; set; }
        public mdSecurityQuestion? securityQuestion { get; set; }
        
    }
}