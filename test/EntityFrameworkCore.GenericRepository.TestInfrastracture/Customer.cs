﻿using System;
using System.Collections.Generic;
using EntityFrameworkCore.GenericRepository.Shared;

namespace EntityFrameworkCore.GenericRepository.TestInfrastracture
{
    public sealed class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public int CustomerNumber { get; set; }

        public Customer()
        {
            this.Addresses = new List<Address>();
        }
    }
}