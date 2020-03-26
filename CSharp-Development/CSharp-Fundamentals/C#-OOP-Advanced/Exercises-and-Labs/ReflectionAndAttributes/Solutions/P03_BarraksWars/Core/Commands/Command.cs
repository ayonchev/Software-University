using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            private set { unitFactory = value; }
        }

        public abstract string Execute();
    }
}
