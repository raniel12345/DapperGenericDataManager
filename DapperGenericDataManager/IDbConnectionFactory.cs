﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DapperGenericDataManager
{
    public interface IDbConnectionFactory
    {
        DbConnection CreateConnection();
    }
}
