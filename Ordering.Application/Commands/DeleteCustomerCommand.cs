﻿using MediatR;

namespace Ordering.Application.Commands
{
    public class DeleteCustomerCommand : IRequest<string>
    {
        public Int64 Id { get; private set; }

        public DeleteCustomerCommand(Int64 Id)
        {
            this.Id = Id;
        }
    }
}