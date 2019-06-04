﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.HttpJob.Agent.MysqlConsole.Config
{
    public sealed class MysqlConsoleServiceConfigurer
    {
        private readonly MySqlStorageOptions options;

        internal MysqlConsoleServiceConfigurer(MySqlStorageOptions options)
        {
            this.options = options;
        }

        public MysqlConsoleServiceConfigurer TablePrefix(string prefix)
        {
            options.TablePrefix = prefix;
            return this;
        }
        public MysqlConsoleServiceConfigurer DbConnectionString(string db)
        {
            options.DbConnectionString = db;
            return this;
        }
    }
}
