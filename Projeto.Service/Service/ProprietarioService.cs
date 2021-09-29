using AutoMapper;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Dto;
using Projeto.Model.Model;
using Projeto.Service.Interface;
using System;
using System.Collections.Generic;

namespace Projeto.Service.Service
{
    public class ProprietarioService : IProprietarioService
    {
        private readonly IProprietarioRepository _proprietarioRepository;
        IMapper _mapper;

        public ProprietarioService(IProprietarioRepository proprietarioRepository, IMapper mapper)
        {
            _mapper = mapper;
            _proprietarioRepository = proprietarioRepository;
        }


        public String SalvarProprietario(ProprietarioDto proprietarioDto)
        {
            try
            {
                Proprietario proprietario = _mapper.Map<Proprietario>(proprietarioDto);
                _proprietarioRepository.Salvar(proprietario);
                return "Salvo com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String DeletarProprietario(ProprietarioDto proprietarioDto)
        {
            try
            {
                Proprietario proprietario = _mapper.Map<Proprietario>(proprietarioDto);
                _proprietarioRepository.Deletar(proprietario);
                return "Predio apagado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public String UpdateProprietario(ProprietarioDto proprietarioDto)
        {
            try
            {
                Proprietario proprietario = _mapper.Map<Proprietario>(proprietarioDto);
                _proprietarioRepository.Update(proprietario);
                return "Predio atualizado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public IEnumerable<ProprietarioDto> ConsultarTodos()
        {
            IEnumerable<Proprietario> proprietario = _proprietarioRepository.proprietario;
            return _mapper.Map<ProprietarioDto[]>(proprietario);
        }
        public ProprietarioDto BusarPorId(int id)
        {
            Proprietario proprietario = new Proprietario();
            proprietario = _proprietarioRepository.findById(id);
            return _mapper.Map<ProprietarioDto>(proprietario);
        }
    }
}
