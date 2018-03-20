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
                                    join data_user in _db.users
                                    on data.CreatedBy equals data_user.id
                                    select new InterestRate
                                    {
                                        IdInterestRate = data.id,
                                        NameInterestRate = data.Name,
                                        CreatedAtInterestRate = data.CreatedAt,
                                        UpdatedAtInterestRate = data.UpdatedAt,
                                        NoteInterestRate = data.Note,
                                        StatusInterestRate = data.Status,

                                        IdHistory = data_history.id,
                                        StartDateHistory = data_history.StartDate,
                                        Percents = data_history.Percents,
                                        NoteHistory = data_history.Note,
                                        StatusHistory = data_history.Status,
                                        CreateAtHisgory = data_history.CreatedAt,
                                        UpdatedAtHistory = data.UpdatedAt,
                                        CreatedBy = data_user.FullName
                                    }).AsEnumerable().ToList();
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
                                select new InterestRate
                                {
                                    IdInterestRate = data.id,
                                    NameInterestRate = data.Name,
                                    CreatedAtInterestRate = data.CreatedAt,
                                    UpdatedAtInterestRate = data.UpdatedAt,
                                    NoteInterestRate = data.Note,
                                    StatusInterestRate = data.Status,

                                    IdHistory = data_history.id,
                                    StartDateHistory = data_history.StartDate,
                                    Percents = data_history.Percents,
                                    NoteHistory = data_history.Note,
                                    StatusHistory = data_history.Status,
                                    CreateAtHisgory = data_history.CreatedAt,
                                    UpdatedAtHistory = data.UpdatedAt,
                                }).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return InterestRate;
        }

        public void changeStatusHistoryInterest()
        {
            (from p in _db.historyInterestRates
             select p).ToList().ForEach(x => x.Status = false);
        }

        public bool Add_and_Edit_HistoryInterest(historyInterestRate historyInterest, int action_status, user user)
        {
            bool check = false;
            try
            {
                historyInterest.CreatedBy = user.id;
                historyInterest.UpdatedBy = user.id;
                historyInterest.InterestRateId = 1;
                historyInterest.Status = true;
                historyInterest.CreatedAt = DateTime.Now;
                historyInterest.UpdatedAt = DateTime.Now;
                changeStatusHistoryInterest();
                _db.historyInterestRates.Add(historyInterest);
                _db.SaveChanges();
                check = true;
            }
            catch (Exception)
            {
                return check;
            }
            return check;
        }
    }
}
