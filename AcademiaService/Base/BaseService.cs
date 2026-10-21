using System;
using System.Collections.Generic;
using System.Text;
using AcademiaDomain.Base;
using AcademiaRepository.Base;
using AutoMapper;
using FluentValidation;

//instalamos o automapper para podermos mapear os objetos do banco de dados para os objetos do nosso projeto
//instalamos o fluent validation para podermos validar os objetos do nosso projeto
namespace AcademiaService.Base
{
    /* 
        Classe BaseService: Aqui centralizo toda a regra de negócio e os fluxos de CRUD.
        Basicamente, ela evita que eu repita código em todos os serviços específicos (Aluno, Treino, etc.).

        Injeção: Recebo o repositório genérico para mexer no banco e o IMapper para converter os DTOs.
        Validação: O método Validate usa o FluentValidation para barrar dados errados antes de irem pro banco.
        Create: Pega os dados da tela, converte pra entidade do domínio, valida, salva no PostgreSQL e devolve a resposta formatada.
 */
    public class BaseService<TypeEntity> : IBaseService<TypeEntity> where TypeEntity : IBaseEntity
        {
            private readonly IBaseRepository<TypeEntity> _baseRepository;
            private readonly IMapper _mapper;

            public BaseService(IBaseRepository<TypeEntity> baseRepository, IMapper mapper)
            {
                _baseRepository = baseRepository;
                _mapper = mapper;
            }

            private void Validate(TypeEntity obj, AbstractValidator<TypeEntity> validator)
            {
                validator.ValidateAndThrow(obj);
            }
            public TypeOutPutModel Create<TypeInputModel, TypeOutPutModel, TypeValidator>(TypeEntity entity) where TypeInputModel : class where TypeOutPutModel : class where TypeValidator : FluentValidation.AbstractValidator<TypeEntity>
            {
                var e = _mapper.Map<TypeEntity>(entity);
                Validate(e, Activator.CreateInstance<TypeValidator>());
                _baseRepository.Create(e);
                var outputModel = _mapper.Map<TypeOutPutModel>(e);
                return outputModel;
            }

            public TypeOutPutModel ReadById<TypeOutPutModel>(int id) where TypeOutPutModel : class
            {
                throw new NotImplementedException();
            }

            public IEnumerable<TypeOutPutModel> ReadAll<TypeOutPutModel>() where TypeOutPutModel : class
            {
                throw new NotImplementedException();
            }

            public TypeOutPutModel Update<TypeInputModel, TypeOutPutModel, TypeValidator>(TypeEntity entity) where TypeInputModel : class where TypeOutPutModel : class where TypeValidator : FluentValidation.AbstractValidator<TypeEntity>
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }
        }
}
