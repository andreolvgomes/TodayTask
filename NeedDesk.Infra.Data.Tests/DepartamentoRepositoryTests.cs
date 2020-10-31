﻿using NeedDesk.Domain.Interfaces.Repositories;
using NeedDesk.Domain.Models;
using NeedDesk.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NeedDesk.Infra.Data.Tests
{
    public class DepartamentoRepositoryTests
    {
        [Fact]
        public void CrudTest()
        {
            try
            {
                IDepartamentoRepository departamentoRepository = new DepartamentoRepository();

                // test insert
                var id = (Int64)departamentoRepository.Insert(NewDepartamento());
                Assert.True(id > 0);

                // test get by id
                Departamento cliente = departamentoRepository.FindById(id);
                Assert.True(cliente != null);

                // test update
                cliente.CreateAt = DateTime.Now;
                var rowscuccess = departamentoRepository.Update(cliente);
                Assert.True(rowscuccess > 0);

                // test delete
                departamentoRepository.Delete(cliente);

                for (int i = 1; i <= 5; i++)
                    departamentoRepository.Insert(NewDepartamento());

                var list = departamentoRepository.All("tenant_id > 0");
                Assert.True(list.Count() > 0);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private Departamento NewDepartamento()
        {
            return new Departamento()
            {
                Tenant_id = CreateTenant.Tenant_id(),
                Dep_descricao = Faker.Company.Name()
            };
        }
    }
}