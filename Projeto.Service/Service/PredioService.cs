using AutoMapper;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Dto;
using Projeto.Model.Model;
using Projeto.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Service.Service
{
    public class PredioService : IPredioService
    {
        private readonly IPredioRepository _predioRepository;
        IMapper _mapper;
        public PredioService(IPredioRepository predioRepository, IMapper mapper)
        {
            _predioRepository = predioRepository;
            _mapper = mapper;
        }

        public String SalvarPredio(PredioDto predioDto)
        {
            try
            {
                Predio predio = _mapper.Map<Predio>(predioDto);
                _predioRepository.Salvar(predio);
                return "Salvo com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String DeletarPredio(PredioDto predioDto)
        {
            try
            {
                Predio predio = _mapper.Map<Predio>(predioDto);
                _predioRepository.Deletar(predio);
                return "Predio apagado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String UpdatePredio(PredioDto predioDto)
        {
            try
            {
                Predio predio = _mapper.Map<Predio>(predioDto);
                _predioRepository.Update(predio);
                return "Predio atualizado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public IEnumerable<PredioDto> ConsultarTodos()
        {
            IEnumerable<Predio> predio = _predioRepository.predio;
            return _mapper.Map<PredioDto[]>(predio);
        }
        public PredioDto BusarPorId(int id)
        {
            Predio predio = new Predio();
            predio = _predioRepository.findById(id);
            return _mapper.Map<PredioDto>(predio);
        }
    }
}
