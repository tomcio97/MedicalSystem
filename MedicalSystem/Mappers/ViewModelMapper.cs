using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MedicalSystem.Core.Dtos;
using MedicalSystem.Database.Entities;
using MedicalSystem.Models;

namespace MedicalSystem.Mappers
{
    public class ViewModelMapper
    {
        private readonly IMapper mapper;

        public ViewModelMapper()
        {
            mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<MedicineDto, MedicineViewModel>().ReverseMap();
                config.CreateMap<PrescriptionDto, PrescriptionViewModel>().ReverseMap();
                config.CreateMap<Doctor, DoctorViewModel>().ReverseMap();

            }).CreateMapper();
        }

        #region medicines map
        public MedicineViewModel Map(MedicineDto medicine)
        {
            return mapper.Map<MedicineViewModel>(medicine);
        }

        public IEnumerable<MedicineViewModel> Map(IEnumerable<MedicineDto> medicines)
        {
            return mapper.Map<IEnumerable<MedicineViewModel>>(medicines);
        }

        public MedicineDto Map(MedicineViewModel medicine)
        {
            return mapper.Map<MedicineDto>(medicine);
        }

        public IEnumerable<MedicineDto> Map(IEnumerable<MedicineViewModel> medicines)
        {
            return mapper.Map<IEnumerable<MedicineDto>>(medicines);
        }
        #endregion

        #region prescriptions map
        public PrescriptionViewModel Map(PrescriptionDto prescription)
        {
            return mapper.Map<PrescriptionViewModel>(prescription);
        }

        public IEnumerable<PrescriptionViewModel> Map(IEnumerable<PrescriptionDto> prescriptions)
        {
            return mapper.Map<IEnumerable<PrescriptionViewModel>>(prescriptions);
        }

        public PrescriptionDto Map(PrescriptionViewModel prescription)
        {
            return mapper.Map<PrescriptionDto>(prescription);
        }

        public IEnumerable<PrescriptionDto> Map(IEnumerable<PrescriptionViewModel> prescriptions)
        {
            return mapper.Map<IEnumerable<PrescriptionDto>>(prescriptions);
        }
        #endregion

        #region doctorss map
        public DoctorViewModel Map(DoctorDto doctor)
        {
            return mapper.Map<DoctorViewModel>(doctor);
        }

        public IEnumerable<DoctorViewModel> Map(IEnumerable<DoctorDto> doctors)
        {
            return mapper.Map<IEnumerable<DoctorViewModel>>(doctors);
        }

        public DoctorDto Map(DoctorViewModel doctor)
        {
            return mapper.Map<DoctorDto>(doctor);
        }

        public IEnumerable<DoctorDto> Map(IEnumerable<DoctorViewModel> doctors)
        {
            return mapper.Map<IEnumerable<DoctorDto>>(doctors);
        }
        #endregion
    }
}
