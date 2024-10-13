﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafTakipYonetim.Application.Cqrs.Commands.ExpenseRequestsAndResponses
{
    public class DeleteExpenseCommandResponse : IRequest<DeleteExpenseCommandRequest>
    {
        public string Message { get; set; }
    }
}
