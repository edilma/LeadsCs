using webapi.Models;

namespace webapi.Data.Services
{
    public interface ILeadService
    {
        List<Lead> GetLeadList();
        Lead GetLeadById(int LeadId);
        Lead AddLead(Lead lead);
        Lead UpdateLead(Lead lead);
        void DeleteLead(int LeadId);



    }
}
