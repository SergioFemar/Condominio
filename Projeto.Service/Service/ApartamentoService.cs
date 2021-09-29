using AutoMapper;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Dto;
using Projeto.Model.Model;
using Projeto.Service.Interface;
using System;
using System.Collections.Generic;

namespace Projeto.Service.Service
{
    public class ApartamentoService : IApartamentoService
    {
        private readonly IApartamentoRepository _apartamentoRepository;
        IMapper _mapper;
        public ApartamentoService(IApartamentoRepository apartamentoRepository, IMapper mapper)
        {
            _apartamentoRepository = apartamentoRepository;
            _mapper = mapper;
        }

        public String SalvarApartamento(ApartamentoDto apartamentoDto)
        {
            try
            {
                Apartamento apartamento = _mapper.Map<Apartamento>(apartamentoDto);
                _apartamentoRepository.Salvar(apartamento);
                return "Salvo com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String DeletarApartamento(ApartamentoDto apartamentoDto)
        {
            try
            {
                Apartamento apartamento = _mapper.Map<Apartamento>(apartamentoDto);
                _apartamentoRepository.Deletar(apartamento);
                return "Predio apagado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String UpdatePredio(ApartamentoDto apartamentoDto)
        {
            try
            {
                Apartamento apartamento = _mapper.Map<Apartamento>(apartamentoDto);
                _apartamentoRepository.Update(apartamento);
                return "Predio atualizado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public IEnumerable<ApartamentoDto> ConsultarTodos()
        {
            IEnumerable<Apartamento> apartamento = _apartamentoRepository.apartamento;
            return _mapper.Map<ApartamentoDto[]>(apartamento);
        }
        public ApartamentoDto BusarPorId(int id)
        {
            Apartamento apartamento = new Apartamento();
            apartamento = _apartamentoRepository.findById(id);
            return _mapper.Map<ApartamentoDto>(apartamento);
        }
    }
}
