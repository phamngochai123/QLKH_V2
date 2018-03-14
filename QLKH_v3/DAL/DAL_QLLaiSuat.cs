using QLKH_v3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_QLLaiSuat
    {
        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();

        public List<InterestRate> Get_List_InterestRate()
        {
            List<InterestRate> lst_InterestRate = new List<InterestRate>();
            try
            {
                lst_InterestRate = (from data in _db.interestRates 
                                    join data_history in _db.historyInterestRates
                                    on data.id equals data_history.InterestRateId
                                    where (data.Status == true && data_history.Status ==true) 
                                    select new InterestRate {
                                        IdInterestRate = data.id,
                                        NameInterestRate = data.Name,
                                        CreatedAtInterestRate = data.CreatedAt,
                                        UpdatedAtInterestRate = data.UpdatedAt,
                                        NoteInterestRate = data.Note,
                                        StatusInterestRate = data.Status,

                                        IdHistory = data_history.id,
                                        StartDateHistory = data_history.StartDate,
                                        EndDateHistory = data_history.EndDate,
                                        Percents = data_history.Percents,
                                        NoteHistory = data_history.Note,
                                        StatusHistory = data_history.Status,
                                        CreateAtHisgory = data_history.CreatedAt,
                                        UpdatedAtHistory = data.UpdatedAt,
                                    } ).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_InterestRate;
        }
        public InterestRate Get_InterestRate(int id_interest)
        {
            InterestRate InterestRate = new InterestRate();
            try
            {
                InterestRate = (from data in _db.interestRates 
                                    join data_history in _db.historyInterestRates
                                    on data.id equals data_history.InterestRateId
                                where (data.Status == true && data_history.Status == true) 
                                    select new InterestRate {
                                        IdInterestRate = data.id,
                                        NameInterestRate = data.Name,
                                        CreatedAtInterestRate = data.CreatedAt,
                                        UpdatedAtInterestRate = data.UpdatedAt,
                                        NoteInterestRate = data.Note,
                                        StatusInterestRate = data.Status,

                                        IdHistory = data_history.id,
                                        StartDateHistory = data_history.StartDate,
                                        EndDateHistory = data_history.EndDate,
                                        Percents = data_history.Percents,
                                        NoteHistory = data_history.Note,
                                        StatusHistory = data_history.Status,
                                        CreateAtHisgory = data_history.CreatedAt,
                                        UpdatedAtHistory = data.UpdatedAt,
                                    } ).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return InterestRate;
        }
    }
}
