﻿using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentalContext>, IBrandDal
    {

    }
}