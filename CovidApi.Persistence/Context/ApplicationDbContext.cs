using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidApi.Domain.ArticleModel;
using CovidApi.Domain.ChatModel;
using CovidApi.Domain.HospitalModel;
using CovidApi.Domain.SilderModel;
using CovidApi.Domain.VaccineModel;
using CovidApi.Domain.VaccinrCenterModel;
using Microsoft.EntityFrameworkCore;

namespace CovidApi.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        #region SilderModel
        public DbSet<SilderModel> silderModels { get; set; }
        #endregion
        #region VaccinrCenter
        public DbSet<VaccinrCenter> vaccinrCenters { get; set; }
        #endregion
        #region Article
        public DbSet<Article> articles { get; set; }
        #endregion
        #region Chat
        public DbSet<Chat> chats { get; set; }
        #endregion
        #region Vaccine
        public DbSet<Vaccine> vaccines { get; set; }
        #endregion
        #region Hospital
        public DbSet<Hospital> Hospitals { get; set; }
        #endregion
    }
}
