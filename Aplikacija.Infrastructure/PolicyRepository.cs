using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Aplikacija.Core;
using System.Text.RegularExpressions;
using Aplikacija.Core.Interfaces;

namespace Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        PolicyAPPcontext context = new PolicyAPPcontext();
        public void Add(Policy obj)
        {
        }

        public void Edit(Policy obj)
        {
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }

        public Policy FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetPolicy()
        {
            throw new NotImplementedException();
        }

        public void Remove(int ID)
        {
            throw new NotImplementedException();
        }

        public PolicyViewModel GetPolicyByID(int id)
        {
            Policy policyDb = context.Policies.FirstOrDefault(x => x.ID == id);
            PolicyViewModel p = new PolicyViewModel();

            p.PolicyID = policyDb.ID;
            p.SumOsig = policyDb.SumOsig;
            p.Premium = policyDb.Premium;
            p.Premiumtotal = policyDb.Premiumtotal;
            p.DDV = policyDb.DDV;
            p.DateSale = DateTime.Now;
            Guid FranshizaID = Guid.Parse(policyDb.Franshiza);
            p.Franshiza = context.Franshizas.FirstOrDefault(x => x.Id == FranshizaID);
            int PackageID = int.Parse(policyDb.Package);
            p.Package = context.Packages.FirstOrDefault(x => x.Id == PackageID);
            return p;
        }
        

        public bool SavePolicy(PolicyViewModel policy, string package, string franshiza, string tipkind, string tipkind1, out string policyID)
        {
            policyID = string.Empty;
            ValidatePolicy(policy);
            #region ConvertPackageFranshTipKind
            int p_package = Convert.ToInt32(package);
            Guid p_fransh = Guid.Parse(franshiza);
            int p_tipkindContractor = Convert.ToInt32(tipkind);
            int p_tipkindInsured = Convert.ToInt32(tipkind1);
            #endregion

            #region ContextFirstOrDefault
            Package p_pckg = context.Packages.FirstOrDefault(x => x.Id == p_package);
            Franshiza p_f = context.Franshizas.FirstOrDefault(x => x.Id == p_fransh);
            Tipkind p_tipkind1 = context.Tipkinds.FirstOrDefault(x => x.Id == p_tipkindContractor);
            Tipkind p_tipkind2 = context.Tipkinds.FirstOrDefault(x => x.Id == p_tipkindInsured);
            #endregion

            #region PolicyModel        
            Policy p = new Policy();
            p.Contractor = new List<Contractor>();
            p.Insurers = new List<Insured>();
            p.Beneficiaries = new List<Beneficiary>();
            p.Vehicles = new List<Vehicle>();

            p.Package = p_pckg.Id.ToString();
            p.Franshiza = p_f.Id.ToString();
            p.Moment = DateTime.Now;
            p.DateSale = DateTime.Now;
            p.FromDate = policy.FromDate;
            p.ToDate = policy.ToDate;
            p.Premium = policy.Premium;
            p.DDV = policy.DDV;
            p.Premiumtotal = policy.Premiumtotal;
            #endregion
            //Dogovarac(toj sto gi dava parite)
            #region ContractorModel
            Contractor c = new Contractor();
            c.Tipkind = p_tipkind1.Id.ToString();
            c.Name = policy.ContractorName;
            c.Surname = policy.ContractorSurname;
            c.EMBG = policy.ContractorEMBG;
            c.Regnumber = policy.ContractorRegnumber;
            c.Phone = policy.ContractorPhone;
            c.Fax = policy.ContractorFax;
            p.Contractor.Add(c);
            #endregion
            //Osigurenik(toj sto e pokrien so polisata)
            #region InsuredModel
            Insured i = new Insured();
            i.Tipkind = p_tipkind2.Id.ToString();
            i.Name = policy.InsuredName;
            i.Surname = policy.InsuredSurname;
            i.EMBG = policy.InsuredEMBG;
            i.Regnumber = policy.InsuredRegnumber;
            i.Phone = policy.InsuredPhone;
            i.Fax = policy.InsuredFax;
            p.Insurers.Add(i);
            #endregion
            //Korisnik na sredstva(toj gi zema parite)
            #region BeneficiaryModel
            Beneficiary b = new Beneficiary();
            b.Name = policy.BeneficiaryName;
            b.Surname = policy.BeneficiarySurname;
            b.EMBG = policy.BeneficiaryEMBG;
            b.Regnumber = policy.BeneficiaryRegnumber;
            b.Phone = policy.BeneficiaryPhone;
            b.Fax = policy.BeneficiaryEMBG;
            p.Beneficiaries.Add(b);
            #endregion
            #region VehicleModel
            Vehicle v = new Vehicle();
            v.TypeVehicle = policy.VehicleTypeVehicle;
            v.Regnumber = policy.VehicleRegnumber;
            v.Chassis = policy.VehicleChassis;
            v.MotorNum = policy.VehicleMotorNum;
            v.Power = policy.VehiclePower;
            v.Capacity = policy.VehicleCapacity;
            v.Color = policy.VehicleColor;
            v.SeetsNum = policy.VehicleSeetsNum;
            p.Vehicles.Add(v);
            #endregion

            //Calculations
            #region Calculations
            decimal CapacityDec =Convert.ToDecimal(v.Capacity);
            p.SumOsig = CapacityDec;
            #endregion
            #region SaveData
            context.Policies.Add(p);
            try
            {
                context.SaveChanges();
                policyID = p.ID.ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            #endregion
        }

        #region GetAllFranshizasPackagesTipKinds
        public List<Franshiza> GetAllFranshizas()
        {
            List<Franshiza> f_list = context.Franshizas.OrderBy(x => x.Id).ToList();
            return f_list;
        }

        public List<Package> GetAllPackages()
        {
            List<Package> p_list = context.Packages.OrderBy(x => x.Id).ToList();
            return p_list;
        }

        public List<Tipkind> GetAllTipkinds()
        {
            List<Tipkind> t_list = context.Tipkinds.OrderBy(x => x.Id).ToList();
            return t_list;
        }
        #endregion

        public void ValidatePolicy(PolicyViewModel policy)
        {
            //Vehicle Validation
            #region VehicleValidation
            if (string.IsNullOrEmpty(policy.VehicleTypeVehicle))
                throw new Exception("VehicleTypeVehicle not found");
            if (string.IsNullOrEmpty(policy.VehicleRegnumber))
                throw new Exception("VehicleRegNumber not found");
            if (string.IsNullOrEmpty(policy.VehicleChassis))
                throw new Exception("VehicleChassis not found");
            if (string.IsNullOrEmpty(policy.VehicleMotorNum))
                throw new Exception("VehicleMotorNum not found");
            if (string.IsNullOrEmpty(policy.VehicleColor))
                throw new Exception("VehicleColor not found");
            if (policy.VehicleSeetsNum<=0 || policy.VehicleSeetsNum>=100)
                throw new Exception("VehicleSeetsNum not found");
            if(policy.VehiclePower<=0)
                throw new Exception("VehiclePower not found");
            #endregion
            //Contractor Validation
            #region ContractorValidation
            if (string.IsNullOrEmpty(policy.ContractorName))
                throw new Exception("ContractorName not found");

            if (string.IsNullOrEmpty(policy.ContractorSurname))
                throw new Exception("ContractorSurname not found");

            if (string.IsNullOrEmpty(policy.ContractorEMBG)) {
                if (string.IsNullOrEmpty(policy.ContractorRegnumber))
                    throw new Exception("ContractorRegnumber not found");
            }

            if (string.IsNullOrEmpty(policy.ContractorRegnumber)) {
                if (string.IsNullOrEmpty(policy.ContractorEMBG))
                    throw new Exception("ContractorEmbg not found");
            }

            if (string.IsNullOrEmpty(policy.ContractorPhone))
                 throw new Exception("ContractorPhone not found");

            if (string.IsNullOrEmpty(policy.ContractorFax))
                throw new Exception("ContractorFax not found");
            #endregion
            //Insured Validation
            #region InsuredValidation
            if (string.IsNullOrEmpty(policy.InsuredName))
                throw new Exception("InsuredName not found");

            if (string.IsNullOrEmpty(policy.InsuredSurname))
                throw new Exception("InsuredSurname not found");

            if (string.IsNullOrEmpty(policy.InsuredEMBG))
            {
                if (string.IsNullOrEmpty(policy.InsuredRegnumber))
                    throw new Exception("ContractorRegnumber not found");
            }

            if (string.IsNullOrEmpty(policy.InsuredRegnumber))
            {
                if (string.IsNullOrEmpty(policy.InsuredEMBG))
                    throw new Exception("ContractorEmbg not found");
            }

            if (string.IsNullOrEmpty(policy.InsuredPhone))
                throw new Exception("InsuredPhone not found");

            if (string.IsNullOrEmpty(policy.InsuredFax))
                throw new Exception("InsuredFax not found");
            #endregion
            //Franshiza Validation
            #region PokritieValidation
            if (policy.FromDate == DateTime.MinValue || policy.FromDate == DateTime.MaxValue)
                throw new Exception("FromDate not found");
            if (policy.ToDate == DateTime.MinValue || policy.ToDate == DateTime.MaxValue)
                throw new Exception("ToDate not found");

            //if(policy.InsuredBirthDate == DateTime.MinValue)
            //    throw new Exception("InsuredBirthDate not found");
            #endregion
        }

    }
}
