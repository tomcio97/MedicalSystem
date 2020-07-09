using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MedicalSystem.Core.Dtos;
using MedicalSystem.Database.Entities;

namespace MedicalSystem.Core.Mappers
{
    public class DtoMapper
    {
        private readonly IMapper mapper;

        public DtoMapper()
        {
            mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Medicine, MedicineDto>().ForMember(x => x.PriceInTotal, opt => opt.MapFrom(y => y.Price * y.Amount)).ReverseMap();                                         
                config.CreateMap<Prescription, PrescriptionDto>().ReverseMap();
                config.CreateMap<Doctor, DoctorDto>().ReverseMap();
            }).CreateMapper();
        }

        #region Medicine
        public MedicineDto Map(Medicine medicine)
        {
            return mapper.Map<MedicineDto>(medicine);
        }

        public IQueryable<MedicineDto> Map(IQueryable<Medicine> medicines)
        {
            return mapper.Map<IQueryable<MedicineDto>>(medicines);
        }

        public Medicine Map(MedicineDto medicine)
        {
            return mapper.Map<Medicine>(medicine);
        }

        public IQueryable<Medicine> Map(IQueryable<MedicineDto> medicines)
        {
            return mapper.Map<IQueryable<Medicine>>(medicines);
        }

        #endregion

        #region Prescription

        public PrescriptionDto Map(Prescription prescription)
        {
            return mapper.Map<PrescriptionDto>(prescription);
        }

        public IQueryable<PrescriptionDto> Map(IQueryable<Prescription> prescription)
        {
            return mapper.Map<IQueryable<PrescriptionDto>>(prescription);
        }

        public Prescription Map(PrescriptionDto prescription)
        {
            return mapper.Map<Prescription>(prescription);
        }

        public IQueryable<Prescription> Map(IQueryable<PrescriptionDto> prescription)
        {
            return mapper.Map<IQueryable<Prescription>>(prescription);
        }


        #endregion

        #region Doctor

        public DoctorDto Map(Doctor doctor)
        {
            return mapper.Map<DoctorDto>(doctor);
        }

        public IQueryable<DoctorDto> Map(IQueryable<Doctor> doctor)
        {
            return mapper.Map<IQueryable<DoctorDto>>(doctor);
        }

        public Doctor Map(DoctorDto doctor)
        {
            return mapper.Map<Doctor>(doctor);
        }

        public IQueryable<Doctor> Map(IQueryable<DoctorDto> doctor)
        {
            return mapper.Map<IQueryable<Doctor>>(doctor);
        }

        #endregion
    }
}
