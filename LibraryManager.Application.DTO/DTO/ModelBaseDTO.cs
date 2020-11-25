using System.Runtime.Serialization;

namespace LibraryManager.Application.DTO.DTO
{
    [DataContract]
    public abstract class ModelBaseDTO
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
