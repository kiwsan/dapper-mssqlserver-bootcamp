﻿using Domain.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Uow
{
    public interface IUnitOfWork : IDisposable
    {

        IProductRepository ProductRepository { get; }

        ICustomerRepository CustomerRepository { get; }

        IOrderRepository OrderRepository { get; }

        void Commit();

    }
}
