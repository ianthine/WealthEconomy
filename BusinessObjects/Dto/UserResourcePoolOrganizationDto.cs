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
    
    public class UserResourcePoolOrganizationDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ResourcePoolOrganizationId { get; set; }
        public int NumberOfSales { get; set; }
        public decimal QualityRating { get; set; }
        public decimal CustomerSatisfactionRating { get; set; }
        public decimal EmployeeSatisfactionRating { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    	
    	public UserResourcePoolOrganization ToBusinessObject()
    	{
    		return new UserResourcePoolOrganization()
    		{
    			Id = Id, 
    			UserId = UserId, 
    			ResourcePoolOrganizationId = ResourcePoolOrganizationId, 
    			NumberOfSales = NumberOfSales, 
    			QualityRating = QualityRating, 
    			CustomerSatisfactionRating = CustomerSatisfactionRating, 
    			EmployeeSatisfactionRating = EmployeeSatisfactionRating, 
    			CreatedOn = CreatedOn, 
    			ModifiedOn = ModifiedOn, 
    			DeletedOn = DeletedOn
    		};
    	}
    }
}