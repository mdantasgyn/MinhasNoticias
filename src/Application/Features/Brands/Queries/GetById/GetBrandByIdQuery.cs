﻿using AutoMapper;
using MinhasNoticias.Application.Interfaces.Repositories;
using MinhasNoticias.Domain.Entities.Catalog;
using MinhasNoticias.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MinhasNoticias.Application.Features.Brands.Queries.GetById
{
    public class GetBrandByIdQuery : IRequest<Result<GetBrandByIdResponse>>
    {
        public int Id { get; set; }
    }

    internal class GetProductByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Result<GetBrandByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetBrandByIdResponse>> Handle(GetBrandByIdQuery query, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(query.Id);
            var mappedBrand = _mapper.Map<GetBrandByIdResponse>(brand);
            return await Result<GetBrandByIdResponse>.SuccessAsync(mappedBrand);
        }
    }
}