﻿using MediatR;

namespace SaleProject.Application.Contracts.Checkings.Queries
{
    public class CheckingQueryHandler : IRequestHandler<CheckingQueryRequest, CheckingQueryResponse>
    {
        public Task<CheckingQueryResponse> Handle(CheckingQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CheckingQueryResponse());
        }
    }
}
