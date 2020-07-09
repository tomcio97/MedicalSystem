using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalSystem.Core.Dtos;
using MedicalSystem.Core.Mappers;
using MedicalSystem.Database.Entities;
using MedicalSystem.Database.Interfaces;

namespace MedicalSystem.Core
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IPrescriptionRepository prescriptionRepository;
        private readonly IMedicineRepository medicineRepository;
        private readonly DtoMapper mapper;

        public DoctorManager(IDoctorRepository doctorRepository, IPrescriptionRepository prescriptionRepository, IMedicineRepository medicineRepository, DtoMapper mapper)
        {
            this.doctorRepository = doctorRepository;
            this.prescriptionRepository = prescriptionRepository;
            this.medicineRepository = medicineRepository;
            this.mapper = mapper;
        }

        public IEnumerable<DoctorDto> GetAllDoctors(string filterString)
        {
            var doctorEntities = doctorRepository.GetDoctors();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities.Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString));
            }

            return mapper.Map(doctorEntities);
        }

        public IEnumerable<PrescriptionDto> GetAllPrescriptionsForADoctor(int doctorId, string filterString)
        {
            var prescriptionEntities = prescriptionRepository.GetPrescriptions().Where(x => x.DoctorId == doctorId);

            if (!string.IsNullOrEmpty(filterString))
            {
                prescriptionEntities = prescriptionEntities.Where(x => x.Name.Contains(filterString));
            }

            return mapper.Map(prescriptionEntities);
        }

        public IEnumerable<MedicineDto> GetAllMedicinesForAPrescription(int prescriptionId, string filterString)
        {
            var medicineEntities = medicineRepository.GetMedicines().Where(x => x.PrescriptionId == prescriptionId);

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities.Where(x => x.Name.Contains(filterString) || x.CompanyName.Contains(filterString));
            }

            return mapper.Map(medicineEntities);
        }

        public bool AddDoctor(DoctorDto doctor)
        {
            var entity = mapper.Map(doctor);

            return doctorRepository.Add(entity);
        }

        public bool AddPrescription(int doctorId, PrescriptionDto prescription)
        {
            var entity = mapper.Map(prescription);

            entity.DoctorId = doctorId;

            return prescriptionRepository.Add(entity);
        }

        public bool AddMedicine(int prescriptionId, MedicineDto medicine)
        {
            var entity = mapper.Map(medicine);

            entity.PrescriptionId = prescriptionId;

            return medicineRepository.Add(entity);
        }

        public bool DeleteDoctor(DoctorDto doctor)
        {
            var entity = mapper.Map(doctor);

            return doctorRepository.Delete(entity);
        }

        public bool DeletePrescription(PrescriptionDto prescription)
        {
            var entity = mapper.Map(prescription);

            return prescriptionRepository.Delete(entity);
        }

        public bool DeleteMedicine(MedicineDto medicine)
        {
            var entity = mapper.Map(medicine);

            return medicineRepository.Delete(entity);
        }
    }
}
