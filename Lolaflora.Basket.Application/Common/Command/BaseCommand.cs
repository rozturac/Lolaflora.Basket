﻿using Lolaflora.Baskets.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lolaflora.Baskets.Application.Common.Command
{
    public class BaseCommand<TData> : ICommand, IRequest<GenericResult<TData>>
    {
        private readonly Guid _commandId;

        public BaseCommand(Guid commandId)
        {
            _commandId = commandId;
        }

        public BaseCommand()
        {
            _commandId = Guid.NewGuid();
        }
    }

    public interface ICommand
    {

    }
}
