//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects.Dto
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class ResourcePoolIndexDto
    {
        public ResourcePoolIndexDto()
        {
        }

        public ResourcePoolIndexDto(ResourcePoolIndex resourcePoolIndex)
        {
            this.Id = resourcePoolIndex.Id;
            this.ResourcePoolId = resourcePoolIndex.ResourcePoolId;
            this.Name = resourcePoolIndex.Name;
            this.ResourcePoolIndexType = resourcePoolIndex.ResourcePoolIndexType;
            this.ElementId = resourcePoolIndex.ElementId;
            this.CreatedOn = resourcePoolIndex.CreatedOn;
            this.ModifiedOn = resourcePoolIndex.ModifiedOn;
            this.DeletedOn = resourcePoolIndex.DeletedOn;
            this.RowVersion = resourcePoolIndex.RowVersion;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public int ResourcePoolId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte ResourcePoolIndexType { get; set; }

        public Nullable<int> ElementId { get; set; }

        [Required]
        public System.DateTime CreatedOn { get; set; }

        [Required]
        public System.DateTime ModifiedOn { get; set; }

        public Nullable<System.DateTime> DeletedOn { get; set; }

        [Required]
        public byte[] RowVersion { get; set; }

        public ResourcePoolIndex ToBusinessObject()
        {
            return new ResourcePoolIndex()
            {
                Id = Id,
                ResourcePoolId = ResourcePoolId,
                Name = Name,
                ResourcePoolIndexType = ResourcePoolIndexType,
                ElementId = ElementId,
                CreatedOn = CreatedOn,
                ModifiedOn = ModifiedOn,
                DeletedOn = DeletedOn,
                RowVersion = RowVersion
            };
        }
    }
}
