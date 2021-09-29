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
    public class CondominioService : ICondominioService
    {
        private readonly ICondominioRepository _condominioRepository;
        IMapper _mapper;
        public CondominioService(ICondominioRepository condominioRepository, IMapper mapper)
        {
            _condominioRepository = condominioRepository;
            _mapper = mapper;
        }



        public String SalvarCondominio(CondominioDto condominioDto)
        {
            try { 
            
                Condominio cond = _mapper.Map<Condominio>(condominioDto);
                _condominioRepository.Salvar(cond);
                return "Salvo com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }

        }

        public String DeletarCondominio(CondominioDto condominioDto)
        {
            try
            {

                Condominio cond = _mapper.Map<Condominio>(condominioDto);
                _condominioRepository.Deletar(cond);
                return "Condomínio apagado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }

        }

        public String UpdateCondominio(CondominioDto condominioDto)
        {
            try
            {

                Condominio cond = _mapper.Map<Condominio>(condominioDto);
                _condominioRepository.Update(cond);
                return "Condomínio atualizado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }


        public IEnumerable<CondominioDto> ConsultarTodos()
        {
            IEnumerable<Condominio> condominio = _condominioRepository.condominio;
            return _mapper.Map<CondominioDto[]>(condominio);
        }

        public CondominioDto BusarPorId(int id)
        {
            Condominio condominio = new Condominio();
            condominio = _condominioRepository.findById(id);
            return _mapper.Map<CondominioDto>(condominio);
        }
    }
}
